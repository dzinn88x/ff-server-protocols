using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001FD0 RID: 8144
	[Token(Token = "0x2001FD0")]
	public class RebateCardInfo
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600B4A6 RID: 46246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C37")]
		public PayItemData SubscriptionProductFromCSV
		{
			[Token(Token = "0x600B4A6")]
			[Address(RVA = "0x17516D0", Offset = "0x17516D0", VA = "0x7BBBF516D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4A7")]
		[Address(RVA = "0x17516D8", Offset = "0x17516D8", VA = "0x7BBBF516D8")]
		public RebateCardInfo(RebateCardType type)
		{
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4A8")]
		[Address(RVA = "0x1751A78", Offset = "0x1751A78", VA = "0x7BBBF51A78")]
		public void UpdateDynamicData(RebateItemData rebateItemData)
		{
		}

		// Token: 0x0400B71B RID: 46875
		[Token(Token = "0x400B71B")]
		[FieldOffset(Offset = "0x10")]
		public RebateCardInfo.ELocalizedPriceStatus PriceStatus;

		// Token: 0x0400B71C RID: 46876
		[Token(Token = "0x400B71C")]
		[FieldOffset(Offset = "0x14")]
		public RebateCardInfo.ELocalizedPriceStatus SubscriptionPriceStatus;

		// Token: 0x0400B71D RID: 46877
		[Token(Token = "0x400B71D")]
		[FieldOffset(Offset = "0x18")]
		public RebateCardData CardInfo;

		// Token: 0x0400B71E RID: 46878
		[Token(Token = "0x400B71E")]
		[FieldOffset(Offset = "0x20")]
		public bool Owned;

		// Token: 0x0400B71F RID: 46879
		[Token(Token = "0x400B71F")]
		[FieldOffset(Offset = "0x21")]
		public bool Valid_To_Redeem;

		// Token: 0x0400B720 RID: 46880
		[Token(Token = "0x400B720")]
		[FieldOffset(Offset = "0x22")]
		public bool Valid_To_Purchase;

		// Token: 0x0400B721 RID: 46881
		[Token(Token = "0x400B721")]
		[FieldOffset(Offset = "0x24")]
		public int Remaining_Days;

		// Token: 0x0400B722 RID: 46882
		[Token(Token = "0x400B722")]
		[FieldOffset(Offset = "0x28")]
		public ulong TimeSpan_To_NextRedeem;

		// Token: 0x0400B723 RID: 46883
		[Token(Token = "0x400B723")]
		[FieldOffset(Offset = "0x30")]
		public RebateCardType Type;

		// Token: 0x0400B724 RID: 46884
		[Token(Token = "0x400B724")]
		[FieldOffset(Offset = "0x38")]
		public string CDN_URL;

		// Token: 0x0400B725 RID: 46885
		[Token(Token = "0x400B725")]
		[FieldOffset(Offset = "0x40")]
		private PayItemData _SubscriptionProductFromCSV;

		// Token: 0x02001FD1 RID: 8145
		[Token(Token = "0x2001FD1")]
		public enum ELocalizedPriceStatus
		{
			// Token: 0x0400B727 RID: 46887
			[Token(Token = "0x400B727")]
			Unloaded,
			// Token: 0x0400B728 RID: 46888
			[Token(Token = "0x400B728")]
			Loading,
			// Token: 0x0400B729 RID: 46889
			[Token(Token = "0x400B729")]
			Loaded
		}
	}
}
