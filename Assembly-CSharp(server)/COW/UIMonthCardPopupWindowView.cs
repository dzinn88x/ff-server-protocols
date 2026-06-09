using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002448 RID: 9288
	[Token(Token = "0x2002448")]
	internal class UIMonthCardPopupWindowView : UIBaseView
	{
		// Token: 0x0600C3A0 RID: 50080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A0")]
		[Address(RVA = "0x14C9CE0", Offset = "0x14C9CE0", VA = "0x7BBBCC9CE0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A1")]
		[Address(RVA = "0x14CA1F4", Offset = "0x14CA1F4", VA = "0x7BBBCCA1F4")]
		public UIMonthCardPopupWindowView()
		{
		}

		// Token: 0x0400E793 RID: 59283
		[Token(Token = "0x400E793")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400E794 RID: 59284
		[Token(Token = "0x400E794")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BuyInfoContainer;

		// Token: 0x0400E795 RID: 59285
		[Token(Token = "0x400E795")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelRemainingDay;

		// Token: 0x0400E796 RID: 59286
		[Token(Token = "0x400E796")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnRedeem;

		// Token: 0x0400E797 RID: 59287
		[Token(Token = "0x400E797")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EffectRedeem;

		// Token: 0x0400E798 RID: 59288
		[Token(Token = "0x400E798")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelRedeemTitle;

		// Token: 0x0400E799 RID: 59289
		[Token(Token = "0x400E799")]
		[FieldOffset(Offset = "0x50")]
		public UISprite RedeemBtnBG;

		// Token: 0x0400E79A RID: 59290
		[Token(Token = "0x400E79A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DiamondIcon;

		// Token: 0x0400E79B RID: 59291
		[Token(Token = "0x400E79B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject CoinsIcon;

		// Token: 0x0400E79C RID: 59292
		[Token(Token = "0x400E79C")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelRedeemAmount;

		// Token: 0x0400E79D RID: 59293
		[Token(Token = "0x400E79D")]
		[FieldOffset(Offset = "0x70")]
		public UICountDownLabel LabelTimeCount;

		// Token: 0x0400E79E RID: 59294
		[Token(Token = "0x400E79E")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnPurchase;

		// Token: 0x0400E79F RID: 59295
		[Token(Token = "0x400E79F")]
		[FieldOffset(Offset = "0x80")]
		public UISprite PurchaseBtnBG;

		// Token: 0x0400E7A0 RID: 59296
		[Token(Token = "0x400E7A0")]
		[FieldOffset(Offset = "0x88")]
		public UILabel LabelPrice;

		// Token: 0x0400E7A1 RID: 59297
		[Token(Token = "0x400E7A1")]
		[FieldOffset(Offset = "0x90")]
		public UILabel LabelPurchaseHint;

		// Token: 0x0400E7A2 RID: 59298
		[Token(Token = "0x400E7A2")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LabelMonthCardDesc0;

		// Token: 0x0400E7A3 RID: 59299
		[Token(Token = "0x400E7A3")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LabelMonthCardDesc1;

		// Token: 0x0400E7A4 RID: 59300
		[Token(Token = "0x400E7A4")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel LabelMonthCardDesc2;

		// Token: 0x0400E7A5 RID: 59301
		[Token(Token = "0x400E7A5")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LabelResetHint;

		// Token: 0x0400E7A6 RID: 59302
		[Token(Token = "0x400E7A6")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject LoadingContainer;
	}
}
