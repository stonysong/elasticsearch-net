﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;

namespace Tests.XPack.CrossClusterReplication.AutoFollow.GetAutoFollowPattern
{
	public class GetAutoFollowPatternUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			var name = "x";
			await UrlTester.GET($"/_ccr/auto_follow/{name}")
				.Fluent(c => c.CrossClusterReplication.GetAutoFollowPattern(d => d.Name(name)))
				.Request(c => c.CrossClusterReplication.GetAutoFollowPattern(new GetAutoFollowPatternRequest(name)))
				.FluentAsync(c => c.CrossClusterReplication.GetAutoFollowPatternAsync(d => d.Name(name)))
				.RequestAsync(c => c.CrossClusterReplication.GetAutoFollowPatternAsync(new GetAutoFollowPatternRequest(name)));

			await UrlTester.GET($"/_ccr/auto_follow")
				.Fluent(c => c.CrossClusterReplication.GetAutoFollowPattern(d => d))
				.Request(c => c.CrossClusterReplication.GetAutoFollowPattern(new GetAutoFollowPatternRequest()))
				.FluentAsync(c => c.CrossClusterReplication.GetAutoFollowPatternAsync(d => d))
				.RequestAsync(c => c.CrossClusterReplication.GetAutoFollowPatternAsync(new GetAutoFollowPatternRequest()));

		}
	}
}
