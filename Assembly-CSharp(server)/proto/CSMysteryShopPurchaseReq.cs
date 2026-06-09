using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	[ProtoContract]
	public class CSMysteryShopPurchaseReq
	{
		// Token: 0x060025E1 RID: 9697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E1")]
		[Address(RVA = "0x21B6BF0", Offset = "0x21B6BF0", VA = "0x7BBC9B6BF0")]
		public CSMysteryShopPurchaseReq()
		{
		}

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D78", Offset = "0x1116D78")]
		public uint store_id;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116D8C", Offset = "0x1116D8C")]
		public uint cnt;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116DA0", Offset = "0x1116DA0")]
		public uint price;
	}
}
