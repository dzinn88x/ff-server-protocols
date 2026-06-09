using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BA7 RID: 7079
	[Token(Token = "0x2001BA7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA98C", Offset = "0x10FA98C")]
	public class UISubscriptionPreviewWindowController : UIPopupWindowController
	{
		// Token: 0x060098CA RID: 39114 RVA: 0x000283E0 File Offset: 0x000265E0
		[Token(Token = "0x60098CA")]
		[Address(RVA = "0x2139F78", Offset = "0x2139F78", VA = "0x7BBC939F78")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098CB")]
		[Address(RVA = "0x2139FC8", Offset = "0x2139FC8", VA = "0x7BBC939FC8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098CC")]
		[Address(RVA = "0x213A214", Offset = "0x213A214", VA = "0x7BBC93A214")]
		private void SetLegalTexts()
		{
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098CD")]
		[Address(RVA = "0x213A5D8", Offset = "0x213A5D8", VA = "0x7BBC93A5D8")]
		public void SetDisplayInfo(UISubscriptionPreviewWindowController.DisplayInfo info)
		{
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098CE")]
		[Address(RVA = "0x213A658", Offset = "0x213A658", VA = "0x7BBC93A658")]
		private void UpdateDescLabel()
		{
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098CF")]
		[Address(RVA = "0x213A850", Offset = "0x213A850", VA = "0x7BBC93A850")]
		private void UpdateIcon()
		{
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D0")]
		[Address(RVA = "0x213ABBC", Offset = "0x213ABBC", VA = "0x7BBC93ABBC")]
		private void UpdateBonus()
		{
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D1")]
		[Address(RVA = "0x213B1EC", Offset = "0x213B1EC", VA = "0x7BBC93B1EC")]
		private void UpdatePeriodLabel(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D2")]
		[Address(RVA = "0x213AF00", Offset = "0x213AF00", VA = "0x7BBC93AF00")]
		private void GetProduct(out PayItemData csv, out PayItemData sdk)
		{
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D3")]
		[Address(RVA = "0x213B118", Offset = "0x213B118", VA = "0x7BBC93B118")]
		private void UpdatePriceLabel(PayItemData csv, PayItemData sdk)
		{
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D4")]
		[Address(RVA = "0x213B384", Offset = "0x213B384", VA = "0x7BBC93B384", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D5")]
		[Address(RVA = "0x213B3AC", Offset = "0x213B3AC", VA = "0x7BBC93B3AC")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D6")]
		[Address(RVA = "0x213B3B4", Offset = "0x213B3B4", VA = "0x7BBC93B3B4")]
		private void OnBtnSubscribeClick()
		{
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D7")]
		[Address(RVA = "0x213B790", Offset = "0x213B790", VA = "0x7BBC93B790")]
		private void OnBtnTermsOfServiceClick()
		{
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D8")]
		[Address(RVA = "0x213B798", Offset = "0x213B798", VA = "0x7BBC93B798")]
		private void OnBtnPrivacyPolicyClick()
		{
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60098D9")]
		[Address(RVA = "0x213B7A0", Offset = "0x213B7A0", VA = "0x7BBC93B7A0")]
		public UISubscriptionPreviewWindowController()
		{
		}

		// Token: 0x0400A067 RID: 41063
		[Token(Token = "0x400A067")]
		[FieldOffset(Offset = "0x98")]
		private UISubscriptionPreviewWindowView m_View;

		// Token: 0x0400A068 RID: 41064
		[Token(Token = "0x400A068")]
		[FieldOffset(Offset = "0xA0")]
		private UISubscriptionPreviewWindowController.DisplayInfo m_DisplayInfo;

		// Token: 0x0400A069 RID: 41065
		[Token(Token = "0x400A069")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelPayment m_Payment;

		// Token: 0x0400A06A RID: 41066
		[Token(Token = "0x400A06A")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelRebateCard m_RebateCard;

		// Token: 0x0400A06B RID: 41067
		[Token(Token = "0x400A06B")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelElitePass m_ElitePass;

		// Token: 0x02001BA8 RID: 7080
		[Token(Token = "0x2001BA8")]
		public enum DisplayType
		{
			// Token: 0x0400A06D RID: 41069
			[Token(Token = "0x400A06D")]
			None,
			// Token: 0x0400A06E RID: 41070
			[Token(Token = "0x400A06E")]
			RebateCard,
			// Token: 0x0400A06F RID: 41071
			[Token(Token = "0x400A06F")]
			ElitePass,
			// Token: 0x0400A070 RID: 41072
			[Token(Token = "0x400A070")]
			Bundle
		}

		// Token: 0x02001BA9 RID: 7081
		[Token(Token = "0x2001BA9")]
		public class DisplayInfo
		{
			// Token: 0x060098DA RID: 39130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60098DA")]
			[Address(RVA = "0x213B7A8", Offset = "0x213B7A8", VA = "0x7BBC93B7A8")]
			public DisplayInfo()
			{
			}

			// Token: 0x0400A071 RID: 41073
			[Token(Token = "0x400A071")]
			[FieldOffset(Offset = "0x10")]
			public UISubscriptionPreviewWindowController.DisplayType Type;

			// Token: 0x0400A072 RID: 41074
			[Token(Token = "0x400A072")]
			[FieldOffset(Offset = "0x14")]
			public RebateCardType? RebateCardType;

			// Token: 0x0400A073 RID: 41075
			[Token(Token = "0x400A073")]
			[FieldOffset(Offset = "0x1C")]
			public uint BundleID;
		}
	}
}
