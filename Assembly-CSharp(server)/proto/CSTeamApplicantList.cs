using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008F3 RID: 2291
	[Token(Token = "0x20008F3")]
	[ProtoContract]
	public class CSTeamApplicantList
	{
		// Token: 0x06002601 RID: 9729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002601")]
		[Address(RVA = "0x21B7730", Offset = "0x21B7730", VA = "0x7BBC9B7730")]
		public CSTeamApplicantList()
		{
		}

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117548", Offset = "0x1117548")]
		public List<TeamApplicantRes> team_applicant_list;
	}
}
