using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A77 RID: 2679
	[Token(Token = "0x2000A77")]
	[ProtoContract]
	public class RankingPointsScaleDesc
	{
		// Token: 0x06002781 RID: 10113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x249FB24", Offset = "0x249FB24", VA = "0x7BBCC9FB24")]
		public RankingPointsScaleDesc()
		{
		}

		// Token: 0x04003113 RID: 12563
		[Token(Token = "0x4003113")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122394", Offset = "0x1122394")]
		public uint lower_bound;

		// Token: 0x04003114 RID: 12564
		[Token(Token = "0x4003114")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11223A8", Offset = "0x11223A8")]
		public uint upper_bound;

		// Token: 0x04003115 RID: 12565
		[Token(Token = "0x4003115")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11223BC", Offset = "0x11223BC")]
		public bool is_rank_open;

		// Token: 0x04003116 RID: 12566
		[Token(Token = "0x4003116")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11223D0", Offset = "0x11223D0")]
		public bool is_battle_open;

		// Token: 0x04003117 RID: 12567
		[Token(Token = "0x4003117")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11223E4", Offset = "0x11223E4")]
		public int positive_refer;

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11223F8", Offset = "0x11223F8")]
		public float positive_scale;

		// Token: 0x04003119 RID: 12569
		[Token(Token = "0x4003119")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112240C", Offset = "0x112240C")]
		public int negative_refer;

		// Token: 0x0400311A RID: 12570
		[Token(Token = "0x400311A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1122420", Offset = "0x1122420")]
		public float negative_scale;
	}
}
