using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A16 RID: 2582
	[Token(Token = "0x2000A16")]
	[ProtoContract]
	public class RoomCreateRuleDropDesc
	{
		// Token: 0x06002720 RID: 10016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x24A02E8", Offset = "0x24A02E8", VA = "0x7BBCCA02E8")]
		public RoomCreateRuleDropDesc()
		{
		}

		// Token: 0x04002F1E RID: 12062
		[Token(Token = "0x4002F1E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E9D8", Offset = "0x111E9D8")]
		public uint id;

		// Token: 0x04002F1F RID: 12063
		[Token(Token = "0x4002F1F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E9EC", Offset = "0x111E9EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111E9EC", Offset = "0x111E9EC")]
		public string suffix;

		// Token: 0x04002F20 RID: 12064
		[Token(Token = "0x4002F20")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EA3C", Offset = "0x111EA3C")]
		public uint room_type;

		// Token: 0x04002F21 RID: 12065
		[Token(Token = "0x4002F21")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EA50", Offset = "0x111EA50")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111EA50", Offset = "0x111EA50")]
		public string loc_key;

		// Token: 0x04002F22 RID: 12066
		[Token(Token = "0x4002F22")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EAA0", Offset = "0x111EAA0")]
		public ERoom.WeatherType weather;

		// Token: 0x04002F23 RID: 12067
		[Token(Token = "0x4002F23")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EAB4", Offset = "0x111EAB4")]
		public ERoom.DropPresetState unlimited_ammo_switch;

		// Token: 0x04002F24 RID: 12068
		[Token(Token = "0x4002F24")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EAC8", Offset = "0x111EAC8")]
		public ERoom.DropPresetState skill_switch;

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EADC", Offset = "0x111EADC")]
		public ERoom.DropPresetState air_drop_switch;

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EAF0", Offset = "0x111EAF0")]
		public ERoom.DropPresetState fall_down_switch;

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB04", Offset = "0x111EB04")]
		public ERoom.DropPresetState loadout_switch;

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB18", Offset = "0x111EB18")]
		public ERoom.DropPresetState car_drop_switch;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB2C", Offset = "0x111EB2C")]
		public uint drop_type;

		// Token: 0x04002F2A RID: 12074
		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111EB40", Offset = "0x111EB40")]
		public ERoom.DropPresetState air_ship_switch;
	}
}
