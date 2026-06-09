using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CC8 RID: 7368
	[Token(Token = "0x2001CC8")]
	public class EPDailyQuestInfo
	{
		// Token: 0x0600A0C2 RID: 41154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C2")]
		[Address(RVA = "0x160EA00", Offset = "0x160EA00", VA = "0x7BBBE0EA00")]
		public EPDailyQuestInfo()
		{
		}

		// Token: 0x0400A786 RID: 42886
		[Token(Token = "0x400A786")]
		[FieldOffset(Offset = "0x10")]
		public EPDailyQuestData dailyQuestData;

		// Token: 0x0400A787 RID: 42887
		[Token(Token = "0x400A787")]
		[FieldOffset(Offset = "0x18")]
		public ChallengeStatus status;

		// Token: 0x0400A788 RID: 42888
		[Token(Token = "0x400A788")]
		[FieldOffset(Offset = "0x20")]
		public bool isNewFinish;
	}
}
