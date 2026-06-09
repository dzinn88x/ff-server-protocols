using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	[ProtoContract]
	public class CSGetExchangeCurrencyAllDescRes
	{
		// Token: 0x060024A8 RID: 9384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024A8")]
		[Address(RVA = "0x21B32F4", Offset = "0x21B32F4", VA = "0x7BBC9B32F4")]
		public CSGetExchangeCurrencyAllDescRes()
		{
		}

		// Token: 0x040025A9 RID: 9641
		[Token(Token = "0x40025A9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E4AC", Offset = "0x110E4AC")]
		public List<ExchangeCurrencyDesc> exchange_currency_desc;
	}
}
