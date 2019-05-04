// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iam/v1/api_key_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Iam.V1 {
  /// <summary>
  /// A set of methods for managing API keys.
  /// </summary>
  internal static partial class ApiKeyService
  {
    static readonly string __ServiceName = "yandex.cloud.iam.v1.ApiKeyService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.ListApiKeysRequest> __Marshaller_yandex_cloud_iam_v1_ListApiKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.ListApiKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.ListApiKeysResponse> __Marshaller_yandex_cloud_iam_v1_ListApiKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.ListApiKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.GetApiKeyRequest> __Marshaller_yandex_cloud_iam_v1_GetApiKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.GetApiKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.ApiKey> __Marshaller_yandex_cloud_iam_v1_ApiKey = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.ApiKey.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest> __Marshaller_yandex_cloud_iam_v1_CreateApiKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse> __Marshaller_yandex_cloud_iam_v1_CreateApiKeyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest> __Marshaller_yandex_cloud_iam_v1_DeleteApiKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.ListApiKeysRequest, global::Yandex.Cloud.Iam.V1.ListApiKeysResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Iam.V1.ListApiKeysRequest, global::Yandex.Cloud.Iam.V1.ListApiKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_iam_v1_ListApiKeysRequest,
        __Marshaller_yandex_cloud_iam_v1_ListApiKeysResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.GetApiKeyRequest, global::Yandex.Cloud.Iam.V1.ApiKey> __Method_Get = new grpc::Method<global::Yandex.Cloud.Iam.V1.GetApiKeyRequest, global::Yandex.Cloud.Iam.V1.ApiKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_iam_v1_GetApiKeyRequest,
        __Marshaller_yandex_cloud_iam_v1_ApiKey);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest, global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse> __Method_Create = new grpc::Method<global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest, global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_iam_v1_CreateApiKeyRequest,
        __Marshaller_yandex_cloud_iam_v1_CreateApiKeyResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_iam_v1_DeleteApiKeyRequest,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Iam.V1.ApiKeyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ApiKeyService</summary>
    public partial class ApiKeyServiceClient : grpc::ClientBase<ApiKeyServiceClient>
    {
      /// <summary>Creates a new client for ApiKeyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ApiKeyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ApiKeyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ApiKeyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ApiKeyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ApiKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the list of API keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ListApiKeysResponse List(global::Yandex.Cloud.Iam.V1.ListApiKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of API keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ListApiKeysResponse List(global::Yandex.Cloud.Iam.V1.ListApiKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of API keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ListApiKeysResponse> ListAsync(global::Yandex.Cloud.Iam.V1.ListApiKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of API keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ListApiKeysResponse> ListAsync(global::Yandex.Cloud.Iam.V1.ListApiKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Returns the specified API key.
      ///
      /// To get the list of available API keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ApiKey Get(global::Yandex.Cloud.Iam.V1.GetApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified API key.
      ///
      /// To get the list of available API keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ApiKey Get(global::Yandex.Cloud.Iam.V1.GetApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified API key.
      ///
      /// To get the list of available API keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ApiKey> GetAsync(global::Yandex.Cloud.Iam.V1.GetApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified API key.
      ///
      /// To get the list of available API keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ApiKey> GetAsync(global::Yandex.Cloud.Iam.V1.GetApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Creates an API key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse Create(global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an API key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse Create(global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Creates an API key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse> CreateAsync(global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an API key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.CreateApiKeyResponse> CreateAsync(global::Yandex.Cloud.Iam.V1.CreateApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Deletes the specified API key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Delete(global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified API key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty Delete(global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified API key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAsync(global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified API key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAsync(global::Yandex.Cloud.Iam.V1.DeleteApiKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ApiKeyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ApiKeyServiceClient(configuration);
      }
    }

  }
}
#endregion