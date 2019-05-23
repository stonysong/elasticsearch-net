﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.XPack.Security.Role.GetRole
{
	public class GetRoleUrlTests : UrlTestsBase
	{
		[U] public override async Task Urls()
		{
			await GET("/_security/role")
					.Fluent(c => c.Security.GetRole())
					.Request(c => c.Security.GetRole(new GetRoleRequest()))
					.FluentAsync(c => c.Security.GetRoleAsync())
					.RequestAsync(c => c.Security.GetRoleAsync(new GetRoleRequest()))
				;

			var users = "admin,user,nest_user";
			await GET($"/_security/role/{EscapeUriString(users)}")
					.Fluent(c => c.Security.GetRole(f => f.Name(users)))
					.Request(c => c.Security.GetRole(new GetRoleRequest(users)))
					.FluentAsync(c => c.Security.GetRoleAsync(f => f.Name(users)))
					.RequestAsync(c => c.Security.GetRoleAsync(new GetRoleRequest(users)))
				;
		}
	}
}
