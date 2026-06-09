using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	[ProtoContract]
	public enum RankingItemRankAffectedSeason
	{
		// Token: 0x04003748 RID: 14152
		[Token(Token = "0x4003748")]
		INVALID,
		// Token: 0x04003749 RID: 14153
		[Token(Token = "0x4003749")]
		CUR_SEASON,
		// Token: 0x0400374A RID: 14154
		[Token(Token = "0x400374A")]
		LAST_OR_CUR_SEASON
	}
}
