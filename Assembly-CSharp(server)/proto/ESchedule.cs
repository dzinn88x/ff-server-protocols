using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200069E RID: 1694
	[Token(Token = "0x200069E")]
	[ProtoContract]
	public class ESchedule
	{
		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x21B9B3C", Offset = "0x21B9B3C", VA = "0x7BBC9B9B3C")]
		public ESchedule()
		{
		}

		// Token: 0x0200069F RID: 1695
		[Token(Token = "0x200069F")]
		[ProtoContract]
		public enum TaskType
		{
			// Token: 0x04002137 RID: 8503
			[Token(Token = "0x4002137")]
			TaskType_NONE,
			// Token: 0x04002138 RID: 8504
			[Token(Token = "0x4002138")]
			TaskType_RANKING_SeasonTopAward,
			// Token: 0x04002139 RID: 8505
			[Token(Token = "0x4002139")]
			TaskType_CHAMPIONSHIP_CleanLeaderboard,
			// Token: 0x0400213A RID: 8506
			[Token(Token = "0x400213A")]
			TaskType_LIMITEDEVENT_BooyahLeaderboardAward,
			// Token: 0x0400213B RID: 8507
			[Token(Token = "0x400213B")]
			TaskType_RANKING_CleanLeaderboard,
			// Token: 0x0400213C RID: 8508
			[Token(Token = "0x400213C")]
			TaskType_CSRANKING_CleanLeaderboard
		}

		// Token: 0x020006A0 RID: 1696
		[Token(Token = "0x20006A0")]
		[ProtoContract]
		public enum TaskStatus
		{
			// Token: 0x0400213E RID: 8510
			[Token(Token = "0x400213E")]
			TaskStatus_NONE,
			// Token: 0x0400213F RID: 8511
			[Token(Token = "0x400213F")]
			TaskStatus_WAIT,
			// Token: 0x04002140 RID: 8512
			[Token(Token = "0x4002140")]
			TaskStatus_EXEC,
			// Token: 0x04002141 RID: 8513
			[Token(Token = "0x4002141")]
			TaskStatus_SUCC,
			// Token: 0x04002142 RID: 8514
			[Token(Token = "0x4002142")]
			TaskStatus_FAIL
		}
	}
}
