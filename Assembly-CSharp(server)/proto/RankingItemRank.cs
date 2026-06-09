using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA4 RID: 2724
	[Token(Token = "0x2000AA4")]
	[ProtoContract]
	public class RankingItemRank
	{
		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x249FA90", Offset = "0x249FA90", VA = "0x7BBCC9FA90")]
		public RankingItemRank()
		{
		}

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F08", Offset = "0x1125F08")]
		public uint item_id;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F1C", Offset = "0x1125F1C")]
		public uint buy_rank;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F30", Offset = "0x1125F30")]
		public uint use_rank;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125F44", Offset = "0x1125F44")]
		public RankingItemRankAffectedSeason which_season;
	}
}
