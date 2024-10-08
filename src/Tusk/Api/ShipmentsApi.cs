/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Net.Http;
using Tusk.Client;
using Tusk.Model;

namespace Tusk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a Shipment by ID
        /// </summary>
        /// <remarks>
        /// Returns a single Shipment
        /// </remarks>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <returns>Shipment</returns>
        Shipment GetaShipmentbyID(int shipmentId);

        /// <summary>
        /// Get a Shipment by ID
        /// </summary>
        /// <remarks>
        /// Returns a single Shipment
        /// </remarks>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> GetaShipmentbyIDWithHttpInfo(int shipmentId);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a Shipment by ID
        /// </summary>
        /// <remarks>
        /// Returns a single Shipment
        /// </remarks>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Shipment</returns>
        System.Threading.Tasks.Task<Shipment> GetaShipmentbyIDAsync(int shipmentId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Get a Shipment by ID
        /// </summary>
        /// <remarks>
        /// Returns a single Shipment
        /// </remarks>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Shipment>> GetaShipmentbyIDWithHttpInfoAsync(int shipmentId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApi : IShipmentsApiSync, IShipmentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShipmentsApi : IDisposable, IShipmentsApi
    {
        private Tusk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <returns></returns>
        public ShipmentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ShipmentsApi(string basePath)
        {
            this.Configuration = Tusk.Client.ReadableConfiguration.MergeConfigurations(
                Tusk.Client.GlobalReadableConfiguration.Instance,
                new Tusk.Client.ReadableConfiguration { BasePath = basePath }
            );
            this.ApiClient = new Tusk.Client.ApiClient(this.Configuration.BasePath);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Tusk.Client.ReadableConfiguration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class using Configuration object.
        /// **IMPORTANT** This will also create an instance of HttpClient, which is less than ideal.
        /// It's better to reuse the <see href="https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net">HttpClient and HttpClientHandler</see>.
        /// </summary>
        /// <param name="readableConfiguration">An instance of Configuration.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        public ShipmentsApi(Tusk.Client.ReadableConfiguration readableConfiguration)
        {
            if (readableConfiguration == null) throw new ArgumentNullException("readableConfiguration");

            this.Configuration = Tusk.Client.ReadableConfiguration.MergeConfigurations(
                Tusk.Client.GlobalReadableConfiguration.Instance,
                readableConfiguration
            );
            this.ApiClient = new Tusk.Client.ApiClient(this.Configuration.BasePath);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Tusk.Client.ReadableConfiguration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ShipmentsApi(HttpClient client, HttpClientHandler handler = null) : this(client, (string)null, handler)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="basePath">The target service's base path in URL format.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ShipmentsApi(HttpClient client, string basePath, HttpClientHandler handler = null)
        {
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Tusk.Client.ReadableConfiguration.MergeConfigurations(
                Tusk.Client.GlobalReadableConfiguration.Instance,
                new Tusk.Client.ReadableConfiguration { BasePath = basePath }
            );
            this.ApiClient = new Tusk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client =  this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            this.ExceptionFactory = Tusk.Client.ReadableConfiguration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class using Configuration object.
        /// </summary>
        /// <param name="client">An instance of HttpClient.</param>
        /// <param name="readableConfiguration">An instance of Configuration.</param>
        /// <param name="handler">An optional instance of HttpClientHandler that is used by HttpClient.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <returns></returns>
        /// <remarks>
        /// Some configuration settings will not be applied without passing an HttpClientHandler.
        /// The features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings.
        /// </remarks>
        public ShipmentsApi(HttpClient client, Tusk.Client.ReadableConfiguration readableConfiguration, HttpClientHandler handler = null)
        {
            if (readableConfiguration == null) throw new ArgumentNullException("readableConfiguration");
            if (client == null) throw new ArgumentNullException("client");

            this.Configuration = Tusk.Client.ReadableConfiguration.MergeConfigurations(
                Tusk.Client.GlobalReadableConfiguration.Instance,
                readableConfiguration
            );
            this.ApiClient = new Tusk.Client.ApiClient(client, this.Configuration.BasePath, handler);
            this.Client = this.ApiClient;
            this.AsynchronousClient = this.ApiClient;
            ExceptionFactory = Tusk.Client.ReadableConfiguration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ShipmentsApi(Tusk.Client.ISynchronousClient client, Tusk.Client.IAsynchronousClient asyncClient, Tusk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Tusk.Client.ReadableConfiguration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Disposes resources if they were created by us
        /// </summary>
        public void Dispose()
        {
            this.ApiClient?.Dispose();
        }

        /// <summary>
        /// Holds the ApiClient if created
        /// </summary>
        public Tusk.Client.ApiClient ApiClient { get; set; } = null;

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Tusk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Tusk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Tusk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Tusk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get a Shipment by ID Returns a single Shipment
        /// </summary>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <returns>Shipment</returns>
        public Shipment GetaShipmentbyID(int shipmentId)
        {
            Tusk.Client.ApiResponse<Shipment> localVarResponse = GetaShipmentbyIDWithHttpInfo(shipmentId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Shipment by ID Returns a single Shipment
        /// </summary>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <returns>ApiResponse of Shipment</returns>
        public Tusk.Client.ApiResponse<Shipment> GetaShipmentbyIDWithHttpInfo(int shipmentId)
        {
            Tusk.Client.RequestOptions localVarRequestOptions = new Tusk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Tusk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tusk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("shipment_id", Tusk.Client.ClientUtils.ParameterToString(shipmentId)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Shipment>("/v1/shipment/{shipment_id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetaShipmentbyID", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a Shipment by ID Returns a single Shipment
        /// </summary>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Shipment</returns>
        public async System.Threading.Tasks.Task<Shipment> GetaShipmentbyIDAsync(int shipmentId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Tusk.Client.ApiResponse<Shipment> localVarResponse = await GetaShipmentbyIDWithHttpInfoAsync(shipmentId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Shipment by ID Returns a single Shipment
        /// </summary>
        /// <exception cref="Tusk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">ID of Shipment to return</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        public async System.Threading.Tasks.Task<Tusk.Client.ApiResponse<Shipment>> GetaShipmentbyIDWithHttpInfoAsync(int shipmentId, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Tusk.Client.RequestOptions localVarRequestOptions = new Tusk.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Tusk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Tusk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("shipment_id", Tusk.Client.ClientUtils.ParameterToString(shipmentId)); // path parameter

            // authentication (ApiKeyAuth) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarRequestOptions.HeaderParameters.Add("x-api-key", this.Configuration.GetApiKeyWithPrefix("x-api-key"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Shipment>("/v1/shipment/{shipment_id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetaShipmentbyID", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
