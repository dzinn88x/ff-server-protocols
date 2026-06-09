using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200086E RID: 2158
	[Token(Token = "0x200086E")]
	[ProtoContract]
	public class GachaInfo
	{
		// Token: 0x0600257C RID: 9596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600257C")]
		[Address(RVA = "0x21BA5C4", Offset = "0x21BA5C4", VA = "0x7BBC9BA5C4")]
		public GachaInfo()
		{
		}

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A20", Offset = "0x1112A20")]
		public uint chest_id;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A34", Offset = "0x1112A34")]
		public uint lottery_count_weekly;

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A48", Offset = "0x1112A48")]
		public uint[] exchanged_reward_list;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A84", Offset = "0x1112A84")]
		public long next_free_time;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112A98", Offset = "0x1112A98")]
		public uint not_got_num;

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112AAC", Offset = "0x1112AAC")]
		public uint limit_purchase_count_one;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112AC0", Offset = "0x1112AC0")]
		public uint limit_purchase_count_ten;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112AD4", Offset = "0x1112AD4")]
		public uint first_draw_reward_num;
	}
}
