// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/compute/v1/snapshot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Compute.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/compute/v1/snapshot.proto</summary>
  internal static partial class SnapshotReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/compute/v1/snapshot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SnapshotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZ5YW5kZXgvY2xvdWQvY29tcHV0ZS92MS9zbmFwc2hvdC5wcm90bxIXeWFu",
            "ZGV4LmNsb3VkLmNvbXB1dGUudjEaH2dvb2dsZS9wcm90b2J1Zi90aW1lc3Rh",
            "bXAucHJvdG8izgMKCFNuYXBzaG90EgoKAmlkGAEgASgJEhEKCWZvbGRlcl9p",
            "ZBgCIAEoCRIuCgpjcmVhdGVkX2F0GAMgASgLMhouZ29vZ2xlLnByb3RvYnVm",
            "LlRpbWVzdGFtcBIMCgRuYW1lGAQgASgJEhMKC2Rlc2NyaXB0aW9uGAUgASgJ",
            "Ej0KBmxhYmVscxgGIAMoCzItLnlhbmRleC5jbG91ZC5jb21wdXRlLnYxLlNu",
            "YXBzaG90LkxhYmVsc0VudHJ5EhQKDHN0b3JhZ2Vfc2l6ZRgHIAEoAxIRCglk",
            "aXNrX3NpemUYCCABKAMSEwoLcHJvZHVjdF9pZHMYCSADKAkSOAoGc3RhdHVz",
            "GAogASgOMigueWFuZGV4LmNsb3VkLmNvbXB1dGUudjEuU25hcHNob3QuU3Rh",
            "dHVzEhYKDnNvdXJjZV9kaXNrX2lkGAsgASgJGi0KC0xhYmVsc0VudHJ5EgsK",
            "A2tleRgBIAEoCRINCgV2YWx1ZRgCIAEoCToCOAEiUgoGU3RhdHVzEhYKElNU",
            "QVRVU19VTlNQRUNJRklFRBAAEgwKCENSRUFUSU5HEAESCQoFUkVBRFkQAhIJ",
            "CgVFUlJPUhADEgwKCERFTEVUSU5HEARCRVpDZ2l0aHViLmNvbS95YW5kZXgt",
            "Y2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2NvbXB1dGUvdjE7Y29t",
            "cHV0ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Compute.V1.Snapshot), global::Yandex.Cloud.Compute.V1.Snapshot.Parser, new[]{ "Id", "FolderId", "CreatedAt", "Name", "Description", "Labels", "StorageSize", "DiskSize", "ProductIds", "Status", "SourceDiskId" }, null, new[]{ typeof(global::Yandex.Cloud.Compute.V1.Snapshot.Types.Status) }, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Snapshot resource. For more information, see [Snapshots](/docs/compute/concepts/snapshot).
  /// </summary>
  internal sealed partial class Snapshot : pb::IMessage<Snapshot> {
    private static readonly pb::MessageParser<Snapshot> _parser = new pb::MessageParser<Snapshot>(() => new Snapshot());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Snapshot> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Compute.V1.SnapshotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Snapshot() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Snapshot(Snapshot other) : this() {
      id_ = other.id_;
      folderId_ = other.folderId_;
      createdAt_ = other.createdAt_ != null ? other.createdAt_.Clone() : null;
      name_ = other.name_;
      description_ = other.description_;
      labels_ = other.labels_.Clone();
      storageSize_ = other.storageSize_;
      diskSize_ = other.diskSize_;
      productIds_ = other.productIds_.Clone();
      status_ = other.status_;
      sourceDiskId_ = other.sourceDiskId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Snapshot Clone() {
      return new Snapshot(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// ID of the snapshot.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "folder_id" field.</summary>
    public const int FolderIdFieldNumber = 2;
    private string folderId_ = "";
    /// <summary>
    /// ID of the folder that the snapshot belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FolderId {
      get { return folderId_; }
      set {
        folderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "created_at" field.</summary>
    public const int CreatedAtFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createdAt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreatedAt {
      get { return createdAt_; }
      set {
        createdAt_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private string name_ = "";
    /// <summary>
    /// Name of the snapshot. 1-63 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 5;
    private string description_ = "";
    /// <summary>
    /// Description of the snapshot. 0-256 characters long.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 6;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 50);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Resource labels as `key:value` pairs. Maximum of 64 per resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "storage_size" field.</summary>
    public const int StorageSizeFieldNumber = 7;
    private long storageSize_;
    /// <summary>
    /// Size of the snapshot, specified in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StorageSize {
      get { return storageSize_; }
      set {
        storageSize_ = value;
      }
    }

    /// <summary>Field number for the "disk_size" field.</summary>
    public const int DiskSizeFieldNumber = 8;
    private long diskSize_;
    /// <summary>
    /// Size of the disk when the snapshot was created, specified in bytes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long DiskSize {
      get { return diskSize_; }
      set {
        diskSize_ = value;
      }
    }

    /// <summary>Field number for the "product_ids" field.</summary>
    public const int ProductIdsFieldNumber = 9;
    private static readonly pb::FieldCodec<string> _repeated_productIds_codec
        = pb::FieldCodec.ForString(74);
    private readonly pbc::RepeatedField<string> productIds_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// License IDs that indicate which licenses are attached to this resource.
    /// License IDs are used to calculate additional charges for the use of the virtual machine.
    ///
    /// The correct license ID is generated by Yandex.Cloud. IDs are inherited by new resources created from this resource.
    ///
    /// If you know the license IDs, specify them when you create the image.
    /// For example, if you create a disk image using a third-party utility and load it into Yandex Object Storage, the license IDs will be lost.
    /// You can specify them in the [yandex.cloud.compute.v1.ImageService.Create] request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ProductIds {
      get { return productIds_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 10;
    private global::Yandex.Cloud.Compute.V1.Snapshot.Types.Status status_ = 0;
    /// <summary>
    /// Current status of the snapshot.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Compute.V1.Snapshot.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "source_disk_id" field.</summary>
    public const int SourceDiskIdFieldNumber = 11;
    private string sourceDiskId_ = "";
    /// <summary>
    /// ID of the source disk used to create this snapshot.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceDiskId {
      get { return sourceDiskId_; }
      set {
        sourceDiskId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Snapshot);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Snapshot other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (FolderId != other.FolderId) return false;
      if (!object.Equals(CreatedAt, other.CreatedAt)) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (StorageSize != other.StorageSize) return false;
      if (DiskSize != other.DiskSize) return false;
      if(!productIds_.Equals(other.productIds_)) return false;
      if (Status != other.Status) return false;
      if (SourceDiskId != other.SourceDiskId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (FolderId.Length != 0) hash ^= FolderId.GetHashCode();
      if (createdAt_ != null) hash ^= CreatedAt.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (StorageSize != 0L) hash ^= StorageSize.GetHashCode();
      if (DiskSize != 0L) hash ^= DiskSize.GetHashCode();
      hash ^= productIds_.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (SourceDiskId.Length != 0) hash ^= SourceDiskId.GetHashCode();
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
      if (FolderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FolderId);
      }
      if (createdAt_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(CreatedAt);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Description);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (StorageSize != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(StorageSize);
      }
      if (DiskSize != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(DiskSize);
      }
      productIds_.WriteTo(output, _repeated_productIds_codec);
      if (Status != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) Status);
      }
      if (SourceDiskId.Length != 0) {
        output.WriteRawTag(90);
        output.WriteString(SourceDiskId);
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
      if (FolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FolderId);
      }
      if (createdAt_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreatedAt);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (StorageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StorageSize);
      }
      if (DiskSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DiskSize);
      }
      size += productIds_.CalculateSize(_repeated_productIds_codec);
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (SourceDiskId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceDiskId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Snapshot other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.FolderId.Length != 0) {
        FolderId = other.FolderId;
      }
      if (other.createdAt_ != null) {
        if (createdAt_ == null) {
          CreatedAt = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreatedAt.MergeFrom(other.CreatedAt);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      labels_.Add(other.labels_);
      if (other.StorageSize != 0L) {
        StorageSize = other.StorageSize;
      }
      if (other.DiskSize != 0L) {
        DiskSize = other.DiskSize;
      }
      productIds_.Add(other.productIds_);
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.SourceDiskId.Length != 0) {
        SourceDiskId = other.SourceDiskId;
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
            FolderId = input.ReadString();
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
            Name = input.ReadString();
            break;
          }
          case 42: {
            Description = input.ReadString();
            break;
          }
          case 50: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 56: {
            StorageSize = input.ReadInt64();
            break;
          }
          case 64: {
            DiskSize = input.ReadInt64();
            break;
          }
          case 74: {
            productIds_.AddEntriesFrom(input, _repeated_productIds_codec);
            break;
          }
          case 80: {
            Status = (global::Yandex.Cloud.Compute.V1.Snapshot.Types.Status) input.ReadEnum();
            break;
          }
          case 90: {
            SourceDiskId = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Snapshot message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum Status {
        [pbr::OriginalName("STATUS_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Snapshot is being created.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// Snapshot is ready to use.
        /// </summary>
        [pbr::OriginalName("READY")] Ready = 2,
        /// <summary>
        /// Snapshot encountered a problem and cannot operate.
        /// </summary>
        [pbr::OriginalName("ERROR")] Error = 3,
        /// <summary>
        /// Snapshot is being deleted.
        /// </summary>
        [pbr::OriginalName("DELETING")] Deleting = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code