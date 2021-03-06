// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iam/v1/role_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Iam.V1 {
  /// <summary>
  /// A set of methods for managing Role resources.
  /// </summary>
  internal static partial class RoleService
  {
    static readonly string __ServiceName = "yandex.cloud.iam.v1.RoleService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.GetRoleRequest> __Marshaller_yandex_cloud_iam_v1_GetRoleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.GetRoleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.Role> __Marshaller_yandex_cloud_iam_v1_Role = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.Role.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.ListRolesRequest> __Marshaller_yandex_cloud_iam_v1_ListRolesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.ListRolesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Iam.V1.ListRolesResponse> __Marshaller_yandex_cloud_iam_v1_ListRolesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Iam.V1.ListRolesResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.GetRoleRequest, global::Yandex.Cloud.Iam.V1.Role> __Method_Get = new grpc::Method<global::Yandex.Cloud.Iam.V1.GetRoleRequest, global::Yandex.Cloud.Iam.V1.Role>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_iam_v1_GetRoleRequest,
        __Marshaller_yandex_cloud_iam_v1_Role);

    static readonly grpc::Method<global::Yandex.Cloud.Iam.V1.ListRolesRequest, global::Yandex.Cloud.Iam.V1.ListRolesResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Iam.V1.ListRolesRequest, global::Yandex.Cloud.Iam.V1.ListRolesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_iam_v1_ListRolesRequest,
        __Marshaller_yandex_cloud_iam_v1_ListRolesResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Iam.V1.RoleServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for RoleService</summary>
    public partial class RoleServiceClient : grpc::ClientBase<RoleServiceClient>
    {
      /// <summary>Creates a new client for RoleService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RoleServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RoleService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RoleServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RoleServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RoleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified Role resource.
      ///
      /// To get the list of available Role resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Role Get(global::Yandex.Cloud.Iam.V1.GetRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Role resource.
      ///
      /// To get the list of available Role resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.Role Get(global::Yandex.Cloud.Iam.V1.GetRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified Role resource.
      ///
      /// To get the list of available Role resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Role> GetAsync(global::Yandex.Cloud.Iam.V1.GetRoleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Role resource.
      ///
      /// To get the list of available Role resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.Role> GetAsync(global::Yandex.Cloud.Iam.V1.GetRoleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of Role resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ListRolesResponse List(global::Yandex.Cloud.Iam.V1.ListRolesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Role resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Iam.V1.ListRolesResponse List(global::Yandex.Cloud.Iam.V1.ListRolesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of Role resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ListRolesResponse> ListAsync(global::Yandex.Cloud.Iam.V1.ListRolesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Role resources.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Iam.V1.ListRolesResponse> ListAsync(global::Yandex.Cloud.Iam.V1.ListRolesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RoleServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RoleServiceClient(configuration);
      }
    }

  }
}
#endregion
