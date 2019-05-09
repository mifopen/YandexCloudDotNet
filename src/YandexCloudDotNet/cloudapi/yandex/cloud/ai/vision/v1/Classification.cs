// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/ai/vision/v1/classification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Ai.Vision.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/ai/vision/v1/classification.proto</summary>
  internal static partial class ClassificationReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/ai/vision/v1/classification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClassificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci55YW5kZXgvY2xvdWQvYWkvdmlzaW9uL3YxL2NsYXNzaWZpY2F0aW9uLnBy",
            "b3RvEhl5YW5kZXguY2xvdWQuYWkudmlzaW9uLnYxIkoKD0NsYXNzQW5ub3Rh",
            "dGlvbhI3Cgpwcm9wZXJ0aWVzGAEgAygLMiMueWFuZGV4LmNsb3VkLmFpLnZp",
            "c2lvbi52MS5Qcm9wZXJ0eSItCghQcm9wZXJ0eRIMCgRuYW1lGAEgASgJEhMK",
            "C3Byb2JhYmlsaXR5GAIgASgBQkZaRGdpdGh1Yi5jb20veWFuZGV4LWNsb3Vk",
            "L2dvLWdlbnByb3RvL3lhbmRleC9jbG91ZC9haS92aXNpb24vdjE7dmlzaW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.ClassAnnotation), global::Yandex.Cloud.Ai.Vision.V1.ClassAnnotation.Parser, new[]{ "Properties" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Ai.Vision.V1.Property), global::Yandex.Cloud.Ai.Vision.V1.Property.Parser, new[]{ "Name", "Probability" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ClassAnnotation : pb::IMessage<ClassAnnotation> {
    private static readonly pb::MessageParser<ClassAnnotation> _parser = new pb::MessageParser<ClassAnnotation>(() => new ClassAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClassAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.ClassificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassAnnotation(ClassAnnotation other) : this() {
      properties_ = other.properties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClassAnnotation Clone() {
      return new ClassAnnotation(this);
    }

    /// <summary>Field number for the "properties" field.</summary>
    public const int PropertiesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Ai.Vision.V1.Property> _repeated_properties_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Ai.Vision.V1.Property.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Property> properties_ = new pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Property>();
    /// <summary>
    /// Properties extracted by a specified model.
    ///
    /// For example, if you ask to evaluate the image quality,
    /// the service could return such properties as `good` and `bad`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Ai.Vision.V1.Property> Properties {
      get { return properties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClassAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClassAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!properties_.Equals(other.properties_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= properties_.GetHashCode();
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
      properties_.WriteTo(output, _repeated_properties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += properties_.CalculateSize(_repeated_properties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClassAnnotation other) {
      if (other == null) {
        return;
      }
      properties_.Add(other.properties_);
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
            properties_.AddEntriesFrom(input, _repeated_properties_codec);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class Property : pb::IMessage<Property> {
    private static readonly pb::MessageParser<Property> _parser = new pb::MessageParser<Property>(() => new Property());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Property> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Ai.Vision.V1.ClassificationReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property(Property other) : this() {
      name_ = other.name_;
      probability_ = other.probability_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Property Clone() {
      return new Property(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Property name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "probability" field.</summary>
    public const int ProbabilityFieldNumber = 2;
    private double probability_;
    /// <summary>
    /// Probability of the property, from 0 to 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Probability {
      get { return probability_; }
      set {
        probability_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Property);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Property other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Probability, other.Probability)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Probability != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Probability);
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
      if (Probability != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Probability);
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
      if (Probability != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Property other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Probability != 0D) {
        Probability = other.Probability;
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
          case 17: {
            Probability = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code