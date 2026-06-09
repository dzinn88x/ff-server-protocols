using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B05 RID: 2821
	[Token(Token = "0x2000B05")]
	[ProtoContract]
	public class CSRankDesc
	{
		// Token: 0x0600280D RID: 10253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x21B70AC", Offset = "0x21B70AC", VA = "0x7BBC9B70AC")]
		public CSRankDesc()
		{
		}

		// Token: 0x04003537 RID: 13623
		[Token(Token = "0x4003537")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A274", Offset = "0x112A274")]
		public uint rank;

		// Token: 0x04003538 RID: 13624
		[Token(Token = "0x4003538")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A288", Offset = "0x112A288")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A288", Offset = "0x112A288")]
		public string rank_desc;

		// Token: 0x04003539 RID: 13625
		[Token(Token = "0x4003539")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112A2D8", Offset = "0x112A2D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A2D8", Offset = "0x112A2D8")]
		public string rank_name;

		// Token: 0x0400353A RID: 13626
		[Token(Token = "0x400353A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A328", Offset = "0x112A328")]
		public uint rank_up_star;

		// Token: 0x0400353B RID: 13627
		[Token(Token = "0x400353B")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A33C", Offset = "0x112A33C")]
		public uint lower_bound;

		// Token: 0x0400353C RID: 13628
		[Token(Token = "0x400353C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A350", Offset = "0x112A350")]
		public uint upper_bound;

		// Token: 0x0400353D RID: 13629
		[Token(Token = "0x400353D")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A364", Offset = "0x112A364")]
		public bool is_streak_bonus;

		// Token: 0x0400353E RID: 13630
		[Token(Token = "0x400353E")]
		[FieldOffset(Offset = "0x35")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A378", Offset = "0x112A378")]
		public bool is_rank_protect;

		// Token: 0x0400353F RID: 13631
		[Token(Token = "0x400353F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A38C", Offset = "0x112A38C")]
		public uint achieve_protection_score;

		// Token: 0x04003540 RID: 13632
		[Token(Token = "0x4003540")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A3A0", Offset = "0x112A3A0")]
		public bool heroic_mark_switch;
	}
}
