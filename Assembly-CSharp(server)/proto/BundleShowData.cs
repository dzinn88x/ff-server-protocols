using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000782 RID: 1922
	[Token(Token = "0x2000782")]
	[ProtoContract]
	public class BundleShowData
	{
		// Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x21B0030", Offset = "0x21B0030", VA = "0x7BBC9B0030")]
		public BundleShowData()
		{
		}

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DDE0", Offset = "0x110DDE0")]
		public uint award_id;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DDF4", Offset = "0x110DDF4")]
		public bool is_preview;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DE08", Offset = "0x110DE08")]
		public uint preview_avatar;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DE1C", Offset = "0x110DE1C")]
		public uint award_num;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DE30", Offset = "0x110DE30")]
		public EInventory.AwardType award_type;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DE44", Offset = "0x110DE44")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110DE44", Offset = "0x110DE44")]
		public string image_url;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DE94", Offset = "0x110DE94")]
		public EInventory.AwardType return_type;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DEA8", Offset = "0x110DEA8")]
		public uint return_id;

		// Token: 0x0400256A RID: 9578
		[Token(Token = "0x400256A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DEBC", Offset = "0x110DEBC")]
		public uint return_num;

		// Token: 0x0400256B RID: 9579
		[Token(Token = "0x400256B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110DED0", Offset = "0x110DED0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DED0", Offset = "0x110DED0")]
		public string back_ground_url;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF20", Offset = "0x110DF20")]
		public uint default_male_role;

		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF34", Offset = "0x110DF34")]
		public uint default_female_role;

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DF48", Offset = "0x110DF48")]
		public uint award_time;
	}
}
