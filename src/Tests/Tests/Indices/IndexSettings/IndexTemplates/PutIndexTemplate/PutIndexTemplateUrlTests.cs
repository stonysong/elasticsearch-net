﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Indices.IndexSettings.IndexTemplates.PutIndexTemplate
{
	public class PutTemplateUrlTests
	{
		[U] public async Task Urls()
		{
			var name = "temp";
			await PUT($"/_template/{name}")
					.Fluent(c => c.Indices.PutIndexTemplate(name, p => p))
					.Request(c => c.Indices.PutIndexTemplate(new PutIndexTemplateRequest(name)))
					.FluentAsync(c => c.Indices.PutIndexTemplateAsync(name, p => p))
					.RequestAsync(c => c.Indices.PutIndexTemplateAsync(new PutIndexTemplateRequest(name)))
				;
		}
	}
}
