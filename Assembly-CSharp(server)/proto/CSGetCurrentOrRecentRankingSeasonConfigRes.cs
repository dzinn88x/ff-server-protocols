using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000715 RID: 1813
	[Token(Token = "0x2000715")]
	[ProtoContract]
	public class CSGetCurrentOrRecentRankingSeasonConfigRes
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x21B2FC8", Offset = "0x21B2FC8", VA = "0x7BBC9B2FC8")]
		public CSGetCurrentOrRecentRankingSeasonConfigRes()
		{
		}

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE64", Offset = "0x110BE64")]
		public RankingSeasonInfo season_info;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE78", Offset = "0x110BE78")]
		public List<RankAwardsDesc> awards;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE8C", Offset = "0x110BE8C")]
		public RankAwardsDesc top_awards;
	}
}
