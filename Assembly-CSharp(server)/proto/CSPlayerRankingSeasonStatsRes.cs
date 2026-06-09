using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	[ProtoContract]
	public class CSPlayerRankingSeasonStatsRes
	{
		// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x21B6F10", Offset = "0x21B6F10", VA = "0x7BBC9B6F10")]
		public CSPlayerRankingSeasonStatsRes()
		{
		}

		// Token: 0x04002418 RID: 9240
		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BCC0", Offset = "0x110BCC0")]
		public ulong account_id;

		// Token: 0x04002419 RID: 9241
		[Token(Token = "0x4002419")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BCD4", Offset = "0x110BCD4")]
		public uint season_id;

		// Token: 0x0400241A RID: 9242
		[Token(Token = "0x400241A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BCE8", Offset = "0x110BCE8")]
		public uint games_played;

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BCFC", Offset = "0x110BCFC")]
		public uint max_rank;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD10", Offset = "0x110BD10")]
		public uint max_ranking_points;

		// Token: 0x0400241D RID: 9245
		[Token(Token = "0x400241D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD24", Offset = "0x110BD24")]
		public uint wins;

		// Token: 0x0400241E RID: 9246
		[Token(Token = "0x400241E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD38", Offset = "0x110BD38")]
		public uint top_10_percent_times;

		// Token: 0x0400241F RID: 9247
		[Token(Token = "0x400241F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD4C", Offset = "0x110BD4C")]
		public uint top_50_percent_times;

		// Token: 0x04002420 RID: 9248
		[Token(Token = "0x4002420")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD60", Offset = "0x110BD60")]
		public uint survival_time;

		// Token: 0x04002421 RID: 9249
		[Token(Token = "0x4002421")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD74", Offset = "0x110BD74")]
		public uint moving_distance;

		// Token: 0x04002422 RID: 9250
		[Token(Token = "0x4002422")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD88", Offset = "0x110BD88")]
		public uint kills;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BD9C", Offset = "0x110BD9C")]
		public uint damage;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BDB0", Offset = "0x110BDB0")]
		public uint one_game_most_kills;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BDC4", Offset = "0x110BDC4")]
		public uint one_game_most_damage;

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BDD8", Offset = "0x110BDD8")]
		public uint head_shot_kills;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BDEC", Offset = "0x110BDEC")]
		public uint revivals;
	}
}
