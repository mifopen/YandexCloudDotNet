// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/mongodb/v1/resource_preset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Mongodb.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/mongodb/v1/resource_preset.proto</summary>
  internal static partial class ResourcePresetReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/mongodb/v1/resource_preset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourcePresetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjF5YW5kZXgvY2xvdWQvbWRiL21vbmdvZGIvdjEvcmVzb3VyY2VfcHJlc2V0",
            "LnByb3RvEht5YW5kZXguY2xvdWQubWRiLm1vbmdvZGIudjEiTQoOUmVzb3Vy",
            "Y2VQcmVzZXQSCgoCaWQYASABKAkSEAoIem9uZV9pZHMYAiADKAkSDQoFY29y",
            "ZXMYAyABKAMSDgoGbWVtb3J5GAQgASgDQklaR2dpdGh1Yi5jb20veWFuZGV4",
            "LWNsb3VkL2dvLWdlbnByb3RvL3lhbmRleC9jbG91ZC9tZGIvbW9uZ29kYi92",
            "MTttb25nb2RiYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.ResourcePreset), global::Yandex.Cloud.Mdb.Mongodb.V1.ResourcePreset.Parser, new[]{ "Id", "ZoneIds", "Cores", "Memory" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A ResourcePreset resource for describing hardware configuration presets.
  /// </summary>
  internal sealed partial class ResourcePreset : pb::IMessage<ResourcePreset> {
    private static readonly pb::MessageParser<ResourcePreset> _parser = new pb::MessageParser<ResourcePreset>(() => new ResourcePreset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourcePreset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.ResourcePresetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourcePreset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourcePreset(ResourcePreset other) : this() {
      id_ = other.id_;
      zoneIds_ = other.zoneIds_.Clone();
      cores_ = other.cores_;
      memory_ = other.memory_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourcePreset Clone() {
      return new ResourcePreset(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the ResourcePreset resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "zone_ids" field.</summary>
    public const int ZoneIdsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_zoneIds_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> zoneIds_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// IDs of availability zones where the resource preset is available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ZoneIds {
      get { return zoneIds_; }
    }

    /// <summary>Field number for the "cores" field.</summary>
    public const int CoresFieldNumber = 3;
    private long cores_;
    /// <summary>
    /// Number of CPU cores for a MongoDB host created with the preset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Cores {
      get { return cores_; }
      set {
        cores_ = value;
      }
    }

    /// <summary>Field number for the "memory" field.</summary>
    public const int MemoryFieldNumber = 4;
    private long memory_;
    /// <summary>
    /// RAM volume for a MongoDB host created with the preset, in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Memory {
      get { return memory_; }
      set {
        memory_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourcePreset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourcePreset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if(!zoneIds_.Equals(other.zoneIds_)) return false;
      if (Cores != other.Cores) return false;
      if (Memory != other.Memory) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      hash ^= zoneIds_.GetHashCode();
      if (Cores != 0L) hash ^= Cores.GetHashCode();
      if (Memory != 0L) hash ^= Memory.GetHashCode();
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
      zoneIds_.WriteTo(output, _repeated_zoneIds_codec);
      if (Cores != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Cores);
      }
      if (Memory != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Memory);
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
      size += zoneIds_.CalculateSize(_repeated_zoneIds_codec);
      if (Cores != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Cores);
      }
      if (Memory != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Memory);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourcePreset other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      zoneIds_.Add(other.zoneIds_);
      if (other.Cores != 0L) {
        Cores = other.Cores;
      }
      if (other.Memory != 0L) {
        Memory = other.Memory;
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
            zoneIds_.AddEntriesFrom(input, _repeated_zoneIds_codec);
            break;
          }
          case 24: {
            Cores = input.ReadInt64();
            break;
          }
          case 32: {
            Memory = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
