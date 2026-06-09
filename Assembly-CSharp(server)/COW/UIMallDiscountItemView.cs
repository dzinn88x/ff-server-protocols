using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002415 RID: 9237
	[Token(Token = "0x2002415")]
	public class UIMallDiscountItemView : UIBaseView
	{
		// Token: 0x0600C33A RID: 49978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33A")]
		[Address(RVA = "0x1C6B7C8", Offset = "0x1C6B7C8", VA = "0x7BBC46B7C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C33B RID: 49979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C33B")]
		[Address(RVA = "0x1C6C0E0", Offset = "0x1C6C0E0", VA = "0x7BBC46C0E0")]
		public UIMallDiscountItemView()
		{
		}

		// Token: 0x0400E45F RID: 58463
		[Token(Token = "0x400E45F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E460 RID: 58464
		[Token(Token = "0x400E460")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400E461 RID: 58465
		[Token(Token = "0x400E461")]
		[FieldOffset(Offset = "0x30")]
		public UITipsButton tipsButton;

		// Token: 0x0400E462 RID: 58466
		[Token(Token = "0x400E462")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400E463 RID: 58467
		[Token(Token = "0x400E463")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TimaAndCount;

		// Token: 0x0400E464 RID: 58468
		[Token(Token = "0x400E464")]
		[FieldOffset(Offset = "0x48")]
		public UILabel time;

		// Token: 0x0400E465 RID: 58469
		[Token(Token = "0x400E465")]
		[FieldOffset(Offset = "0x50")]
		public UISprite QualityBG;

		// Token: 0x0400E466 RID: 58470
		[Token(Token = "0x400E466")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Quality;

		// Token: 0x0400E467 RID: 58471
		[Token(Token = "0x400E467")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BG_grey;

		// Token: 0x0400E468 RID: 58472
		[Token(Token = "0x400E468")]
		[FieldOffset(Offset = "0x68")]
		public GameObject PreviewFemale;

		// Token: 0x0400E469 RID: 58473
		[Token(Token = "0x400E469")]
		[FieldOffset(Offset = "0x70")]
		public GameObject PreviewMale;

		// Token: 0x0400E46A RID: 58474
		[Token(Token = "0x400E46A")]
		[FieldOffset(Offset = "0x78")]
		public UISprite Descargar;

		// Token: 0x0400E46B RID: 58475
		[Token(Token = "0x400E46B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LimitedTitle;

		// Token: 0x0400E46C RID: 58476
		[Token(Token = "0x400E46C")]
		[FieldOffset(Offset = "0x88")]
		public UIButton DownloadBtn;

		// Token: 0x0400E46D RID: 58477
		[Token(Token = "0x400E46D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject UniquedTitle;

		// Token: 0x0400E46E RID: 58478
		[Token(Token = "0x400E46E")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GetTitle;

		// Token: 0x0400E46F RID: 58479
		[Token(Token = "0x400E46F")]
		[FieldOffset(Offset = "0xA0")]
		public Transform GoldContainer;

		// Token: 0x0400E470 RID: 58480
		[Token(Token = "0x400E470")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject GoldIcon;

		// Token: 0x0400E471 RID: 58481
		[Token(Token = "0x400E471")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel GoldPriceLabel;

		// Token: 0x0400E472 RID: 58482
		[Token(Token = "0x400E472")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel OriginGoldPriceLabel;

		// Token: 0x0400E473 RID: 58483
		[Token(Token = "0x400E473")]
		[FieldOffset(Offset = "0xC0")]
		public Transform DiamondContainer;

		// Token: 0x0400E474 RID: 58484
		[Token(Token = "0x400E474")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel DiamondPriceLabel;

		// Token: 0x0400E475 RID: 58485
		[Token(Token = "0x400E475")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject DiamonIcon;

		// Token: 0x0400E476 RID: 58486
		[Token(Token = "0x400E476")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel OriginDiamondPriceLabel;

		// Token: 0x0400E477 RID: 58487
		[Token(Token = "0x400E477")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject Discount;

		// Token: 0x0400E478 RID: 58488
		[Token(Token = "0x400E478")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite DiscountBG;

		// Token: 0x0400E479 RID: 58489
		[Token(Token = "0x400E479")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel DiscountLabel;

		// Token: 0x0400E47A RID: 58490
		[Token(Token = "0x400E47A")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite ItemIcon;

		// Token: 0x0400E47B RID: 58491
		[Token(Token = "0x400E47B")]
		[FieldOffset(Offset = "0x100")]
		public UISprite HeadIcon;

		// Token: 0x0400E47C RID: 58492
		[Token(Token = "0x400E47C")]
		[FieldOffset(Offset = "0x108")]
		public UISprite BannerIcon;

		// Token: 0x0400E47D RID: 58493
		[Token(Token = "0x400E47D")]
		[FieldOffset(Offset = "0x110")]
		public UISprite DebrisIcon;

		// Token: 0x0400E47E RID: 58494
		[Token(Token = "0x400E47E")]
		[FieldOffset(Offset = "0x118")]
		public UISprite VehicleSkinIcon;

		// Token: 0x0400E47F RID: 58495
		[Token(Token = "0x400E47F")]
		[FieldOffset(Offset = "0x120")]
		public UISprite WeaponSkinIcon;

		// Token: 0x0400E480 RID: 58496
		[Token(Token = "0x400E480")]
		[FieldOffset(Offset = "0x128")]
		public UISprite RankIcon;

		// Token: 0x0400E481 RID: 58497
		[Token(Token = "0x400E481")]
		[FieldOffset(Offset = "0x130")]
		public UISprite VoucherIcon;

		// Token: 0x0400E482 RID: 58498
		[Token(Token = "0x400E482")]
		[FieldOffset(Offset = "0x138")]
		public UISprite RedEnvelopeIcon;

		// Token: 0x0400E483 RID: 58499
		[Token(Token = "0x400E483")]
		[FieldOffset(Offset = "0x140")]
		public GameObject HighLightBG;

		// Token: 0x0400E484 RID: 58500
		[Token(Token = "0x400E484")]
		[FieldOffset(Offset = "0x148")]
		public GameObject Effect;
	}
}
