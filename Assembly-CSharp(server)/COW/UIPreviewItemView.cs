using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024A0 RID: 9376
	[Token(Token = "0x20024A0")]
	public class UIPreviewItemView : UIBaseView
	{
		// Token: 0x0600C450 RID: 50256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C450")]
		[Address(RVA = "0x2185810", Offset = "0x2185810", VA = "0x7BBC985810", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C451 RID: 50257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C451")]
		[Address(RVA = "0x2187734", Offset = "0x2187734", VA = "0x7BBC987734")]
		public UIPreviewItemView()
		{
		}

		// Token: 0x0400EC0E RID: 60430
		[Token(Token = "0x400EC0E")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel UIPreviewItem;

		// Token: 0x0400EC0F RID: 60431
		[Token(Token = "0x400EC0F")]
		[FieldOffset(Offset = "0x28")]
		public Transform CommonPanelContainer;

		// Token: 0x0400EC10 RID: 60432
		[Token(Token = "0x400EC10")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha TweenAnim;

		// Token: 0x0400EC11 RID: 60433
		[Token(Token = "0x400EC11")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView PreviewScrollView;

		// Token: 0x0400EC12 RID: 60434
		[Token(Token = "0x400EC12")]
		[FieldOffset(Offset = "0x40")]
		public UIPanel PreviewScrollViewPanel;

		// Token: 0x0400EC13 RID: 60435
		[Token(Token = "0x400EC13")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList previewGrid;

		// Token: 0x0400EC14 RID: 60436
		[Token(Token = "0x400EC14")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SkillInfo;

		// Token: 0x0400EC15 RID: 60437
		[Token(Token = "0x400EC15")]
		[FieldOffset(Offset = "0x58")]
		public UILabel SkillTipsCenter;

		// Token: 0x0400EC16 RID: 60438
		[Token(Token = "0x400EC16")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SkillName;

		// Token: 0x0400EC17 RID: 60439
		[Token(Token = "0x400EC17")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SkillIcon;

		// Token: 0x0400EC18 RID: 60440
		[Token(Token = "0x400EC18")]
		[FieldOffset(Offset = "0x70")]
		public UISprite SkillSprBgCenter;

		// Token: 0x0400EC19 RID: 60441
		[Token(Token = "0x400EC19")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ItemDesc;

		// Token: 0x0400EC1A RID: 60442
		[Token(Token = "0x400EC1A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject itemsdesc;

		// Token: 0x0400EC1B RID: 60443
		[Token(Token = "0x400EC1B")]
		[FieldOffset(Offset = "0x88")]
		public UISprite itemdescrightposspr;

		// Token: 0x0400EC1C RID: 60444
		[Token(Token = "0x400EC1C")]
		[FieldOffset(Offset = "0x90")]
		public UISprite AlignmentIcon;

		// Token: 0x0400EC1D RID: 60445
		[Token(Token = "0x400EC1D")]
		[FieldOffset(Offset = "0x98")]
		public UIButton alignmentBtn;

		// Token: 0x0400EC1E RID: 60446
		[Token(Token = "0x400EC1E")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel AlignmentName;

		// Token: 0x0400EC1F RID: 60447
		[Token(Token = "0x400EC1F")]
		[FieldOffset(Offset = "0xA8")]
		public UIScrollView DescScrollview;

		// Token: 0x0400EC20 RID: 60448
		[Token(Token = "0x400EC20")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel itemDescLabel;

		// Token: 0x0400EC21 RID: 60449
		[Token(Token = "0x400EC21")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject itemsname;

		// Token: 0x0400EC22 RID: 60450
		[Token(Token = "0x400EC22")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite NewQualityiconBgY;

		// Token: 0x0400EC23 RID: 60451
		[Token(Token = "0x400EC23")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel itemNameLabel;

		// Token: 0x0400EC24 RID: 60452
		[Token(Token = "0x400EC24")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite itemnamerightposspr;

		// Token: 0x0400EC25 RID: 60453
		[Token(Token = "0x400EC25")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite NewQualityicon;

		// Token: 0x0400EC26 RID: 60454
		[Token(Token = "0x400EC26")]
		[FieldOffset(Offset = "0xE0")]
		public UITable IconTable;

		// Token: 0x0400EC27 RID: 60455
		[Token(Token = "0x400EC27")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton notificationIconBtn;

		// Token: 0x0400EC28 RID: 60456
		[Token(Token = "0x400EC28")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject notificationIcon;

		// Token: 0x0400EC29 RID: 60457
		[Token(Token = "0x400EC29")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject showIcon;

		// Token: 0x0400EC2A RID: 60458
		[Token(Token = "0x400EC2A")]
		[FieldOffset(Offset = "0x100")]
		public UIButton showIconBtn;

		// Token: 0x0400EC2B RID: 60459
		[Token(Token = "0x400EC2B")]
		[FieldOffset(Offset = "0x108")]
		public UISprite SkillSpirte;

		// Token: 0x0400EC2C RID: 60460
		[Token(Token = "0x400EC2C")]
		[FieldOffset(Offset = "0x110")]
		public UIButton skillbtn;

		// Token: 0x0400EC2D RID: 60461
		[Token(Token = "0x400EC2D")]
		[FieldOffset(Offset = "0x118")]
		public UIButton tipsleft;

		// Token: 0x0400EC2E RID: 60462
		[Token(Token = "0x400EC2E")]
		[FieldOffset(Offset = "0x120")]
		public UILabel skilltiplabelleft;

		// Token: 0x0400EC2F RID: 60463
		[Token(Token = "0x400EC2F")]
		[FieldOffset(Offset = "0x128")]
		public UIButton tipsright;

		// Token: 0x0400EC30 RID: 60464
		[Token(Token = "0x400EC30")]
		[FieldOffset(Offset = "0x130")]
		public UILabel skilltiplabelright;

		// Token: 0x0400EC31 RID: 60465
		[Token(Token = "0x400EC31")]
		[FieldOffset(Offset = "0x138")]
		public UISprite SkillSprBg;

		// Token: 0x0400EC32 RID: 60466
		[Token(Token = "0x400EC32")]
		[FieldOffset(Offset = "0x140")]
		public UISprite sexicon;

		// Token: 0x0400EC33 RID: 60467
		[Token(Token = "0x400EC33")]
		[FieldOffset(Offset = "0x148")]
		public GameObject weaponSkinUpgradeInfoIcon;

		// Token: 0x0400EC34 RID: 60468
		[Token(Token = "0x400EC34")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnWeaponSkinUpgradeInfoIcon;

		// Token: 0x0400EC35 RID: 60469
		[Token(Token = "0x400EC35")]
		[FieldOffset(Offset = "0x158")]
		public UISprite IPTag;

		// Token: 0x0400EC36 RID: 60470
		[Token(Token = "0x400EC36")]
		[FieldOffset(Offset = "0x160")]
		public UIButton ForgeAwardBtn;

		// Token: 0x0400EC37 RID: 60471
		[Token(Token = "0x400EC37")]
		[FieldOffset(Offset = "0x168")]
		public UISprite ForgeAwardIcon;

		// Token: 0x0400EC38 RID: 60472
		[Token(Token = "0x400EC38")]
		[FieldOffset(Offset = "0x170")]
		public GameObject BundlePreviewTitle;

		// Token: 0x0400EC39 RID: 60473
		[Token(Token = "0x400EC39")]
		[FieldOffset(Offset = "0x178")]
		public UISprite bundlebg;

		// Token: 0x0400EC3A RID: 60474
		[Token(Token = "0x400EC3A")]
		[FieldOffset(Offset = "0x180")]
		public UILabel PreviewTitleLabel;

		// Token: 0x0400EC3B RID: 60475
		[Token(Token = "0x400EC3B")]
		[FieldOffset(Offset = "0x188")]
		public GameObject BackpackLevel;

		// Token: 0x0400EC3C RID: 60476
		[Token(Token = "0x400EC3C")]
		[FieldOffset(Offset = "0x190")]
		public UIToggleButton BtnLv1;

		// Token: 0x0400EC3D RID: 60477
		[Token(Token = "0x400EC3D")]
		[FieldOffset(Offset = "0x198")]
		public UIToggleButton BtnLv2;

		// Token: 0x0400EC3E RID: 60478
		[Token(Token = "0x400EC3E")]
		[FieldOffset(Offset = "0x1A0")]
		public UIToggleButton BtnLv3;

		// Token: 0x0400EC3F RID: 60479
		[Token(Token = "0x400EC3F")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject tail;

		// Token: 0x0400EC40 RID: 60480
		[Token(Token = "0x400EC40")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject Backpacklevelright;

		// Token: 0x0400EC41 RID: 60481
		[Token(Token = "0x400EC41")]
		[FieldOffset(Offset = "0x1B8")]
		public UIToggleButton btnlv1right;

		// Token: 0x0400EC42 RID: 60482
		[Token(Token = "0x400EC42")]
		[FieldOffset(Offset = "0x1C0")]
		public UIToggleButton btnlv2right;

		// Token: 0x0400EC43 RID: 60483
		[Token(Token = "0x400EC43")]
		[FieldOffset(Offset = "0x1C8")]
		public UIToggleButton btnlv3right;

		// Token: 0x0400EC44 RID: 60484
		[Token(Token = "0x400EC44")]
		[FieldOffset(Offset = "0x1D0")]
		public UITable propertyIconTable;

		// Token: 0x0400EC45 RID: 60485
		[Token(Token = "0x400EC45")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject propertyContainer;

		// Token: 0x0400EC46 RID: 60486
		[Token(Token = "0x400EC46")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject VehicleSkinScoreTable;

		// Token: 0x0400EC47 RID: 60487
		[Token(Token = "0x400EC47")]
		[FieldOffset(Offset = "0x1E8")]
		public UIGrid VehicleScoreGrid;

		// Token: 0x0400EC48 RID: 60488
		[Token(Token = "0x400EC48")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject pvpPropertyContainer;

		// Token: 0x0400EC49 RID: 60489
		[Token(Token = "0x400EC49")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject propertyScore;

		// Token: 0x0400EC4A RID: 60490
		[Token(Token = "0x400EC4A")]
		[FieldOffset(Offset = "0x200")]
		public UITable propertyTable;

		// Token: 0x0400EC4B RID: 60491
		[Token(Token = "0x400EC4B")]
		[FieldOffset(Offset = "0x208")]
		public UIGrid scoreGrid;

		// Token: 0x0400EC4C RID: 60492
		[Token(Token = "0x400EC4C")]
		[FieldOffset(Offset = "0x210")]
		public GameObject weaponSkill;

		// Token: 0x0400EC4D RID: 60493
		[Token(Token = "0x400EC4D")]
		[FieldOffset(Offset = "0x218")]
		public UIButton weaponskillbtn;

		// Token: 0x0400EC4E RID: 60494
		[Token(Token = "0x400EC4E")]
		[FieldOffset(Offset = "0x220")]
		public UISprite SpriteWeaponskillIcon;

		// Token: 0x0400EC4F RID: 60495
		[Token(Token = "0x400EC4F")]
		[FieldOffset(Offset = "0x228")]
		public GameObject pvePropertyContainer;

		// Token: 0x0400EC50 RID: 60496
		[Token(Token = "0x400EC50")]
		[FieldOffset(Offset = "0x230")]
		public GameObject pveweaponProperty;

		// Token: 0x0400EC51 RID: 60497
		[Token(Token = "0x400EC51")]
		[FieldOffset(Offset = "0x238")]
		public GameObject skillicon;

		// Token: 0x0400EC52 RID: 60498
		[Token(Token = "0x400EC52")]
		[FieldOffset(Offset = "0x240")]
		public UIGrid toggleGrid;

		// Token: 0x0400EC53 RID: 60499
		[Token(Token = "0x400EC53")]
		[FieldOffset(Offset = "0x248")]
		public UIToggleButton pvpToggle;

		// Token: 0x0400EC54 RID: 60500
		[Token(Token = "0x400EC54")]
		[FieldOffset(Offset = "0x250")]
		public UIToggleButton pveToggle;

		// Token: 0x0400EC55 RID: 60501
		[Token(Token = "0x400EC55")]
		[FieldOffset(Offset = "0x258")]
		public GameObject HairStyleLevel;

		// Token: 0x0400EC56 RID: 60502
		[Token(Token = "0x400EC56")]
		[FieldOffset(Offset = "0x260")]
		public UIButton HairStylecontrlbtn;

		// Token: 0x0400EC57 RID: 60503
		[Token(Token = "0x400EC57")]
		[FieldOffset(Offset = "0x268")]
		public GameObject HairStylecontrlleft;

		// Token: 0x0400EC58 RID: 60504
		[Token(Token = "0x400EC58")]
		[FieldOffset(Offset = "0x270")]
		public GameObject HairStylecontrlright;

		// Token: 0x0400EC59 RID: 60505
		[Token(Token = "0x400EC59")]
		[FieldOffset(Offset = "0x278")]
		public GameObject HairStyleSpread;

		// Token: 0x0400EC5A RID: 60506
		[Token(Token = "0x400EC5A")]
		[FieldOffset(Offset = "0x280")]
		public UIToggleButton HairBtnLv0;

		// Token: 0x0400EC5B RID: 60507
		[Token(Token = "0x400EC5B")]
		[FieldOffset(Offset = "0x288")]
		public UIToggleButton HairBtnLv1;

		// Token: 0x0400EC5C RID: 60508
		[Token(Token = "0x400EC5C")]
		[FieldOffset(Offset = "0x290")]
		public UIToggleButton HairBtnLv2;

		// Token: 0x0400EC5D RID: 60509
		[Token(Token = "0x400EC5D")]
		[FieldOffset(Offset = "0x298")]
		public UIToggleButton HairBtnLv3;

		// Token: 0x0400EC5E RID: 60510
		[Token(Token = "0x400EC5E")]
		[FieldOffset(Offset = "0x2A0")]
		public GameObject HairStylePinch;

		// Token: 0x0400EC5F RID: 60511
		[Token(Token = "0x400EC5F")]
		[FieldOffset(Offset = "0x2A8")]
		public UIButton HairSpreadhlBtn;

		// Token: 0x0400EC60 RID: 60512
		[Token(Token = "0x400EC60")]
		[FieldOffset(Offset = "0x2B0")]
		public UILabel HairShowLabel;

		// Token: 0x0400EC61 RID: 60513
		[Token(Token = "0x400EC61")]
		[FieldOffset(Offset = "0x2B8")]
		public GameObject HairStyleLevelright;

		// Token: 0x0400EC62 RID: 60514
		[Token(Token = "0x400EC62")]
		[FieldOffset(Offset = "0x2C0")]
		public UIButton HairStylecontrlRbtn;

		// Token: 0x0400EC63 RID: 60515
		[Token(Token = "0x400EC63")]
		[FieldOffset(Offset = "0x2C8")]
		public GameObject HairStylecontrlrleft;

		// Token: 0x0400EC64 RID: 60516
		[Token(Token = "0x400EC64")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject HairStylecontrlrright;

		// Token: 0x0400EC65 RID: 60517
		[Token(Token = "0x400EC65")]
		[FieldOffset(Offset = "0x2D8")]
		public GameObject HairStyleRSpread;

		// Token: 0x0400EC66 RID: 60518
		[Token(Token = "0x400EC66")]
		[FieldOffset(Offset = "0x2E0")]
		public UIToggleButton HairBtnLv0right;

		// Token: 0x0400EC67 RID: 60519
		[Token(Token = "0x400EC67")]
		[FieldOffset(Offset = "0x2E8")]
		public UIToggleButton HairBtnLv1right;

		// Token: 0x0400EC68 RID: 60520
		[Token(Token = "0x400EC68")]
		[FieldOffset(Offset = "0x2F0")]
		public UIToggleButton HairBtnLv2right;

		// Token: 0x0400EC69 RID: 60521
		[Token(Token = "0x400EC69")]
		[FieldOffset(Offset = "0x2F8")]
		public UIToggleButton HairBtnLv3right;

		// Token: 0x0400EC6A RID: 60522
		[Token(Token = "0x400EC6A")]
		[FieldOffset(Offset = "0x300")]
		public GameObject HairStyleRPinch;

		// Token: 0x0400EC6B RID: 60523
		[Token(Token = "0x400EC6B")]
		[FieldOffset(Offset = "0x308")]
		public UIButton HairSpreadhlRBtn;

		// Token: 0x0400EC6C RID: 60524
		[Token(Token = "0x400EC6C")]
		[FieldOffset(Offset = "0x310")]
		public UILabel HairShowRLabel;

		// Token: 0x0400EC6D RID: 60525
		[Token(Token = "0x400EC6D")]
		[FieldOffset(Offset = "0x318")]
		public UIButton notificationBtn;

		// Token: 0x0400EC6E RID: 60526
		[Token(Token = "0x400EC6E")]
		[FieldOffset(Offset = "0x320")]
		public Transform notificationContainer;

		// Token: 0x0400EC6F RID: 60527
		[Token(Token = "0x400EC6F")]
		[FieldOffset(Offset = "0x328")]
		public UIButton WeaponSkinBtn;

		// Token: 0x0400EC70 RID: 60528
		[Token(Token = "0x400EC70")]
		[FieldOffset(Offset = "0x330")]
		public UIButton WeaponSkinTips;

		// Token: 0x0400EC71 RID: 60529
		[Token(Token = "0x400EC71")]
		[FieldOffset(Offset = "0x338")]
		public UILabel WeaponSkinTipsLabel;

		// Token: 0x0400EC72 RID: 60530
		[Token(Token = "0x400EC72")]
		[FieldOffset(Offset = "0x340")]
		public UISprite WeaponSkinIcon;

		// Token: 0x0400EC73 RID: 60531
		[Token(Token = "0x400EC73")]
		[FieldOffset(Offset = "0x348")]
		public UISprite WeaponSkinIcon_shadow;

		// Token: 0x0400EC74 RID: 60532
		[Token(Token = "0x400EC74")]
		[FieldOffset(Offset = "0x350")]
		public UIButton HotFixDownloadBtn;

		// Token: 0x0400EC75 RID: 60533
		[Token(Token = "0x400EC75")]
		[FieldOffset(Offset = "0x358")]
		public UILabel HotFixDownloadTxt;

		// Token: 0x0400EC76 RID: 60534
		[Token(Token = "0x400EC76")]
		[FieldOffset(Offset = "0x360")]
		public Transform DownloadIcon;

		// Token: 0x0400EC77 RID: 60535
		[Token(Token = "0x400EC77")]
		[FieldOffset(Offset = "0x368")]
		public BaseItemView HotFixBaseItemInfo;

		// Token: 0x0400EC78 RID: 60536
		[Token(Token = "0x400EC78")]
		[FieldOffset(Offset = "0x370")]
		public UIButton TreasureBoxProbability;

		// Token: 0x0400EC79 RID: 60537
		[Token(Token = "0x400EC79")]
		[FieldOffset(Offset = "0x378")]
		public Transform TreasureBoxTr;

		// Token: 0x0400EC7A RID: 60538
		[Token(Token = "0x400EC7A")]
		[FieldOffset(Offset = "0x380")]
		public UIWidget InstallmentInfo;

		// Token: 0x0400EC7B RID: 60539
		[Token(Token = "0x400EC7B")]
		[FieldOffset(Offset = "0x388")]
		public UILabel RemainTerm;

		// Token: 0x0400EC7C RID: 60540
		[Token(Token = "0x400EC7C")]
		[FieldOffset(Offset = "0x390")]
		public UICountDownLabel RemainTime;

		// Token: 0x0400EC7D RID: 60541
		[Token(Token = "0x400EC7D")]
		[FieldOffset(Offset = "0x398")]
		public UIGrid IconGrid;

		// Token: 0x0400EC7E RID: 60542
		[Token(Token = "0x400EC7E")]
		[FieldOffset(Offset = "0x3A0")]
		public UIButton InstallmentInfoBtn;

		// Token: 0x0400EC7F RID: 60543
		[Token(Token = "0x400EC7F")]
		[FieldOffset(Offset = "0x3A8")]
		public UISprite InstallmentInfoWidget;

		// Token: 0x0400EC80 RID: 60544
		[Token(Token = "0x400EC80")]
		[FieldOffset(Offset = "0x3B0")]
		public GameObject InstallmentEffect;

		// Token: 0x0400EC81 RID: 60545
		[Token(Token = "0x400EC81")]
		[FieldOffset(Offset = "0x3B8")]
		public UIButton MagnifierBtn;

		// Token: 0x0400EC82 RID: 60546
		[Token(Token = "0x400EC82")]
		[FieldOffset(Offset = "0x3C0")]
		public GameObject enlargeSprite;

		// Token: 0x0400EC83 RID: 60547
		[Token(Token = "0x400EC83")]
		[FieldOffset(Offset = "0x3C8")]
		public GameObject deflateSprite;

		// Token: 0x0400EC84 RID: 60548
		[Token(Token = "0x400EC84")]
		[FieldOffset(Offset = "0x3D0")]
		public UIButton zoomBtn;

		// Token: 0x0400EC85 RID: 60549
		[Token(Token = "0x400EC85")]
		[FieldOffset(Offset = "0x3D8")]
		public GameObject zoomSprite;

		// Token: 0x0400EC86 RID: 60550
		[Token(Token = "0x400EC86")]
		[FieldOffset(Offset = "0x3E0")]
		public GameObject PlaySprite;

		// Token: 0x0400EC87 RID: 60551
		[Token(Token = "0x400EC87")]
		[FieldOffset(Offset = "0x3E8")]
		public UIButton switchbtn;

		// Token: 0x0400EC88 RID: 60552
		[Token(Token = "0x400EC88")]
		[FieldOffset(Offset = "0x3F0")]
		public GameObject SwitchToGunSpr;

		// Token: 0x0400EC89 RID: 60553
		[Token(Token = "0x400EC89")]
		[FieldOffset(Offset = "0x3F8")]
		public GameObject SwitchToPersonSpr;

		// Token: 0x0400EC8A RID: 60554
		[Token(Token = "0x400EC8A")]
		[FieldOffset(Offset = "0x400")]
		public UIButton gachaswitchbtn;

		// Token: 0x0400EC8B RID: 60555
		[Token(Token = "0x400EC8B")]
		[FieldOffset(Offset = "0x408")]
		public GameObject gachaSwitchToGunSpr;

		// Token: 0x0400EC8C RID: 60556
		[Token(Token = "0x400EC8C")]
		[FieldOffset(Offset = "0x410")]
		public GameObject gachaSwitchToPersonSpr;

		// Token: 0x0400EC8D RID: 60557
		[Token(Token = "0x400EC8D")]
		[FieldOffset(Offset = "0x418")]
		public UIButton backpckSwitch;

		// Token: 0x0400EC8E RID: 60558
		[Token(Token = "0x400EC8E")]
		[FieldOffset(Offset = "0x420")]
		public GameObject SwitchTobackpackSpr;

		// Token: 0x0400EC8F RID: 60559
		[Token(Token = "0x400EC8F")]
		[FieldOffset(Offset = "0x428")]
		public GameObject SwitchTobackpackPersonSpr;

		// Token: 0x0400EC90 RID: 60560
		[Token(Token = "0x400EC90")]
		[FieldOffset(Offset = "0x430")]
		public GameObject WeaponSkinUpgradeLevel;

		// Token: 0x0400EC91 RID: 60561
		[Token(Token = "0x400EC91")]
		[FieldOffset(Offset = "0x438")]
		public UIToggleButton BtnWeaponSkinUpgradeLv1;

		// Token: 0x0400EC92 RID: 60562
		[Token(Token = "0x400EC92")]
		[FieldOffset(Offset = "0x440")]
		public UIToggleButton BtnWeaponSkinUpgradeLvMax;

		// Token: 0x0400EC93 RID: 60563
		[Token(Token = "0x400EC93")]
		[FieldOffset(Offset = "0x448")]
		public UILabel LabelWeaponSkinUpgradeLvMaxChosen;

		// Token: 0x0400EC94 RID: 60564
		[Token(Token = "0x400EC94")]
		[FieldOffset(Offset = "0x450")]
		public UILabel LabelWeaponSkinUpgradeLvMaxUnChosen;

		// Token: 0x0400EC95 RID: 60565
		[Token(Token = "0x400EC95")]
		[FieldOffset(Offset = "0x458")]
		public UIButton LevelUpBtn;

		// Token: 0x0400EC96 RID: 60566
		[Token(Token = "0x400EC96")]
		[FieldOffset(Offset = "0x460")]
		public GameObject WeaponSkinUpgradeLevelRight;

		// Token: 0x0400EC97 RID: 60567
		[Token(Token = "0x400EC97")]
		[FieldOffset(Offset = "0x468")]
		public UIToggleButton BtnWeaponSkinUpgradeLevelRightLv1;

		// Token: 0x0400EC98 RID: 60568
		[Token(Token = "0x400EC98")]
		[FieldOffset(Offset = "0x470")]
		public UIToggleButton BtnWeaponSkinUpgradeLevelRightLvMax;

		// Token: 0x0400EC99 RID: 60569
		[Token(Token = "0x400EC99")]
		[FieldOffset(Offset = "0x478")]
		public UILabel LabelWeaponSkinUpgradeLvMaxChosenRight;

		// Token: 0x0400EC9A RID: 60570
		[Token(Token = "0x400EC9A")]
		[FieldOffset(Offset = "0x480")]
		public UILabel LabelWeaponSkinUpgradeLvMaxUnChosenRight;
	}
}
