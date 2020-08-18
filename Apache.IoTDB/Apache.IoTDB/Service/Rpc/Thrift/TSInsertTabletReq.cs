/**
 * Autogenerated by Thrift Compiler (0.13.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


namespace Apache.IoTDB.Service.Rpc.Thrift
{

  public partial class TSInsertTabletReq : TBase
  {

    public long SessionId { get; set; }

    public string DeviceId { get; set; }

    public List<string> Measurements { get; set; }

    public byte[] Values { get; set; }

    public byte[] Timestamps { get; set; }

    public List<int> Types { get; set; }

    public int Size { get; set; }

    public TSInsertTabletReq()
    {
    }

    public TSInsertTabletReq(long sessionId, string deviceId, List<string> measurements, byte[] values, byte[] timestamps, List<int> types, int size) : this()
    {
      this.SessionId = sessionId;
      this.DeviceId = deviceId;
      this.Measurements = measurements;
      this.Values = values;
      this.Timestamps = timestamps;
      this.Types = types;
      this.Size = size;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_sessionId = false;
        bool isset_deviceId = false;
        bool isset_measurements = false;
        bool isset_values = false;
        bool isset_timestamps = false;
        bool isset_types = false;
        bool isset_size = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I64)
              {
                SessionId = await iprot.ReadI64Async(cancellationToken);
                isset_sessionId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                DeviceId = await iprot.ReadStringAsync(cancellationToken);
                isset_deviceId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.List)
              {
                {
                  TList _list47 = await iprot.ReadListBeginAsync(cancellationToken);
                  Measurements = new List<string>(_list47.Count);
                  for(int _i48 = 0; _i48 < _list47.Count; ++_i48)
                  {
                    string _elem49;
                    _elem49 = await iprot.ReadStringAsync(cancellationToken);
                    Measurements.Add(_elem49);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_measurements = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Values = await iprot.ReadBinaryAsync(cancellationToken);
                isset_values = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Timestamps = await iprot.ReadBinaryAsync(cancellationToken);
                isset_timestamps = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.List)
              {
                {
                  TList _list50 = await iprot.ReadListBeginAsync(cancellationToken);
                  Types = new List<int>(_list50.Count);
                  for(int _i51 = 0; _i51 < _list50.Count; ++_i51)
                  {
                    int _elem52;
                    _elem52 = await iprot.ReadI32Async(cancellationToken);
                    Types.Add(_elem52);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
                isset_types = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Size = await iprot.ReadI32Async(cancellationToken);
                isset_size = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_sessionId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_deviceId)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_measurements)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_values)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_timestamps)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_types)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_size)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("TSInsertTabletReq");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "sessionId";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(SessionId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "deviceId";
        field.Type = TType.String;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(DeviceId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "measurements";
        field.Type = TType.List;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.String, Measurements.Count), cancellationToken);
          foreach (string _iter53 in Measurements)
          {
            await oprot.WriteStringAsync(_iter53, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "values";
        field.Type = TType.String;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(Values, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "timestamps";
        field.Type = TType.String;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(Timestamps, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "types";
        field.Type = TType.List;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        {
          await oprot.WriteListBeginAsync(new TList(TType.I32, Types.Count), cancellationToken);
          foreach (int _iter54 in Types)
          {
            await oprot.WriteI32Async(_iter54, cancellationToken);
          }
          await oprot.WriteListEndAsync(cancellationToken);
        }
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "size";
        field.Type = TType.I32;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Size, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      var other = that as TSInsertTabletReq;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(SessionId, other.SessionId)
        && System.Object.Equals(DeviceId, other.DeviceId)
        && TCollections.Equals(Measurements, other.Measurements)
        && TCollections.Equals(Values, other.Values)
        && TCollections.Equals(Timestamps, other.Timestamps)
        && TCollections.Equals(Types, other.Types)
        && System.Object.Equals(Size, other.Size);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + SessionId.GetHashCode();
        hashcode = (hashcode * 397) + DeviceId.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Measurements);
        hashcode = (hashcode * 397) + Values.GetHashCode();
        hashcode = (hashcode * 397) + Timestamps.GetHashCode();
        hashcode = (hashcode * 397) + TCollections.GetHashCode(Types);
        hashcode = (hashcode * 397) + Size.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("TSInsertTabletReq(");
      sb.Append(", SessionId: ");
      sb.Append(SessionId);
      sb.Append(", DeviceId: ");
      sb.Append(DeviceId);
      sb.Append(", Measurements: ");
      sb.Append(Measurements);
      sb.Append(", Values: ");
      sb.Append(Values);
      sb.Append(", Timestamps: ");
      sb.Append(Timestamps);
      sb.Append(", Types: ");
      sb.Append(Types);
      sb.Append(", Size: ");
      sb.Append(Size);
      sb.Append(")");
      return sb.ToString();
    }
  }

}