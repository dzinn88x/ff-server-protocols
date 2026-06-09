using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000722 RID: 1826
	[Token(Token = "0x2000722")]
	[ProtoContract]
	public class CSGetPlayerCSRankingInfoByAccountIDReq
	{
		// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x21B5588", Offset = "0x21B5588", VA = "0x7BBC9B5588")]
		public CSGetPlayerCSRankingInfoByAccountIDReq()
		{
		}

		// Token: 0x04002451 RID: 9297
		[Token(Token = "0x4002451")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C1AC", Offset = "0x110C1AC")]
		public ulong account_id;
	}
}
