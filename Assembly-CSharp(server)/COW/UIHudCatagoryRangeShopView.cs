using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002290 RID: 8848
	[Token(Token = "0x2002290")]
	public class UIHudCatagoryRangeShopView : UIBaseView
	{
		// Token: 0x0600C031 RID: 49201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C031")]
		[Address(RVA = "0x19D11B0", Offset = "0x19D11B0", VA = "0x7BBC1D11B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C032")]
		[Address(RVA = "0x19D160C", Offset = "0x19D160C", VA = "0x7BBC1D160C")]
		public UIHudCatagoryRangeShopView()
		{
		}

		// Token: 0x0400D465 RID: 54373
		[Token(Token = "0x400D465")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnQuit;

		// Token: 0x0400D466 RID: 54374
		[Token(Token = "0x400D466")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400D467 RID: 54375
		[Token(Token = "0x400D467")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleLabel;

		// Token: 0x0400D468 RID: 54376
		[Token(Token = "0x400D468")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TopCatagory;

		// Token: 0x0400D469 RID: 54377
		[Token(Token = "0x400D469")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView CatagoryScrollView;

		// Token: 0x0400D46A RID: 54378
		[Token(Token = "0x400D46A")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList Grid;

		// Token: 0x0400D46B RID: 54379
		[Token(Token = "0x400D46B")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView ScrollView;

		// Token: 0x0400D46C RID: 54380
		[Token(Token = "0x400D46C")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid ItemGrid;

		// Token: 0x0400D46D RID: 54381
		[Token(Token = "0x400D46D")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView MaxScrollView;

		// Token: 0x0400D46E RID: 54382
		[Token(Token = "0x400D46E")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid MaxItemGrid;

		// Token: 0x0400D46F RID: 54383
		[Token(Token = "0x400D46F")]
		[FieldOffset(Offset = "0x70")]
		public UIButton purchaseBtn;

		// Token: 0x0400D470 RID: 54384
		[Token(Token = "0x400D470")]
		[FieldOffset(Offset = "0x78")]
		public GameObject TokenInfo;

		// Token: 0x0400D471 RID: 54385
		[Token(Token = "0x400D471")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Icon;

		// Token: 0x0400D472 RID: 54386
		[Token(Token = "0x400D472")]
		[FieldOffset(Offset = "0x88")]
		public UILabel TokenCnt;

		// Token: 0x0400D473 RID: 54387
		[Token(Token = "0x400D473")]
		[FieldOffset(Offset = "0x90")]
		public UIButton HelpBtn;

		// Token: 0x0400D474 RID: 54388
		[Token(Token = "0x400D474")]
		[FieldOffset(Offset = "0x98")]
		public UIButton Mask;
	}
}
