using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008FD RID: 2301
	[Token(Token = "0x20008FD")]
	[ProtoContract]
	public class CSJoinTeamReq
	{
		// Token: 0x0600260B RID: 9739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600260B")]
		[Address(RVA = "0x21B65F0", Offset = "0x21B65F0", VA = "0x7BBC9B65F0")]
		public CSJoinTeamReq()
		{
		}

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117A70", Offset = "0x1117A70")]
		public ulong team_id;
	}
}
