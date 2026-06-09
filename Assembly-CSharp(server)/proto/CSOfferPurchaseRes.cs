using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000776 RID: 1910
	[Token(Token = "0x2000776")]
	[ProtoContract]
	public class CSOfferPurchaseRes
	{
		// Token: 0x06002483 RID: 9347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x21B6C20", Offset = "0x21B6C20", VA = "0x7BBC9B6C20")]
		public CSOfferPurchaseRes()
		{
		}

		// Token: 0x04002541 RID: 9537
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA70", Offset = "0x110DA70")]
		public ExchangeChangeData data;

		// Token: 0x04002542 RID: 9538
		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA84", Offset = "0x110DA84")]
		public int gems;
	}
}
