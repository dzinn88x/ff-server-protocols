using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000905 RID: 2309
	[Token(Token = "0x2000905")]
	[ProtoContract]
	public class CSQuitTeamReq
	{
		// Token: 0x06002613 RID: 9747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x21B7008", Offset = "0x21B7008", VA = "0x7BBC9B7008")]
		public CSQuitTeamReq()
		{
		}

		// Token: 0x04002AD4 RID: 10964
		[Token(Token = "0x4002AD4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117BC4", Offset = "0x1117BC4")]
		public ulong team_id;
	}
}
