using System;
using System.Text;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Domain;

namespace Tests.Reproduce
{
	public class GithubIssue3710
	{
		[U]
		public void CanDeserializeTermsAggregation()
		{
			var json = @"{
  ""took"" : 2,
  ""timed_out"" : false,
  ""_shards"" : {
    ""total"" : 3,
    ""successful"" : 3,
    ""skipped"" : 0,
    ""failed"" : 0
  },
  ""hits"" : {
    ""total"" : {
      ""value"" : 10000,
      ""relation"" : ""gte""
    },
    ""max_score"" : null,
    ""hits"" : [ ]
  },
  ""aggregations"" : {
    ""lterms#test_agg"" : {
      ""doc_count_error_upper_bound"" : 0,
      ""sum_other_doc_count"" : 0,
      ""buckets"" : [
        {
          ""key"" : 0,
          ""doc_count"" : 752550
        },
        {
          ""key"" : 1,
          ""doc_count"" : 128339
        },
        {
          ""key"" : 2,
          ""doc_count"" : 5826
        }
      ]
    }
  }
}";

			var bytes = Encoding.UTF8.GetBytes(json);

			var pool = new SingleNodeConnectionPool(new Uri("http://localhost:9200"));
			var connectionSettings = new ConnectionSettings(pool, new InMemoryConnection(bytes));
			var client = new ElasticClient(connectionSettings);

			var searchResponse = client.Search<Project>(s => s
				.Size(0)
				.Index("issue")
				.Aggregations(q => q
					.Terms("test_agg", t => t
						.Field(f => f.Type)))
			);

			var buckets = searchResponse.Aggregations.Terms("test_agg").Buckets;
			buckets.Should().NotBeNull().And.HaveCount(3);
		}
	}
}
