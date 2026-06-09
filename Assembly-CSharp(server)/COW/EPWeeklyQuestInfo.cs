using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CC9 RID: 7369
	[Token(Token = "0x2001CC9")]
	public class EPWeeklyQuestInfo
	{
		// Token: 0x0600A0C3 RID: 41155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C3")]
		[Address(RVA = "0x16164F8", Offset = "0x16164F8", VA = "0x7BBBE164F8")]
		public EPWeeklyQuestInfo()
		{
		}

		// Token: 0x0400A789 RID: 42889
		[Token(Token = "0x400A789")]
		[FieldOffset(Offset = "0x10")]
		public EPWeeklyQuestData weeklyQuestData;

		// Token: 0x0400A78A RID: 42890
		[Token(Token = "0x400A78A")]
		[FieldOffset(Offset = "0x18")]
		public ChallengeStatus status;

		// Token: 0x0400A78B RID: 42891
		[Token(Token = "0x400A78B")]
		[FieldOffset(Offset = "0x20")]
		public bool isLock;
	}
}
