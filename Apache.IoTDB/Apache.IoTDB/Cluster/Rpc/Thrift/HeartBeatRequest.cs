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


namespace Apache.IoTDB.Cluster.Rpc.Thrift
{

  public partial class HeartBeatRequest : TBase
  {
    private byte[] _partitionTableBytes;
    private Node _header;

    public long Term { get; set; }

    public long CommitLogIndex { get; set; }

    public long CommitLogTerm { get; set; }

    public Node Leader { get; set; }

    public bool RequireIdentifier { get; set; }

    public bool RegenerateIdentifier { get; set; }

    public byte[] PartitionTableBytes
    {
      get
      {
        return _partitionTableBytes;
      }
      set
      {
        __isset.partitionTableBytes = true;
        this._partitionTableBytes = value;
      }
    }

    public Node Header
    {
      get
      {
        return _header;
      }
      set
      {
        __isset.header = true;
        this._header = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool partitionTableBytes;
      public bool header;
    }

    public HeartBeatRequest()
    {
    }

    public HeartBeatRequest(long term, long commitLogIndex, long commitLogTerm, Node leader, bool requireIdentifier, bool regenerateIdentifier) : this()
    {
      this.Term = term;
      this.CommitLogIndex = commitLogIndex;
      this.CommitLogTerm = commitLogTerm;
      this.Leader = leader;
      this.RequireIdentifier = requireIdentifier;
      this.RegenerateIdentifier = regenerateIdentifier;
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_term = false;
        bool isset_commitLogIndex = false;
        bool isset_commitLogTerm = false;
        bool isset_leader = false;
        bool isset_requireIdentifier = false;
        bool isset_regenerateIdentifier = false;
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
                Term = await iprot.ReadI64Async(cancellationToken);
                isset_term = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                CommitLogIndex = await iprot.ReadI64Async(cancellationToken);
                isset_commitLogIndex = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                CommitLogTerm = await iprot.ReadI64Async(cancellationToken);
                isset_commitLogTerm = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                Leader = new Node();
                await Leader.ReadAsync(iprot, cancellationToken);
                isset_leader = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Bool)
              {
                RequireIdentifier = await iprot.ReadBoolAsync(cancellationToken);
                isset_requireIdentifier = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Bool)
              {
                RegenerateIdentifier = await iprot.ReadBoolAsync(cancellationToken);
                isset_regenerateIdentifier = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                PartitionTableBytes = await iprot.ReadBinaryAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Struct)
              {
                Header = new Node();
                await Header.ReadAsync(iprot, cancellationToken);
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
        if (!isset_term)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_commitLogIndex)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_commitLogTerm)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_leader)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_requireIdentifier)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_regenerateIdentifier)
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
        var struc = new TStruct("HeartBeatRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        field.Name = "term";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Term, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "commitLogIndex";
        field.Type = TType.I64;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(CommitLogIndex, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "commitLogTerm";
        field.Type = TType.I64;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(CommitLogTerm, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "leader";
        field.Type = TType.Struct;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await Leader.WriteAsync(oprot, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "requireIdentifier";
        field.Type = TType.Bool;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBoolAsync(RequireIdentifier, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        field.Name = "regenerateIdentifier";
        field.Type = TType.Bool;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBoolAsync(RegenerateIdentifier, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if (PartitionTableBytes != null && __isset.partitionTableBytes)
        {
          field.Name = "partitionTableBytes";
          field.Type = TType.String;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBinaryAsync(PartitionTableBytes, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Header != null && __isset.header)
        {
          field.Name = "header";
          field.Type = TType.Struct;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await Header.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
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
      var other = that as HeartBeatRequest;
      if (other == null) return false;
      if (ReferenceEquals(this, other)) return true;
      return System.Object.Equals(Term, other.Term)
        && System.Object.Equals(CommitLogIndex, other.CommitLogIndex)
        && System.Object.Equals(CommitLogTerm, other.CommitLogTerm)
        && System.Object.Equals(Leader, other.Leader)
        && System.Object.Equals(RequireIdentifier, other.RequireIdentifier)
        && System.Object.Equals(RegenerateIdentifier, other.RegenerateIdentifier)
        && ((__isset.partitionTableBytes == other.__isset.partitionTableBytes) && ((!__isset.partitionTableBytes) || (TCollections.Equals(PartitionTableBytes, other.PartitionTableBytes))))
        && ((__isset.header == other.__isset.header) && ((!__isset.header) || (System.Object.Equals(Header, other.Header))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Term.GetHashCode();
        hashcode = (hashcode * 397) + CommitLogIndex.GetHashCode();
        hashcode = (hashcode * 397) + CommitLogTerm.GetHashCode();
        hashcode = (hashcode * 397) + Leader.GetHashCode();
        hashcode = (hashcode * 397) + RequireIdentifier.GetHashCode();
        hashcode = (hashcode * 397) + RegenerateIdentifier.GetHashCode();
        if(__isset.partitionTableBytes)
          hashcode = (hashcode * 397) + PartitionTableBytes.GetHashCode();
        if(__isset.header)
          hashcode = (hashcode * 397) + Header.GetHashCode();
      }
      return hashcode;
    }

    public override string ToString()
    {
      var sb = new StringBuilder("HeartBeatRequest(");
      sb.Append(", Term: ");
      sb.Append(Term);
      sb.Append(", CommitLogIndex: ");
      sb.Append(CommitLogIndex);
      sb.Append(", CommitLogTerm: ");
      sb.Append(CommitLogTerm);
      sb.Append(", Leader: ");
      sb.Append(Leader);
      sb.Append(", RequireIdentifier: ");
      sb.Append(RequireIdentifier);
      sb.Append(", RegenerateIdentifier: ");
      sb.Append(RegenerateIdentifier);
      if (PartitionTableBytes != null && __isset.partitionTableBytes)
      {
        sb.Append(", PartitionTableBytes: ");
        sb.Append(PartitionTableBytes);
      }
      if (Header != null && __isset.header)
      {
        sb.Append(", Header: ");
        sb.Append(Header);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}