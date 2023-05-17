// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mediapipe/calculators/core/flow_limiter_calculator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mediapipe {

  /// <summary>Holder for reflection information generated from mediapipe/calculators/core/flow_limiter_calculator.proto</summary>
  public static partial class FlowLimiterCalculatorReflection {

    #region Descriptor
    /// <summary>File descriptor for mediapipe/calculators/core/flow_limiter_calculator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FlowLimiterCalculatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhtZWRpYXBpcGUvY2FsY3VsYXRvcnMvY29yZS9mbG93X2xpbWl0ZXJfY2Fs",
            "Y3VsYXRvci5wcm90bxIJbWVkaWFwaXBlGiRtZWRpYXBpcGUvZnJhbWV3b3Jr",
            "L2NhbGN1bGF0b3IucHJvdG8izQEKHEZsb3dMaW1pdGVyQ2FsY3VsYXRvck9w",
            "dGlvbnMSGAoNbWF4X2luX2ZsaWdodBgBIAEoBToBMRIXCgxtYXhfaW5fcXVl",
            "dWUYAiABKAU6ATASIgoRaW5fZmxpZ2h0X3RpbWVvdXQYAyABKAM6BzEwMDAw",
            "MDAyVgoDZXh0EhwubWVkaWFwaXBlLkNhbGN1bGF0b3JPcHRpb25zGPig9JsB",
            "IAEoCzInLm1lZGlhcGlwZS5GbG93TGltaXRlckNhbGN1bGF0b3JPcHRpb25z",
            "QkMKJWNvbS5nb29nbGUubWVkaWFwaXBlLmNhbGN1bGF0b3IucHJvdG9CGkZs",
            "b3dMaW1pdGVyQ2FsY3VsYXRvclByb3Rv"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mediapipe.CalculatorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mediapipe.FlowLimiterCalculatorOptions), global::Mediapipe.FlowLimiterCalculatorOptions.Parser, new[]{ "MaxInFlight", "MaxInQueue", "InFlightTimeout" }, null, null, new pb::Extension[] { global::Mediapipe.FlowLimiterCalculatorOptions.Extensions.Ext }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FlowLimiterCalculatorOptions : pb::IMessage<FlowLimiterCalculatorOptions>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FlowLimiterCalculatorOptions> _parser = new pb::MessageParser<FlowLimiterCalculatorOptions>(() => new FlowLimiterCalculatorOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FlowLimiterCalculatorOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mediapipe.FlowLimiterCalculatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlowLimiterCalculatorOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlowLimiterCalculatorOptions(FlowLimiterCalculatorOptions other) : this() {
      _hasBits0 = other._hasBits0;
      maxInFlight_ = other.maxInFlight_;
      maxInQueue_ = other.maxInQueue_;
      inFlightTimeout_ = other.inFlightTimeout_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlowLimiterCalculatorOptions Clone() {
      return new FlowLimiterCalculatorOptions(this);
    }

    /// <summary>Field number for the "max_in_flight" field.</summary>
    public const int MaxInFlightFieldNumber = 1;
    private readonly static int MaxInFlightDefaultValue = 1;

    private int maxInFlight_;
    /// <summary>
    /// The maximum number of frames released for processing at one time.
    /// The default value limits to 1 frame processing at a time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxInFlight {
      get { if ((_hasBits0 & 1) != 0) { return maxInFlight_; } else { return MaxInFlightDefaultValue; } }
      set {
        _hasBits0 |= 1;
        maxInFlight_ = value;
      }
    }
    /// <summary>Gets whether the "max_in_flight" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMaxInFlight {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "max_in_flight" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMaxInFlight() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "max_in_queue" field.</summary>
    public const int MaxInQueueFieldNumber = 2;
    private readonly static int MaxInQueueDefaultValue = 0;

    private int maxInQueue_;
    /// <summary>
    /// The maximum number of frames queued waiting for processing.
    /// The default value limits to 0 frames awaiting processing.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MaxInQueue {
      get { if ((_hasBits0 & 2) != 0) { return maxInQueue_; } else { return MaxInQueueDefaultValue; } }
      set {
        _hasBits0 |= 2;
        maxInQueue_ = value;
      }
    }
    /// <summary>Gets whether the "max_in_queue" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMaxInQueue {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "max_in_queue" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMaxInQueue() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "in_flight_timeout" field.</summary>
    public const int InFlightTimeoutFieldNumber = 3;
    private readonly static long InFlightTimeoutDefaultValue = 1000000L;

    private long inFlightTimeout_;
    /// <summary>
    /// The maximum time in microseconds to wait for a frame to finish processing.
    /// The default value stops waiting after 1 sec.
    /// The value 0 specifies no timeout.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long InFlightTimeout {
      get { if ((_hasBits0 & 4) != 0) { return inFlightTimeout_; } else { return InFlightTimeoutDefaultValue; } }
      set {
        _hasBits0 |= 4;
        inFlightTimeout_ = value;
      }
    }
    /// <summary>Gets whether the "in_flight_timeout" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasInFlightTimeout {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "in_flight_timeout" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearInFlightTimeout() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FlowLimiterCalculatorOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FlowLimiterCalculatorOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MaxInFlight != other.MaxInFlight) return false;
      if (MaxInQueue != other.MaxInQueue) return false;
      if (InFlightTimeout != other.InFlightTimeout) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasMaxInFlight) hash ^= MaxInFlight.GetHashCode();
      if (HasMaxInQueue) hash ^= MaxInQueue.GetHashCode();
      if (HasInFlightTimeout) hash ^= InFlightTimeout.GetHashCode();
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
      if (HasMaxInFlight) {
        output.WriteRawTag(8);
        output.WriteInt32(MaxInFlight);
      }
      if (HasMaxInQueue) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxInQueue);
      }
      if (HasInFlightTimeout) {
        output.WriteRawTag(24);
        output.WriteInt64(InFlightTimeout);
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
      if (HasMaxInFlight) {
        output.WriteRawTag(8);
        output.WriteInt32(MaxInFlight);
      }
      if (HasMaxInQueue) {
        output.WriteRawTag(16);
        output.WriteInt32(MaxInQueue);
      }
      if (HasInFlightTimeout) {
        output.WriteRawTag(24);
        output.WriteInt64(InFlightTimeout);
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
      if (HasMaxInFlight) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxInFlight);
      }
      if (HasMaxInQueue) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxInQueue);
      }
      if (HasInFlightTimeout) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(InFlightTimeout);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FlowLimiterCalculatorOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasMaxInFlight) {
        MaxInFlight = other.MaxInFlight;
      }
      if (other.HasMaxInQueue) {
        MaxInQueue = other.MaxInQueue;
      }
      if (other.HasInFlightTimeout) {
        InFlightTimeout = other.InFlightTimeout;
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
          case 8: {
            MaxInFlight = input.ReadInt32();
            break;
          }
          case 16: {
            MaxInQueue = input.ReadInt32();
            break;
          }
          case 24: {
            InFlightTimeout = input.ReadInt64();
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
          case 8: {
            MaxInFlight = input.ReadInt32();
            break;
          }
          case 16: {
            MaxInQueue = input.ReadInt32();
            break;
          }
          case 24: {
            InFlightTimeout = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

    #region Extensions
    /// <summary>Container for extensions for other messages declared in the FlowLimiterCalculatorOptions message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Extensions {
      public static readonly pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.FlowLimiterCalculatorOptions> Ext =
        new pb::Extension<global::Mediapipe.CalculatorOptions, global::Mediapipe.FlowLimiterCalculatorOptions>(326963320, pb::FieldCodec.ForMessage(2615706562, global::Mediapipe.FlowLimiterCalculatorOptions.Parser));
    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code