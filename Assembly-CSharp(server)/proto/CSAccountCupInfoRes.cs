using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200073F RID: 1855
	[Token(Token = "0x200073F")]
	[ProtoContract]
	public class CSAccountCupInfoRes
	{
		// Token: 0x0600244C RID: 9292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x21B0114", Offset = "0x21B0114", VA = "0x7BBC9B0114")]
		public CSAccountCupInfoRes()
		{
		}

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CA94", Offset = "0x110CA94")]
		public ulong account_id;

		// Token: 0x040024AC RID: 9388
		[Token(Token = "0x40024AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CAA8", Offset = "0x110CAA8")]
		public uint cup_type;

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CABC", Offset = "0x110CABC")]
		public uint cup_id;

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CAD0", Offset = "0x110CAD0")]
		public uint tier;

		// Token: 0x040024AF RID: 9391
		[Token(Token = "0x40024AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CAE4", Offset = "0x110CAE4")]
		public CupTeamInfo team_info;

		// Token: 0x040024B0 RID: 9392
		[Token(Token = "0x40024B0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CAF8", Offset = "0x110CAF8")]
		public ulong team_id;

		// Token: 0x040024B1 RID: 9393
		[Token(Token = "0x40024B1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB0C", Offset = "0x110CB0C")]
		public bool award_claimed;

		// Token: 0x040024B2 RID: 9394
		[Token(Token = "0x40024B2")]
		[FieldOffset(Offset = "0x39")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB20", Offset = "0x110CB20")]
		public bool use_ticket;

		// Token: 0x040024B3 RID: 9395
		[Token(Token = "0x40024B3")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB34", Offset = "0x110CB34")]
		public uint member_type;

		// Token: 0x040024B4 RID: 9396
		[Token(Token = "0x40024B4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CB48", Offset = "0x110CB48")]
		public uint join_at;
	}
}
