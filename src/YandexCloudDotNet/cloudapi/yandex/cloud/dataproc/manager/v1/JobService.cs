// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/dataproc/manager/v1/job_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Dataproc.Manager.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/dataproc/manager/v1/job_service.proto</summary>
  internal static partial class JobServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/dataproc/manager/v1/job_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JobServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJ5YW5kZXgvY2xvdWQvZGF0YXByb2MvbWFuYWdlci92MS9qb2Jfc2Vydmlj",
            "ZS5wcm90bxIgeWFuZGV4LmNsb3VkLmRhdGFwcm9jLm1hbmFnZXIudjEaHXlh",
            "bmRleC9jbG91ZC92YWxpZGF0aW9uLnByb3RvGip5YW5kZXgvY2xvdWQvZGF0",
            "YXByb2MvbWFuYWdlci92MS9qb2IucHJvdG8iiQEKD0xpc3RKb2JzUmVxdWVz",
            "dBIcCgpjbHVzdGVyX2lkGAEgASgJQgiKyDEEPD01MBIdCglwYWdlX3NpemUY",
            "AiABKANCCvrHMQY8PTEwMDASHQoKcGFnZV90b2tlbhgDIAEoCUIJisgxBTw9",
            "MTAwEhoKBmZpbHRlchgEIAEoCUIKisgxBjw9MTAwMCJgChBMaXN0Sm9ic1Jl",
            "c3BvbnNlEjMKBGpvYnMYASADKAsyJS55YW5kZXguY2xvdWQuZGF0YXByb2Mu",
            "bWFuYWdlci52MS5Kb2ISFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJIo4BChZV",
            "cGRhdGVKb2JTdGF0dXNSZXF1ZXN0EhwKCmNsdXN0ZXJfaWQYASABKAlCCIrI",
            "MQQ8PTUwEhgKBmpvYl9pZBgCIAEoCUIIisgxBDw9NTASPAoGc3RhdHVzGAMg",
            "ASgOMiwueWFuZGV4LmNsb3VkLmRhdGFwcm9jLm1hbmFnZXIudjEuSm9iLlN0",
            "YXR1cyIZChdVcGRhdGVKb2JTdGF0dXNSZXNwb25zZTKLAgoKSm9iU2Vydmlj",
            "ZRJ1CgpMaXN0QWN0aXZlEjEueWFuZGV4LmNsb3VkLmRhdGFwcm9jLm1hbmFn",
            "ZXIudjEuTGlzdEpvYnNSZXF1ZXN0GjIueWFuZGV4LmNsb3VkLmRhdGFwcm9j",
            "Lm1hbmFnZXIudjEuTGlzdEpvYnNSZXNwb25zZSIAEoUBCgxVcGRhdGVTdGF0",
            "dXMSOC55YW5kZXguY2xvdWQuZGF0YXByb2MubWFuYWdlci52MS5VcGRhdGVK",
            "b2JTdGF0dXNSZXF1ZXN0GjkueWFuZGV4LmNsb3VkLmRhdGFwcm9jLm1hbmFn",
            "ZXIudjEuVXBkYXRlSm9iU3RhdHVzUmVzcG9uc2UiAEJ9CiR5YW5kZXguY2xv",
            "dWQuYXBpLmRhdGFwcm9jLm1hbmFnZXIudjFaVWdpdGh1Yi5jb20veWFuZGV4",
            "LWNsb3VkL2dvLWdlbnByb3RvL3lhbmRleC9jbG91ZC9kYXRhcHJvYy9tYW5h",
            "Z2VyL3YxO2RhdGFwcm9jX21hbmFnZXJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Yandex.Cloud.ValidationReflection.Descriptor, global::Yandex.Cloud.Dataproc.Manager.V1.JobReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Dataproc.Manager.V1.ListJobsRequest), global::Yandex.Cloud.Dataproc.Manager.V1.ListJobsRequest.Parser, new[]{ "ClusterId", "PageSize", "PageToken", "Filter" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Dataproc.Manager.V1.ListJobsResponse), global::Yandex.Cloud.Dataproc.Manager.V1.ListJobsResponse.Parser, new[]{ "Jobs", "NextPageToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Dataproc.Manager.V1.UpdateJobStatusRequest), global::Yandex.Cloud.Dataproc.Manager.V1.UpdateJobStatusRequest.Parser, new[]{ "ClusterId", "JobId", "Status" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Dataproc.Manager.V1.UpdateJobStatusResponse), global::Yandex.Cloud.Dataproc.Manager.V1.UpdateJobStatusResponse.Parser, null, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class ListJobsRequest : pb::IMessage<ListJobsRequest> {
    private static readonly pb::MessageParser<ListJobsRequest> _parser = new pb::MessageParser<ListJobsRequest>(() => new ListJobsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListJobsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Dataproc.Manager.V1.JobServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsRequest(ListJobsRequest other) : this() {
      clusterId_ = other.clusterId_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      filter_ = other.filter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsRequest Clone() {
      return new ListJobsRequest(this);
    }

    /// <summary>Field number for the "cluster_id" field.</summary>
    public const int ClusterIdFieldNumber = 1;
    private string clusterId_ = "";
    /// <summary>
    /// Required. ID of the cluster to list Data Proc jobs of.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterId {
      get { return clusterId_; }
      set {
        clusterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private long pageSize_;
    /// <summary>
    /// The maximum number of results per page that should be returned. If the number of available
    /// results is larger than `page_size`, the service returns a `next_page_token` that can be used
    /// to get the next page of results in subsequent ListJobs requests.
    /// Acceptable values are 0 to 1000, inclusive. Default value: 100.
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
    /// Page token. Set `page_token` to the `next_page_token` returned by a previous ListJobs
    /// request to get the next page of results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 4;
    private string filter_ = "";
    /// <summary>
    /// String that describes a display filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListJobsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListJobsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterId != other.ClusterId) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      if (Filter != other.Filter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClusterId.Length != 0) hash ^= ClusterId.GetHashCode();
      if (PageSize != 0L) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
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
      if (ClusterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterId);
      }
      if (PageSize != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClusterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterId);
      }
      if (PageSize != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListJobsRequest other) {
      if (other == null) {
        return;
      }
      if (other.ClusterId.Length != 0) {
        ClusterId = other.ClusterId;
      }
      if (other.PageSize != 0L) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
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
            ClusterId = input.ReadString();
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
          case 34: {
            Filter = input.ReadString();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class ListJobsResponse : pb::IMessage<ListJobsResponse> {
    private static readonly pb::MessageParser<ListJobsResponse> _parser = new pb::MessageParser<ListJobsResponse>(() => new ListJobsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListJobsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Dataproc.Manager.V1.JobServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsResponse(ListJobsResponse other) : this() {
      jobs_ = other.jobs_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListJobsResponse Clone() {
      return new ListJobsResponse(this);
    }

    /// <summary>Field number for the "jobs" field.</summary>
    public const int JobsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.Dataproc.Manager.V1.Job> _repeated_jobs_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.Dataproc.Manager.V1.Job.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.Dataproc.Manager.V1.Job> jobs_ = new pbc::RepeatedField<global::Yandex.Cloud.Dataproc.Manager.V1.Job>();
    /// <summary>
    /// Requested list of Data Proc jobs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.Dataproc.Manager.V1.Job> Jobs {
      get { return jobs_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// This token allows you to get the next page of results for ListJobs requests,
    /// if the number of results is larger than `page_size` specified in the request.
    /// To get the next page, specify the value of `next_page_token` as a value for
    /// the `page_token` parameter in the next ListClusters request. Subsequent ListClusters
    /// requests will have their own `next_page_token` to continue paging through the results.
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
      return Equals(other as ListJobsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListJobsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!jobs_.Equals(other.jobs_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= jobs_.GetHashCode();
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
      jobs_.WriteTo(output, _repeated_jobs_codec);
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
      size += jobs_.CalculateSize(_repeated_jobs_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListJobsResponse other) {
      if (other == null) {
        return;
      }
      jobs_.Add(other.jobs_);
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
            jobs_.AddEntriesFrom(input, _repeated_jobs_codec);
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

  internal sealed partial class UpdateJobStatusRequest : pb::IMessage<UpdateJobStatusRequest> {
    private static readonly pb::MessageParser<UpdateJobStatusRequest> _parser = new pb::MessageParser<UpdateJobStatusRequest>(() => new UpdateJobStatusRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateJobStatusRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Dataproc.Manager.V1.JobServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusRequest(UpdateJobStatusRequest other) : this() {
      clusterId_ = other.clusterId_;
      jobId_ = other.jobId_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusRequest Clone() {
      return new UpdateJobStatusRequest(this);
    }

    /// <summary>Field number for the "cluster_id" field.</summary>
    public const int ClusterIdFieldNumber = 1;
    private string clusterId_ = "";
    /// <summary>
    /// Required. ID of the Data Proc cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClusterId {
      get { return clusterId_; }
      set {
        clusterId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "job_id" field.</summary>
    public const int JobIdFieldNumber = 2;
    private string jobId_ = "";
    /// <summary>
    /// Required. ID of the Data Proc job to update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JobId {
      get { return jobId_; }
      set {
        jobId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status status_ = global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status.Unspecified;
    /// <summary>
    /// Required. New status of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateJobStatusRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateJobStatusRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClusterId != other.ClusterId) return false;
      if (JobId != other.JobId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClusterId.Length != 0) hash ^= ClusterId.GetHashCode();
      if (JobId.Length != 0) hash ^= JobId.GetHashCode();
      if (Status != global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status.Unspecified) hash ^= Status.GetHashCode();
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
      if (ClusterId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClusterId);
      }
      if (JobId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(JobId);
      }
      if (Status != global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClusterId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClusterId);
      }
      if (JobId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JobId);
      }
      if (Status != global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UpdateJobStatusRequest other) {
      if (other == null) {
        return;
      }
      if (other.ClusterId.Length != 0) {
        ClusterId = other.ClusterId;
      }
      if (other.JobId.Length != 0) {
        JobId = other.JobId;
      }
      if (other.Status != global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status.Unspecified) {
        Status = other.Status;
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
            ClusterId = input.ReadString();
            break;
          }
          case 18: {
            JobId = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Yandex.Cloud.Dataproc.Manager.V1.Job.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  internal sealed partial class UpdateJobStatusResponse : pb::IMessage<UpdateJobStatusResponse> {
    private static readonly pb::MessageParser<UpdateJobStatusResponse> _parser = new pb::MessageParser<UpdateJobStatusResponse>(() => new UpdateJobStatusResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UpdateJobStatusResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Dataproc.Manager.V1.JobServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusResponse(UpdateJobStatusResponse other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UpdateJobStatusResponse Clone() {
      return new UpdateJobStatusResponse(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UpdateJobStatusResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UpdateJobStatusResponse other) {
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
    public void MergeFrom(UpdateJobStatusResponse other) {
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
