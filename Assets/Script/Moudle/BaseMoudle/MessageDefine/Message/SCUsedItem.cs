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
  public partial class SCUsedItem : TBase
  {
    private int _playerUid;
    private int _itemId;
    private int _positionId;

    public int PlayerUid
    {
      get
      {
        return _playerUid;
      }
      set
      {
        __isset.playerUid = true;
        this._playerUid = value;
      }
    }

    public int ItemId
    {
      get
      {
        return _itemId;
      }
      set
      {
        __isset.itemId = true;
        this._itemId = value;
      }
    }

    public int PositionId
    {
      get
      {
        return _positionId;
      }
      set
      {
        __isset.positionId = true;
        this._positionId = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool playerUid;
      public bool itemId;
      public bool positionId;
    }

    public SCUsedItem() {
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
              PlayerUid = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.I32) {
              ItemId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 32:
            if (field.Type == TType.I32) {
              PositionId = iprot.ReadI32();
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
      TStruct struc = new TStruct("SCUsedItem");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.playerUid) {
        field.Name = "playerUid";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PlayerUid);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemId) {
        field.Name = "itemId";
        field.Type = TType.I32;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemId);
        oprot.WriteFieldEnd();
      }
      if (__isset.positionId) {
        field.Name = "positionId";
        field.Type = TType.I32;
        field.ID = 32;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(PositionId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("SCUsedItem(");
      sb.Append("PlayerUid: ");
      sb.Append(PlayerUid);
      sb.Append(",ItemId: ");
      sb.Append(ItemId);
      sb.Append(",PositionId: ");
      sb.Append(PositionId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
