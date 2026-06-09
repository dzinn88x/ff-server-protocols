using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB8 RID: 2744
	[Token(Token = "0x2000AB8")]
	[ProtoContract]
	public class RelationTypeInfoDesc
	{
		// Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x24A006C", Offset = "0x24A006C", VA = "0x7BBCCA006C")]
		public RelationTypeInfoDesc()
		{
		}

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F84", Offset = "0x1126F84")]
		public uint idx;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126F98", Offset = "0x1126F98")]
		public EFriend.RelationType relation_type;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126FAC", Offset = "0x1126FAC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126FAC", Offset = "0x1126FAC")]
		public string relation_name;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126FFC", Offset = "0x1126FFC")]
		public uint relation_item_id;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127010", Offset = "0x1127010")]
		public uint reject_countdown;

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127024", Offset = "0x1127024")]
		public uint relation_break_up_cd;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127038", Offset = "0x1127038")]
		public uint relation_break_up_countdown;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112704C", Offset = "0x112704C")]
		public uint chat_intimacy_value;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127060", Offset = "0x1127060")]
		public float item_intimacy_diamond_rate;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127074", Offset = "0x1127074")]
		public float item_intimacy_coin_rate;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127088", Offset = "0x1127088")]
		public uint intimacy_week_max;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112709C", Offset = "0x112709C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112709C", Offset = "0x112709C")]
		public string relation_broken_badge_icon;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11270EC", Offset = "0x11270EC")]
		public uint relation_friend_max;
	}
}
