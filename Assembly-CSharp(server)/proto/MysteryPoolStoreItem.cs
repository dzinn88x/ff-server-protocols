using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	[ProtoContract]
	public class MysteryPoolStoreItem
	{
		// Token: 0x060025D9 RID: 9689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D9")]
		[Address(RVA = "0x249E6BC", Offset = "0x249E6BC", VA = "0x7BBCC9E6BC")]
		public MysteryPoolStoreItem()
		{
		}

		// Token: 0x04002A36 RID: 10806
		[Token(Token = "0x4002A36")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116968", Offset = "0x1116968")]
		public uint store_id;

		// Token: 0x04002A37 RID: 10807
		[Token(Token = "0x4002A37")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111697C", Offset = "0x111697C")]
		public uint mystery_shop_pool_id;

		// Token: 0x04002A38 RID: 10808
		[Token(Token = "0x4002A38")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116990", Offset = "0x1116990")]
		public uint sort_id;

		// Token: 0x04002A39 RID: 10809
		[Token(Token = "0x4002A39")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11169A4", Offset = "0x11169A4")]
		public uint item_id;

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11169B8", Offset = "0x11169B8")]
		public uint award_time;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11169CC", Offset = "0x11169CC")]
		public uint gems_price;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11169E0", Offset = "0x11169E0")]
		public uint limited_purchase_times;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11169F4", Offset = "0x11169F4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11169F4", Offset = "0x11169F4")]
		public string reward_cdn;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116A44", Offset = "0x1116A44")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1116A44", Offset = "0x1116A44")]
		public string share_cdn;

		// Token: 0x04002A3F RID: 10815
		[Token(Token = "0x4002A3F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116A94", Offset = "0x1116A94")]
		public uint purchased_cnt;

		// Token: 0x04002A40 RID: 10816
		[Token(Token = "0x4002A40")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116AA8", Offset = "0x1116AA8")]
		public uint discount_price;
	}
}
