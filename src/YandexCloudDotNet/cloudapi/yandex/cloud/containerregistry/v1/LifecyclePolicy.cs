// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/containerregistry/v1/lifecycle_policy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Containerregistry.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/containerregistry/v1/lifecycle_policy.proto</summary>
  internal static partial class LifecyclePolicyReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/containerregistry/v1/lifecycle_policy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LifecyclePolicyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjh5YW5kZXgvY2xvdWQvY29udGFpbmVycmVnaXN0cnkvdjEvbGlmZWN5Y2xl",
            "X3BvbGljeS5wcm90bxIheWFuZGV4LmNsb3VkLmNvbnRhaW5lcnJlZ2lzdHJ5",
            "LnYxGh15YW5kZXgvY2xvdWQvdmFsaWRhdGlvbi5wcm90bxoeZ29vZ2xlL3By",
            "b3RvYnVmL2R1cmF0aW9uLnByb3RvGh9nb29nbGUvcHJvdG9idWYvdGltZXN0",
            "YW1wLnByb3RvIs8CCg9MaWZlY3ljbGVQb2xpY3kSCgoCaWQYASABKAkSDAoE",
            "bmFtZRgCIAEoCRIVCg1yZXBvc2l0b3J5X2lkGAMgASgJEhMKC2Rlc2NyaXB0",
            "aW9uGAQgASgJEkkKBnN0YXR1cxgFIAEoDjI5LnlhbmRleC5jbG91ZC5jb250",
            "YWluZXJyZWdpc3RyeS52MS5MaWZlY3ljbGVQb2xpY3kuU3RhdHVzEi4KCmNy",
            "ZWF0ZWRfYXQYBiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEj8K",
            "BXJ1bGVzGAcgAygLMjAueWFuZGV4LmNsb3VkLmNvbnRhaW5lcnJlZ2lzdHJ5",
            "LnYxLkxpZmVjeWNsZVJ1bGUiOgoGU3RhdHVzEhYKElNUQVRVU19VTlNQRUNJ",
            "RklFRBAAEgoKBkFDVElWRRABEgwKCERJU0FCTEVEEAIiuwEKDUxpZmVjeWNs",
            "ZVJ1bGUSHgoLZGVzY3JpcHRpb24YASABKAlCCYrIMQU8PTI1NhI6Cg1leHBp",
            "cmVfcGVyaW9kGAIgASgLMhkuZ29vZ2xlLnByb3RvYnVmLkR1cmF0aW9uQgj6",
            "xzEEPjI0aBIdCgp0YWdfcmVnZXhwGAMgASgJQgmKyDEFPD0yNTYSEAoIdW50",
            "YWdnZWQYBCABKAgSHQoMcmV0YWluZWRfdG9wGAUgASgDQgf6xzEDPj0wQoAB",
            "CiV5YW5kZXguY2xvdWQuYXBpLmNvbnRhaW5lcnJlZ2lzdHJ5LnYxWldnaXRo",
            "dWIuY29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90by95YW5kZXgvY2xvdWQv",
            "Y29udGFpbmVycmVnaXN0cnkvdjE7Y29udGFpbmVycmVnaXN0cnliBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Yandex.Cloud.ValidationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy), global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Parser, new[]{ "Id", "Name", "RepositoryId", "Description", "Status", "CreatedAt", "Rules" }, null, new[]{ typeof(global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Containerregistry.V1.LifecycleRule), global::Yandex.Cloud.Containerregistry.V1.LifecycleRule.Parser, new[]{ "Description", "ExpirePeriod", "TagRegexp", "Untagged", "RetainedTop" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class LifecyclePolicy : pb::IMessage<LifecyclePolicy> {
    private static readonly pb::MessageParser<LifecyclePolicy> _parser = new pb::MessageParser<LifecyclePolicy>(() => new LifecyclePolicy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LifecyclePolicy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecyclePolicy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecyclePolicy(LifecyclePolicy other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      repositoryId_ = other.repositoryId_;
      description_ = other.description_;
      status_ = other.status_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      rules_ = other.rules_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecyclePolicy Clone() {
      return new LifecyclePolicy(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "repository_id" field.</summary>
    public const int RepositoryIdFieldNumber = 3;
    private string repositoryId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RepositoryId {
      get { return repositoryId_; }
      set {
        repositoryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status status_ = global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "rules" field.</summary>
    public const int RulesFieldNumber = 7;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Containerregistry.V1.LifecycleRule> _repeated_rules_codec
        = pb::FieldCodec.ForMessage(58, global::Yandex.Cloud.Containerregistry.V1.LifecycleRule.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.LifecycleRule> rules_ = new pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.LifecycleRule>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.LifecycleRule> Rules {
      get { return rules_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LifecyclePolicy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LifecyclePolicy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (RepositoryId != other.RepositoryId) return false;
      if (Description != other.Description) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if(!rules_.Equals(other.rules_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (RepositoryId.Length != 0) hash ^= RepositoryId.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Status != global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status.Unspecified) hash ^= Status.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      hash ^= rules_.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (RepositoryId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(RepositoryId);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (Status != global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreatedAt);
      }
      rules_.WriteTo(output, _repeated_rules_codec);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (RepositoryId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RepositoryId);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Status != global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      size += rules_.CalculateSize(_repeated_rules_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LifecyclePolicy other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.RepositoryId.Length != 0) {
        RepositoryId = other.RepositoryId;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Status != global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status.Unspecified) {
        Status = other.Status;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      rules_.Add(other.rules_);
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
            Name = input.ReadString();
            break;
          }
          case 26: {
            RepositoryId = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicy.Types.Status) input.ReadEnum();
            break;
          }
          case 50: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 58: {
            rules_.AddEntriesFrom(input, _repeated_rules_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the LifecyclePolicy message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        [pbr::OriginalName("ACTIVE")] Active = 1,
        [pbr::OriginalName("DISABLED")] Disabled = 2,
      }

    }
    #endregion

  }

  internal sealed partial class LifecycleRule : pb::IMessage<LifecycleRule> {
    private static readonly pb::MessageParser<LifecycleRule> _parser = new pb::MessageParser<LifecycleRule>(() => new LifecycleRule());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LifecycleRule> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Containerregistry.V1.LifecyclePolicyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecycleRule() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecycleRule(LifecycleRule other) : this() {
      description_ = other.description_;
      expirePeriod_ = other.expirePeriod_ != null ? other.expirePeriod_.Clone() : null;
      tagRegexp_ = other.tagRegexp_;
      untagged_ = other.untagged_;
      retainedTop_ = other.retainedTop_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LifecycleRule Clone() {
      return new LifecycleRule(this);
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 1;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expire_period" field.</summary>
    public const int ExpirePeriodFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration expirePeriod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration ExpirePeriod {
      get { return expirePeriod_; }
      set {
        expirePeriod_ = value;
      }
    }

    /// <summary>Field number for the "tag_regexp" field.</summary>
    public const int TagRegexpFieldNumber = 3;
    private string tagRegexp_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TagRegexp {
      get { return tagRegexp_; }
      set {
        tagRegexp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "untagged" field.</summary>
    public const int UntaggedFieldNumber = 4;
    private bool untagged_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Untagged {
      get { return untagged_; }
      set {
        untagged_ = value;
      }
    }

    /// <summary>Field number for the "retained_top" field.</summary>
    public const int RetainedTopFieldNumber = 5;
    private long retainedTop_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RetainedTop {
      get { return retainedTop_; }
      set {
        retainedTop_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LifecycleRule);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LifecycleRule other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Description != other.Description) return false;
      if (!object.Equals(ExpirePeriod, other.ExpirePeriod)) return false;
      if (TagRegexp != other.TagRegexp) return false;
      if (Untagged != other.Untagged) return false;
      if (RetainedTop != other.RetainedTop) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (expirePeriod_ != null) hash ^= ExpirePeriod.GetHashCode();
      if (TagRegexp.Length != 0) hash ^= TagRegexp.GetHashCode();
      if (Untagged != false) hash ^= Untagged.GetHashCode();
      if (RetainedTop != 0L) hash ^= RetainedTop.GetHashCode();
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
      if (Description.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Description);
      }
      if (expirePeriod_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ExpirePeriod);
      }
      if (TagRegexp.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(TagRegexp);
      }
      if (Untagged != false) {
        output.WriteRawTag(32);
        output.WriteBool(Untagged);
      }
      if (RetainedTop != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(RetainedTop);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (expirePeriod_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpirePeriod);
      }
      if (TagRegexp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TagRegexp);
      }
      if (Untagged != false) {
        size += 1 + 1;
      }
      if (RetainedTop != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RetainedTop);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LifecycleRule other) {
      if (other == null) {
        return;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.expirePeriod_ != null) {
        if (expirePeriod_ == null) {
          ExpirePeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        ExpirePeriod.MergeFrom(other.ExpirePeriod);
      }
      if (other.TagRegexp.Length != 0) {
        TagRegexp = other.TagRegexp;
      }
      if (other.Untagged != false) {
        Untagged = other.Untagged;
      }
      if (other.RetainedTop != 0L) {
        RetainedTop = other.RetainedTop;
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
            Description = input.ReadString();
            break;
          }
          case 18: {
            if (expirePeriod_ == null) {
              ExpirePeriod = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(ExpirePeriod);
            break;
          }
          case 26: {
            TagRegexp = input.ReadString();
            break;
          }
          case 32: {
            Untagged = input.ReadBool();
            break;
          }
          case 40: {
            RetainedTop = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
