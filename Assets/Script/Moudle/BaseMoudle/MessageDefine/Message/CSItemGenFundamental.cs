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
  public partial class CSItemGenFundamental : TBase
  {
    private NetWork.Auto.ItemGenFundamental _genFundamental;

    public NetWork.Auto.ItemGenFundamental GenFundamental
    {
      get
      {
        return _genFundamental;
      }
      set
      {
        __isset.genFundamental = true;
        this._genFundamental = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool genFundamental;
    }

    public CSItemGenFundamental() {
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
              GenFundamental = new NetWork.Auto.ItemGenFundamental();
              GenFundamental.Read(iprot);
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
      TStruct struc = new TStruct("CSItemGenFundamental");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (GenFundamental != null && __isset.genFundamental) {
        field.Name = "genFundamental";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        GenFundamental.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CSItemGenFundamental(");
      sb.Append("GenFundamental: ");
      sb.Append(GenFundamental== null ? "<null>" : GenFundamental.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
