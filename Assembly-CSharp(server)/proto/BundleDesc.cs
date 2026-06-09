using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CE RID: 2510
	[Token(Token = "0x20009CE")]
	[ProtoContract]
	public class BundleDesc
	{
		// Token: 0x060026D8 RID: 9944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D8")]
		[Address(RVA = "0x21AFF60", Offset = "0x21AFF60", VA = "0x7BBC9AFF60")]
		public BundleDesc()
		{
		}

		// Token: 0x04002D62 RID: 11618
		[Token(Token = "0x4002D62")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B38C", Offset = "0x111B38C")]
		public uint id;

		// Token: 0x04002D63 RID: 11619
		[Token(Token = "0x4002D63")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B3A0", Offset = "0x111B3A0")]
		public EInventory.AwardType award_type;

		// Token: 0x04002D64 RID: 11620
		[Token(Token = "0x4002D64")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B3B4", Offset = "0x111B3B4")]
		public uint award_id;

		// Token: 0x04002D65 RID: 11621
		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B3C8", Offset = "0x111B3C8")]
		public uint award_num;

		// Token: 0x04002D66 RID: 11622
		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B3DC", Offset = "0x111B3DC")]
		public EInventory.AwardType return_type;

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B3F0", Offset = "0x111B3F0")]
		public uint return_id;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B404", Offset = "0x111B404")]
		public uint return_num;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B418", Offset = "0x111B418")]
		public bool is_preview;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B42C", Offset = "0x111B42C")]
		public uint preview_avatar;

		// Token: 0x04002D6B RID: 11627
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B440", Offset = "0x111B440")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B440", Offset = "0x111B440")]
		public string image_url;

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B490", Offset = "0x111B490")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B490", Offset = "0x111B490")]
		public string back_ground_url;

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B4E0", Offset = "0x111B4E0")]
		public uint default_male_role;

		// Token: 0x04002D6E RID: 11630
		[Token(Token = "0x4002D6E")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B4F4", Offset = "0x111B4F4")]
		public uint default_female_role;

		// Token: 0x04002D6F RID: 11631
		[Token(Token = "0x4002D6F")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B508", Offset = "0x111B508")]
		public uint award_time;
	}
}
