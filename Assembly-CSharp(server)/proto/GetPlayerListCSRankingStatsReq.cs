using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000721 RID: 1825
	[Token(Token = "0x2000721")]
	[ProtoContract]
	public class GetPlayerListCSRankingStatsReq
	{
		// Token: 0x0600242E RID: 9262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x21BAAE4", Offset = "0x21BAAE4", VA = "0x7BBC9BAAE4")]
		public GetPlayerListCSRankingStatsReq()
		{
		}

		// Token: 0x0400244E RID: 9294
		[Token(Token = "0x400244E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C148", Offset = "0x110C148")]
		public ulong[] account_ids;

		// Token: 0x0400244F RID: 9295
		[Token(Token = "0x400244F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C184", Offset = "0x110C184")]
		public uint season_id;

		// Token: 0x04002450 RID: 9296
		[Token(Token = "0x4002450")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C198", Offset = "0x110C198")]
		public uint game_mode;
	}
}
