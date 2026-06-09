using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AF RID: 8623
	[Token(Token = "0x20021AF")]
	public class UIElitePassBadgePurchaseView : UIBaseView
	{
		// Token: 0x0600BE6E RID: 48750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6E")]
		[Address(RVA = "0x1ADAE7C", Offset = "0x1ADAE7C", VA = "0x7BBC2DAE7C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE6F RID: 48751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6F")]
		[Address(RVA = "0x1ADB490", Offset = "0x1ADB490", VA = "0x7BBC2DB490")]
		public UIElitePassBadgePurchaseView()
		{
		}

		// Token: 0x0400C9AE RID: 51630
		[Token(Token = "0x400C9AE")]
		[FieldOffset(Offset = "0x20")]
		public UICountDownLabel RefreshLabel;

		// Token: 0x0400C9AF RID: 51631
		[Token(Token = "0x400C9AF")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture CDNTheme;

		// Token: 0x0400C9B0 RID: 51632
		[Token(Token = "0x400C9B0")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BadgeCountIconSprite;

		// Token: 0x0400C9B1 RID: 51633
		[Token(Token = "0x400C9B1")]
		[FieldOffset(Offset = "0x38")]
		public UIButton badgeInfoBtn;

		// Token: 0x0400C9B2 RID: 51634
		[Token(Token = "0x400C9B2")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BadgeCount;

		// Token: 0x0400C9B3 RID: 51635
		[Token(Token = "0x400C9B3")]
		[FieldOffset(Offset = "0x48")]
		public UIButton MinusBtn;

		// Token: 0x0400C9B4 RID: 51636
		[Token(Token = "0x400C9B4")]
		[FieldOffset(Offset = "0x50")]
		public UIButton MinusFiveBtn;

		// Token: 0x0400C9B5 RID: 51637
		[Token(Token = "0x400C9B5")]
		[FieldOffset(Offset = "0x58")]
		public UIButton PlusBtn;

		// Token: 0x0400C9B6 RID: 51638
		[Token(Token = "0x400C9B6")]
		[FieldOffset(Offset = "0x60")]
		public UIButton PlusFiveBtn;

		// Token: 0x0400C9B7 RID: 51639
		[Token(Token = "0x400C9B7")]
		[FieldOffset(Offset = "0x68")]
		public UIInput BuyCountField;

		// Token: 0x0400C9B8 RID: 51640
		[Token(Token = "0x400C9B8")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Badge;

		// Token: 0x0400C9B9 RID: 51641
		[Token(Token = "0x400C9B9")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DiamondAmountOriginal;

		// Token: 0x0400C9BA RID: 51642
		[Token(Token = "0x400C9BA")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DiamondSpriteOriginal;

		// Token: 0x0400C9BB RID: 51643
		[Token(Token = "0x400C9BB")]
		[FieldOffset(Offset = "0x88")]
		public GameObject CoinSpriteOriginal;

		// Token: 0x0400C9BC RID: 51644
		[Token(Token = "0x400C9BC")]
		[FieldOffset(Offset = "0x90")]
		public UIButton PurchaseBtn;

		// Token: 0x0400C9BD RID: 51645
		[Token(Token = "0x400C9BD")]
		[FieldOffset(Offset = "0x98")]
		public GameObject DiamondSprite;

		// Token: 0x0400C9BE RID: 51646
		[Token(Token = "0x400C9BE")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel DiamondAmount;

		// Token: 0x0400C9BF RID: 51647
		[Token(Token = "0x400C9BF")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject CoinSprite;

		// Token: 0x0400C9C0 RID: 51648
		[Token(Token = "0x400C9C0")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton UpgradeBtn;

		// Token: 0x0400C9C1 RID: 51649
		[Token(Token = "0x400C9C1")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget EPSprite;

		// Token: 0x0400C9C2 RID: 51650
		[Token(Token = "0x400C9C2")]
		[FieldOffset(Offset = "0xC0")]
		public UIEasyList Grid;

		// Token: 0x0400C9C3 RID: 51651
		[Token(Token = "0x400C9C3")]
		[FieldOffset(Offset = "0xC8")]
		public UIWidget PreViewContain;

		// Token: 0x0400C9C4 RID: 51652
		[Token(Token = "0x400C9C4")]
		[FieldOffset(Offset = "0xD0")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400C9C5 RID: 51653
		[Token(Token = "0x400C9C5")]
		[FieldOffset(Offset = "0xD8")]
		public UIWidget PreviewRightContainer;
	}
}
