using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D1A RID: 7450
	[Token(Token = "0x2001D1A")]
	public class GachaSpDescData
	{
		// Token: 0x0600A21F RID: 41503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A21F")]
		[Address(RVA = "0x186B6A4", Offset = "0x186B6A4", VA = "0x7BBC06B6A4")]
		public void ComposeSpDesc(ChestSpecialExchangeDesc exchangeDesc)
		{
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A220")]
		[Address(RVA = "0x186B72C", Offset = "0x186B72C", VA = "0x7BBC06B72C")]
		public GachaSpDescData()
		{
		}

		// Token: 0x0400A893 RID: 43155
		[Token(Token = "0x400A893")]
		[FieldOffset(Offset = "0x10")]
		public uint GachaID;

		// Token: 0x0400A894 RID: 43156
		[Token(Token = "0x400A894")]
		[FieldOffset(Offset = "0x18")]
		public List<ChestSpecialExchangeDesc> GachaSpDescList;
	}
}
