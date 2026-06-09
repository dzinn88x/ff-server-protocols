using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008BD RID: 2237
	[Token(Token = "0x20008BD")]
	[ProtoContract]
	public class CSDiscountStorePurchaseReq
	{
		// Token: 0x060025CB RID: 9675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025CB")]
		[Address(RVA = "0x21B0F48", Offset = "0x21B0F48", VA = "0x7BBC9B0F48")]
		public CSDiscountStorePurchaseReq()
		{
		}

		// Token: 0x04002A0D RID: 10765
		[Token(Token = "0x4002A0D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116544", Offset = "0x1116544")]
		public uint store_id;

		// Token: 0x04002A0E RID: 10766
		[Token(Token = "0x4002A0E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116558", Offset = "0x1116558")]
		public uint item_id;

		// Token: 0x04002A0F RID: 10767
		[Token(Token = "0x4002A0F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111656C", Offset = "0x111656C")]
		public uint cnt;

		// Token: 0x04002A10 RID: 10768
		[Token(Token = "0x4002A10")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116580", Offset = "0x1116580")]
		public EInventory.CurrencyType currency_type;

		// Token: 0x04002A11 RID: 10769
		[Token(Token = "0x4002A11")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116594", Offset = "0x1116594")]
		public uint price;

		// Token: 0x04002A12 RID: 10770
		[Token(Token = "0x4002A12")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11165A8", Offset = "0x11165A8")]
		public uint voucher_id;
	}
}
