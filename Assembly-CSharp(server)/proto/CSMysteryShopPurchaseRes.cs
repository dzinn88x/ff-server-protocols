using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	[ProtoContract]
	public class CSMysteryShopPurchaseRes
	{
		// Token: 0x060025E2 RID: 9698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x21B6BF8", Offset = "0x21B6BF8", VA = "0x7BBC9B6BF8")]
		public CSMysteryShopPurchaseRes()
		{
		}

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116DB4", Offset = "0x1116DB4")]
		public ExchangeChangeData data;

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116DC8", Offset = "0x1116DC8")]
		public uint pool_id;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116DDC", Offset = "0x1116DDC")]
		public uint cost_gems;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116DF0", Offset = "0x1116DF0")]
		public uint purchase_count;
	}
}
