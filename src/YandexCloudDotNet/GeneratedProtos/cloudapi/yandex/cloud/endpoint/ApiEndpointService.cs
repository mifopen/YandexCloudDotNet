// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/endpoint/api_endpoint_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Endpoint {

  /// <summary>Holder for reflection information generated from yandex/cloud/endpoint/api_endpoint_service.proto</summary>
  internal static partial class ApiEndpointServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/endpoint/api_endpoint_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApiEndpointServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjB5YW5kZXgvY2xvdWQvZW5kcG9pbnQvYXBpX2VuZHBvaW50X3NlcnZpY2Uu",
            "cHJvdG8SFXlhbmRleC5jbG91ZC5lbmRwb2ludBocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxooeWFuZGV4L2Nsb3VkL2VuZHBvaW50L2FwaV9lbmRw",
            "b2ludC5wcm90byIwChVHZXRBcGlFbmRwb2ludFJlcXVlc3QSFwoPYXBpX2Vu",
            "ZHBvaW50X2lkGAEgASgJIkAKF0xpc3RBcGlFbmRwb2ludHNSZXF1ZXN0EhEK",
            "CXBhZ2Vfc2l6ZRgBIAEoAxISCgpwYWdlX3Rva2VuGAIgASgJImoKGExpc3RB",
            "cGlFbmRwb2ludHNSZXNwb25zZRI1CgllbmRwb2ludHMYASADKAsyIi55YW5k",
            "ZXguY2xvdWQuZW5kcG9pbnQuQXBpRW5kcG9pbnQSFwoPbmV4dF9wYWdlX3Rv",
            "a2VuGAIgASgJMpACChJBcGlFbmRwb2ludFNlcnZpY2USfQoDR2V0EiwueWFu",
            "ZGV4LmNsb3VkLmVuZHBvaW50LkdldEFwaUVuZHBvaW50UmVxdWVzdBoiLnlh",
            "bmRleC5jbG91ZC5lbmRwb2ludC5BcGlFbmRwb2ludCIkgtPkkwIeEhwvZW5k",
            "cG9pbnRzL3thcGlfZW5kcG9pbnRfaWR9EnsKBExpc3QSLi55YW5kZXguY2xv",
            "dWQuZW5kcG9pbnQuTGlzdEFwaUVuZHBvaW50c1JlcXVlc3QaLy55YW5kZXgu",
            "Y2xvdWQuZW5kcG9pbnQuTGlzdEFwaUVuZHBvaW50c1Jlc3BvbnNlIhKC0+ST",
            "AgwSCi9lbmRwb2ludHNCRFpCZ2l0aHViLmNvbS95YW5kZXgtY2xvdWQvZ28t",
            "Z2VucHJvdG8veWFuZGV4L2Nsb3VkL2VuZHBvaW50O2VuZHBvaW50YgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.Endpoint.ApiEndpointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Endpoint.GetApiEndpointRequest), global::Yandex.Cloud.Endpoint.GetApiEndpointRequest.Parser, new[]{ "ApiEndpointId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Endpoint.ListApiEndpointsRequest), global::Yandex.Cloud.Endpoint.ListApiEndpointsRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Endpoint.ListApiEndpointsResponse), global::Yandex.Cloud.Endpoint.ListApiEndpointsResponse.Parser, new[]{ "Endpoints", "NextPageToken" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GetApiEndpointRequest : pb::IMessage<GetApiEndpointRequest> {
    private static readonly pb::MessageParser<GetApiEndpointRequest> _parser = new pb::MessageParser<GetApiEndpointRequest>(() => new GetApiEndpointRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetApiEndpointRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Endpoint.ApiEndpointServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetApiEndpointRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetApiEndpointRequest(GetApiEndpointRequest other) : this() {
      apiEndpointId_ = other.apiEndpointId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetApiEndpointRequest Clone() {
      return new GetApiEndpointRequest(this);
    }

    /// <summary>Field number for the "api_endpoint_id" field.</summary>
    public const int ApiEndpointIdFieldNumber = 1;
    private string apiEndpointId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ApiEndpointId {
      get { return apiEndpointId_; }
      set {
        apiEndpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetApiEndpointRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetApiEndpointRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApiEndpointId != other.ApiEndpointId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ApiEndpointId.Length != 0) hash ^= ApiEndpointId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ApiEndpointId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ApiEndpointId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ApiEndpointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApiEndpointId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetApiEndpointRequest other) {
      if (other == null) {
        return;
      }
      if (other.ApiEndpointId.Length != 0) {
        ApiEndpointId = other.ApiEndpointId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ApiEndpointId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListApiEndpointsRequest : pb::IMessage<ListApiEndpointsRequest> {
    private static readonly pb::MessageParser<ListApiEndpointsRequest> _parser = new pb::MessageParser<ListApiEndpointsRequest>(() => new ListApiEndpointsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListApiEndpointsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Endpoint.ApiEndpointServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsRequest(ListApiEndpointsRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsRequest Clone() {
      return new ListApiEndpointsRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 1;
    private long pageSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 2;
    private string pageToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListApiEndpointsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListApiEndpointsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PageSize != 0L) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PageSize != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListApiEndpointsRequest other) {
      if (other == null) {
        return;
      }
      if (other.PageSize != 0L) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            PageSize = input.ReadInt64();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListApiEndpointsResponse : pb::IMessage<ListApiEndpointsResponse> {
    private static readonly pb::MessageParser<ListApiEndpointsResponse> _parser = new pb::MessageParser<ListApiEndpointsResponse>(() => new ListApiEndpointsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListApiEndpointsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Endpoint.ApiEndpointServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsResponse(ListApiEndpointsResponse other) : this() {
      endpoints_ = other.endpoints_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListApiEndpointsResponse Clone() {
      return new ListApiEndpointsResponse(this);
    }

    /// <summary>Field number for the "endpoints" field.</summary>
    public const int EndpointsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Endpoint.ApiEndpoint> _repeated_endpoints_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Endpoint.ApiEndpoint.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Endpoint.ApiEndpoint> endpoints_ = new pbc::RepeatedField<global::Yandex.Cloud.Endpoint.ApiEndpoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Endpoint.ApiEndpoint> Endpoints {
      get { return endpoints_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListApiEndpointsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListApiEndpointsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!endpoints_.Equals(other.endpoints_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= endpoints_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      endpoints_.WriteTo(output, _repeated_endpoints_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += endpoints_.CalculateSize(_repeated_endpoints_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListApiEndpointsResponse other) {
      if (other == null) {
        return;
      }
      endpoints_.Add(other.endpoints_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            endpoints_.AddEntriesFrom(input, _repeated_endpoints_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
