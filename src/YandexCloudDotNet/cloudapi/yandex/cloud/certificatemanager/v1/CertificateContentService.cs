// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/certificatemanager/v1/certificate_content_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Certificatemanager.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/certificatemanager/v1/certificate_content_service.proto</summary>
  internal static partial class CertificateContentServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/certificatemanager/v1/certificate_content_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CertificateContentServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkR5YW5kZXgvY2xvdWQvY2VydGlmaWNhdGVtYW5hZ2VyL3YxL2NlcnRpZmlj",
            "YXRlX2NvbnRlbnRfc2VydmljZS5wcm90bxIieWFuZGV4LmNsb3VkLmNlcnRp",
            "ZmljYXRlbWFuYWdlci52MRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "bxodeWFuZGV4L2Nsb3VkL3ZhbGlkYXRpb24ucHJvdG8iZwodR2V0Q2VydGlm",
            "aWNhdGVDb250ZW50UmVzcG9uc2USFgoOY2VydGlmaWNhdGVfaWQYASABKAkS",
            "GQoRY2VydGlmaWNhdGVfY2hhaW4YAyADKAkSEwoLcHJpdmF0ZV9rZXkYBCAB",
            "KAkiNgocR2V0Q2VydGlmaWNhdGVDb250ZW50UmVxdWVzdBIWCg5jZXJ0aWZp",
            "Y2F0ZV9pZBgBIAEoCTLyAQoZQ2VydGlmaWNhdGVDb250ZW50U2VydmljZRLU",
            "AQoDR2V0EkAueWFuZGV4LmNsb3VkLmNlcnRpZmljYXRlbWFuYWdlci52MS5H",
            "ZXRDZXJ0aWZpY2F0ZUNvbnRlbnRSZXF1ZXN0GkEueWFuZGV4LmNsb3VkLmNl",
            "cnRpZmljYXRlbWFuYWdlci52MS5HZXRDZXJ0aWZpY2F0ZUNvbnRlbnRSZXNw",
            "b25zZSJIgtPkkwJCEkAvY2VydGlmaWNhdGUtbWFuYWdlci92MS9jZXJ0aWZp",
            "Y2F0ZXMve2NlcnRpZmljYXRlX2lkfTpnZXRDb250ZW50QoMBCiZ5YW5kZXgu",
            "Y2xvdWQuYXBpLmNlcnRpZmljYXRlbWFuYWdlci52MVpZZ2l0aHViLmNvbS95",
            "YW5kZXgtY2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2NlcnRpZmlj",
            "YXRlbWFuYWdlci92MTtjZXJ0aWZpY2F0ZW1hbmFnZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Certificatemanager.V1.GetCertificateContentResponse), global::Yandex.Cloud.Certificatemanager.V1.GetCertificateContentResponse.Parser, new[]{ "CertificateId", "CertificateChain", "PrivateKey" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Certificatemanager.V1.GetCertificateContentRequest), global::Yandex.Cloud.Certificatemanager.V1.GetCertificateContentRequest.Parser, new[]{ "CertificateId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GetCertificateContentResponse : pb::IMessage<GetCertificateContentResponse> {
    private static readonly pb::MessageParser<GetCertificateContentResponse> _parser = new pb::MessageParser<GetCertificateContentResponse>(() => new GetCertificateContentResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCertificateContentResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Certificatemanager.V1.CertificateContentServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentResponse(GetCertificateContentResponse other) : this() {
      certificateId_ = other.certificateId_;
      certificateChain_ = other.certificateChain_.Clone();
      privateKey_ = other.privateKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentResponse Clone() {
      return new GetCertificateContentResponse(this);
    }

    /// <summary>Field number for the "certificate_id" field.</summary>
    public const int CertificateIdFieldNumber = 1;
    private string certificateId_ = "";
    /// <summary>
    /// ID of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CertificateId {
      get { return certificateId_; }
      set {
        certificateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "certificate_chain" field.</summary>
    public const int CertificateChainFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_certificateChain_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> certificateChain_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// PEM-encoded certificate chain content of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> CertificateChain {
      get { return certificateChain_; }
    }

    /// <summary>Field number for the "private_key" field.</summary>
    public const int PrivateKeyFieldNumber = 4;
    private string privateKey_ = "";
    /// <summary>
    /// PEM-encoded private key content of the certificate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PrivateKey {
      get { return privateKey_; }
      set {
        privateKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCertificateContentResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCertificateContentResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CertificateId != other.CertificateId) return false;
      if(!certificateChain_.Equals(other.certificateChain_)) return false;
      if (PrivateKey != other.PrivateKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CertificateId.Length != 0) hash ^= CertificateId.GetHashCode();
      hash ^= certificateChain_.GetHashCode();
      if (PrivateKey.Length != 0) hash ^= PrivateKey.GetHashCode();
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
      if (CertificateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CertificateId);
      }
      certificateChain_.WriteTo(output, _repeated_certificateChain_codec);
      if (PrivateKey.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PrivateKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CertificateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificateId);
      }
      size += certificateChain_.CalculateSize(_repeated_certificateChain_codec);
      if (PrivateKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PrivateKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCertificateContentResponse other) {
      if (other == null) {
        return;
      }
      if (other.CertificateId.Length != 0) {
        CertificateId = other.CertificateId;
      }
      certificateChain_.Add(other.certificateChain_);
      if (other.PrivateKey.Length != 0) {
        PrivateKey = other.PrivateKey;
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
            CertificateId = input.ReadString();
            break;
          }
          case 26: {
            certificateChain_.AddEntriesFrom(input, _repeated_certificateChain_codec);
            break;
          }
          case 34: {
            PrivateKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class GetCertificateContentRequest : pb::IMessage<GetCertificateContentRequest> {
    private static readonly pb::MessageParser<GetCertificateContentRequest> _parser = new pb::MessageParser<GetCertificateContentRequest>(() => new GetCertificateContentRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCertificateContentRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Certificatemanager.V1.CertificateContentServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentRequest(GetCertificateContentRequest other) : this() {
      certificateId_ = other.certificateId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCertificateContentRequest Clone() {
      return new GetCertificateContentRequest(this);
    }

    /// <summary>Field number for the "certificate_id" field.</summary>
    public const int CertificateIdFieldNumber = 1;
    private string certificateId_ = "";
    /// <summary>
    /// ID of the certificate to download content.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CertificateId {
      get { return certificateId_; }
      set {
        certificateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetCertificateContentRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCertificateContentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CertificateId != other.CertificateId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CertificateId.Length != 0) hash ^= CertificateId.GetHashCode();
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
      if (CertificateId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CertificateId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CertificateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CertificateId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetCertificateContentRequest other) {
      if (other == null) {
        return;
      }
      if (other.CertificateId.Length != 0) {
        CertificateId = other.CertificateId;
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
            CertificateId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
