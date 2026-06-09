using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CC6 RID: 7366
	[Token(Token = "0x2001CC6")]
	public class EPChallengeInfo
	{
		// Token: 0x0600A0C0 RID: 41152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C0")]
		[Address(RVA = "0x160D644", Offset = "0x160D644", VA = "0x7BBBE0D644")]
		public EPChallengeInfo()
		{
		}

		// Token: 0x0400A781 RID: 42881
		[Token(Token = "0x400A781")]
		[FieldOffset(Offset = "0x10")]
		public EPChallengeData challengeData;

		// Token: 0x0400A782 RID: 42882
		[Token(Token = "0x400A782")]
		[FieldOffset(Offset = "0x18")]
		public ChallengeStatus status;

		// Token: 0x0400A783 RID: 42883
		[Token(Token = "0x400A783")]
		[FieldOffset(Offset = "0x20")]
		public bool isUnlocked;
	}
}
