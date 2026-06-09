using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000767 RID: 1895
	[Token(Token = "0x2000767")]
	[ProtoContract]
	public class CSGetStoreRes
	{
		// Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x21B5C1C", Offset = "0x21B5C1C", VA = "0x7BBC9B5C1C")]
		public CSGetStoreRes()
		{
		}

		// Token: 0x04002520 RID: 9504
		[Token(Token = "0x4002520")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D73C", Offset = "0x110D73C")]
		public List<StoreDesc> store_items;
	}
}
