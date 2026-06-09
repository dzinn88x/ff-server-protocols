using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CA RID: 2506
	[Token(Token = "0x20009CA")]
	[ProtoContract]
	public class StoreDesc
	{
		// Token: 0x060026D4 RID: 9940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D4")]
		[Address(RVA = "0x24A0860", Offset = "0x24A0860", VA = "0x7BBCCA0860")]
		public StoreDesc()
		{
		}

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ACC0", Offset = "0x111ACC0")]
		public uint store_id;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ACD4", Offset = "0x111ACD4")]
		public uint sort_id;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ACE8", Offset = "0x111ACE8")]
		public uint item_id;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ACFC", Offset = "0x111ACFC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111ACFC", Offset = "0x111ACFC")]
		public string added_time;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AD4C", Offset = "0x111AD4C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AD4C", Offset = "0x111AD4C")]
		public string expire_time;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AD9C", Offset = "0x111AD9C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AD9C", Offset = "0x111AD9C")]
		public string name;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ADEC", Offset = "0x111ADEC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111ADEC", Offset = "0x111ADEC")]
		public string desc;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AE3C", Offset = "0x111AE3C")]
		public uint coins_price;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AE50", Offset = "0x111AE50")]
		public uint gems_price;

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AE64", Offset = "0x111AE64")]
		public EInventory.StoreTag tag_type;

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AE78", Offset = "0x111AE78")]
		public uint tag_value;

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AE8C", Offset = "0x111AE8C")]
		public uint limited_purchase_times;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AEA0", Offset = "0x111AEA0")]
		public uint purchase_times;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AEB4", Offset = "0x111AEB4")]
		public bool is_new;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AEC8", Offset = "0x111AEC8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AEC8", Offset = "0x111AEC8")]
		public string type_override;

		// Token: 0x04002D3E RID: 11582
		[Token(Token = "0x4002D3E")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AF18", Offset = "0x111AF18")]
		public bool is_original_type_remain;

		// Token: 0x04002D3F RID: 11583
		[Token(Token = "0x4002D3F")]
		[FieldOffset(Offset = "0x69")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AF2C", Offset = "0x111AF2C")]
		public bool is_recommended;

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AF40", Offset = "0x111AF40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AF40", Offset = "0x111AF40")]
		public string image_url;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AF90", Offset = "0x111AF90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AF90", Offset = "0x111AF90")]
		public string language;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AFE0", Offset = "0x111AFE0")]
		public bool is_vfx;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111AFF4", Offset = "0x111AFF4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111AFF4", Offset = "0x111AFF4")]
		public string real_image_url;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B044", Offset = "0x111B044")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B044", Offset = "0x111B044")]
		public string link_to_web_store;

		// Token: 0x04002D45 RID: 11589
		[Token(Token = "0x4002D45")]
		[FieldOffset(Offset = "0x98")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B094", Offset = "0x111B094")]
		public uint discount_price;

		// Token: 0x04002D46 RID: 11590
		[Token(Token = "0x4002D46")]
		[FieldOffset(Offset = "0xA0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B0A8", Offset = "0x111B0A8")]
		public long discount_start_time;

		// Token: 0x04002D47 RID: 11591
		[Token(Token = "0x4002D47")]
		[FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B0BC", Offset = "0x111B0BC")]
		public long discount_end_time;

		// Token: 0x04002D48 RID: 11592
		[Token(Token = "0x4002D48")]
		[FieldOffset(Offset = "0xB0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B0D0", Offset = "0x111B0D0")]
		public uint award_time;

		// Token: 0x04002D49 RID: 11593
		[Token(Token = "0x4002D49")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B0E4", Offset = "0x111B0E4")]
		public bool go_mystery_shop;

		// Token: 0x04002D4A RID: 11594
		[Token(Token = "0x4002D4A")]
		[FieldOffset(Offset = "0xB8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B0F8", Offset = "0x111B0F8")]
		public long expire_timestamp;
	}
}
