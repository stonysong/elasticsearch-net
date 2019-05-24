using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.SqlApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.SqlApi
{
	///<summary>
	/// Logically groups all Sql API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Sql"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class SqlNamespace : NamespacedClientProxy
	{
		internal SqlNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IClearSqlCursorRequest"/>
		public ClearSqlCursorResponse ClearSqlCursor(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IClearSqlCursorRequest"/>
		public Task<ClearSqlCursorResponse> ClearSqlCursorAsync(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IClearSqlCursorRequest"/>
		public ClearSqlCursorResponse ClearSqlCursor(IClearSqlCursorRequest request) => DoRequest<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IClearSqlCursorRequest"/>
		public Task<ClearSqlCursorResponse> ClearSqlCursorAsync(IClearSqlCursorRequest request, CancellationToken ct = default) => DoRequestAsync<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IQuerySqlRequest"/>
		public QuerySqlResponse QuerySql(Func<QuerySqlDescriptor, IQuerySqlRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IQuerySqlRequest"/>
		public Task<QuerySqlResponse> QuerySqlAsync(Func<QuerySqlDescriptor, IQuerySqlRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IQuerySqlRequest"/>
		public QuerySqlResponse QuerySql(IQuerySqlRequest request) => DoRequest<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IQuerySqlRequest"/>
		public Task<QuerySqlResponse> QuerySqlAsync(IQuerySqlRequest request, CancellationToken ct = default) => DoRequestAsync<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ITranslateSqlRequest"/>
		public TranslateSqlResponse TranslateSql(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "ITranslateSqlRequest"/>
		public Task<TranslateSqlResponse> TranslateSqlAsync(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ITranslateSqlRequest"/>
		public TranslateSqlResponse TranslateSql(ITranslateSqlRequest request) => DoRequest<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ITranslateSqlRequest"/>
		public Task<TranslateSqlResponse> TranslateSqlAsync(ITranslateSqlRequest request, CancellationToken ct = default) => DoRequestAsync<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters, ct);
	}
}