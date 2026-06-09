using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	[ProtoContract]
	public class CSPlayerCSRankingSeasonStatsRes
	{
		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x21B6E7C", Offset = "0x21B6E7C", VA = "0x7BBC9B6E7C")]
		public CSPlayerCSRankingSeasonStatsRes()
		{
		}

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C094", Offset = "0x110C094")]
		public uint season_id;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C0A8", Offset = "0x110C0A8")]
		public AccountInfoWithTCStats ranking_stats;
	}
}
