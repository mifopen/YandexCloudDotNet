// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/kms/v1/symmetric_key.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Kms.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/kms/v1/symmetric_key.proto</summary>
  internal static partial class SymmetricKeyReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/kms/v1/symmetric_key.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SymmetricKeyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cid5YW5kZXgvY2xvdWQva21zL3YxL3N5bW1ldHJpY19rZXkucHJvdG8SE3lh",
            "bmRleC5jbG91ZC5rbXMudjEaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAu",
            "cHJvdG8aHmdvb2dsZS9wcm90b2J1Zi9kdXJhdGlvbi5wcm90byL6BAoMU3lt",
            "bWV0cmljS2V5EgoKAmlkGAEgASgJEhEKCWZvbGRlcl9pZBgCIAEoCRIuCgpj",
            "cmVhdGVkX2F0GAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIM",
            "CgRuYW1lGAQgASgJEhMKC2Rlc2NyaXB0aW9uGAUgASgJEj0KBmxhYmVscxgG",
            "IAMoCzItLnlhbmRleC5jbG91ZC5rbXMudjEuU3ltbWV0cmljS2V5LkxhYmVs",
            "c0VudHJ5EjgKBnN0YXR1cxgHIAEoDjIoLnlhbmRleC5jbG91ZC5rbXMudjEu",
            "U3ltbWV0cmljS2V5LlN0YXR1cxJBCg9wcmltYXJ5X3ZlcnNpb24YCCABKAsy",
            "KC55YW5kZXguY2xvdWQua21zLnYxLlN5bW1ldHJpY0tleVZlcnNpb24SQgoR",
            "ZGVmYXVsdF9hbGdvcml0aG0YCSABKA4yJy55YW5kZXguY2xvdWQua21zLnYx",
            "LlN5bW1ldHJpY0FsZ29yaXRobRIuCgpyb3RhdGVkX2F0GAogASgLMhouZ29v",
            "Z2xlLnByb3RvYnVmLlRpbWVzdGFtcBIyCg9yb3RhdGlvbl9wZXJpb2QYCyAB",
            "KAsyGS5nb29nbGUucHJvdG9idWYuRHVyYXRpb24SGwoTZGVsZXRpb25fcHJv",
            "dGVjdGlvbhgMIAEoCBotCgtMYWJlbHNFbnRyeRILCgNrZXkYASABKAkSDQoF",
            "dmFsdWUYAiABKAk6AjgBIkgKBlN0YXR1cxIWChJTVEFUVVNfVU5TUEVDSUZJ",
            "RUQQABIMCghDUkVBVElORxABEgoKBkFDVElWRRACEgwKCElOQUNUSVZFEAMi",
            "+wIKE1N5bW1ldHJpY0tleVZlcnNpb24SCgoCaWQYASABKAkSDgoGa2V5X2lk",
            "GAIgASgJEj8KBnN0YXR1cxgDIAEoDjIvLnlhbmRleC5jbG91ZC5rbXMudjEu",
            "U3ltbWV0cmljS2V5VmVyc2lvbi5TdGF0dXMSOgoJYWxnb3JpdGhtGAQgASgO",
            "MicueWFuZGV4LmNsb3VkLmttcy52MS5TeW1tZXRyaWNBbGdvcml0aG0SLgoK",
            "Y3JlYXRlZF9hdBgFIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXAS",
            "DwoHcHJpbWFyeRgGIAEoCBIuCgpkZXN0cm95X2F0GAcgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcCJaCgZTdGF0dXMSFgoSU1RBVFVTX1VOU1BF",
            "Q0lGSUVEEAASCgoGQUNUSVZFEAESHQoZU0NIRURVTEVEX0ZPUl9ERVNUUlVD",
            "VElPThACEg0KCURFU1RST1lFRBADKmAKElN5bW1ldHJpY0FsZ29yaXRobRIj",
            "Ch9TWU1NRVRSSUNfQUxHT1JJVEhNX1VOU1BFQ0lGSUVEEAASCwoHQUVTXzEy",
            "OBABEgsKB0FFU18xOTIQAhILCgdBRVNfMjU2EANCVgoXeWFuZGV4LmNsb3Vk",
            "LmFwaS5rbXMudjFaO2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdlbnBy",
            "b3RvL3lhbmRleC9jbG91ZC9rbXMvdjE7a21zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Kms.V1.SymmetricKey), global::Yandex.Cloud.Kms.V1.SymmetricKey.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "Status", "PrimaryVersion", "DefaultAlgorithm", "RotatedAt", "RotationPeriod", "DeletionProtection" }, null, new[]{ typeof(global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status) }, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion), global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Parser, new[]{ "Id", "KeyId", "Status", "Algorithm", "CreatedAt", "Primary", "DestroyAt" }, null, new[]{ typeof(global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status) }, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Supported symmetric encryption algorithms.
  /// </summary>
  internal enum SymmetricAlgorithm {
    [pbr::OriginalName("SYMMETRIC_ALGORITHM_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// AES algorithm with 128-bit keys.
    /// </summary>
    [pbr::OriginalName("AES_128")] Aes128 = 1,
    /// <summary>
    /// AES algorithm with 192-bit keys.
    /// </summary>
    [pbr::OriginalName("AES_192")] Aes192 = 2,
    /// <summary>
    /// AES algorithm with 256-bit keys.
    /// </summary>
    [pbr::OriginalName("AES_256")] Aes256 = 3,
  }

  #endregion

  #region Messages
  /// <summary>
  /// A symmetric KMS key that may contain several versions of the cryptographic material.
  /// </summary>
  internal sealed partial class SymmetricKey : pb::IMessage<SymmetricKey> {
    private static readonly pb::MessageParser<SymmetricKey> _parser = new pb::MessageParser<SymmetricKey>(() => new SymmetricKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SymmetricKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Kms.V1.SymmetricKeyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKey(SymmetricKey other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      status_ = other.status_;
      primaryVersion_ = other.primaryVersion_ != null ? other.primaryVersion_.Clone() : null;
      defaultAlgorithm_ = other.defaultAlgorithm_;
      rotatedAt_ = other.rotatedAt_ != null ? other.rotatedAt_.Clone() : null;
      rotationPeriod_ = other.rotationPeriod_ != null ? other.rotationPeriod_.Clone() : null;
      deletionProtection_ = other.deletionProtection_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKey Clone() {
      return new SymmetricKey(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the key.
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
    /// ID of the folder that the key belongs to.
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
    /// Time when the key was created.
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
    /// Name of the key.
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
    /// Description of the key.
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
    /// Custom labels for the key as `key:value` pairs. Maximum 64 per key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 7;
    private global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status status_ = global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status.Unspecified;
    /// <summary>
    /// Current status of the key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "primary_version" field.</summary>
    public const int PrimaryVersionFieldNumber = 8;
    private global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion primaryVersion_;
    /// <summary>
    /// Primary version of the key, used as the default for all encrypt/decrypt operations,
    /// when no version ID is specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion PrimaryVersion {
      get { return primaryVersion_; }
      set {
        primaryVersion_ = value;
      }
    }

    /// <summary>Field number for the "default_algorithm" field.</summary>
    public const int DefaultAlgorithmFieldNumber = 9;
    private global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm defaultAlgorithm_ = global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified;
    /// <summary>
    /// Default encryption algorithm to be used with new versions of the key.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm DefaultAlgorithm {
      get { return defaultAlgorithm_; }
      set {
        defaultAlgorithm_ = value;
      }
    }

    /// <summary>Field number for the "rotated_at" field.</summary>
    public const int RotatedAtFieldNumber = 10;
    private global::Google.Protobuf.WellKnownTypes.Timestamp rotatedAt_;
    /// <summary>
    /// Time of the last key rotation (time when the last version was created).
    /// Empty if the key does not have versions yet.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp RotatedAt {
      get { return rotatedAt_; }
      set {
        rotatedAt_ = value;
      }
    }

    /// <summary>Field number for the "rotation_period" field.</summary>
    public const int RotationPeriodFieldNumber = 11;
    private global::Google.Protobuf.WellKnownTypes.Duration rotationPeriod_;
    /// <summary>
    /// Time period between automatic key rotations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration RotationPeriod {
      get { return rotationPeriod_; }
      set {
        rotationPeriod_ = value;
      }
    }

    /// <summary>Field number for the "deletion_protection" field.</summary>
    public const int DeletionProtectionFieldNumber = 12;
    private bool deletionProtection_;
    /// <summary>
    /// Flag that inhibits deletion of the key
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool DeletionProtection {
      get { return deletionProtection_; }
      set {
        deletionProtection_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SymmetricKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SymmetricKey other) {
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
      if (!object.Equals(PrimaryVersion, other.PrimaryVersion)) return false;
      if (DefaultAlgorithm != other.DefaultAlgorithm) return false;
      if (!object.Equals(RotatedAt, other.RotatedAt)) return false;
      if (!object.Equals(RotationPeriod, other.RotationPeriod)) return false;
      if (DeletionProtection != other.DeletionProtection) return false;
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
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status.Unspecified) hash ^= Status.GetHashCode();
      if (primaryVersion_ != null) hash ^= PrimaryVersion.GetHashCode();
      if (DefaultAlgorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) hash ^= DefaultAlgorithm.GetHashCode();
      if (rotatedAt_ != null) hash ^= RotatedAt.GetHashCode();
      if (rotationPeriod_ != null) hash ^= RotationPeriod.GetHashCode();
      if (DeletionProtection != false) hash ^= DeletionProtection.GetHashCode();
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
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status.Unspecified) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Status);
      }
      if (primaryVersion_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PrimaryVersion);
      }
      if (DefaultAlgorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) DefaultAlgorithm);
      }
      if (rotatedAt_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RotatedAt);
      }
      if (rotationPeriod_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(RotationPeriod);
      }
      if (DeletionProtection != false) {
        output.WriteRawTag(96);
        output.WriteBool(DeletionProtection);
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
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (primaryVersion_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PrimaryVersion);
      }
      if (DefaultAlgorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DefaultAlgorithm);
      }
      if (rotatedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RotatedAt);
      }
      if (rotationPeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RotationPeriod);
      }
      if (DeletionProtection != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SymmetricKey other) {
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
      if (other.Status != global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status.Unspecified) {
        Status = other.Status;
      }
      if (other.primaryVersion_ != null) {
        if (primaryVersion_ == null) {
          PrimaryVersion = new global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion();
        }
        PrimaryVersion.MergeFrom(other.PrimaryVersion);
      }
      if (other.DefaultAlgorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        DefaultAlgorithm = other.DefaultAlgorithm;
      }
      if (other.rotatedAt_ != null) {
        if (rotatedAt_ == null) {
          RotatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        RotatedAt.MergeFrom(other.RotatedAt);
      }
      if (other.rotationPeriod_ != null) {
        if (rotationPeriod_ == null) {
          RotationPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        RotationPeriod.MergeFrom(other.RotationPeriod);
      }
      if (other.DeletionProtection != false) {
        DeletionProtection = other.DeletionProtection;
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
            Status = (global::Yandex.Cloud.Kms.V1.SymmetricKey.Types.Status) input.ReadEnum();
            break;
          }
          case 66: {
            if (primaryVersion_ == null) {
              PrimaryVersion = new global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion();
            }
            input.ReadMessage(PrimaryVersion);
            break;
          }
          case 72: {
            DefaultAlgorithm = (global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm) input.ReadEnum();
            break;
          }
          case 82: {
            if (rotatedAt_ == null) {
              RotatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(RotatedAt);
            break;
          }
          case 90: {
            if (rotationPeriod_ == null) {
              RotationPeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(RotationPeriod);
            break;
          }
          case 96: {
            DeletionProtection = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SymmetricKey message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The key is being created.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// The key is active and can be used for encryption and decryption.
        /// Can be set to INACTIVE using the [SymmetricKeyService.Update] method.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 2,
        /// <summary>
        /// The key is inactive and unusable.
        /// Can be set to ACTIVE using the [SymmetricKeyService.Update] method.
        /// </summary>
        [pbr::OriginalName("INACTIVE")] Inactive = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Symmetric KMS key version: metadata about actual cryptographic data.
  /// </summary>
  internal sealed partial class SymmetricKeyVersion : pb::IMessage<SymmetricKeyVersion> {
    private static readonly pb::MessageParser<SymmetricKeyVersion> _parser = new pb::MessageParser<SymmetricKeyVersion>(() => new SymmetricKeyVersion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SymmetricKeyVersion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Kms.V1.SymmetricKeyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKeyVersion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKeyVersion(SymmetricKeyVersion other) : this() {
      id_ = other.id_;
      keyId_ = other.keyId_;
      status_ = other.status_;
      algorithm_ = other.algorithm_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      primary_ = other.primary_;
      destroyAt_ = other.destroyAt_ != null ? other.destroyAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SymmetricKeyVersion Clone() {
      return new SymmetricKeyVersion(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the key version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_id" field.</summary>
    public const int KeyIdFieldNumber = 2;
    private string keyId_ = "";
    /// <summary>
    /// ID of the symmetric KMS key that the version belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeyId {
      get { return keyId_; }
      set {
        keyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status status_ = global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status.Unspecified;
    /// <summary>
    /// Status of the key version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "algorithm" field.</summary>
    public const int AlgorithmFieldNumber = 4;
    private global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm algorithm_ = global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified;
    /// <summary>
    /// Encryption algorithm that should be used when using the key version to encrypt plaintext.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm Algorithm {
      get { return algorithm_; }
      set {
        algorithm_ = value;
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Time when the key version was created.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "primary" field.</summary>
    public const int PrimaryFieldNumber = 6;
    private bool primary_;
    /// <summary>
    /// Indication of a primary version, that is to be used by default for all cryptographic
    /// operations that don't have a key version explicitly specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Primary {
      get { return primary_; }
      set {
        primary_ = value;
      }
    }

    /// <summary>Field number for the "destroy_at" field.</summary>
    public const int DestroyAtFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp destroyAt_;
    /// <summary>
    /// Time when the key version is going to be destroyed. Empty unless the status
    /// is `SCHEDULED_FOR_DESTRUCTION`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DestroyAt {
      get { return destroyAt_; }
      set {
        destroyAt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SymmetricKeyVersion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SymmetricKeyVersion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (KeyId != other.KeyId) return false;
      if (Status != other.Status) return false;
      if (Algorithm != other.Algorithm) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Primary != other.Primary) return false;
      if (!object.Equals(DestroyAt, other.DestroyAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (KeyId.Length != 0) hash ^= KeyId.GetHashCode();
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status.Unspecified) hash ^= Status.GetHashCode();
      if (Algorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) hash ^= Algorithm.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Primary != false) hash ^= Primary.GetHashCode();
      if (destroyAt_ != null) hash ^= DestroyAt.GetHashCode();
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
      if (KeyId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(KeyId);
      }
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Algorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Algorithm);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(CreatedAt);
      }
      if (Primary != false) {
        output.WriteRawTag(48);
        output.WriteBool(Primary);
      }
      if (destroyAt_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(DestroyAt);
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
      if (KeyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(KeyId);
      }
      if (Status != global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Algorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Algorithm);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (Primary != false) {
        size += 1 + 1;
      }
      if (destroyAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DestroyAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SymmetricKeyVersion other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.KeyId.Length != 0) {
        KeyId = other.KeyId;
      }
      if (other.Status != global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status.Unspecified) {
        Status = other.Status;
      }
      if (other.Algorithm != global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm.Unspecified) {
        Algorithm = other.Algorithm;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.Primary != false) {
        Primary = other.Primary;
      }
      if (other.destroyAt_ != null) {
        if (destroyAt_ == null) {
          DestroyAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DestroyAt.MergeFrom(other.DestroyAt);
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
            KeyId = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Yandex.Cloud.Kms.V1.SymmetricKeyVersion.Types.Status) input.ReadEnum();
            break;
          }
          case 32: {
            Algorithm = (global::Yandex.Cloud.Kms.V1.SymmetricAlgorithm) input.ReadEnum();
            break;
          }
          case 42: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 48: {
            Primary = input.ReadBool();
            break;
          }
          case 58: {
            if (destroyAt_ == null) {
              DestroyAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DestroyAt);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SymmetricKeyVersion message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible version status.
      /// </summary>
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The version is active and can be used for encryption and decryption.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 1,
        /// <summary>
        /// The version is scheduled for destruction, the time when it will be destroyed
        /// is specified in the [SymmetricKeyVersion.destroy_at] field.
        /// </summary>
        [pbr::OriginalName("SCHEDULED_FOR_DESTRUCTION")] ScheduledForDestruction = 2,
        /// <summary>
        /// The version is destroyed and cannot be recovered.
        /// </summary>
        [pbr::OriginalName("DESTROYED")] Destroyed = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
