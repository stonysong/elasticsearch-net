using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.IngestApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.IngestApi
{
	///<summary>
	/// Logically groups all Ingest API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Ingest"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class IngestNamespace : NamespacedClientProxy
	{
		internal IngestNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "IDeletePipelineRequest"/>
		public DeletePipelineResponse DeletePipeline(Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeletePipelineRequest"/>
		public Task<DeletePipelineResponse> DeletePipelineAsync(Id id, Func<DeletePipelineDescriptor, IDeletePipelineRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IDeletePipelineRequest"/>
		public DeletePipelineResponse DeletePipeline(IDeletePipelineRequest request) => DoRequest<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IDeletePipelineRequest"/>
		public Task<DeletePipelineResponse> DeletePipelineAsync(IDeletePipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IDeletePipelineRequest, DeletePipelineResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetPipelineRequest"/>
		public GetPipelineResponse GetPipeline(Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetPipelineRequest"/>
		public Task<GetPipelineResponse> GetPipelineAsync(Func<GetPipelineDescriptor, IGetPipelineRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetPipelineRequest"/>
		public GetPipelineResponse GetPipeline(IGetPipelineRequest request) => DoRequest<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetPipelineRequest"/>
		public Task<GetPipelineResponse> GetPipelineAsync(IGetPipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IGetPipelineRequest, GetPipelineResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGrokProcessorPatternsRequest"/>
		public GrokProcessorPatternsResponse GrokProcessorPatterns(Func<GrokProcessorPatternsDescriptor, IGrokProcessorPatternsRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGrokProcessorPatternsRequest"/>
		public Task<GrokProcessorPatternsResponse> GrokProcessorPatternsAsync(Func<GrokProcessorPatternsDescriptor, IGrokProcessorPatternsRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGrokProcessorPatternsRequest"/>
		public GrokProcessorPatternsResponse GrokProcessorPatterns(IGrokProcessorPatternsRequest request) => DoRequest<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGrokProcessorPatternsRequest"/>
		public Task<GrokProcessorPatternsResponse> GrokProcessorPatternsAsync(IGrokProcessorPatternsRequest request, CancellationToken ct = default) => DoRequestAsync<IGrokProcessorPatternsRequest, GrokProcessorPatternsResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IPutPipelineRequest"/>
		public PutPipelineResponse PutPipeline(Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutPipelineRequest"/>
		public Task<PutPipelineResponse> PutPipelineAsync(Id id, Func<PutPipelineDescriptor, IPutPipelineRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IPutPipelineRequest"/>
		public PutPipelineResponse PutPipeline(IPutPipelineRequest request) => DoRequest<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IPutPipelineRequest"/>
		public Task<PutPipelineResponse> PutPipelineAsync(IPutPipelineRequest request, CancellationToken ct = default) => DoRequestAsync<IPutPipelineRequest, PutPipelineResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "ISimulatePipelineRequest"/>
		public SimulatePipelineResponse SimulatePipeline(Func<SimulatePipelineDescriptor, ISimulatePipelineRequest> selector) => throw new NotImplementedException();
		///<inheritdoc cref = "ISimulatePipelineRequest"/>
		public Task<SimulatePipelineResponse> SimulatePipelineAsync(Func<SimulatePipelineDescriptor, ISimulatePipelineRequest> selector, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ISimulatePipelineRequest"/>
		public SimulatePipelineResponse SimulatePipeline(ISimulatePipelineRequest request) => DoRequest<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ISimulatePipelineRequest"/>
		public Task<SimulatePipelineResponse> SimulatePipelineAsync(ISimulatePipelineRequest request, CancellationToken ct = default) => DoRequestAsync<ISimulatePipelineRequest, SimulatePipelineResponse>(request, request.RequestParameters, ct);
	}
}