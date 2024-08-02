﻿// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ma_session_config_data.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from ma_session_config_data.proto</summary>
public static partial class MaSessionConfigDataReflection {

  #region Descriptor
  /// <summary>File descriptor for ma_session_config_data.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MaSessionConfigDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChxtYV9zZXNzaW9uX2NvbmZpZ19kYXRhLnByb3RvGhNtYV9wYWRfY29uZmln",
          "LnByb3RvIlgKEVNlc3Npb25Db25maWdEYXRhEh8KC3BhZF9jb25maWdzGAEg",
          "AygLMgouUGFkQ29uZmlnEhAKCGR1cmF0aW9uGAIgASgCEhAKCGludGVydmFs",
          "GAMgASgF"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::MaPadConfigReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::SessionConfigData), global::SessionConfigData.Parser, new[]{ "PadConfigs", "Duration", "Interval" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class SessionConfigData : pb::IMessage<SessionConfigData>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<SessionConfigData> _parser = new pb::MessageParser<SessionConfigData>(() => new SessionConfigData());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pb::MessageParser<SessionConfigData> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MaSessionConfigDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SessionConfigData() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SessionConfigData(SessionConfigData other) : this() {
    _hasBits0 = other._hasBits0;
    padConfigs_ = other.padConfigs_.Clone();
    duration_ = other.duration_;
    interval_ = other.interval_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public SessionConfigData Clone() {
    return new SessionConfigData(this);
  }

  /// <summary>Field number for the "pad_configs" field.</summary>
  public const int PadConfigsFieldNumber = 1;
  private static readonly pb::FieldCodec<global::PadConfig> _repeated_padConfigs_codec
      = pb::FieldCodec.ForMessage(10, global::PadConfig.Parser);
  private readonly pbc::RepeatedField<global::PadConfig> padConfigs_ = new pbc::RepeatedField<global::PadConfig>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public pbc::RepeatedField<global::PadConfig> PadConfigs {
    get { return padConfigs_; }
  }

  /// <summary>Field number for the "duration" field.</summary>
  public const int DurationFieldNumber = 2;
  private readonly static float DurationDefaultValue = 0F;

  private float duration_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public float Duration {
    get { if ((_hasBits0 & 1) != 0) { return duration_; } else { return DurationDefaultValue; } }
    set {
      _hasBits0 |= 1;
      duration_ = value;
    }
  }
  /// <summary>Gets whether the "duration" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasDuration {
    get { return (_hasBits0 & 1) != 0; }
  }
  /// <summary>Clears the value of the "duration" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearDuration() {
    _hasBits0 &= ~1;
  }

  /// <summary>Field number for the "interval" field.</summary>
  public const int IntervalFieldNumber = 3;
  private readonly static int IntervalDefaultValue = 0;

  private int interval_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int Interval {
    get { if ((_hasBits0 & 2) != 0) { return interval_; } else { return IntervalDefaultValue; } }
    set {
      _hasBits0 |= 2;
      interval_ = value;
    }
  }
  /// <summary>Gets whether the "interval" field is set</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool HasInterval {
    get { return (_hasBits0 & 2) != 0; }
  }
  /// <summary>Clears the value of the "interval" field</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void ClearInterval() {
    _hasBits0 &= ~2;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override bool Equals(object other) {
    return Equals(other as SessionConfigData);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public bool Equals(SessionConfigData other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!padConfigs_.Equals(other.padConfigs_)) return false;
    if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration)) return false;
    if (Interval != other.Interval) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= padConfigs_.GetHashCode();
    if (HasDuration) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
    if (HasInterval) hash ^= Interval.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    padConfigs_.WriteTo(output, _repeated_padConfigs_codec);
    if (HasDuration) {
      output.WriteRawTag(21);
      output.WriteFloat(Duration);
    }
    if (HasInterval) {
      output.WriteRawTag(24);
      output.WriteInt32(Interval);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    padConfigs_.WriteTo(ref output, _repeated_padConfigs_codec);
    if (HasDuration) {
      output.WriteRawTag(21);
      output.WriteFloat(Duration);
    }
    if (HasInterval) {
      output.WriteRawTag(24);
      output.WriteInt32(Interval);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public int CalculateSize() {
    int size = 0;
    size += padConfigs_.CalculateSize(_repeated_padConfigs_codec);
    if (HasDuration) {
      size += 1 + 4;
    }
    if (HasInterval) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Interval);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(SessionConfigData other) {
    if (other == null) {
      return;
    }
    padConfigs_.Add(other.padConfigs_);
    if (other.HasDuration) {
      Duration = other.Duration;
    }
    if (other.HasInterval) {
      Interval = other.Interval;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          padConfigs_.AddEntriesFrom(input, _repeated_padConfigs_codec);
          break;
        }
        case 21: {
          Duration = input.ReadFloat();
          break;
        }
        case 24: {
          Interval = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          padConfigs_.AddEntriesFrom(ref input, _repeated_padConfigs_codec);
          break;
        }
        case 21: {
          Duration = input.ReadFloat();
          break;
        }
        case 24: {
          Interval = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
