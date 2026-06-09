using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000870 RID: 2160
	[Token(Token = "0x2000870")]
	[ProtoContract]
	public class GachaShowItemsWithJackpot
	{
		// Token: 0x0600257E RID: 9598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x21BA5D4", Offset = "0x21BA5D4", VA = "0x7BBC9BA5D4")]
		public GachaShowItemsWithJackpot()
		{
		}

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111318C", Offset = "0x111318C")]
		public List<GachaShowItem> items;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11131A0", Offset = "0x11131A0")]
		public uint jackpot;
	}
}
