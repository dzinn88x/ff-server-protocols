using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009A2 RID: 2466
	[Token(Token = "0x20009A2")]
	[ProtoContract]
	public class MonopolyBoard
	{
		// Token: 0x060026B0 RID: 9904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B0")]
		[Address(RVA = "0x21BCCD4", Offset = "0x21BCCD4", VA = "0x7BBC9BCCD4")]
		public MonopolyBoard()
		{
		}

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A388", Offset = "0x111A388")]
		public List<MonopolyNodeDesc> nodes;
	}
}
