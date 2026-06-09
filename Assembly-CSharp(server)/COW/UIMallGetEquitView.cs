using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002416 RID: 9238
	[Token(Token = "0x2002416")]
	internal class UIMallGetEquitView : UIBaseView
	{
		// Token: 0x0600C33C RID: 49980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33C")]
		[Address(RVA = "0x1C6C904", Offset = "0x1C6C904", VA = "0x7BBC46C904", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C33D RID: 49981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33D")]
		[Address(RVA = "0x1C6CD94", Offset = "0x1C6CD94", VA = "0x7BBC46CD94")]
		public UIMallGetEquitView()
		{
		}

		// Token: 0x0400E485 RID: 58501
		[Token(Token = "0x400E485")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400E486 RID: 58502
		[Token(Token = "0x400E486")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContinueOpenContainer;

		// Token: 0x0400E487 RID: 58503
		[Token(Token = "0x400E487")]
		[FieldOffset(Offset = "0x30")]
		public UIButton OpenBtn;

		// Token: 0x0400E488 RID: 58504
		[Token(Token = "0x400E488")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CountLabel;

		// Token: 0x0400E489 RID: 58505
		[Token(Token = "0x400E489")]
		[FieldOffset(Offset = "0x40")]
		public UISprite OpenCrateIcon;

		// Token: 0x0400E48A RID: 58506
		[Token(Token = "0x400E48A")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CancelOpenBtn;

		// Token: 0x0400E48B RID: 58507
		[Token(Token = "0x400E48B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EndOpenContainer;

		// Token: 0x0400E48C RID: 58508
		[Token(Token = "0x400E48C")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BuyBtn;

		// Token: 0x0400E48D RID: 58509
		[Token(Token = "0x400E48D")]
		[FieldOffset(Offset = "0x60")]
		public GameObject GoldIcon;

		// Token: 0x0400E48E RID: 58510
		[Token(Token = "0x400E48E")]
		[FieldOffset(Offset = "0x68")]
		public GameObject DiamondIcon;

		// Token: 0x0400E48F RID: 58511
		[Token(Token = "0x400E48F")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PriceLabel;

		// Token: 0x0400E490 RID: 58512
		[Token(Token = "0x400E490")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BuyCrateIcon;

		// Token: 0x0400E491 RID: 58513
		[Token(Token = "0x400E491")]
		[FieldOffset(Offset = "0x80")]
		public UIButton CancelBuyBtn;

		// Token: 0x0400E492 RID: 58514
		[Token(Token = "0x400E492")]
		[FieldOffset(Offset = "0x88")]
		public UISprite EquitIcon;

		// Token: 0x0400E493 RID: 58515
		[Token(Token = "0x400E493")]
		[FieldOffset(Offset = "0x90")]
		public UISprite EquitHightlightSprite;

		// Token: 0x0400E494 RID: 58516
		[Token(Token = "0x400E494")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ItemNameLabel;

		// Token: 0x0400E495 RID: 58517
		[Token(Token = "0x400E495")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel ItemCountLabel;

		// Token: 0x0400E496 RID: 58518
		[Token(Token = "0x400E496")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ItemExpireTimeLable;
	}
}
