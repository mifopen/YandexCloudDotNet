// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iot/devices/v1/registry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Iot.Devices.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/iot/devices/v1/registry.proto</summary>
  internal static partial class RegistryReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/iot/devices/v1/registry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegistryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip5YW5kZXgvY2xvdWQvaW90L2RldmljZXMvdjEvcmVnaXN0cnkucHJvdG8S",
            "G3lhbmRleC5jbG91ZC5pb3QuZGV2aWNlcy52MRofZ29vZ2xlL3Byb3RvYnVm",
            "L3RpbWVzdGFtcC5wcm90bxodeWFuZGV4L2Nsb3VkL3ZhbGlkYXRpb24ucHJv",
            "dG8ijAMKCFJlZ2lzdHJ5EgoKAmlkGAEgASgJEhEKCWZvbGRlcl9pZBgCIAEo",
            "CRIuCgpjcmVhdGVkX2F0GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVz",
            "dGFtcBIMCgRuYW1lGAQgASgJEhMKC2Rlc2NyaXB0aW9uGAUgASgJEkEKBmxh",
            "YmVscxgGIAMoCzIxLnlhbmRleC5jbG91ZC5pb3QuZGV2aWNlcy52MS5SZWdp",
            "c3RyeS5MYWJlbHNFbnRyeRI8CgZzdGF0dXMYByABKA4yLC55YW5kZXguY2xv",
            "dWQuaW90LmRldmljZXMudjEuUmVnaXN0cnkuU3RhdHVzEhQKDGxvZ19ncm91",
            "cF9pZBgIIAEoCRotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs",
            "dWUYAiABKAk6AjgBIkgKBlN0YXR1cxIWChJTVEFUVVNfVU5TUEVDSUZJRUQQ",
            "ABIMCghDUkVBVElORxABEgoKBkFDVElWRRACEgwKCERFTEVUSU5HEAMiiQEK",
            "E1JlZ2lzdHJ5Q2VydGlmaWNhdGUSEwoLcmVnaXN0cnlfaWQYASABKAkSEwoL",
            "ZmluZ2VycHJpbnQYAiABKAkSGAoQY2VydGlmaWNhdGVfZGF0YRgDIAEoCRIu",
            "CgpjcmVhdGVkX2F0GAQgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cCJFCgtEZXZpY2VBbGlhcxIRCglkZXZpY2VfaWQYASABKAkSFAoMdG9waWNf",
            "cHJlZml4GAIgASgJEg0KBWFsaWFzGAMgASgJImMKEFJlZ2lzdHJ5UGFzc3dv",
            "cmQSEwoLcmVnaXN0cnlfaWQYASABKAkSCgoCaWQYAiABKAkSLgoKY3JlYXRl",
            "ZF9hdBgDIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCagofeWFu",
            "ZGV4LmNsb3VkLmFwaS5pb3QuZGV2aWNlcy52MVpHZ2l0aHViLmNvbS95YW5k",
            "ZXgtY2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2lvdC9kZXZpY2Vz",
            "L3YxO2RldmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.Registry), global::Yandex.Cloud.Iot.Devices.V1.Registry.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "Status", "LogGroupId" }, null, new[]{ typeof(global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status) }, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.RegistryCertificate), global::Yandex.Cloud.Iot.Devices.V1.RegistryCertificate.Parser, new[]{ "RegistryId", "Fingerprint", "CertificateData", "CreatedAt" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.DeviceAlias), global::Yandex.Cloud.Iot.Devices.V1.DeviceAlias.Parser, new[]{ "DeviceId", "TopicPrefix", "Alias" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.RegistryPassword), global::Yandex.Cloud.Iot.Devices.V1.RegistryPassword.Parser, new[]{ "RegistryId", "Id", "CreatedAt" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A registry. For more information, see [Registry](/docs/iot-core/concepts/index#registry).
  /// </summary>
  internal sealed partial class Registry : pb::IMessage<Registry> {
    private static readonly pb::MessageParser<Registry> _parser = new pb::MessageParser<Registry>(() => new Registry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Registry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Registry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Registry(Registry other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      status_ = other.status_;
      logGroupId_ = other.logGroupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Registry Clone() {
      return new Registry(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the registry.
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
    /// ID of the folder that the registry belongs to.
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
    /// Name of the registry. The name is unique within the folder.
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
    /// Description of the registry. 0-256 characters long.
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
    /// Resource labels as `key:value` pairs. Мaximum of 64 per resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 7;
    private global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status status_ = global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status.Unspecified;
    /// <summary>
    /// Status of the registry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "log_group_id" field.</summary>
    public const int LogGroupIdFieldNumber = 8;
    private string logGroupId_ = "";
    /// <summary>
    /// ID of the logs group for the specified registry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LogGroupId {
      get { return logGroupId_; }
      set {
        logGroupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Registry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Registry other) {
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
      if (Status != other.Status) return false;
      if (LogGroupId != other.LogGroupId) return false;
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
      if (Status != global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status.Unspecified) hash ^= Status.GetHashCode();
      if (LogGroupId.Length != 0) hash ^= LogGroupId.GetHashCode();
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
      if (Status != global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Status);
      }
      if (LogGroupId.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(LogGroupId);
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
      if (Status != global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (LogGroupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LogGroupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Registry other) {
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
      if (other.Status != global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status.Unspecified) {
        Status = other.Status;
      }
      if (other.LogGroupId.Length != 0) {
        LogGroupId = other.LogGroupId;
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
          case 56: {
            Status = (global::Yandex.Cloud.Iot.Devices.V1.Registry.Types.Status) input.ReadEnum();
            break;
          }
          case 66: {
            LogGroupId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Registry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Registry is being created.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// Registry is ready to use.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 2,
        /// <summary>
        /// Registry is being deleted.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// A registry certificate. For more information, see [Managing registry certificates](/docs/iot-core/operations/certificates/registry-certificates).
  /// </summary>
  internal sealed partial class RegistryCertificate : pb::IMessage<RegistryCertificate> {
    private static readonly pb::MessageParser<RegistryCertificate> _parser = new pb::MessageParser<RegistryCertificate>(() => new RegistryCertificate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistryCertificate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryCertificate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryCertificate(RegistryCertificate other) : this() {
      registryId_ = other.registryId_;
      fingerprint_ = other.fingerprint_;
      certificateData_ = other.certificateData_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryCertificate Clone() {
      return new RegistryCertificate(this);
    }

    /// <summary>Field number for the "registry_id" field.</summary>
    public const int RegistryIdFieldNumber = 1;
    private string registryId_ = "";
    /// <summary>
    /// ID of the registry that the certificate belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegistryId {
      get { return registryId_; }
      set {
        registryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fingerprint" field.</summary>
    public const int FingerprintFieldNumber = 2;
    private string fingerprint_ = "";
    /// <summary>
    /// SHA256 hash of the certificates.
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
      return Equals(other as RegistryCertificate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistryCertificate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistryId != other.RegistryId) return false;
      if (Fingerprint != other.Fingerprint) return false;
      if (CertificateData != other.CertificateData) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistryId.Length != 0) hash ^= RegistryId.GetHashCode();
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
      if (RegistryId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegistryId);
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
      if (RegistryId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegistryId);
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
    public void MergeFrom(RegistryCertificate other) {
      if (other == null) {
        return;
      }
      if (other.RegistryId.Length != 0) {
        RegistryId = other.RegistryId;
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
            RegistryId = input.ReadString();
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
  /// A device topic alias.
  ///
  /// Alias is an alternate name of a device topic assigned by the user. Map alias to canonical topic name prefix, e.g. `my/custom/alias` match to `$device/abcdef/events`. For more information, see [Using topic aliases](/docs/iot-core/concepts/topic#aliases).
  /// </summary>
  internal sealed partial class DeviceAlias : pb::IMessage<DeviceAlias> {
    private static readonly pb::MessageParser<DeviceAlias> _parser = new pb::MessageParser<DeviceAlias>(() => new DeviceAlias());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeviceAlias> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceAlias() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceAlias(DeviceAlias other) : this() {
      deviceId_ = other.deviceId_;
      topicPrefix_ = other.topicPrefix_;
      alias_ = other.alias_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeviceAlias Clone() {
      return new DeviceAlias(this);
    }

    /// <summary>Field number for the "device_id" field.</summary>
    public const int DeviceIdFieldNumber = 1;
    private string deviceId_ = "";
    /// <summary>
    /// ID of the device that the alias belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DeviceId {
      get { return deviceId_; }
      set {
        deviceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "topic_prefix" field.</summary>
    public const int TopicPrefixFieldNumber = 2;
    private string topicPrefix_ = "";
    /// <summary>
    /// Prefix of a canonical topic name to be aliased, e.g. `$devices/abcdef`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TopicPrefix {
      get { return topicPrefix_; }
      set {
        topicPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "alias" field.</summary>
    public const int AliasFieldNumber = 3;
    private string alias_ = "";
    /// <summary>
    /// Alias of a device topic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Alias {
      get { return alias_; }
      set {
        alias_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeviceAlias);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeviceAlias other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (DeviceId != other.DeviceId) return false;
      if (TopicPrefix != other.TopicPrefix) return false;
      if (Alias != other.Alias) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DeviceId.Length != 0) hash ^= DeviceId.GetHashCode();
      if (TopicPrefix.Length != 0) hash ^= TopicPrefix.GetHashCode();
      if (Alias.Length != 0) hash ^= Alias.GetHashCode();
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
      if (TopicPrefix.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TopicPrefix);
      }
      if (Alias.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Alias);
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
      if (TopicPrefix.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TopicPrefix);
      }
      if (Alias.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Alias);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeviceAlias other) {
      if (other == null) {
        return;
      }
      if (other.DeviceId.Length != 0) {
        DeviceId = other.DeviceId;
      }
      if (other.TopicPrefix.Length != 0) {
        TopicPrefix = other.TopicPrefix;
      }
      if (other.Alias.Length != 0) {
        Alias = other.Alias;
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
            TopicPrefix = input.ReadString();
            break;
          }
          case 26: {
            Alias = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A registry password.
  /// </summary>
  internal sealed partial class RegistryPassword : pb::IMessage<RegistryPassword> {
    private static readonly pb::MessageParser<RegistryPassword> _parser = new pb::MessageParser<RegistryPassword>(() => new RegistryPassword());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegistryPassword> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryPassword() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryPassword(RegistryPassword other) : this() {
      registryId_ = other.registryId_;
      id_ = other.id_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegistryPassword Clone() {
      return new RegistryPassword(this);
    }

    /// <summary>Field number for the "registry_id" field.</summary>
    public const int RegistryIdFieldNumber = 1;
    private string registryId_ = "";
    /// <summary>
    /// ID of the registry that the password belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegistryId {
      get { return registryId_; }
      set {
        registryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      return Equals(other as RegistryPassword);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegistryPassword other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistryId != other.RegistryId) return false;
      if (Id != other.Id) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistryId.Length != 0) hash ^= RegistryId.GetHashCode();
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
      if (RegistryId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegistryId);
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
      if (RegistryId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegistryId);
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
    public void MergeFrom(RegistryPassword other) {
      if (other == null) {
        return;
      }
      if (other.RegistryId.Length != 0) {
        RegistryId = other.RegistryId;
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
            RegistryId = input.ReadString();
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