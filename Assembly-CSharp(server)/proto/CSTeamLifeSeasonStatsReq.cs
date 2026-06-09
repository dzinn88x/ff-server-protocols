using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000919 RID: 2329
	[Token(Token = "0x2000919")]
	[ProtoContract]
	public class CSTeamLifeSeasonStatsReq
	{
		// Token: 0x06002627 RID: 9767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002627")]
		[Address(RVA = "0x21B799C", Offset = "0x21B799C", VA = "0x7BBC9B799C")]
		public CSTeamLifeSeasonStatsReq()
		{
		}

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11185D8", Offset = "0x11185D8")]
		public ulong team_id;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11185EC", Offset = "0x11185EC")]
		public uint championship_type;
	}
}
