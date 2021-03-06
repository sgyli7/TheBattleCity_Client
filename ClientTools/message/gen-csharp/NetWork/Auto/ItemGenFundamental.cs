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
  public partial class ItemGenFundamental : TBase
  {
    private List<int> _positionId;
    private List<int> _itemList;
    private int _maxCount;
    private int _genPreTimeItemCountMin;
    private int _genPreTimeItemCountMax;
    private int _triggerDeltaTime;
    private int _initItemCount;

    public List<int> PositionId
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

    public List<int> ItemList
    {
      get
      {
        return _itemList;
      }
      set
      {
        __isset.itemList = true;
        this._itemList = value;
      }
    }

    public int MaxCount
    {
      get
      {
        return _maxCount;
      }
      set
      {
        __isset.maxCount = true;
        this._maxCount = value;
      }
    }

    public int GenPreTimeItemCountMin
    {
      get
      {
        return _genPreTimeItemCountMin;
      }
      set
      {
        __isset.genPreTimeItemCountMin = true;
        this._genPreTimeItemCountMin = value;
      }
    }

    public int GenPreTimeItemCountMax
    {
      get
      {
        return _genPreTimeItemCountMax;
      }
      set
      {
        __isset.genPreTimeItemCountMax = true;
        this._genPreTimeItemCountMax = value;
      }
    }

    public int TriggerDeltaTime
    {
      get
      {
        return _triggerDeltaTime;
      }
      set
      {
        __isset.triggerDeltaTime = true;
        this._triggerDeltaTime = value;
      }
    }

    public int InitItemCount
    {
      get
      {
        return _initItemCount;
      }
      set
      {
        __isset.initItemCount = true;
        this._initItemCount = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool positionId;
      public bool itemList;
      public bool maxCount;
      public bool genPreTimeItemCountMin;
      public bool genPreTimeItemCountMax;
      public bool triggerDeltaTime;
      public bool initItemCount;
    }

    public ItemGenFundamental() {
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
            if (field.Type == TType.List) {
              {
                PositionId = new List<int>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  int _elem2 = 0;
                  _elem2 = iprot.ReadI32();
                  PositionId.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.List) {
              {
                ItemList = new List<int>();
                TList _list3 = iprot.ReadListBegin();
                for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                {
                  int _elem5 = 0;
                  _elem5 = iprot.ReadI32();
                  ItemList.Add(_elem5);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 30:
            if (field.Type == TType.I32) {
              MaxCount = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 40:
            if (field.Type == TType.I32) {
              GenPreTimeItemCountMin = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 50:
            if (field.Type == TType.I32) {
              GenPreTimeItemCountMax = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 60:
            if (field.Type == TType.I32) {
              TriggerDeltaTime = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 70:
            if (field.Type == TType.I32) {
              InitItemCount = iprot.ReadI32();
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
      TStruct struc = new TStruct("ItemGenFundamental");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (PositionId != null && __isset.positionId) {
        field.Name = "positionId";
        field.Type = TType.List;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, PositionId.Count));
          foreach (int _iter6 in PositionId)
          {
            oprot.WriteI32(_iter6);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (ItemList != null && __isset.itemList) {
        field.Name = "itemList";
        field.Type = TType.List;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, ItemList.Count));
          foreach (int _iter7 in ItemList)
          {
            oprot.WriteI32(_iter7);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.maxCount) {
        field.Name = "maxCount";
        field.Type = TType.I32;
        field.ID = 30;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MaxCount);
        oprot.WriteFieldEnd();
      }
      if (__isset.genPreTimeItemCountMin) {
        field.Name = "genPreTimeItemCountMin";
        field.Type = TType.I32;
        field.ID = 40;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GenPreTimeItemCountMin);
        oprot.WriteFieldEnd();
      }
      if (__isset.genPreTimeItemCountMax) {
        field.Name = "genPreTimeItemCountMax";
        field.Type = TType.I32;
        field.ID = 50;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(GenPreTimeItemCountMax);
        oprot.WriteFieldEnd();
      }
      if (__isset.triggerDeltaTime) {
        field.Name = "triggerDeltaTime";
        field.Type = TType.I32;
        field.ID = 60;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TriggerDeltaTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.initItemCount) {
        field.Name = "initItemCount";
        field.Type = TType.I32;
        field.ID = 70;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InitItemCount);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ItemGenFundamental(");
      sb.Append("PositionId: ");
      sb.Append(PositionId);
      sb.Append(",ItemList: ");
      sb.Append(ItemList);
      sb.Append(",MaxCount: ");
      sb.Append(MaxCount);
      sb.Append(",GenPreTimeItemCountMin: ");
      sb.Append(GenPreTimeItemCountMin);
      sb.Append(",GenPreTimeItemCountMax: ");
      sb.Append(GenPreTimeItemCountMax);
      sb.Append(",TriggerDeltaTime: ");
      sb.Append(TriggerDeltaTime);
      sb.Append(",InitItemCount: ");
      sb.Append(InitItemCount);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
