using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247B RID: 9339
	[Token(Token = "0x200247B")]
	public class UIPaymentSubscriptionBundleView : UIBaseView
	{
		// Token: 0x0600C406 RID: 50182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C406")]
		[Address(RVA = "0x1F30F88", Offset = "0x1F30F88", VA = "0x7BBC730F88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C407")]
		[Address(RVA = "0x1F31594", Offset = "0x1F31594", VA = "0x7BBC731594")]
		public UIPaymentSubscriptionBundleView()
		{
		}

		// Token: 0x0400EA76 RID: 60022
		[Token(Token = "0x400EA76")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIPaymentSubscriptionBundle;

		// Token: 0x0400EA77 RID: 60023
		[Token(Token = "0x400EA77")]
		[FieldOffset(Offset = "0x28")]
		public UIButton InfoButton;

		// Token: 0x0400EA78 RID: 60024
		[Token(Token = "0x400EA78")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BonusUI;

		// Token: 0x0400EA79 RID: 60025
		[Token(Token = "0x400EA79")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BonusAmountLabel;

		// Token: 0x0400EA7A RID: 60026
		[Token(Token = "0x400EA7A")]
		[FieldOffset(Offset = "0x40")]
		public UIButton SubscribeButton;

		// Token: 0x0400EA7B RID: 60027
		[Token(Token = "0x400EA7B")]
		[FieldOffset(Offset = "0x48")]
		public UILabel SubscribeButtonLabel;

		// Token: 0x0400EA7C RID: 60028
		[Token(Token = "0x400EA7C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SubscribeButtonBgYellow;

		// Token: 0x0400EA7D RID: 60029
		[Token(Token = "0x400EA7D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SubscribeButtonMask;

		// Token: 0x0400EA7E RID: 60030
		[Token(Token = "0x400EA7E")]
		[FieldOffset(Offset = "0x60")]
		public UITable PricingTable;

		// Token: 0x0400EA7F RID: 60031
		[Token(Token = "0x400EA7F")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PriceLabel;

		// Token: 0x0400EA80 RID: 60032
		[Token(Token = "0x400EA80")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PeriodLabel;

		// Token: 0x0400EA81 RID: 60033
		[Token(Token = "0x400EA81")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ClaimButton;

		// Token: 0x0400EA82 RID: 60034
		[Token(Token = "0x400EA82")]
		[FieldOffset(Offset = "0x80")]
		public UISprite ClaimButtonMask;

		// Token: 0x0400EA83 RID: 60035
		[Token(Token = "0x400EA83")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ClaimButtonLabel;

		// Token: 0x0400EA84 RID: 60036
		[Token(Token = "0x400EA84")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ClaimButtonBgYellow;

		// Token: 0x0400EA85 RID: 60037
		[Token(Token = "0x400EA85")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid ContentContainer;

		// Token: 0x0400EA86 RID: 60038
		[Token(Token = "0x400EA86")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel NameLabel;

		// Token: 0x0400EA87 RID: 60039
		[Token(Token = "0x400EA87")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel DescLabel;

		// Token: 0x0400EA88 RID: 60040
		[Token(Token = "0x400EA88")]
		[FieldOffset(Offset = "0xB0")]
		public UITexture BgTexture;

		// Token: 0x0400EA89 RID: 60041
		[Token(Token = "0x400EA89")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite PreviewLeft;

		// Token: 0x0400EA8A RID: 60042
		[Token(Token = "0x400EA8A")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite PreviewRight;

		// Token: 0x0400EA8B RID: 60043
		[Token(Token = "0x400EA8B")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject AccountHold;

		// Token: 0x0400EA8C RID: 60044
		[Token(Token = "0x400EA8C")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton FixOnHoldButton;

		// Token: 0x0400EA8D RID: 60045
		[Token(Token = "0x400EA8D")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton GracePeriodButton;
	}
}
