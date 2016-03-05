/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Config
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class LimitFuncSceneConfig : TBase
  {
    private int _limitId;
    private int _funcId;
    private int _targetId;

    public int LimitId
    {
      get
      {
        return _limitId;
      }
      set
      {
        __isset.limitId = true;
        this._limitId = value;
      }
    }

    public int FuncId
    {
      get
      {
        return _funcId;
      }
      set
      {
        __isset.funcId = true;
        this._funcId = value;
      }
    }

    public int TargetId
    {
      get
      {
        return _targetId;
      }
      set
      {
        __isset.targetId = true;
        this._targetId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool limitId;
      public bool funcId;
      public bool targetId;
    }

    public LimitFuncSceneConfig() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              LimitId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              FuncId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              TargetId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("LimitFuncSceneConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.limitId) {
        field.Name = "limitId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(LimitId);
        oprot.WriteFieldEnd();
      }
      if (__isset.funcId) {
        field.Name = "funcId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(FuncId);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetId) {
        field.Name = "targetId";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LimitFuncSceneConfig(");
      sb.Append("LimitId: ");
      sb.Append(LimitId);
      sb.Append(",FuncId: ");
      sb.Append(FuncId);
      sb.Append(",TargetId: ");
      sb.Append(TargetId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}