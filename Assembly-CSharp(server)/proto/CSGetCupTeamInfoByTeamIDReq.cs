using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000748 RID: 1864
	[Token(Token = "0x2000748")]
	[ProtoContract]
	public class CSGetCupTeamInfoByTeamIDReq
	{
		// Token: 0x06002455 RID: 9301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x21B2EC0", Offset = "0x21B2EC0", VA = "0x7BBC9B2EC0")]
		public CSGetCupTeamInfoByTeamIDReq()
		{
		}

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110CE7C", Offset = "0x110CE7C")]
		public ulong team_id;
	}
}
