using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D9B RID: 7579
	[Token(Token = "0x2001D9B")]
	public class IntegrateGachaRewardItemData
	{
		// Token: 0x0600A5A2 RID: 42402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5A2")]
		[Address(RVA = "0x185FC18", Offset = "0x185FC18", VA = "0x7BBC05FC18")]
		public IntegrateGachaRewardItemData(BaseItemInfo itemInfo, string cnt, bool own, uint level, bool bigReward)
		{
		}

		// Token: 0x0400AB54 RID: 43860
		[Token(Token = "0x400AB54")]
		[FieldOffset(Offset = "0x10")]
		public BaseItemInfo baseItemInfo;

		// Token: 0x0400AB55 RID: 43861
		[Token(Token = "0x400AB55")]
		[FieldOffset(Offset = "0x18")]
		public string cntString;

		// Token: 0x0400AB56 RID: 43862
		[Token(Token = "0x400AB56")]
		[FieldOffset(Offset = "0x20")]
		public bool isOwned;

		// Token: 0x0400AB57 RID: 43863
		[Token(Token = "0x400AB57")]
		[FieldOffset(Offset = "0x24")]
		public uint rewardLevel;

		// Token: 0x0400AB58 RID: 43864
		[Token(Token = "0x400AB58")]
		[FieldOffset(Offset = "0x28")]
		public bool isBigReward;
	}
}
