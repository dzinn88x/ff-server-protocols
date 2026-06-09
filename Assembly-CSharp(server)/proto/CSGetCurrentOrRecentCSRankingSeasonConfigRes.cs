using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071E RID: 1822
	[Token(Token = "0x200071E")]
	[ProtoContract]
	public class CSGetCurrentOrRecentCSRankingSeasonConfigRes
	{
		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x21B2F54", Offset = "0x21B2F54", VA = "0x7BBC9B2F54")]
		public CSGetCurrentOrRecentCSRankingSeasonConfigRes()
		{
		}

		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C0BC", Offset = "0x110C0BC")]
		public CSRankingSeasonInfoDesc season_info;

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C0D0", Offset = "0x110C0D0")]
		public List<CSRankAwardsDesc> awards;
	}
}
