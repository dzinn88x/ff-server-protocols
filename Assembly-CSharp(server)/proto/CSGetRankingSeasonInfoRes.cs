using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000720 RID: 1824
	[Token(Token = "0x2000720")]
	[ProtoContract]
	public class CSGetRankingSeasonInfoRes
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242D")]
		[Address(RVA = "0x21B582C", Offset = "0x21B582C", VA = "0x7BBC9B582C")]
		public CSGetRankingSeasonInfoRes()
		{
		}

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C134", Offset = "0x110C134")]
		public RankingSeasonInfo season_info;
	}
}
