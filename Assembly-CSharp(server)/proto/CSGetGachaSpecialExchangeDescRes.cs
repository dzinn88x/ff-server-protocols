using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000869 RID: 2153
	[Token(Token = "0x2000869")]
	[ProtoContract]
	public class CSGetGachaSpecialExchangeDescRes
	{
		// Token: 0x06002577 RID: 9591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002577")]
		[Address(RVA = "0x21B3E64", Offset = "0x21B3E64", VA = "0x7BBC9B3E64")]
		public CSGetGachaSpecialExchangeDescRes()
		{
		}

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11128F4", Offset = "0x11128F4")]
		public List<ChestSpecialExchangeDesc> chest_special_exchange_descs;
	}
}
