using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007D7 RID: 2007
	[Token(Token = "0x20007D7")]
	[ProtoContract]
	public class CSClanApplicantList
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E6")]
		[Address(RVA = "0x21B094C", Offset = "0x21B094C", VA = "0x7BBC9B094C")]
		public CSClanApplicantList()
		{
		}

		// Token: 0x0400265F RID: 9823
		[Token(Token = "0x400265F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110FADC", Offset = "0x110FADC")]
		public List<ClanApplicantRes> clan_applicant_list;
	}
}
