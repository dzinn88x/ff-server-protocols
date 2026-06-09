using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BF RID: 9151
	[Token(Token = "0x20023BF")]
	public class UIIAPBundleView : UIBaseView
	{
		// Token: 0x0600C28E RID: 49806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28E")]
		[Address(RVA = "0x138B37C", Offset = "0x138B37C", VA = "0x7BBBB8B37C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C28F RID: 49807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28F")]
		[Address(RVA = "0x138BDC4", Offset = "0x138BDC4", VA = "0x7BBBB8BDC4")]
		public UIIAPBundleView()
		{
		}

		// Token: 0x0400DE5D RID: 56925
		[Token(Token = "0x400DE5D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Close;

		// Token: 0x0400DE5E RID: 56926
		[Token(Token = "0x400DE5E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentBG;

		// Token: 0x0400DE5F RID: 56927
		[Token(Token = "0x400DE5F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Hint;

		// Token: 0x0400DE60 RID: 56928
		[Token(Token = "0x400DE60")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DiscountWidget;

		// Token: 0x0400DE61 RID: 56929
		[Token(Token = "0x400DE61")]
		[FieldOffset(Offset = "0x40")]
		public Animation DiscountWidgetAnimation;

		// Token: 0x0400DE62 RID: 56930
		[Token(Token = "0x400DE62")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DiscountEffectLabel;

		// Token: 0x0400DE63 RID: 56931
		[Token(Token = "0x400DE63")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DiscountLabel;

		// Token: 0x0400DE64 RID: 56932
		[Token(Token = "0x400DE64")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SloganLabel;

		// Token: 0x0400DE65 RID: 56933
		[Token(Token = "0x400DE65")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTexture CDNTitle;

		// Token: 0x0400DE66 RID: 56934
		[Token(Token = "0x400DE66")]
		[FieldOffset(Offset = "0x68")]
		public UICountDownLabel CountdownLabel;

		// Token: 0x0400DE67 RID: 56935
		[Token(Token = "0x400DE67")]
		[FieldOffset(Offset = "0x70")]
		public UILabel DefaultLabelTitle;

		// Token: 0x0400DE68 RID: 56936
		[Token(Token = "0x400DE68")]
		[FieldOffset(Offset = "0x78")]
		public UILabel DesciptionLabel;

		// Token: 0x0400DE69 RID: 56937
		[Token(Token = "0x400DE69")]
		[FieldOffset(Offset = "0x80")]
		public UIScrollView BundleContentScrollView;

		// Token: 0x0400DE6A RID: 56938
		[Token(Token = "0x400DE6A")]
		[FieldOffset(Offset = "0x88")]
		public UIEasyList ContentItemsEasyList;

		// Token: 0x0400DE6B RID: 56939
		[Token(Token = "0x400DE6B")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid BundleContentGrid;

		// Token: 0x0400DE6C RID: 56940
		[Token(Token = "0x400DE6C")]
		[FieldOffset(Offset = "0x98")]
		public Transform Item0;

		// Token: 0x0400DE6D RID: 56941
		[Token(Token = "0x400DE6D")]
		[FieldOffset(Offset = "0xA0")]
		public Transform Item1;

		// Token: 0x0400DE6E RID: 56942
		[Token(Token = "0x400DE6E")]
		[FieldOffset(Offset = "0xA8")]
		public Transform Item2;

		// Token: 0x0400DE6F RID: 56943
		[Token(Token = "0x400DE6F")]
		[FieldOffset(Offset = "0xB0")]
		public Transform Item3;

		// Token: 0x0400DE70 RID: 56944
		[Token(Token = "0x400DE70")]
		[FieldOffset(Offset = "0xB8")]
		public Transform Item4;

		// Token: 0x0400DE71 RID: 56945
		[Token(Token = "0x400DE71")]
		[FieldOffset(Offset = "0xC0")]
		public UITable Table;

		// Token: 0x0400DE72 RID: 56946
		[Token(Token = "0x400DE72")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel OwnedLabel;

		// Token: 0x0400DE73 RID: 56947
		[Token(Token = "0x400DE73")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite ReturnTypeSprite;

		// Token: 0x0400DE74 RID: 56948
		[Token(Token = "0x400DE74")]
		[FieldOffset(Offset = "0xD8")]
		public BaseItemView ReturnItemView;

		// Token: 0x0400DE75 RID: 56949
		[Token(Token = "0x400DE75")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel ReturnNumLabel;

		// Token: 0x0400DE76 RID: 56950
		[Token(Token = "0x400DE76")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton PurchaseButton;

		// Token: 0x0400DE77 RID: 56951
		[Token(Token = "0x400DE77")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject ExtraDiamond;

		// Token: 0x0400DE78 RID: 56952
		[Token(Token = "0x400DE78")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel ExtraDiamondLabel;

		// Token: 0x0400DE79 RID: 56953
		[Token(Token = "0x400DE79")]
		[FieldOffset(Offset = "0x100")]
		public UILabel OriginalPriceLabel;

		// Token: 0x0400DE7A RID: 56954
		[Token(Token = "0x400DE7A")]
		[FieldOffset(Offset = "0x108")]
		public UILabel ActualPriceLabel;

		// Token: 0x0400DE7B RID: 56955
		[Token(Token = "0x400DE7B")]
		[FieldOffset(Offset = "0x110")]
		public UISprite PendingMask;

		// Token: 0x0400DE7C RID: 56956
		[Token(Token = "0x400DE7C")]
		[FieldOffset(Offset = "0x118")]
		public UILabel PendingLabel;

		// Token: 0x0400DE7D RID: 56957
		[Token(Token = "0x400DE7D")]
		[FieldOffset(Offset = "0x120")]
		public UIButton DiamondPurchaseButton;

		// Token: 0x0400DE7E RID: 56958
		[Token(Token = "0x400DE7E")]
		[FieldOffset(Offset = "0x128")]
		public GameObject OriginalDiamond;

		// Token: 0x0400DE7F RID: 56959
		[Token(Token = "0x400DE7F")]
		[FieldOffset(Offset = "0x130")]
		public UILabel OriginalDiamondPriceLabel;

		// Token: 0x0400DE80 RID: 56960
		[Token(Token = "0x400DE80")]
		[FieldOffset(Offset = "0x138")]
		public GameObject ActualDiamond;

		// Token: 0x0400DE81 RID: 56961
		[Token(Token = "0x400DE81")]
		[FieldOffset(Offset = "0x140")]
		public UILabel ActualDiamondPriceLabel;

		// Token: 0x0400DE82 RID: 56962
		[Token(Token = "0x400DE82")]
		[FieldOffset(Offset = "0x148")]
		public UISprite DiamondPendingMask;

		// Token: 0x0400DE83 RID: 56963
		[Token(Token = "0x400DE83")]
		[FieldOffset(Offset = "0x150")]
		public UILabel DiamondPendingLabel;

		// Token: 0x0400DE84 RID: 56964
		[Token(Token = "0x400DE84")]
		[FieldOffset(Offset = "0x158")]
		public GameObject OR;

		// Token: 0x0400DE85 RID: 56965
		[Token(Token = "0x400DE85")]
		[FieldOffset(Offset = "0x160")]
		public GameObject CenterPoint;

		// Token: 0x0400DE86 RID: 56966
		[Token(Token = "0x400DE86")]
		[FieldOffset(Offset = "0x168")]
		public UISprite PreviewLeft;

		// Token: 0x0400DE87 RID: 56967
		[Token(Token = "0x400DE87")]
		[FieldOffset(Offset = "0x170")]
		public UISprite PreviewRight;
	}
}
