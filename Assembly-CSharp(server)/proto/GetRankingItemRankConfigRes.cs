using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	[ProtoContract]
	public class GetRankingItemRankConfigRes
	{
		// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x21BAAF4", Offset = "0x21BAAF4", VA = "0x7BBC9BAAF4")]
		public GetRankingItemRankConfigRes()
		{
		}

		// Token: 0x04002586 RID: 9606
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E128", Offset = "0x110E128")]
		public List<RankingItemRank> items;
	}
}
