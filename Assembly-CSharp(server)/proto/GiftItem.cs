using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	[ProtoContract]
	public class GiftItem
	{
		// Token: 0x060025D1 RID: 9681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025D1")]
		[Address(RVA = "0x21BABEC", Offset = "0x21BABEC", VA = "0x7BBC9BABEC")]
		public GiftItem()
		{
		}

		// Token: 0x04002A1F RID: 10783
		[Token(Token = "0x4002A1F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116724", Offset = "0x1116724")]
		public uint commodity_id;

		// Token: 0x04002A20 RID: 10784
		[Token(Token = "0x4002A20")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116738", Offset = "0x1116738")]
		public uint sort_id;

		// Token: 0x04002A21 RID: 10785
		[Token(Token = "0x4002A21")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111674C", Offset = "0x111674C")]
		public uint item_id;

		// Token: 0x04002A22 RID: 10786
		[Token(Token = "0x4002A22")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116760", Offset = "0x1116760")]
		public uint coins_price;

		// Token: 0x04002A23 RID: 10787
		[Token(Token = "0x4002A23")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116774", Offset = "0x1116774")]
		public uint gems_price;

		// Token: 0x04002A24 RID: 10788
		[Token(Token = "0x4002A24")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116788", Offset = "0x1116788")]
		public uint tag_type;

		// Token: 0x04002A25 RID: 10789
		[Token(Token = "0x4002A25")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111679C", Offset = "0x111679C")]
		public uint tag_value;

		// Token: 0x04002A26 RID: 10790
		[Token(Token = "0x4002A26")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11167B0", Offset = "0x11167B0")]
		public uint type_override;

		// Token: 0x04002A27 RID: 10791
		[Token(Token = "0x4002A27")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11167C4", Offset = "0x11167C4")]
		public bool is_original_type_remain;

		// Token: 0x04002A28 RID: 10792
		[Token(Token = "0x4002A28")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11167D8", Offset = "0x11167D8")]
		public bool is_exclusive;

		// Token: 0x04002A29 RID: 10793
		[Token(Token = "0x4002A29")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11167EC", Offset = "0x11167EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11167EC", Offset = "0x11167EC")]
		public string image_url;

		// Token: 0x04002A2A RID: 10794
		[Token(Token = "0x4002A2A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111683C", Offset = "0x111683C")]
		public bool is_quick_gift_recommended;

		// Token: 0x04002A2B RID: 10795
		[Token(Token = "0x4002A2B")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116850", Offset = "0x1116850")]
		public uint award_time;

		// Token: 0x04002A2C RID: 10796
		[Token(Token = "0x4002A2C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1116864", Offset = "0x1116864")]
		public long expire_timestamp;
	}
}
