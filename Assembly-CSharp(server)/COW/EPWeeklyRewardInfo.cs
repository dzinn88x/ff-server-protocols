using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CCB RID: 7371
	[Token(Token = "0x2001CCB")]
	public class EPWeeklyRewardInfo
	{
		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C5")]
		[Address(RVA = "0x1616D60", Offset = "0x1616D60", VA = "0x7BBBE16D60")]
		public EPWeeklyRewardInfo()
		{
		}

		// Token: 0x0400A78E RID: 42894
		[Token(Token = "0x400A78E")]
		[FieldOffset(Offset = "0x10")]
		public EPWeeklyQuestRewardData weeklyQuestRewardData;

		// Token: 0x0400A78F RID: 42895
		[Token(Token = "0x400A78F")]
		[FieldOffset(Offset = "0x18")]
		public EPProcess_Status status;
	}
}
