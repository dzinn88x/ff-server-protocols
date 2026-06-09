using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246D RID: 9325
	[Token(Token = "0x200246D")]
	public class UIPaymentBundleItemView : UIBaseView
	{
		// Token: 0x0600C3EA RID: 50154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3EA")]
		[Address(RVA = "0x16F73F0", Offset = "0x16F73F0", VA = "0x7BBBEF73F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3EB RID: 50155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3EB")]
		[Address(RVA = "0x16F7A1C", Offset = "0x16F7A1C", VA = "0x7BBBEF7A1C")]
		public UIPaymentBundleItemView()
		{
		}

		// Token: 0x0400E9C9 RID: 59849
		[Token(Token = "0x400E9C9")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView IAPBundleItemView;

		// Token: 0x0400E9CA RID: 59850
		[Token(Token = "0x400E9CA")]
		[FieldOffset(Offset = "0x28")]
		public UIDragScrollView DragScrollView;

		// Token: 0x0400E9CB RID: 59851
		[Token(Token = "0x400E9CB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Tag;

		// Token: 0x0400E9CC RID: 59852
		[Token(Token = "0x400E9CC")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TagLabel;

		// Token: 0x0400E9CD RID: 59853
		[Token(Token = "0x400E9CD")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Countdown;

		// Token: 0x0400E9CE RID: 59854
		[Token(Token = "0x400E9CE")]
		[FieldOffset(Offset = "0x48")]
		public Transform Time;

		// Token: 0x0400E9CF RID: 59855
		[Token(Token = "0x400E9CF")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SubTitle;

		// Token: 0x0400E9D0 RID: 59856
		[Token(Token = "0x400E9D0")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Title;

		// Token: 0x0400E9D1 RID: 59857
		[Token(Token = "0x400E9D1")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ClickBtn;

		// Token: 0x0400E9D2 RID: 59858
		[Token(Token = "0x400E9D2")]
		[FieldOffset(Offset = "0x68")]
		public UISprite PurchasableSprite;

		// Token: 0x0400E9D3 RID: 59859
		[Token(Token = "0x400E9D3")]
		[FieldOffset(Offset = "0x70")]
		public UILabel BundlePriceLabel;

		// Token: 0x0400E9D4 RID: 59860
		[Token(Token = "0x400E9D4")]
		[FieldOffset(Offset = "0x78")]
		public UILabel OriginalPriceLabel;

		// Token: 0x0400E9D5 RID: 59861
		[Token(Token = "0x400E9D5")]
		[FieldOffset(Offset = "0x80")]
		public UILabel PendingLabel;

		// Token: 0x0400E9D6 RID: 59862
		[Token(Token = "0x400E9D6")]
		[FieldOffset(Offset = "0x88")]
		public UISprite PurchasableDiamondSprite;

		// Token: 0x0400E9D7 RID: 59863
		[Token(Token = "0x400E9D7")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BundlePriceDiamondLabel;

		// Token: 0x0400E9D8 RID: 59864
		[Token(Token = "0x400E9D8")]
		[FieldOffset(Offset = "0x98")]
		public UILabel OriginalPriceDiamondLabel;

		// Token: 0x0400E9D9 RID: 59865
		[Token(Token = "0x400E9D9")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite PurchasableFreeSprite;

		// Token: 0x0400E9DA RID: 59866
		[Token(Token = "0x400E9DA")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite UnpurchasableSprite;

		// Token: 0x0400E9DB RID: 59867
		[Token(Token = "0x400E9DB")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject HasGained;

		// Token: 0x0400E9DC RID: 59868
		[Token(Token = "0x400E9DC")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel PurchaseLimitLabel;

		// Token: 0x0400E9DD RID: 59869
		[Token(Token = "0x400E9DD")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite PercentageSprite;

		// Token: 0x0400E9DE RID: 59870
		[Token(Token = "0x400E9DE")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel PercentageLabel;

		// Token: 0x0400E9DF RID: 59871
		[Token(Token = "0x400E9DF")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid ContentsGrid;

		// Token: 0x0400E9E0 RID: 59872
		[Token(Token = "0x400E9E0")]
		[FieldOffset(Offset = "0xD8")]
		public UIGrid ContentsGridTop;

		// Token: 0x0400E9E1 RID: 59873
		[Token(Token = "0x400E9E1")]
		[FieldOffset(Offset = "0xE0")]
		public UIGrid ContentsGridBottom;
	}
}
