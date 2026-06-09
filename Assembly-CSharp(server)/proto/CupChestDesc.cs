using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B54 RID: 2900
	[Token(Token = "0x2000B54")]
	[ProtoContract]
	public class CupChestDesc
	{
		// Token: 0x0600285C RID: 10332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x21B917C", Offset = "0x21B917C", VA = "0x7BBC9B917C")]
		public CupChestDesc()
		{
		}

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E590", Offset = "0x112E590")]
		public uint cup_type;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E5A4", Offset = "0x112E5A4")]
		public uint cup_id;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E5B8", Offset = "0x112E5B8")]
		public uint chest_id;

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E5CC", Offset = "0x112E5CC")]
		public uint ticket_item_id;

		// Token: 0x0400373B RID: 14139
		[Token(Token = "0x400373B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E5E0", Offset = "0x112E5E0")]
		public uint[] chest_tier;

		// Token: 0x0400373C RID: 14140
		[Token(Token = "0x400373C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E61C", Offset = "0x112E61C")]
		public uint chest_unlock_wins;

		// Token: 0x0400373D RID: 14141
		[Token(Token = "0x400373D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E630", Offset = "0x112E630")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E630", Offset = "0x112E630")]
		public string chest_res;

		// Token: 0x0400373E RID: 14142
		[Token(Token = "0x400373E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E680", Offset = "0x112E680")]
		public uint chest_treasure_id;

		// Token: 0x0400373F RID: 14143
		[Token(Token = "0x400373F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112E694", Offset = "0x112E694")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112E694", Offset = "0x112E694")]
		public string chest_name;
	}
}
