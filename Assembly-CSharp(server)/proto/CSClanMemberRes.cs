using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007EC RID: 2028
	[Token(Token = "0x20007EC")]
	[ProtoContract]
	public class CSClanMemberRes
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024FB")]
		[Address(RVA = "0x21B0AC0", Offset = "0x21B0AC0", VA = "0x7BBC9B0AC0")]
		public CSClanMemberRes()
		{
		}

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111007C", Offset = "0x111007C")]
		public ulong clan_id;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110090", Offset = "0x1110090")]
		public ulong member_id;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11100A4", Offset = "0x11100A4")]
		public uint member_type;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11100B8", Offset = "0x11100B8")]
		public ulong join_at;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11100CC", Offset = "0x11100CC")]
		public uint honor_point;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11100E0", Offset = "0x11100E0")]
		public uint race_point;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11100F4", Offset = "0x11100F4")]
		public ulong last_gain_rp_at;
	}
}
