// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/host_group_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Compute.V1 {
  /// <summary>
  /// A set of methods for managing groups of dedicated hosts.
  /// </summary>
  internal static partial class HostGroupService
  {
    static readonly string __ServiceName = "yandex.cloud.compute.v1.HostGroupService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.GetHostGroupRequest> __Marshaller_yandex_cloud_compute_v1_GetHostGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.GetHostGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.HostGroup> __Marshaller_yandex_cloud_compute_v1_HostGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.HostGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest> __Marshaller_yandex_cloud_compute_v1_ListHostGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse> __Marshaller_yandex_cloud_compute_v1_ListHostGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest> __Marshaller_yandex_cloud_compute_v1_CreateHostGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest> __Marshaller_yandex_cloud_compute_v1_UpdateHostGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest> __Marshaller_yandex_cloud_compute_v1_DeleteHostGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest> __Marshaller_yandex_cloud_compute_v1_ListHostGroupOperationsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse> __Marshaller_yandex_cloud_compute_v1_ListHostGroupOperationsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest> __Marshaller_yandex_cloud_compute_v1_ListHostGroupInstancesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse> __Marshaller_yandex_cloud_compute_v1_ListHostGroupInstancesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest> __Marshaller_yandex_cloud_compute_v1_ListHostGroupHostsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse> __Marshaller_yandex_cloud_compute_v1_ListHostGroupHostsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.GetHostGroupRequest, global::Yandex.Cloud.Compute.V1.HostGroup> __Method_Get = new grpc::Method<global::Yandex.Cloud.Compute.V1.GetHostGroupRequest, global::Yandex.Cloud.Compute.V1.HostGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_compute_v1_GetHostGroupRequest,
        __Marshaller_yandex_cloud_compute_v1_HostGroup);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupsRequest,
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupsResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Create = new grpc::Method<global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_compute_v1_CreateHostGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Update = new grpc::Method<global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_yandex_cloud_compute_v1_UpdateHostGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_compute_v1_DeleteHostGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse> __Method_ListOperations = new grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupOperationsRequest,
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupOperationsResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse> __Method_ListInstances = new grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListInstances",
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupInstancesRequest,
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupInstancesResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse> __Method_ListHosts = new grpc::Method<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest, global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListHosts",
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupHostsRequest,
        __Marshaller_yandex_cloud_compute_v1_ListHostGroupHostsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Compute.V1.HostGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for HostGroupService</summary>
    public partial class HostGroupServiceClient : grpc::ClientBase<HostGroupServiceClient>
    {
      /// <summary>Creates a new client for HostGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public HostGroupServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for HostGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public HostGroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected HostGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected HostGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.HostGroup Get(global::Yandex.Cloud.Compute.V1.GetHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.HostGroup Get(global::Yandex.Cloud.Compute.V1.GetHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.HostGroup> GetAsync(global::Yandex.Cloud.Compute.V1.GetHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.HostGroup> GetAsync(global::Yandex.Cloud.Compute.V1.GetHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of host groups in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse List(global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of host groups in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse List(global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of host groups in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse> ListAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of host groups in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupsResponse> ListAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Creates a host group in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a host group in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Creates a host group in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a host group in the specified folder.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Compute.V1.CreateHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      /// <summary>
      /// Updates the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Updates the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Compute.V1.UpdateHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>
      /// Deletes the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Compute.V1.DeleteHostGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Lists operations for the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse ListOperations(global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists operations for the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse ListOperations(global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// Lists operations for the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists operations for the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>
      /// Lists instances that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse ListInstances(global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListInstances(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists instances that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse ListInstances(global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListInstances, null, options, request);
      }
      /// <summary>
      /// Lists instances that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse> ListInstancesAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListInstancesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists instances that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesResponse> ListInstancesAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupInstancesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListInstances, null, options, request);
      }
      /// <summary>
      /// Lists hosts that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse ListHosts(global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListHosts(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists hosts that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse ListHosts(global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListHosts, null, options, request);
      }
      /// <summary>
      /// Lists hosts that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse> ListHostsAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListHostsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists hosts that belongs to the specified host group.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Compute.V1.ListHostGroupHostsResponse> ListHostsAsync(global::Yandex.Cloud.Compute.V1.ListHostGroupHostsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListHosts, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override HostGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new HostGroupServiceClient(configuration);
      }
    }

  }
}
#endregion