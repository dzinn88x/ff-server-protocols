using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	[ProtoContract]
	public class CSGetRecommendedVideoListReq
	{
		// Token: 0x060025E9 RID: 9705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E9")]
		[Address(RVA = "0x21B59B8", Offset = "0x21B59B8", VA = "0x7BBC9B59B8")]
		public CSGetRecommendedVideoListReq()
		{
		}

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116FF8", Offset = "0x1116FF8")]
		public uint page_id;
	}
}
