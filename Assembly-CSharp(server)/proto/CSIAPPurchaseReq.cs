using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008B0 RID: 2224
	[Token(Token = "0x20008B0")]
	[ProtoContract]
	public class CSIAPPurchaseReq
	{
		// Token: 0x060025BE RID: 9662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025BE")]
		[Address(RVA = "0x21B6458", Offset = "0x21B6458", VA = "0x7BBC9B6458")]
		public CSIAPPurchaseReq()
		{
		}

		// Token: 0x040029E4 RID: 10724
		[Token(Token = "0x40029E4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11160A8", Offset = "0x11160A8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11160A8", Offset = "0x11160A8")]
		public string login_token;

		// Token: 0x040029E5 RID: 10725
		[Token(Token = "0x40029E5")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11160F8", Offset = "0x11160F8")]
		public uint plat_id;

		// Token: 0x040029E6 RID: 10726
		[Token(Token = "0x40029E6")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111610C", Offset = "0x111610C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111610C", Offset = "0x111610C")]
		public string external_id;

		// Token: 0x040029E7 RID: 10727
		[Token(Token = "0x40029E7")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111615C", Offset = "0x111615C")]
		public uint rebate_card_id;

		// Token: 0x040029E8 RID: 10728
		[Token(Token = "0x40029E8")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116170", Offset = "0x1116170")]
		public bool from_gop;

		// Token: 0x040029E9 RID: 10729
		[Token(Token = "0x40029E9")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116184", Offset = "0x1116184")]
		public uint iap_type;

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116198", Offset = "0x1116198")]
		public uint iap_consume_type;

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11161AC", Offset = "0x11161AC")]
		public uint store_id;
	}
}
