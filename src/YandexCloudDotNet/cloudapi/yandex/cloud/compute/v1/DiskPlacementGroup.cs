// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/disk_placement_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Compute.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/compute/v1/disk_placement_group.proto</summary>
  internal static partial class DiskPlacementGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/compute/v1/disk_placement_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DiskPlacementGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJ5YW5kZXgvY2xvdWQvY29tcHV0ZS92MS9kaXNrX3BsYWNlbWVudF9ncm91",
            "cC5wcm90bxIXeWFuZGV4LmNsb3VkLmNvbXB1dGUudjEaH2dvb2dsZS9wcm90",
            "b2J1Zi90aW1lc3RhbXAucHJvdG8ijQQKEkRpc2tQbGFjZW1lbnRHcm91cBIK",
            "CgJpZBgBIAEoCRIRCglmb2xkZXJfaWQYAiABKAkSLgoKY3JlYXRlZF9hdBgD",
            "IAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASDAoEbmFtZRgEIAEo",
            "CRITCgtkZXNjcmlwdGlvbhgFIAEoCRJHCgZsYWJlbHMYBiADKAsyNy55YW5k",
            "ZXguY2xvdWQuY29tcHV0ZS52MS5EaXNrUGxhY2VtZW50R3JvdXAuTGFiZWxz",
            "RW50cnkSDwoHem9uZV9pZBgHIAEoCRJCCgZzdGF0dXMYCyABKA4yMi55YW5k",
            "ZXguY2xvdWQuY29tcHV0ZS52MS5EaXNrUGxhY2VtZW50R3JvdXAuU3RhdHVz",
            "ElkKGXNwcmVhZF9wbGFjZW1lbnRfc3RyYXRlZ3kYCCABKAsyNC55YW5kZXgu",
            "Y2xvdWQuY29tcHV0ZS52MS5EaXNrU3ByZWFkUGxhY2VtZW50U3RyYXRlZ3lI",
            "ABotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6",
            "AjgBIkcKBlN0YXR1cxIWChJTVEFUVVNfVU5TUEVDSUZJRUQQABIMCghDUkVB",
            "VElORxABEgkKBVJFQURZEAISDAoIREVMRVRJTkcQBEIUChJwbGFjZW1lbnRf",
            "c3RyYXRlZ3kiHQobRGlza1NwcmVhZFBsYWNlbWVudFN0cmF0ZWd5QmIKG3lh",
            "bmRleC5jbG91ZC5hcGkuY29tcHV0ZS52MVpDZ2l0aHViLmNvbS95YW5kZXgt",
            "Y2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2NvbXB1dGUvdjE7Y29t",
            "cHV0ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.DiskPlacementGroup), global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "ZoneId", "Status", "SpreadPlacementStrategy" }, new[]{ "PlacementStrategy" }, new[]{ typeof(global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status) }, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy), global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class DiskPlacementGroup : pb::IMessage<DiskPlacementGroup> {
    private static readonly pb::MessageParser<DiskPlacementGroup> _parser = new pb::MessageParser<DiskPlacementGroup>(() => new DiskPlacementGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DiskPlacementGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.DiskPlacementGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskPlacementGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskPlacementGroup(DiskPlacementGroup other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      zoneId_ = other.zoneId_;
      status_ = other.status_;
      switch (other.PlacementStrategyCase) {
        case PlacementStrategyOneofCase.SpreadPlacementStrategy:
          SpreadPlacementStrategy = other.SpreadPlacementStrategy.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskPlacementGroup Clone() {
      return new DiskPlacementGroup(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the placement group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "folder_id" field.</summary>
    public const int FolderIdFieldNumber = 2;
    private string folderId_ = "";
    /// <summary>
    /// ID of the folder that the placement group belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FolderId {
      get { return folderId_; }
      set {
        folderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// Name of the placement group.
    /// The name is unique within the folder.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Description of the placement group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForString(18, ""), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Resource labels as `key:value` pairs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "zone_id" field.</summary>
    public const int ZoneIdFieldNumber = 7;
    private string zoneId_ = "";
    /// <summary>
    /// ID of the availability zone where the placement group resides.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ZoneId {
      get { return zoneId_; }
      set {
        zoneId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 11;
    private global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status status_ = global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status.Unspecified;
    /// <summary>
    /// Current status of the placement group
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "spread_placement_strategy" field.</summary>
    public const int SpreadPlacementStrategyFieldNumber = 8;
    /// <summary>
    /// Distribute instances over distinct failure domains.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy SpreadPlacementStrategy {
      get { return placementStrategyCase_ == PlacementStrategyOneofCase.SpreadPlacementStrategy ? (global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy) placementStrategy_ : null; }
      set {
        placementStrategy_ = value;
        placementStrategyCase_ = value == null ? PlacementStrategyOneofCase.None : PlacementStrategyOneofCase.SpreadPlacementStrategy;
      }
    }

    private object placementStrategy_;
    /// <summary>Enum of possible cases for the "placement_strategy" oneof.</summary>
    public enum PlacementStrategyOneofCase {
      None = 0,
      SpreadPlacementStrategy = 8,
    }
    private PlacementStrategyOneofCase placementStrategyCase_ = PlacementStrategyOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PlacementStrategyOneofCase PlacementStrategyCase {
      get { return placementStrategyCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPlacementStrategy() {
      placementStrategyCase_ = PlacementStrategyOneofCase.None;
      placementStrategy_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DiskPlacementGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DiskPlacementGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (FolderId != other.FolderId) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (ZoneId != other.ZoneId) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(SpreadPlacementStrategy, other.SpreadPlacementStrategy)) return false;
      if (PlacementStrategyCase != other.PlacementStrategyCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (FolderId.Length != 0) hash ^= FolderId.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (ZoneId.Length != 0) hash ^= ZoneId.GetHashCode();
      if (Status != global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status.Unspecified) hash ^= Status.GetHashCode();
      if (placementStrategyCase_ == PlacementStrategyOneofCase.SpreadPlacementStrategy) hash ^= SpreadPlacementStrategy.GetHashCode();
      hash ^= (int) placementStrategyCase_;
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (FolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FolderId);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreatedAt);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (ZoneId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ZoneId);
      }
      if (placementStrategyCase_ == PlacementStrategyOneofCase.SpreadPlacementStrategy) {
        output.WriteRawTag(66);
        output.WriteMessage(SpreadPlacementStrategy);
      }
      if (Status != global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (FolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FolderId);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (ZoneId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ZoneId);
      }
      if (Status != global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (placementStrategyCase_ == PlacementStrategyOneofCase.SpreadPlacementStrategy) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SpreadPlacementStrategy);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DiskPlacementGroup other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.FolderId.Length != 0) {
        FolderId = other.FolderId;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      labels_.Add(other.labels_);
      if (other.ZoneId.Length != 0) {
        ZoneId = other.ZoneId;
      }
      if (other.Status != global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status.Unspecified) {
        Status = other.Status;
      }
      switch (other.PlacementStrategyCase) {
        case PlacementStrategyOneofCase.SpreadPlacementStrategy:
          if (SpreadPlacementStrategy == null) {
            SpreadPlacementStrategy = new global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy();
          }
          SpreadPlacementStrategy.MergeFrom(other.SpreadPlacementStrategy);
          break;
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            FolderId = input.ReadString();
            break;
          }
          case 26: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 34: {
            Name = input.ReadString();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 58: {
            ZoneId = input.ReadString();
            break;
          }
          case 66: {
            global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy subBuilder = new global::Yandex.Cloud.Compute.V1.DiskSpreadPlacementStrategy();
            if (placementStrategyCase_ == PlacementStrategyOneofCase.SpreadPlacementStrategy) {
              subBuilder.MergeFrom(SpreadPlacementStrategy);
            }
            input.ReadMessage(subBuilder);
            SpreadPlacementStrategy = subBuilder;
            break;
          }
          case 88: {
            Status = (global::Yandex.Cloud.Compute.V1.DiskPlacementGroup.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DiskPlacementGroup message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        [pbr::OriginalName("CREATING")] Creating = 1,
        [pbr::OriginalName("READY")] Ready = 2,
        [pbr::OriginalName("DELETING")] Deleting = 4,
      }

    }
    #endregion

  }

  internal sealed partial class DiskSpreadPlacementStrategy : pb::IMessage<DiskSpreadPlacementStrategy> {
    private static readonly pb::MessageParser<DiskSpreadPlacementStrategy> _parser = new pb::MessageParser<DiskSpreadPlacementStrategy>(() => new DiskSpreadPlacementStrategy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DiskSpreadPlacementStrategy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.DiskPlacementGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskSpreadPlacementStrategy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskSpreadPlacementStrategy(DiskSpreadPlacementStrategy other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DiskSpreadPlacementStrategy Clone() {
      return new DiskSpreadPlacementStrategy(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DiskSpreadPlacementStrategy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DiskSpreadPlacementStrategy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DiskSpreadPlacementStrategy other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
