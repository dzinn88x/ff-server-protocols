using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	[ProtoContract]
	public class CSCupTeamApplicantList
	{
		// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x21B0DC4", Offset = "0x21B0DC4", VA = "0x7BBC9B0DC4")]
		public CSCupTeamApplicantList()
		{
		}

		// Token: 0x040024F6 RID: 9462
		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D23C", Offset = "0x110D23C")]
		public List<CupTeamApplicantRes> cup_team_applicant_list;
	}
}
