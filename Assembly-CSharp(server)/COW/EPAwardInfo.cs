using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CC5 RID: 7365
	[Token(Token = "0x2001CC5")]
	internal class EPAwardInfo
	{
		// Token: 0x0600A0BD RID: 41149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0BD")]
		[Address(RVA = "0x160BEF0", Offset = "0x160BEF0", VA = "0x7BBBE0BEF0")]
		public EPAwardInfo(EPUnlockData data)
		{
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0BE")]
		[Address(RVA = "0x160BF20", Offset = "0x160BF20", VA = "0x7BBBE0BF20")]
		public EPAwardInfo(EPMaxAwardInfoType type)
		{
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Token(Token = "0x600A0BF")]
		[Address(RVA = "0x160BF50", Offset = "0x160BF50", VA = "0x7BBBE0BF50")]
		public bool hasNewReward()
		{
			return default(bool);
		}

		// Token: 0x0400A77D RID: 42877
		[Token(Token = "0x400A77D")]
		[FieldOffset(Offset = "0x10")]
		public EPUnlockData unlockData;

		// Token: 0x0400A77E RID: 42878
		[Token(Token = "0x400A77E")]
		[FieldOffset(Offset = "0x18")]
		public EPTarget_Status FPStatus;

		// Token: 0x0400A77F RID: 42879
		[Token(Token = "0x400A77F")]
		[FieldOffset(Offset = "0x1C")]
		public EPTarget_Status EPStatus;

		// Token: 0x0400A780 RID: 42880
		[Token(Token = "0x400A780")]
		[FieldOffset(Offset = "0x20")]
		public EPMaxAwardInfoType maxAwardType;
	}
}
