using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000901 RID: 2305
	[Token(Token = "0x2000901")]
	[ProtoContract]
	public class CSInviteToTeamReq
	{
		// Token: 0x0600260F RID: 9743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x21B65C8", Offset = "0x21B65C8", VA = "0x7BBC9B65C8")]
		public CSInviteToTeamReq()
		{
		}

		// Token: 0x04002ACD RID: 10957
		[Token(Token = "0x4002ACD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B10", Offset = "0x1117B10")]
		public ulong invitee_id;

		// Token: 0x04002ACE RID: 10958
		[Token(Token = "0x4002ACE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117B24", Offset = "0x1117B24")]
		public ulong team_id;
	}
}
