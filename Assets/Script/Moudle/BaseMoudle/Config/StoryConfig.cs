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
  public partial class StoryConfig : TBase
  {
    private int _id;
    private int _dialogId;
    private int _talkerId;
    private bool _isFocusOnTalker;
    private int _delay;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public int DialogId
    {
      get
      {
        return _dialogId;
      }
      set
      {
        __isset.dialogId = true;
        this._dialogId = value;
      }
    }

    public int TalkerId
    {
      get
      {
        return _talkerId;
      }
      set
      {
        __isset.talkerId = true;
        this._talkerId = value;
      }
    }

    public bool IsFocusOnTalker
    {
      get
      {
        return _isFocusOnTalker;
      }
      set
      {
        __isset.isFocusOnTalker = true;
        this._isFocusOnTalker = value;
      }
    }

    public int Delay
    {
      get
      {
        return _delay;
      }
      set
      {
        __isset.delay = true;
        this._delay = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool dialogId;
      public bool talkerId;
      public bool isFocusOnTalker;
      public bool delay;
    }

    public StoryConfig() {
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
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              DialogId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              TalkerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.Bool) {
              IsFocusOnTalker = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.I32) {
              Delay = iprot.ReadI32();
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
      TStruct struc = new TStruct("StoryConfig");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.dialogId) {
        field.Name = "dialogId";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DialogId);
        oprot.WriteFieldEnd();
      }
      if (__isset.talkerId) {
        field.Name = "talkerId";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TalkerId);
        oprot.WriteFieldEnd();
      }
      if (__isset.isFocusOnTalker) {
        field.Name = "isFocusOnTalker";
        field.Type = TType.Bool;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsFocusOnTalker);
        oprot.WriteFieldEnd();
      }
      if (__isset.delay) {
        field.Name = "delay";
        field.Type = TType.I32;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Delay);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("StoryConfig(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",DialogId: ");
      sb.Append(DialogId);
      sb.Append(",TalkerId: ");
      sb.Append(TalkerId);
      sb.Append(",IsFocusOnTalker: ");
      sb.Append(IsFocusOnTalker);
      sb.Append(",Delay: ");
      sb.Append(Delay);
      sb.Append(")");
      return sb.ToString();
    }

  }

}