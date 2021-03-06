// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/k8s/v1/version_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.K8S.V1 {
  /// <summary>
  /// A set of methods for managing Kubernetes versions.
  /// </summary>
  internal static partial class VersionService
  {
    static readonly string __ServiceName = "yandex.cloud.k8s.v1.VersionService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.K8S.V1.ListVersionsRequest> __Marshaller_yandex_cloud_k8s_v1_ListVersionsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.K8S.V1.ListVersionsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.K8S.V1.ListVersionsResponse> __Marshaller_yandex_cloud_k8s_v1_ListVersionsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.K8S.V1.ListVersionsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.K8S.V1.ListVersionsRequest, global::Yandex.Cloud.K8S.V1.ListVersionsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.K8S.V1.ListVersionsRequest, global::Yandex.Cloud.K8S.V1.ListVersionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_k8s_v1_ListVersionsRequest,
        __Marshaller_yandex_cloud_k8s_v1_ListVersionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.K8S.V1.VersionServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for VersionService</summary>
    public partial class VersionServiceClient : grpc::ClientBase<VersionServiceClient>
    {
      /// <summary>Creates a new client for VersionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public VersionServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for VersionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public VersionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected VersionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected VersionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the list of versions in the specified release channel.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.K8S.V1.ListVersionsResponse List(global::Yandex.Cloud.K8S.V1.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of versions in the specified release channel.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.K8S.V1.ListVersionsResponse List(global::Yandex.Cloud.K8S.V1.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of versions in the specified release channel.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.K8S.V1.ListVersionsResponse> ListAsync(global::Yandex.Cloud.K8S.V1.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of versions in the specified release channel.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.K8S.V1.ListVersionsResponse> ListAsync(global::Yandex.Cloud.K8S.V1.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override VersionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new VersionServiceClient(configuration);
      }
    }

  }
}
#endregion
