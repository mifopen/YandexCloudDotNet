// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/containerregistry/v1/image_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Containerregistry.V1 {
  /// <summary>
  /// A set of methods for managing Image resources.
  /// </summary>
  internal static partial class ImageService
  {
    static readonly string __ServiceName = "yandex.cloud.containerregistry.v1.ImageService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest> __Marshaller_yandex_cloud_containerregistry_v1_ListImagesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse> __Marshaller_yandex_cloud_containerregistry_v1_ListImagesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Containerregistry.V1.GetImageRequest> __Marshaller_yandex_cloud_containerregistry_v1_GetImageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Containerregistry.V1.GetImageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Containerregistry.V1.Image> __Marshaller_yandex_cloud_containerregistry_v1_Image = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Containerregistry.V1.Image.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest> __Marshaller_yandex_cloud_containerregistry_v1_DeleteImageRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest, global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse> __Method_List = new grpc::Method<global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest, global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_yandex_cloud_containerregistry_v1_ListImagesRequest,
        __Marshaller_yandex_cloud_containerregistry_v1_ListImagesResponse);

    static readonly grpc::Method<global::Yandex.Cloud.Containerregistry.V1.GetImageRequest, global::Yandex.Cloud.Containerregistry.V1.Image> __Method_Get = new grpc::Method<global::Yandex.Cloud.Containerregistry.V1.GetImageRequest, global::Yandex.Cloud.Containerregistry.V1.Image>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_yandex_cloud_containerregistry_v1_GetImageRequest,
        __Marshaller_yandex_cloud_containerregistry_v1_Image);

    static readonly grpc::Method<global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest, global::Yandex.Cloud.Operation.Operation> __Method_Delete = new grpc::Method<global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_yandex_cloud_containerregistry_v1_DeleteImageRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Containerregistry.V1.ImageServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ImageService</summary>
    public partial class ImageServiceClient : grpc::ClientBase<ImageServiceClient>
    {
      /// <summary>Creates a new client for ImageService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ImageServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ImageService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ImageServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ImageServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ImageServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Retrieves the list of Image resources in the specified registry or repository.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse List(global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Image resources in the specified registry or repository.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse List(global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Retrieves the list of Image resources in the specified registry or repository.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse> ListAsync(global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Retrieves the list of Image resources in the specified registry or repository.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Containerregistry.V1.ListImagesResponse> ListAsync(global::Yandex.Cloud.Containerregistry.V1.ListImagesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// Returns the specified Image resource.
      ///
      /// To get the list of available Image resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Containerregistry.V1.Image Get(global::Yandex.Cloud.Containerregistry.V1.GetImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Image resource.
      ///
      /// To get the list of available Image resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Containerregistry.V1.Image Get(global::Yandex.Cloud.Containerregistry.V1.GetImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Returns the specified Image resource.
      ///
      /// To get the list of available Image resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Containerregistry.V1.Image> GetAsync(global::Yandex.Cloud.Containerregistry.V1.GetImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the specified Image resource.
      ///
      /// To get the list of available Image resources, make a [List] request.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Containerregistry.V1.Image> GetAsync(global::Yandex.Cloud.Containerregistry.V1.GetImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Deletes the specified Docker image.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified Docker image.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Yandex.Cloud.Operation.Operation Delete(global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Deletes the specified Docker image.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes the specified Docker image.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> DeleteAsync(global::Yandex.Cloud.Containerregistry.V1.DeleteImageRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ImageServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ImageServiceClient(configuration);
      }
    }

  }
}
#endregion