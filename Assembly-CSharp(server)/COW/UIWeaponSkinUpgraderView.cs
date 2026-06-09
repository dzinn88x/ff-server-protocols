using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200259D RID: 9629
	[Token(Token = "0x200259D")]
	public class UIWeaponSkinUpgraderView : UIBaseView
	{
		// Token: 0x0600C64A RID: 50762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64A")]
		[Address(RVA = "0x22337E4", Offset = "0x22337E4", VA = "0x7BBCA337E4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C64B RID: 50763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C64B")]
		[Address(RVA = "0x223474C", Offset = "0x223474C", VA = "0x7BBCA3474C")]
		public UIWeaponSkinUpgraderView()
		{
		}

		// Token: 0x0400F831 RID: 63537
		[Token(Token = "0x400F831")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GoRootNode;

		// Token: 0x0400F832 RID: 63538
		[Token(Token = "0x400F832")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400F833 RID: 63539
		[Token(Token = "0x400F833")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ObjAnnouncementArea;

		// Token: 0x0400F834 RID: 63540
		[Token(Token = "0x400F834")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget WidgetPreview;

		// Token: 0x0400F835 RID: 63541
		[Token(Token = "0x400F835")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelSkinName;

		// Token: 0x0400F836 RID: 63542
		[Token(Token = "0x400F836")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NewSkill;

		// Token: 0x0400F837 RID: 63543
		[Token(Token = "0x400F837")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NewSkillLock;

		// Token: 0x0400F838 RID: 63544
		[Token(Token = "0x400F838")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelLockTip;

		// Token: 0x0400F839 RID: 63545
		[Token(Token = "0x400F839")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelSkillDesc;

		// Token: 0x0400F83A RID: 63546
		[Token(Token = "0x400F83A")]
		[FieldOffset(Offset = "0x68")]
		public TweenAlpha AlphaSkillDesc;

		// Token: 0x0400F83B RID: 63547
		[Token(Token = "0x400F83B")]
		[FieldOffset(Offset = "0x70")]
		public UISprite SpriteSkillIcon;

		// Token: 0x0400F83C RID: 63548
		[Token(Token = "0x400F83C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LabelWeaponSkill;

		// Token: 0x0400F83D RID: 63549
		[Token(Token = "0x400F83D")]
		[FieldOffset(Offset = "0x80")]
		public ParticleSystem ParticalSkillLock;

		// Token: 0x0400F83E RID: 63550
		[Token(Token = "0x400F83E")]
		[FieldOffset(Offset = "0x88")]
		public ParticleSystem ParticalSkillGlow;

		// Token: 0x0400F83F RID: 63551
		[Token(Token = "0x400F83F")]
		[FieldOffset(Offset = "0x90")]
		public ParticleSystem ParticalSkillLizi;

		// Token: 0x0400F840 RID: 63552
		[Token(Token = "0x400F840")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem ParticalSkillFlash;

		// Token: 0x0400F841 RID: 63553
		[Token(Token = "0x400F841")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject propertyContainer;

		// Token: 0x0400F842 RID: 63554
		[Token(Token = "0x400F842")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject pvpPropertyContainer;

		// Token: 0x0400F843 RID: 63555
		[Token(Token = "0x400F843")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject propertyScore;

		// Token: 0x0400F844 RID: 63556
		[Token(Token = "0x400F844")]
		[FieldOffset(Offset = "0xB8")]
		public UITable propertyTable;

		// Token: 0x0400F845 RID: 63557
		[Token(Token = "0x400F845")]
		[FieldOffset(Offset = "0xC0")]
		public UIGrid scoreGrid;

		// Token: 0x0400F846 RID: 63558
		[Token(Token = "0x400F846")]
		[FieldOffset(Offset = "0xC8")]
		public ParticleSystem ParticalAttrGlow;

		// Token: 0x0400F847 RID: 63559
		[Token(Token = "0x400F847")]
		[FieldOffset(Offset = "0xD0")]
		public ParticleSystem ParticalAttrGlow2;

		// Token: 0x0400F848 RID: 63560
		[Token(Token = "0x400F848")]
		[FieldOffset(Offset = "0xD8")]
		public ParticleSystem ParticalAttrLizi;

		// Token: 0x0400F849 RID: 63561
		[Token(Token = "0x400F849")]
		[FieldOffset(Offset = "0xE0")]
		public ParticleSystem ParticalAttrCirculation;

		// Token: 0x0400F84A RID: 63562
		[Token(Token = "0x400F84A")]
		[FieldOffset(Offset = "0xE8")]
		public ParticleSystem ParticalAttrJiantou;

		// Token: 0x0400F84B RID: 63563
		[Token(Token = "0x400F84B")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject EventTrigger;

		// Token: 0x0400F84C RID: 63564
		[Token(Token = "0x400F84C")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject GoUIMask;

		// Token: 0x0400F84D RID: 63565
		[Token(Token = "0x400F84D")]
		[FieldOffset(Offset = "0x100")]
		public GameObject OverView;

		// Token: 0x0400F84E RID: 63566
		[Token(Token = "0x400F84E")]
		[FieldOffset(Offset = "0x108")]
		public UIScrollView PropertyPickScrollView;

		// Token: 0x0400F84F RID: 63567
		[Token(Token = "0x400F84F")]
		[FieldOffset(Offset = "0x110")]
		public UIGrid GridProperty;

		// Token: 0x0400F850 RID: 63568
		[Token(Token = "0x400F850")]
		[FieldOffset(Offset = "0x118")]
		public UIButton BtnSeeAnimAgain;

		// Token: 0x0400F851 RID: 63569
		[Token(Token = "0x400F851")]
		[FieldOffset(Offset = "0x120")]
		public UILabel LabelSeeAnimAgain;

		// Token: 0x0400F852 RID: 63570
		[Token(Token = "0x400F852")]
		[FieldOffset(Offset = "0x128")]
		public UILabel LabelFeatureText;

		// Token: 0x0400F853 RID: 63571
		[Token(Token = "0x400F853")]
		[FieldOffset(Offset = "0x130")]
		public UIGrid MainBtnGrid;

		// Token: 0x0400F854 RID: 63572
		[Token(Token = "0x400F854")]
		[FieldOffset(Offset = "0x138")]
		public UIButton BtnGoToDetail;

		// Token: 0x0400F855 RID: 63573
		[Token(Token = "0x400F855")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BtnGoToPurchase;

		// Token: 0x0400F856 RID: 63574
		[Token(Token = "0x400F856")]
		[FieldOffset(Offset = "0x148")]
		public UILabel LabelBtnGridGoposUnopen;

		// Token: 0x0400F857 RID: 63575
		[Token(Token = "0x400F857")]
		[FieldOffset(Offset = "0x150")]
		public GameObject UpgradeView;

		// Token: 0x0400F858 RID: 63576
		[Token(Token = "0x400F858")]
		[FieldOffset(Offset = "0x158")]
		public UIButton BtnSeeAnim;

		// Token: 0x0400F859 RID: 63577
		[Token(Token = "0x400F859")]
		[FieldOffset(Offset = "0x160")]
		public UILabel LabelSeeAnim;

		// Token: 0x0400F85A RID: 63578
		[Token(Token = "0x400F85A")]
		[FieldOffset(Offset = "0x168")]
		public UIButton BtnGoToDepot;

		// Token: 0x0400F85B RID: 63579
		[Token(Token = "0x400F85B")]
		[FieldOffset(Offset = "0x170")]
		public UILabel LabelObtainedFeature;

		// Token: 0x0400F85C RID: 63580
		[Token(Token = "0x400F85C")]
		[FieldOffset(Offset = "0x178")]
		public UIGrid GridFeatureAdd;

		// Token: 0x0400F85D RID: 63581
		[Token(Token = "0x400F85D")]
		[FieldOffset(Offset = "0x180")]
		public GameObject ObjHaveHad;

		// Token: 0x0400F85E RID: 63582
		[Token(Token = "0x400F85E")]
		[FieldOffset(Offset = "0x188")]
		public UILabel LabelObtainStyle;

		// Token: 0x0400F85F RID: 63583
		[Token(Token = "0x400F85F")]
		[FieldOffset(Offset = "0x190")]
		public GameObject ObjHaventHave;

		// Token: 0x0400F860 RID: 63584
		[Token(Token = "0x400F860")]
		[FieldOffset(Offset = "0x198")]
		public UILabel LabelFeatureViewGoposUnopen;

		// Token: 0x0400F861 RID: 63585
		[Token(Token = "0x400F861")]
		[FieldOffset(Offset = "0x1A0")]
		public UIGrid FragmentProgressGrid;

		// Token: 0x0400F862 RID: 63586
		[Token(Token = "0x400F862")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject FragmentProgressItem0;

		// Token: 0x0400F863 RID: 63587
		[Token(Token = "0x400F863")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite SpriteFragmentProgressItem0;

		// Token: 0x0400F864 RID: 63588
		[Token(Token = "0x400F864")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel LabelFragmentProgressItem0;

		// Token: 0x0400F865 RID: 63589
		[Token(Token = "0x400F865")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject FragmentProgressItem2;

		// Token: 0x0400F866 RID: 63590
		[Token(Token = "0x400F866")]
		[FieldOffset(Offset = "0x1C8")]
		public UISprite SpriteFragmentProgressItem2;

		// Token: 0x0400F867 RID: 63591
		[Token(Token = "0x400F867")]
		[FieldOffset(Offset = "0x1D0")]
		public UILabel LabelFragmentProgressItem2;

		// Token: 0x0400F868 RID: 63592
		[Token(Token = "0x400F868")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject FragmentProgressItem1;

		// Token: 0x0400F869 RID: 63593
		[Token(Token = "0x400F869")]
		[FieldOffset(Offset = "0x1E0")]
		public UISprite SpriteFragmentProgressItem1;

		// Token: 0x0400F86A RID: 63594
		[Token(Token = "0x400F86A")]
		[FieldOffset(Offset = "0x1E8")]
		public UILabel LabelFragmentProgressItem1;

		// Token: 0x0400F86B RID: 63595
		[Token(Token = "0x400F86B")]
		[FieldOffset(Offset = "0x1F0")]
		public UIButton BtnGetFragment;

		// Token: 0x0400F86C RID: 63596
		[Token(Token = "0x400F86C")]
		[FieldOffset(Offset = "0x1F8")]
		public UILabel LabelGetFragment;

		// Token: 0x0400F86D RID: 63597
		[Token(Token = "0x400F86D")]
		[FieldOffset(Offset = "0x200")]
		public UIButton BtnUpgrade;

		// Token: 0x0400F86E RID: 63598
		[Token(Token = "0x400F86E")]
		[FieldOffset(Offset = "0x208")]
		public UIButton BtnUpgradeViewPurchase;

		// Token: 0x0400F86F RID: 63599
		[Token(Token = "0x400F86F")]
		[FieldOffset(Offset = "0x210")]
		public UILabel LabelUpgradeFirst;

		// Token: 0x0400F870 RID: 63600
		[Token(Token = "0x400F870")]
		[FieldOffset(Offset = "0x218")]
		public GameObject LevelPickContainer;

		// Token: 0x0400F871 RID: 63601
		[Token(Token = "0x400F871")]
		[FieldOffset(Offset = "0x220")]
		public UIScrollView LevelPickScrollView;

		// Token: 0x0400F872 RID: 63602
		[Token(Token = "0x400F872")]
		[FieldOffset(Offset = "0x228")]
		public UIPanel PanelLevelPick;

		// Token: 0x0400F873 RID: 63603
		[Token(Token = "0x400F873")]
		[FieldOffset(Offset = "0x230")]
		public UIGrid LevelGrid;
	}
}
