using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D3E RID: 7486
	[Token(Token = "0x2001D3E")]
	public class ActivenessInfo
	{
		// Token: 0x0600A2BB RID: 41659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A2BB")]
		[Address(RVA = "0x1F98874", Offset = "0x1F98874", VA = "0x7BBC798874")]
		public ActivenessInfo()
		{
		}

		// Token: 0x0400A959 RID: 43353
		[Token(Token = "0x400A959")]
		[FieldOffset(Offset = "0x10")]
		public uint group_id;

		// Token: 0x0400A95A RID: 43354
		[Token(Token = "0x400A95A")]
		[FieldOffset(Offset = "0x14")]
		public uint obtain_daily_activeness;

		// Token: 0x0400A95B RID: 43355
		[Token(Token = "0x400A95B")]
		[FieldOffset(Offset = "0x18")]
		public uint obtain_weekly_activeness;

		// Token: 0x0400A95C RID: 43356
		[Token(Token = "0x400A95C")]
		[FieldOffset(Offset = "0x1C")]
		public uint last_daily_reward_need_activeness;

		// Token: 0x0400A95D RID: 43357
		[Token(Token = "0x400A95D")]
		[FieldOffset(Offset = "0x20")]
		public uint weekly_reward_need_activeness;
	}
}
