﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;
using static Nest.Infer;

namespace Tests.Cluster.ClusterState
{
	public class ClusterStateUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_cluster/state")
					.Fluent(c => c.Cluster.State(AllIndices))
					.Request(c => c.Cluster.State(new ClusterStateRequest()))
					.FluentAsync(c => c.Cluster.StateAsync(AllIndices))
					.RequestAsync(c => c.Cluster.StateAsync(new ClusterStateRequest()))
				;

			var metrics = ClusterStateMetric.MasterNode | ClusterStateMetric.Metadata;
			await GET("/_cluster/state/metadata%2Cmaster_node")
					.Fluent(c => c.Cluster.State(AllIndices, p => p.Metric(metrics)))
					.Request(c => c.Cluster.State(new ClusterStateRequest(metrics)))
					.FluentAsync(c => c.Cluster.StateAsync(AllIndices, p => p.Metric(metrics)))
					.RequestAsync(c => c.Cluster.StateAsync(new ClusterStateRequest(metrics)))
				;

			metrics |= ClusterStateMetric.All;
			var index = "indexx";
			await GET($"/_cluster/state/_all/{index}")
					.Fluent(c => c.Cluster.State(index, p => p.Metric(metrics)))
					.Request(c => c.Cluster.State(new ClusterStateRequest(metrics, index)))
					.FluentAsync(c => c.Cluster.StateAsync(index, p => p.Metric(metrics)))
					.RequestAsync(c => c.Cluster.StateAsync(new ClusterStateRequest(metrics, index)))
				;
		}
	}
}
