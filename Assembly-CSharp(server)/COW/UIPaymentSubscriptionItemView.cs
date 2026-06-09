using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200247F RID: 9343
	[Token(Token = "0x200247F")]
	internal class UIPaymentSubscriptionItemView : UIBaseView
	{
		// Token: 0x0600C40E RID: 50190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40E")]
		[Address(RVA = "0x1F34B6C", Offset = "0x1F34B6C", VA = "0x7BBC734B6C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C40F RID: 50191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C40F")]
		[Address(RVA = "0x1F34E24", Offset = "0x1F34E24", VA = "0x7BBC734E24")]
		public UIPaymentSubscriptionItemView()
		{
		}

		// Token: 0x0400EAA7 RID: 60071
		[Token(Token = "0x400EAA7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Button;

		// Token: 0x0400EAA8 RID: 60072
		[Token(Token = "0x400EAA8")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Selected;

		// Token: 0x0400EAA9 RID: 60073
		[Token(Token = "0x400EAA9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite RedDot;

		// Token: 0x0400EAAA RID: 60074
		[Token(Token = "0x400EAAA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PriceLabel;

		// Token: 0x0400EAAB RID: 60075
		[Token(Token = "0x400EAAB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel PeriodLabel;

		// Token: 0x0400EAAC RID: 60076
		[Token(Token = "0x400EAAC")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget Subscribing;

		// Token: 0x0400EAAD RID: 60077
		[Token(Token = "0x400EAAD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SubscribingLabel;

		// Token: 0x0400EAAE RID: 60078
		[Token(Token = "0x400EAAE")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTextureExt MainAdNetworkTexture;

		// Token: 0x0400EAAF RID: 60079
		[Token(Token = "0x400EAAF")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget NewIcon;

		// Token: 0x0400EAB0 RID: 60080
		[Token(Token = "0x400EAB0")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget LimitedIcon;
	}
}
