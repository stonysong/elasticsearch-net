﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Indices.Monitoring.IndicesShardStores
{
	public class IndicesShardStoresUrlTests
	{
		[U] public async Task Urls()
		{
			await GET("/_shard_stores")
					.Fluent(c => c.Indices.ShardStores())
					.Request(c => c.Indices.ShardStores(new IndicesShardStoresRequest()))
					.FluentAsync(c => c.Indices.ShardStoresAsync())
					.RequestAsync(c => c.Indices.ShardStoresAsync(new IndicesShardStoresRequest()))
				;

			var index = "index1,index2";
			await GET("/index1%2Cindex2/_shard_stores")
					.Fluent(c => c.Indices.ShardStores(s => s.Index(index)))
					.Request(c => c.Indices.ShardStores(new IndicesShardStoresRequest(index)))
					.FluentAsync(c => c.Indices.ShardStoresAsync(s => s.Index(index)))
					.RequestAsync(c => c.Indices.ShardStoresAsync(new IndicesShardStoresRequest(index)))
				;
		}
	}
}
