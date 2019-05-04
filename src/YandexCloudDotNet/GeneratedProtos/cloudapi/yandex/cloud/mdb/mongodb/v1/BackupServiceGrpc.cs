// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/mongodb/v1/backup_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Mdb.Mongodb.V1 {
  /// <summary>
  /// A set of methods for managing MongoDB Backup resources.
  /// </summary>
  internal static partial class BackupService
  {
    static readonly string __ServiceName = "yandex.cloud.mdb.mongodb.v1.BackupService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest> __Marshaller_yandex_cloud_mdb_mongodb_v1_GetBackupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Mongodb.V1.Backup> __Marshaller_yandex_cloud_mdb_mongodb_v1_Backup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Mongodb.V1.Backup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest> __Marshaller_yandex_cloud_mdb_mongodb_v1_ListBackupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse> __Marshaller_yandex_cloud_mdb_mongodb_v1_ListBackupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest, global::Yandex.Cloud.Mdb.Mongodb.V1.Backup> __Method_Get = new grpc::Method<global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest, global::Yandex.Cloud.Mdb.Mongodb.V1.Backup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_mdb_mongodb_v1_GetBackupRequest,
        __Marshaller_yandex_cloud_mdb_mongodb_v1_Backup);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest, global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest, global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_mdb_mongodb_v1_ListBackupsRequest,
        __Marshaller_yandex_cloud_mdb_mongodb_v1_ListBackupsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.BackupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for BackupService</summary>
    public partial class BackupServiceClient : grpc::ClientBase<BackupServiceClient>
    {
      /// <summary>Creates a new client for BackupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public BackupServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BackupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public BackupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected BackupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected BackupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified MongoDB Backup resource.
      ///
      /// To get the list of available MongoDB Backup resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Mongodb.V1.Backup Get(global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified MongoDB Backup resource.
      ///
      /// To get the list of available MongoDB Backup resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Mongodb.V1.Backup Get(global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified MongoDB Backup resource.
      ///
      /// To get the list of available MongoDB Backup resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Mongodb.V1.Backup> GetAsync(global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified MongoDB Backup resource.
      ///
      /// To get the list of available MongoDB Backup resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Mongodb.V1.Backup> GetAsync(global::Yandex.Cloud.Mdb.Mongodb.V1.GetBackupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of Backup resources available for the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse List(global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Backup resources available for the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse List(global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of Backup resources available for the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse> ListAsync(global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Backup resources available for the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsResponse> ListAsync(global::Yandex.Cloud.Mdb.Mongodb.V1.ListBackupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override BackupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BackupServiceClient(configuration);
      }
    }

  }
}
#endregion
