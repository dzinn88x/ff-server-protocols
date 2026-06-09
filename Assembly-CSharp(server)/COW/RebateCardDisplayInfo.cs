using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FCF RID: 8143
	[Token(Token = "0x2001FCF")]
	public class RebateCardDisplayInfo
	{
		// Token: 0x0600B4A4 RID: 46244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4A4")]
		[Address(RVA = "0x1750EF4", Offset = "0x1750EF4", VA = "0x7BBBF50EF4")]
		public RebateCardDisplayInfo()
		{
		}

		// Token: 0x0400B706 RID: 46854
		[Token(Token = "0x400B706")]
		[FieldOffset(Offset = "0x10")]
		public Color BgColor;

		// Token: 0x0400B707 RID: 46855
		[Token(Token = "0x400B707")]
		[FieldOffset(Offset = "0x20")]
		public string SubscriptionPeriodTextKey;

		// Token: 0x0400B708 RID: 46856
		[Token(Token = "0x400B708")]
		[FieldOffset(Offset = "0x28")]
		public string Subscription_TitleKey;

		// Token: 0x0400B709 RID: 46857
		[Token(Token = "0x400B709")]
		[FieldOffset(Offset = "0x30")]
		public string Subscription_BenefitKey;

		// Token: 0x0400B70A RID: 46858
		[Token(Token = "0x400B70A")]
		[FieldOffset(Offset = "0x38")]
		public string ConfirmBeforeSubscribe_TitleKey;

		// Token: 0x0400B70B RID: 46859
		[Token(Token = "0x400B70B")]
		[FieldOffset(Offset = "0x40")]
		public string ConfirmBeforeSubscribe_TextKey;

		// Token: 0x0400B70C RID: 46860
		[Token(Token = "0x400B70C")]
		[FieldOffset(Offset = "0x48")]
		public string ConfirmBeforeSubscribe_LegalKey;

		// Token: 0x0400B70D RID: 46861
		[Token(Token = "0x400B70D")]
		[FieldOffset(Offset = "0x50")]
		public string NotifyAfterSubscribe_SuccessKey;

		// Token: 0x0400B70E RID: 46862
		[Token(Token = "0x400B70E")]
		[FieldOffset(Offset = "0x58")]
		public string PurchaseWhileSubscribed_TipsKey;

		// Token: 0x0400B70F RID: 46863
		[Token(Token = "0x400B70F")]
		[FieldOffset(Offset = "0x60")]
		public string NotSubscribed_CheckBoxTextKey;

		// Token: 0x0400B710 RID: 46864
		[Token(Token = "0x400B710")]
		[FieldOffset(Offset = "0x68")]
		public string Subscribed_CheckBoxTextKey;

		// Token: 0x0400B711 RID: 46865
		[Token(Token = "0x400B711")]
		[FieldOffset(Offset = "0x70")]
		public string Subscription_LastPaymentTimeKey;

		// Token: 0x0400B712 RID: 46866
		[Token(Token = "0x400B712")]
		[FieldOffset(Offset = "0x78")]
		public string Subscription_NextPaymentTimeKey;

		// Token: 0x0400B713 RID: 46867
		[Token(Token = "0x400B713")]
		[FieldOffset(Offset = "0x80")]
		public string HasReadSubscriptionHintPrefKey;

		// Token: 0x0400B714 RID: 46868
		[Token(Token = "0x400B714")]
		[FieldOffset(Offset = "0x88")]
		public string ExtraItemKey;

		// Token: 0x0400B715 RID: 46869
		[Token(Token = "0x400B715")]
		[FieldOffset(Offset = "0x90")]
		public string InstantDiamondsKey;

		// Token: 0x0400B716 RID: 46870
		[Token(Token = "0x400B716")]
		[FieldOffset(Offset = "0x98")]
		public string DailyAndTotalDiamondsKey;

		// Token: 0x0400B717 RID: 46871
		[Token(Token = "0x400B717")]
		[FieldOffset(Offset = "0xA0")]
		public string RebateRateKey;

		// Token: 0x0400B718 RID: 46872
		[Token(Token = "0x400B718")]
		[FieldOffset(Offset = "0xA8")]
		public string ResetTimeKey;

		// Token: 0x0400B719 RID: 46873
		[Token(Token = "0x400B719")]
		[FieldOffset(Offset = "0xB0")]
		public string VipCardKey;

		// Token: 0x0400B71A RID: 46874
		[Token(Token = "0x400B71A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<RebateCardType, RebateCardDisplayInfo> Infos;
	}
}
