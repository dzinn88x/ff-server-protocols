using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021BE RID: 8638
	[Token(Token = "0x20021BE")]
	public class UIElitePassSubscriptionView : UIBaseView
	{
		// Token: 0x0600BE8C RID: 48780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE8C")]
		[Address(RVA = "0x1E704A0", Offset = "0x1E704A0", VA = "0x7BBC6704A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE8D")]
		[Address(RVA = "0x1E707B8", Offset = "0x1E707B8", VA = "0x7BBC6707B8")]
		public UIElitePassSubscriptionView()
		{
		}

		// Token: 0x0400CACD RID: 51917
		[Token(Token = "0x400CACD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton PrivacyPolicyBtn;

		// Token: 0x0400CACE RID: 51918
		[Token(Token = "0x400CACE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton TermsOfServiceBtn;

		// Token: 0x0400CACF RID: 51919
		[Token(Token = "0x400CACF")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel SubscriptionCountDown;

		// Token: 0x0400CAD0 RID: 51920
		[Token(Token = "0x400CAD0")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture SubscribedCDN;

		// Token: 0x0400CAD1 RID: 51921
		[Token(Token = "0x400CAD1")]
		[FieldOffset(Offset = "0x40")]
		public UIButton SubscribeTipsBtn;

		// Token: 0x0400CAD2 RID: 51922
		[Token(Token = "0x400CAD2")]
		[FieldOffset(Offset = "0x48")]
		public UIButton SubscribeBtn;

		// Token: 0x0400CAD3 RID: 51923
		[Token(Token = "0x400CAD3")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PriceLabel;

		// Token: 0x0400CAD4 RID: 51924
		[Token(Token = "0x400CAD4")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BonusUI;

		// Token: 0x0400CAD5 RID: 51925
		[Token(Token = "0x400CAD5")]
		[FieldOffset(Offset = "0x60")]
		public UILabel BonusAmountLabel;

		// Token: 0x0400CAD6 RID: 51926
		[Token(Token = "0x400CAD6")]
		[FieldOffset(Offset = "0x68")]
		public UITable SubscriptionInfoTable;

		// Token: 0x0400CAD7 RID: 51927
		[Token(Token = "0x400CAD7")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SubscriptionInfoLabel_2;
	}
}
