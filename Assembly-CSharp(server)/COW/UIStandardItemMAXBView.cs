using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200254F RID: 9551
	[Token(Token = "0x200254F")]
	public class UIStandardItemMAXBView : UIBaseView
	{
		// Token: 0x0600C5AE RID: 50606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AE")]
		[Address(RVA = "0x163E1E0", Offset = "0x163E1E0", VA = "0x7BBBE3E1E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5AF RID: 50607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AF")]
		[Address(RVA = "0x163ED50", Offset = "0x163ED50", VA = "0x7BBBE3ED50")]
		public UIStandardItemMAXBView()
		{
		}

		// Token: 0x0400F475 RID: 62581
		[Token(Token = "0x400F475")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400F476 RID: 62582
		[Token(Token = "0x400F476")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400F477 RID: 62583
		[Token(Token = "0x400F477")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VFX;

		// Token: 0x0400F478 RID: 62584
		[Token(Token = "0x400F478")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GreyBg;

		// Token: 0x0400F479 RID: 62585
		[Token(Token = "0x400F479")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLightBG;

		// Token: 0x0400F47A RID: 62586
		[Token(Token = "0x400F47A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NewLabel;

		// Token: 0x0400F47B RID: 62587
		[Token(Token = "0x400F47B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LimitedLabel;

		// Token: 0x0400F47C RID: 62588
		[Token(Token = "0x400F47C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LimitedPurchaseLabel;

		// Token: 0x0400F47D RID: 62589
		[Token(Token = "0x400F47D")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HotLabel;

		// Token: 0x0400F47E RID: 62590
		[Token(Token = "0x400F47E")]
		[FieldOffset(Offset = "0x68")]
		public UILabel DiscountLabel;

		// Token: 0x0400F47F RID: 62591
		[Token(Token = "0x400F47F")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DiscountVFX;

		// Token: 0x0400F480 RID: 62592
		[Token(Token = "0x400F480")]
		[FieldOffset(Offset = "0x78")]
		public GameObject EarlyBirdLabel;

		// Token: 0x0400F481 RID: 62593
		[Token(Token = "0x400F481")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ExpireTime;

		// Token: 0x0400F482 RID: 62594
		[Token(Token = "0x400F482")]
		[FieldOffset(Offset = "0x88")]
		public UISprite QualityBG;

		// Token: 0x0400F483 RID: 62595
		[Token(Token = "0x400F483")]
		[FieldOffset(Offset = "0x90")]
		public UISprite QualityNameBG01;

		// Token: 0x0400F484 RID: 62596
		[Token(Token = "0x400F484")]
		[FieldOffset(Offset = "0x98")]
		public GameObject BaseItemView;

		// Token: 0x0400F485 RID: 62597
		[Token(Token = "0x400F485")]
		[FieldOffset(Offset = "0xA0")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400F486 RID: 62598
		[Token(Token = "0x400F486")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite VoucherIcon;

		// Token: 0x0400F487 RID: 62599
		[Token(Token = "0x400F487")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject BaseitemName;

		// Token: 0x0400F488 RID: 62600
		[Token(Token = "0x400F488")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject Free;

		// Token: 0x0400F489 RID: 62601
		[Token(Token = "0x400F489")]
		[FieldOffset(Offset = "0xC0")]
		public UIGrid PriceContainer;

		// Token: 0x0400F48A RID: 62602
		[Token(Token = "0x400F48A")]
		[FieldOffset(Offset = "0xC8")]
		public Transform GoldContainer;

		// Token: 0x0400F48B RID: 62603
		[Token(Token = "0x400F48B")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel GoldPriceLabel;

		// Token: 0x0400F48C RID: 62604
		[Token(Token = "0x400F48C")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel GoldOriginalPriceLabel;

		// Token: 0x0400F48D RID: 62605
		[Token(Token = "0x400F48D")]
		[FieldOffset(Offset = "0xE0")]
		public Transform DiamondContainer;

		// Token: 0x0400F48E RID: 62606
		[Token(Token = "0x400F48E")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel DiamondPriceLabel;

		// Token: 0x0400F48F RID: 62607
		[Token(Token = "0x400F48F")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel DiamondOriginalPriceLabel;

		// Token: 0x0400F490 RID: 62608
		[Token(Token = "0x400F490")]
		[FieldOffset(Offset = "0xF8")]
		public Transform ExchangeContainer;

		// Token: 0x0400F491 RID: 62609
		[Token(Token = "0x400F491")]
		[FieldOffset(Offset = "0x100")]
		public UILabel ExchangePriceLabel;

		// Token: 0x0400F492 RID: 62610
		[Token(Token = "0x400F492")]
		[FieldOffset(Offset = "0x108")]
		public UISprite ExchangeIcon;

		// Token: 0x0400F493 RID: 62611
		[Token(Token = "0x400F493")]
		[FieldOffset(Offset = "0x110")]
		public GameObject GemsAndGoldContainer;

		// Token: 0x0400F494 RID: 62612
		[Token(Token = "0x400F494")]
		[FieldOffset(Offset = "0x118")]
		public UILabel DualCurrencyGoldPrice;

		// Token: 0x0400F495 RID: 62613
		[Token(Token = "0x400F495")]
		[FieldOffset(Offset = "0x120")]
		public UILabel DualCurrencyGemsPrice;

		// Token: 0x0400F496 RID: 62614
		[Token(Token = "0x400F496")]
		[FieldOffset(Offset = "0x128")]
		public GameObject CheckIcon;

		// Token: 0x0400F497 RID: 62615
		[Token(Token = "0x400F497")]
		[FieldOffset(Offset = "0x130")]
		public GameObject OverDueTitle;

		// Token: 0x0400F498 RID: 62616
		[Token(Token = "0x400F498")]
		[FieldOffset(Offset = "0x138")]
		public GameObject LockedTitle;

		// Token: 0x0400F499 RID: 62617
		[Token(Token = "0x400F499")]
		[FieldOffset(Offset = "0x140")]
		public GameObject OwnedTitle;

		// Token: 0x0400F49A RID: 62618
		[Token(Token = "0x400F49A")]
		[FieldOffset(Offset = "0x148")]
		public GameObject ClaimedTitle;

		// Token: 0x0400F49B RID: 62619
		[Token(Token = "0x400F49B")]
		[FieldOffset(Offset = "0x150")]
		public GameObject LimitedTitle;

		// Token: 0x0400F49C RID: 62620
		[Token(Token = "0x400F49C")]
		[FieldOffset(Offset = "0x158")]
		public UILabel CanNotEquipTitle;

		// Token: 0x0400F49D RID: 62621
		[Token(Token = "0x400F49D")]
		[FieldOffset(Offset = "0x160")]
		public GameObject PreviewFemale;

		// Token: 0x0400F49E RID: 62622
		[Token(Token = "0x400F49E")]
		[FieldOffset(Offset = "0x168")]
		public GameObject PreviewMale;

		// Token: 0x0400F49F RID: 62623
		[Token(Token = "0x400F49F")]
		[FieldOffset(Offset = "0x170")]
		public GameObject PreviewCommon;

		// Token: 0x0400F4A0 RID: 62624
		[Token(Token = "0x400F4A0")]
		[FieldOffset(Offset = "0x178")]
		public GameObject WebTitleContainer;

		// Token: 0x0400F4A1 RID: 62625
		[Token(Token = "0x400F4A1")]
		[FieldOffset(Offset = "0x180")]
		public UISprite RankIcon;

		// Token: 0x0400F4A2 RID: 62626
		[Token(Token = "0x400F4A2")]
		[FieldOffset(Offset = "0x188")]
		public UISprite Descargar;

		// Token: 0x0400F4A3 RID: 62627
		[Token(Token = "0x400F4A3")]
		[FieldOffset(Offset = "0x190")]
		public UILabel ClanLevelLabel;

		// Token: 0x0400F4A4 RID: 62628
		[Token(Token = "0x400F4A4")]
		[FieldOffset(Offset = "0x198")]
		public UISprite IPTag;

		// Token: 0x0400F4A5 RID: 62629
		[Token(Token = "0x400F4A5")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject DiscountEffect;

		// Token: 0x0400F4A6 RID: 62630
		[Token(Token = "0x400F4A6")]
		[FieldOffset(Offset = "0x1A8")]
		public UITipsButton Tips;
	}
}
