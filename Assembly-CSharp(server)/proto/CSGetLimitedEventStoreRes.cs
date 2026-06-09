using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000953 RID: 2387
	[Token(Token = "0x2000953")]
	[ProtoContract]
	public class CSGetLimitedEventStoreRes
	{
		// Token: 0x06002661 RID: 9825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x21B455C", Offset = "0x21B455C", VA = "0x7BBC9B455C")]
		public CSGetLimitedEventStoreRes()
		{
		}

		// Token: 0x04002BCA RID: 11210
		[Token(Token = "0x4002BCA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11192D0", Offset = "0x11192D0")]
		public List<LimitedEventStore> limited_event_stores;
	}
}
