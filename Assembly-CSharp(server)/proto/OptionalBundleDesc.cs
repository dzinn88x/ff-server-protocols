using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	[ProtoContract]
	public class OptionalBundleDesc
	{
		// Token: 0x060026D9 RID: 9945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D9")]
		[Address(RVA = "0x249ED98", Offset = "0x249ED98", VA = "0x7BBCC9ED98")]
		public OptionalBundleDesc()
		{
		}

		// Token: 0x04002D70 RID: 11632
		[Token(Token = "0x4002D70")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B51C", Offset = "0x111B51C")]
		public uint id;

		// Token: 0x04002D71 RID: 11633
		[Token(Token = "0x4002D71")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B530", Offset = "0x111B530")]
		public uint option_order;

		// Token: 0x04002D72 RID: 11634
		[Token(Token = "0x4002D72")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B544", Offset = "0x111B544")]
		public EInventory.AwardType award_type;

		// Token: 0x04002D73 RID: 11635
		[Token(Token = "0x4002D73")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B558", Offset = "0x111B558")]
		public uint award_id;

		// Token: 0x04002D74 RID: 11636
		[Token(Token = "0x4002D74")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B56C", Offset = "0x111B56C")]
		public uint award_num;

		// Token: 0x04002D75 RID: 11637
		[Token(Token = "0x4002D75")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B580", Offset = "0x111B580")]
		public uint award_time;

		// Token: 0x04002D76 RID: 11638
		[Token(Token = "0x4002D76")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B594", Offset = "0x111B594")]
		public EInventory.AwardType return_type;

		// Token: 0x04002D77 RID: 11639
		[Token(Token = "0x4002D77")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B5A8", Offset = "0x111B5A8")]
		public uint return_id;

		// Token: 0x04002D78 RID: 11640
		[Token(Token = "0x4002D78")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B5BC", Offset = "0x111B5BC")]
		public uint return_num;

		// Token: 0x04002D79 RID: 11641
		[Token(Token = "0x4002D79")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B5D0", Offset = "0x111B5D0")]
		public bool is_preview;

		// Token: 0x04002D7A RID: 11642
		[Token(Token = "0x4002D7A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B5E4", Offset = "0x111B5E4")]
		public uint preview_avatar;

		// Token: 0x04002D7B RID: 11643
		[Token(Token = "0x4002D7B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B5F8", Offset = "0x111B5F8")]
		public uint default_male_role;

		// Token: 0x04002D7C RID: 11644
		[Token(Token = "0x4002D7C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B60C", Offset = "0x111B60C")]
		public uint default_female_role;

		// Token: 0x04002D7D RID: 11645
		[Token(Token = "0x4002D7D")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B620", Offset = "0x111B620")]
		public uint original_price;
	}
}
