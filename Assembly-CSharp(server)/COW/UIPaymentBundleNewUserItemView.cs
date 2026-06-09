using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246E RID: 9326
	[Token(Token = "0x200246E")]
	public class UIPaymentBundleNewUserItemView : UIBaseView
	{
		// Token: 0x0600C3EC RID: 50156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3EC")]
		[Address(RVA = "0x16FAA08", Offset = "0x16FAA08", VA = "0x7BBBEFAA08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3ED RID: 50157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3ED")]
		[Address(RVA = "0x16FB080", Offset = "0x16FB080", VA = "0x7BBBEFB080")]
		public UIPaymentBundleNewUserItemView()
		{
		}

		// Token: 0x0400E9E2 RID: 59874
		[Token(Token = "0x400E9E2")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView IAPBundleItemView;

		// Token: 0x0400E9E3 RID: 59875
		[Token(Token = "0x400E9E3")]
		[FieldOffset(Offset = "0x28")]
		public UIDragScrollView DragScrollView;

		// Token: 0x0400E9E4 RID: 59876
		[Token(Token = "0x400E9E4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Countdown;

		// Token: 0x0400E9E5 RID: 59877
		[Token(Token = "0x400E9E5")]
		[FieldOffset(Offset = "0x38")]
		public Transform Time;

		// Token: 0x0400E9E6 RID: 59878
		[Token(Token = "0x400E9E6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Tag;

		// Token: 0x0400E9E7 RID: 59879
		[Token(Token = "0x400E9E7")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TagLabel;

		// Token: 0x0400E9E8 RID: 59880
		[Token(Token = "0x400E9E8")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Title;

		// Token: 0x0400E9E9 RID: 59881
		[Token(Token = "0x400E9E9")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SubTitle;

		// Token: 0x0400E9EA RID: 59882
		[Token(Token = "0x400E9EA")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ClickBtn;

		// Token: 0x0400E9EB RID: 59883
		[Token(Token = "0x400E9EB")]
		[FieldOffset(Offset = "0x68")]
		public UISprite PurchasableSprite;

		// Token: 0x0400E9EC RID: 59884
		[Token(Token = "0x400E9EC")]
		[FieldOffset(Offset = "0x70")]
		public UILabel BundlePriceLabel;

		// Token: 0x0400E9ED RID: 59885
		[Token(Token = "0x400E9ED")]
		[FieldOffset(Offset = "0x78")]
		public UILabel OriginalPriceLabel;

		// Token: 0x0400E9EE RID: 59886
		[Token(Token = "0x400E9EE")]
		[FieldOffset(Offset = "0x80")]
		public UILabel PendingLabel;

		// Token: 0x0400E9EF RID: 59887
		[Token(Token = "0x400E9EF")]
		[FieldOffset(Offset = "0x88")]
		public UISprite PurchasableDiamondSprite;

		// Token: 0x0400E9F0 RID: 59888
		[Token(Token = "0x400E9F0")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BundlePriceDiamondLabel;

		// Token: 0x0400E9F1 RID: 59889
		[Token(Token = "0x400E9F1")]
		[FieldOffset(Offset = "0x98")]
		public UILabel OriginalPriceDiamondLabel;

		// Token: 0x0400E9F2 RID: 59890
		[Token(Token = "0x400E9F2")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite PurchasableFreeSprite;

		// Token: 0x0400E9F3 RID: 59891
		[Token(Token = "0x400E9F3")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite UnpurchasableSprite;

		// Token: 0x0400E9F4 RID: 59892
		[Token(Token = "0x400E9F4")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject HasGained;

		// Token: 0x0400E9F5 RID: 59893
		[Token(Token = "0x400E9F5")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel PurchaseLimitLabel;

		// Token: 0x0400E9F6 RID: 59894
		[Token(Token = "0x400E9F6")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite PercentageSprite;

		// Token: 0x0400E9F7 RID: 59895
		[Token(Token = "0x400E9F7")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel PercentageLabel;

		// Token: 0x0400E9F8 RID: 59896
		[Token(Token = "0x400E9F8")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid ContentsGrid;

		// Token: 0x0400E9F9 RID: 59897
		[Token(Token = "0x400E9F9")]
		[FieldOffset(Offset = "0xD8")]
		public UIGrid ContentsGridBottom;

		// Token: 0x0400E9FA RID: 59898
		[Token(Token = "0x400E9FA")]
		[FieldOffset(Offset = "0xE0")]
		public UIGrid ContentsGridTop;

		// Token: 0x0400E9FB RID: 59899
		[Token(Token = "0x400E9FB")]
		[FieldOffset(Offset = "0xE8")]
		public UINetworkTexture NetworkTexture;
	}
}
