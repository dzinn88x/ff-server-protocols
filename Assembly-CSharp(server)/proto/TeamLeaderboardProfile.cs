using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	[ProtoContract]
	public class TeamLeaderboardProfile
	{
		// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x24A0E18", Offset = "0x24A0E18", VA = "0x7BBCCA0E18")]
		public TeamLeaderboardProfile()
		{
		}

		// Token: 0x0400248F RID: 9359
		[Token(Token = "0x400248F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C7EC", Offset = "0x110C7EC")]
		public TeamInfo team_info;

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C800", Offset = "0x110C800")]
		public TeamChampionshipInfo team_championship_info;

		// Token: 0x04002491 RID: 9361
		[Token(Token = "0x4002491")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110C814", Offset = "0x110C814")]
		public CSTeamChampionshipSeasonStatsRes team_stats;
	}
}
