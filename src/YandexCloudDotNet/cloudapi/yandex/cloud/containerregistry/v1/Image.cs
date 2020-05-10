// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/containerregistry/v1/image.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Containerregistry.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/containerregistry/v1/image.proto</summary>
  internal static partial class ImageReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/containerregistry/v1/image.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci15YW5kZXgvY2xvdWQvY29udGFpbmVycmVnaXN0cnkvdjEvaW1hZ2UucHJv",
            "dG8SIXlhbmRleC5jbG91ZC5jb250YWluZXJyZWdpc3RyeS52MRoseWFuZGV4",
            "L2Nsb3VkL2NvbnRhaW5lcnJlZ2lzdHJ5L3YxL2Jsb2IucHJvdG8aH2dvb2ds",
            "ZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i+gEKBUltYWdlEgoKAmlkGAEg",
            "ASgJEgwKBG5hbWUYAiABKAkSDgoGZGlnZXN0GAMgASgJEhcKD2NvbXByZXNz",
            "ZWRfc2l6ZRgEIAEoAxI3CgZjb25maWcYBSABKAsyJy55YW5kZXguY2xvdWQu",
            "Y29udGFpbmVycmVnaXN0cnkudjEuQmxvYhI3CgZsYXllcnMYBiADKAsyJy55",
            "YW5kZXguY2xvdWQuY29udGFpbmVycmVnaXN0cnkudjEuQmxvYhIMCgR0YWdz",
            "GAcgAygJEi4KCmNyZWF0ZWRfYXQYCCABKAsyGi5nb29nbGUucHJvdG9idWYu",
            "VGltZXN0YW1wQoABCiV5YW5kZXguY2xvdWQuYXBpLmNvbnRhaW5lcnJlZ2lz",
            "dHJ5LnYxWldnaXRodWIuY29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90by95",
            "YW5kZXgvY2xvdWQvY29udGFpbmVycmVnaXN0cnkvdjE7Y29udGFpbmVycmVn",
            "aXN0cnliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Yandex.Cloud.Containerregistry.V1.BlobReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Containerregistry.V1.Image), global::Yandex.Cloud.Containerregistry.V1.Image.Parser, new[]{ "Id", "Name", "Digest", "CompressedSize", "Config", "Layers", "Tags", "CreatedAt" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An Image resource. For more information, see [Docker image](/docs/cloud/container-registry/docker-image).
  /// </summary>
  internal sealed partial class Image : pb::IMessage<Image> {
    private static readonly pb::MessageParser<Image> _parser = new pb::MessageParser<Image>(() => new Image());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Image> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Containerregistry.V1.ImageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image(Image other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      digest_ = other.digest_;
      compressedSize_ = other.compressedSize_;
      config_ = other.config_ != null ? other.config_.Clone() : null;
      layers_ = other.layers_.Clone();
      tags_ = other.tags_.Clone();
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Image Clone() {
      return new Image(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Output only. ID of the Docker image.
    /// </summary>
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
    /// <summary>
    /// Name of the Docker image.
    /// The name is unique within the registry.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "digest" field.</summary>
    public const int DigestFieldNumber = 3;
    private string digest_ = "";
    /// <summary>
    /// Content-addressable identifier of the Docker image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Digest {
      get { return digest_; }
      set {
        digest_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "compressed_size" field.</summary>
    public const int CompressedSizeFieldNumber = 4;
    private long compressedSize_;
    /// <summary>
    /// Compressed size of the Docker image, specified in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CompressedSize {
      get { return compressedSize_; }
      set {
        compressedSize_ = value;
      }
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 5;
    private global::Yandex.Cloud.Containerregistry.V1.Blob config_;
    /// <summary>
    /// Configuration of the Docker image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Containerregistry.V1.Blob Config {
      get { return config_; }
      set {
        config_ = value;
      }
    }

    /// <summary>Field number for the "layers" field.</summary>
    public const int LayersFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Containerregistry.V1.Blob> _repeated_layers_codec
        = pb::FieldCodec.ForMessage(50, global::Yandex.Cloud.Containerregistry.V1.Blob.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.Blob> layers_ = new pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.Blob>();
    /// <summary>
    /// Layers of the Docker image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Containerregistry.V1.Blob> Layers {
      get { return layers_; }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_tags_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> tags_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Tags of the Docker image.
    ///
    /// Each tag is unique within the repository.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Tags {
      get { return tags_; }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 8;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Image);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Image other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Digest != other.Digest) return false;
      if (CompressedSize != other.CompressedSize) return false;
      if (!object.Equals(Config, other.Config)) return false;
      if(!layers_.Equals(other.layers_)) return false;
      if(!tags_.Equals(other.tags_)) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Digest.Length != 0) hash ^= Digest.GetHashCode();
      if (CompressedSize != 0L) hash ^= CompressedSize.GetHashCode();
      if (config_ != null) hash ^= Config.GetHashCode();
      hash ^= layers_.GetHashCode();
      hash ^= tags_.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Digest.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Digest);
      }
      if (CompressedSize != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(CompressedSize);
      }
      if (config_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Config);
      }
      layers_.WriteTo(output, _repeated_layers_codec);
      tags_.WriteTo(output, _repeated_tags_codec);
      if (createdAt_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(CreatedAt);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Digest.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Digest);
      }
      if (CompressedSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CompressedSize);
      }
      if (config_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Config);
      }
      size += layers_.CalculateSize(_repeated_layers_codec);
      size += tags_.CalculateSize(_repeated_tags_codec);
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Image other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Digest.Length != 0) {
        Digest = other.Digest;
      }
      if (other.CompressedSize != 0L) {
        CompressedSize = other.CompressedSize;
      }
      if (other.config_ != null) {
        if (config_ == null) {
          Config = new global::Yandex.Cloud.Containerregistry.V1.Blob();
        }
        Config.MergeFrom(other.Config);
      }
      layers_.Add(other.layers_);
      tags_.Add(other.tags_);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Digest = input.ReadString();
            break;
          }
          case 32: {
            CompressedSize = input.ReadInt64();
            break;
          }
          case 42: {
            if (config_ == null) {
              Config = new global::Yandex.Cloud.Containerregistry.V1.Blob();
            }
            input.ReadMessage(Config);
            break;
          }
          case 50: {
            layers_.AddEntriesFrom(input, _repeated_layers_codec);
            break;
          }
          case 58: {
            tags_.AddEntriesFrom(input, _repeated_tags_codec);
            break;
          }
          case 66: {
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
