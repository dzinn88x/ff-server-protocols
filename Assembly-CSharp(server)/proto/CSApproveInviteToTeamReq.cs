using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000902 RID: 2306
	[Token(Token = "0x2000902")]
	[ProtoContract]
	public class CSApproveInviteToTeamReq
	{
		// Token: 0x06002610 RID: 9744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x21B0420", Offset = "0x21B0420", VA = "0x7BBC9B0420")]
		public CSApproveInviteToTeamReq()
		{
		}

		// Token: 0x04002ACF RID: 10959
		[Token(Token = "0x4002ACF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B38", Offset = "0x1117B38")]
		public ulong inviter_id;

		// Token: 0x04002AD0 RID: 10960
		[Token(Token = "0x4002AD0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B4C", Offset = "0x1117B4C")]
		public ulong team_id;
	}
}
