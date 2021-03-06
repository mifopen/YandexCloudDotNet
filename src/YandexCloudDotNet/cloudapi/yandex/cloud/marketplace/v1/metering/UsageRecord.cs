// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/marketplace/v1/metering/usage_record.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Marketplace.V1.Metering {

  /// <summary>Holder for reflection information generated from yandex/cloud/marketplace/v1/metering/usage_record.proto</summary>
  internal static partial class UsageRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/marketplace/v1/metering/usage_record.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UsageRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjd5YW5kZXgvY2xvdWQvbWFya2V0cGxhY2UvdjEvbWV0ZXJpbmcvdXNhZ2Vf",
            "cmVjb3JkLnByb3RvEiR5YW5kZXguY2xvdWQubWFya2V0cGxhY2UudjEubWV0",
            "ZXJpbmcaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aH2dvb2dsZS9w",
            "cm90b2J1Zi90aW1lc3RhbXAucHJvdG8aHXlhbmRleC9jbG91ZC92YWxpZGF0",
            "aW9uLnByb3RvIpYBCgtVc2FnZVJlY29yZBIaCgR1dWlkGAEgASgJQgzoxzEB",
            "isgxBDw9MzYSHAoGc2t1X2lkGAIgASgJQgzoxzEBisgxBDw9NTASGAoIcXVh",
            "bnRpdHkYAyABKANCBvrHMQI+MBIzCgl0aW1lc3RhbXAYBCABKAsyGi5nb29n",
            "bGUucHJvdG9idWYuVGltZXN0YW1wQgToxzEBIiMKE0FjY2VwdGVkVXNhZ2VS",
            "ZWNvcmQSDAoEdXVpZBgBIAEoCSKdAgoTUmVqZWN0ZWRVc2FnZVJlY29yZBIM",
            "CgR1dWlkGAEgASgJElAKBnJlYXNvbhgCIAEoDjJALnlhbmRleC5jbG91ZC5t",
            "YXJrZXRwbGFjZS52MS5tZXRlcmluZy5SZWplY3RlZFVzYWdlUmVjb3JkLlJl",
            "YXNvbiKlAQoGUmVhc29uEhYKElJFQVNPTl9VTlNQRUNJRklFRBAAEg0KCURV",
            "UExJQ0FURRABEgsKB0VYUElSRUQQAhIVChFJTlZBTElEX1RJTUVTVEFNUBAD",
            "EhIKDklOVkFMSURfU0tVX0lEEAQSFgoSSU5WQUxJRF9QUk9EVUNUX0lEEAUS",
            "FAoQSU5WQUxJRF9RVUFOVElUWRAGEg4KCklOVkFMSURfSUQQB0J9Cih5YW5k",
            "ZXguY2xvdWQuYXBpLm1hcmtldHBsYWNlLnYxLm1ldGVyaW5nWlFnaXRodWIu",
            "Y29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90by95YW5kZXgvY2xvdWQvbWFy",
            "a2V0cGxhY2UvdjEvbWV0ZXJpbmc7bWV0ZXJpbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Marketplace.V1.Metering.UsageRecord), global::Yandex.Cloud.Marketplace.V1.Metering.UsageRecord.Parser, new[]{ "Uuid", "SkuId", "Quantity", "Timestamp" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Marketplace.V1.Metering.AcceptedUsageRecord), global::Yandex.Cloud.Marketplace.V1.Metering.AcceptedUsageRecord.Parser, new[]{ "Uuid" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord), global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Parser, new[]{ "Uuid", "Reason" }, null, new[]{ typeof(global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class UsageRecord : pb::IMessage<UsageRecord> {
    private static readonly pb::MessageParser<UsageRecord> _parser = new pb::MessageParser<UsageRecord>(() => new UsageRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UsageRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Marketplace.V1.Metering.UsageRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UsageRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UsageRecord(UsageRecord other) : this() {
      uuid_ = other.uuid_;
      skuId_ = other.skuId_;
      quantity_ = other.quantity_;
      timestamp_ = other.timestamp_ != null ? other.timestamp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UsageRecord Clone() {
      return new UsageRecord(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    /// <summary>
    /// Unique identitifier of the usage record (UUID format)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sku_id" field.</summary>
    public const int SkuIdFieldNumber = 2;
    private string skuId_ = "";
    /// <summary>
    /// Consumed Marketplace SaaS Sku ID, linked to `UsageRecord.product_id`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SkuId {
      get { return skuId_; }
      set {
        skuId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quantity" field.</summary>
    public const int QuantityFieldNumber = 3;
    private long quantity_;
    /// <summary>
    /// Quantity of sku consumed, measured in `sku.usage_unit` units (e.g. bytes)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    /// <summary>
    /// Timestamp in UTC for which the usage is being reported
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UsageRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UsageRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (SkuId != other.SkuId) return false;
      if (Quantity != other.Quantity) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (SkuId.Length != 0) hash ^= SkuId.GetHashCode();
      if (Quantity != 0L) hash ^= Quantity.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
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
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (SkuId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SkuId);
      }
      if (Quantity != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Quantity);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Timestamp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (SkuId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SkuId);
      }
      if (Quantity != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Quantity);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UsageRecord other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.SkuId.Length != 0) {
        SkuId = other.SkuId;
      }
      if (other.Quantity != 0L) {
        Quantity = other.Quantity;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
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
            Uuid = input.ReadString();
            break;
          }
          case 18: {
            SkuId = input.ReadString();
            break;
          }
          case 24: {
            Quantity = input.ReadInt64();
            break;
          }
          case 34: {
            if (timestamp_ == null) {
              Timestamp = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(Timestamp);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AcceptedUsageRecord : pb::IMessage<AcceptedUsageRecord> {
    private static readonly pb::MessageParser<AcceptedUsageRecord> _parser = new pb::MessageParser<AcceptedUsageRecord>(() => new AcceptedUsageRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AcceptedUsageRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Marketplace.V1.Metering.UsageRecordReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AcceptedUsageRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AcceptedUsageRecord(AcceptedUsageRecord other) : this() {
      uuid_ = other.uuid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AcceptedUsageRecord Clone() {
      return new AcceptedUsageRecord(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    /// <summary>
    /// Unique identitifier of the usage record (UUID format)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AcceptedUsageRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AcceptedUsageRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
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
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AcceptedUsageRecord other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
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
            Uuid = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class RejectedUsageRecord : pb::IMessage<RejectedUsageRecord> {
    private static readonly pb::MessageParser<RejectedUsageRecord> _parser = new pb::MessageParser<RejectedUsageRecord>(() => new RejectedUsageRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RejectedUsageRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Marketplace.V1.Metering.UsageRecordReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RejectedUsageRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RejectedUsageRecord(RejectedUsageRecord other) : this() {
      uuid_ = other.uuid_;
      reason_ = other.reason_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RejectedUsageRecord Clone() {
      return new RejectedUsageRecord(this);
    }

    /// <summary>Field number for the "uuid" field.</summary>
    public const int UuidFieldNumber = 1;
    private string uuid_ = "";
    /// <summary>
    /// Unique identitifier of the usage record (UUID format)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uuid {
      get { return uuid_; }
      set {
        uuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 2;
    private global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason reason_ = global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason.Unspecified;
    /// <summary>
    /// The reason of rejection
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason Reason {
      get { return reason_; }
      set {
        reason_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RejectedUsageRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RejectedUsageRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Uuid != other.Uuid) return false;
      if (Reason != other.Reason) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Uuid.Length != 0) hash ^= Uuid.GetHashCode();
      if (Reason != global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason.Unspecified) hash ^= Reason.GetHashCode();
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
      if (Uuid.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Uuid);
      }
      if (Reason != global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Reason);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Uuid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uuid);
      }
      if (Reason != global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Reason);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RejectedUsageRecord other) {
      if (other == null) {
        return;
      }
      if (other.Uuid.Length != 0) {
        Uuid = other.Uuid;
      }
      if (other.Reason != global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason.Unspecified) {
        Reason = other.Reason;
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
            Uuid = input.ReadString();
            break;
          }
          case 16: {
            Reason = (global::Yandex.Cloud.Marketplace.V1.Metering.RejectedUsageRecord.Types.Reason) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RejectedUsageRecord message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Reason {
        [pbr::OriginalName("REASON_UNSPECIFIED")] Unspecified = 0,
        [pbr::OriginalName("DUPLICATE")] Duplicate = 1,
        [pbr::OriginalName("EXPIRED")] Expired = 2,
        [pbr::OriginalName("INVALID_TIMESTAMP")] InvalidTimestamp = 3,
        [pbr::OriginalName("INVALID_SKU_ID")] InvalidSkuId = 4,
        [pbr::OriginalName("INVALID_PRODUCT_ID")] InvalidProductId = 5,
        [pbr::OriginalName("INVALID_QUANTITY")] InvalidQuantity = 6,
        [pbr::OriginalName("INVALID_ID")] InvalidId = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
