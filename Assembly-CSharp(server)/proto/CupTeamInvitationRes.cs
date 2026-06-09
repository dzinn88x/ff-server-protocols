using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	[ProtoContract]
	public class CupTeamInvitationRes
	{
		// Token: 0x06002465 RID: 9317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x21B9340", Offset = "0x21B9340", VA = "0x7BBC9B9340")]
		public CupTeamInvitationRes()
		{
		}

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D1B0", Offset = "0x110D1B0")]
		public ulong account_id;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D1C4", Offset = "0x110D1C4")]
		public uint tier;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D1D8", Offset = "0x110D1D8")]
		public ulong team_id;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D1EC", Offset = "0x110D1EC")]
		public uint cup_type;

		// Token: 0x040024F3 RID: 9459
		[Token(Token = "0x40024F3")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D200", Offset = "0x110D200")]
		public uint cup_id;

		// Token: 0x040024F4 RID: 9460
		[Token(Token = "0x40024F4")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D214", Offset = "0x110D214")]
		public ulong inviter_id;

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D228", Offset = "0x110D228")]
		public ulong create_at;
	}
}
