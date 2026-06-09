using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	[ProtoContract]
	public class RankingLevelLimitDescList
	{
		// Token: 0x06002715 RID: 10005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x249FAA0", Offset = "0x249FAA0", VA = "0x7BBCC9FAA0")]
		public RankingLevelLimitDescList()
		{
		}

		// Token: 0x04002EF5 RID: 12021
		[Token(Token = "0x4002EF5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111E5DC", Offset = "0x111E5DC")]
		public List<RankingLevelLimitDesc> ranking_level_limits;
	}
}
