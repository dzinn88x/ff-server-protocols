using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002414 RID: 9236
	[Token(Token = "0x2002414")]
	public class UIMallDetailView : UIBaseView
	{
		// Token: 0x0600C338 RID: 49976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C338")]
		[Address(RVA = "0x1C6A264", Offset = "0x1C6A264", VA = "0x7BBC46A264", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C339 RID: 49977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C339")]
		[Address(RVA = "0x1C6B7C0", Offset = "0x1C6B7C0", VA = "0x7BBC46B7C0")]
		public UIMallDetailView()
		{
		}

		// Token: 0x0400E403 RID: 58371
		[Token(Token = "0x400E403")]
		[FieldOffset(Offset = "0x20")]
		public Animation Animation;

		// Token: 0x0400E404 RID: 58372
		[Token(Token = "0x400E404")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GiftRank;

		// Token: 0x0400E405 RID: 58373
		[Token(Token = "0x400E405")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GiftRankName;

		// Token: 0x0400E406 RID: 58374
		[Token(Token = "0x400E406")]
		[FieldOffset(Offset = "0x38")]
		public UISprite GiftRankIcon;

		// Token: 0x0400E407 RID: 58375
		[Token(Token = "0x400E407")]
		[FieldOffset(Offset = "0x40")]
		public UIButton GiftRankBtn;

		// Token: 0x0400E408 RID: 58376
		[Token(Token = "0x400E408")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GiftRankEffect;

		// Token: 0x0400E409 RID: 58377
		[Token(Token = "0x400E409")]
		[FieldOffset(Offset = "0x50")]
		public UIButton RecommendBuyBtn;

		// Token: 0x0400E40A RID: 58378
		[Token(Token = "0x400E40A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject GiftReceive;

		// Token: 0x0400E40B RID: 58379
		[Token(Token = "0x400E40B")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ReceiveNum;

		// Token: 0x0400E40C RID: 58380
		[Token(Token = "0x400E40C")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ReceiveIcon;

		// Token: 0x0400E40D RID: 58381
		[Token(Token = "0x400E40D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject GiftSend;

		// Token: 0x0400E40E RID: 58382
		[Token(Token = "0x400E40E")]
		[FieldOffset(Offset = "0x78")]
		public UILabel SendNum;

		// Token: 0x0400E40F RID: 58383
		[Token(Token = "0x400E40F")]
		[FieldOffset(Offset = "0x80")]
		public UISprite SendIcon;

		// Token: 0x0400E410 RID: 58384
		[Token(Token = "0x400E410")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BtnGroupContainer;

		// Token: 0x0400E411 RID: 58385
		[Token(Token = "0x400E411")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BuyBtn;

		// Token: 0x0400E412 RID: 58386
		[Token(Token = "0x400E412")]
		[FieldOffset(Offset = "0x98")]
		public UISprite BuyBtnBG;

		// Token: 0x0400E413 RID: 58387
		[Token(Token = "0x400E413")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite BuyIcon;

		// Token: 0x0400E414 RID: 58388
		[Token(Token = "0x400E414")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel BuyBtnLabel;

		// Token: 0x0400E415 RID: 58389
		[Token(Token = "0x400E415")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LabelLimitedCount;

		// Token: 0x0400E416 RID: 58390
		[Token(Token = "0x400E416")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton InstallmentTutorialBtn;

		// Token: 0x0400E417 RID: 58391
		[Token(Token = "0x400E417")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton BtnGoExchange;

		// Token: 0x0400E418 RID: 58392
		[Token(Token = "0x400E418")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel LabeGoExchange;

		// Token: 0x0400E419 RID: 58393
		[Token(Token = "0x400E419")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite IconGoExchange;

		// Token: 0x0400E41A RID: 58394
		[Token(Token = "0x400E41A")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BtnGoMystery;

		// Token: 0x0400E41B RID: 58395
		[Token(Token = "0x400E41B")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel LabeGoMystery;

		// Token: 0x0400E41C RID: 58396
		[Token(Token = "0x400E41C")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject IconGoMystery;

		// Token: 0x0400E41D RID: 58397
		[Token(Token = "0x400E41D")]
		[FieldOffset(Offset = "0xF0")]
		public UINetworkTextureExt CdnGoMystery;

		// Token: 0x0400E41E RID: 58398
		[Token(Token = "0x400E41E")]
		[FieldOffset(Offset = "0xF8")]
		public Transform MallPanelContainer;

		// Token: 0x0400E41F RID: 58399
		[Token(Token = "0x400E41F")]
		[FieldOffset(Offset = "0x100")]
		public GameObject MainToggles;

		// Token: 0x0400E420 RID: 58400
		[Token(Token = "0x400E420")]
		[FieldOffset(Offset = "0x108")]
		public UIScrollView MainToggleScrollView;

		// Token: 0x0400E421 RID: 58401
		[Token(Token = "0x400E421")]
		[FieldOffset(Offset = "0x110")]
		public UIToggleButton mallToggle;

		// Token: 0x0400E422 RID: 58402
		[Token(Token = "0x400E422")]
		[FieldOffset(Offset = "0x118")]
		public UIToggleButton petToggle;

		// Token: 0x0400E423 RID: 58403
		[Token(Token = "0x400E423")]
		[FieldOffset(Offset = "0x120")]
		public UIGrid MainToggleGrid;

		// Token: 0x0400E424 RID: 58404
		[Token(Token = "0x400E424")]
		[FieldOffset(Offset = "0x128")]
		public UIToggleButtonGroup MainToggleGroup;

		// Token: 0x0400E425 RID: 58405
		[Token(Token = "0x400E425")]
		[FieldOffset(Offset = "0x130")]
		public UIToggleButton InstallmentToggle;

		// Token: 0x0400E426 RID: 58406
		[Token(Token = "0x400E426")]
		[FieldOffset(Offset = "0x138")]
		public UIToggleButton discountToggle;

		// Token: 0x0400E427 RID: 58407
		[Token(Token = "0x400E427")]
		[FieldOffset(Offset = "0x140")]
		public UIScrollView NormalMallTabScrollView;

		// Token: 0x0400E428 RID: 58408
		[Token(Token = "0x400E428")]
		[FieldOffset(Offset = "0x148")]
		public UIGrid NormalMallTabGrid;

		// Token: 0x0400E429 RID: 58409
		[Token(Token = "0x400E429")]
		[FieldOffset(Offset = "0x150")]
		public UIToggleButtonGroup NormalMallTabGroup;

		// Token: 0x0400E42A RID: 58410
		[Token(Token = "0x400E42A")]
		[FieldOffset(Offset = "0x158")]
		public Animation DiscountAnim;

		// Token: 0x0400E42B RID: 58411
		[Token(Token = "0x400E42B")]
		[FieldOffset(Offset = "0x160")]
		public UILabel MaxOff;

		// Token: 0x0400E42C RID: 58412
		[Token(Token = "0x400E42C")]
		[FieldOffset(Offset = "0x168")]
		public UIWidget CountDownContainer;

		// Token: 0x0400E42D RID: 58413
		[Token(Token = "0x400E42D")]
		[FieldOffset(Offset = "0x170")]
		public Transform DiscountContainer;

		// Token: 0x0400E42E RID: 58414
		[Token(Token = "0x400E42E")]
		[FieldOffset(Offset = "0x178")]
		public GameObject SubToggles;

		// Token: 0x0400E42F RID: 58415
		[Token(Token = "0x400E42F")]
		[FieldOffset(Offset = "0x180")]
		public UIScrollView SubToggleScrollView;

		// Token: 0x0400E430 RID: 58416
		[Token(Token = "0x400E430")]
		[FieldOffset(Offset = "0x188")]
		public UIToggleButton subToggle;

		// Token: 0x0400E431 RID: 58417
		[Token(Token = "0x400E431")]
		[FieldOffset(Offset = "0x190")]
		public UIGrid SubToggleGrid;

		// Token: 0x0400E432 RID: 58418
		[Token(Token = "0x400E432")]
		[FieldOffset(Offset = "0x198")]
		public UIToggleButtonGroup SubToggleGroup;

		// Token: 0x0400E433 RID: 58419
		[Token(Token = "0x400E433")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject side_BG;

		// Token: 0x0400E434 RID: 58420
		[Token(Token = "0x400E434")]
		[FieldOffset(Offset = "0x1A8")]
		public UIScrollView MallScrollView;

		// Token: 0x0400E435 RID: 58421
		[Token(Token = "0x400E435")]
		[FieldOffset(Offset = "0x1B0")]
		public UIEasyList Grid;

		// Token: 0x0400E436 RID: 58422
		[Token(Token = "0x400E436")]
		[FieldOffset(Offset = "0x1B8")]
		public UIScrollView MallBoxItemScrollView;

		// Token: 0x0400E437 RID: 58423
		[Token(Token = "0x400E437")]
		[FieldOffset(Offset = "0x1C0")]
		public UIEasyList BoxItemGrid;

		// Token: 0x0400E438 RID: 58424
		[Token(Token = "0x400E438")]
		[FieldOffset(Offset = "0x1C8")]
		public UIScrollView MallWeaponItemScrollView;

		// Token: 0x0400E439 RID: 58425
		[Token(Token = "0x400E439")]
		[FieldOffset(Offset = "0x1D0")]
		public UIEasyList WeaponItemGrid;

		// Token: 0x0400E43A RID: 58426
		[Token(Token = "0x400E43A")]
		[FieldOffset(Offset = "0x1D8")]
		public UIScrollView MallCrystalItemScrollView;

		// Token: 0x0400E43B RID: 58427
		[Token(Token = "0x400E43B")]
		[FieldOffset(Offset = "0x1E0")]
		public UIEasyList CrystalItemGrid;

		// Token: 0x0400E43C RID: 58428
		[Token(Token = "0x400E43C")]
		[FieldOffset(Offset = "0x1E8")]
		public UIScrollView MallDiscountScrollView;

		// Token: 0x0400E43D RID: 58429
		[Token(Token = "0x400E43D")]
		[FieldOffset(Offset = "0x1F0")]
		public UIEasyList DiscountItemGrid;

		// Token: 0x0400E43E RID: 58430
		[Token(Token = "0x400E43E")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject AdsPanel;

		// Token: 0x0400E43F RID: 58431
		[Token(Token = "0x400E43F")]
		[FieldOffset(Offset = "0x200")]
		public UIScrollView ADScrollView;

		// Token: 0x0400E440 RID: 58432
		[Token(Token = "0x400E440")]
		[FieldOffset(Offset = "0x208")]
		public UIWrapContent AdsContent;

		// Token: 0x0400E441 RID: 58433
		[Token(Token = "0x400E441")]
		[FieldOffset(Offset = "0x210")]
		public GameObject ADEffect;

		// Token: 0x0400E442 RID: 58434
		[Token(Token = "0x400E442")]
		[FieldOffset(Offset = "0x218")]
		public Transform CarouselContainer;

		// Token: 0x0400E443 RID: 58435
		[Token(Token = "0x400E443")]
		[FieldOffset(Offset = "0x220")]
		public UIPanel CarouselPanel;

		// Token: 0x0400E444 RID: 58436
		[Token(Token = "0x400E444")]
		[FieldOffset(Offset = "0x228")]
		public Transform GiftContainer;

		// Token: 0x0400E445 RID: 58437
		[Token(Token = "0x400E445")]
		[FieldOffset(Offset = "0x230")]
		public GameObject NoItemTips;

		// Token: 0x0400E446 RID: 58438
		[Token(Token = "0x400E446")]
		[FieldOffset(Offset = "0x238")]
		public GameObject GenderSelectionContainer;

		// Token: 0x0400E447 RID: 58439
		[Token(Token = "0x400E447")]
		[FieldOffset(Offset = "0x240")]
		public UIToggleButton AllClothToggle;

		// Token: 0x0400E448 RID: 58440
		[Token(Token = "0x400E448")]
		[FieldOffset(Offset = "0x248")]
		public UIToggleButton CommonClothToggle;

		// Token: 0x0400E449 RID: 58441
		[Token(Token = "0x400E449")]
		[FieldOffset(Offset = "0x250")]
		public UIToggleButton MaleClothToggle;

		// Token: 0x0400E44A RID: 58442
		[Token(Token = "0x400E44A")]
		[FieldOffset(Offset = "0x258")]
		public UIToggleButton FemaleClothToggle;

		// Token: 0x0400E44B RID: 58443
		[Token(Token = "0x400E44B")]
		[FieldOffset(Offset = "0x260")]
		public UIWidget WeaponTypeFilter;

		// Token: 0x0400E44C RID: 58444
		[Token(Token = "0x400E44C")]
		[FieldOffset(Offset = "0x268")]
		public UIWidget WeaponModelFilter;

		// Token: 0x0400E44D RID: 58445
		[Token(Token = "0x400E44D")]
		[FieldOffset(Offset = "0x270")]
		public UICountDownLabel LeftTime;

		// Token: 0x0400E44E RID: 58446
		[Token(Token = "0x400E44E")]
		[FieldOffset(Offset = "0x278")]
		public GameObject WeaponMallEffect;

		// Token: 0x0400E44F RID: 58447
		[Token(Token = "0x400E44F")]
		[FieldOffset(Offset = "0x280")]
		public UIToggleButtonGroup SwitchClothPreviewBtnGroup;

		// Token: 0x0400E450 RID: 58448
		[Token(Token = "0x400E450")]
		[FieldOffset(Offset = "0x288")]
		public UIToggleButton SwitchClothMaleBtn;

		// Token: 0x0400E451 RID: 58449
		[Token(Token = "0x400E451")]
		[FieldOffset(Offset = "0x290")]
		public UIToggleButton SwitchClotFemaleBtn;

		// Token: 0x0400E452 RID: 58450
		[Token(Token = "0x400E452")]
		[FieldOffset(Offset = "0x298")]
		public GameObject ClothPreviewTab;

		// Token: 0x0400E453 RID: 58451
		[Token(Token = "0x400E453")]
		[FieldOffset(Offset = "0x2A0")]
		public UIToggleButtonGroup ClothPreviewBtGroup;

		// Token: 0x0400E454 RID: 58452
		[Token(Token = "0x400E454")]
		[FieldOffset(Offset = "0x2A8")]
		public UIToggleButton previewHair;

		// Token: 0x0400E455 RID: 58453
		[Token(Token = "0x400E455")]
		[FieldOffset(Offset = "0x2B0")]
		public UIToggleButton previewFace;

		// Token: 0x0400E456 RID: 58454
		[Token(Token = "0x400E456")]
		[FieldOffset(Offset = "0x2B8")]
		public UIToggleButton previewHeadAdditive;

		// Token: 0x0400E457 RID: 58455
		[Token(Token = "0x400E457")]
		[FieldOffset(Offset = "0x2C0")]
		public UIToggleButton previewChest;

		// Token: 0x0400E458 RID: 58456
		[Token(Token = "0x400E458")]
		[FieldOffset(Offset = "0x2C8")]
		public UIToggleButton previewlegs;

		// Token: 0x0400E459 RID: 58457
		[Token(Token = "0x400E459")]
		[FieldOffset(Offset = "0x2D0")]
		public UIToggleButton previewFeet;

		// Token: 0x0400E45A RID: 58458
		[Token(Token = "0x400E45A")]
		[FieldOffset(Offset = "0x2D8")]
		public UIToggleButton previewClothesSet;

		// Token: 0x0400E45B RID: 58459
		[Token(Token = "0x400E45B")]
		[FieldOffset(Offset = "0x2E0")]
		public GameObject RecommendContainer;

		// Token: 0x0400E45C RID: 58460
		[Token(Token = "0x400E45C")]
		[FieldOffset(Offset = "0x2E8")]
		public UIScrollView RecommendScrollView;

		// Token: 0x0400E45D RID: 58461
		[Token(Token = "0x400E45D")]
		[FieldOffset(Offset = "0x2F0")]
		public UIEasyList RecommendGrid;

		// Token: 0x0400E45E RID: 58462
		[Token(Token = "0x400E45E")]
		[FieldOffset(Offset = "0x2F8")]
		public GameObject RecommendTitle;
	}
}
