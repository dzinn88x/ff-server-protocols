using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000785 RID: 1925
	[Token(Token = "0x2000785")]
	[ProtoContract]
	public class OptionalBundleShowData
	{
		// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x249EE14", Offset = "0x249EE14", VA = "0x7BBCC9EE14")]
		public OptionalBundleShowData()
		{
		}

		// Token: 0x04002573 RID: 9587
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DFAC", Offset = "0x110DFAC")]
		public uint option_order;

		// Token: 0x04002574 RID: 9588
		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DFC0", Offset = "0x110DFC0")]
		public EInventory.AwardType award_type;

		// Token: 0x04002575 RID: 9589
		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DFD4", Offset = "0x110DFD4")]
		public uint award_id;

		// Token: 0x04002576 RID: 9590
		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DFE8", Offset = "0x110DFE8")]
		public uint award_num;

		// Token: 0x04002577 RID: 9591
		[Token(Token = "0x4002577")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DFFC", Offset = "0x110DFFC")]
		public uint award_time;

		// Token: 0x04002578 RID: 9592
		[Token(Token = "0x4002578")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E010", Offset = "0x110E010")]
		public EInventory.AwardType return_type;

		// Token: 0x04002579 RID: 9593
		[Token(Token = "0x4002579")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E024", Offset = "0x110E024")]
		public uint return_id;

		// Token: 0x0400257A RID: 9594
		[Token(Token = "0x400257A")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E038", Offset = "0x110E038")]
		public uint return_num;

		// Token: 0x0400257B RID: 9595
		[Token(Token = "0x400257B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E04C", Offset = "0x110E04C")]
		public bool is_preview;

		// Token: 0x0400257C RID: 9596
		[Token(Token = "0x400257C")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E060", Offset = "0x110E060")]
		public uint preview_avatar;

		// Token: 0x0400257D RID: 9597
		[Token(Token = "0x400257D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E074", Offset = "0x110E074")]
		public uint default_male_role;

		// Token: 0x0400257E RID: 9598
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E088", Offset = "0x110E088")]
		public uint default_female_role;

		// Token: 0x0400257F RID: 9599
		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E09C", Offset = "0x110E09C")]
		public uint original_price;
	}
}
