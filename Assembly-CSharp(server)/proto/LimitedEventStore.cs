using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000954 RID: 2388
	[Token(Token = "0x2000954")]
	[ProtoContract]
	public class LimitedEventStore
	{
		// Token: 0x06002662 RID: 9826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x21BBAA0", Offset = "0x21BBAA0", VA = "0x7BBC9BBAA0")]
		public LimitedEventStore()
		{
		}

		// Token: 0x04002BCB RID: 11211
		[Token(Token = "0x4002BCB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11192E4", Offset = "0x11192E4")]
		public BigEventStoreDesc store_desc;

		// Token: 0x04002BCC RID: 11212
		[Token(Token = "0x4002BCC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11192F8", Offset = "0x11192F8")]
		public List<BigEventStoreCommodityDesc> store_commodities;
	}
}
