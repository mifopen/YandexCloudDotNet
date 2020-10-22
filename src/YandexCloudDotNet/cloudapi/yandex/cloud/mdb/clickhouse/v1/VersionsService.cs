// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/versions_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Clickhouse.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/clickhouse/v1/versions_service.proto</summary>
  internal static partial class VersionsServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/clickhouse/v1/versions_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VersionsServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjV5YW5kZXgvY2xvdWQvbWRiL2NsaWNraG91c2UvdjEvdmVyc2lvbnNfc2Vy",
            "dmljZS5wcm90bxIeeWFuZGV4LmNsb3VkLm1kYi5jbGlja2hvdXNlLnYxGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGh15YW5kZXgvY2xvdWQvdmFs",
            "aWRhdGlvbi5wcm90bxoseWFuZGV4L2Nsb3VkL21kYi9jbGlja2hvdXNlL3Yx",
            "L3ZlcnNpb24ucHJvdG8iUwoTTGlzdFZlcnNpb25zUmVxdWVzdBIdCglwYWdl",
            "X3NpemUYASABKANCCvrHMQYwLTEwMDASHQoKcGFnZV90b2tlbhgCIAEoCUIJ",
            "isgxBTw9MTAwImkKFExpc3RWZXJzaW9uc1Jlc3BvbnNlEjgKB3ZlcnNpb24Y",
            "ASADKAsyJy55YW5kZXguY2xvdWQubWRiLmNsaWNraG91c2UudjEuVmVyc2lv",
            "bhIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAkyrgEKD1ZlcnNpb25zU2Vydmlj",
            "ZRKaAQoETGlzdBIzLnlhbmRleC5jbG91ZC5tZGIuY2xpY2tob3VzZS52MS5M",
            "aXN0VmVyc2lvbnNSZXF1ZXN0GjQueWFuZGV4LmNsb3VkLm1kYi5jbGlja2hv",
            "dXNlLnYxLkxpc3RWZXJzaW9uc1Jlc3BvbnNlIieC0+STAiESHy9tYW5hZ2Vk",
            "LWNsaWNraG91c2UvdjEvdmVyc2lvbnNCcwoieWFuZGV4LmNsb3VkLmFwaS5t",
            "ZGIuY2xpY2tob3VzZS52MVpNZ2l0aHViLmNvbS95YW5kZXgtY2xvdWQvZ28t",
            "Z2VucHJvdG8veWFuZGV4L2Nsb3VkL21kYi9jbGlja2hvdXNlL3YxO2NsaWNr",
            "aG91c2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, global::Yandex.Cloud.Mdb.Clickhouse.V1.VersionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse), global::Yandex.Cloud.Mdb.Clickhouse.V1.ListVersionsResponse.Parser, new[]{ "Version", "NextPageToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ListVersionsRequest : pb::IMessage<ListVersionsRequest> {
    private static readonly pb::MessageParser<ListVersionsRequest> _parser = new pb::MessageParser<ListVersionsRequest>(() => new ListVersionsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListVersionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.VersionsServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsRequest(ListVersionsRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsRequest Clone() {
      return new ListVersionsRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 1;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page that should be returned. If the number of available
    /// results is larger than [page_size], the service returns a [ListVersionsResponse.next_page_token] that can be used
    /// to get the next page of results in subsequent ListVersions requests.
    /// Default value: 100.
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
    /// Page token. Set [page_token] to the [ListVersionsResponse.next_page_token] returned by a previous ListVersions
    /// request to get the next page of results.
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
      return Equals(other as ListVersionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListVersionsRequest other) {
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
    public void MergeFrom(ListVersionsRequest other) {
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

  internal sealed partial class ListVersionsResponse : pb::IMessage<ListVersionsResponse> {
    private static readonly pb::MessageParser<ListVersionsResponse> _parser = new pb::MessageParser<ListVersionsResponse>(() => new ListVersionsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListVersionsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.VersionsServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsResponse(ListVersionsResponse other) : this() {
      version_ = other.version_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListVersionsResponse Clone() {
      return new ListVersionsResponse(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Mdb.Clickhouse.V1.Version> _repeated_version_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Mdb.Clickhouse.V1.Version.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.Version> version_ = new pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.Version>();
    /// <summary>
    /// Requested list of available versions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Mdb.Clickhouse.V1.Version> Version {
      get { return version_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for ListVersions requests,
    /// if the number of results is larger than [ListVersionsRequest.page_size] specified in the request.
    /// To get the next page, specify the value of [next_page_token] as a value for
    /// the [ListVersionsRequest.page_token] parameter in the next ListVerions request. Subsequent ListVersions
    /// requests will have their own [next_page_token] to continue paging through the results.
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
      return Equals(other as ListVersionsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListVersionsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!version_.Equals(other.version_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= version_.GetHashCode();
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
      version_.WriteTo(output, _repeated_version_codec);
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
      size += version_.CalculateSize(_repeated_version_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListVersionsResponse other) {
      if (other == null) {
        return;
      }
      version_.Add(other.version_);
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
            version_.AddEntriesFrom(input, _repeated_version_codec);
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