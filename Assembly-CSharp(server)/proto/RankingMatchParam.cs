using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A56 RID: 2646
	[Token(Token = "0x2000A56")]
	[ProtoContract]
	public class RankingMatchParam
	{
		// Token: 0x06002760 RID: 10080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x249FB14", Offset = "0x249FB14", VA = "0x7BBCC9FB14")]
		public RankingMatchParam()
		{
		}

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120DF0", Offset = "0x1120DF0")]
		public int solo_chicken_points;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E04", Offset = "0x1120E04")]
		public int dual_chicken_points;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E18", Offset = "0x1120E18")]
		public int squad_chicken_points;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E2C", Offset = "0x1120E2C")]
		public int limit_death_points;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E40", Offset = "0x1120E40")]
		public int gap_death_points;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E54", Offset = "0x1120E54")]
		public int knockdown_points;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E68", Offset = "0x1120E68")]
		public int revive_points;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E7C", Offset = "0x1120E7C")]
		public uint solo_battle_score_limit;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120E90", Offset = "0x1120E90")]
		public uint solo_kill_add;

		// Token: 0x04003056 RID: 12374
		[Token(Token = "0x4003056")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120EA4", Offset = "0x1120EA4")]
		public uint solo_kill_multi;

		// Token: 0x04003057 RID: 12375
		[Token(Token = "0x4003057")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120EB8", Offset = "0x1120EB8")]
		public uint group_battle_score_limit;

		// Token: 0x04003058 RID: 12376
		[Token(Token = "0x4003058")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120ECC", Offset = "0x1120ECC")]
		public uint group_kill_add;

		// Token: 0x04003059 RID: 12377
		[Token(Token = "0x4003059")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120EE0", Offset = "0x1120EE0")]
		public uint group_kill_multi;

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120EF4", Offset = "0x1120EF4")]
		public uint damage_per_score;

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F08", Offset = "0x1120F08")]
		public int down_points;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F1C", Offset = "0x1120F1C")]
		public int fratricide_points;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F30", Offset = "0x1120F30")]
		public uint first_win_rank;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F44", Offset = "0x1120F44")]
		public uint first_win_kill;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F58", Offset = "0x1120F58")]
		public uint ranking_token_id;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F6C", Offset = "0x1120F6C")]
		public uint most_token_given;

		// Token: 0x04003061 RID: 12385
		[Token(Token = "0x4003061")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F80", Offset = "0x1120F80")]
		public float ranking_extra_coins;

		// Token: 0x04003062 RID: 12386
		[Token(Token = "0x4003062")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120F94", Offset = "0x1120F94")]
		public float ranking_extra_exp;

		// Token: 0x04003063 RID: 12387
		[Token(Token = "0x4003063")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120FA8", Offset = "0x1120FA8")]
		public int birth_island_quit_deduct;

		// Token: 0x04003064 RID: 12388
		[Token(Token = "0x4003064")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120FBC", Offset = "0x1120FBC")]
		public float one_map_rp;

		// Token: 0x04003065 RID: 12389
		[Token(Token = "0x4003065")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120FD0", Offset = "0x1120FD0")]
		public float two_map_rp;

		// Token: 0x04003066 RID: 12390
		[Token(Token = "0x4003066")]
		[FieldOffset(Offset = "0x74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120FE4", Offset = "0x1120FE4")]
		public float three_map_rp;

		// Token: 0x04003067 RID: 12391
		[Token(Token = "0x4003067")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120FF8", Offset = "0x1120FF8")]
		public uint bot_point_lower;

		// Token: 0x04003068 RID: 12392
		[Token(Token = "0x4003068")]
		[FieldOffset(Offset = "0x7C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112100C", Offset = "0x112100C")]
		public uint bot_point_upper;
	}
}
