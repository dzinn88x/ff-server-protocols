using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B4F RID: 2895
	[Token(Token = "0x2000B4F")]
	[ProtoContract]
	public class CupSettingDesc
	{
		// Token: 0x06002857 RID: 10327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x21B9250", Offset = "0x21B9250", VA = "0x7BBC9B9250")]
		public CupSettingDesc()
		{
		}

		// Token: 0x04003705 RID: 14085
		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DED8", Offset = "0x112DED8")]
		public uint cup_type;

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DEEC", Offset = "0x112DEEC")]
		public uint cup_id;

		// Token: 0x04003707 RID: 14087
		[Token(Token = "0x4003707")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DF00", Offset = "0x112DF00")]
		public uint game_mode;

		// Token: 0x04003708 RID: 14088
		[Token(Token = "0x4003708")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DF14", Offset = "0x112DF14")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DF14", Offset = "0x112DF14")]
		public string cup_name;

		// Token: 0x04003709 RID: 14089
		[Token(Token = "0x4003709")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112DF64", Offset = "0x112DF64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DF64", Offset = "0x112DF64")]
		public string mode_name;

		// Token: 0x0400370A RID: 14090
		[Token(Token = "0x400370A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DFB4", Offset = "0x112DFB4")]
		public bool disable_weapon_skin;

		// Token: 0x0400370B RID: 14091
		[Token(Token = "0x400370B")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DFC8", Offset = "0x112DFC8")]
		public bool is_new;

		// Token: 0x0400370C RID: 14092
		[Token(Token = "0x400370C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DFDC", Offset = "0x112DFDC")]
		public uint ticket_item_id;

		// Token: 0x0400370D RID: 14093
		[Token(Token = "0x400370D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112DFF0", Offset = "0x112DFF0")]
		public uint ticket_store_id;

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E004", Offset = "0x112E004")]
		public bool tier_inherit;
	}
}
