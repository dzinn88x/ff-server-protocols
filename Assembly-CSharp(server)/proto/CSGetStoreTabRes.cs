using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	[ProtoContract]
	public class CSGetStoreTabRes
	{
		// Token: 0x060025CD RID: 9677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CD")]
		[Address(RVA = "0x21B5C90", Offset = "0x21B5C90", VA = "0x7BBC9B5C90")]
		public CSGetStoreTabRes()
		{
		}

		// Token: 0x04002A15 RID: 10773
		[Token(Token = "0x4002A15")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11165E4", Offset = "0x11165E4")]
		public List<StoreTableDesc> store_tables;
	}
}
