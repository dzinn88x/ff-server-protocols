using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AB0 RID: 2736
	[Token(Token = "0x2000AB0")]
	[ProtoContract]
	public class MysteryShopSwitchDesc
	{
		// Token: 0x060027BA RID: 10170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x249E898", Offset = "0x249E898", VA = "0x7BBCC9E898")]
		public MysteryShopSwitchDesc()
		{
		}

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112687C", Offset = "0x112687C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112687C", Offset = "0x112687C")]
		public string melon_pi_api_classes;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11268CC", Offset = "0x11268CC")]
		public uint mystery_shop_id;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11268E0", Offset = "0x11268E0")]
		public uint mystery_shop_pool_id;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11268F4", Offset = "0x11268F4")]
		public uint weight;

		// Token: 0x04003362 RID: 13154
		[Token(Token = "0x4003362")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126908", Offset = "0x1126908")]
		public uint unlock_amount;

		// Token: 0x04003363 RID: 13155
		[Token(Token = "0x4003363")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112691C", Offset = "0x112691C")]
		public uint switch_amount;

		// Token: 0x04003364 RID: 13156
		[Token(Token = "0x4003364")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126930", Offset = "0x1126930")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126930", Offset = "0x1126930")]
		public string shop_cdn;

		// Token: 0x04003365 RID: 13157
		[Token(Token = "0x4003365")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126980", Offset = "0x1126980")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126980", Offset = "0x1126980")]
		public string switch_cdn;

		// Token: 0x04003366 RID: 13158
		[Token(Token = "0x4003366")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11269D0", Offset = "0x11269D0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11269D0", Offset = "0x11269D0")]
		public string pool_center_cdn;
	}
}
