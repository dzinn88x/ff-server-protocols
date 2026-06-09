using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CCA RID: 7370
	[Token(Token = "0x2001CCA")]
	public class EPMonthlyQuestInfo
	{
		// Token: 0x0600A0C4 RID: 41156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C4")]
		[Address(RVA = "0x1610FE8", Offset = "0x1610FE8", VA = "0x7BBBE10FE8")]
		public EPMonthlyQuestInfo()
		{
		}

		// Token: 0x0400A78C RID: 42892
		[Token(Token = "0x400A78C")]
		[FieldOffset(Offset = "0x10")]
		public EPMonthlyQuestData monthlyQuestData;

		// Token: 0x0400A78D RID: 42893
		[Token(Token = "0x400A78D")]
		[FieldOffset(Offset = "0x18")]
		public ChallengeStatus status;
	}
}
