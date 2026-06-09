using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247C RID: 9340
	[Token(Token = "0x200247C")]
	public class UIPaymentSubscriptionElitePassView : UIBaseView
	{
		// Token: 0x0600C408 RID: 50184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C408")]
		[Address(RVA = "0x1F321C4", Offset = "0x1F321C4", VA = "0x7BBC7321C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C409 RID: 50185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C409")]
		[Address(RVA = "0x1F326B8", Offset = "0x1F326B8", VA = "0x7BBC7326B8")]
		public UIPaymentSubscriptionElitePassView()
		{
		}

		// Token: 0x0400EA8E RID: 60046
		[Token(Token = "0x400EA8E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject AccountHold;

		// Token: 0x0400EA8F RID: 60047
		[Token(Token = "0x400EA8F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton FixOnHoldButton;

		// Token: 0x0400EA90 RID: 60048
		[Token(Token = "0x400EA90")]
		[FieldOffset(Offset = "0x30")]
		public UIButton GracePeriodButton;

		// Token: 0x0400EA91 RID: 60049
		[Token(Token = "0x400EA91")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400EA92 RID: 60050
		[Token(Token = "0x400EA92")]
		[FieldOffset(Offset = "0x40")]
		public UITable PricingTable;

		// Token: 0x0400EA93 RID: 60051
		[Token(Token = "0x400EA93")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PriceLabel;

		// Token: 0x0400EA94 RID: 60052
		[Token(Token = "0x400EA94")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PeriodLabel;

		// Token: 0x0400EA95 RID: 60053
		[Token(Token = "0x400EA95")]
		[FieldOffset(Offset = "0x58")]
		public UIButton InfoButton;

		// Token: 0x0400EA96 RID: 60054
		[Token(Token = "0x400EA96")]
		[FieldOffset(Offset = "0x60")]
		public UIButton SubscribeButton;

		// Token: 0x0400EA97 RID: 60055
		[Token(Token = "0x400EA97")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SubscribeButtonMask;

		// Token: 0x0400EA98 RID: 60056
		[Token(Token = "0x400EA98")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SubscribeButtonLabel;

		// Token: 0x0400EA99 RID: 60057
		[Token(Token = "0x400EA99")]
		[FieldOffset(Offset = "0x78")]
		public GameObject BtnOperateBgYellow;

		// Token: 0x0400EA9A RID: 60058
		[Token(Token = "0x400EA9A")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelDesc1;

		// Token: 0x0400EA9B RID: 60059
		[Token(Token = "0x400EA9B")]
		[FieldOffset(Offset = "0x88")]
		public UILabel LabelDesc2;

		// Token: 0x0400EA9C RID: 60060
		[Token(Token = "0x400EA9C")]
		[FieldOffset(Offset = "0x90")]
		public UILabel LabelDesc3;

		// Token: 0x0400EA9D RID: 60061
		[Token(Token = "0x400EA9D")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LabelDesc4;

		// Token: 0x0400EA9E RID: 60062
		[Token(Token = "0x400EA9E")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LabelDesc5;

		// Token: 0x0400EA9F RID: 60063
		[Token(Token = "0x400EA9F")]
		[FieldOffset(Offset = "0xA8")]
		public UICountDownLabel CountdownLabel;

		// Token: 0x0400EAA0 RID: 60064
		[Token(Token = "0x400EAA0")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BonusUI;

		// Token: 0x0400EAA1 RID: 60065
		[Token(Token = "0x400EAA1")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel BonusAmountLabel;
	}
}
