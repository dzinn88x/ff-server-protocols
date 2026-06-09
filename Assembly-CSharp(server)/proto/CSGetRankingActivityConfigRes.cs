using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000717 RID: 1815
	[Token(Token = "0x2000717")]
	[ProtoContract]
	public class CSGetRankingActivityConfigRes
	{
		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x21B57B0", Offset = "0x21B57B0", VA = "0x7BBC9B57B0")]
		public CSGetRankingActivityConfigRes()
		{
		}

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BEB4", Offset = "0x110BEB4")]
		public List<RankingActivityConfig> ranking_activity_configs;
	}
}
