using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	[ProtoContract]
	public class CSGetCupTeamInvitationListRes
	{
		// Token: 0x06002469 RID: 9321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x21B2F44", Offset = "0x21B2F44", VA = "0x7BBC9B2F44")]
		public CSGetCupTeamInvitationListRes()
		{
		}

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D2B4", Offset = "0x110D2B4")]
		public AccountInfoBasicBundleRes members_info;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D2C8", Offset = "0x110D2C8")]
		public CSCupTeamInvitationList members_cup_info;
	}
}
