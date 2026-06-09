using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071C RID: 1820
	[Token(Token = "0x200071C")]
	[ProtoContract]
	public class CSPlayerCSRankingSeasonStatsReq
	{
		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x21B6E74", Offset = "0x21B6E74", VA = "0x7BBC9B6E74")]
		public CSPlayerCSRankingSeasonStatsReq()
		{
		}

		// Token: 0x04002443 RID: 9283
		[Token(Token = "0x4002443")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C06C", Offset = "0x110C06C")]
		public uint season_id;

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C080", Offset = "0x110C080")]
		public ulong account_id;
	}
}
