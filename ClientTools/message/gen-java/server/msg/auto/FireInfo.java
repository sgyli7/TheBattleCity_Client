/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
package server.msg.auto;

import org.apache.thrift.scheme.IScheme;
import org.apache.thrift.scheme.SchemeFactory;
import org.apache.thrift.scheme.StandardScheme;

import org.apache.thrift.scheme.TupleScheme;
import org.apache.thrift.protocol.TTupleProtocol;
import org.apache.thrift.protocol.TProtocolException;
import org.apache.thrift.EncodingUtils;
import org.apache.thrift.TException;
import org.apache.thrift.async.AsyncMethodCallback;
import org.apache.thrift.server.AbstractNonblockingServer.*;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import java.util.EnumMap;
import java.util.Set;
import java.util.HashSet;
import java.util.EnumSet;
import java.util.Collections;
import java.util.BitSet;
import java.nio.ByteBuffer;
import java.util.Arrays;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class FireInfo implements org.apache.thrift.TBase<FireInfo, FireInfo._Fields>, java.io.Serializable, Cloneable, Comparable<FireInfo> {
  private static final org.apache.thrift.protocol.TStruct STRUCT_DESC = new org.apache.thrift.protocol.TStruct("FireInfo");

  private static final org.apache.thrift.protocol.TField CURRENT_POSITION_FIELD_DESC = new org.apache.thrift.protocol.TField("currentPosition", org.apache.thrift.protocol.TType.STRUCT, (short)10);
  private static final org.apache.thrift.protocol.TField FIRE_DIRECTION_FIELD_DESC = new org.apache.thrift.protocol.TField("fireDirection", org.apache.thrift.protocol.TType.STRUCT, (short)20);
  private static final org.apache.thrift.protocol.TField BULLET_NAME_FIELD_DESC = new org.apache.thrift.protocol.TField("bulletName", org.apache.thrift.protocol.TType.STRING, (short)30);

  private static final Map<Class<? extends IScheme>, SchemeFactory> schemes = new HashMap<Class<? extends IScheme>, SchemeFactory>();
  static {
    schemes.put(StandardScheme.class, new FireInfoStandardSchemeFactory());
    schemes.put(TupleScheme.class, new FireInfoTupleSchemeFactory());
  }

  public ThriftVector3 currentPosition; // required
  public ThriftVector3 fireDirection; // required
  public String bulletName; // required

  /** The set of fields this struct contains, along with convenience methods for finding and manipulating them. */
  public enum _Fields implements org.apache.thrift.TFieldIdEnum {
    CURRENT_POSITION((short)10, "currentPosition"),
    FIRE_DIRECTION((short)20, "fireDirection"),
    BULLET_NAME((short)30, "bulletName");

    private static final Map<String, _Fields> byName = new HashMap<String, _Fields>();

    static {
      for (_Fields field : EnumSet.allOf(_Fields.class)) {
        byName.put(field.getFieldName(), field);
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, or null if its not found.
     */
    public static _Fields findByThriftId(int fieldId) {
      switch(fieldId) {
        case 10: // CURRENT_POSITION
          return CURRENT_POSITION;
        case 20: // FIRE_DIRECTION
          return FIRE_DIRECTION;
        case 30: // BULLET_NAME
          return BULLET_NAME;
        default:
          return null;
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, throwing an exception
     * if it is not found.
     */
    public static _Fields findByThriftIdOrThrow(int fieldId) {
      _Fields fields = findByThriftId(fieldId);
      if (fields == null) throw new IllegalArgumentException("Field " + fieldId + " doesn't exist!");
      return fields;
    }

    /**
     * Find the _Fields constant that matches name, or null if its not found.
     */
    public static _Fields findByName(String name) {
      return byName.get(name);
    }

    private final short _thriftId;
    private final String _fieldName;

    _Fields(short thriftId, String fieldName) {
      _thriftId = thriftId;
      _fieldName = fieldName;
    }

    public short getThriftFieldId() {
      return _thriftId;
    }

    public String getFieldName() {
      return _fieldName;
    }
  }

  // isset id assignments
  public static final Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> metaDataMap;
  static {
    Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> tmpMap = new EnumMap<_Fields, org.apache.thrift.meta_data.FieldMetaData>(_Fields.class);
    tmpMap.put(_Fields.CURRENT_POSITION, new org.apache.thrift.meta_data.FieldMetaData("currentPosition", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.StructMetaData(org.apache.thrift.protocol.TType.STRUCT, ThriftVector3.class)));
    tmpMap.put(_Fields.FIRE_DIRECTION, new org.apache.thrift.meta_data.FieldMetaData("fireDirection", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.StructMetaData(org.apache.thrift.protocol.TType.STRUCT, ThriftVector3.class)));
    tmpMap.put(_Fields.BULLET_NAME, new org.apache.thrift.meta_data.FieldMetaData("bulletName", org.apache.thrift.TFieldRequirementType.DEFAULT, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    metaDataMap = Collections.unmodifiableMap(tmpMap);
    org.apache.thrift.meta_data.FieldMetaData.addStructMetaDataMap(FireInfo.class, metaDataMap);
  }

  public FireInfo() {
  }

  public FireInfo(
    ThriftVector3 currentPosition,
    ThriftVector3 fireDirection,
    String bulletName)
  {
    this();
    this.currentPosition = currentPosition;
    this.fireDirection = fireDirection;
    this.bulletName = bulletName;
  }

  /**
   * Performs a deep copy on <i>other</i>.
   */
  public FireInfo(FireInfo other) {
    if (other.isSetCurrentPosition()) {
      this.currentPosition = new ThriftVector3(other.currentPosition);
    }
    if (other.isSetFireDirection()) {
      this.fireDirection = new ThriftVector3(other.fireDirection);
    }
    if (other.isSetBulletName()) {
      this.bulletName = other.bulletName;
    }
  }

  public FireInfo deepCopy() {
    return new FireInfo(this);
  }

  @Override
  public void clear() {
    this.currentPosition = null;
    this.fireDirection = null;
    this.bulletName = null;
  }

  public ThriftVector3 getCurrentPosition() {
    return this.currentPosition;
  }

  public FireInfo setCurrentPosition(ThriftVector3 currentPosition) {
    this.currentPosition = currentPosition;
    return this;
  }

  public void unsetCurrentPosition() {
    this.currentPosition = null;
  }

  /** Returns true if field currentPosition is set (has been assigned a value) and false otherwise */
  public boolean isSetCurrentPosition() {
    return this.currentPosition != null;
  }

  public void setCurrentPositionIsSet(boolean value) {
    if (!value) {
      this.currentPosition = null;
    }
  }

  public ThriftVector3 getFireDirection() {
    return this.fireDirection;
  }

  public FireInfo setFireDirection(ThriftVector3 fireDirection) {
    this.fireDirection = fireDirection;
    return this;
  }

  public void unsetFireDirection() {
    this.fireDirection = null;
  }

  /** Returns true if field fireDirection is set (has been assigned a value) and false otherwise */
  public boolean isSetFireDirection() {
    return this.fireDirection != null;
  }

  public void setFireDirectionIsSet(boolean value) {
    if (!value) {
      this.fireDirection = null;
    }
  }

  public String getBulletName() {
    return this.bulletName;
  }

  public FireInfo setBulletName(String bulletName) {
    this.bulletName = bulletName;
    return this;
  }

  public void unsetBulletName() {
    this.bulletName = null;
  }

  /** Returns true if field bulletName is set (has been assigned a value) and false otherwise */
  public boolean isSetBulletName() {
    return this.bulletName != null;
  }

  public void setBulletNameIsSet(boolean value) {
    if (!value) {
      this.bulletName = null;
    }
  }

  public void setFieldValue(_Fields field, Object value) {
    switch (field) {
    case CURRENT_POSITION:
      if (value == null) {
        unsetCurrentPosition();
      } else {
        setCurrentPosition((ThriftVector3)value);
      }
      break;

    case FIRE_DIRECTION:
      if (value == null) {
        unsetFireDirection();
      } else {
        setFireDirection((ThriftVector3)value);
      }
      break;

    case BULLET_NAME:
      if (value == null) {
        unsetBulletName();
      } else {
        setBulletName((String)value);
      }
      break;

    }
  }

  public Object getFieldValue(_Fields field) {
    switch (field) {
    case CURRENT_POSITION:
      return getCurrentPosition();

    case FIRE_DIRECTION:
      return getFireDirection();

    case BULLET_NAME:
      return getBulletName();

    }
    throw new IllegalStateException();
  }

  /** Returns true if field corresponding to fieldID is set (has been assigned a value) and false otherwise */
  public boolean isSet(_Fields field) {
    if (field == null) {
      throw new IllegalArgumentException();
    }

    switch (field) {
    case CURRENT_POSITION:
      return isSetCurrentPosition();
    case FIRE_DIRECTION:
      return isSetFireDirection();
    case BULLET_NAME:
      return isSetBulletName();
    }
    throw new IllegalStateException();
  }

  @Override
  public boolean equals(Object that) {
    if (that == null)
      return false;
    if (that instanceof FireInfo)
      return this.equals((FireInfo)that);
    return false;
  }

  public boolean equals(FireInfo that) {
    if (that == null)
      return false;

    boolean this_present_currentPosition = true && this.isSetCurrentPosition();
    boolean that_present_currentPosition = true && that.isSetCurrentPosition();
    if (this_present_currentPosition || that_present_currentPosition) {
      if (!(this_present_currentPosition && that_present_currentPosition))
        return false;
      if (!this.currentPosition.equals(that.currentPosition))
        return false;
    }

    boolean this_present_fireDirection = true && this.isSetFireDirection();
    boolean that_present_fireDirection = true && that.isSetFireDirection();
    if (this_present_fireDirection || that_present_fireDirection) {
      if (!(this_present_fireDirection && that_present_fireDirection))
        return false;
      if (!this.fireDirection.equals(that.fireDirection))
        return false;
    }

    boolean this_present_bulletName = true && this.isSetBulletName();
    boolean that_present_bulletName = true && that.isSetBulletName();
    if (this_present_bulletName || that_present_bulletName) {
      if (!(this_present_bulletName && that_present_bulletName))
        return false;
      if (!this.bulletName.equals(that.bulletName))
        return false;
    }

    return true;
  }

  @Override
  public int hashCode() {
    return 0;
  }

  @Override
  public int compareTo(FireInfo other) {
    if (!getClass().equals(other.getClass())) {
      return getClass().getName().compareTo(other.getClass().getName());
    }

    int lastComparison = 0;

    lastComparison = Boolean.valueOf(isSetCurrentPosition()).compareTo(other.isSetCurrentPosition());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetCurrentPosition()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.currentPosition, other.currentPosition);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetFireDirection()).compareTo(other.isSetFireDirection());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetFireDirection()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.fireDirection, other.fireDirection);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetBulletName()).compareTo(other.isSetBulletName());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetBulletName()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.bulletName, other.bulletName);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    return 0;
  }

  public _Fields fieldForId(int fieldId) {
    return _Fields.findByThriftId(fieldId);
  }

  public void read(org.apache.thrift.protocol.TProtocol iprot) throws org.apache.thrift.TException {
    schemes.get(iprot.getScheme()).getScheme().read(iprot, this);
  }

  public void write(org.apache.thrift.protocol.TProtocol oprot) throws org.apache.thrift.TException {
    schemes.get(oprot.getScheme()).getScheme().write(oprot, this);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder("FireInfo(");
    boolean first = true;

    sb.append("currentPosition:");
    if (this.currentPosition == null) {
      sb.append("null");
    } else {
      sb.append(this.currentPosition);
    }
    first = false;
    if (!first) sb.append(", ");
    sb.append("fireDirection:");
    if (this.fireDirection == null) {
      sb.append("null");
    } else {
      sb.append(this.fireDirection);
    }
    first = false;
    if (!first) sb.append(", ");
    sb.append("bulletName:");
    if (this.bulletName == null) {
      sb.append("null");
    } else {
      sb.append(this.bulletName);
    }
    first = false;
    sb.append(")");
    return sb.toString();
  }

  public void validate() throws org.apache.thrift.TException {
    // check for required fields
    // check for sub-struct validity
    if (currentPosition != null) {
      currentPosition.validate();
    }
    if (fireDirection != null) {
      fireDirection.validate();
    }
  }

  private void writeObject(java.io.ObjectOutputStream out) throws java.io.IOException {
    try {
      write(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(out)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private void readObject(java.io.ObjectInputStream in) throws java.io.IOException, ClassNotFoundException {
    try {
      read(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(in)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private static class FireInfoStandardSchemeFactory implements SchemeFactory {
    public FireInfoStandardScheme getScheme() {
      return new FireInfoStandardScheme();
    }
  }

  private static class FireInfoStandardScheme extends StandardScheme<FireInfo> {

    public void read(org.apache.thrift.protocol.TProtocol iprot, FireInfo struct) throws org.apache.thrift.TException {
      org.apache.thrift.protocol.TField schemeField;
      iprot.readStructBegin();
      while (true)
      {
        schemeField = iprot.readFieldBegin();
        if (schemeField.type == org.apache.thrift.protocol.TType.STOP) { 
          break;
        }
        switch (schemeField.id) {
          case 10: // CURRENT_POSITION
            if (schemeField.type == org.apache.thrift.protocol.TType.STRUCT) {
              struct.currentPosition = new ThriftVector3();
              struct.currentPosition.read(iprot);
              struct.setCurrentPositionIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 20: // FIRE_DIRECTION
            if (schemeField.type == org.apache.thrift.protocol.TType.STRUCT) {
              struct.fireDirection = new ThriftVector3();
              struct.fireDirection.read(iprot);
              struct.setFireDirectionIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 30: // BULLET_NAME
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.bulletName = iprot.readString();
              struct.setBulletNameIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          default:
            org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
        }
        iprot.readFieldEnd();
      }
      iprot.readStructEnd();

      // check for required fields of primitive type, which can't be checked in the validate method
      struct.validate();
    }

    public void write(org.apache.thrift.protocol.TProtocol oprot, FireInfo struct) throws org.apache.thrift.TException {
      struct.validate();

      oprot.writeStructBegin(STRUCT_DESC);
      if (struct.currentPosition != null) {
        oprot.writeFieldBegin(CURRENT_POSITION_FIELD_DESC);
        struct.currentPosition.write(oprot);
        oprot.writeFieldEnd();
      }
      if (struct.fireDirection != null) {
        oprot.writeFieldBegin(FIRE_DIRECTION_FIELD_DESC);
        struct.fireDirection.write(oprot);
        oprot.writeFieldEnd();
      }
      if (struct.bulletName != null) {
        oprot.writeFieldBegin(BULLET_NAME_FIELD_DESC);
        oprot.writeString(struct.bulletName);
        oprot.writeFieldEnd();
      }
      oprot.writeFieldStop();
      oprot.writeStructEnd();
    }

  }

  private static class FireInfoTupleSchemeFactory implements SchemeFactory {
    public FireInfoTupleScheme getScheme() {
      return new FireInfoTupleScheme();
    }
  }

  private static class FireInfoTupleScheme extends TupleScheme<FireInfo> {

    @Override
    public void write(org.apache.thrift.protocol.TProtocol prot, FireInfo struct) throws org.apache.thrift.TException {
      TTupleProtocol oprot = (TTupleProtocol) prot;
      BitSet optionals = new BitSet();
      if (struct.isSetCurrentPosition()) {
        optionals.set(0);
      }
      if (struct.isSetFireDirection()) {
        optionals.set(1);
      }
      if (struct.isSetBulletName()) {
        optionals.set(2);
      }
      oprot.writeBitSet(optionals, 3);
      if (struct.isSetCurrentPosition()) {
        struct.currentPosition.write(oprot);
      }
      if (struct.isSetFireDirection()) {
        struct.fireDirection.write(oprot);
      }
      if (struct.isSetBulletName()) {
        oprot.writeString(struct.bulletName);
      }
    }

    @Override
    public void read(org.apache.thrift.protocol.TProtocol prot, FireInfo struct) throws org.apache.thrift.TException {
      TTupleProtocol iprot = (TTupleProtocol) prot;
      BitSet incoming = iprot.readBitSet(3);
      if (incoming.get(0)) {
        struct.currentPosition = new ThriftVector3();
        struct.currentPosition.read(iprot);
        struct.setCurrentPositionIsSet(true);
      }
      if (incoming.get(1)) {
        struct.fireDirection = new ThriftVector3();
        struct.fireDirection.read(iprot);
        struct.setFireDirectionIsSet(true);
      }
      if (incoming.get(2)) {
        struct.bulletName = iprot.readString();
        struct.setBulletNameIsSet(true);
      }
    }
  }

}

