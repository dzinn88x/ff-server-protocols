using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000918 RID: 2328
	[Token(Token = "0x2000918")]
	[ProtoContract]
	public class CSTeamLifeSeasonStats
	{
		// Token: 0x06002626 RID: 9766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002626")]
		[Address(RVA = "0x21B7928", Offset = "0x21B7928", VA = "0x7BBC9B7928")]
		public CSTeamLifeSeasonStats()
		{
		}

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111859C", Offset = "0x111859C")]
		public ulong team_id;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11185B0", Offset = "0x11185B0")]
		public uint championship_type;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11185C4", Offset = "0x11185C4")]
		public List<TeamSeasonStats> stats;
	}
}
