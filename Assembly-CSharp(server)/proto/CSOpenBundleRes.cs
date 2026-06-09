using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	[ProtoContract]
	public class CSOpenBundleRes
	{
		// Token: 0x06002485 RID: 9349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x21B6C30", Offset = "0x21B6C30", VA = "0x7BBC9B6C30")]
		public CSOpenBundleRes()
		{
		}

		// Token: 0x04002544 RID: 9540
		[Token(Token = "0x4002544")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DAAC", Offset = "0x110DAAC")]
		public ExchangeChangeData data;

		// Token: 0x04002545 RID: 9541
		[Token(Token = "0x4002545")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DAC0", Offset = "0x110DAC0")]
		public List<AwardDesc> transfer_to_items;
	}
}
