using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	[ProtoContract]
	public class ItemSlice
	{
		// Token: 0x06002356 RID: 9046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002356")]
		[Address(RVA = "0x21BB7D0", Offset = "0x21BB7D0", VA = "0x7BBC9BB7D0")]
		public ItemSlice()
		{
		}

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11051CC", Offset = "0x11051CC")]
		public List<Item> items;
	}
}
