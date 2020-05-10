// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iot/devices/v1/device.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Iot.Devices.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/iot/devices/v1/device.proto</summary>
  internal static partial class DeviceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/iot/devices/v1/device.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih5YW5kZXgvY2xvdWQvaW90L2RldmljZXMvdjEvZGV2aWNlLnByb3RvEht5",
            "YW5kZXguY2xvdWQuaW90LmRldmljZXMudjEaH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8aHXlhbmRleC9jbG91ZC92YWxpZGF0aW9uLnByb3Rv",
            "Iv8BCgZEZXZpY2USCgoCaWQYASABKAkSEwoLcmVnaXN0cnlfaWQYAiABKAkS",
            "LgoKY3JlYXRlZF9hdBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3Rh",
            "bXASDAoEbmFtZRgEIAEoCRITCgtkZXNjcmlwdGlvbhgFIAEoCRJMCg10b3Bp",
            "Y19hbGlhc2VzGAYgAygLMjUueWFuZGV4LmNsb3VkLmlvdC5kZXZpY2VzLnYx",
            "LkRldmljZS5Ub3BpY0FsaWFzZXNFbnRyeRozChFUb3BpY0FsaWFzZXNFbnRy",
            "eRILCgNrZXkYASABKAkSDQoFdmFsdWUYAiABKAk6AjgBIoUBChFEZXZpY2VD",
            "ZXJ0aWZpY2F0ZRIRCglkZXZpY2VfaWQYASABKAkSEwoLZmluZ2VycHJpbnQY",
            "AiABKAkSGAoQY2VydGlmaWNhdGVfZGF0YRgDIAEoCRIuCgpjcmVhdGVkX2F0",
            "GAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcCJfCg5EZXZpY2VQ",
            "YXNzd29yZBIRCglkZXZpY2VfaWQYASABKAkSCgoCaWQYAiABKAkSLgoKY3Jl",
            "YXRlZF9hdBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCagof",
            "eWFuZGV4LmNsb3VkLmFwaS5pb3QuZGV2aWNlcy52MVpHZ2l0aHViLmNvbS95",
            "YW5kZXgtY2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2lvdC9kZXZp",
            "Y2VzL3YxO2RldmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.Device), global::Yandex.Cloud.Iot.Devices.V1.Device.Parser, new[]{ "Id", "RegistryId", "CreatedAt", "Name", "Description", "TopicAliases" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.DeviceCertificate), global::Yandex.Cloud.Iot.Devices.V1.DeviceCertificate.Parser, new[]{ "DeviceId", "Fingerprint", "CertificateData", "CreatedAt" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.DevicePassword), global::Yandex.Cloud.Iot.Devices.V1.DevicePassword.Parser, new[]{ "DeviceId", "Id", "CreatedAt" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A device. For more information, see [Device](/docs/iot-core/concepts/index#device).
  /// </summary>
  internal sealed partial class Device : pb::IMessage<Device> {
    private static readonly pb::MessageParser<Device> _parser = new pb::MessageParser<Device>(() => new Device());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Device> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.DeviceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device(Device other) : this() {
      id_ = other.id_;
      registryId_ = other.registryId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      topicAliases_ = other.topicAliases_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Device Clone() {
      return new Device(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "registry_id" field.</summary>
    public const int RegistryIdFieldNumber = 2;
    private string registryId_ = "";
    /// <summary>
    /// ID of the registry that the device belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegistryId {
      get { return registryId_; }
      set {
        registryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp.
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
    /// Name of the device. The name is unique within the registry.
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
    /// Description of the device. 0-256 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "topic_aliases" field.</summary>
    public const int TopicAliasesFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_topicAliases_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
    private readonly pbc::MapField<string, string> topicAliases_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Alias of a device topic.
    ///
    /// Alias is an alternate name of a device topic assigned by the user. Map alias to canonical topic name prefix, e.g. `my/custom/alias` match to `$device/abcdef/events`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> TopicAliases {
      get { return topicAliases_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Device);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Device other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (RegistryId != other.RegistryId) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (!TopicAliases.Equals(other.TopicAliases)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (RegistryId.Length != 0) hash ^= RegistryId.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= TopicAliases.GetHashCode();
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
      if (RegistryId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RegistryId);
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
      topicAliases_.WriteTo(output, _map_topicAliases_codec);
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
      if (RegistryId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegistryId);
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
      size += topicAliases_.CalculateSize(_map_topicAliases_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Device other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.RegistryId.Length != 0) {
        RegistryId = other.RegistryId;
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
      topicAliases_.Add(other.topicAliases_);
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
            RegistryId = input.ReadString();
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
            topicAliases_.AddEntriesFrom(input, _map_topicAliases_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A device certificate. For more information, see [Managing device certificates](/docs/iot-core/operations/certificates/device-certificates).
  /// </summary>
  internal sealed partial class DeviceCertificate : pb::IMessage<DeviceCertificate> {
    private static readonly pb::MessageParser<DeviceCertificate> _parser = new pb::MessageParser<DeviceCertificate>(() => new DeviceCertificate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceCertificate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.DeviceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCertificate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCertificate(DeviceCertificate other) : this() {
      deviceId_ = other.deviceId_;
      fingerprint_ = other.fingerprint_;
      certificateData_ = other.certificateData_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceCertificate Clone() {
      return new DeviceCertificate(this);
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private string deviceId_ = "";
    /// <summary>
    /// ID of the device that the certificate belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fingerprint" field.</summary>
    public const int FingerprintFieldNumber = 2;
    private string fingerprint_ = "";
    /// <summary>
    /// SHA256 hash of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Fingerprint {
      get { return fingerprint_; }
      set {
        fingerprint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "certificate_data" field.</summary>
    public const int CertificateDataFieldNumber = 3;
    private string certificateData_ = "";
    /// <summary>
    /// Public part of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CertificateData {
      get { return certificateData_; }
      set {
        certificateData_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceCertificate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceCertificate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (Fingerprint != other.Fingerprint) return false;
      if (CertificateData != other.CertificateData) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (Fingerprint.Length != 0) hash ^= Fingerprint.GetHashCode();
      if (CertificateData.Length != 0) hash ^= CertificateData.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceId);
      }
      if (Fingerprint.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Fingerprint);
      }
      if (CertificateData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CertificateData);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatedAt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (Fingerprint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Fingerprint);
      }
      if (CertificateData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificateData);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceCertificate other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.Fingerprint.Length != 0) {
        Fingerprint = other.Fingerprint;
      }
      if (other.CertificateData.Length != 0) {
        CertificateData = other.CertificateData;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
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
            DeviceId = input.ReadString();
            break;
          }
          case 18: {
            Fingerprint = input.ReadString();
            break;
          }
          case 26: {
            CertificateData = input.ReadString();
            break;
          }
          case 34: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A device password.
  /// </summary>
  internal sealed partial class DevicePassword : pb::IMessage<DevicePassword> {
    private static readonly pb::MessageParser<DevicePassword> _parser = new pb::MessageParser<DevicePassword>(() => new DevicePassword());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DevicePassword> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.DeviceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DevicePassword() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DevicePassword(DevicePassword other) : this() {
      deviceId_ = other.deviceId_;
      id_ = other.id_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DevicePassword Clone() {
      return new DevicePassword(this);
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private string deviceId_ = "";
    /// <summary>
    /// ID of the device that the password belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    /// <summary>
    /// ID of the password.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DevicePassword);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DevicePassword other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
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
      if (DeviceId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(DeviceId);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreatedAt);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DeviceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceId);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DevicePassword other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
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
            DeviceId = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 26: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
