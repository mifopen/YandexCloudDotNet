// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/loadbalancer/v1/target_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Loadbalancer.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/loadbalancer/v1/target_group.proto</summary>
  internal static partial class TargetGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/loadbalancer/v1/target_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci95YW5kZXgvY2xvdWQvbG9hZGJhbGFuY2VyL3YxL3RhcmdldF9ncm91cC5w",
            "cm90bxIceWFuZGV4LmNsb3VkLmxvYWRiYWxhbmNlci52MRofZ29vZ2xlL3By",
            "b3RvYnVmL3RpbWVzdGFtcC5wcm90bxodeWFuZGV4L2Nsb3VkL3ZhbGlkYXRp",
            "b24ucHJvdG8ivwIKC1RhcmdldEdyb3VwEgoKAmlkGAEgASgJEhEKCWZvbGRl",
            "cl9pZBgCIAEoCRIuCgpjcmVhdGVkX2F0GAMgASgLMhouZ29vZ2xlLnByb3Rv",
            "YnVmLlRpbWVzdGFtcBIMCgRuYW1lGAQgASgJEhMKC2Rlc2NyaXB0aW9uGAUg",
            "ASgJEkUKBmxhYmVscxgGIAMoCzI1LnlhbmRleC5jbG91ZC5sb2FkYmFsYW5j",
            "ZXIudjEuVGFyZ2V0R3JvdXAuTGFiZWxzRW50cnkSEQoJcmVnaW9uX2lkGAcg",
            "ASgJEjUKB3RhcmdldHMYCSADKAsyJC55YW5kZXguY2xvdWQubG9hZGJhbGFu",
            "Y2VyLnYxLlRhcmdldBotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBIjYKBlRhcmdldBIbCglzdWJuZXRfaWQYASABKAlC",
            "CIrIMQQ8PTUwEg8KB2FkZHJlc3MYAiABKAlCT1pNZ2l0aHViLmNvbS95YW5k",
            "ZXgtY2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2xvYWRiYWxhbmNl",
            "ci92MTtsb2FkYmFsYW5jZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Loadbalancer.V1.TargetGroup), global::Yandex.Cloud.Loadbalancer.V1.TargetGroup.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "RegionId", "Targets" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Loadbalancer.V1.Target), global::Yandex.Cloud.Loadbalancer.V1.Target.Parser, new[]{ "SubnetId", "Address" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A TargetGroup resource. For more information, see [Target groups and resources](/docs/load-balancer/target-resources).
  /// </summary>
  internal sealed partial class TargetGroup : pb::IMessage<TargetGroup> {
    private static readonly pb::MessageParser<TargetGroup> _parser = new pb::MessageParser<TargetGroup>(() => new TargetGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TargetGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Loadbalancer.V1.TargetGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetGroup(TargetGroup other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      regionId_ = other.regionId_;
      targets_ = other.targets_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetGroup Clone() {
      return new TargetGroup(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Output only. ID of the target group.
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
    /// ID of the folder that the target group belongs to.
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
    /// Output only. Creation timestamp in [RFC3339](https://www.ietf.org/rfc/rfc3339.txt) text format.
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
    /// Name of the target group. 
    /// The name is unique within the folder. 3-63 characters long.
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
    /// Description of the target group. 0-256 characters long.
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
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Resource labels as `` key:value `` pairs. Мaximum of 64 per resource. 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "region_id" field.</summary>
    public const int RegionIdFieldNumber = 7;
    private string regionId_ = "";
    /// <summary>
    /// ID of the region where the target group resides.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegionId {
      get { return regionId_; }
      set {
        regionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "targets" field.</summary>
    public const int TargetsFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Loadbalancer.V1.Target> _repeated_targets_codec
        = pb::FieldCodec.ForMessage(74, global::Yandex.Cloud.Loadbalancer.V1.Target.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Loadbalancer.V1.Target> targets_ = new pbc::RepeatedField<global::Yandex.Cloud.Loadbalancer.V1.Target>();
    /// <summary>
    /// A list of targets in the target group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Loadbalancer.V1.Target> Targets {
      get { return targets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TargetGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TargetGroup other) {
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
      if (RegionId != other.RegionId) return false;
      if(!targets_.Equals(other.targets_)) return false;
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
      if (RegionId.Length != 0) hash ^= RegionId.GetHashCode();
      hash ^= targets_.GetHashCode();
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
      if (RegionId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(RegionId);
      }
      targets_.WriteTo(output, _repeated_targets_codec);
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
      if (RegionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegionId);
      }
      size += targets_.CalculateSize(_repeated_targets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TargetGroup other) {
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
      if (other.RegionId.Length != 0) {
        RegionId = other.RegionId;
      }
      targets_.Add(other.targets_);
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
            RegionId = input.ReadString();
            break;
          }
          case 74: {
            targets_.AddEntriesFrom(input, _repeated_targets_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A Target resource. For more information, see [Target groups and resources](/docs/load-balancer/target-resources).
  /// </summary>
  internal sealed partial class Target : pb::IMessage<Target> {
    private static readonly pb::MessageParser<Target> _parser = new pb::MessageParser<Target>(() => new Target());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Target> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Loadbalancer.V1.TargetGroupReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Target() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Target(Target other) : this() {
      subnetId_ = other.subnetId_;
      address_ = other.address_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Target Clone() {
      return new Target(this);
    }

    /// <summary>Field number for the "subnet_id" field.</summary>
    public const int SubnetIdFieldNumber = 1;
    private string subnetId_ = "";
    /// <summary>
    /// ID of the subnet that targets are connected to. 
    /// All targets in the target group must be connected to the same subnet within a single availability zone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SubnetId {
      get { return subnetId_; }
      set {
        subnetId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 2;
    private string address_ = "";
    /// <summary>
    /// IP address of the target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Target);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Target other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SubnetId != other.SubnetId) return false;
      if (Address != other.Address) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SubnetId.Length != 0) hash ^= SubnetId.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
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
      if (SubnetId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SubnetId);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SubnetId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SubnetId);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Target other) {
      if (other == null) {
        return;
      }
      if (other.SubnetId.Length != 0) {
        SubnetId = other.SubnetId;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
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
            SubnetId = input.ReadString();
            break;
          }
          case 18: {
            Address = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code