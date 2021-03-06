// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/ai/stt/v2/stt_service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Yandex.Cloud.Ai.Stt.V2 {
  internal static partial class SttService
  {
    static readonly string __ServiceName = "yandex.cloud.ai.stt.v2.SttService";

    static readonly grpc::Marshaller<global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest> __Marshaller_yandex_cloud_ai_stt_v2_LongRunningRecognitionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Operation.Operation> __Marshaller_yandex_cloud_operation_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Operation.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest> __Marshaller_yandex_cloud_ai_stt_v2_StreamingRecognitionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse> __Marshaller_yandex_cloud_ai_stt_v2_StreamingRecognitionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest, global::Yandex.Cloud.Operation.Operation> __Method_LongRunningRecognize = new grpc::Method<global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest, global::Yandex.Cloud.Operation.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LongRunningRecognize",
        __Marshaller_yandex_cloud_ai_stt_v2_LongRunningRecognitionRequest,
        __Marshaller_yandex_cloud_operation_Operation);

    static readonly grpc::Method<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest, global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse> __Method_StreamingRecognize = new grpc::Method<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest, global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "StreamingRecognize",
        __Marshaller_yandex_cloud_ai_stt_v2_StreamingRecognitionRequest,
        __Marshaller_yandex_cloud_ai_stt_v2_StreamingRecognitionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Yandex.Cloud.Ai.Stt.V2.SttServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for SttService</summary>
    public partial class SttServiceClient : grpc::ClientBase<SttServiceClient>
    {
      /// <summary>Creates a new client for SttService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SttServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SttService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SttServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SttServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SttServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Yandex.Cloud.Operation.Operation LongRunningRecognize(global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LongRunningRecognize(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Yandex.Cloud.Operation.Operation LongRunningRecognize(global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LongRunningRecognize, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> LongRunningRecognizeAsync(global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LongRunningRecognizeAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Yandex.Cloud.Operation.Operation> LongRunningRecognizeAsync(global::Yandex.Cloud.Ai.Stt.V2.LongRunningRecognitionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LongRunningRecognize, null, options, request);
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest, global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse> StreamingRecognize(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StreamingRecognize(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionRequest, global::Yandex.Cloud.Ai.Stt.V2.StreamingRecognitionResponse> StreamingRecognize(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_StreamingRecognize, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SttServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SttServiceClient(configuration);
      }
    }

  }
}
#endregion
