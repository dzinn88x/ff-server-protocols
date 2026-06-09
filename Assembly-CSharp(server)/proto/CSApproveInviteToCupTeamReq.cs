using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	[ProtoContract]
	public class CSApproveInviteToCupTeamReq
	{
		// Token: 0x06002463 RID: 9315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x21B0418", Offset = "0x21B0418", VA = "0x7BBC9B0418")]
		public CSApproveInviteToCupTeamReq()
		{
		}

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D174", Offset = "0x110D174")]
		public ulong team_id;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D188", Offset = "0x110D188")]
		public ulong inviter_id;
	}
}
