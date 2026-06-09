using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	[ProtoContract]
	public class ReviveTokenUsed
	{
		// Token: 0x060023B0 RID: 9136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x24A01F4", Offset = "0x24A01F4", VA = "0x7BBCCA01F4")]
		public ReviveTokenUsed()
		{
		}

		// Token: 0x04001FBE RID: 8126
		[Token(Token = "0x4001FBE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108480", Offset = "0x1108480")]
		public uint used_gems;

		// Token: 0x04001FBF RID: 8127
		[Token(Token = "0x4001FBF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108494", Offset = "0x1108494")]
		public uint used_coins;

		// Token: 0x04001FC0 RID: 8128
		[Token(Token = "0x4001FC0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11084A8", Offset = "0x11084A8")]
		public List<Item> used_items;
	}
}
