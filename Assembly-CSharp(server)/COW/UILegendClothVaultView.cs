using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DD RID: 9181
	[Token(Token = "0x20023DD")]
	public class UILegendClothVaultView : UIBaseView
	{
		// Token: 0x0600C2CA RID: 49866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CA")]
		[Address(RVA = "0x1CB23B4", Offset = "0x1CB23B4", VA = "0x7BBC4B23B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2CB RID: 49867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CB")]
		[Address(RVA = "0x1CB3738", Offset = "0x1CB3738", VA = "0x7BBC4B3738")]
		public UILegendClothVaultView()
		{
		}

		// Token: 0x0400E010 RID: 57360
		[Token(Token = "0x400E010")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelName;

		// Token: 0x0400E011 RID: 57361
		[Token(Token = "0x400E011")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TagPanel;

		// Token: 0x0400E012 RID: 57362
		[Token(Token = "0x400E012")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid GridTagAll;

		// Token: 0x0400E013 RID: 57363
		[Token(Token = "0x400E013")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteIpTag;

		// Token: 0x0400E014 RID: 57364
		[Token(Token = "0x400E014")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelIPName;

		// Token: 0x0400E015 RID: 57365
		[Token(Token = "0x400E015")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid GridTagOthers;

		// Token: 0x0400E016 RID: 57366
		[Token(Token = "0x400E016")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ColorSwitchPanel;

		// Token: 0x0400E017 RID: 57367
		[Token(Token = "0x400E017")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnColorPanel;

		// Token: 0x0400E018 RID: 57368
		[Token(Token = "0x400E018")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelColorPanelTitle;

		// Token: 0x0400E019 RID: 57369
		[Token(Token = "0x400E019")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelColorPanelDesc;

		// Token: 0x0400E01A RID: 57370
		[Token(Token = "0x400E01A")]
		[FieldOffset(Offset = "0x70")]
		public GameObject FeaturePanel;

		// Token: 0x0400E01B RID: 57371
		[Token(Token = "0x400E01B")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LabelFeatureTitle;

		// Token: 0x0400E01C RID: 57372
		[Token(Token = "0x400E01C")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelFeatureTip;

		// Token: 0x0400E01D RID: 57373
		[Token(Token = "0x400E01D")]
		[FieldOffset(Offset = "0x88")]
		public UIScrollView FeatureScrollView;

		// Token: 0x0400E01E RID: 57374
		[Token(Token = "0x400E01E")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid GridProperty;

		// Token: 0x0400E01F RID: 57375
		[Token(Token = "0x400E01F")]
		[FieldOffset(Offset = "0x98")]
		public UIButton BtnHideColorPanel;

		// Token: 0x0400E020 RID: 57376
		[Token(Token = "0x400E020")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ConfirmPanel;

		// Token: 0x0400E021 RID: 57377
		[Token(Token = "0x400E021")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnConfirm;

		// Token: 0x0400E022 RID: 57378
		[Token(Token = "0x400E022")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LabelConfirmTip;

		// Token: 0x0400E023 RID: 57379
		[Token(Token = "0x400E023")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject StoryPanel;

		// Token: 0x0400E024 RID: 57380
		[Token(Token = "0x400E024")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel LabelStoryTitle;

		// Token: 0x0400E025 RID: 57381
		[Token(Token = "0x400E025")]
		[FieldOffset(Offset = "0xC8")]
		public UIPanel PanelStoryDesc;

		// Token: 0x0400E026 RID: 57382
		[Token(Token = "0x400E026")]
		[FieldOffset(Offset = "0xD0")]
		public UIScrollView ScrollViewStoryDesc;

		// Token: 0x0400E027 RID: 57383
		[Token(Token = "0x400E027")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel LabelStoryDesc_unfold;

		// Token: 0x0400E028 RID: 57384
		[Token(Token = "0x400E028")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject GoPanelStoryDrag;

		// Token: 0x0400E029 RID: 57385
		[Token(Token = "0x400E029")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton BtnFoldStory;

		// Token: 0x0400E02A RID: 57386
		[Token(Token = "0x400E02A")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BtnUnFoldStory;

		// Token: 0x0400E02B RID: 57387
		[Token(Token = "0x400E02B")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject ColorPanel;

		// Token: 0x0400E02C RID: 57388
		[Token(Token = "0x400E02C")]
		[FieldOffset(Offset = "0x100")]
		public GameObject GoColorPanelUnlockRank;

		// Token: 0x0400E02D RID: 57389
		[Token(Token = "0x400E02D")]
		[FieldOffset(Offset = "0x108")]
		public UISprite SpriteColorLadderLevelBR;

		// Token: 0x0400E02E RID: 57390
		[Token(Token = "0x400E02E")]
		[FieldOffset(Offset = "0x110")]
		public UISprite SpriteColorLadderLevelCS;

		// Token: 0x0400E02F RID: 57391
		[Token(Token = "0x400E02F")]
		[FieldOffset(Offset = "0x118")]
		public UISprite SpriteColorLadderLevelColor;

		// Token: 0x0400E030 RID: 57392
		[Token(Token = "0x400E030")]
		[FieldOffset(Offset = "0x120")]
		public UILabel LabelColorPanelComponentsTitle;

		// Token: 0x0400E031 RID: 57393
		[Token(Token = "0x400E031")]
		[FieldOffset(Offset = "0x128")]
		public UIButton BtnColorPanelComponentHair;

		// Token: 0x0400E032 RID: 57394
		[Token(Token = "0x400E032")]
		[FieldOffset(Offset = "0x130")]
		public UISprite SpriteColorPanelComponentBgHair;

		// Token: 0x0400E033 RID: 57395
		[Token(Token = "0x400E033")]
		[FieldOffset(Offset = "0x138")]
		public UISprite SpriteColorPanelComponentHair;

		// Token: 0x0400E034 RID: 57396
		[Token(Token = "0x400E034")]
		[FieldOffset(Offset = "0x140")]
		public GameObject GoColorPanelPickingHair;

		// Token: 0x0400E035 RID: 57397
		[Token(Token = "0x400E035")]
		[FieldOffset(Offset = "0x148")]
		public GameObject GoColorPanelUnPickingHair;

		// Token: 0x0400E036 RID: 57398
		[Token(Token = "0x400E036")]
		[FieldOffset(Offset = "0x150")]
		public UISprite SpriteColorPanelCurrentColorHair;

		// Token: 0x0400E037 RID: 57399
		[Token(Token = "0x400E037")]
		[FieldOffset(Offset = "0x158")]
		public UIButton BtnColorPanelComponentFace;

		// Token: 0x0400E038 RID: 57400
		[Token(Token = "0x400E038")]
		[FieldOffset(Offset = "0x160")]
		public GameObject GoColorPanelPickingFace;

		// Token: 0x0400E039 RID: 57401
		[Token(Token = "0x400E039")]
		[FieldOffset(Offset = "0x168")]
		public GameObject GoColorPanelUnPickingFace;

		// Token: 0x0400E03A RID: 57402
		[Token(Token = "0x400E03A")]
		[FieldOffset(Offset = "0x170")]
		public UISprite SpriteColorPanelComponentBgFace;

		// Token: 0x0400E03B RID: 57403
		[Token(Token = "0x400E03B")]
		[FieldOffset(Offset = "0x178")]
		public UISprite SpriteColorPanelComponentFace;

		// Token: 0x0400E03C RID: 57404
		[Token(Token = "0x400E03C")]
		[FieldOffset(Offset = "0x180")]
		public UISprite SpriteColorPanelCurrentColorFace;

		// Token: 0x0400E03D RID: 57405
		[Token(Token = "0x400E03D")]
		[FieldOffset(Offset = "0x188")]
		public UIButton BtnColorPanelComponentHeadAdditive;

		// Token: 0x0400E03E RID: 57406
		[Token(Token = "0x400E03E")]
		[FieldOffset(Offset = "0x190")]
		public UISprite SpriteColorPanelCurrentColorHeadAdditive;

		// Token: 0x0400E03F RID: 57407
		[Token(Token = "0x400E03F")]
		[FieldOffset(Offset = "0x198")]
		public GameObject GoColorPanelPickingHeadAdditive;

		// Token: 0x0400E040 RID: 57408
		[Token(Token = "0x400E040")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject GoColorPanelUnPickingHeadAdditive;

		// Token: 0x0400E041 RID: 57409
		[Token(Token = "0x400E041")]
		[FieldOffset(Offset = "0x1A8")]
		public UISprite SpriteColorPanelComponentBgHeadAdditive;

		// Token: 0x0400E042 RID: 57410
		[Token(Token = "0x400E042")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite SpriteColorPanelComponentHeadAdditive;

		// Token: 0x0400E043 RID: 57411
		[Token(Token = "0x400E043")]
		[FieldOffset(Offset = "0x1B8")]
		public UIButton BtnColorPanelComponentChest;

		// Token: 0x0400E044 RID: 57412
		[Token(Token = "0x400E044")]
		[FieldOffset(Offset = "0x1C0")]
		public UISprite SpriteColorPanelCurrentColorChest;

		// Token: 0x0400E045 RID: 57413
		[Token(Token = "0x400E045")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject GoColorPanelPickingChest;

		// Token: 0x0400E046 RID: 57414
		[Token(Token = "0x400E046")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject GoColorPanelUnPickingChest;

		// Token: 0x0400E047 RID: 57415
		[Token(Token = "0x400E047")]
		[FieldOffset(Offset = "0x1D8")]
		public UISprite SpriteColorPanelComponentBgChest;

		// Token: 0x0400E048 RID: 57416
		[Token(Token = "0x400E048")]
		[FieldOffset(Offset = "0x1E0")]
		public UISprite SpriteColorPanelComponentChest;

		// Token: 0x0400E049 RID: 57417
		[Token(Token = "0x400E049")]
		[FieldOffset(Offset = "0x1E8")]
		public UIButton BtnColorPanelComponentLegs;

		// Token: 0x0400E04A RID: 57418
		[Token(Token = "0x400E04A")]
		[FieldOffset(Offset = "0x1F0")]
		public UISprite SpriteColorPanelCurrentColorLegs;

		// Token: 0x0400E04B RID: 57419
		[Token(Token = "0x400E04B")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject GoColorPanelPickingLegs;

		// Token: 0x0400E04C RID: 57420
		[Token(Token = "0x400E04C")]
		[FieldOffset(Offset = "0x200")]
		public GameObject GoColorPanelUnPickingLegs;

		// Token: 0x0400E04D RID: 57421
		[Token(Token = "0x400E04D")]
		[FieldOffset(Offset = "0x208")]
		public UISprite SpriteColorPanelComponentBgLegs;

		// Token: 0x0400E04E RID: 57422
		[Token(Token = "0x400E04E")]
		[FieldOffset(Offset = "0x210")]
		public UISprite SpriteColorPanelComponentLegs;

		// Token: 0x0400E04F RID: 57423
		[Token(Token = "0x400E04F")]
		[FieldOffset(Offset = "0x218")]
		public UIButton BtnColorPanelComponentFeet;

		// Token: 0x0400E050 RID: 57424
		[Token(Token = "0x400E050")]
		[FieldOffset(Offset = "0x220")]
		public UISprite SpriteColorPanelCurrentColorFeet;

		// Token: 0x0400E051 RID: 57425
		[Token(Token = "0x400E051")]
		[FieldOffset(Offset = "0x228")]
		public GameObject GoColorPanelPickingFeet;

		// Token: 0x0400E052 RID: 57426
		[Token(Token = "0x400E052")]
		[FieldOffset(Offset = "0x230")]
		public GameObject GoColorPanelUnPickingFeet;

		// Token: 0x0400E053 RID: 57427
		[Token(Token = "0x400E053")]
		[FieldOffset(Offset = "0x238")]
		public UISprite SpriteColorPanelComponentBgFeet;

		// Token: 0x0400E054 RID: 57428
		[Token(Token = "0x400E054")]
		[FieldOffset(Offset = "0x240")]
		public UISprite SpriteColorPanelComponentFeet;

		// Token: 0x0400E055 RID: 57429
		[Token(Token = "0x400E055")]
		[FieldOffset(Offset = "0x248")]
		public UIButton BtnColorPanelComponentsAll;

		// Token: 0x0400E056 RID: 57430
		[Token(Token = "0x400E056")]
		[FieldOffset(Offset = "0x250")]
		public UISprite SpriteColorPanelCurrentColorAll;

		// Token: 0x0400E057 RID: 57431
		[Token(Token = "0x400E057")]
		[FieldOffset(Offset = "0x258")]
		public GameObject GoColorPanelPickingAll;

		// Token: 0x0400E058 RID: 57432
		[Token(Token = "0x400E058")]
		[FieldOffset(Offset = "0x260")]
		public GameObject GoColorPanelUnPickingAll;

		// Token: 0x0400E059 RID: 57433
		[Token(Token = "0x400E059")]
		[FieldOffset(Offset = "0x268")]
		public UISprite SpriteColorPanelComponentBgAll;

		// Token: 0x0400E05A RID: 57434
		[Token(Token = "0x400E05A")]
		[FieldOffset(Offset = "0x270")]
		public UISprite SpriteColorPanelComponentsAll;

		// Token: 0x0400E05B RID: 57435
		[Token(Token = "0x400E05B")]
		[FieldOffset(Offset = "0x278")]
		public UISprite SpriteColorPanelCurrentColorAllSplitColor;

		// Token: 0x0400E05C RID: 57436
		[Token(Token = "0x400E05C")]
		[FieldOffset(Offset = "0x280")]
		public UILabel LabelColorPickTitle;

		// Token: 0x0400E05D RID: 57437
		[Token(Token = "0x400E05D")]
		[FieldOffset(Offset = "0x288")]
		public UIGrid GridColor;

		// Token: 0x0400E05E RID: 57438
		[Token(Token = "0x400E05E")]
		[FieldOffset(Offset = "0x290")]
		public UIButton BtnPurchase;

		// Token: 0x0400E05F RID: 57439
		[Token(Token = "0x400E05F")]
		[FieldOffset(Offset = "0x298")]
		public GameObject ClothSlotPanel;

		// Token: 0x0400E060 RID: 57440
		[Token(Token = "0x400E060")]
		[FieldOffset(Offset = "0x2A0")]
		public UILabel LabelGenderNotMatchTip;

		// Token: 0x0400E061 RID: 57441
		[Token(Token = "0x400E061")]
		[FieldOffset(Offset = "0x2A8")]
		public UIButton BtnGotoAvatarProfile;

		// Token: 0x0400E062 RID: 57442
		[Token(Token = "0x400E062")]
		[FieldOffset(Offset = "0x2B0")]
		public GameObject GoSlotHair;

		// Token: 0x0400E063 RID: 57443
		[Token(Token = "0x400E063")]
		[FieldOffset(Offset = "0x2B8")]
		public GameObject GoSlotFace;

		// Token: 0x0400E064 RID: 57444
		[Token(Token = "0x400E064")]
		[FieldOffset(Offset = "0x2C0")]
		public GameObject GoSlotChest;

		// Token: 0x0400E065 RID: 57445
		[Token(Token = "0x400E065")]
		[FieldOffset(Offset = "0x2C8")]
		public GameObject GoSlotLegs;

		// Token: 0x0400E066 RID: 57446
		[Token(Token = "0x400E066")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject GoSlotFeet;

		// Token: 0x0400E067 RID: 57447
		[Token(Token = "0x400E067")]
		[FieldOffset(Offset = "0x2D8")]
		public GameObject GoSlotHeadAdditive;
	}
}
