// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/database_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Mdb.Clickhouse.V1 {
  /// <summary>
  /// A set of methods for managing ClickHouse Database resources.
  /// </summary>
  internal static partial class DatabaseService
  {
    static readonly string __ServiceName = "yandex.cloud.mdb.clickhouse.v1.DatabaseService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetDatabaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.Database> __Marshaller_yandex_cloud_mdb_clickhouse_v1_Database = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.Database.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListDatabasesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListDatabasesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_CreateDatabaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_DeleteDatabaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.Database> __Method_Get = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.Database>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetDatabaseRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_Database);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListDatabasesRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListDatabasesResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest, global::Yandex.Cloud.Operation.Operation> __Method_Create = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_CreateDatabaseRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_DeleteDatabaseRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.DatabaseServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for DatabaseService</summary>
    public partial class DatabaseServiceClient : grpc::ClientBase<DatabaseServiceClient>
    {
      /// <summary>Creates a new client for DatabaseService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DatabaseServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DatabaseService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DatabaseServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DatabaseServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DatabaseServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified ClickHouse Database resource.
      ///
      /// To get the list of available ClickHouse Database resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.Database Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ClickHouse Database resource.
      ///
      /// To get the list of available ClickHouse Database resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.Database Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified ClickHouse Database resource.
      ///
      /// To get the list of available ClickHouse Database resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.Database> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ClickHouse Database resource.
      ///
      /// To get the list of available ClickHouse Database resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.Database> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of ClickHouse Database resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of ClickHouse Database resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of ClickHouse Database resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of ClickHouse Database resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListDatabasesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Creates a new ClickHouse database in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new ClickHouse database in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Creates a new ClickHouse database in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new ClickHouse database in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Deletes the specified ClickHouse database.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified ClickHouse database.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified ClickHouse database.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified ClickHouse database.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteDatabaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DatabaseServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DatabaseServiceClient(configuration);
      }
    }

  }
}
#endregion
