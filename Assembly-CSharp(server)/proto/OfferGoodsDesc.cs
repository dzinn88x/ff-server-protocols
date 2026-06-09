using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E5 RID: 2533
	[Token(Token = "0x20009E5")]
	[ProtoContract]
	public class OfferGoodsDesc
	{
		// Token: 0x060026EF RID: 9967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EF")]
		[Address(RVA = "0x249EC7C", Offset = "0x249EC7C", VA = "0x7BBCC9EC7C")]
		public OfferGoodsDesc()
		{
		}

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BD8C", Offset = "0x111BD8C")]
		public uint offer_id;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BDA0", Offset = "0x111BDA0")]
		public uint offer_goods_id;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BDB4", Offset = "0x111BDB4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111BDB4", Offset = "0x111BDB4")]
		public string award_name;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE04", Offset = "0x111BE04")]
		public uint item_id;

		// Token: 0x04002DC8 RID: 11720
		[Token(Token = "0x4002DC8")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE18", Offset = "0x111BE18")]
		public uint award_num;

		// Token: 0x04002DC9 RID: 11721
		[Token(Token = "0x4002DC9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE2C", Offset = "0x111BE2C")]
		public uint award_time;

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE40", Offset = "0x111BE40")]
		public uint item_price;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE54", Offset = "0x111BE54")]
		public uint discount_price;

		// Token: 0x04002DCC RID: 11724
		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE68", Offset = "0x111BE68")]
		public uint is_force;

		// Token: 0x04002DCD RID: 11725
		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BE7C", Offset = "0x111BE7C")]
		public uint is_replenish;
	}
}
