// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/versions_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Mdb.Clickhouse.V1 {
  /// <summary>
  /// A set of methods for managing ClickHouse versions.
  /// </summary>
  internal static partial class VersionsService
  {
    static readonly string __ServiceName = "yandex.cloud.mdb.clickhouse.v1.VersionsService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListVersionsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListVersionsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListVersionsRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListVersionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.VersionsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for VersionsService</summary>
    public partial class VersionsServiceClient : grpc::ClientBase<VersionsServiceClient>
    {
      /// <summary>Creates a new client for VersionsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public VersionsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for VersionsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public VersionsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected VersionsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected VersionsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns list of available ClickHouse versions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns list of available ClickHouse versions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Returns list of available ClickHouse versions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns list of available ClickHouse versions.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override VersionsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new VersionsServiceClient(configuration);
      }
    }

  }
}
#endregion
