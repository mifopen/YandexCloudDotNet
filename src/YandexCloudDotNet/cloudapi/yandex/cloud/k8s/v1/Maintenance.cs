// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/k8s/v1/maintenance.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.K8S.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/k8s/v1/maintenance.proto</summary>
  internal static partial class MaintenanceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/k8s/v1/maintenance.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MaintenanceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiV5YW5kZXgvY2xvdWQvazhzL3YxL21haW50ZW5hbmNlLnByb3RvEhN5YW5k",
            "ZXguY2xvdWQuazhzLnYxGhtnb29nbGUvdHlwZS9kYXlvZndlZWsucHJvdG8a",
            "G2dvb2dsZS90eXBlL3RpbWVvZmRheS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVm",
            "L2R1cmF0aW9uLnByb3RvGh15YW5kZXgvY2xvdWQvdmFsaWRhdGlvbi5wcm90",
            "byKJAgoRTWFpbnRlbmFuY2VXaW5kb3cSQAoHYW55dGltZRgBIAEoCzItLnlh",
            "bmRleC5jbG91ZC5rOHMudjEuQW55dGltZU1haW50ZW5hbmNlV2luZG93SAAS",
            "TwoYZGFpbHlfbWFpbnRlbmFuY2Vfd2luZG93GAIgASgLMisueWFuZGV4LmNs",
            "b3VkLms4cy52MS5EYWlseU1haW50ZW5hbmNlV2luZG93SAASUQoZd2Vla2x5",
            "X21haW50ZW5hbmNlX3dpbmRvdxgDIAEoCzIsLnlhbmRleC5jbG91ZC5rOHMu",
            "djEuV2Vla2x5TWFpbnRlbmFuY2VXaW5kb3dIAEIOCgZwb2xpY3kSBMDBMQEi",
            "GgoYQW55dGltZU1haW50ZW5hbmNlV2luZG93IoMBChZEYWlseU1haW50ZW5h",
            "bmNlV2luZG93EjAKCnN0YXJ0X3RpbWUYASABKAsyFi5nb29nbGUudHlwZS5U",
            "aW1lT2ZEYXlCBOjHMQESNwoIZHVyYXRpb24YAiABKAsyGS5nb29nbGUucHJv",
            "dG9idWYuRHVyYXRpb25CCvrHMQYxaC0yNGgitwEKG0RheXNPZldlZWtNYWlu",
            "dGVuYW5jZVdpbmRvdxItCgRkYXlzGAEgAygOMhYuZ29vZ2xlLnR5cGUuRGF5",
            "T2ZXZWVrQgeCyDEDMS03EjAKCnN0YXJ0X3RpbWUYAiABKAsyFi5nb29nbGUu",
            "dHlwZS5UaW1lT2ZEYXlCBOjHMQESNwoIZHVyYXRpb24YAyABKAsyGS5nb29n",
            "bGUucHJvdG9idWYuRHVyYXRpb25CCvrHMQYxaC0yNGgiagoXV2Vla2x5TWFp",
            "bnRlbmFuY2VXaW5kb3cSTwoMZGF5c19vZl93ZWVrGAEgAygLMjAueWFuZGV4",
            "LmNsb3VkLms4cy52MS5EYXlzT2ZXZWVrTWFpbnRlbmFuY2VXaW5kb3dCB4LI",
            "MQMxLTdCVgoXeWFuZGV4LmNsb3VkLmFwaS5rOHMudjFaO2dpdGh1Yi5jb20v",
            "eWFuZGV4LWNsb3VkL2dvLWdlbnByb3RvL3lhbmRleC9jbG91ZC9rOHMvdjE7",
            "azhzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Type.DayofweekReflection.Descriptor, global::Google.Type.TimeofdayReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.DurationReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.MaintenanceWindow), global::Yandex.Cloud.K8S.V1.MaintenanceWindow.Parser, new[]{ "Anytime", "DailyMaintenanceWindow", "WeeklyMaintenanceWindow" }, new[]{ "Policy" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow), global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow), global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow.Parser, new[]{ "StartTime", "Duration" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow), global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow.Parser, new[]{ "Days", "StartTime", "Duration" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow), global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow.Parser, new[]{ "DaysOfWeek" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  internal sealed partial class MaintenanceWindow : pb::IMessage<MaintenanceWindow> {
    private static readonly pb::MessageParser<MaintenanceWindow> _parser = new pb::MessageParser<MaintenanceWindow>(() => new MaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.MaintenanceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceWindow(MaintenanceWindow other) : this() {
      switch (other.PolicyCase) {
        case PolicyOneofCase.Anytime:
          Anytime = other.Anytime.Clone();
          break;
        case PolicyOneofCase.DailyMaintenanceWindow:
          DailyMaintenanceWindow = other.DailyMaintenanceWindow.Clone();
          break;
        case PolicyOneofCase.WeeklyMaintenanceWindow:
          WeeklyMaintenanceWindow = other.WeeklyMaintenanceWindow.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceWindow Clone() {
      return new MaintenanceWindow(this);
    }

    /// <summary>Field number for the "anytime" field.</summary>
    public const int AnytimeFieldNumber = 1;
    /// <summary>
    /// Updating the master at any time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow Anytime {
      get { return policyCase_ == PolicyOneofCase.Anytime ? (global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow) policy_ : null; }
      set {
        policy_ = value;
        policyCase_ = value == null ? PolicyOneofCase.None : PolicyOneofCase.Anytime;
      }
    }

    /// <summary>Field number for the "daily_maintenance_window" field.</summary>
    public const int DailyMaintenanceWindowFieldNumber = 2;
    /// <summary>
    /// Updating the master on any day during the specified time window.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow DailyMaintenanceWindow {
      get { return policyCase_ == PolicyOneofCase.DailyMaintenanceWindow ? (global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow) policy_ : null; }
      set {
        policy_ = value;
        policyCase_ = value == null ? PolicyOneofCase.None : PolicyOneofCase.DailyMaintenanceWindow;
      }
    }

    /// <summary>Field number for the "weekly_maintenance_window" field.</summary>
    public const int WeeklyMaintenanceWindowFieldNumber = 3;
    /// <summary>
    /// Updating the master on selected days during the specified time window.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow WeeklyMaintenanceWindow {
      get { return policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow ? (global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow) policy_ : null; }
      set {
        policy_ = value;
        policyCase_ = value == null ? PolicyOneofCase.None : PolicyOneofCase.WeeklyMaintenanceWindow;
      }
    }

    private object policy_;
    /// <summary>Enum of possible cases for the "policy" oneof.</summary>
    public enum PolicyOneofCase {
      None = 0,
      Anytime = 1,
      DailyMaintenanceWindow = 2,
      WeeklyMaintenanceWindow = 3,
    }
    private PolicyOneofCase policyCase_ = PolicyOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyOneofCase PolicyCase {
      get { return policyCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPolicy() {
      policyCase_ = PolicyOneofCase.None;
      policy_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MaintenanceWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MaintenanceWindow other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Anytime, other.Anytime)) return false;
      if (!object.Equals(DailyMaintenanceWindow, other.DailyMaintenanceWindow)) return false;
      if (!object.Equals(WeeklyMaintenanceWindow, other.WeeklyMaintenanceWindow)) return false;
      if (PolicyCase != other.PolicyCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (policyCase_ == PolicyOneofCase.Anytime) hash ^= Anytime.GetHashCode();
      if (policyCase_ == PolicyOneofCase.DailyMaintenanceWindow) hash ^= DailyMaintenanceWindow.GetHashCode();
      if (policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow) hash ^= WeeklyMaintenanceWindow.GetHashCode();
      hash ^= (int) policyCase_;
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
      if (policyCase_ == PolicyOneofCase.Anytime) {
        output.WriteRawTag(10);
        output.WriteMessage(Anytime);
      }
      if (policyCase_ == PolicyOneofCase.DailyMaintenanceWindow) {
        output.WriteRawTag(18);
        output.WriteMessage(DailyMaintenanceWindow);
      }
      if (policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow) {
        output.WriteRawTag(26);
        output.WriteMessage(WeeklyMaintenanceWindow);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (policyCase_ == PolicyOneofCase.Anytime) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Anytime);
      }
      if (policyCase_ == PolicyOneofCase.DailyMaintenanceWindow) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyMaintenanceWindow);
      }
      if (policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(WeeklyMaintenanceWindow);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MaintenanceWindow other) {
      if (other == null) {
        return;
      }
      switch (other.PolicyCase) {
        case PolicyOneofCase.Anytime:
          if (Anytime == null) {
            Anytime = new global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow();
          }
          Anytime.MergeFrom(other.Anytime);
          break;
        case PolicyOneofCase.DailyMaintenanceWindow:
          if (DailyMaintenanceWindow == null) {
            DailyMaintenanceWindow = new global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow();
          }
          DailyMaintenanceWindow.MergeFrom(other.DailyMaintenanceWindow);
          break;
        case PolicyOneofCase.WeeklyMaintenanceWindow:
          if (WeeklyMaintenanceWindow == null) {
            WeeklyMaintenanceWindow = new global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow();
          }
          WeeklyMaintenanceWindow.MergeFrom(other.WeeklyMaintenanceWindow);
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
            global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow subBuilder = new global::Yandex.Cloud.K8S.V1.AnytimeMaintenanceWindow();
            if (policyCase_ == PolicyOneofCase.Anytime) {
              subBuilder.MergeFrom(Anytime);
            }
            input.ReadMessage(subBuilder);
            Anytime = subBuilder;
            break;
          }
          case 18: {
            global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow subBuilder = new global::Yandex.Cloud.K8S.V1.DailyMaintenanceWindow();
            if (policyCase_ == PolicyOneofCase.DailyMaintenanceWindow) {
              subBuilder.MergeFrom(DailyMaintenanceWindow);
            }
            input.ReadMessage(subBuilder);
            DailyMaintenanceWindow = subBuilder;
            break;
          }
          case 26: {
            global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow subBuilder = new global::Yandex.Cloud.K8S.V1.WeeklyMaintenanceWindow();
            if (policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow) {
              subBuilder.MergeFrom(WeeklyMaintenanceWindow);
            }
            input.ReadMessage(subBuilder);
            WeeklyMaintenanceWindow = subBuilder;
            break;
          }
        }
      }
    }

  }

  internal sealed partial class AnytimeMaintenanceWindow : pb::IMessage<AnytimeMaintenanceWindow> {
    private static readonly pb::MessageParser<AnytimeMaintenanceWindow> _parser = new pb::MessageParser<AnytimeMaintenanceWindow>(() => new AnytimeMaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AnytimeMaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.MaintenanceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnytimeMaintenanceWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnytimeMaintenanceWindow(AnytimeMaintenanceWindow other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AnytimeMaintenanceWindow Clone() {
      return new AnytimeMaintenanceWindow(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AnytimeMaintenanceWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AnytimeMaintenanceWindow other) {
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
    public void MergeFrom(AnytimeMaintenanceWindow other) {
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

  internal sealed partial class DailyMaintenanceWindow : pb::IMessage<DailyMaintenanceWindow> {
    private static readonly pb::MessageParser<DailyMaintenanceWindow> _parser = new pb::MessageParser<DailyMaintenanceWindow>(() => new DailyMaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DailyMaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.MaintenanceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyMaintenanceWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyMaintenanceWindow(DailyMaintenanceWindow other) : this() {
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyMaintenanceWindow Clone() {
      return new DailyMaintenanceWindow(this);
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 1;
    private global::Google.Type.TimeOfDay startTime_;
    /// <summary>
    /// Window start time, in the UTC timezone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Type.TimeOfDay StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    /// <summary>
    /// Window duration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DailyMaintenanceWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DailyMaintenanceWindow other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
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
      if (startTime_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(StartTime);
      }
      if (duration_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DailyMaintenanceWindow other) {
      if (other == null) {
        return;
      }
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Type.TimeOfDay();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
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
            if (startTime_ == null) {
              StartTime = new global::Google.Type.TimeOfDay();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 18: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class DaysOfWeekMaintenanceWindow : pb::IMessage<DaysOfWeekMaintenanceWindow> {
    private static readonly pb::MessageParser<DaysOfWeekMaintenanceWindow> _parser = new pb::MessageParser<DaysOfWeekMaintenanceWindow>(() => new DaysOfWeekMaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DaysOfWeekMaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.MaintenanceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DaysOfWeekMaintenanceWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DaysOfWeekMaintenanceWindow(DaysOfWeekMaintenanceWindow other) : this() {
      days_ = other.days_.Clone();
      startTime_ = other.startTime_ != null ? other.startTime_.Clone() : null;
      duration_ = other.duration_ != null ? other.duration_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DaysOfWeekMaintenanceWindow Clone() {
      return new DaysOfWeekMaintenanceWindow(this);
    }

    /// <summary>Field number for the "days" field.</summary>
    public const int DaysFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Type.DayOfWeek> _repeated_days_codec
        = pb::FieldCodec.ForEnum(10, x => (int) x, x => (global::Google.Type.DayOfWeek) x);
    private readonly pbc::RepeatedField<global::Google.Type.DayOfWeek> days_ = new pbc::RepeatedField<global::Google.Type.DayOfWeek>();
    /// <summary>
    /// Days of the week when automatic updates are allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Type.DayOfWeek> Days {
      get { return days_; }
    }

    /// <summary>Field number for the "start_time" field.</summary>
    public const int StartTimeFieldNumber = 2;
    private global::Google.Type.TimeOfDay startTime_;
    /// <summary>
    /// Window start time, in the UTC timezone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Type.TimeOfDay StartTime {
      get { return startTime_; }
      set {
        startTime_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Duration duration_;
    /// <summary>
    /// Window duration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Duration Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DaysOfWeekMaintenanceWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DaysOfWeekMaintenanceWindow other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!days_.Equals(other.days_)) return false;
      if (!object.Equals(StartTime, other.StartTime)) return false;
      if (!object.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= days_.GetHashCode();
      if (startTime_ != null) hash ^= StartTime.GetHashCode();
      if (duration_ != null) hash ^= Duration.GetHashCode();
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
      days_.WriteTo(output, _repeated_days_codec);
      if (startTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StartTime);
      }
      if (duration_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Duration);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += days_.CalculateSize(_repeated_days_codec);
      if (startTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StartTime);
      }
      if (duration_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Duration);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DaysOfWeekMaintenanceWindow other) {
      if (other == null) {
        return;
      }
      days_.Add(other.days_);
      if (other.startTime_ != null) {
        if (startTime_ == null) {
          StartTime = new global::Google.Type.TimeOfDay();
        }
        StartTime.MergeFrom(other.StartTime);
      }
      if (other.duration_ != null) {
        if (duration_ == null) {
          Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
        }
        Duration.MergeFrom(other.Duration);
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
          case 10:
          case 8: {
            days_.AddEntriesFrom(input, _repeated_days_codec);
            break;
          }
          case 18: {
            if (startTime_ == null) {
              StartTime = new global::Google.Type.TimeOfDay();
            }
            input.ReadMessage(StartTime);
            break;
          }
          case 26: {
            if (duration_ == null) {
              Duration = new global::Google.Protobuf.WellKnownTypes.Duration();
            }
            input.ReadMessage(Duration);
            break;
          }
        }
      }
    }

  }

  internal sealed partial class WeeklyMaintenanceWindow : pb::IMessage<WeeklyMaintenanceWindow> {
    private static readonly pb::MessageParser<WeeklyMaintenanceWindow> _parser = new pb::MessageParser<WeeklyMaintenanceWindow>(() => new WeeklyMaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeeklyMaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.K8S.V1.MaintenanceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeeklyMaintenanceWindow() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeeklyMaintenanceWindow(WeeklyMaintenanceWindow other) : this() {
      daysOfWeek_ = other.daysOfWeek_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeeklyMaintenanceWindow Clone() {
      return new WeeklyMaintenanceWindow(this);
    }

    /// <summary>Field number for the "days_of_week" field.</summary>
    public const int DaysOfWeekFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow> _repeated_daysOfWeek_codec
        = pb::FieldCodec.ForMessage(10, global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow.Parser);
    private readonly pbc::RepeatedField<global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow> daysOfWeek_ = new pbc::RepeatedField<global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow>();
    /// <summary>
    /// Days of the week and the maintenance window for these days when automatic updates are allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yandex.Cloud.K8S.V1.DaysOfWeekMaintenanceWindow> DaysOfWeek {
      get { return daysOfWeek_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WeeklyMaintenanceWindow);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WeeklyMaintenanceWindow other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!daysOfWeek_.Equals(other.daysOfWeek_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= daysOfWeek_.GetHashCode();
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
      daysOfWeek_.WriteTo(output, _repeated_daysOfWeek_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += daysOfWeek_.CalculateSize(_repeated_daysOfWeek_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WeeklyMaintenanceWindow other) {
      if (other == null) {
        return;
      }
      daysOfWeek_.Add(other.daysOfWeek_);
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
            daysOfWeek_.AddEntriesFrom(input, _repeated_daysOfWeek_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code