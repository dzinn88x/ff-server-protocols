using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	[ProtoContract]
	public class CSDeclineInviteToCupTeamReq
	{
		// Token: 0x06002462 RID: 9314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x21B0EBC", Offset = "0x21B0EBC", VA = "0x7BBC9B0EBC")]
		public CSDeclineInviteToCupTeamReq()
		{
		}

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D138", Offset = "0x110D138")]
		public ulong[] inviter_ids;
	}
}
