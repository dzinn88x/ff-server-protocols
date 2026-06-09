using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D9A RID: 7578
	[Token(Token = "0x2001D9A")]
	public class IntegrateRewardLevelInfo
	{
		// Token: 0x0600A5A1 RID: 42401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5A1")]
		[Address(RVA = "0x185FD20", Offset = "0x185FD20", VA = "0x7BBC05FD20")]
		public IntegrateRewardLevelInfo()
		{
		}

		// Token: 0x0400AB52 RID: 43858
		[Token(Token = "0x400AB52")]
		[FieldOffset(Offset = "0x10")]
		public CommonRewardItemInfo.RewardLevel RewardLevel;

		// Token: 0x0400AB53 RID: 43859
		[Token(Token = "0x400AB53")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<IntegrateRewardItemID, List<GachaShowItem>> RewardInfoList;
	}
}
