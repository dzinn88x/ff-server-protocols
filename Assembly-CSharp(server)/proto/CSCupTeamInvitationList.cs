using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000757 RID: 1879
	[Token(Token = "0x2000757")]
	[ProtoContract]
	public class CSCupTeamInvitationList
	{
		// Token: 0x06002464 RID: 9316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x21B0E48", Offset = "0x21B0E48", VA = "0x7BBC9B0E48")]
		public CSCupTeamInvitationList()
		{
		}

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D19C", Offset = "0x110D19C")]
		public List<CupTeamInvitationRes> cup_team_invitation_list;
	}
}
