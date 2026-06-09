using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005A4 RID: 1444
	[Token(Token = "0x20005A4")]
	[ProtoContract]
	public class ELeaderboard
	{
		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x21B9838", Offset = "0x21B9838", VA = "0x7BBC9B9838")]
		public ELeaderboard()
		{
		}

		// Token: 0x020005A5 RID: 1445
		[Token(Token = "0x20005A5")]
		[ProtoContract]
		public enum LeaderboardMainType
		{
			// Token: 0x04001C9B RID: 7323
			[Token(Token = "0x4001C9B")]
			Leaderboard_REGULAR,
			// Token: 0x04001C9C RID: 7324
			[Token(Token = "0x4001C9C")]
			Leaderboard_RANKING_SCORE,
			// Token: 0x04001C9D RID: 7325
			[Token(Token = "0x4001C9D")]
			Leaderboard_RANKING_KILLS,
			// Token: 0x04001C9E RID: 7326
			[Token(Token = "0x4001C9E")]
			Leaderboard_RANKING_WIN_COUNT,
			// Token: 0x04001C9F RID: 7327
			[Token(Token = "0x4001C9F")]
			Leaderboard_CASUAL_KILLS,
			// Token: 0x04001CA0 RID: 7328
			[Token(Token = "0x4001CA0")]
			Leaderboard_CASUAL_WIN_COUNT,
			// Token: 0x04001CA1 RID: 7329
			[Token(Token = "0x4001CA1")]
			Leaderboard_ELITEPASS_BADGE,
			// Token: 0x04001CA2 RID: 7330
			[Token(Token = "0x4001CA2")]
			Leaderboard_GIFT_STORE,
			// Token: 0x04001CA3 RID: 7331
			[Token(Token = "0x4001CA3")]
			Leaderboard_CHAMPIONSHIP_TRIAL_SCORE,
			// Token: 0x04001CA4 RID: 7332
			[Token(Token = "0x4001CA4")]
			Leaderboard_CHAMPIONSHIP_TRIAL_KILLS,
			// Token: 0x04001CA5 RID: 7333
			[Token(Token = "0x4001CA5")]
			Leaderboard_LIMITED_EVENT,
			// Token: 0x04001CA6 RID: 7334
			[Token(Token = "0x4001CA6")]
			Leaderboard_CS_RANKING_KILLS,
			// Token: 0x04001CA7 RID: 7335
			[Token(Token = "0x4001CA7")]
			Leaderboard_CS_RANKING_WINS,
			// Token: 0x04001CA8 RID: 7336
			[Token(Token = "0x4001CA8")]
			Leaderboard_CS_RANKING_SCORE,
			// Token: 0x04001CA9 RID: 7337
			[Token(Token = "0x4001CA9")]
			Leaderboard_CLAN_HONOR = 1001,
			// Token: 0x04001CAA RID: 7338
			[Token(Token = "0x4001CAA")]
			Leaderboard_CLAN_HONOR_WEEK,
			// Token: 0x04001CAB RID: 7339
			[Token(Token = "0x4001CAB")]
			Leaderboard_CLAN_RACE
		}
	}
}
