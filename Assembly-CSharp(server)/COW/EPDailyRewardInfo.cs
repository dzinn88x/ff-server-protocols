using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CC7 RID: 7367
	[Token(Token = "0x2001CC7")]
	public class EPDailyRewardInfo
	{
		// Token: 0x0600A0C1 RID: 41153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A0C1")]
		[Address(RVA = "0x160EF04", Offset = "0x160EF04", VA = "0x7BBBE0EF04")]
		public EPDailyRewardInfo()
		{
		}

		// Token: 0x0400A784 RID: 42884
		[Token(Token = "0x400A784")]
		[FieldOffset(Offset = "0x10")]
		public EPDailyRewardData dailyRewardData;

		// Token: 0x0400A785 RID: 42885
		[Token(Token = "0x400A785")]
		[FieldOffset(Offset = "0x18")]
		public EPTarget_Status status;
	}
}
