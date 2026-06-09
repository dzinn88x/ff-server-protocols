using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024ED RID: 9453
	[Token(Token = "0x20024ED")]
	public class UISeasonStatsDetailView : UIBaseView
	{
		// Token: 0x0600C4EA RID: 50410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4EA")]
		[Address(RVA = "0x162D314", Offset = "0x162D314", VA = "0x7BBBE2D314", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4EB")]
		[Address(RVA = "0x162E38C", Offset = "0x162E38C", VA = "0x7BBBE2E38C")]
		public UISeasonStatsDetailView()
		{
		}

		// Token: 0x0400F07B RID: 61563
		[Token(Token = "0x400F07B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BRExtraBg;

		// Token: 0x0400F07C RID: 61564
		[Token(Token = "0x400F07C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BRRankGroup;

		// Token: 0x0400F07D RID: 61565
		[Token(Token = "0x400F07D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel mMatchCount;

		// Token: 0x0400F07E RID: 61566
		[Token(Token = "0x400F07E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel bKD;

		// Token: 0x0400F07F RID: 61567
		[Token(Token = "0x400F07F")]
		[FieldOffset(Offset = "0x40")]
		public UILabel mWins;

		// Token: 0x0400F080 RID: 61568
		[Token(Token = "0x400F080")]
		[FieldOffset(Offset = "0x48")]
		public UILabel mMostRankLevel;

		// Token: 0x0400F081 RID: 61569
		[Token(Token = "0x400F081")]
		[FieldOffset(Offset = "0x50")]
		public UILabel mMostRankPoint;

		// Token: 0x0400F082 RID: 61570
		[Token(Token = "0x400F082")]
		[FieldOffset(Offset = "0x58")]
		public UILabel mTop10P;

		// Token: 0x0400F083 RID: 61571
		[Token(Token = "0x400F083")]
		[FieldOffset(Offset = "0x60")]
		public UILabel mTop50P;

		// Token: 0x0400F084 RID: 61572
		[Token(Token = "0x400F084")]
		[FieldOffset(Offset = "0x68")]
		public UILabel mSurvialTime;

		// Token: 0x0400F085 RID: 61573
		[Token(Token = "0x400F085")]
		[FieldOffset(Offset = "0x70")]
		public UILabel mMoveDistance;

		// Token: 0x0400F086 RID: 61574
		[Token(Token = "0x400F086")]
		[FieldOffset(Offset = "0x78")]
		public UILabel bTotalKill;

		// Token: 0x0400F087 RID: 61575
		[Token(Token = "0x400F087")]
		[FieldOffset(Offset = "0x80")]
		public UILabel bHeadShot;

		// Token: 0x0400F088 RID: 61576
		[Token(Token = "0x400F088")]
		[FieldOffset(Offset = "0x88")]
		public UILabel bAvgKill;

		// Token: 0x0400F089 RID: 61577
		[Token(Token = "0x400F089")]
		[FieldOffset(Offset = "0x90")]
		public UILabel bAvgDamage;

		// Token: 0x0400F08A RID: 61578
		[Token(Token = "0x400F08A")]
		[FieldOffset(Offset = "0x98")]
		public UILabel bMostKill;

		// Token: 0x0400F08B RID: 61579
		[Token(Token = "0x400F08B")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel bMostDamage;

		// Token: 0x0400F08C RID: 61580
		[Token(Token = "0x400F08C")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel bRevivals;

		// Token: 0x0400F08D RID: 61581
		[Token(Token = "0x400F08D")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject CSRankGroup;

		// Token: 0x0400F08E RID: 61582
		[Token(Token = "0x400F08E")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel CSMatchCount;

		// Token: 0x0400F08F RID: 61583
		[Token(Token = "0x400F08F")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject KDRatioLabel;

		// Token: 0x0400F090 RID: 61584
		[Token(Token = "0x400F090")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel CSKDRatio;

		// Token: 0x0400F091 RID: 61585
		[Token(Token = "0x400F091")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel CSWins;

		// Token: 0x0400F092 RID: 61586
		[Token(Token = "0x400F092")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel CSMostRankLevel;

		// Token: 0x0400F093 RID: 61587
		[Token(Token = "0x400F093")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject MVPLabel;

		// Token: 0x0400F094 RID: 61588
		[Token(Token = "0x400F094")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel CSMvp;

		// Token: 0x0400F095 RID: 61589
		[Token(Token = "0x400F095")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject WinRateLabel;

		// Token: 0x0400F096 RID: 61590
		[Token(Token = "0x400F096")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel CSWinRate;

		// Token: 0x0400F097 RID: 61591
		[Token(Token = "0x400F097")]
		[FieldOffset(Offset = "0x100")]
		public GameObject AVGDamageLabel;

		// Token: 0x0400F098 RID: 61592
		[Token(Token = "0x400F098")]
		[FieldOffset(Offset = "0x108")]
		public UILabel CSAVGDamage;

		// Token: 0x0400F099 RID: 61593
		[Token(Token = "0x400F099")]
		[FieldOffset(Offset = "0x110")]
		public GameObject RevivesLabel;

		// Token: 0x0400F09A RID: 61594
		[Token(Token = "0x400F09A")]
		[FieldOffset(Offset = "0x118")]
		public UILabel CSRevives;

		// Token: 0x0400F09B RID: 61595
		[Token(Token = "0x400F09B")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TotalKillLabel;

		// Token: 0x0400F09C RID: 61596
		[Token(Token = "0x400F09C")]
		[FieldOffset(Offset = "0x128")]
		public UILabel CSTotalKill;

		// Token: 0x0400F09D RID: 61597
		[Token(Token = "0x400F09D")]
		[FieldOffset(Offset = "0x130")]
		public GameObject DoubleKillLabel;

		// Token: 0x0400F09E RID: 61598
		[Token(Token = "0x400F09E")]
		[FieldOffset(Offset = "0x138")]
		public UILabel CSDoubleKill;

		// Token: 0x0400F09F RID: 61599
		[Token(Token = "0x400F09F")]
		[FieldOffset(Offset = "0x140")]
		public GameObject ThreekillLabel;

		// Token: 0x0400F0A0 RID: 61600
		[Token(Token = "0x400F0A0")]
		[FieldOffset(Offset = "0x148")]
		public UILabel CSThreeKill;

		// Token: 0x0400F0A1 RID: 61601
		[Token(Token = "0x400F0A1")]
		[FieldOffset(Offset = "0x150")]
		public GameObject FourKillLabel;

		// Token: 0x0400F0A2 RID: 61602
		[Token(Token = "0x400F0A2")]
		[FieldOffset(Offset = "0x158")]
		public UILabel CSFourKill;

		// Token: 0x0400F0A3 RID: 61603
		[Token(Token = "0x400F0A3")]
		[FieldOffset(Offset = "0x160")]
		public GameObject HeadShotLabel;

		// Token: 0x0400F0A4 RID: 61604
		[Token(Token = "0x400F0A4")]
		[FieldOffset(Offset = "0x168")]
		public UILabel CSHeadShot;

		// Token: 0x0400F0A5 RID: 61605
		[Token(Token = "0x400F0A5")]
		[FieldOffset(Offset = "0x170")]
		public GameObject HeadShotRatioLabel;

		// Token: 0x0400F0A6 RID: 61606
		[Token(Token = "0x400F0A6")]
		[FieldOffset(Offset = "0x178")]
		public UILabel CSHeadShotRatio;

		// Token: 0x0400F0A7 RID: 61607
		[Token(Token = "0x400F0A7")]
		[FieldOffset(Offset = "0x180")]
		public GameObject BRRankLevel;

		// Token: 0x0400F0A8 RID: 61608
		[Token(Token = "0x400F0A8")]
		[FieldOffset(Offset = "0x188")]
		public UISprite RankIconCurrent;

		// Token: 0x0400F0A9 RID: 61609
		[Token(Token = "0x400F0A9")]
		[FieldOffset(Offset = "0x190")]
		public UILabel CurRankName;

		// Token: 0x0400F0AA RID: 61610
		[Token(Token = "0x400F0AA")]
		[FieldOffset(Offset = "0x198")]
		public GameObject RankEffect;

		// Token: 0x0400F0AB RID: 61611
		[Token(Token = "0x400F0AB")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject HeroicLeveContainer;

		// Token: 0x0400F0AC RID: 61612
		[Token(Token = "0x400F0AC")]
		[FieldOffset(Offset = "0x1A8")]
		public UILadderMatchHeroicLevelView UILadderMatchHeroic;

		// Token: 0x0400F0AD RID: 61613
		[Token(Token = "0x400F0AD")]
		[FieldOffset(Offset = "0x1B0")]
		public UILabel SeasonInfoLabel;

		// Token: 0x0400F0AE RID: 61614
		[Token(Token = "0x400F0AE")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel SeasonLabel;

		// Token: 0x0400F0AF RID: 61615
		[Token(Token = "0x400F0AF")]
		[FieldOffset(Offset = "0x1C0")]
		public UILabel RankType;

		// Token: 0x0400F0B0 RID: 61616
		[Token(Token = "0x400F0B0")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject CSRankLevel;

		// Token: 0x0400F0B1 RID: 61617
		[Token(Token = "0x400F0B1")]
		[FieldOffset(Offset = "0x1D0")]
		public UIGrid CSGrid;

		// Token: 0x0400F0B2 RID: 61618
		[Token(Token = "0x400F0B2")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject star1;

		// Token: 0x0400F0B3 RID: 61619
		[Token(Token = "0x400F0B3")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject star2;

		// Token: 0x0400F0B4 RID: 61620
		[Token(Token = "0x400F0B4")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject star3;

		// Token: 0x0400F0B5 RID: 61621
		[Token(Token = "0x400F0B5")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject star4;

		// Token: 0x0400F0B6 RID: 61622
		[Token(Token = "0x400F0B6")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject star5;

		// Token: 0x0400F0B7 RID: 61623
		[Token(Token = "0x400F0B7")]
		[FieldOffset(Offset = "0x200")]
		public GameObject blackstar1;

		// Token: 0x0400F0B8 RID: 61624
		[Token(Token = "0x400F0B8")]
		[FieldOffset(Offset = "0x208")]
		public GameObject blackstar2;

		// Token: 0x0400F0B9 RID: 61625
		[Token(Token = "0x400F0B9")]
		[FieldOffset(Offset = "0x210")]
		public GameObject blackstar3;

		// Token: 0x0400F0BA RID: 61626
		[Token(Token = "0x400F0BA")]
		[FieldOffset(Offset = "0x218")]
		public GameObject blackstar4;

		// Token: 0x0400F0BB RID: 61627
		[Token(Token = "0x400F0BB")]
		[FieldOffset(Offset = "0x220")]
		public GameObject blackstar5;

		// Token: 0x0400F0BC RID: 61628
		[Token(Token = "0x400F0BC")]
		[FieldOffset(Offset = "0x228")]
		public GameObject StarIcon;

		// Token: 0x0400F0BD RID: 61629
		[Token(Token = "0x400F0BD")]
		[FieldOffset(Offset = "0x230")]
		public UILabel MaxRankTxt;

		// Token: 0x0400F0BE RID: 61630
		[Token(Token = "0x400F0BE")]
		[FieldOffset(Offset = "0x238")]
		public UISprite CSRankIcon;

		// Token: 0x0400F0BF RID: 61631
		[Token(Token = "0x400F0BF")]
		[FieldOffset(Offset = "0x240")]
		public UILabel CSRankName;

		// Token: 0x0400F0C0 RID: 61632
		[Token(Token = "0x400F0C0")]
		[FieldOffset(Offset = "0x248")]
		public UILabel CSSeasonInfoLabel;

		// Token: 0x0400F0C1 RID: 61633
		[Token(Token = "0x400F0C1")]
		[FieldOffset(Offset = "0x250")]
		public UILabel CSSeasonLabel;

		// Token: 0x0400F0C2 RID: 61634
		[Token(Token = "0x400F0C2")]
		[FieldOffset(Offset = "0x258")]
		public UIButton ShareBtn;

		// Token: 0x0400F0C3 RID: 61635
		[Token(Token = "0x400F0C3")]
		[FieldOffset(Offset = "0x260")]
		public Animator ShareIconAnimator;

		// Token: 0x0400F0C4 RID: 61636
		[Token(Token = "0x400F0C4")]
		[FieldOffset(Offset = "0x268")]
		public GameObject LadderParticleEffect;
	}
}
