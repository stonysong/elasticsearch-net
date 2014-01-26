﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Nest;
using Newtonsoft.Json.Converters;
using Nest.Resolvers.Converters;
using Nest.Tests.MockData.Domain;

namespace Nest.Tests.Unit.Core.Template
{
	[TestFixture]
	public class PutWarmerRequestTests : BaseJsonTests
	{

		[Test]
		public void PathWithType()
		{
			var result = this._client.PutWarmer(wd => wd
				.Type<ElasticSearchProject>()
				.Name("warmer_pathwithtype")
				.Search<ElasticSearchProject>(s => s));
			Assert.NotNull(result, "PutWarmer result should not be null");
			var status = result.ConnectionStatus;
			StringAssert.Contains("USING NEST IN MEMORY CONNECTION", result.ConnectionStatus.Result);
			StringAssert.EndsWith("/nest_test_data/elasticsearchprojects/_warmer/warmer_pathwithtype", status.RequestUrl);
			StringAssert.AreEqualIgnoringCase("PUT", status.RequestMethod);
		}

		[Test]
		public void PathWithDynamic()
		{
			var result = this._client.PutWarmer(wd=> wd
				.Name("warmer_pathwithdynamic")
				.Search<dynamic>(s => s));
			Assert.NotNull(result, "PutWarmer result should not be null");
			var status = result.ConnectionStatus;
			StringAssert.Contains("USING NEST IN MEMORY CONNECTION", result.ConnectionStatus.Result);
			StringAssert.EndsWith("/nest_test_data/_warmer/warmer_pathwithdynamic", status.RequestUrl);
			StringAssert.AreEqualIgnoringCase("PUT", status.RequestMethod);
		}

		[Test]
		public void PathWithAllIndices()
		{
			var result = this._client.PutWarmer(wd => wd
				.AllIndices()
				.Name("warmer_pathwithallindices")
				.Search<dynamic>(s => s));
			Assert.NotNull(result, "PutWarmer result should not be null");
			var status = result.ConnectionStatus;
			StringAssert.Contains("USING NEST IN MEMORY CONNECTION", result.ConnectionStatus.Result);
			StringAssert.EndsWith("/_all/_warmer/warmer_pathwithallindices", status.RequestUrl);
			StringAssert.AreEqualIgnoringCase("PUT", status.RequestMethod);
		}
	}
}
