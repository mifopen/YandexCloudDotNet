// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/mdb/mysql/v1alpha/config/mysql5_7.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud.Mdb.Mysql.V1Alpha.Config {

  /// <summary>Holder for reflection information generated from yandex/cloud/mdb/mysql/v1alpha/config/mysql5_7.proto</summary>
  internal static partial class Mysql57Reflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/mdb/mysql/v1alpha/config/mysql5_7.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Mysql57Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjR5YW5kZXgvY2xvdWQvbWRiL215c3FsL3YxYWxwaGEvY29uZmlnL215c3Fs",
            "NV83LnByb3RvEiV5YW5kZXguY2xvdWQubWRiLm15c3FsLnYxYWxwaGEuY29u",
            "ZmlnGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHXlhbmRleC9j",
            "bG91ZC92YWxpZGF0aW9uLnByb3RvItgBCg5NeXNxbENvbmZpZzVfNxJLChdp",
            "bm5vZGJfYnVmZmVyX3Bvb2xfc2l6ZRgBIAEoCzIbLmdvb2dsZS5wcm90b2J1",
            "Zi5JbnQ2NFZhbHVlQg36xzEJPj01MjQyODgwEkIKD21heF9jb25uZWN0aW9u",
            "cxgCIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgz6xzEIMTAt",
            "MTAwMDASNQoPbG9uZ19xdWVyeV90aW1lGAMgASgLMhwuZ29vZ2xlLnByb3Rv",
            "YnVmLkRvdWJsZVZhbHVlIv8BChFNeXNxbENvbmZpZ1NldDVfNxJPChBlZmZl",
            "Y3RpdmVfY29uZmlnGAEgASgLMjUueWFuZGV4LmNsb3VkLm1kYi5teXNxbC52",
            "MWFscGhhLmNvbmZpZy5NeXNxbENvbmZpZzVfNxJKCgt1c2VyX2NvbmZpZxgC",
            "IAEoCzI1LnlhbmRleC5jbG91ZC5tZGIubXlzcWwudjFhbHBoYS5jb25maWcu",
            "TXlzcWxDb25maWc1XzcSTQoOZGVmYXVsdF9jb25maWcYAyABKAsyNS55YW5k",
            "ZXguY2xvdWQubWRiLm15c3FsLnYxYWxwaGEuY29uZmlnLk15c3FsQ29uZmln",
            "NV83QlFaT2dpdGh1Yi5jb20veWFuZGV4LWNsb3VkL2dvLWdlbnByb3RvL3lh",
            "bmRleC9jbG91ZC9tZGIvbXlzcWwvdjFhbHBoYS9jb25maWc7bXlzcWxiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7), global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7.Parser, new[]{ "InnodbBufferPoolSize", "MaxConnections", "LongQueryTime" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfigSet5_7), global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfigSet5_7.Parser, new[]{ "EffectiveConfig", "UserConfig", "DefaultConfig" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Options and structure of `MysqlConfig5_7` reflects MySQL 5.7 configuration file
  /// </summary>
  internal sealed partial class MysqlConfig5_7 : pb::IMessage<MysqlConfig5_7> {
    private static readonly pb::MessageParser<MysqlConfig5_7> _parser = new pb::MessageParser<MysqlConfig5_7>(() => new MysqlConfig5_7());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MysqlConfig5_7> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.Mysql57Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfig5_7() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfig5_7(MysqlConfig5_7 other) : this() {
      InnodbBufferPoolSize = other.InnodbBufferPoolSize;
      MaxConnections = other.MaxConnections;
      LongQueryTime = other.LongQueryTime;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfig5_7 Clone() {
      return new MysqlConfig5_7(this);
    }

    /// <summary>Field number for the "innodb_buffer_pool_size" field.</summary>
    public const int InnodbBufferPoolSizeFieldNumber = 1;
    private static readonly pb::FieldCodec<long?> _single_innodbBufferPoolSize_codec = pb::FieldCodec.ForStructWrapper<long>(10);
    private long? innodbBufferPoolSize_;
    /// <summary>
    /// Size of the InnoDB buffer pool used for caching table and index data.
    ///
    /// For details, see [MySQL documentation for the parameter](https://dev.mysql.com/doc/refman/5.7/en/innodb-parameters.html#sysvar_innodb_buffer_pool_size).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? InnodbBufferPoolSize {
      get { return innodbBufferPoolSize_; }
      set {
        innodbBufferPoolSize_ = value;
      }
    }


    /// <summary>Field number for the "max_connections" field.</summary>
    public const int MaxConnectionsFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_maxConnections_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? maxConnections_;
    /// <summary>
    /// The maximum permitted number of simultaneous client connections.
    ///
    /// For details, see [MySQL documentation for the variable](https://dev.mysql.com/doc/refman/5.7/en/server-system-variables.html#sysvar_max_connections).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? MaxConnections {
      get { return maxConnections_; }
      set {
        maxConnections_ = value;
      }
    }


    /// <summary>Field number for the "long_query_time" field.</summary>
    public const int LongQueryTimeFieldNumber = 3;
    private static readonly pb::FieldCodec<double?> _single_longQueryTime_codec = pb::FieldCodec.ForStructWrapper<double>(26);
    private double? longQueryTime_;
    /// <summary>
    /// Time that it takes to process a query before it is considered slow.
    ///
    /// For details, see [MySQL documentation for the variable](https://dev.mysql.com/doc/refman/5.7/en/server-system-variables.html#sysvar_long_query_time).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double? LongQueryTime {
      get { return longQueryTime_; }
      set {
        longQueryTime_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MysqlConfig5_7);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MysqlConfig5_7 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (InnodbBufferPoolSize != other.InnodbBufferPoolSize) return false;
      if (MaxConnections != other.MaxConnections) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.Equals(LongQueryTime, other.LongQueryTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (innodbBufferPoolSize_ != null) hash ^= InnodbBufferPoolSize.GetHashCode();
      if (maxConnections_ != null) hash ^= MaxConnections.GetHashCode();
      if (longQueryTime_ != null) hash ^= pbc::ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparer.GetHashCode(LongQueryTime);
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
      if (innodbBufferPoolSize_ != null) {
        _single_innodbBufferPoolSize_codec.WriteTagAndValue(output, InnodbBufferPoolSize);
      }
      if (maxConnections_ != null) {
        _single_maxConnections_codec.WriteTagAndValue(output, MaxConnections);
      }
      if (longQueryTime_ != null) {
        _single_longQueryTime_codec.WriteTagAndValue(output, LongQueryTime);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (innodbBufferPoolSize_ != null) {
        size += _single_innodbBufferPoolSize_codec.CalculateSizeWithTag(InnodbBufferPoolSize);
      }
      if (maxConnections_ != null) {
        size += _single_maxConnections_codec.CalculateSizeWithTag(MaxConnections);
      }
      if (longQueryTime_ != null) {
        size += _single_longQueryTime_codec.CalculateSizeWithTag(LongQueryTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MysqlConfig5_7 other) {
      if (other == null) {
        return;
      }
      if (other.innodbBufferPoolSize_ != null) {
        if (innodbBufferPoolSize_ == null || other.InnodbBufferPoolSize != 0L) {
          InnodbBufferPoolSize = other.InnodbBufferPoolSize;
        }
      }
      if (other.maxConnections_ != null) {
        if (maxConnections_ == null || other.MaxConnections != 0L) {
          MaxConnections = other.MaxConnections;
        }
      }
      if (other.longQueryTime_ != null) {
        if (longQueryTime_ == null || other.LongQueryTime != 0D) {
          LongQueryTime = other.LongQueryTime;
        }
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
            long? value = _single_innodbBufferPoolSize_codec.Read(input);
            if (innodbBufferPoolSize_ == null || value != 0L) {
              InnodbBufferPoolSize = value;
            }
            break;
          }
          case 18: {
            long? value = _single_maxConnections_codec.Read(input);
            if (maxConnections_ == null || value != 0L) {
              MaxConnections = value;
            }
            break;
          }
          case 26: {
            double? value = _single_longQueryTime_codec.Read(input);
            if (longQueryTime_ == null || value != 0D) {
              LongQueryTime = value;
            }
            break;
          }
        }
      }
    }

  }

  internal sealed partial class MysqlConfigSet5_7 : pb::IMessage<MysqlConfigSet5_7> {
    private static readonly pb::MessageParser<MysqlConfigSet5_7> _parser = new pb::MessageParser<MysqlConfigSet5_7>(() => new MysqlConfigSet5_7());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MysqlConfigSet5_7> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.Mysql57Reflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfigSet5_7() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfigSet5_7(MysqlConfigSet5_7 other) : this() {
      effectiveConfig_ = other.effectiveConfig_ != null ? other.effectiveConfig_.Clone() : null;
      userConfig_ = other.userConfig_ != null ? other.userConfig_.Clone() : null;
      defaultConfig_ = other.defaultConfig_ != null ? other.defaultConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MysqlConfigSet5_7 Clone() {
      return new MysqlConfigSet5_7(this);
    }

    /// <summary>Field number for the "effective_config" field.</summary>
    public const int EffectiveConfigFieldNumber = 1;
    private global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 effectiveConfig_;
    /// <summary>
    /// Effective settings for a MySQL 5.7 cluster (a combination of settings defined
    /// in [user_config] and [default_config]).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 EffectiveConfig {
      get { return effectiveConfig_; }
      set {
        effectiveConfig_ = value;
      }
    }

    /// <summary>Field number for the "user_config" field.</summary>
    public const int UserConfigFieldNumber = 2;
    private global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 userConfig_;
    /// <summary>
    /// User-defined settings for a MySQL 5.7 cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 UserConfig {
      get { return userConfig_; }
      set {
        userConfig_ = value;
      }
    }

    /// <summary>Field number for the "default_config" field.</summary>
    public const int DefaultConfigFieldNumber = 3;
    private global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 defaultConfig_;
    /// <summary>
    /// Default configuration for a MySQL 5.7 cluster.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7 DefaultConfig {
      get { return defaultConfig_; }
      set {
        defaultConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MysqlConfigSet5_7);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MysqlConfigSet5_7 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(EffectiveConfig, other.EffectiveConfig)) return false;
      if (!object.Equals(UserConfig, other.UserConfig)) return false;
      if (!object.Equals(DefaultConfig, other.DefaultConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (effectiveConfig_ != null) hash ^= EffectiveConfig.GetHashCode();
      if (userConfig_ != null) hash ^= UserConfig.GetHashCode();
      if (defaultConfig_ != null) hash ^= DefaultConfig.GetHashCode();
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
      if (effectiveConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(EffectiveConfig);
      }
      if (userConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserConfig);
      }
      if (defaultConfig_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(DefaultConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (effectiveConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EffectiveConfig);
      }
      if (userConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserConfig);
      }
      if (defaultConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DefaultConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MysqlConfigSet5_7 other) {
      if (other == null) {
        return;
      }
      if (other.effectiveConfig_ != null) {
        if (effectiveConfig_ == null) {
          EffectiveConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
        }
        EffectiveConfig.MergeFrom(other.EffectiveConfig);
      }
      if (other.userConfig_ != null) {
        if (userConfig_ == null) {
          UserConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
        }
        UserConfig.MergeFrom(other.UserConfig);
      }
      if (other.defaultConfig_ != null) {
        if (defaultConfig_ == null) {
          DefaultConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
        }
        DefaultConfig.MergeFrom(other.DefaultConfig);
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
            if (effectiveConfig_ == null) {
              EffectiveConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
            }
            input.ReadMessage(EffectiveConfig);
            break;
          }
          case 18: {
            if (userConfig_ == null) {
              UserConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
            }
            input.ReadMessage(UserConfig);
            break;
          }
          case 26: {
            if (defaultConfig_ == null) {
              DefaultConfig = new global::Yandex.Cloud.Mdb.Mysql.V1Alpha.Config.MysqlConfig5_7();
            }
            input.ReadMessage(DefaultConfig);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code