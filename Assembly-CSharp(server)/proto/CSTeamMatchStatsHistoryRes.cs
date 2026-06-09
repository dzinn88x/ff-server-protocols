using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000925 RID: 2341
	[Token(Token = "0x2000925")]
	[ProtoContract]
	public class CSTeamMatchStatsHistoryRes
	{
		// Token: 0x06002633 RID: 9779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x21B79AC", Offset = "0x21B79AC", VA = "0x7BBC9B79AC")]
		public CSTeamMatchStatsHistoryRes()
		{
		}

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11188D0", Offset = "0x11188D0")]
		public List<TeamChampionshipMatchStats> match_stats;
	}
}
