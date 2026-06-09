using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000964 RID: 2404
	[Token(Token = "0x2000964")]
	[ProtoContract]
	public class CSGetCollectTokenInfoRes
	{
		// Token: 0x06002672 RID: 9842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x21B2D24", Offset = "0x21B2D24", VA = "0x7BBC9B2D24")]
		public CSGetCollectTokenInfoRes()
		{
		}

		// Token: 0x04002BEB RID: 11243
		[Token(Token = "0x4002BEB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119564", Offset = "0x1119564")]
		public List<LdcpTokenDesc> desc;

		// Token: 0x04002BEC RID: 11244
		[Token(Token = "0x4002BEC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119578", Offset = "0x1119578")]
		public uint collected_tokens;
	}
}
