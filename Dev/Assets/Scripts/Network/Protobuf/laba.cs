//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: laba.proto
namespace network
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"cs_laba_enter_room_req")]
  public partial class cs_laba_enter_room_req : global::ProtoBuf.IExtensible
  {
    public cs_laba_enter_room_req() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sc_laba_enter_room_reply")]
  public partial class sc_laba_enter_room_reply : global::ProtoBuf.IExtensible
  {
    public sc_laba_enter_room_reply() {}
    
    private uint _line_num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"line_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint line_num
    {
      get { return _line_num; }
      set { _line_num = value; }
    }
    private uint _line_set_chips;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"line_set_chips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint line_set_chips
    {
      get { return _line_set_chips; }
      set { _line_set_chips = value; }
    }
    private uint _last_free_times;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"last_free_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_free_times
    {
      get { return _last_free_times; }
      set { _last_free_times = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"cs_laba_leave_room_req")]
  public partial class cs_laba_leave_room_req : global::ProtoBuf.IExtensible
  {
    public cs_laba_leave_room_req() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sc_laba_leave_room_reply")]
  public partial class sc_laba_leave_room_reply : global::ProtoBuf.IExtensible
  {
    public sc_laba_leave_room_reply() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sc_laba_pool_num_update")]
  public partial class sc_laba_pool_num_update : global::ProtoBuf.IExtensible
  {
    public sc_laba_pool_num_update() {}
    
    private string _total_pool_num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"total_pool_num", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string total_pool_num
    {
      get { return _total_pool_num; }
      set { _total_pool_num = value; }
    }

    private network.pb_pool_win_player_info _win_player = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"win_player", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public network.pb_pool_win_player_info win_player
    {
      get { return _win_player; }
      set { _win_player = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pb_pool_win_player_info")]
  public partial class pb_pool_win_player_info : global::ProtoBuf.IExtensible
  {
    public pb_pool_win_player_info() {}
    
    private string _player_uuid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_uuid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_uuid
    {
      get { return _player_uuid; }
      set { _player_uuid = value; }
    }

    private string _icon_url = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"icon_url", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon_url
    {
      get { return _icon_url; }
      set { _icon_url = value; }
    }

    private byte[] _player_name = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] player_name
    {
      get { return _player_name; }
      set { _player_name = value; }
    }
    private uint _vip_level;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"vip_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint vip_level
    {
      get { return _vip_level; }
      set { _vip_level = value; }
    }

    private string _win_gold = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"win_gold", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string win_gold
    {
      get { return _win_gold; }
      set { _win_gold = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"cs_laba_spin_req")]
  public partial class cs_laba_spin_req : global::ProtoBuf.IExtensible
  {
    public cs_laba_spin_req() {}
    
    private uint _line_num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"line_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint line_num
    {
      get { return _line_num; }
      set { _line_num = value; }
    }
    private uint _line_set_chips;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"line_set_chips", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint line_set_chips
    {
      get { return _line_set_chips; }
      set { _line_set_chips = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"sc_laba_spin_reply")]
  public partial class sc_laba_spin_reply : global::ProtoBuf.IExtensible
  {
    public sc_laba_spin_reply() {}
    
    private string _total_reward_num;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"total_reward_num", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string total_reward_num
    {
      get { return _total_reward_num; }
      set { _total_reward_num = value; }
    }
    private readonly global::System.Collections.Generic.List<network.pb_laba_fruit_info> _fruit_list = new global::System.Collections.Generic.List<network.pb_laba_fruit_info>();
    [global::ProtoBuf.ProtoMember(2, Name=@"fruit_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<network.pb_laba_fruit_info> fruit_list
    {
      get { return _fruit_list; }
    }
  
    private readonly global::System.Collections.Generic.List<network.pb_laba_line_reward> _reward_list = new global::System.Collections.Generic.List<network.pb_laba_line_reward>();
    [global::ProtoBuf.ProtoMember(3, Name=@"reward_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<network.pb_laba_line_reward> reward_list
    {
      get { return _reward_list; }
    }
  
    private uint _new_last_free_times;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"new_last_free_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint new_last_free_times
    {
      get { return _new_last_free_times; }
      set { _new_last_free_times = value; }
    }
    private uint _pool;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"pool", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint pool
    {
      get { return _pool; }
      set { _pool = value; }
    }
    private uint _free;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"free", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint free
    {
      get { return _free; }
      set { _free = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pb_laba_fruit_info")]
  public partial class pb_laba_fruit_info : global::ProtoBuf.IExtensible
  {
    public pb_laba_fruit_info() {}
    
    private uint _pos_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"pos_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint pos_id
    {
      get { return _pos_id; }
      set { _pos_id = value; }
    }
    private uint _fruit_type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"fruit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint fruit_type
    {
      get { return _fruit_type; }
      set { _fruit_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"pb_laba_line_reward")]
  public partial class pb_laba_line_reward : global::ProtoBuf.IExtensible
  {
    public pb_laba_line_reward() {}
    
    private uint _line_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"line_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint line_id
    {
      get { return _line_id; }
      set { _line_id = value; }
    }
    private uint _same_num;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"same_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint same_num
    {
      get { return _same_num; }
      set { _same_num = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}