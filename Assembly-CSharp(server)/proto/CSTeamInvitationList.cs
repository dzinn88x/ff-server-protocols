using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	[ProtoContract]
	public class CSTeamInvitationList
	{
		// Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x21B78B4", Offset = "0x21B78B4", VA = "0x7BBC9B78B4")]
		public CSTeamInvitationList()
		{
		}

		// Token: 0x04002AA3 RID: 10915
		[Token(Token = "0x4002AA3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117598", Offset = "0x1117598")]
		public List<TeamInvitationRes> team_invitation_list;
	}
}
