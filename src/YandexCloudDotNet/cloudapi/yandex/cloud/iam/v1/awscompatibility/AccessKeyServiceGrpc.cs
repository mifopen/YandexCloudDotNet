// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iam/v1/awscompatibility/access_key_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Iam.V1.Awscompatibility {
  /// <summary>
  /// A set of methods for managing access keys.
  /// </summary>
  internal static partial class AccessKeyService
  {
    static readonly string __ServiceName = "yandex.cloud.iam.v1.awscompatibility.AccessKeyService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeysRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse> __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeysResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_GetAccessKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey> __Marshaller_yandex_cloud_iam_v1_awscompatibility_AccessKey = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_CreateAccessKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse> __Marshaller_yandex_cloud_iam_v1_awscompatibility_CreateAccessKeyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_UpdateAccessKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_DeleteAccessKeyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest> __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeyOperationsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse> __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeyOperationsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeysRequest,
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeysResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey> __Method_Get = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_GetAccessKeyRequest,
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_AccessKey);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse> __Method_Create = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_CreateAccessKeyRequest,
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_CreateAccessKeyResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest, global::Yandex.Cloud.Operation.Operation> __Method_Update = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_UpdateAccessKeyRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_DeleteAccessKeyRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse> __Method_ListOperations = new grpc::Method<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest, global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeyOperationsRequest,
        __Marshaller_yandex_cloud_iam_v1_awscompatibility_ListAccessKeyOperationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKeyServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for AccessKeyService</summary>
    public partial class AccessKeyServiceClient : grpc::ClientBase<AccessKeyServiceClient>
    {
      /// <summary>Creates a new client for AccessKeyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AccessKeyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AccessKeyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AccessKeyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AccessKeyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AccessKeyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the list of access keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse List(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of access keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse List(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of access keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse> ListAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of access keys for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysResponse> ListAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeysRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Returns the specified access key.
      ///
      /// To get the list of available access keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey Get(global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified access key.
      ///
      /// To get the list of available access keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey Get(global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified access key.
      ///
      /// To get the list of available access keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey> GetAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified access key.
      ///
      /// To get the list of available access keys, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.AccessKey> GetAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.GetAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Creates an access key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse Create(global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an access key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse Create(global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Creates an access key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse> CreateAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates an access key for the specified service account.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyResponse> CreateAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.CreateAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Updates the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Updates the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.UpdateAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Deletes the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.DeleteAccessKeyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of operations for the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse ListOperations(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of operations for the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse ListOperations(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of operations for the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of operations for the specified access key.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Iam.V1.Awscompatibility.ListAccessKeyOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AccessKeyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AccessKeyServiceClient(configuration);
      }
    }

  }
}
#endregion
