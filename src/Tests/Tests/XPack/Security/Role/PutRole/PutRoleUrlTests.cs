﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Security.Role.PutRole
{
	public class PutRoleUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls() => await PUT("/_security/role/mpdreamz")
			.Fluent(c => c.Security.PutRole("mpdreamz"))
			.Request(c => c.Security.PutRole(new PutRoleRequest("mpdreamz")))
			.FluentAsync(c => c.Security.PutRoleAsync("mpdreamz"))
			.RequestAsync(c => c.Security.PutRoleAsync(new PutRoleRequest("mpdreamz")));
	}
}
