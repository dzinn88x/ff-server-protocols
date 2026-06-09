using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B0B RID: 2827
	[Token(Token = "0x2000B0B")]
	[ProtoContract]
	public class BigEventStoreCommodityDesc
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x21AF944", Offset = "0x21AF944", VA = "0x7BBC9AF944")]
		public BigEventStoreCommodityDesc()
		{
		}

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A760", Offset = "0x112A760")]
		public uint store_id;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A774", Offset = "0x112A774")]
		public uint sku_id;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A788", Offset = "0x112A788")]
		public uint sort_id;

		// Token: 0x04003561 RID: 13665
		[Token(Token = "0x4003561")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A79C", Offset = "0x112A79C")]
		public uint item_id;

		// Token: 0x04003562 RID: 13666
		[Token(Token = "0x4003562")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A7B0", Offset = "0x112A7B0")]
		public uint item_duration;

		// Token: 0x04003563 RID: 13667
		[Token(Token = "0x4003563")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A7C4", Offset = "0x112A7C4")]
		public uint currency_id;

		// Token: 0x04003564 RID: 13668
		[Token(Token = "0x4003564")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A7D8", Offset = "0x112A7D8")]
		public uint currency_price;

		// Token: 0x04003565 RID: 13669
		[Token(Token = "0x4003565")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A7EC", Offset = "0x112A7EC")]
		public uint limited_purchase_times;

		// Token: 0x04003566 RID: 13670
		[Token(Token = "0x4003566")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A800", Offset = "0x112A800")]
		public uint purchase_times;

		// Token: 0x04003567 RID: 13671
		[Token(Token = "0x4003567")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112A814", Offset = "0x112A814")]
		public uint item_amount;
	}
}
