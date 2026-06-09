using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A7 RID: 2215
	[Token(Token = "0x20008A7")]
	[ProtoContract]
	public class CSGetGiftStoreDetailsRes
	{
		// Token: 0x060025B5 RID: 9653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B5")]
		[Address(RVA = "0x21B3FE0", Offset = "0x21B3FE0", VA = "0x7BBC9B3FE0")]
		public CSGetGiftStoreDetailsRes()
		{
		}

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D10", Offset = "0x1115D10")]
		public uint store_id;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D24", Offset = "0x1115D24")]
		public List<GiftItem> items;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115D38", Offset = "0x1115D38")]
		public uint send_gift_times_today;
	}
}
