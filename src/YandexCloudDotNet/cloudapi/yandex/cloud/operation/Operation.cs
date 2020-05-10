// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/operation/operation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Operation {

  /// <summary>Holder for reflection information generated from yandex/cloud/operation/operation.proto</summary>
  internal static partial class OperationReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/operation/operation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZ5YW5kZXgvY2xvdWQvb3BlcmF0aW9uL29wZXJhdGlvbi5wcm90bxIWeWFu",
            "ZGV4LmNsb3VkLm9wZXJhdGlvbhoZZ29vZ2xlL3Byb3RvYnVmL2FueS5wcm90",
            "bxoXZ29vZ2xlL3JwYy9zdGF0dXMucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8isAIKCU9wZXJhdGlvbhIKCgJpZBgBIAEoCRITCgtk",
            "ZXNjcmlwdGlvbhgCIAEoCRIuCgpjcmVhdGVkX2F0GAMgASgLMhouZ29vZ2xl",
            "LnByb3RvYnVmLlRpbWVzdGFtcBISCgpjcmVhdGVkX2J5GAQgASgJEi8KC21v",
            "ZGlmaWVkX2F0GAUgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFtcBIM",
            "CgRkb25lGAYgASgIEiYKCG1ldGFkYXRhGAcgASgLMhQuZ29vZ2xlLnByb3Rv",
            "YnVmLkFueRIjCgVlcnJvchgIIAEoCzISLmdvb2dsZS5ycGMuU3RhdHVzSAAS",
            "KAoIcmVzcG9uc2UYCSABKAsyFC5nb29nbGUucHJvdG9idWYuQW55SABCCAoG",
            "cmVzdWx0QmIKGnlhbmRleC5jbG91ZC5hcGkub3BlcmF0aW9uWkRnaXRodWIu",
            "Y29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90by95YW5kZXgvY2xvdWQvb3Bl",
            "cmF0aW9uO29wZXJhdGlvbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Operation.Operation), global::Yandex.Cloud.Operation.Operation.Parser, new[]{ "Id", "Description", "CreatedAt", "CreatedBy", "ModifiedAt", "Done", "Metadata", "Error", "Response" }, new[]{ "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An Operation resource. For more information, see [Operation](/docs/api-design-guide/concepts/operation).
  /// </summary>
  internal sealed partial class Operation : pb::IMessage<Operation> {
    private static readonly pb::MessageParser<Operation> _parser = new pb::MessageParser<Operation>(() => new Operation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Operation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Operation.OperationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operation(Operation other) : this() {
      id_ = other.id_;
      description_ = other.description_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      createdBy_ = other.createdBy_;
      modifiedAt_ = other.modifiedAt_ != null ? other.modifiedAt_.Clone() : null;
      done_ = other.done_;
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      switch (other.ResultCase) {
        case ResultOneofCase.Error:
          Error = other.Error.Clone();
          break;
        case ResultOneofCase.Response:
          Response = other.Response.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operation Clone() {
      return new Operation(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    /// <summary>
    /// Description of the operation. 0-256 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    /// <summary>
    /// Creation timestamp.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "created_by" field.</summary>
    public const int CreatedByFieldNumber = 4;
    private string createdBy_ = "";
    /// <summary>
    /// ID of the user or service account who initiated the operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CreatedBy {
      get { return createdBy_; }
      set {
        createdBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "modified_at" field.</summary>
    public const int ModifiedAtFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp modifiedAt_;
    /// <summary>
    /// The time when the Operation resource was last modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ModifiedAt {
      get { return modifiedAt_; }
      set {
        modifiedAt_ = value;
      }
    }

    /// <summary>Field number for the "done" field.</summary>
    public const int DoneFieldNumber = 6;
    private bool done_;
    /// <summary>
    /// If the value is `false`, it means the operation is still in progress.
    /// If `true`, the operation is completed, and either `error` or `response` is available.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Done {
      get { return done_; }
      set {
        done_ = value;
      }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Any metadata_;
    /// <summary>
    /// Service-specific metadata associated with the operation.
    /// It typically contains the ID of the target resource that the operation is performed on.
    /// Any method that returns a long-running operation should document the metadata type, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 8;
    /// <summary>
    /// The error result of the operation in case of failure or cancellation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status Error {
      get { return resultCase_ == ResultOneofCase.Error ? (global::Google.Rpc.Status) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Error;
      }
    }

    /// <summary>Field number for the "response" field.</summary>
    public const int ResponseFieldNumber = 9;
    /// <summary>
    /// The normal response of the operation in case of success.
    /// If the original method returns no data on success, such as Delete,
    /// the response is [google.protobuf.Empty].
    /// If the original method is the standard Create/Update,
    /// the response should be the target resource of the operation.
    /// Any method that returns a long-running operation should document the response type, if any.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Response {
      get { return resultCase_ == ResultOneofCase.Response ? (global::Google.Protobuf.WellKnownTypes.Any) result_ : null; }
      set {
        result_ = value;
        resultCase_ = value == null ? ResultOneofCase.None : ResultOneofCase.Response;
      }
    }

    private object result_;
    /// <summary>Enum of possible cases for the "result" oneof.</summary>
    public enum ResultOneofCase {
      None = 0,
      Error = 8,
      Response = 9,
    }
    private ResultOneofCase resultCase_ = ResultOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResultOneofCase ResultCase {
      get { return resultCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearResult() {
      resultCase_ = ResultOneofCase.None;
      result_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Operation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Operation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Description != other.Description) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (CreatedBy != other.CreatedBy) return false;
      if (!object.Equals(ModifiedAt, other.ModifiedAt)) return false;
      if (Done != other.Done) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      if (!object.Equals(Error, other.Error)) return false;
      if (!object.Equals(Response, other.Response)) return false;
      if (ResultCase != other.ResultCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (CreatedBy.Length != 0) hash ^= CreatedBy.GetHashCode();
      if (modifiedAt_ != null) hash ^= ModifiedAt.GetHashCode();
      if (Done != false) hash ^= Done.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (resultCase_ == ResultOneofCase.Error) hash ^= Error.GetHashCode();
      if (resultCase_ == ResultOneofCase.Response) hash ^= Response.GetHashCode();
      hash ^= (int) resultCase_;
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
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreatedAt);
      }
      if (CreatedBy.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(CreatedBy);
      }
      if (modifiedAt_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(ModifiedAt);
      }
      if (Done != false) {
        output.WriteRawTag(48);
        output.WriteBool(Done);
      }
      if (metadata_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(Metadata);
      }
      if (resultCase_ == ResultOneofCase.Error) {
        output.WriteRawTag(66);
        output.WriteMessage(Error);
      }
      if (resultCase_ == ResultOneofCase.Response) {
        output.WriteRawTag(74);
        output.WriteMessage(Response);
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
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (CreatedBy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreatedBy);
      }
      if (modifiedAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModifiedAt);
      }
      if (Done != false) {
        size += 1 + 1;
      }
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (resultCase_ == ResultOneofCase.Error) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Error);
      }
      if (resultCase_ == ResultOneofCase.Response) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Response);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Operation other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.CreatedBy.Length != 0) {
        CreatedBy = other.CreatedBy;
      }
      if (other.modifiedAt_ != null) {
        if (modifiedAt_ == null) {
          ModifiedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ModifiedAt.MergeFrom(other.ModifiedAt);
      }
      if (other.Done != false) {
        Done = other.Done;
      }
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      switch (other.ResultCase) {
        case ResultOneofCase.Error:
          if (Error == null) {
            Error = new global::Google.Rpc.Status();
          }
          Error.MergeFrom(other.Error);
          break;
        case ResultOneofCase.Response:
          if (Response == null) {
            Response = new global::Google.Protobuf.WellKnownTypes.Any();
          }
          Response.MergeFrom(other.Response);
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            if (createdAt_ == null) {
              CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreatedAt);
            break;
          }
          case 34: {
            CreatedBy = input.ReadString();
            break;
          }
          case 42: {
            if (modifiedAt_ == null) {
              ModifiedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ModifiedAt);
            break;
          }
          case 48: {
            Done = input.ReadBool();
            break;
          }
          case 58: {
            if (metadata_ == null) {
              Metadata = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 66: {
            global::Google.Rpc.Status subBuilder = new global::Google.Rpc.Status();
            if (resultCase_ == ResultOneofCase.Error) {
              subBuilder.MergeFrom(Error);
            }
            input.ReadMessage(subBuilder);
            Error = subBuilder;
            break;
          }
          case 74: {
            global::Google.Protobuf.WellKnownTypes.Any subBuilder = new global::Google.Protobuf.WellKnownTypes.Any();
            if (resultCase_ == ResultOneofCase.Response) {
              subBuilder.MergeFrom(Response);
            }
            input.ReadMessage(subBuilder);
            Response = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
