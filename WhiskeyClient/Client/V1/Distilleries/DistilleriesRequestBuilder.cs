// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
using Whiskey.Client.Models;
namespace Whiskey.Client.V1.Distilleries {
    /// <summary>
    /// Builds and executes requests for operations under \v1\distilleries
    /// </summary>
    public class DistilleriesRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DistilleriesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DistilleriesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/distilleries", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DistilleriesRequestBuilder and sets the default values.z
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DistilleriesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/distilleries", rawUrl) {
        }
        /// <summary>
        /// Sample request:    GET api/v1/distilleries
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<Distillery>?> GetAsync(Action<RequestConfiguration<DistilleriesRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<Distillery>> GetAsync(Action<RequestConfiguration<DistilleriesRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
          
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            try {
            var collectionResult = await RequestAdapter.SendCollectionAsync<Distillery>(requestInfo, Distillery.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
            } catch (Exception ex) {
                Console.WriteLine($"ERROR: {ex.Message}");
                throw;
            }   
        }
        /// <summary>
        /// Sample request:    GET api/v1/distilleries
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DistilleriesRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DistilleriesRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "text/plain;q=0.9");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public DistilleriesRequestBuilder WithUrl(string rawUrl) {
            return new DistilleriesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Sample request:    GET api/v1/distilleries
        /// </summary>
        public class DistilleriesRequestBuilderGetQueryParameters {
            [QueryParameter("pageNumber")]
            public int? PageNumber { get; set; }
            [QueryParameter("pageSize")]
            public int? PageSize { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class DistilleriesRequestBuilderGetRequestConfiguration : RequestConfiguration<DistilleriesRequestBuilderGetQueryParameters> {
        }
    }
}
