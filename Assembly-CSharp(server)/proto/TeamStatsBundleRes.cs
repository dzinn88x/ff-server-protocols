using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000920 RID: 2336
	[Token(Token = "0x2000920")]
	[ProtoContract]
	public class TeamStatsBundleRes
	{
		// Token: 0x0600262E RID: 9774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600262E")]
		[Address(RVA = "0x24A0F74", Offset = "0x24A0F74", VA = "0x7BBCCA0F74")]
		public TeamStatsBundleRes()
		{
		}

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118790", Offset = "0x1118790")]
		public List<CSTeamChampionshipSeasonStatsRes> statses;
	}
}
