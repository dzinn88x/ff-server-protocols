using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x200074F")]
	[ProtoContract]
	public class CSInviteToCupTeamReq
	{
		// Token: 0x0600245C RID: 9308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x21B65C0", Offset = "0x21B65C0", VA = "0x7BBC9B65C0")]
		public CSInviteToCupTeamReq()
		{
		}

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CFBC", Offset = "0x110CFBC")]
		public ulong team_id;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CFD0", Offset = "0x110CFD0")]
		public ulong invitee_id;
	}
}
