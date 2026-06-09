using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241E RID: 9246
	[Token(Token = "0x200241E")]
	public class UIMallRecommendItemView : UIBaseView
	{
		// Token: 0x0600C34C RID: 49996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34C")]
		[Address(RVA = "0x1DF232C", Offset = "0x1DF232C", VA = "0x7BBC5F232C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C34D RID: 49997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34D")]
		[Address(RVA = "0x1DF261C", Offset = "0x1DF261C", VA = "0x7BBC5F261C")]
		public UIMallRecommendItemView()
		{
		}

		// Token: 0x0400E51F RID: 58655
		[Token(Token = "0x400E51F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E520 RID: 58656
		[Token(Token = "0x400E520")]
		[FieldOffset(Offset = "0x28")]
		public BaseItemView BaseItemInfo;

		// Token: 0x0400E521 RID: 58657
		[Token(Token = "0x400E521")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HighLightBG;

		// Token: 0x0400E522 RID: 58658
		[Token(Token = "0x400E522")]
		[FieldOffset(Offset = "0x38")]
		public UISprite QualityBG;

		// Token: 0x0400E523 RID: 58659
		[Token(Token = "0x400E523")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Quality;

		// Token: 0x0400E524 RID: 58660
		[Token(Token = "0x400E524")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGBlack;

		// Token: 0x0400E525 RID: 58661
		[Token(Token = "0x400E525")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BGWhite;

		// Token: 0x0400E526 RID: 58662
		[Token(Token = "0x400E526")]
		[FieldOffset(Offset = "0x58")]
		public GameObject UniquedTitle;

		// Token: 0x0400E527 RID: 58663
		[Token(Token = "0x400E527")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SellOutTitle;

		// Token: 0x0400E528 RID: 58664
		[Token(Token = "0x400E528")]
		[FieldOffset(Offset = "0x68")]
		public UISprite VoucherIcon;

		// Token: 0x0400E529 RID: 58665
		[Token(Token = "0x400E529")]
		[FieldOffset(Offset = "0x70")]
		public UILabel DiscountLabel;
	}
}
