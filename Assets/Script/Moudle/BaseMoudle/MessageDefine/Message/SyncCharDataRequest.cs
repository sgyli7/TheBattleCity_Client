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

namespace NetWork.Auto
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class SyncCharDataRequest : TBase
  {
    private NetWork.Auto.CharBaseInfo _charBaseInfo;
    private NetWork.Auto.CharCounterInfo _charCounterInfo;
    private NetWork.Auto.CharBagInfo _charBagInfo;
    private NetWork.Auto.CharMissionInfo _charMissionInfo;

    public NetWork.Auto.CharBaseInfo CharBaseInfo
    {
      get
      {
        return _charBaseInfo;
      }
      set
      {
        __isset.charBaseInfo = true;
        this._charBaseInfo = value;
      }
    }

    public NetWork.Auto.CharCounterInfo CharCounterInfo
    {
      get
      {
        return _charCounterInfo;
      }
      set
      {
        __isset.charCounterInfo = true;
        this._charCounterInfo = value;
      }
    }

    public NetWork.Auto.CharBagInfo CharBagInfo
    {
      get
      {
        return _charBagInfo;
      }
      set
      {
        __isset.charBagInfo = true;
        this._charBagInfo = value;
      }
    }

    public NetWork.Auto.CharMissionInfo CharMissionInfo
    {
      get
      {
        return _charMissionInfo;
      }
      set
      {
        __isset.charMissionInfo = true;
        this._charMissionInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool charBaseInfo;
      public bool charCounterInfo;
      public bool charBagInfo;
      public bool charMissionInfo;
    }

    public SyncCharDataRequest() {
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
          case 10:
            if (field.Type == TType.Struct) {
              CharBaseInfo = new NetWork.Auto.CharBaseInfo();
              CharBaseInfo.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Struct) {
              CharCounterInfo = new NetWork.Auto.CharCounterInfo();
              CharCounterInfo.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.Struct) {
              CharBagInfo = new NetWork.Auto.CharBagInfo();
              CharBagInfo.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.Struct) {
              CharMissionInfo = new NetWork.Auto.CharMissionInfo();
              CharMissionInfo.Read(iprot);
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
      TStruct struc = new TStruct("SyncCharDataRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (CharBaseInfo != null && __isset.charBaseInfo) {
        field.Name = "charBaseInfo";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        CharBaseInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (CharCounterInfo != null && __isset.charCounterInfo) {
        field.Name = "charCounterInfo";
        field.Type = TType.Struct;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        CharCounterInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (CharBagInfo != null && __isset.charBagInfo) {
        field.Name = "charBagInfo";
        field.Type = TType.Struct;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        CharBagInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (CharMissionInfo != null && __isset.charMissionInfo) {
        field.Name = "charMissionInfo";
        field.Type = TType.Struct;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        CharMissionInfo.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SyncCharDataRequest(");
      sb.Append("CharBaseInfo: ");
      sb.Append(CharBaseInfo== null ? "<null>" : CharBaseInfo.ToString());
      sb.Append(",CharCounterInfo: ");
      sb.Append(CharCounterInfo== null ? "<null>" : CharCounterInfo.ToString());
      sb.Append(",CharBagInfo: ");
      sb.Append(CharBagInfo== null ? "<null>" : CharBagInfo.ToString());
      sb.Append(",CharMissionInfo: ");
      sb.Append(CharMissionInfo== null ? "<null>" : CharMissionInfo.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}