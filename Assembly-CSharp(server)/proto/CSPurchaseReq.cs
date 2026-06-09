using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	[ProtoContract]
	public class CSPurchaseReq
	{
		// Token: 0x06002480 RID: 9344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x21B6FE8", Offset = "0x21B6FE8", VA = "0x7BBC9B6FE8")]
		public CSPurchaseReq()
		{
		}

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D91C", Offset = "0x110D91C")]
		public uint store_item_id;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D930", Offset = "0x110D930")]
		public ulong trans_id;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D944", Offset = "0x110D944")]
		public uint cnt;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D958", Offset = "0x110D958")]
		public uint currency_type;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D96C", Offset = "0x110D96C")]
		public uint price;

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D980", Offset = "0x110D980")]
		public uint voucher_id;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D994", Offset = "0x110D994")]
		public EInventory.StorePromotionType promotion_type;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D9A8", Offset = "0x110D9A8")]
		public bool is_offer;
	}
}
