using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AAF RID: 2735
	[Token(Token = "0x2000AAF")]
	[ProtoContract]
	public class MysteryShopDiscountDesc
	{
		// Token: 0x060027B9 RID: 10169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x249E7D8", Offset = "0x249E7D8", VA = "0x7BBCC9E7D8")]
		public MysteryShopDiscountDesc()
		{
		}

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11267DC", Offset = "0x11267DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11267DC", Offset = "0x11267DC")]
		public string melon_pi_api_classes;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112682C", Offset = "0x112682C")]
		public uint mystery_shop_id;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126840", Offset = "0x1126840")]
		public uint discount;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126854", Offset = "0x1126854")]
		public uint weight;

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126868", Offset = "0x1126868")]
		public uint discount_show;
	}
}
