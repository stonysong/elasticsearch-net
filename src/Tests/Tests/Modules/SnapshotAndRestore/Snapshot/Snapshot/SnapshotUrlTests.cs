﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using Nest;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Modules.SnapshotAndRestore.Snapshot.Snapshot
{
	public class SnapshotUrlTests
	{
		[U] public async Task Urls()
		{
			var repository = "repos";
			var snapshot = "snap";

			await PUT($"/_snapshot/{repository}/{snapshot}")
					.Fluent(c => c.Snapshot.Snapshot(repository, snapshot))
					.Request(c => c.Snapshot.Snapshot(new SnapshotRequest(repository, snapshot)))
					.FluentAsync(c => c.Snapshot.SnapshotAsync(repository, snapshot))
					.RequestAsync(c => c.Snapshot.SnapshotAsync(new SnapshotRequest(repository, snapshot)))
				;


			await ExpectUrl(HttpMethod.PUT, $"/_snapshot/{repository}/{snapshot}?pretty=true", s => s.PrettyJson())
				.Fluent(c => c.Snapshot.Snapshot(repository, snapshot))
				.Request(c => c.Snapshot.Snapshot(new SnapshotRequest(repository, snapshot)))
				.FluentAsync(c => c.Snapshot.SnapshotAsync(repository, snapshot))
				.RequestAsync(c => c.Snapshot.SnapshotAsync(new SnapshotRequest(repository, snapshot)));

			await ExpectUrl(HttpMethod.PUT, $"/_snapshot/{repository}/{snapshot}?pretty=true", s => s.PrettyJson())
				.Fluent(c => c.Snapshot.Snapshot(repository, snapshot, s => s.Pretty()))
				.Request(c => c.Snapshot.Snapshot(new SnapshotRequest(repository, snapshot) { Pretty = true }))
				.FluentAsync(c => c.Snapshot.SnapshotAsync(repository, snapshot, s => s.Pretty()))
				.RequestAsync(c => c.Snapshot.SnapshotAsync(new SnapshotRequest(repository, snapshot) { Pretty = true }));
		}
	}
}
