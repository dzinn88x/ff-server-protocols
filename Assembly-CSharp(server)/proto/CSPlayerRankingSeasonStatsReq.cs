using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200070F RID: 1807
	[Token(Token = "0x200070F")]
	[ProtoContract]
	public class CSPlayerRankingSeasonStatsReq
	{
		// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x21B6F08", Offset = "0x21B6F08", VA = "0x7BBC9B6F08")]
		public CSPlayerRankingSeasonStatsReq()
		{
		}

		// Token: 0x04002417 RID: 9239
		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BCAC", Offset = "0x110BCAC")]
		public uint season_id;
	}
}
