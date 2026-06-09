using System;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D99 RID: 7577
	[Token(Token = "0x2001D99")]
	public struct IntegrateRewardItemID
	{
		// Token: 0x0600A5A0 RID: 42400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A5A0")]
		[Address(RVA = "0x11F0608", Offset = "0x11F0608", VA = "0x7BBB9F0608")]
		public IntegrateRewardItemID(GachaShowItem ItemInfo)
		{
		}

		// Token: 0x0400AB4D RID: 43853
		[Token(Token = "0x400AB4D")]
		[FieldOffset(Offset = "0x0")]
		public uint ItemID;

		// Token: 0x0400AB4E RID: 43854
		[Token(Token = "0x400AB4E")]
		[FieldOffset(Offset = "0x4")]
		public EInventory.AwardType awardType;

		// Token: 0x0400AB4F RID: 43855
		[Token(Token = "0x400AB4F")]
		[FieldOffset(Offset = "0x8")]
		public uint Count;

		// Token: 0x0400AB50 RID: 43856
		[Token(Token = "0x400AB50")]
		[FieldOffset(Offset = "0xC")]
		public uint RewardLevel;

		// Token: 0x0400AB51 RID: 43857
		[Token(Token = "0x400AB51")]
		[FieldOffset(Offset = "0x10")]
		public uint Duration;
	}
}
