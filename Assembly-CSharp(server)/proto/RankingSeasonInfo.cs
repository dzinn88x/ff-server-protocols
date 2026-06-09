using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A53 RID: 2643
	[Token(Token = "0x2000A53")]
	[ProtoContract]
	public class RankingSeasonInfo
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x249FB34", Offset = "0x249FB34", VA = "0x7BBCC9FB34")]
		public RankingSeasonInfo()
		{
		}

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B5C", Offset = "0x1120B5C")]
		public uint id;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B70", Offset = "0x1120B70")]
		public long open_time;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B84", Offset = "0x1120B84")]
		public long end_time;

		// Token: 0x0400303B RID: 12347
		[Token(Token = "0x400303B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120B98", Offset = "0x1120B98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120B98", Offset = "0x1120B98")]
		public string season_name;

		// Token: 0x0400303C RID: 12348
		[Token(Token = "0x400303C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120BE8", Offset = "0x1120BE8")]
		public uint starting_ranking_points;

		// Token: 0x0400303D RID: 12349
		[Token(Token = "0x400303D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120BFC", Offset = "0x1120BFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120BFC", Offset = "0x1120BFC")]
		public string map_id;

		// Token: 0x0400303E RID: 12350
		[Token(Token = "0x400303E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120C4C", Offset = "0x1120C4C")]
		public uint season_award_id;

		// Token: 0x0400303F RID: 12351
		[Token(Token = "0x400303F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120C60", Offset = "0x1120C60")]
		public uint season_award_rank;

		// Token: 0x04003040 RID: 12352
		[Token(Token = "0x4003040")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120C74", Offset = "0x1120C74")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120C74", Offset = "0x1120C74")]
		public string season_award_url;

		// Token: 0x04003041 RID: 12353
		[Token(Token = "0x4003041")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120CC4", Offset = "0x1120CC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1120CC4", Offset = "0x1120CC4")]
		public string season_bg_url;

		// Token: 0x04003042 RID: 12354
		[Token(Token = "0x4003042")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D14", Offset = "0x1120D14")]
		public uint season_peak_award_id;

		// Token: 0x04003043 RID: 12355
		[Token(Token = "0x4003043")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D28", Offset = "0x1120D28")]
		public uint season_peak_award_rank;

		// Token: 0x04003044 RID: 12356
		[Token(Token = "0x4003044")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1120D3C", Offset = "0x1120D3C")]
		public bool heroic_mark_switch;
	}
}
