// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/user_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Mdb.Clickhouse.V1 {
  /// <summary>
  /// A set of methods for managing ClickHouse User resources.
  /// </summary>
  internal static partial class UserService
  {
    static readonly string __ServiceName = "yandex.cloud.mdb.clickhouse.v1.UserService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetUserRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.User> __Marshaller_yandex_cloud_mdb_clickhouse_v1_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.User.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListUsersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse> __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListUsersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_CreateUserRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_UpdateUserRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_DeleteUserRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_GrantUserPermissionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest> __Marshaller_yandex_cloud_mdb_clickhouse_v1_RevokeUserPermissionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.User> __Method_Get = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.User>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_GetUserRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_User);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest, global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListUsersRequest,
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_ListUsersResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest, global::Yandex.Cloud.Operation.Operation> __Method_Create = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_CreateUserRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest, global::Yandex.Cloud.Operation.Operation> __Method_Update = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_UpdateUserRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_DeleteUserRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest, global::Yandex.Cloud.Operation.Operation> __Method_GrantPermission = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GrantPermission",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_GrantUserPermissionRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest, global::Yandex.Cloud.Operation.Operation> __Method_RevokePermission = new grpc::Method<global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RevokePermission",
        __Marshaller_yandex_cloud_mdb_clickhouse_v1_RevokeUserPermissionRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.UserServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for UserService</summary>
    public partial class UserServiceClient : grpc::ClientBase<UserServiceClient>
    {
      /// <summary>Creates a new client for UserService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public UserServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for UserService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public UserServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected UserServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected UserServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified ClickHouse User resource.
      ///
      /// To get the list of available ClickHouse User resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.User Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ClickHouse User resource.
      ///
      /// To get the list of available ClickHouse User resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.User Get(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified ClickHouse User resource.
      ///
      /// To get the list of available ClickHouse User resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.User> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified ClickHouse User resource.
      ///
      /// To get the list of available ClickHouse User resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.User> GetAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GetUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of ClickHouse User resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of ClickHouse User resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse List(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of ClickHouse User resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of ClickHouse User resources in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersResponse> ListAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListUsersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Creates a ClickHouse user in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a ClickHouse user in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Creates a ClickHouse user in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a ClickHouse user in the specified cluster.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.CreateUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Updates the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Updates the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.UpdateUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Deletes the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.DeleteUserRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Grants a permission to the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation GrantPermission(global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GrantPermission(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Grants a permission to the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation GrantPermission(global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GrantPermission, null, options, request);
      }
      /// <summary>
      /// Grants a permission to the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> GrantPermissionAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GrantPermissionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Grants a permission to the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> GrantPermissionAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.GrantUserPermissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GrantPermission, null, options, request);
      }
      /// <summary>
      /// Revokes a permission from the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation RevokePermission(global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RevokePermission(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Revokes a permission from the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation RevokePermission(global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RevokePermission, null, options, request);
      }
      /// <summary>
      /// Revokes a permission from the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> RevokePermissionAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RevokePermissionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Revokes a permission from the specified ClickHouse user.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> RevokePermissionAsync(global::Yandex.Cloud.Mdb.Clickhouse.V1.RevokeUserPermissionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RevokePermission, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override UserServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new UserServiceClient(configuration);
      }
    }

  }
}
#endregion