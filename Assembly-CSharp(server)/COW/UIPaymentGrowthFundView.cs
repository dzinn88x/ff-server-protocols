using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002476 RID: 9334
	[Token(Token = "0x2002476")]
	public class UIPaymentGrowthFundView : UIBaseView
	{
		// Token: 0x0600C3FC RID: 50172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FC")]
		[Address(RVA = "0x1F28B1C", Offset = "0x1F28B1C", VA = "0x7BBC728B1C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3FD RID: 50173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3FD")]
		[Address(RVA = "0x1F2916C", Offset = "0x1F2916C", VA = "0x7BBC72916C")]
		public UIPaymentGrowthFundView()
		{
		}

		// Token: 0x0400EA3B RID: 59963
		[Token(Token = "0x400EA3B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Hint;

		// Token: 0x0400EA3C RID: 59964
		[Token(Token = "0x400EA3C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HasGained;

		// Token: 0x0400EA3D RID: 59965
		[Token(Token = "0x400EA3D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel HasGainedLevel;

		// Token: 0x0400EA3E RID: 59966
		[Token(Token = "0x400EA3E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HasGainedDesc;

		// Token: 0x0400EA3F RID: 59967
		[Token(Token = "0x400EA3F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HasNotGained;

		// Token: 0x0400EA40 RID: 59968
		[Token(Token = "0x400EA40")]
		[FieldOffset(Offset = "0x48")]
		public UISprite PurchasableDiamondSprite;

		// Token: 0x0400EA41 RID: 59969
		[Token(Token = "0x400EA41")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BundlePriceDiamondLabel;

		// Token: 0x0400EA42 RID: 59970
		[Token(Token = "0x400EA42")]
		[FieldOffset(Offset = "0x58")]
		public UILabel OriginalPriceDiamondLabel;

		// Token: 0x0400EA43 RID: 59971
		[Token(Token = "0x400EA43")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PendingDiamondLabel;

		// Token: 0x0400EA44 RID: 59972
		[Token(Token = "0x400EA44")]
		[FieldOffset(Offset = "0x68")]
		public UISprite PurchasableSprite;

		// Token: 0x0400EA45 RID: 59973
		[Token(Token = "0x400EA45")]
		[FieldOffset(Offset = "0x70")]
		public UIButton Purchase;

		// Token: 0x0400EA46 RID: 59974
		[Token(Token = "0x400EA46")]
		[FieldOffset(Offset = "0x78")]
		public UILabel BundlePriceLabel;

		// Token: 0x0400EA47 RID: 59975
		[Token(Token = "0x400EA47")]
		[FieldOffset(Offset = "0x80")]
		public UILabel OriginalPriceLabel;

		// Token: 0x0400EA48 RID: 59976
		[Token(Token = "0x400EA48")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PendingLabel;

		// Token: 0x0400EA49 RID: 59977
		[Token(Token = "0x400EA49")]
		[FieldOffset(Offset = "0x90")]
		public UISprite UnpurchasableSprite;

		// Token: 0x0400EA4A RID: 59978
		[Token(Token = "0x400EA4A")]
		[FieldOffset(Offset = "0x98")]
		public UISprite PurchasableFreeSprite;

		// Token: 0x0400EA4B RID: 59979
		[Token(Token = "0x400EA4B")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite PercentageSprite;

		// Token: 0x0400EA4C RID: 59980
		[Token(Token = "0x400EA4C")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel PercentageLabel;

		// Token: 0x0400EA4D RID: 59981
		[Token(Token = "0x400EA4D")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel HasNotGainedLevel;

		// Token: 0x0400EA4E RID: 59982
		[Token(Token = "0x400EA4E")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel HasNotGainedDesc;

		// Token: 0x0400EA4F RID: 59983
		[Token(Token = "0x400EA4F")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel HasNotGainedDesc2;

		// Token: 0x0400EA50 RID: 59984
		[Token(Token = "0x400EA50")]
		[FieldOffset(Offset = "0xC8")]
		public UIScrollView BundlesScrollView;

		// Token: 0x0400EA51 RID: 59985
		[Token(Token = "0x400EA51")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid BundlesScrollViewGrid;

		// Token: 0x0400EA52 RID: 59986
		[Token(Token = "0x400EA52")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite ArrowRight;

		// Token: 0x0400EA53 RID: 59987
		[Token(Token = "0x400EA53")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite ArrowLeft;

		// Token: 0x0400EA54 RID: 59988
		[Token(Token = "0x400EA54")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject VFX_UI_Fund_01;
	}
}
