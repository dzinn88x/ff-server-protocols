using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000774 RID: 1908
	[Token(Token = "0x2000774")]
	[ProtoContract]
	public class CSPurchaseRes
	{
		// Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x21B6FF0", Offset = "0x21B6FF0", VA = "0x7BBC9B6FF0")]
		public CSPurchaseRes()
		{
		}

		// Token: 0x04002538 RID: 9528
		[Token(Token = "0x4002538")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D9BC", Offset = "0x110D9BC")]
		public ExchangeChangeData data;

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D9D0", Offset = "0x110D9D0")]
		public uint coins;

		// Token: 0x0400253A RID: 9530
		[Token(Token = "0x400253A")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D9E4", Offset = "0x110D9E4")]
		public int gems;

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D9F8", Offset = "0x110D9F8")]
		public OfferGoodsDesc offer_goods;
	}
}
