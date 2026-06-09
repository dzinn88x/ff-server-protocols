using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	[ProtoContract]
	public class CSGetBooyahDayLeaderboardAwardDescRes
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002684")]
		[Address(RVA = "0x21B276C", Offset = "0x21B276C", VA = "0x7BBC9B276C")]
		public CSGetBooyahDayLeaderboardAwardDescRes()
		{
		}

		// Token: 0x04002C12 RID: 11282
		[Token(Token = "0x4002C12")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111994C", Offset = "0x111994C")]
		public List<BooyahDayLeaderboardRewardDesc> game_leaderboard_awards;

		// Token: 0x04002C13 RID: 11283
		[Token(Token = "0x4002C13")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119960", Offset = "0x1119960")]
		public List<BooyahDayLeaderboardRewardDesc> chess_leaderboard_awards;
	}
}
