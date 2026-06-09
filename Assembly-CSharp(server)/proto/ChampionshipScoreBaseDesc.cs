using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AE3 RID: 2787
	[Token(Token = "0x2000AE3")]
	[ProtoContract]
	public class ChampionshipScoreBaseDesc
	{
		// Token: 0x060027EB RID: 10219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027EB")]
		[Address(RVA = "0x21B810C", Offset = "0x21B810C", VA = "0x7BBC9B810C")]
		public ChampionshipScoreBaseDesc()
		{
		}

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11289D8", Offset = "0x11289D8")]
		public uint championship_type;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11289EC", Offset = "0x11289EC")]
		public uint first_ranking_point;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A00", Offset = "0x1128A00")]
		public uint knock_down_points;

		// Token: 0x04003480 RID: 13440
		[Token(Token = "0x4003480")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A14", Offset = "0x1128A14")]
		public uint revive_points;

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A28", Offset = "0x1128A28")]
		public uint damage_per_get;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A3C", Offset = "0x1128A3C")]
		public uint damage_score;

		// Token: 0x04003483 RID: 13443
		[Token(Token = "0x4003483")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A50", Offset = "0x1128A50")]
		public uint alive_per_get;

		// Token: 0x04003484 RID: 13444
		[Token(Token = "0x4003484")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A64", Offset = "0x1128A64")]
		public uint alive_score;

		// Token: 0x04003485 RID: 13445
		[Token(Token = "0x4003485")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A78", Offset = "0x1128A78")]
		public float ranking_extra_coins;

		// Token: 0x04003486 RID: 13446
		[Token(Token = "0x4003486")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128A8C", Offset = "0x1128A8C")]
		public float ranking_extra_exps;

		// Token: 0x04003487 RID: 13447
		[Token(Token = "0x4003487")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128AA0", Offset = "0x1128AA0")]
		public int birth_island_quit_deduct;

		// Token: 0x04003488 RID: 13448
		[Token(Token = "0x4003488")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128AB4", Offset = "0x1128AB4")]
		public uint kill_points;

		// Token: 0x04003489 RID: 13449
		[Token(Token = "0x4003489")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128AC8", Offset = "0x1128AC8")]
		public uint game_mode;
	}
}
