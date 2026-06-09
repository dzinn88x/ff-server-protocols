using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2000AC4")]
	[ProtoContract]
	public class CardPrice
	{
		// Token: 0x060027CD RID: 10189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x21B7E90", Offset = "0x21B7E90", VA = "0x7BBC9B7E90")]
		public CardPrice()
		{
		}

		// Token: 0x040033CA RID: 13258
		[Token(Token = "0x40033CA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11274E8", Offset = "0x11274E8")]
		public uint card_num;

		// Token: 0x040033CB RID: 13259
		[Token(Token = "0x40033CB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11274FC", Offset = "0x11274FC")]
		public uint single_price;

		// Token: 0x040033CC RID: 13260
		[Token(Token = "0x40033CC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127510", Offset = "0x1127510")]
		public uint all_price;
	}
}
