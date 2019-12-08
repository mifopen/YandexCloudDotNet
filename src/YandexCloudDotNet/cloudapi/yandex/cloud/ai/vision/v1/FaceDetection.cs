// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/ai/vision/v1/face_detection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Ai.Vision.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/ai/vision/v1/face_detection.proto</summary>
  internal static partial class FaceDetectionReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/ai/vision/v1/face_detection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FaceDetectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci55YW5kZXgvY2xvdWQvYWkvdmlzaW9uL3YxL2ZhY2VfZGV0ZWN0aW9uLnBy",
            "b3RvEhl5YW5kZXguY2xvdWQuYWkudmlzaW9uLnYxGip5YW5kZXgvY2xvdWQv",
            "YWkvdmlzaW9uL3YxL3ByaW1pdGl2ZXMucHJvdG8iQAoORmFjZUFubm90YXRp",
            "b24SLgoFZmFjZXMYASADKAsyHy55YW5kZXguY2xvdWQuYWkudmlzaW9uLnYx",
            "LkZhY2UiQAoERmFjZRI4Cgxib3VuZGluZ19ib3gYASABKAsyIi55YW5kZXgu",
            "Y2xvdWQuYWkudmlzaW9uLnYxLlBvbHlnb25CZQodeWFuZGV4LmNsb3VkLmFw",
            "aS5haS52aXNpb24udjFaRGdpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdl",
            "bnByb3RvL3lhbmRleC9jbG91ZC9haS92aXNpb24vdjE7dmlzaW9uYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Yandex.Cloud.Ai.Vision.V1.PrimitivesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.FaceAnnotation), global::Yandex.Cloud.Ai.Vision.V1.FaceAnnotation.Parser, new[]{ "Faces" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.Face), global::Yandex.Cloud.Ai.Vision.V1.Face.Parser, new[]{ "BoundingBox" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class FaceAnnotation : pb::IMessage<FaceAnnotation> {
    private static readonly pb::MessageParser<FaceAnnotation> _parser = new pb::MessageParser<FaceAnnotation>(() => new FaceAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FaceAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.FaceDetectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaceAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaceAnnotation(FaceAnnotation other) : this() {
      faces_ = other.faces_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FaceAnnotation Clone() {
      return new FaceAnnotation(this);
    }

    /// <summary>Field number for the "faces" field.</summary>
    public const int FacesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Ai.Vision.V1.Face> _repeated_faces_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Ai.Vision.V1.Face.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Face> faces_ = new pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Face>();
    /// <summary>
    /// An array of detected faces for the specified image.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Face> Faces {
      get { return faces_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FaceAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FaceAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!faces_.Equals(other.faces_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= faces_.GetHashCode();
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
      faces_.WriteTo(output, _repeated_faces_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += faces_.CalculateSize(_repeated_faces_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FaceAnnotation other) {
      if (other == null) {
        return;
      }
      faces_.Add(other.faces_);
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
            faces_.AddEntriesFrom(input, _repeated_faces_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Face : pb::IMessage<Face> {
    private static readonly pb::MessageParser<Face> _parser = new pb::MessageParser<Face>(() => new Face());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Face> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.FaceDetectionReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Face() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Face(Face other) : this() {
      boundingBox_ = other.boundingBox_ != null ? other.boundingBox_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Face Clone() {
      return new Face(this);
    }

    /// <summary>Field number for the "bounding_box" field.</summary>
    public const int BoundingBoxFieldNumber = 1;
    private global::Yandex.Cloud.Ai.Vision.V1.Polygon boundingBox_;
    /// <summary>
    /// Area on the image where the face is located.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Ai.Vision.V1.Polygon BoundingBox {
      get { return boundingBox_; }
      set {
        boundingBox_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Face);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Face other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BoundingBox, other.BoundingBox)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (boundingBox_ != null) hash ^= BoundingBox.GetHashCode();
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
      if (boundingBox_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BoundingBox);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (boundingBox_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoundingBox);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Face other) {
      if (other == null) {
        return;
      }
      if (other.boundingBox_ != null) {
        if (boundingBox_ == null) {
          BoundingBox = new global::Yandex.Cloud.Ai.Vision.V1.Polygon();
        }
        BoundingBox.MergeFrom(other.BoundingBox);
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
            if (boundingBox_ == null) {
              BoundingBox = new global::Yandex.Cloud.Ai.Vision.V1.Polygon();
            }
            input.ReadMessage(BoundingBox);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
