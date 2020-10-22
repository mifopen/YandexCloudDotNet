// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/mongodb/v1/maintenance.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Mongodb.V1 {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/mongodb/v1/maintenance.proto</summary>
  internal static partial class MaintenanceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/mongodb/v1/maintenance.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MaintenanceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci15YW5kZXgvY2xvdWQvbWRiL21vbmdvZGIvdjEvbWFpbnRlbmFuY2UucHJv",
            "dG8SG3lhbmRleC5jbG91ZC5tZGIubW9uZ29kYi52MRofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90bxodeWFuZGV4L2Nsb3VkL3ZhbGlkYXRpb24u",
            "cHJvdG8iyAEKEU1haW50ZW5hbmNlV2luZG93EkgKB2FueXRpbWUYASABKAsy",
            "NS55YW5kZXguY2xvdWQubWRiLm1vbmdvZGIudjEuQW55dGltZU1haW50ZW5h",
            "bmNlV2luZG93SAASWQoZd2Vla2x5X21haW50ZW5hbmNlX3dpbmRvdxgCIAEo",
            "CzI0LnlhbmRleC5jbG91ZC5tZGIubW9uZ29kYi52MS5XZWVrbHlNYWludGVu",
            "YW5jZVdpbmRvd0gAQg4KBnBvbGljeRIEwMExASIaChhBbnl0aW1lTWFpbnRl",
            "bmFuY2VXaW5kb3ci4AEKF1dlZWtseU1haW50ZW5hbmNlV2luZG93EkkKA2Rh",
            "eRgBIAEoDjI8LnlhbmRleC5jbG91ZC5tZGIubW9uZ29kYi52MS5XZWVrbHlN",
            "YWludGVuYW5jZVdpbmRvdy5XZWVrRGF5EhYKBGhvdXIYAiABKANCCPrHMQQx",
            "LTI0ImIKB1dlZWtEYXkSGAoUV0VFS19EQVlfVU5TUEVDSUZJRUQQABIHCgNN",
            "T04QARIHCgNUVUUQAhIHCgNXRUQQAxIHCgNUSFUQBBIHCgNGUkkQBRIHCgNT",
            "QVQQBhIHCgNTVU4QByJiChRNYWludGVuYW5jZU9wZXJhdGlvbhIXCgRpbmZv",
            "GAEgASgJQgmKyDEFPD0yNTYSMQoNZGVsYXllZF91bnRpbBgCIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCagofeWFuZGV4LmNsb3VkLmFwaS5t",
            "ZGIubW9uZ29kYi52MVpHZ2l0aHViLmNvbS95YW5kZXgtY2xvdWQvZ28tZ2Vu",
            "cHJvdG8veWFuZGV4L2Nsb3VkL21kYi9tb25nb2RiL3YxO21vbmdvZGJiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceWindow), global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceWindow.Parser, new[]{ "Anytime", "WeeklyMaintenanceWindow" }, new[]{ "Policy" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow), global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow), global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Parser, new[]{ "Day", "Hour" }, null, new[]{ typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceOperation), global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceOperation.Parser, new[]{ "Info", "DelayedUntil" }, null, null, null, null)
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
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceReflection.Descriptor.MessageTypes[0]; }
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
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow Anytime {
      get { return policyCase_ == PolicyOneofCase.Anytime ? (global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow) policy_ : null; }
      set {
        policy_ = value;
        policyCase_ = value == null ? PolicyOneofCase.None : PolicyOneofCase.Anytime;
      }
    }

    /// <summary>Field number for the "weekly_maintenance_window" field.</summary>
    public const int WeeklyMaintenanceWindowFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow WeeklyMaintenanceWindow {
      get { return policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow ? (global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow) policy_ : null; }
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
      WeeklyMaintenanceWindow = 2,
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
      if (!object.Equals(WeeklyMaintenanceWindow, other.WeeklyMaintenanceWindow)) return false;
      if (PolicyCase != other.PolicyCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (policyCase_ == PolicyOneofCase.Anytime) hash ^= Anytime.GetHashCode();
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
      if (policyCase_ == PolicyOneofCase.WeeklyMaintenanceWindow) {
        output.WriteRawTag(18);
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
            Anytime = new global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow();
          }
          Anytime.MergeFrom(other.Anytime);
          break;
        case PolicyOneofCase.WeeklyMaintenanceWindow:
          if (WeeklyMaintenanceWindow == null) {
            WeeklyMaintenanceWindow = new global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow();
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
            global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow subBuilder = new global::Yandex.Cloud.Mdb.Mongodb.V1.AnytimeMaintenanceWindow();
            if (policyCase_ == PolicyOneofCase.Anytime) {
              subBuilder.MergeFrom(Anytime);
            }
            input.ReadMessage(subBuilder);
            Anytime = subBuilder;
            break;
          }
          case 18: {
            global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow subBuilder = new global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow();
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
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceReflection.Descriptor.MessageTypes[1]; }
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

  internal sealed partial class WeeklyMaintenanceWindow : pb::IMessage<WeeklyMaintenanceWindow> {
    private static readonly pb::MessageParser<WeeklyMaintenanceWindow> _parser = new pb::MessageParser<WeeklyMaintenanceWindow>(() => new WeeklyMaintenanceWindow());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeeklyMaintenanceWindow> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceReflection.Descriptor.MessageTypes[2]; }
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
      day_ = other.day_;
      hour_ = other.hour_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeeklyMaintenanceWindow Clone() {
      return new WeeklyMaintenanceWindow(this);
    }

    /// <summary>Field number for the "day" field.</summary>
    public const int DayFieldNumber = 1;
    private global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay day_ = global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay.Unspecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay Day {
      get { return day_; }
      set {
        day_ = value;
      }
    }

    /// <summary>Field number for the "hour" field.</summary>
    public const int HourFieldNumber = 2;
    private long hour_;
    /// <summary>
    /// Hour of the day in UTC.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Hour {
      get { return hour_; }
      set {
        hour_ = value;
      }
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
      if (Day != other.Day) return false;
      if (Hour != other.Hour) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Day != global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay.Unspecified) hash ^= Day.GetHashCode();
      if (Hour != 0L) hash ^= Hour.GetHashCode();
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
      if (Day != global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Day);
      }
      if (Hour != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Hour);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Day != global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Day);
      }
      if (Hour != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Hour);
      }
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
      if (other.Day != global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay.Unspecified) {
        Day = other.Day;
      }
      if (other.Hour != 0L) {
        Hour = other.Hour;
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
            Day = (global::Yandex.Cloud.Mdb.Mongodb.V1.WeeklyMaintenanceWindow.Types.WeekDay) input.ReadEnum();
            break;
          }
          case 16: {
            Hour = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the WeeklyMaintenanceWindow message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      internal enum WeekDay {
        [pbr::OriginalName("WEEK_DAY_UNSPECIFIED")] Unspecified = 0,
        [pbr::OriginalName("MON")] Mon = 1,
        [pbr::OriginalName("TUE")] Tue = 2,
        [pbr::OriginalName("WED")] Wed = 3,
        [pbr::OriginalName("THU")] Thu = 4,
        [pbr::OriginalName("FRI")] Fri = 5,
        [pbr::OriginalName("SAT")] Sat = 6,
        [pbr::OriginalName("SUN")] Sun = 7,
      }

    }
    #endregion

  }

  internal sealed partial class MaintenanceOperation : pb::IMessage<MaintenanceOperation> {
    private static readonly pb::MessageParser<MaintenanceOperation> _parser = new pb::MessageParser<MaintenanceOperation>(() => new MaintenanceOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MaintenanceOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mongodb.V1.MaintenanceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceOperation(MaintenanceOperation other) : this() {
      info_ = other.info_;
      delayedUntil_ = other.delayedUntil_ != null ? other.delayedUntil_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MaintenanceOperation Clone() {
      return new MaintenanceOperation(this);
    }

    /// <summary>Field number for the "info" field.</summary>
    public const int InfoFieldNumber = 1;
    private string info_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Info {
      get { return info_; }
      set {
        info_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "delayed_until" field.</summary>
    public const int DelayedUntilFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp delayedUntil_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp DelayedUntil {
      get { return delayedUntil_; }
      set {
        delayedUntil_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MaintenanceOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MaintenanceOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Info != other.Info) return false;
      if (!object.Equals(DelayedUntil, other.DelayedUntil)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Info.Length != 0) hash ^= Info.GetHashCode();
      if (delayedUntil_ != null) hash ^= DelayedUntil.GetHashCode();
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
      if (Info.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Info);
      }
      if (delayedUntil_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DelayedUntil);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Info.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Info);
      }
      if (delayedUntil_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DelayedUntil);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MaintenanceOperation other) {
      if (other == null) {
        return;
      }
      if (other.Info.Length != 0) {
        Info = other.Info;
      }
      if (other.delayedUntil_ != null) {
        if (delayedUntil_ == null) {
          DelayedUntil = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        DelayedUntil.MergeFrom(other.DelayedUntil);
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
            Info = input.ReadString();
            break;
          }
          case 18: {
            if (delayedUntil_ == null) {
              DelayedUntil = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(DelayedUntil);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
