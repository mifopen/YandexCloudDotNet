// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/operation/operation_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Operation {
  /// <summary>
  /// A set of methods for managing operations for asynchronous API requests.
  /// </summary>
  internal static partial class OperationService
  {
    static readonly string __ServiceName = "yandex.cloud.operation.OperationService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.GetOperationRequest> __Marshaller_yandex_cloud_operation_GetOperationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.GetOperationRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.CancelOperationRequest> __Marshaller_yandex_cloud_operation_CancelOperationRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.CancelOperationRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Operation.GetOperationRequest, global::Yandex.Cloud.Operation.Operation> __Method_Get = new grpc::Method<global::Yandex.Cloud.Operation.GetOperationRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_operation_GetOperationRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Operation.CancelOperationRequest, global::Yandex.Cloud.Operation.Operation> __Method_Cancel = new grpc::Method<global::Yandex.Cloud.Operation.CancelOperationRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Cancel",
        __Marshaller_yandex_cloud_operation_CancelOperationRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Operation.OperationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OperationService</summary>
    public partial class OperationServiceClient : grpc::ClientBase<OperationServiceClient>
    {
      /// <summary>Creates a new client for OperationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OperationServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OperationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OperationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OperationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OperationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified Operation resource.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Get(global::Yandex.Cloud.Operation.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Operation resource.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Get(global::Yandex.Cloud.Operation.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified Operation resource.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> GetAsync(global::Yandex.Cloud.Operation.GetOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Operation resource.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> GetAsync(global::Yandex.Cloud.Operation.GetOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Cancels the specified operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Cancel(global::Yandex.Cloud.Operation.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Cancel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancels the specified operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Cancel(global::Yandex.Cloud.Operation.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Cancel, null, options, request);
      }
      /// <summary>
      /// Cancels the specified operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CancelAsync(global::Yandex.Cloud.Operation.CancelOperationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CancelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Cancels the specified operation.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CancelAsync(global::Yandex.Cloud.Operation.CancelOperationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Cancel, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OperationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OperationServiceClient(configuration);
      }
    }

  }
}
#endregion