// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/clickhouse/v1/ml_model.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Clickhouse.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/clickhouse/v1/ml_model.proto</summary>
  internal static partial class MlModelReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/clickhouse/v1/ml_model.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MlModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci15YW5kZXgvY2xvdWQvbWRiL2NsaWNraG91c2UvdjEvbWxfbW9kZWwucHJv",
            "dG8SHnlhbmRleC5jbG91ZC5tZGIuY2xpY2tob3VzZS52MSJzCgdNbE1vZGVs",
            "EgwKBG5hbWUYASABKAkSEgoKY2x1c3Rlcl9pZBgCIAEoCRI5CgR0eXBlGAMg",
            "ASgOMisueWFuZGV4LmNsb3VkLm1kYi5jbGlja2hvdXNlLnYxLk1sTW9kZWxU",
            "eXBlEgsKA3VyaRgEIAEoCSpICgtNbE1vZGVsVHlwZRIdChlNTF9NT0RFTF9U",
            "WVBFX1VOU1BFQ0lGSUVEEAASGgoWTUxfTU9ERUxfVFlQRV9DQVRCT09TVBAB",
            "QnMKInlhbmRleC5jbG91ZC5hcGkubWRiLmNsaWNraG91c2UudjFaTWdpdGh1",
            "Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdlbnByb3RvL3lhbmRleC9jbG91ZC9t",
            "ZGIvY2xpY2tob3VzZS92MTtjbGlja2hvdXNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModelType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModel), global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModel.Parser, new[]{ "Name", "ClusterId", "Type", "Uri" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  internal enum MlModelType {
    [pbr::OriginalName("ML_MODEL_TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// CatBoost model.
    /// </summary>
    [pbr::OriginalName("ML_MODEL_TYPE_CATBOOST")] Catboost = 1,
  }

  #endregion

  #region Messages
  internal sealed partial class MlModel : pb::IMessage<MlModel> {
    private static readonly pb::MessageParser<MlModel> _parser = new pb::MessageParser<MlModel>(() => new MlModel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MlModel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MlModel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MlModel(MlModel other) : this() {
      name_ = other.name_;
      clusterId_ = other.clusterId_;
      type_ = other.type_;
      uri_ = other.uri_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MlModel Clone() {
      return new MlModel(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the the model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cluster_id" field.</summary>
    public const int ClusterIdFieldNumber = 2;
    private string clusterId_ = "";
    /// <summary>
    /// ID of the ClickHouse cluster that the model belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterId {
      get { return clusterId_; }
      set {
        clusterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModelType type_ = 0;
    /// <summary>
    /// Type of the model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModelType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "uri" field.</summary>
    public const int UriFieldNumber = 4;
    private string uri_ = "";
    /// <summary>
    /// Model file URL. You can only use models stored in Yandex Object Storage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Uri {
      get { return uri_; }
      set {
        uri_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MlModel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MlModel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (ClusterId != other.ClusterId) return false;
      if (Type != other.Type) return false;
      if (Uri != other.Uri) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (ClusterId.Length != 0) hash ^= ClusterId.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Uri.Length != 0) hash ^= Uri.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (ClusterId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ClusterId);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (Uri.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Uri);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (ClusterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterId);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Uri.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Uri);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MlModel other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.ClusterId.Length != 0) {
        ClusterId = other.ClusterId;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Uri.Length != 0) {
        Uri = other.Uri;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            ClusterId = input.ReadString();
            break;
          }
          case 24: {
            Type = (global::Yandex.Cloud.Mdb.Clickhouse.V1.MlModelType) input.ReadEnum();
            break;
          }
          case 34: {
            Uri = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
