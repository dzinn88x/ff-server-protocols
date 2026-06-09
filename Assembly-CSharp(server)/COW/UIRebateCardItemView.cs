using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C8 RID: 9416
	[Token(Token = "0x20024C8")]
	public class UIRebateCardItemView : UIBaseView
	{
		// Token: 0x0600C4A0 RID: 50336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A0")]
		[Address(RVA = "0x1E175C8", Offset = "0x1E175C8", VA = "0x7BBC6175C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A1")]
		[Address(RVA = "0x1E18004", Offset = "0x1E18004", VA = "0x7BBC618004")]
		public UIRebateCardItemView()
		{
		}

		// Token: 0x0400EF75 RID: 61301
		[Token(Token = "0x400EF75")]
		[FieldOffset(Offset = "0x20")]
		public GameObject MonthCardBg;

		// Token: 0x0400EF76 RID: 61302
		[Token(Token = "0x400EF76")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WeekCardBg;

		// Token: 0x0400EF77 RID: 61303
		[Token(Token = "0x400EF77")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RedeemContainer;

		// Token: 0x0400EF78 RID: 61304
		[Token(Token = "0x400EF78")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RedeemButton_RebateCardTint;

		// Token: 0x0400EF79 RID: 61305
		[Token(Token = "0x400EF79")]
		[FieldOffset(Offset = "0x40")]
		public GameObject OwnedDays;

		// Token: 0x0400EF7A RID: 61306
		[Token(Token = "0x400EF7A")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OwnedDaysLabel;

		// Token: 0x0400EF7B RID: 61307
		[Token(Token = "0x400EF7B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel RebateCardNameLabel;

		// Token: 0x0400EF7C RID: 61308
		[Token(Token = "0x400EF7C")]
		[FieldOffset(Offset = "0x58")]
		public UISprite LeftTopSprite_RebateCardTint;

		// Token: 0x0400EF7D RID: 61309
		[Token(Token = "0x400EF7D")]
		[FieldOffset(Offset = "0x60")]
		public UISprite RightTopSprite;

		// Token: 0x0400EF7E RID: 61310
		[Token(Token = "0x400EF7E")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RebateRateLabel;

		// Token: 0x0400EF7F RID: 61311
		[Token(Token = "0x400EF7F")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RightBottomSprite;

		// Token: 0x0400EF80 RID: 61312
		[Token(Token = "0x400EF80")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget BuyInfoContainer;

		// Token: 0x0400EF81 RID: 61313
		[Token(Token = "0x400EF81")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget RebateInfo;

		// Token: 0x0400EF82 RID: 61314
		[Token(Token = "0x400EF82")]
		[FieldOffset(Offset = "0x88")]
		public UIButton GracePeriodButton;

		// Token: 0x0400EF83 RID: 61315
		[Token(Token = "0x400EF83")]
		[FieldOffset(Offset = "0x90")]
		public GameObject AccountHold;

		// Token: 0x0400EF84 RID: 61316
		[Token(Token = "0x400EF84")]
		[FieldOffset(Offset = "0x98")]
		public UIButton FixOnHoldButton;

		// Token: 0x0400EF85 RID: 61317
		[Token(Token = "0x400EF85")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Effect_Diamond;

		// Token: 0x0400EF86 RID: 61318
		[Token(Token = "0x400EF86")]
		[FieldOffset(Offset = "0xA8")]
		public UIWidget RedeemAmount;

		// Token: 0x0400EF87 RID: 61319
		[Token(Token = "0x400EF87")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel RedeemAmountLabel;

		// Token: 0x0400EF88 RID: 61320
		[Token(Token = "0x400EF88")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite TotalAmount;

		// Token: 0x0400EF89 RID: 61321
		[Token(Token = "0x400EF89")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel TotalAmountLabel;

		// Token: 0x0400EF8A RID: 61322
		[Token(Token = "0x400EF8A")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite WeekCardSprite;

		// Token: 0x0400EF8B RID: 61323
		[Token(Token = "0x400EF8B")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite MonthCardSprite;

		// Token: 0x0400EF8C RID: 61324
		[Token(Token = "0x400EF8C")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnPurchase;

		// Token: 0x0400EF8D RID: 61325
		[Token(Token = "0x400EF8D")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel LabelPurchaseHint;

		// Token: 0x0400EF8E RID: 61326
		[Token(Token = "0x400EF8E")]
		[FieldOffset(Offset = "0xE8")]
		public Animator AnimatorForRenewal;

		// Token: 0x0400EF8F RID: 61327
		[Token(Token = "0x400EF8F")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite PurchaseDisabledBG;

		// Token: 0x0400EF90 RID: 61328
		[Token(Token = "0x400EF90")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel PriceLabel_Disabled;

		// Token: 0x0400EF91 RID: 61329
		[Token(Token = "0x400EF91")]
		[FieldOffset(Offset = "0x100")]
		public UISprite PurchaseEnabledBG;

		// Token: 0x0400EF92 RID: 61330
		[Token(Token = "0x400EF92")]
		[FieldOffset(Offset = "0x108")]
		public UILabel PriceLabel_Enabled;

		// Token: 0x0400EF93 RID: 61331
		[Token(Token = "0x400EF93")]
		[FieldOffset(Offset = "0x110")]
		public UITable Descs;

		// Token: 0x0400EF94 RID: 61332
		[Token(Token = "0x400EF94")]
		[FieldOffset(Offset = "0x118")]
		public UILabel LabelMonthCardDesc0;

		// Token: 0x0400EF95 RID: 61333
		[Token(Token = "0x400EF95")]
		[FieldOffset(Offset = "0x120")]
		public UILabel LabelMonthCardDesc1;

		// Token: 0x0400EF96 RID: 61334
		[Token(Token = "0x400EF96")]
		[FieldOffset(Offset = "0x128")]
		public UILabel LabelMonthCardDesc2;

		// Token: 0x0400EF97 RID: 61335
		[Token(Token = "0x400EF97")]
		[FieldOffset(Offset = "0x130")]
		public UILabel LabelMonthCardDesc3;

		// Token: 0x0400EF98 RID: 61336
		[Token(Token = "0x400EF98")]
		[FieldOffset(Offset = "0x138")]
		public UILabel LabelMonthCardDesc4;

		// Token: 0x0400EF99 RID: 61337
		[Token(Token = "0x400EF99")]
		[FieldOffset(Offset = "0x140")]
		public UILabel LabelMonthCardDesc5;

		// Token: 0x0400EF9A RID: 61338
		[Token(Token = "0x400EF9A")]
		[FieldOffset(Offset = "0x148")]
		public UIWidget SubscriptionWidget;

		// Token: 0x0400EF9B RID: 61339
		[Token(Token = "0x400EF9B")]
		[FieldOffset(Offset = "0x150")]
		public UIButton SubscriptionHintButton;

		// Token: 0x0400EF9C RID: 61340
		[Token(Token = "0x400EF9C")]
		[FieldOffset(Offset = "0x158")]
		public UISprite SubscriptionTips;

		// Token: 0x0400EF9D RID: 61341
		[Token(Token = "0x400EF9D")]
		[FieldOffset(Offset = "0x160")]
		public UISprite SubscriptionBonus;

		// Token: 0x0400EF9E RID: 61342
		[Token(Token = "0x400EF9E")]
		[FieldOffset(Offset = "0x168")]
		public UILabel SubscriptionBonusAmountLabel;

		// Token: 0x0400EF9F RID: 61343
		[Token(Token = "0x400EF9F")]
		[FieldOffset(Offset = "0x170")]
		public UILabel SubscriptionToggleText;

		// Token: 0x0400EFA0 RID: 61344
		[Token(Token = "0x400EFA0")]
		[FieldOffset(Offset = "0x178")]
		public UIButton SubscriptionToggleBox;

		// Token: 0x0400EFA1 RID: 61345
		[Token(Token = "0x400EFA1")]
		[FieldOffset(Offset = "0x180")]
		public UISprite SubscriptionToggleTick;
	}
}
