using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	[ProtoContract]
	public class CSApproveJoinCupTeamApplicationReq
	{
		// Token: 0x0600245A RID: 9306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x21B0430", Offset = "0x21B0430", VA = "0x7BBC9B0430")]
		public CSApproveJoinCupTeamApplicationReq()
		{
		}

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF44", Offset = "0x110CF44")]
		public ulong applicant_id;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CF58", Offset = "0x110CF58")]
		public ulong team_id;
	}
}
