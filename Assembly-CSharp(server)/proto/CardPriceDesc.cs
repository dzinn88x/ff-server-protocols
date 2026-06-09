using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	[ProtoContract]
	public class CardPriceDesc
	{
		// Token: 0x060027CC RID: 10188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x21B7E98", Offset = "0x21B7E98", VA = "0x7BBC9B7E98")]
		public CardPriceDesc()
		{
		}

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127484", Offset = "0x1127484")]
		public uint card_num;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127498", Offset = "0x1127498")]
		public uint single_price;

		// Token: 0x040033C7 RID: 13255
		[Token(Token = "0x40033C7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11274AC", Offset = "0x11274AC")]
		public uint all_price;

		// Token: 0x040033C8 RID: 13256
		[Token(Token = "0x40033C8")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11274C0", Offset = "0x11274C0")]
		public uint win_single_price;

		// Token: 0x040033C9 RID: 13257
		[Token(Token = "0x40033C9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11274D4", Offset = "0x11274D4")]
		public uint win_all_price;
	}
}
