using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	[ProtoContract]
	public class InventoryChangeMessage
	{
		// Token: 0x06002496 RID: 9366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x21BB62C", Offset = "0x21BB62C", VA = "0x7BBC9BB62C")]
		public InventoryChangeMessage()
		{
		}

		// Token: 0x04002585 RID: 9605
		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E114", Offset = "0x110E114")]
		public List<Item> items;
	}
}
