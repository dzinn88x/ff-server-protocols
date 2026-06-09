using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000711 RID: 1809
	[Token(Token = "0x2000711")]
	[ProtoContract]
	public class CSGetRankingSeasonInfoReq
	{
		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x21B5824", Offset = "0x21B5824", VA = "0x7BBC9B5824")]
		public CSGetRankingSeasonInfoReq()
		{
		}

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BE00", Offset = "0x110BE00")]
		public uint season_id;
	}
}
