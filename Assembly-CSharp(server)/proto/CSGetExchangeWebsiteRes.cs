using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C9 RID: 2249
	[Token(Token = "0x20008C9")]
	[ProtoContract]
	public class CSGetExchangeWebsiteRes
	{
		// Token: 0x060025D7 RID: 9687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D7")]
		[Address(RVA = "0x21B3438", Offset = "0x21B3438", VA = "0x7BBC9B3438")]
		public CSGetExchangeWebsiteRes()
		{
		}

		// Token: 0x04002A34 RID: 10804
		[Token(Token = "0x4002A34")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116940", Offset = "0x1116940")]
		public List<ExchangeWebsiteDesc> exchange_website;
	}
}
