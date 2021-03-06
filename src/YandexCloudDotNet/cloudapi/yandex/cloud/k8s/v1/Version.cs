// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/k8s/v1/version.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.K8S.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/k8s/v1/version.proto</summary>
  internal static partial class VersionReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/k8s/v1/version.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VersionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiF5YW5kZXgvY2xvdWQvazhzL3YxL3ZlcnNpb24ucHJvdG8SE3lhbmRleC5j",
            "bG91ZC5rOHMudjEaHXlhbmRleC9jbG91ZC92YWxpZGF0aW9uLnByb3RvIoAB",
            "CgtWZXJzaW9uSW5mbxIXCg9jdXJyZW50X3ZlcnNpb24YASABKAkSHgoWbmV3",
            "X3JldmlzaW9uX2F2YWlsYWJsZRgCIAEoCBIcChRuZXdfcmV2aXNpb25fc3Vt",
            "bWFyeRgDIAEoCRIaChJ2ZXJzaW9uX2RlcHJlY2F0ZWQYBCABKAgiVAoRVXBk",
            "YXRlVmVyc2lvblNwZWMSEQoHdmVyc2lvbhgBIAEoCUgAEhkKD2xhdGVzdF9y",
            "ZXZpc2lvbhgCIAEoCEgAQhEKCXNwZWNpZmllchIEwMExAUJWChd5YW5kZXgu",
            "Y2xvdWQuYXBpLms4cy52MVo7Z2l0aHViLmNvbS95YW5kZXgtY2xvdWQvZ28t",
            "Z2VucHJvdG8veWFuZGV4L2Nsb3VkL2s4cy92MTtrOHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.VersionInfo), global::Yandex.Cloud.K8S.V1.VersionInfo.Parser, new[]{ "CurrentVersion", "NewRevisionAvailable", "NewRevisionSummary", "VersionDeprecated" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.UpdateVersionSpec), global::Yandex.Cloud.K8S.V1.UpdateVersionSpec.Parser, new[]{ "Version", "LatestRevision" }, new[]{ "Specifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class VersionInfo : pb::IMessage<VersionInfo> {
    private static readonly pb::MessageParser<VersionInfo> _parser = new pb::MessageParser<VersionInfo>(() => new VersionInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VersionInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.VersionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo(VersionInfo other) : this() {
      currentVersion_ = other.currentVersion_;
      newRevisionAvailable_ = other.newRevisionAvailable_;
      newRevisionSummary_ = other.newRevisionSummary_;
      versionDeprecated_ = other.versionDeprecated_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VersionInfo Clone() {
      return new VersionInfo(this);
    }

    /// <summary>Field number for the "current_version" field.</summary>
    public const int CurrentVersionFieldNumber = 1;
    private string currentVersion_ = "";
    /// <summary>
    /// Current Kubernetes version, format: major.minor (e.g. 1.15).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CurrentVersion {
      get { return currentVersion_; }
      set {
        currentVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "new_revision_available" field.</summary>
    public const int NewRevisionAvailableFieldNumber = 2;
    private bool newRevisionAvailable_;
    /// <summary>
    /// Newer revisions may include Kubernetes patches (e.g 1.15.1 -> 1.15.2) as well
    /// as some internal component updates — new features or bug fixes in Yandex specific
    /// components either on the master or nodes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool NewRevisionAvailable {
      get { return newRevisionAvailable_; }
      set {
        newRevisionAvailable_ = value;
      }
    }

    /// <summary>Field number for the "new_revision_summary" field.</summary>
    public const int NewRevisionSummaryFieldNumber = 3;
    private string newRevisionSummary_ = "";
    /// <summary>
    /// Description of the changes to be applied when updating to the latest
    /// revision. Empty if new_revision_available is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NewRevisionSummary {
      get { return newRevisionSummary_; }
      set {
        newRevisionSummary_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "version_deprecated" field.</summary>
    public const int VersionDeprecatedFieldNumber = 4;
    private bool versionDeprecated_;
    /// <summary>
    /// The current version is on the deprecation schedule, component (master or node group)
    /// should be upgraded.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool VersionDeprecated {
      get { return versionDeprecated_; }
      set {
        versionDeprecated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VersionInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VersionInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrentVersion != other.CurrentVersion) return false;
      if (NewRevisionAvailable != other.NewRevisionAvailable) return false;
      if (NewRevisionSummary != other.NewRevisionSummary) return false;
      if (VersionDeprecated != other.VersionDeprecated) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CurrentVersion.Length != 0) hash ^= CurrentVersion.GetHashCode();
      if (NewRevisionAvailable != false) hash ^= NewRevisionAvailable.GetHashCode();
      if (NewRevisionSummary.Length != 0) hash ^= NewRevisionSummary.GetHashCode();
      if (VersionDeprecated != false) hash ^= VersionDeprecated.GetHashCode();
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
      if (CurrentVersion.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CurrentVersion);
      }
      if (NewRevisionAvailable != false) {
        output.WriteRawTag(16);
        output.WriteBool(NewRevisionAvailable);
      }
      if (NewRevisionSummary.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(NewRevisionSummary);
      }
      if (VersionDeprecated != false) {
        output.WriteRawTag(32);
        output.WriteBool(VersionDeprecated);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CurrentVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrentVersion);
      }
      if (NewRevisionAvailable != false) {
        size += 1 + 1;
      }
      if (NewRevisionSummary.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NewRevisionSummary);
      }
      if (VersionDeprecated != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VersionInfo other) {
      if (other == null) {
        return;
      }
      if (other.CurrentVersion.Length != 0) {
        CurrentVersion = other.CurrentVersion;
      }
      if (other.NewRevisionAvailable != false) {
        NewRevisionAvailable = other.NewRevisionAvailable;
      }
      if (other.NewRevisionSummary.Length != 0) {
        NewRevisionSummary = other.NewRevisionSummary;
      }
      if (other.VersionDeprecated != false) {
        VersionDeprecated = other.VersionDeprecated;
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
            CurrentVersion = input.ReadString();
            break;
          }
          case 16: {
            NewRevisionAvailable = input.ReadBool();
            break;
          }
          case 26: {
            NewRevisionSummary = input.ReadString();
            break;
          }
          case 32: {
            VersionDeprecated = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class UpdateVersionSpec : pb::IMessage<UpdateVersionSpec> {
    private static readonly pb::MessageParser<UpdateVersionSpec> _parser = new pb::MessageParser<UpdateVersionSpec>(() => new UpdateVersionSpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateVersionSpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.VersionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateVersionSpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateVersionSpec(UpdateVersionSpec other) : this() {
      switch (other.SpecifierCase) {
        case SpecifierOneofCase.Version:
          Version = other.Version;
          break;
        case SpecifierOneofCase.LatestRevision:
          LatestRevision = other.LatestRevision;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateVersionSpec Clone() {
      return new UpdateVersionSpec(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    /// <summary>
    /// Request update to a newer version of Kubernetes (1.x -> 1.y).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return specifierCase_ == SpecifierOneofCase.Version ? (string) specifier_ : ""; }
      set {
        specifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        specifierCase_ = SpecifierOneofCase.Version;
      }
    }

    /// <summary>Field number for the "latest_revision" field.</summary>
    public const int LatestRevisionFieldNumber = 2;
    /// <summary>
    /// Request update to the latest revision for the current version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool LatestRevision {
      get { return specifierCase_ == SpecifierOneofCase.LatestRevision ? (bool) specifier_ : false; }
      set {
        specifier_ = value;
        specifierCase_ = SpecifierOneofCase.LatestRevision;
      }
    }

    private object specifier_;
    /// <summary>Enum of possible cases for the "specifier" oneof.</summary>
    public enum SpecifierOneofCase {
      None = 0,
      Version = 1,
      LatestRevision = 2,
    }
    private SpecifierOneofCase specifierCase_ = SpecifierOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpecifierOneofCase SpecifierCase {
      get { return specifierCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSpecifier() {
      specifierCase_ = SpecifierOneofCase.None;
      specifier_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateVersionSpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateVersionSpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (LatestRevision != other.LatestRevision) return false;
      if (SpecifierCase != other.SpecifierCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (specifierCase_ == SpecifierOneofCase.Version) hash ^= Version.GetHashCode();
      if (specifierCase_ == SpecifierOneofCase.LatestRevision) hash ^= LatestRevision.GetHashCode();
      hash ^= (int) specifierCase_;
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
      if (specifierCase_ == SpecifierOneofCase.Version) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      if (specifierCase_ == SpecifierOneofCase.LatestRevision) {
        output.WriteRawTag(16);
        output.WriteBool(LatestRevision);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (specifierCase_ == SpecifierOneofCase.Version) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      if (specifierCase_ == SpecifierOneofCase.LatestRevision) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateVersionSpec other) {
      if (other == null) {
        return;
      }
      switch (other.SpecifierCase) {
        case SpecifierOneofCase.Version:
          Version = other.Version;
          break;
        case SpecifierOneofCase.LatestRevision:
          LatestRevision = other.LatestRevision;
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
            Version = input.ReadString();
            break;
          }
          case 16: {
            LatestRevision = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
