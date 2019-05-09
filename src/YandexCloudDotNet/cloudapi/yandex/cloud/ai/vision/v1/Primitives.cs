// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/ai/vision/v1/primitives.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Ai.Vision.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/ai/vision/v1/primitives.proto</summary>
  internal static partial class PrimitivesReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/ai/vision/v1/primitives.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrimitivesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cip5YW5kZXgvY2xvdWQvYWkvdmlzaW9uL3YxL3ByaW1pdGl2ZXMucHJvdG8S",
            "GXlhbmRleC5jbG91ZC5haS52aXNpb24udjEiPgoHUG9seWdvbhIzCgh2ZXJ0",
            "aWNlcxgBIAMoCzIhLnlhbmRleC5jbG91ZC5haS52aXNpb24udjEuVmVydGV4",
            "Ih4KBlZlcnRleBIJCgF4GAEgASgDEgkKAXkYAiABKANCRlpEZ2l0aHViLmNv",
            "bS95YW5kZXgtY2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2FpL3Zp",
            "c2lvbi92MTt2aXNpb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.Polygon), global::Yandex.Cloud.Ai.Vision.V1.Polygon.Parser, new[]{ "Vertices" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.Vertex), global::Yandex.Cloud.Ai.Vision.V1.Vertex.Parser, new[]{ "X", "Y" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class Polygon : pb::IMessage<Polygon> {
    private static readonly pb::MessageParser<Polygon> _parser = new pb::MessageParser<Polygon>(() => new Polygon());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Polygon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.PrimitivesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Polygon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Polygon(Polygon other) : this() {
      vertices_ = other.vertices_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Polygon Clone() {
      return new Polygon(this);
    }

    /// <summary>Field number for the "vertices" field.</summary>
    public const int VerticesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Ai.Vision.V1.Vertex> _repeated_vertices_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Ai.Vision.V1.Vertex.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Vertex> vertices_ = new pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Vertex>();
    /// <summary>
    /// The bounding polygon vertices.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Vertex> Vertices {
      get { return vertices_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Polygon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Polygon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!vertices_.Equals(other.vertices_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= vertices_.GetHashCode();
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
      vertices_.WriteTo(output, _repeated_vertices_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += vertices_.CalculateSize(_repeated_vertices_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Polygon other) {
      if (other == null) {
        return;
      }
      vertices_.Add(other.vertices_);
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
            vertices_.AddEntriesFrom(input, _repeated_vertices_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Vertex : pb::IMessage<Vertex> {
    private static readonly pb::MessageParser<Vertex> _parser = new pb::MessageParser<Vertex>(() => new Vertex());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vertex> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.PrimitivesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vertex() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vertex(Vertex other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vertex Clone() {
      return new Vertex(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private long x_;
    /// <summary>
    /// X coordinate in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private long y_;
    /// <summary>
    /// Y coordinate in pixels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vertex);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vertex other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0L) hash ^= X.GetHashCode();
      if (Y != 0L) hash ^= Y.GetHashCode();
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
      if (X != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(X);
      }
      if (Y != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(X);
      }
      if (Y != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Y);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vertex other) {
      if (other == null) {
        return;
      }
      if (other.X != 0L) {
        X = other.X;
      }
      if (other.Y != 0L) {
        Y = other.Y;
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
          case 8: {
            X = input.ReadInt64();
            break;
          }
          case 16: {
            Y = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code