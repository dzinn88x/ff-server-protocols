using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	[ProtoContract]
	public class CSGetExchangeStoreRes
	{
		// Token: 0x060025B9 RID: 9657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B9")]
		[Address(RVA = "0x21B33C4", Offset = "0x21B33C4", VA = "0x7BBC9B33C4")]
		public CSGetExchangeStoreRes()
		{
		}

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115EF0", Offset = "0x1115EF0")]
		public List<ExchangeStore> exchangeStores;
	}
}
