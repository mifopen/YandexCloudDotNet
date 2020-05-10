// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/zone_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Compute.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/compute/v1/zone_service.proto</summary>
  internal static partial class ZoneServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/compute/v1/zone_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZoneServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip5YW5kZXgvY2xvdWQvY29tcHV0ZS92MS96b25lX3NlcnZpY2UucHJvdG8S",
            "F3lhbmRleC5jbG91ZC5jb21wdXRlLnYxGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvGiJ5YW5kZXgvY2xvdWQvY29tcHV0ZS92MS96b25lLnByb3Rv",
            "Gh15YW5kZXgvY2xvdWQvdmFsaWRhdGlvbi5wcm90byJQChBMaXN0Wm9uZXNS",
            "ZXF1ZXN0Eh0KCXBhZ2Vfc2l6ZRgBIAEoA0IK+scxBjw9MTAwMBIdCgpwYWdl",
            "X3Rva2VuGAIgASgJQgmKyDEFPD0xMDAiWgoRTGlzdFpvbmVzUmVzcG9uc2US",
            "LAoFem9uZXMYASADKAsyHS55YW5kZXguY2xvdWQuY29tcHV0ZS52MS5ab25l",
            "EhcKD25leHRfcGFnZV90b2tlbhgCIAEoCSIvCg5HZXRab25lUmVxdWVzdBId",
            "Cgd6b25lX2lkGAEgASgJQgzoxzEBisgxBDw9NTAy+wEKC1pvbmVTZXJ2aWNl",
            "EnIKA0dldBInLnlhbmRleC5jbG91ZC5jb21wdXRlLnYxLkdldFpvbmVSZXF1",
            "ZXN0Gh0ueWFuZGV4LmNsb3VkLmNvbXB1dGUudjEuWm9uZSIjgtPkkwIdEhsv",
            "Y29tcHV0ZS92MS96b25lcy97em9uZV9pZH0SeAoETGlzdBIpLnlhbmRleC5j",
            "bG91ZC5jb21wdXRlLnYxLkxpc3Rab25lc1JlcXVlc3QaKi55YW5kZXguY2xv",
            "dWQuY29tcHV0ZS52MS5MaXN0Wm9uZXNSZXNwb25zZSIZgtPkkwITEhEvY29t",
            "cHV0ZS92MS96b25lc0JiCht5YW5kZXguY2xvdWQuYXBpLmNvbXB1dGUudjFa",
            "Q2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdlbnByb3RvL3lhbmRleC9j",
            "bG91ZC9jb21wdXRlL3YxO2NvbXB1dGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.Compute.V1.ZoneReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.ListZonesRequest), global::Yandex.Cloud.Compute.V1.ListZonesRequest.Parser, new[]{ "PageSize", "PageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.ListZonesResponse), global::Yandex.Cloud.Compute.V1.ListZonesResponse.Parser, new[]{ "Zones", "NextPageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.GetZoneRequest), global::Yandex.Cloud.Compute.V1.GetZoneRequest.Parser, new[]{ "ZoneId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ListZonesRequest : pb::IMessage<ListZonesRequest> {
    private static readonly pb::MessageParser<ListZonesRequest> _parser = new pb::MessageParser<ListZonesRequest>(() => new ListZonesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListZonesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.ZoneServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesRequest(ListZonesRequest other) : this() {
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesRequest Clone() {
      return new ListZonesRequest(this);
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 1;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page to return. If the number of available
    /// results is larger than [page_size],
    /// the service returns a [ListZonesResponse.next_page_token]
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
    /// [ListZonesResponse.next_page_token] returned by a previous list request.
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
      return Equals(other as ListZonesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListZonesRequest other) {
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
    public void MergeFrom(ListZonesRequest other) {
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

  internal sealed partial class ListZonesResponse : pb::IMessage<ListZonesResponse> {
    private static readonly pb::MessageParser<ListZonesResponse> _parser = new pb::MessageParser<ListZonesResponse>(() => new ListZonesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListZonesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.ZoneServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesResponse(ListZonesResponse other) : this() {
      zones_ = other.zones_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListZonesResponse Clone() {
      return new ListZonesResponse(this);
    }

    /// <summary>Field number for the "zones" field.</summary>
    public const int ZonesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Compute.V1.Zone> _repeated_zones_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Compute.V1.Zone.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.Zone> zones_ = new pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.Zone>();
    /// <summary>
    /// List of availability zones.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Compute.V1.Zone> Zones {
      get { return zones_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for list requests. If the number of results
    /// is larger than [ListZonesRequest.page_size], use
    /// the [ListZonesRequest.page_token] as the value
    /// for the [ListZonesRequest.page_token] query parameter
    /// in the next list request. Subsequent list requests will have their own
    /// [ListZonesRequest.page_token] to continue paging through the results.
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
      return Equals(other as ListZonesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListZonesResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!zones_.Equals(other.zones_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= zones_.GetHashCode();
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
      zones_.WriteTo(output, _repeated_zones_codec);
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
      size += zones_.CalculateSize(_repeated_zones_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListZonesResponse other) {
      if (other == null) {
        return;
      }
      zones_.Add(other.zones_);
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
            zones_.AddEntriesFrom(input, _repeated_zones_codec);
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

  internal sealed partial class GetZoneRequest : pb::IMessage<GetZoneRequest> {
    private static readonly pb::MessageParser<GetZoneRequest> _parser = new pb::MessageParser<GetZoneRequest>(() => new GetZoneRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetZoneRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.ZoneServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetZoneRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetZoneRequest(GetZoneRequest other) : this() {
      zoneId_ = other.zoneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetZoneRequest Clone() {
      return new GetZoneRequest(this);
    }

    /// <summary>Field number for the "zone_id" field.</summary>
    public const int ZoneIdFieldNumber = 1;
    private string zoneId_ = "";
    /// <summary>
    /// ID of the availability zone to return information about.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ZoneId {
      get { return zoneId_; }
      set {
        zoneId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetZoneRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetZoneRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ZoneId != other.ZoneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ZoneId.Length != 0) hash ^= ZoneId.GetHashCode();
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
      if (ZoneId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ZoneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ZoneId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ZoneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetZoneRequest other) {
      if (other == null) {
        return;
      }
      if (other.ZoneId.Length != 0) {
        ZoneId = other.ZoneId;
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
            ZoneId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
