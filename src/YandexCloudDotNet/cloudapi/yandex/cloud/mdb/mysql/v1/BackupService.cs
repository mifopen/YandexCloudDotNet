// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/mysql/v1/backup_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Mysql.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/mysql/v1/backup_service.proto</summary>
  internal static partial class BackupServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/mysql/v1/backup_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BackupServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci55YW5kZXgvY2xvdWQvbWRiL215c3FsL3YxL2JhY2t1cF9zZXJ2aWNlLnBy",
            "b3RvEhl5YW5kZXguY2xvdWQubWRiLm15c3FsLnYxGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvGh15YW5kZXgvY2xvdWQvdmFsaWRhdGlvbi5wcm90",
            "bxomeWFuZGV4L2Nsb3VkL21kYi9teXNxbC92MS9iYWNrdXAucHJvdG8iKwoQ",
            "R2V0QmFja3VwUmVxdWVzdBIXCgliYWNrdXBfaWQYASABKAlCBOjHMQEicwoS",
            "TGlzdEJhY2t1cHNSZXF1ZXN0Eh8KCWZvbGRlcl9pZBgBIAEoCUIM6McxAYrI",
            "MQQ8PTUwEh0KCXBhZ2Vfc2l6ZRgCIAEoA0IK+scxBjw9MTAwMBIdCgpwYWdl",
            "X3Rva2VuGAMgASgJQgmKyDEFPD0xMDAibQoTTGlzdEJhY2t1cHNSZXNwb25z",
            "ZRIyCgdiYWNrdXBzGAEgAygLMiEueWFuZGV4LmNsb3VkLm1kYi5teXNxbC52",
            "MS5CYWNrdXASIgoPbmV4dF9wYWdlX3Rva2VuGAIgASgJQgmKyDEFPD0xMDAy",
            "oQIKDUJhY2t1cFNlcnZpY2UShAEKA0dldBIrLnlhbmRleC5jbG91ZC5tZGIu",
            "bXlzcWwudjEuR2V0QmFja3VwUmVxdWVzdBohLnlhbmRleC5jbG91ZC5tZGIu",
            "bXlzcWwudjEuQmFja3VwIi2C0+STAicSJS9tYW5hZ2VkLW15c3FsL3YxL2Jh",
            "Y2t1cHMve2JhY2t1cF9pZH0SiAEKBExpc3QSLS55YW5kZXguY2xvdWQubWRi",
            "Lm15c3FsLnYxLkxpc3RCYWNrdXBzUmVxdWVzdBouLnlhbmRleC5jbG91ZC5t",
            "ZGIubXlzcWwudjEuTGlzdEJhY2t1cHNSZXNwb25zZSIhgtPkkwIbEhkvbWFu",
            "YWdlZC1teXNxbC92MS9iYWNrdXBzQmQKHXlhbmRleC5jbG91ZC5hcGkubWRi",
            "Lm15c3FsLnYxWkNnaXRodWIuY29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90",
            "by95YW5kZXgvY2xvdWQvbWRiL215c3FsL3YxO215c3FsYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, global::Yandex.Cloud.Mdb.Mysql.V1.BackupReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mysql.V1.GetBackupRequest), global::Yandex.Cloud.Mdb.Mysql.V1.GetBackupRequest.Parser, new[]{ "BackupId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mysql.V1.ListBackupsRequest), global::Yandex.Cloud.Mdb.Mysql.V1.ListBackupsRequest.Parser, new[]{ "FolderId", "PageSize", "PageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mysql.V1.ListBackupsResponse), global::Yandex.Cloud.Mdb.Mysql.V1.ListBackupsResponse.Parser, new[]{ "Backups", "NextPageToken" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class GetBackupRequest : pb::IMessage<GetBackupRequest> {
    private static readonly pb::MessageParser<GetBackupRequest> _parser = new pb::MessageParser<GetBackupRequest>(() => new GetBackupRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetBackupRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mysql.V1.BackupServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBackupRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBackupRequest(GetBackupRequest other) : this() {
      backupId_ = other.backupId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetBackupRequest Clone() {
      return new GetBackupRequest(this);
    }

    /// <summary>Field number for the "backup_id" field.</summary>
    public const int BackupIdFieldNumber = 1;
    private string backupId_ = "";
    /// <summary>
    /// ID of the backup to return information about.
    /// To get the backup ID, use a [ClusterService.ListBackups] request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BackupId {
      get { return backupId_; }
      set {
        backupId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetBackupRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetBackupRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BackupId != other.BackupId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BackupId.Length != 0) hash ^= BackupId.GetHashCode();
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
      if (BackupId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(BackupId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BackupId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BackupId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetBackupRequest other) {
      if (other == null) {
        return;
      }
      if (other.BackupId.Length != 0) {
        BackupId = other.BackupId;
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
            BackupId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListBackupsRequest : pb::IMessage<ListBackupsRequest> {
    private static readonly pb::MessageParser<ListBackupsRequest> _parser = new pb::MessageParser<ListBackupsRequest>(() => new ListBackupsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListBackupsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mysql.V1.BackupServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsRequest(ListBackupsRequest other) : this() {
      folderId_ = other.folderId_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsRequest Clone() {
      return new ListBackupsRequest(this);
    }

    /// <summary>Field number for the "folder_id" field.</summary>
    public const int FolderIdFieldNumber = 1;
    private string folderId_ = "";
    /// <summary>
    /// ID of the folder to list backups in.
    /// To get the folder ID, use a [yandex.cloud.resourcemanager.v1.FolderService.List] request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FolderId {
      get { return folderId_; }
      set {
        folderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page to return. If the number of available
    /// results is larger than [page_size], the service returns a [ListBackupsResponse.next_page_token]
    /// that can be used to get the next page of results in subsequent list requests.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    /// <summary>
    /// Page token.  To get the next page of results, Set [page_token] to the [ListBackupsResponse.next_page_token]
    /// returned by a previous list request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListBackupsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListBackupsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FolderId != other.FolderId) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FolderId.Length != 0) hash ^= FolderId.GetHashCode();
      if (PageSize != 0L) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
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
      if (FolderId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FolderId);
      }
      if (PageSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FolderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FolderId);
      }
      if (PageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListBackupsRequest other) {
      if (other == null) {
        return;
      }
      if (other.FolderId.Length != 0) {
        FolderId = other.FolderId;
      }
      if (other.PageSize != 0L) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
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
            FolderId = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt64();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListBackupsResponse : pb::IMessage<ListBackupsResponse> {
    private static readonly pb::MessageParser<ListBackupsResponse> _parser = new pb::MessageParser<ListBackupsResponse>(() => new ListBackupsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListBackupsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mysql.V1.BackupServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsResponse(ListBackupsResponse other) : this() {
      backups_ = other.backups_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListBackupsResponse Clone() {
      return new ListBackupsResponse(this);
    }

    /// <summary>Field number for the "backups" field.</summary>
    public const int BackupsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Mdb.Mysql.V1.Backup> _repeated_backups_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Mdb.Mysql.V1.Backup.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Mdb.Mysql.V1.Backup> backups_ = new pbc::RepeatedField<global::Yandex.Cloud.Mdb.Mysql.V1.Backup>();
    /// <summary>
    /// List of MySQL backups.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Mdb.Mysql.V1.Backup> Backups {
      get { return backups_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for list requests. If the number of results
    /// is larger than [ListBackupsRequest.page_size], use the [next_page_token] as the value
    /// for the [ListBackupsRequest.page_token] parameter in the next list request. Each subsequent
    /// list request will have its own [next_page_token] to continue paging through the results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListBackupsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListBackupsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!backups_.Equals(other.backups_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= backups_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      backups_.WriteTo(output, _repeated_backups_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += backups_.CalculateSize(_repeated_backups_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListBackupsResponse other) {
      if (other == null) {
        return;
      }
      backups_.Add(other.backups_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
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
            backups_.AddEntriesFrom(input, _repeated_backups_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
