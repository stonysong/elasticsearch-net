using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.MigrationApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.MigrationApi
{
	///<summary>
	/// Logically groups all Migration API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Migration"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class MigrationNamespace : NamespacedClientProxy
	{
		internal MigrationNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IDeprecationInfoRequest"/>
		public DeprecationInfoResponse DeprecationInfo(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null) => DeprecationInfo(selector.InvokeOrDefault(new DeprecationInfoDescriptor()));
		///<inheritdoc cref = "IDeprecationInfoRequest"/>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(Func<DeprecationInfoDescriptor, IDeprecationInfoRequest> selector = null, CancellationToken ct = default) => DeprecationInfoAsync(selector.InvokeOrDefault(new DeprecationInfoDescriptor()), ct: ct);
		///<inheritdoc cref = "IDeprecationInfoRequest"/>
		public DeprecationInfoResponse DeprecationInfo(IDeprecationInfoRequest request) => DoRequest<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeprecationInfoRequest"/>
		public Task<DeprecationInfoResponse> DeprecationInfoAsync(IDeprecationInfoRequest request, CancellationToken ct = default) => DoRequestAsync<IDeprecationInfoRequest, DeprecationInfoResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IMigrationAssistanceRequest"/>
		public MigrationAssistanceResponse Assistance(Indices index = null, Func<MigrationAssistanceDescriptor, IMigrationAssistanceRequest> selector = null) => Assistance(selector.InvokeOrDefault(new MigrationAssistanceDescriptor().Index(index: index)));
		///<inheritdoc cref = "IMigrationAssistanceRequest"/>
		public Task<MigrationAssistanceResponse> AssistanceAsync(Indices index = null, Func<MigrationAssistanceDescriptor, IMigrationAssistanceRequest> selector = null, CancellationToken ct = default) => AssistanceAsync(selector.InvokeOrDefault(new MigrationAssistanceDescriptor().Index(index: index)), ct: ct);
		///<inheritdoc cref = "IMigrationAssistanceRequest"/>
		public MigrationAssistanceResponse Assistance(IMigrationAssistanceRequest request) => DoRequest<IMigrationAssistanceRequest, MigrationAssistanceResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IMigrationAssistanceRequest"/>
		public Task<MigrationAssistanceResponse> AssistanceAsync(IMigrationAssistanceRequest request, CancellationToken ct = default) => DoRequestAsync<IMigrationAssistanceRequest, MigrationAssistanceResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IMigrationUpgradeRequest"/>
		public MigrationUpgradeResponse Upgrade(IndexName index, Func<MigrationUpgradeDescriptor, IMigrationUpgradeRequest> selector = null) => Upgrade(selector.InvokeOrDefault(new MigrationUpgradeDescriptor(index: index)));
		///<inheritdoc cref = "IMigrationUpgradeRequest"/>
		public Task<MigrationUpgradeResponse> UpgradeAsync(IndexName index, Func<MigrationUpgradeDescriptor, IMigrationUpgradeRequest> selector = null, CancellationToken ct = default) => UpgradeAsync(selector.InvokeOrDefault(new MigrationUpgradeDescriptor(index: index)), ct: ct);
		///<inheritdoc cref = "IMigrationUpgradeRequest"/>
		public MigrationUpgradeResponse Upgrade(IMigrationUpgradeRequest request) => DoRequest<IMigrationUpgradeRequest, MigrationUpgradeResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IMigrationUpgradeRequest"/>
		public Task<MigrationUpgradeResponse> UpgradeAsync(IMigrationUpgradeRequest request, CancellationToken ct = default) => DoRequestAsync<IMigrationUpgradeRequest, MigrationUpgradeResponse>(request, request.RequestParameters, ct);
	}
}