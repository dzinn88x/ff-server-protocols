using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	[ProtoContract]
	public class CSGetCupTeamApplicantListRes
	{
		// Token: 0x0600246A RID: 9322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x21B2EB8", Offset = "0x21B2EB8", VA = "0x7BBC9B2EB8")]
		public CSGetCupTeamApplicantListRes()
		{
		}

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D2DC", Offset = "0x110D2DC")]
		public AccountInfoBasicBundleRes members_info;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D2F0", Offset = "0x110D2F0")]
		public CSCupTeamApplicantList members_cup_info;
	}
}
