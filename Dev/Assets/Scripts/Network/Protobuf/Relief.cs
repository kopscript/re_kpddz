//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Relief.proto
namespace Msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CS_CReliefRequest")]
  public partial class CS_CReliefRequest : global::ProtoBuf.IExtensible
  {
    public CS_CReliefRequest() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SC_CReliefInfoResponse")]
  public partial class SC_CReliefInfoResponse : global::ProtoBuf.IExtensible
  {
    public SC_CReliefInfoResponse() {}
    
    private int _count;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }

    private int _status = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SC_CReliefAwardResponse")]
  public partial class SC_CReliefAwardResponse : global::ProtoBuf.IExtensible
  {
    public SC_CReliefAwardResponse() {}
    
    private int _money;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"money", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int money
    {
      get { return _money; }
      set { _money = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}