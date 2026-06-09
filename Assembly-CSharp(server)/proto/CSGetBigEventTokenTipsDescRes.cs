using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009AE RID: 2478
	[Token(Token = "0x20009AE")]
	[ProtoContract]
	public class CSGetBigEventTokenTipsDescRes
	{
		// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x21B25C8", Offset = "0x21B25C8", VA = "0x7BBC9B25C8")]
		public CSGetBigEventTokenTipsDescRes()
		{
		}

		// Token: 0x04002C9E RID: 11422
		[Token(Token = "0x4002C9E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A5A4", Offset = "0x111A5A4")]
		public List<BigEventTokenTipsDesc> descs;
	}
}
