using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	[ProtoContract]
	public class CupTeamApplicantRes
	{
		// Token: 0x06002467 RID: 9319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x21B92AC", Offset = "0x21B92AC", VA = "0x7BBC9B92AC")]
		public CupTeamApplicantRes()
		{
		}

		// Token: 0x040024F7 RID: 9463
		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D250", Offset = "0x110D250")]
		public ulong applicant_id;

		// Token: 0x040024F8 RID: 9464
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D264", Offset = "0x110D264")]
		public uint tier;

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D278", Offset = "0x110D278")]
		public ulong cup_team_id;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D28C", Offset = "0x110D28C")]
		public ulong create_at;
	}
}
