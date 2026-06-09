using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009CD RID: 2509
	[Token(Token = "0x20009CD")]
	[ProtoContract]
	public class LimitedCardDesc
	{
		// Token: 0x060026D7 RID: 9943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026D7")]
		[Address(RVA = "0x21BBA3C", Offset = "0x21BBA3C", VA = "0x7BBC9BBA3C")]
		public LimitedCardDesc()
		{
		}

		// Token: 0x04002D5A RID: 11610
		[Token(Token = "0x4002D5A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B2B0", Offset = "0x111B2B0")]
		public uint id;

		// Token: 0x04002D5B RID: 11611
		[Token(Token = "0x4002D5B")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B2C4", Offset = "0x111B2C4")]
		public EInventory.LimitedCardType card_type;

		// Token: 0x04002D5C RID: 11612
		[Token(Token = "0x4002D5C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B2D8", Offset = "0x111B2D8")]
		public uint effected_id;

		// Token: 0x04002D5D RID: 11613
		[Token(Token = "0x4002D5D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B2EC", Offset = "0x111B2EC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111B2EC", Offset = "0x111B2EC")]
		public string name;

		// Token: 0x04002D5E RID: 11614
		[Token(Token = "0x4002D5E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B33C", Offset = "0x111B33C")]
		public uint expire_mins;

		// Token: 0x04002D5F RID: 11615
		[Token(Token = "0x4002D5F")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B350", Offset = "0x111B350")]
		public int left_use_times;

		// Token: 0x04002D60 RID: 11616
		[Token(Token = "0x4002D60")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B364", Offset = "0x111B364")]
		public uint discount;

		// Token: 0x04002D61 RID: 11617
		[Token(Token = "0x4002D61")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111B378", Offset = "0x111B378")]
		public uint take_gift_count;
	}
}
