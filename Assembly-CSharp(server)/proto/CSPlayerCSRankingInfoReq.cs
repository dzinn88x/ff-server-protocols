using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200071A RID: 1818
	[Token(Token = "0x200071A")]
	[ProtoContract]
	public class CSPlayerCSRankingInfoReq
	{
		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x21B6E64", Offset = "0x21B6E64", VA = "0x7BBC9B6E64")]
		public CSPlayerCSRankingInfoReq()
		{
		}

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110BF90", Offset = "0x110BF90")]
		public uint season_id;
	}
}
