using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200093E RID: 2366
	[Token(Token = "0x200093E")]
	[ProtoContract]
	public class CSGetSubcribeStoreRes
	{
		// Token: 0x0600264C RID: 9804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x21B5D60", Offset = "0x21B5D60", VA = "0x7BBC9B5D60")]
		public CSGetSubcribeStoreRes()
		{
		}

		// Token: 0x04002BA1 RID: 11169
		[Token(Token = "0x4002BA1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118E98", Offset = "0x1118E98")]
		public List<SubscribeStoreDesc> items;
	}
}
