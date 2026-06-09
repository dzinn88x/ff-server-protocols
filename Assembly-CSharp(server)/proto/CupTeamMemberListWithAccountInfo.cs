using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	[ProtoContract]
	public class CupTeamMemberListWithAccountInfo
	{
		// Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x21B9348", Offset = "0x21B9348", VA = "0x7BBC9B9348")]
		public CupTeamMemberListWithAccountInfo()
		{
		}

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D304", Offset = "0x110D304")]
		public List<CupTeamMemberWithAccountInfo> member_list;
	}
}
