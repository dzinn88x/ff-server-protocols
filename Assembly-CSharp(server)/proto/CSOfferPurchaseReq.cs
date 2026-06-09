using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	[ProtoContract]
	public class CSOfferPurchaseReq
	{
		// Token: 0x06002482 RID: 9346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x21B6C18", Offset = "0x21B6C18", VA = "0x7BBC9B6C18")]
		public CSOfferPurchaseReq()
		{
		}

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA0C", Offset = "0x110DA0C")]
		public uint offer_id;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA20", Offset = "0x110DA20")]
		public uint offer_goods_id;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA34", Offset = "0x110DA34")]
		public uint cnt;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA48", Offset = "0x110DA48")]
		public ulong trans_id;

		// Token: 0x04002540 RID: 9536
		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DA5C", Offset = "0x110DA5C")]
		public uint price;
	}
}
