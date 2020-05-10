// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/iot/devices/v1/registry_data_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Iot.Devices.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/iot/devices/v1/registry_data_service.proto</summary>
  internal static partial class RegistryDataServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/iot/devices/v1/registry_data_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegistryDataServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjd5YW5kZXgvY2xvdWQvaW90L2RldmljZXMvdjEvcmVnaXN0cnlfZGF0YV9z",
            "ZXJ2aWNlLnByb3RvEht5YW5kZXguY2xvdWQuaW90LmRldmljZXMudjEaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aHXlhbmRleC9jbG91ZC92YWxp",
            "ZGF0aW9uLnByb3RvInoKGlB1Ymxpc2hSZWdpc3RyeURhdGFSZXF1ZXN0EiEK",
            "C3JlZ2lzdHJ5X2lkGAEgASgJQgzoxzEBisgxBDw9NTASHQoFdG9waWMYAiAB",
            "KAlCDujHMQGKyDEGPD0xMDI0EhoKBGRhdGEYAyABKAxCDIrIMQg8PTI2MjE0",
            "NCIdChtQdWJsaXNoUmVnaXN0cnlEYXRhUmVzcG9uc2Uy0QEKE1JlZ2lzdHJ5",
            "RGF0YVNlcnZpY2USuQEKB1B1Ymxpc2gSNy55YW5kZXguY2xvdWQuaW90LmRl",
            "dmljZXMudjEuUHVibGlzaFJlZ2lzdHJ5RGF0YVJlcXVlc3QaOC55YW5kZXgu",
            "Y2xvdWQuaW90LmRldmljZXMudjEuUHVibGlzaFJlZ2lzdHJ5RGF0YVJlc3Bv",
            "bnNlIjuC0+STAjUiMC9pb3QtZGV2aWNlcy92MS9yZWdpc3RyaWVzL3tyZWdp",
            "c3RyeV9pZH0vcHVibGlzaDoBKkJqCh95YW5kZXguY2xvdWQuYXBpLmlvdC5k",
            "ZXZpY2VzLnYxWkdnaXRodWIuY29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90",
            "by95YW5kZXgvY2xvdWQvaW90L2RldmljZXMvdjE7ZGV2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.PublishRegistryDataRequest), global::Yandex.Cloud.Iot.Devices.V1.PublishRegistryDataRequest.Parser, new[]{ "RegistryId", "Topic", "Data" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Iot.Devices.V1.PublishRegistryDataResponse), global::Yandex.Cloud.Iot.Devices.V1.PublishRegistryDataResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class PublishRegistryDataRequest : pb::IMessage<PublishRegistryDataRequest> {
    private static readonly pb::MessageParser<PublishRegistryDataRequest> _parser = new pb::MessageParser<PublishRegistryDataRequest>(() => new PublishRegistryDataRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PublishRegistryDataRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryDataServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataRequest(PublishRegistryDataRequest other) : this() {
      registryId_ = other.registryId_;
      topic_ = other.topic_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataRequest Clone() {
      return new PublishRegistryDataRequest(this);
    }

    /// <summary>Field number for the "registry_id" field.</summary>
    public const int RegistryIdFieldNumber = 1;
    private string registryId_ = "";
    /// <summary>
    /// ID of registry publishing message
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string RegistryId {
      get { return registryId_; }
      set {
        registryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "topic" field.</summary>
    public const int TopicFieldNumber = 2;
    private string topic_ = "";
    /// <summary>
    /// Topic where message should be published
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Topic {
      get { return topic_; }
      set {
        topic_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 3;
    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// Content of the message
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PublishRegistryDataRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PublishRegistryDataRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RegistryId != other.RegistryId) return false;
      if (Topic != other.Topic) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RegistryId.Length != 0) hash ^= RegistryId.GetHashCode();
      if (Topic.Length != 0) hash ^= Topic.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
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
      if (RegistryId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RegistryId);
      }
      if (Topic.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Topic);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RegistryId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RegistryId);
      }
      if (Topic.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Topic);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PublishRegistryDataRequest other) {
      if (other == null) {
        return;
      }
      if (other.RegistryId.Length != 0) {
        RegistryId = other.RegistryId;
      }
      if (other.Topic.Length != 0) {
        Topic = other.Topic;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
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
            RegistryId = input.ReadString();
            break;
          }
          case 18: {
            Topic = input.ReadString();
            break;
          }
          case 26: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class PublishRegistryDataResponse : pb::IMessage<PublishRegistryDataResponse> {
    private static readonly pb::MessageParser<PublishRegistryDataResponse> _parser = new pb::MessageParser<PublishRegistryDataResponse>(() => new PublishRegistryDataResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PublishRegistryDataResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Iot.Devices.V1.RegistryDataServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataResponse(PublishRegistryDataResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PublishRegistryDataResponse Clone() {
      return new PublishRegistryDataResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PublishRegistryDataResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PublishRegistryDataResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PublishRegistryDataResponse other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code