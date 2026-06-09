using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024A8 RID: 9384
	[Token(Token = "0x20024A8")]
	public class UIProfileFightDataItemView : UIBaseView
	{
		// Token: 0x0600C460 RID: 50272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C460")]
		[Address(RVA = "0x1FE11F8", Offset = "0x1FE11F8", VA = "0x7BBC7E11F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C461 RID: 50273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C461")]
		[Address(RVA = "0x1FE27C8", Offset = "0x1FE27C8", VA = "0x7BBC7E27C8")]
		public UIProfileFightDataItemView()
		{
		}

		// Token: 0x0400ECF7 RID: 60663
		[Token(Token = "0x400ECF7")]
		[FieldOffset(Offset = "0x20")]
		public Animation Animation;

		// Token: 0x0400ECF8 RID: 60664
		[Token(Token = "0x400ECF8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ProfileNode;

		// Token: 0x0400ECF9 RID: 60665
		[Token(Token = "0x400ECF9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FiveDMap;

		// Token: 0x0400ECFA RID: 60666
		[Token(Token = "0x400ECFA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject WinrateVFX;

		// Token: 0x0400ECFB RID: 60667
		[Token(Token = "0x400ECFB")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SurvivalVFX;

		// Token: 0x0400ECFC RID: 60668
		[Token(Token = "0x400ECFC")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ExploreVFX;

		// Token: 0x0400ECFD RID: 60669
		[Token(Token = "0x400ECFD")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SkillVFX;

		// Token: 0x0400ECFE RID: 60670
		[Token(Token = "0x400ECFE")]
		[FieldOffset(Offset = "0x58")]
		public GameObject KillVFX;

		// Token: 0x0400ECFF RID: 60671
		[Token(Token = "0x400ECFF")]
		[FieldOffset(Offset = "0x60")]
		public MeshRenderer MapRenderer;

		// Token: 0x0400ED00 RID: 60672
		[Token(Token = "0x400ED00")]
		[FieldOffset(Offset = "0x68")]
		public MeshFilter MapMeshFilter;

		// Token: 0x0400ED01 RID: 60673
		[Token(Token = "0x400ED01")]
		[FieldOffset(Offset = "0x70")]
		public Transform PointWinRate;

		// Token: 0x0400ED02 RID: 60674
		[Token(Token = "0x400ED02")]
		[FieldOffset(Offset = "0x78")]
		public Transform PointSurvival;

		// Token: 0x0400ED03 RID: 60675
		[Token(Token = "0x400ED03")]
		[FieldOffset(Offset = "0x80")]
		public Transform PointExplore;

		// Token: 0x0400ED04 RID: 60676
		[Token(Token = "0x400ED04")]
		[FieldOffset(Offset = "0x88")]
		public Transform PointSkill;

		// Token: 0x0400ED05 RID: 60677
		[Token(Token = "0x400ED05")]
		[FieldOffset(Offset = "0x90")]
		public Transform PointKill;

		// Token: 0x0400ED06 RID: 60678
		[Token(Token = "0x400ED06")]
		[FieldOffset(Offset = "0x98")]
		public UIStarSprite mapRender;

		// Token: 0x0400ED07 RID: 60679
		[Token(Token = "0x400ED07")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite LineWinRate;

		// Token: 0x0400ED08 RID: 60680
		[Token(Token = "0x400ED08")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite LineKill;

		// Token: 0x0400ED09 RID: 60681
		[Token(Token = "0x400ED09")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite LineSkill;

		// Token: 0x0400ED0A RID: 60682
		[Token(Token = "0x400ED0A")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite LineExplore;

		// Token: 0x0400ED0B RID: 60683
		[Token(Token = "0x400ED0B")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite LineSurvival;

		// Token: 0x0400ED0C RID: 60684
		[Token(Token = "0x400ED0C")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject BasicDataPanel;

		// Token: 0x0400ED0D RID: 60685
		[Token(Token = "0x400ED0D")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel PlayTimes;

		// Token: 0x0400ED0E RID: 60686
		[Token(Token = "0x400ED0E")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel WinTimes;

		// Token: 0x0400ED0F RID: 60687
		[Token(Token = "0x400ED0F")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel KillTimes;

		// Token: 0x0400ED10 RID: 60688
		[Token(Token = "0x400ED10")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite nameicon;

		// Token: 0x0400ED11 RID: 60689
		[Token(Token = "0x400ED11")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel namelabel;

		// Token: 0x0400ED12 RID: 60690
		[Token(Token = "0x400ED12")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject detailpanel;

		// Token: 0x0400ED13 RID: 60691
		[Token(Token = "0x400ED13")]
		[FieldOffset(Offset = "0x100")]
		public UIButton detailbtn;

		// Token: 0x0400ED14 RID: 60692
		[Token(Token = "0x400ED14")]
		[FieldOffset(Offset = "0x108")]
		public UISprite arrow;

		// Token: 0x0400ED15 RID: 60693
		[Token(Token = "0x400ED15")]
		[FieldOffset(Offset = "0x110")]
		public UILabel detaillabel;

		// Token: 0x0400ED16 RID: 60694
		[Token(Token = "0x400ED16")]
		[FieldOffset(Offset = "0x118")]
		public GameObject detailselect;

		// Token: 0x0400ED17 RID: 60695
		[Token(Token = "0x400ED17")]
		[FieldOffset(Offset = "0x120")]
		public UISprite bg;

		// Token: 0x0400ED18 RID: 60696
		[Token(Token = "0x400ED18")]
		[FieldOffset(Offset = "0x128")]
		public GameObject ThreeDMap;

		// Token: 0x0400ED19 RID: 60697
		[Token(Token = "0x400ED19")]
		[FieldOffset(Offset = "0x130")]
		public GameObject CSWinrateVFX;

		// Token: 0x0400ED1A RID: 60698
		[Token(Token = "0x400ED1A")]
		[FieldOffset(Offset = "0x138")]
		public GameObject CSSurvivalVFX;

		// Token: 0x0400ED1B RID: 60699
		[Token(Token = "0x400ED1B")]
		[FieldOffset(Offset = "0x140")]
		public GameObject CSExploreVFX;

		// Token: 0x0400ED1C RID: 60700
		[Token(Token = "0x400ED1C")]
		[FieldOffset(Offset = "0x148")]
		public GameObject CSSkillVFX;

		// Token: 0x0400ED1D RID: 60701
		[Token(Token = "0x400ED1D")]
		[FieldOffset(Offset = "0x150")]
		public GameObject CSKillVFX;

		// Token: 0x0400ED1E RID: 60702
		[Token(Token = "0x400ED1E")]
		[FieldOffset(Offset = "0x158")]
		public MeshRenderer ThreedMapRenderer;

		// Token: 0x0400ED1F RID: 60703
		[Token(Token = "0x400ED1F")]
		[FieldOffset(Offset = "0x160")]
		public MeshFilter ThreedMapMeshFilter;

		// Token: 0x0400ED20 RID: 60704
		[Token(Token = "0x400ED20")]
		[FieldOffset(Offset = "0x168")]
		public Transform PointCsLeader;

		// Token: 0x0400ED21 RID: 60705
		[Token(Token = "0x400ED21")]
		[FieldOffset(Offset = "0x170")]
		public Transform PointCsSupport;

		// Token: 0x0400ED22 RID: 60706
		[Token(Token = "0x400ED22")]
		[FieldOffset(Offset = "0x178")]
		public Transform PointCskill;

		// Token: 0x0400ED23 RID: 60707
		[Token(Token = "0x400ED23")]
		[FieldOffset(Offset = "0x180")]
		public Transform PointCsDamage;

		// Token: 0x0400ED24 RID: 60708
		[Token(Token = "0x400ED24")]
		[FieldOffset(Offset = "0x188")]
		public Transform PointCsParticipation;

		// Token: 0x0400ED25 RID: 60709
		[Token(Token = "0x400ED25")]
		[FieldOffset(Offset = "0x190")]
		public UIStarSprite ThreedmapRender;

		// Token: 0x0400ED26 RID: 60710
		[Token(Token = "0x400ED26")]
		[FieldOffset(Offset = "0x198")]
		public UISprite LineCsLeader;

		// Token: 0x0400ED27 RID: 60711
		[Token(Token = "0x400ED27")]
		[FieldOffset(Offset = "0x1A0")]
		public UISprite LineCsSupport;

		// Token: 0x0400ED28 RID: 60712
		[Token(Token = "0x400ED28")]
		[FieldOffset(Offset = "0x1A8")]
		public UISprite LineCskill;

		// Token: 0x0400ED29 RID: 60713
		[Token(Token = "0x400ED29")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite LineCsDamage;

		// Token: 0x0400ED2A RID: 60714
		[Token(Token = "0x400ED2A")]
		[FieldOffset(Offset = "0x1B8")]
		public UISprite LineCsParticipation;

		// Token: 0x0400ED2B RID: 60715
		[Token(Token = "0x400ED2B")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject CSModeBasicDataPanel;

		// Token: 0x0400ED2C RID: 60716
		[Token(Token = "0x400ED2C")]
		[FieldOffset(Offset = "0x1C8")]
		public UILabel CSPlayTimes;

		// Token: 0x0400ED2D RID: 60717
		[Token(Token = "0x400ED2D")]
		[FieldOffset(Offset = "0x1D0")]
		public UILabel CSWinTimes;

		// Token: 0x0400ED2E RID: 60718
		[Token(Token = "0x400ED2E")]
		[FieldOffset(Offset = "0x1D8")]
		public UILabel CSKillTimes;

		// Token: 0x0400ED2F RID: 60719
		[Token(Token = "0x400ED2F")]
		[FieldOffset(Offset = "0x1E0")]
		public UILabel KDATimes;

		// Token: 0x0400ED30 RID: 60720
		[Token(Token = "0x400ED30")]
		[FieldOffset(Offset = "0x1E8")]
		public Transform ScrollView;

		// Token: 0x0400ED31 RID: 60721
		[Token(Token = "0x400ED31")]
		[FieldOffset(Offset = "0x1F0")]
		public Transform RightPanel;

		// Token: 0x0400ED32 RID: 60722
		[Token(Token = "0x400ED32")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject DetailDataPanel;

		// Token: 0x0400ED33 RID: 60723
		[Token(Token = "0x400ED33")]
		[FieldOffset(Offset = "0x200")]
		public UIGrid DetailGrid;

		// Token: 0x0400ED34 RID: 60724
		[Token(Token = "0x400ED34")]
		[FieldOffset(Offset = "0x208")]
		public GameObject DetailBG;

		// Token: 0x0400ED35 RID: 60725
		[Token(Token = "0x400ED35")]
		[FieldOffset(Offset = "0x210")]
		public UILabel TopNsLabel;

		// Token: 0x0400ED36 RID: 60726
		[Token(Token = "0x400ED36")]
		[FieldOffset(Offset = "0x218")]
		public UILabel Top10s;

		// Token: 0x0400ED37 RID: 60727
		[Token(Token = "0x400ED37")]
		[FieldOffset(Offset = "0x220")]
		public UILabel TopNRateLabel;

		// Token: 0x0400ED38 RID: 60728
		[Token(Token = "0x400ED38")]
		[FieldOffset(Offset = "0x228")]
		public UILabel Top10Rate;

		// Token: 0x0400ED39 RID: 60729
		[Token(Token = "0x400ED39")]
		[FieldOffset(Offset = "0x230")]
		public GameObject KDRatioLabel;

		// Token: 0x0400ED3A RID: 60730
		[Token(Token = "0x400ED3A")]
		[FieldOffset(Offset = "0x238")]
		public UILabel KDRatio;

		// Token: 0x0400ED3B RID: 60731
		[Token(Token = "0x400ED3B")]
		[FieldOffset(Offset = "0x240")]
		public GameObject AVGDisTravLabel;

		// Token: 0x0400ED3C RID: 60732
		[Token(Token = "0x400ED3C")]
		[FieldOffset(Offset = "0x248")]
		public UILabel AVGDisTrav;

		// Token: 0x0400ED3D RID: 60733
		[Token(Token = "0x400ED3D")]
		[FieldOffset(Offset = "0x250")]
		public GameObject AVGSurvivalTimeLabel;

		// Token: 0x0400ED3E RID: 60734
		[Token(Token = "0x400ED3E")]
		[FieldOffset(Offset = "0x258")]
		public UILabel AVGSurvivalTime;

		// Token: 0x0400ED3F RID: 60735
		[Token(Token = "0x400ED3F")]
		[FieldOffset(Offset = "0x260")]
		public GameObject RevivesLabel;

		// Token: 0x0400ED40 RID: 60736
		[Token(Token = "0x400ED40")]
		[FieldOffset(Offset = "0x268")]
		public UILabel Revives;

		// Token: 0x0400ED41 RID: 60737
		[Token(Token = "0x400ED41")]
		[FieldOffset(Offset = "0x270")]
		public GameObject MostKillLabel;

		// Token: 0x0400ED42 RID: 60738
		[Token(Token = "0x400ED42")]
		[FieldOffset(Offset = "0x278")]
		public UILabel MostKill;

		// Token: 0x0400ED43 RID: 60739
		[Token(Token = "0x400ED43")]
		[FieldOffset(Offset = "0x280")]
		public GameObject AVGDamageLabel;

		// Token: 0x0400ED44 RID: 60740
		[Token(Token = "0x400ED44")]
		[FieldOffset(Offset = "0x288")]
		public UILabel AVGDamage;

		// Token: 0x0400ED45 RID: 60741
		[Token(Token = "0x400ED45")]
		[FieldOffset(Offset = "0x290")]
		public GameObject RoadKillLabel;

		// Token: 0x0400ED46 RID: 60742
		[Token(Token = "0x400ED46")]
		[FieldOffset(Offset = "0x298")]
		public UILabel RoadKill;

		// Token: 0x0400ED47 RID: 60743
		[Token(Token = "0x400ED47")]
		[FieldOffset(Offset = "0x2A0")]
		public GameObject HeadShotLabel;

		// Token: 0x0400ED48 RID: 60744
		[Token(Token = "0x400ED48")]
		[FieldOffset(Offset = "0x2A8")]
		public UILabel HeadShot;

		// Token: 0x0400ED49 RID: 60745
		[Token(Token = "0x400ED49")]
		[FieldOffset(Offset = "0x2B0")]
		public GameObject HeadShotRatioLabel;

		// Token: 0x0400ED4A RID: 60746
		[Token(Token = "0x400ED4A")]
		[FieldOffset(Offset = "0x2B8")]
		public UILabel HeadShotRatio;

		// Token: 0x0400ED4B RID: 60747
		[Token(Token = "0x400ED4B")]
		[FieldOffset(Offset = "0x2C0")]
		public GameObject KnockDownLabel;

		// Token: 0x0400ED4C RID: 60748
		[Token(Token = "0x400ED4C")]
		[FieldOffset(Offset = "0x2C8")]
		public UILabel KnockDown;

		// Token: 0x0400ED4D RID: 60749
		[Token(Token = "0x400ED4D")]
		[FieldOffset(Offset = "0x2D0")]
		public GameObject WinRateLabel;

		// Token: 0x0400ED4E RID: 60750
		[Token(Token = "0x400ED4E")]
		[FieldOffset(Offset = "0x2D8")]
		public UILabel CSWinRate;

		// Token: 0x0400ED4F RID: 60751
		[Token(Token = "0x400ED4F")]
		[FieldOffset(Offset = "0x2E0")]
		public GameObject MVPLabel;

		// Token: 0x0400ED50 RID: 60752
		[Token(Token = "0x400ED50")]
		[FieldOffset(Offset = "0x2E8")]
		public UILabel CSMvp;

		// Token: 0x0400ED51 RID: 60753
		[Token(Token = "0x400ED51")]
		[FieldOffset(Offset = "0x2F0")]
		public GameObject TotalKillLabel;

		// Token: 0x0400ED52 RID: 60754
		[Token(Token = "0x400ED52")]
		[FieldOffset(Offset = "0x2F8")]
		public UILabel CSTotalKill;

		// Token: 0x0400ED53 RID: 60755
		[Token(Token = "0x400ED53")]
		[FieldOffset(Offset = "0x300")]
		public GameObject DoubleKillLabel;

		// Token: 0x0400ED54 RID: 60756
		[Token(Token = "0x400ED54")]
		[FieldOffset(Offset = "0x308")]
		public UILabel CSDoubleKill;

		// Token: 0x0400ED55 RID: 60757
		[Token(Token = "0x400ED55")]
		[FieldOffset(Offset = "0x310")]
		public GameObject ThreekillLabel;

		// Token: 0x0400ED56 RID: 60758
		[Token(Token = "0x400ED56")]
		[FieldOffset(Offset = "0x318")]
		public UILabel CSThreeKill;

		// Token: 0x0400ED57 RID: 60759
		[Token(Token = "0x400ED57")]
		[FieldOffset(Offset = "0x320")]
		public GameObject FourKillLabel;

		// Token: 0x0400ED58 RID: 60760
		[Token(Token = "0x400ED58")]
		[FieldOffset(Offset = "0x328")]
		public UILabel CSFourKill;
	}
}
