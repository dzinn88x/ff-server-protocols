using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA3 RID: 2723
	[Token(Token = "0x2000AA3")]
	[ProtoContract]
	public class IAPStoreDesc
	{
		// Token: 0x060027AD RID: 10157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x21BB418", Offset = "0x21BB418", VA = "0x7BBC9BB418")]
		public IAPStoreDesc()
		{
		}

		// Token: 0x040032FE RID: 13054
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125D3C", Offset = "0x1125D3C")]
		public uint store_id;

		// Token: 0x040032FF RID: 13055
		[Token(Token = "0x40032FF")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125D50", Offset = "0x1125D50")]
		public uint bundle_id;

		// Token: 0x04003300 RID: 13056
		[Token(Token = "0x4003300")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125D64", Offset = "0x1125D64")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125D64", Offset = "0x1125D64")]
		public string bundle_name;

		// Token: 0x04003301 RID: 13057
		[Token(Token = "0x4003301")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125DB4", Offset = "0x1125DB4")]
		public uint price_item_id;

		// Token: 0x04003302 RID: 13058
		[Token(Token = "0x4003302")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125DC8", Offset = "0x1125DC8")]
		public float price;

		// Token: 0x04003303 RID: 13059
		[Token(Token = "0x4003303")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125DDC", Offset = "0x1125DDC")]
		public uint discount_price_rebate_id;

		// Token: 0x04003304 RID: 13060
		[Token(Token = "0x4003304")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125DF0", Offset = "0x1125DF0")]
		public uint discount_price_item_id;

		// Token: 0x04003305 RID: 13061
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E04", Offset = "0x1125E04")]
		public float discount_price;

		// Token: 0x04003306 RID: 13062
		[Token(Token = "0x4003306")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E18", Offset = "0x1125E18")]
		public float discount;

		// Token: 0x04003307 RID: 13063
		[Token(Token = "0x4003307")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E2C", Offset = "0x1125E2C")]
		public uint diamond_price;

		// Token: 0x04003308 RID: 13064
		[Token(Token = "0x4003308")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E40", Offset = "0x1125E40")]
		public uint discount_diamond_price;

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E54", Offset = "0x1125E54")]
		public uint diamond_bonus;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E68", Offset = "0x1125E68")]
		public bool is_remain_diamond;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0x45")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E7C", Offset = "0x1125E7C")]
		public bool is_nonconsumable;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125E90", Offset = "0x1125E90")]
		public EStore.IapStoreType store_type;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125EA4", Offset = "0x1125EA4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1125EA4", Offset = "0x1125EA4")]
		public string web_link;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1125EF4", Offset = "0x1125EF4")]
		public uint activity_id;
	}
}
