using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009D3 RID: 2515
	[Token(Token = "0x20009D3")]
	[ProtoContract]
	public class GameBagDesc
	{
		// Token: 0x060026DD RID: 9949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026DD")]
		[Address(RVA = "0x21BA650", Offset = "0x21BA650", VA = "0x7BBC9BA650")]
		public GameBagDesc()
		{
		}

		// Token: 0x04002D82 RID: 11650
		[Token(Token = "0x4002D82")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B684", Offset = "0x111B684")]
		public uint item_id;
	}
}
