using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000859 RID: 2137
	[Token(Token = "0x2000859")]
	[ProtoContract]
	public class CSGetAdvertRes
	{
		// Token: 0x06002567 RID: 9575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002567")]
		[Address(RVA = "0x21B1C3C", Offset = "0x21B1C3C", VA = "0x7BBC9B1C3C")]
		public CSGetAdvertRes()
		{
		}

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112458", Offset = "0x1112458")]
		public List<AdvertDesc> advert_items;
	}
}
