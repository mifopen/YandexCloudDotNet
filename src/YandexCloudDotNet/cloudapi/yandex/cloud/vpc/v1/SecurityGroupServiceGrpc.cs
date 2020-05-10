// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/vpc/v1/security_group_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Vpc.V1 {
  internal static partial class SecurityGroupService
  {
    static readonly string __ServiceName = "yandex.cloud.vpc.v1.SecurityGroupService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest> __Marshaller_yandex_cloud_vpc_v1_GetSecurityGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.SecurityGroup> __Marshaller_yandex_cloud_vpc_v1_SecurityGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.SecurityGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest> __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse> __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest> __Marshaller_yandex_cloud_vpc_v1_CreateSecurityGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest> __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest> __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRulesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest> __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRuleRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest> __Marshaller_yandex_cloud_vpc_v1_DeleteSecurityGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest> __Marshaller_yandex_cloud_vpc_v1_MoveSecurityGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest> __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupOperationsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse> __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupOperationsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest, global::Yandex.Cloud.Vpc.V1.SecurityGroup> __Method_Get = new grpc::Method<global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest, global::Yandex.Cloud.Vpc.V1.SecurityGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_vpc_v1_GetSecurityGroupRequest,
        __Marshaller_yandex_cloud_vpc_v1_SecurityGroup);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest, global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest, global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupsRequest,
        __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupsResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Create = new grpc::Method<global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Create",
        __Marshaller_yandex_cloud_vpc_v1_CreateSecurityGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Update = new grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest, global::Yandex.Cloud.Operation.Operation> __Method_UpdateRules = new grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRules",
        __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRulesRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest, global::Yandex.Cloud.Operation.Operation> __Method_UpdateRule = new grpc::Method<global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRule",
        __Marshaller_yandex_cloud_vpc_v1_UpdateSecurityGroupRuleRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_vpc_v1_DeleteSecurityGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation> __Method_Move = new grpc::Method<global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Move",
        __Marshaller_yandex_cloud_vpc_v1_MoveSecurityGroupRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest, global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse> __Method_ListOperations = new grpc::Method<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest, global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListOperations",
        __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupOperationsRequest,
        __Marshaller_yandex_cloud_vpc_v1_ListSecurityGroupOperationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Vpc.V1.SecurityGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for SecurityGroupService</summary>
    public partial class SecurityGroupServiceClient : grpc::ClientBase<SecurityGroupServiceClient>
    {
      /// <summary>Creates a new client for SecurityGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SecurityGroupServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SecurityGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SecurityGroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SecurityGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SecurityGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Yandex.Cloud.Vpc.V1.SecurityGroup Get(global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Vpc.V1.SecurityGroup Get(global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.SecurityGroup> GetAsync(global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.SecurityGroup> GetAsync(global::Yandex.Cloud.Vpc.V1.GetSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse List(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse List(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse> ListAsync(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsResponse> ListAsync(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation Create(global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Create, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> CreateAsync(global::Yandex.Cloud.Vpc.V1.CreateSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Create, null, options, request);
      }
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation Update(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      public virtual global::Yandex.Cloud.Operation.Operation UpdateRules(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRules(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation UpdateRules(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRules, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateRulesAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRulesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateRulesAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRulesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRules, null, options, request);
      }
      /// <summary>
      /// update rule description or labels
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation UpdateRule(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRule(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// update rule description or labels
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation UpdateRule(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRule, null, options, request);
      }
      /// <summary>
      /// update rule description or labels
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateRuleAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRuleAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// update rule description or labels
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> UpdateRuleAsync(global::Yandex.Cloud.Vpc.V1.UpdateSecurityGroupRuleRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRule, null, options, request);
      }
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Vpc.V1.DeleteSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual global::Yandex.Cloud.Operation.Operation Move(global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Move(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation Move(global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Move, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> MoveAsync(global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MoveAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> MoveAsync(global::Yandex.Cloud.Vpc.V1.MoveSecurityGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Move, null, options, request);
      }
      public virtual global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse ListOperations(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse ListOperations(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListOperations, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsResponse> ListOperationsAsync(global::Yandex.Cloud.Vpc.V1.ListSecurityGroupOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListOperations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SecurityGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SecurityGroupServiceClient(configuration);
      }
    }

  }
}
#endregion
