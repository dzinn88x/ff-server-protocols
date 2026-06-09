using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002593 RID: 9619
	[Token(Token = "0x2002593")]
	public class UIWeaponSkinLobbyMainView : UIBaseView
	{
		// Token: 0x0600C636 RID: 50742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C636")]
		[Address(RVA = "0x221702C", Offset = "0x221702C", VA = "0x7BBCA1702C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C637 RID: 50743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C637")]
		[Address(RVA = "0x22184D4", Offset = "0x22184D4", VA = "0x7BBCA184D4")]
		public UIWeaponSkinLobbyMainView()
		{
		}

		// Token: 0x0400F770 RID: 63344
		[Token(Token = "0x400F770")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget LeftUI;

		// Token: 0x0400F771 RID: 63345
		[Token(Token = "0x400F771")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ThirdPanel;

		// Token: 0x0400F772 RID: 63346
		[Token(Token = "0x400F772")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ThirdScrollView;

		// Token: 0x0400F773 RID: 63347
		[Token(Token = "0x400F773")]
		[FieldOffset(Offset = "0x38")]
		public UIEasyList ThirdGrid;

		// Token: 0x0400F774 RID: 63348
		[Token(Token = "0x400F774")]
		[FieldOffset(Offset = "0x40")]
		public GameObject weaponMenuContainer;

		// Token: 0x0400F775 RID: 63349
		[Token(Token = "0x400F775")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FirstPanel;

		// Token: 0x0400F776 RID: 63350
		[Token(Token = "0x400F776")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget LeftBG;

		// Token: 0x0400F777 RID: 63351
		[Token(Token = "0x400F777")]
		[FieldOffset(Offset = "0x58")]
		public UIScrollView FirstScrollView;

		// Token: 0x0400F778 RID: 63352
		[Token(Token = "0x400F778")]
		[FieldOffset(Offset = "0x60")]
		public UIEasyList FirstGrid;

		// Token: 0x0400F779 RID: 63353
		[Token(Token = "0x400F779")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SceondPanel;

		// Token: 0x0400F77A RID: 63354
		[Token(Token = "0x400F77A")]
		[FieldOffset(Offset = "0x70")]
		public UIScrollView SecondScrollView;

		// Token: 0x0400F77B RID: 63355
		[Token(Token = "0x400F77B")]
		[FieldOffset(Offset = "0x78")]
		public UIEasyList SecondGrid;

		// Token: 0x0400F77C RID: 63356
		[Token(Token = "0x400F77C")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget RightUI;

		// Token: 0x0400F77D RID: 63357
		[Token(Token = "0x400F77D")]
		[FieldOffset(Offset = "0x88")]
		public UIWidget PreviewUI;

		// Token: 0x0400F77E RID: 63358
		[Token(Token = "0x400F77E")]
		[FieldOffset(Offset = "0x90")]
		public UIButton switchbtn;

		// Token: 0x0400F77F RID: 63359
		[Token(Token = "0x400F77F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject SwitchToGunSpr;

		// Token: 0x0400F780 RID: 63360
		[Token(Token = "0x400F780")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject SwitchToPersonSpr;

		// Token: 0x0400F781 RID: 63361
		[Token(Token = "0x400F781")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton zoomBtn;

		// Token: 0x0400F782 RID: 63362
		[Token(Token = "0x400F782")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject propertyContainer;

		// Token: 0x0400F783 RID: 63363
		[Token(Token = "0x400F783")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject pvpPropertyContainer;

		// Token: 0x0400F784 RID: 63364
		[Token(Token = "0x400F784")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject propertyScore;

		// Token: 0x0400F785 RID: 63365
		[Token(Token = "0x400F785")]
		[FieldOffset(Offset = "0xC8")]
		public UITable propertyTable;

		// Token: 0x0400F786 RID: 63366
		[Token(Token = "0x400F786")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid scoreGrid;

		// Token: 0x0400F787 RID: 63367
		[Token(Token = "0x400F787")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject weaponSkill;

		// Token: 0x0400F788 RID: 63368
		[Token(Token = "0x400F788")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject pvePropertyContainer;

		// Token: 0x0400F789 RID: 63369
		[Token(Token = "0x400F789")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject pveweaponProperty;

		// Token: 0x0400F78A RID: 63370
		[Token(Token = "0x400F78A")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject skillicon;

		// Token: 0x0400F78B RID: 63371
		[Token(Token = "0x400F78B")]
		[FieldOffset(Offset = "0xF8")]
		public UIGrid toggleGrid;

		// Token: 0x0400F78C RID: 63372
		[Token(Token = "0x400F78C")]
		[FieldOffset(Offset = "0x100")]
		public UIToggleButton pvpToggle;

		// Token: 0x0400F78D RID: 63373
		[Token(Token = "0x400F78D")]
		[FieldOffset(Offset = "0x108")]
		public UIToggleButton pveToggle;

		// Token: 0x0400F78E RID: 63374
		[Token(Token = "0x400F78E")]
		[FieldOffset(Offset = "0x110")]
		public GameObject btnGroup;

		// Token: 0x0400F78F RID: 63375
		[Token(Token = "0x400F78F")]
		[FieldOffset(Offset = "0x118")]
		public UIButton equipBtn;

		// Token: 0x0400F790 RID: 63376
		[Token(Token = "0x400F790")]
		[FieldOffset(Offset = "0x120")]
		public UILabel btnName;

		// Token: 0x0400F791 RID: 63377
		[Token(Token = "0x400F791")]
		[FieldOffset(Offset = "0x128")]
		public UIButton showBtn;

		// Token: 0x0400F792 RID: 63378
		[Token(Token = "0x400F792")]
		[FieldOffset(Offset = "0x130")]
		public UISprite ShowBtnSprite;

		// Token: 0x0400F793 RID: 63379
		[Token(Token = "0x400F793")]
		[FieldOffset(Offset = "0x138")]
		public UILabel showBtnName;

		// Token: 0x0400F794 RID: 63380
		[Token(Token = "0x400F794")]
		[FieldOffset(Offset = "0x140")]
		public GameObject check;

		// Token: 0x0400F795 RID: 63381
		[Token(Token = "0x400F795")]
		[FieldOffset(Offset = "0x148")]
		public Transform notificationContainer;

		// Token: 0x0400F796 RID: 63382
		[Token(Token = "0x400F796")]
		[FieldOffset(Offset = "0x150")]
		public GameObject ItemDesc;

		// Token: 0x0400F797 RID: 63383
		[Token(Token = "0x400F797")]
		[FieldOffset(Offset = "0x158")]
		public GameObject DescLevelObj;

		// Token: 0x0400F798 RID: 63384
		[Token(Token = "0x400F798")]
		[FieldOffset(Offset = "0x160")]
		public UILabel DescLevelLabel;

		// Token: 0x0400F799 RID: 63385
		[Token(Token = "0x400F799")]
		[FieldOffset(Offset = "0x168")]
		public GameObject DescLevelLeftLabelTr;

		// Token: 0x0400F79A RID: 63386
		[Token(Token = "0x400F79A")]
		[FieldOffset(Offset = "0x170")]
		public UISprite DescLevelIcon;

		// Token: 0x0400F79B RID: 63387
		[Token(Token = "0x400F79B")]
		[FieldOffset(Offset = "0x178")]
		public GameObject DescLevelCommonLabelTr;

		// Token: 0x0400F79C RID: 63388
		[Token(Token = "0x400F79C")]
		[FieldOffset(Offset = "0x180")]
		public GameObject itemsdesc;

		// Token: 0x0400F79D RID: 63389
		[Token(Token = "0x400F79D")]
		[FieldOffset(Offset = "0x188")]
		public UILabel itemDescLabel;

		// Token: 0x0400F79E RID: 63390
		[Token(Token = "0x400F79E")]
		[FieldOffset(Offset = "0x190")]
		public GameObject itemsname;

		// Token: 0x0400F79F RID: 63391
		[Token(Token = "0x400F79F")]
		[FieldOffset(Offset = "0x198")]
		public UISprite NewQualityiconBgY;

		// Token: 0x0400F7A0 RID: 63392
		[Token(Token = "0x400F7A0")]
		[FieldOffset(Offset = "0x1A0")]
		public UILabel itemNameLabel;

		// Token: 0x0400F7A1 RID: 63393
		[Token(Token = "0x400F7A1")]
		[FieldOffset(Offset = "0x1A8")]
		public UISprite itemnamerightposspr;

		// Token: 0x0400F7A2 RID: 63394
		[Token(Token = "0x400F7A2")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite NewQualityicon;

		// Token: 0x0400F7A3 RID: 63395
		[Token(Token = "0x400F7A3")]
		[FieldOffset(Offset = "0x1B8")]
		public UIGrid IconTable;

		// Token: 0x0400F7A4 RID: 63396
		[Token(Token = "0x400F7A4")]
		[FieldOffset(Offset = "0x1C0")]
		public UIButton notificationIconBtn;

		// Token: 0x0400F7A5 RID: 63397
		[Token(Token = "0x400F7A5")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject notificationIcon;

		// Token: 0x0400F7A6 RID: 63398
		[Token(Token = "0x400F7A6")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject showIcon;

		// Token: 0x0400F7A7 RID: 63399
		[Token(Token = "0x400F7A7")]
		[FieldOffset(Offset = "0x1D8")]
		public UIButton showIconBtn;

		// Token: 0x0400F7A8 RID: 63400
		[Token(Token = "0x400F7A8")]
		[FieldOffset(Offset = "0x1E0")]
		public UIButton weaponskillbtn;

		// Token: 0x0400F7A9 RID: 63401
		[Token(Token = "0x400F7A9")]
		[FieldOffset(Offset = "0x1E8")]
		public UISprite SkillSpirte;

		// Token: 0x0400F7AA RID: 63402
		[Token(Token = "0x400F7AA")]
		[FieldOffset(Offset = "0x1F0")]
		public UIButton skillbtn;

		// Token: 0x0400F7AB RID: 63403
		[Token(Token = "0x400F7AB")]
		[FieldOffset(Offset = "0x1F8")]
		public UIButton tipsleft;

		// Token: 0x0400F7AC RID: 63404
		[Token(Token = "0x400F7AC")]
		[FieldOffset(Offset = "0x200")]
		public UILabel skilltiplabelleft;

		// Token: 0x0400F7AD RID: 63405
		[Token(Token = "0x400F7AD")]
		[FieldOffset(Offset = "0x208")]
		public UIButton tipsright;

		// Token: 0x0400F7AE RID: 63406
		[Token(Token = "0x400F7AE")]
		[FieldOffset(Offset = "0x210")]
		public UILabel skilltiplabelright;

		// Token: 0x0400F7AF RID: 63407
		[Token(Token = "0x400F7AF")]
		[FieldOffset(Offset = "0x218")]
		public UISprite SkillSprBg;

		// Token: 0x0400F7B0 RID: 63408
		[Token(Token = "0x400F7B0")]
		[FieldOffset(Offset = "0x220")]
		public UISprite sexicon;

		// Token: 0x0400F7B1 RID: 63409
		[Token(Token = "0x400F7B1")]
		[FieldOffset(Offset = "0x228")]
		public UISprite IPTag;

		// Token: 0x0400F7B2 RID: 63410
		[Token(Token = "0x400F7B2")]
		[FieldOffset(Offset = "0x230")]
		public GameObject weaponSkinUpgradeInfoIcon;

		// Token: 0x0400F7B3 RID: 63411
		[Token(Token = "0x400F7B3")]
		[FieldOffset(Offset = "0x238")]
		public UIButton BtnWeaponSkinUpgradeInfoIcon;

		// Token: 0x0400F7B4 RID: 63412
		[Token(Token = "0x400F7B4")]
		[FieldOffset(Offset = "0x240")]
		public Transform DescHighPos;

		// Token: 0x0400F7B5 RID: 63413
		[Token(Token = "0x400F7B5")]
		[FieldOffset(Offset = "0x248")]
		public Transform DeshLowPos;

		// Token: 0x0400F7B6 RID: 63414
		[Token(Token = "0x400F7B6")]
		[FieldOffset(Offset = "0x250")]
		public UIButton ShareBtn;

		// Token: 0x0400F7B7 RID: 63415
		[Token(Token = "0x400F7B7")]
		[FieldOffset(Offset = "0x258")]
		public UIButton LevelUpBtn;

		// Token: 0x0400F7B8 RID: 63416
		[Token(Token = "0x400F7B8")]
		[FieldOffset(Offset = "0x260")]
		public GameObject LevelUpVfx;

		// Token: 0x0400F7B9 RID: 63417
		[Token(Token = "0x400F7B9")]
		[FieldOffset(Offset = "0x268")]
		public UIButton HotFixDownloadBtn;

		// Token: 0x0400F7BA RID: 63418
		[Token(Token = "0x400F7BA")]
		[FieldOffset(Offset = "0x270")]
		public UILabel HotFixDownloadTxt;

		// Token: 0x0400F7BB RID: 63419
		[Token(Token = "0x400F7BB")]
		[FieldOffset(Offset = "0x278")]
		public Transform DownloadIcon;

		// Token: 0x0400F7BC RID: 63420
		[Token(Token = "0x400F7BC")]
		[FieldOffset(Offset = "0x280")]
		public BaseItemView HotFixBaseItemInfo;

		// Token: 0x0400F7BD RID: 63421
		[Token(Token = "0x400F7BD")]
		[FieldOffset(Offset = "0x288")]
		public GameObject EventTrigger;

		// Token: 0x0400F7BE RID: 63422
		[Token(Token = "0x400F7BE")]
		[FieldOffset(Offset = "0x290")]
		public GameObject ShareUI;

		// Token: 0x0400F7BF RID: 63423
		[Token(Token = "0x400F7BF")]
		[FieldOffset(Offset = "0x298")]
		public GameObject ShareItemDesc;

		// Token: 0x0400F7C0 RID: 63424
		[Token(Token = "0x400F7C0")]
		[FieldOffset(Offset = "0x2A0")]
		public UISprite ShareNameBg;

		// Token: 0x0400F7C1 RID: 63425
		[Token(Token = "0x400F7C1")]
		[FieldOffset(Offset = "0x2A8")]
		public UILabel SHareNameLabel;

		// Token: 0x0400F7C2 RID: 63426
		[Token(Token = "0x400F7C2")]
		[FieldOffset(Offset = "0x2B0")]
		public GameObject ShareLevelObj;

		// Token: 0x0400F7C3 RID: 63427
		[Token(Token = "0x400F7C3")]
		[FieldOffset(Offset = "0x2B8")]
		public UILabel ShareLevelLabel;

		// Token: 0x0400F7C4 RID: 63428
		[Token(Token = "0x400F7C4")]
		[FieldOffset(Offset = "0x2C0")]
		public UISprite ShareLevelIcon;

		// Token: 0x0400F7C5 RID: 63429
		[Token(Token = "0x400F7C5")]
		[FieldOffset(Offset = "0x2C8")]
		public GameObject ShareLevelLeftLabelTr;

		// Token: 0x0400F7C6 RID: 63430
		[Token(Token = "0x400F7C6")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject ShareLevelCommonLabelTr;

		// Token: 0x0400F7C7 RID: 63431
		[Token(Token = "0x400F7C7")]
		[FieldOffset(Offset = "0x2D8")]
		public UILabel ShareDesc;

		// Token: 0x0400F7C8 RID: 63432
		[Token(Token = "0x400F7C8")]
		[FieldOffset(Offset = "0x2E0")]
		public Transform ShareLowPoint;

		// Token: 0x0400F7C9 RID: 63433
		[Token(Token = "0x400F7C9")]
		[FieldOffset(Offset = "0x2E8")]
		public Transform ShareHighPoint;

		// Token: 0x0400F7CA RID: 63434
		[Token(Token = "0x400F7CA")]
		[FieldOffset(Offset = "0x2F0")]
		public UILabel OwnSkinLabel;
	}
}
