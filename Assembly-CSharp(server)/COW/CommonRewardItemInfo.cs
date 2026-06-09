using System;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001755 RID: 5973
	[Token(Token = "0x2001755")]
	public class CommonRewardItemInfo
	{
		// Token: 0x06007060 RID: 28768 RVA: 0x0001F758 File Offset: 0x0001D958
		[Token(Token = "0x6007060")]
		[Address(RVA = "0x15FC4A0", Offset = "0x15FC4A0", VA = "0x7BBBDFC4A0")]
		public static CommonRewardItemInfo.RewardLevel CalRewardLevelRange(uint level)
		{
			return CommonRewardItemInfo.RewardLevel.NONE;
		}

		// Token: 0x06007061 RID: 28769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007061")]
		[Address(RVA = "0x15FC4CC", Offset = "0x15FC4CC", VA = "0x7BBBDFC4CC")]
		public static implicit operator CommonRewardItemInfo(ExchangedAward awardItem)
		{
			return null;
		}

		// Token: 0x06007062 RID: 28770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007062")]
		[Address(RVA = "0x15FC610", Offset = "0x15FC610", VA = "0x7BBBDFC610")]
		public static implicit operator CommonRewardItemInfo(Item item)
		{
			return null;
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007063")]
		[Address(RVA = "0x15FC6C8", Offset = "0x15FC6C8", VA = "0x7BBBDFC6C8")]
		public static implicit operator CommonRewardItemInfo(BaseItemInfo itemInfo)
		{
			return null;
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007064")]
		[Address(RVA = "0x15FC750", Offset = "0x15FC750", VA = "0x7BBBDFC750")]
		public static implicit operator CommonRewardItemInfo(AwardItemInfo itemInfo)
		{
			return null;
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007065")]
		[Address(RVA = "0x15FC7D8", Offset = "0x15FC7D8", VA = "0x7BBBDFC7D8")]
		public static implicit operator CommonRewardItemInfo(OptionalBundleShowData itemInfo)
		{
			return null;
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x0001F770 File Offset: 0x0001D970
		[Token(Token = "0x6007066")]
		[Address(RVA = "0x15FC8AC", Offset = "0x15FC8AC", VA = "0x7BBBDFC8AC")]
		public bool CanExchang()
		{
			return default(bool);
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x0001F788 File Offset: 0x0001D988
		[Token(Token = "0x6007067")]
		[Address(RVA = "0x15FC8D4", Offset = "0x15FC8D4", VA = "0x7BBBDFC8D4")]
		public static Color GetColorByQuality(uint rare)
		{
			return default(Color);
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007068")]
		[Address(RVA = "0x15FC608", Offset = "0x15FC608", VA = "0x7BBBDFC608")]
		public CommonRewardItemInfo()
		{
		}

		// Token: 0x04008A38 RID: 35384
		[Token(Token = "0x4008A38")]
		[FieldOffset(Offset = "0x10")]
		public BaseItemInfo m_OriInfo;

		// Token: 0x04008A39 RID: 35385
		[Token(Token = "0x4008A39")]
		[FieldOffset(Offset = "0x18")]
		public BaseItemInfo m_EchInfo;

		// Token: 0x04008A3A RID: 35386
		[Token(Token = "0x4008A3A")]
		[FieldOffset(Offset = "0x20")]
		public uint m_Order;

		// Token: 0x04008A3B RID: 35387
		[Token(Token = "0x4008A3B")]
		[FieldOffset(Offset = "0x24")]
		public bool IsSpecialLegendToken;

		// Token: 0x04008A3C RID: 35388
		[Token(Token = "0x4008A3C")]
		[FieldOffset(Offset = "0x28")]
		public CommonRewardItemInfo.RewardLevel rewardLevel;

		// Token: 0x02001756 RID: 5974
		[Token(Token = "0x2001756")]
		public enum RewardLevel
		{
			// Token: 0x04008A3E RID: 35390
			[Token(Token = "0x4008A3E")]
			NONE,
			// Token: 0x04008A3F RID: 35391
			[Token(Token = "0x4008A3F")]
			FIRST,
			// Token: 0x04008A40 RID: 35392
			[Token(Token = "0x4008A40")]
			SECOND,
			// Token: 0x04008A41 RID: 35393
			[Token(Token = "0x4008A41")]
			THIRD,
			// Token: 0x04008A42 RID: 35394
			[Token(Token = "0x4008A42")]
			FOURTH,
			// Token: 0x04008A43 RID: 35395
			[Token(Token = "0x4008A43")]
			FIFTH
		}
	}
}
