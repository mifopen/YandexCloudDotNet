// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/disk_type_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Compute.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/compute/v1/disk_type_service.proto</summary>
  internal static partial class DiskTypeServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/compute/v1/disk_type_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiskTypeServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci95YW5kZXgvY2xvdWQvY29tcHV0ZS92MS9kaXNrX3R5cGVfc2VydmljZS5w",
            "cm90bxIXeWFuZGV4LmNsb3VkLmNvbXB1dGUudjEaHGdvb2dsZS9hcGkvYW5u",
            "b3RhdGlvbnMucHJvdG8aJ3lhbmRleC9jbG91ZC9jb21wdXRlL3YxL2Rpc2tf",
            "dHlwZS5wcm90bxodeWFuZGV4L2Nsb3VkL3ZhbGlkYXRpb24ucHJvdG8iMAoS",
            "R2V0RGlza1R5cGVSZXF1ZXN0EhoKDGRpc2tfdHlwZV9pZBgBIAEoCUIE6Mcx",
            "ASJUChRMaXN0RGlza1R5cGVzUmVxdWVzdBIdCglwYWdlX3NpemUYASABKANC",
            "CvrHMQY8PTEwMDASHQoKcGFnZV90b2tlbhgCIAEoCUIJisgxBTw9MTAwImcK",
            "FUxpc3REaXNrVHlwZXNSZXNwb25zZRI1CgpkaXNrX3R5cGVzGAEgAygLMiEu",
            "eWFuZGV4LmNsb3VkLmNvbXB1dGUudjEuRGlza1R5cGUSFwoPbmV4dF9wYWdl",
            "X3Rva2VuGAIgASgJMp4CCg9EaXNrVHlwZVNlcnZpY2USgwEKA0dldBIrLnlh",
            "bmRleC5jbG91ZC5jb21wdXRlLnYxLkdldERpc2tUeXBlUmVxdWVzdBohLnlh",
            "bmRleC5jbG91ZC5jb21wdXRlLnYxLkRpc2tUeXBlIiyC0+STAiYSJC9jb21w",
            "dXRlL3YxL2Rpc2tUeXBlcy97ZGlza190eXBlX2lkfRKEAQoETGlzdBItLnlh",
            "bmRleC5jbG91ZC5jb21wdXRlLnYxLkxpc3REaXNrVHlwZXNSZXF1ZXN0Gi4u",
            "eWFuZGV4LmNsb3VkLmNvbXB1dGUudjEuTGlzdERpc2tUeXBlc1Jlc3BvbnNl",
            "Ih2C0+STAhcSFS9jb21wdXRlL3YxL2Rpc2tUeXBlc0JiCht5YW5kZXguY2xv",
            "dWQuYXBpLmNvbXB1dGUudjFaQ2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dv",
            "LWdlbnByb3RvL3lhbmRleC9jbG91ZC9jb21wdXRlL3YxO2NvbXB1dGViBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.Compute.V1.DiskTypeReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.GetDiskTypeRequest), global::Yandex.Cloud.Compute.V1.GetDiskTypeRequest.Parser, new[]{ "DiskTypeId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.ListDiskTypesRequest), global::Yandex.Cloud.Compute.V1.ListDiskTypesRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.ListDiskTypesResponse), global::Yandex.Cloud.Compute.V1.ListDiskTypesResponse.Parser, new[]{ "DiskTypes", "NextPageToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GetDiskTypeRequest : pb::IMessage<GetDiskTypeRequest> {
    private static readonly pb::MessageParser<GetDiskTypeRequest> _parser = new pb::MessageParser<GetDiskTypeRequest>(() => new GetDiskTypeRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetDiskTypeRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.DiskTypeServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDiskTypeRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDiskTypeRequest(GetDiskTypeRequest other) : this() {
      diskTypeId_ = other.diskTypeId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetDiskTypeRequest Clone() {
      return new GetDiskTypeRequest(this);
    }

    /// <summary>Field number for the "disk_type_id" field.</summary>
    public const int DiskTypeIdFieldNumber = 1;
    private string diskTypeId_ = "";
    /// <summary>
    /// ID of the disk type to return information about.
    /// To get the disk type ID use a [DiskTypeService.List] request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DiskTypeId {
      get { return diskTypeId_; }
      set {
        diskTypeId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetDiskTypeRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetDiskTypeRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DiskTypeId != other.DiskTypeId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DiskTypeId.Length != 0) hash ^= DiskTypeId.GetHashCode();
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
      if (DiskTypeId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DiskTypeId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DiskTypeId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DiskTypeId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetDiskTypeRequest other) {
      if (other == null) {
        return;
      }
      if (other.DiskTypeId.Length != 0) {
        DiskTypeId = other.DiskTypeId;
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
            DiskTypeId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListDiskTypesRequest : pb::IMessage<ListDiskTypesRequest> {
    private static readonly pb::MessageParser<ListDiskTypesRequest> _parser = new pb::MessageParser<ListDiskTypesRequest>(() => new ListDiskTypesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListDiskTypesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.DiskTypeServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesRequest(ListDiskTypesRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesRequest Clone() {
      return new ListDiskTypesRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 1;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page to return. If the number of available
    /// results is larger than [page_size],
    /// the service returns a [ListDiskTypesResponse.next_page_token]
    /// that can be used to get the next page of results in subsequent list requests.
    /// </summary>
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
    /// <summary>
    /// Page token. To get the next page of results, set [page_token] to the
    /// [ListDiskTypesResponse.next_page_token] returned by a previous list request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListDiskTypesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListDiskTypesRequest other) {
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
    public void MergeFrom(ListDiskTypesRequest other) {
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

  internal sealed partial class ListDiskTypesResponse : pb::IMessage<ListDiskTypesResponse> {
    private static readonly pb::MessageParser<ListDiskTypesResponse> _parser = new pb::MessageParser<ListDiskTypesResponse>(() => new ListDiskTypesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListDiskTypesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.DiskTypeServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesResponse(ListDiskTypesResponse other) : this() {
      diskTypes_ = other.diskTypes_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListDiskTypesResponse Clone() {
      return new ListDiskTypesResponse(this);
    }

    /// <summary>Field number for the "disk_types" field.</summary>
    public const int DiskTypesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Compute.V1.DiskType> _repeated_diskTypes_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Compute.V1.DiskType.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.DiskType> diskTypes_ = new pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.DiskType>();
    /// <summary>
    /// List of disk types.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.DiskType> DiskTypes {
      get { return diskTypes_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for list requests. If the number of results
    /// is larger than [ListDiskTypesRequest.page_size], use
    /// the [next_page_token] as the value
    /// for the [ListDiskTypesRequest.page_token] query parameter
    /// in the next list request. Each subsequent list request will have its own
    /// [next_page_token] to continue paging through the results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListDiskTypesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListDiskTypesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!diskTypes_.Equals(other.diskTypes_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= diskTypes_.GetHashCode();
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
      diskTypes_.WriteTo(output, _repeated_diskTypes_codec);
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
      size += diskTypes_.CalculateSize(_repeated_diskTypes_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListDiskTypesResponse other) {
      if (other == null) {
        return;
      }
      diskTypes_.Add(other.diskTypes_);
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
            diskTypes_.AddEntriesFrom(input, _repeated_diskTypes_codec);
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
