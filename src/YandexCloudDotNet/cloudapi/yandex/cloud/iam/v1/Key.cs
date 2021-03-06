// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iam/v1/key.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Iam.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/iam/v1/key.proto</summary>
  internal static partial class KeyReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/iam/v1/key.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch15YW5kZXgvY2xvdWQvaWFtL3YxL2tleS5wcm90bxITeWFuZGV4LmNsb3Vk",
            "LmlhbS52MRofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byKtAgoD",
            "S2V5EgoKAmlkGAEgASgJEhkKD3VzZXJfYWNjb3VudF9pZBgCIAEoCUgAEhwK",
            "EnNlcnZpY2VfYWNjb3VudF9pZBgDIAEoCUgAEi4KCmNyZWF0ZWRfYXQYBCAB",
            "KAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEhMKC2Rlc2NyaXB0aW9u",
            "GAUgASgJEjkKDWtleV9hbGdvcml0aG0YBiABKA4yIi55YW5kZXguY2xvdWQu",
            "aWFtLnYxLktleS5BbGdvcml0aG0SEgoKcHVibGljX2tleRgHIAEoCSJCCglB",
            "bGdvcml0aG0SGQoVQUxHT1JJVEhNX1VOU1BFQ0lGSUVEEAASDAoIUlNBXzIw",
            "NDgQARIMCghSU0FfNDA5NhACQgkKB3N1YmplY3RCVgoXeWFuZGV4LmNsb3Vk",
            "LmFwaS5pYW0udjFaO2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdlbnBy",
            "b3RvL3lhbmRleC9jbG91ZC9pYW0vdjE7aWFtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iam.V1.Key), global::Yandex.Cloud.Iam.V1.Key.Parser, new[]{ "Id", "UserAccountId", "ServiceAccountId", "CreatedAt", "Description", "KeyAlgorithm", "PublicKey" }, new[]{ "Subject" }, new[]{ typeof(global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Key resource. For more information, see [Authorized keys](/docs/iam/concepts/authorization/key).
  /// </summary>
  internal sealed partial class Key : pb::IMessage<Key> {
    private static readonly pb::MessageParser<Key> _parser = new pb::MessageParser<Key>(() => new Key());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Key> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iam.V1.KeyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Key() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Key(Key other) : this() {
      id_ = other.id_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      description_ = other.description_;
      keyAlgorithm_ = other.keyAlgorithm_;
      publicKey_ = other.publicKey_;
      switch (other.SubjectCase) {
        case SubjectOneofCase.UserAccountId:
          UserAccountId = other.UserAccountId;
          break;
        case SubjectOneofCase.ServiceAccountId:
          ServiceAccountId = other.ServiceAccountId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Key Clone() {
      return new Key(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the Key resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_account_id" field.</summary>
    public const int UserAccountIdFieldNumber = 2;
    /// <summary>
    /// ID of the user account that the Key resource belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserAccountId {
      get { return subjectCase_ == SubjectOneofCase.UserAccountId ? (string) subject_ : ""; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        subjectCase_ = SubjectOneofCase.UserAccountId;
      }
    }

    /// <summary>Field number for the "service_account_id" field.</summary>
    public const int ServiceAccountIdFieldNumber = 3;
    /// <summary>
    /// ID of the service account that the Key resource belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ServiceAccountId {
      get { return subjectCase_ == SubjectOneofCase.ServiceAccountId ? (string) subject_ : ""; }
      set {
        subject_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        subjectCase_ = SubjectOneofCase.ServiceAccountId;
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

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Description of the Key resource. 0-256 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key_algorithm" field.</summary>
    public const int KeyAlgorithmFieldNumber = 6;
    private global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm keyAlgorithm_ = global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm.Unspecified;
    /// <summary>
    /// An algorithm used to generate a key pair of the Key resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm KeyAlgorithm {
      get { return keyAlgorithm_; }
      set {
        keyAlgorithm_ = value;
      }
    }

    /// <summary>Field number for the "public_key" field.</summary>
    public const int PublicKeyFieldNumber = 7;
    private string publicKey_ = "";
    /// <summary>
    /// A public key of the Key resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublicKey {
      get { return publicKey_; }
      set {
        publicKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private object subject_;
    /// <summary>Enum of possible cases for the "subject" oneof.</summary>
    public enum SubjectOneofCase {
      None = 0,
      UserAccountId = 2,
      ServiceAccountId = 3,
    }
    private SubjectOneofCase subjectCase_ = SubjectOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubjectOneofCase SubjectCase {
      get { return subjectCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSubject() {
      subjectCase_ = SubjectOneofCase.None;
      subject_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Key);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Key other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (UserAccountId != other.UserAccountId) return false;
      if (ServiceAccountId != other.ServiceAccountId) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Description != other.Description) return false;
      if (KeyAlgorithm != other.KeyAlgorithm) return false;
      if (PublicKey != other.PublicKey) return false;
      if (SubjectCase != other.SubjectCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (subjectCase_ == SubjectOneofCase.UserAccountId) hash ^= UserAccountId.GetHashCode();
      if (subjectCase_ == SubjectOneofCase.ServiceAccountId) hash ^= ServiceAccountId.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (KeyAlgorithm != global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm.Unspecified) hash ^= KeyAlgorithm.GetHashCode();
      if (PublicKey.Length != 0) hash ^= PublicKey.GetHashCode();
      hash ^= (int) subjectCase_;
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
      if (subjectCase_ == SubjectOneofCase.UserAccountId) {
        output.WriteRawTag(18);
        output.WriteString(UserAccountId);
      }
      if (subjectCase_ == SubjectOneofCase.ServiceAccountId) {
        output.WriteRawTag(26);
        output.WriteString(ServiceAccountId);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreatedAt);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      if (KeyAlgorithm != global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) KeyAlgorithm);
      }
      if (PublicKey.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(PublicKey);
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
      if (subjectCase_ == SubjectOneofCase.UserAccountId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserAccountId);
      }
      if (subjectCase_ == SubjectOneofCase.ServiceAccountId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ServiceAccountId);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (KeyAlgorithm != global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeyAlgorithm);
      }
      if (PublicKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Key other) {
      if (other == null) {
        return;
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
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.KeyAlgorithm != global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm.Unspecified) {
        KeyAlgorithm = other.KeyAlgorithm;
      }
      if (other.PublicKey.Length != 0) {
        PublicKey = other.PublicKey;
      }
      switch (other.SubjectCase) {
        case SubjectOneofCase.UserAccountId:
          UserAccountId = other.UserAccountId;
          break;
        case SubjectOneofCase.ServiceAccountId:
          ServiceAccountId = other.ServiceAccountId;
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
            UserAccountId = input.ReadString();
            break;
          }
          case 26: {
            ServiceAccountId = input.ReadString();
            break;
          }
          case 34: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 48: {
            KeyAlgorithm = (global::Yandex.Cloud.Iam.V1.Key.Types.Algorithm) input.ReadEnum();
            break;
          }
          case 58: {
            PublicKey = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Key message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Algorithm {
        [pbr::OriginalName("ALGORITHM_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// RSA with a 2048-bit key size. Default value.
        /// </summary>
        [pbr::OriginalName("RSA_2048")] Rsa2048 = 1,
        /// <summary>
        /// RSA with a 4096-bit key size.
        /// </summary>
        [pbr::OriginalName("RSA_4096")] Rsa4096 = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
