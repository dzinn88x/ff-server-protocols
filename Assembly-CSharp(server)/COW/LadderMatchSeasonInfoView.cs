using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C8 RID: 8392
	[Token(Token = "0x20020C8")]
	public class LadderMatchSeasonInfoView : UIBaseView
	{
		// Token: 0x0600BCA1 RID: 48289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA1")]
		[Address(RVA = "0x13FC840", Offset = "0x13FC840", VA = "0x7BBBBFC840", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCA2 RID: 48290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA2")]
		[Address(RVA = "0x13FD384", Offset = "0x13FD384", VA = "0x7BBBBFD384")]
		public LadderMatchSeasonInfoView()
		{
		}

		// Token: 0x0400BDC0 RID: 48576
		[Token(Token = "0x400BDC0")]
		[FieldOffset(Offset = "0x20")]
		public Animator Anim;

		// Token: 0x0400BDC1 RID: 48577
		[Token(Token = "0x400BDC1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentContainer;

		// Token: 0x0400BDC2 RID: 48578
		[Token(Token = "0x400BDC2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LadderParticleEffect;

		// Token: 0x0400BDC3 RID: 48579
		[Token(Token = "0x400BDC3")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SeasonLabel;

		// Token: 0x0400BDC4 RID: 48580
		[Token(Token = "0x400BDC4")]
		[FieldOffset(Offset = "0x40")]
		public UILabel SeasonInfoLabel;

		// Token: 0x0400BDC5 RID: 48581
		[Token(Token = "0x400BDC5")]
		[FieldOffset(Offset = "0x48")]
		public UIButton RuleButton;

		// Token: 0x0400BDC6 RID: 48582
		[Token(Token = "0x400BDC6")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BRRankGroup;

		// Token: 0x0400BDC7 RID: 48583
		[Token(Token = "0x400BDC7")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SeasonClosedObj;

		// Token: 0x0400BDC8 RID: 48584
		[Token(Token = "0x400BDC8")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SeasonCloseHeroicLeveContainer;

		// Token: 0x0400BDC9 RID: 48585
		[Token(Token = "0x400BDC9")]
		[FieldOffset(Offset = "0x68")]
		public UILadderMatchHeroicLevelView UILadderMatchHeroicSeasonClosed;

		// Token: 0x0400BDCA RID: 48586
		[Token(Token = "0x400BDCA")]
		[FieldOffset(Offset = "0x70")]
		public UILabel FinalRankName;

		// Token: 0x0400BDCB RID: 48587
		[Token(Token = "0x400BDCB")]
		[FieldOffset(Offset = "0x78")]
		public UISprite RankIconFinal;

		// Token: 0x0400BDCC RID: 48588
		[Token(Token = "0x400BDCC")]
		[FieldOffset(Offset = "0x80")]
		public GameObject SeasonClosedSprite;

		// Token: 0x0400BDCD RID: 48589
		[Token(Token = "0x400BDCD")]
		[FieldOffset(Offset = "0x88")]
		public UILabel FinalScoreInfoLabel;

		// Token: 0x0400BDCE RID: 48590
		[Token(Token = "0x400BDCE")]
		[FieldOffset(Offset = "0x90")]
		public GameObject SeasonOpeningObj;

		// Token: 0x0400BDCF RID: 48591
		[Token(Token = "0x400BDCF")]
		[FieldOffset(Offset = "0x98")]
		public UILabel CurRankName;

		// Token: 0x0400BDD0 RID: 48592
		[Token(Token = "0x400BDD0")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel PeakRankPosLabel;

		// Token: 0x0400BDD1 RID: 48593
		[Token(Token = "0x400BDD1")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite RankIconCurrent;

		// Token: 0x0400BDD2 RID: 48594
		[Token(Token = "0x400BDD2")]
		[FieldOffset(Offset = "0xB0")]
		public ParticleSystem RankNormalEffect;

		// Token: 0x0400BDD3 RID: 48595
		[Token(Token = "0x400BDD3")]
		[FieldOffset(Offset = "0xB8")]
		public ParticleSystem PeakRankContinousEffect;

		// Token: 0x0400BDD4 RID: 48596
		[Token(Token = "0x400BDD4")]
		[FieldOffset(Offset = "0xC0")]
		public ParticleSystem PeakRankLevelUpEffect;

		// Token: 0x0400BDD5 RID: 48597
		[Token(Token = "0x400BDD5")]
		[FieldOffset(Offset = "0xC8")]
		public ParticleSystem PeakRankLevelDownEffect;

		// Token: 0x0400BDD6 RID: 48598
		[Token(Token = "0x400BDD6")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject SeasonOpenHeroicLeveContainer;

		// Token: 0x0400BDD7 RID: 48599
		[Token(Token = "0x400BDD7")]
		[FieldOffset(Offset = "0xD8")]
		public UILadderMatchHeroicLevelView UILadderMatchHeroicSeasonOpening;

		// Token: 0x0400BDD8 RID: 48600
		[Token(Token = "0x400BDD8")]
		[FieldOffset(Offset = "0xE0")]
		public UIProgressBar BarProgressPoint;

		// Token: 0x0400BDD9 RID: 48601
		[Token(Token = "0x400BDD9")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite BarPointBg;

		// Token: 0x0400BDDA RID: 48602
		[Token(Token = "0x400BDDA")]
		[FieldOffset(Offset = "0xF0")]
		public TweenAlpha BarTween;

		// Token: 0x0400BDDB RID: 48603
		[Token(Token = "0x400BDDB")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject LabelPointTip;

		// Token: 0x0400BDDC RID: 48604
		[Token(Token = "0x400BDDC")]
		[FieldOffset(Offset = "0x100")]
		public GameObject LabelProtectTip;

		// Token: 0x0400BDDD RID: 48605
		[Token(Token = "0x400BDDD")]
		[FieldOffset(Offset = "0x108")]
		public TweenAlpha TweenTip;

		// Token: 0x0400BDDE RID: 48606
		[Token(Token = "0x400BDDE")]
		[FieldOffset(Offset = "0x110")]
		public UIButton BtnProtectTip;

		// Token: 0x0400BDDF RID: 48607
		[Token(Token = "0x400BDDF")]
		[FieldOffset(Offset = "0x118")]
		public UILabel ScoreInfoLabel;

		// Token: 0x0400BDE0 RID: 48608
		[Token(Token = "0x400BDE0")]
		[FieldOffset(Offset = "0x120")]
		public GameObject CSRankGroup;

		// Token: 0x0400BDE1 RID: 48609
		[Token(Token = "0x400BDE1")]
		[FieldOffset(Offset = "0x128")]
		public UIGrid CSGrid;

		// Token: 0x0400BDE2 RID: 48610
		[Token(Token = "0x400BDE2")]
		[FieldOffset(Offset = "0x130")]
		public GameObject star1;

		// Token: 0x0400BDE3 RID: 48611
		[Token(Token = "0x400BDE3")]
		[FieldOffset(Offset = "0x138")]
		public GameObject star2;

		// Token: 0x0400BDE4 RID: 48612
		[Token(Token = "0x400BDE4")]
		[FieldOffset(Offset = "0x140")]
		public GameObject star3;

		// Token: 0x0400BDE5 RID: 48613
		[Token(Token = "0x400BDE5")]
		[FieldOffset(Offset = "0x148")]
		public GameObject star4;

		// Token: 0x0400BDE6 RID: 48614
		[Token(Token = "0x400BDE6")]
		[FieldOffset(Offset = "0x150")]
		public GameObject star5;

		// Token: 0x0400BDE7 RID: 48615
		[Token(Token = "0x400BDE7")]
		[FieldOffset(Offset = "0x158")]
		public GameObject blackstar1;

		// Token: 0x0400BDE8 RID: 48616
		[Token(Token = "0x400BDE8")]
		[FieldOffset(Offset = "0x160")]
		public GameObject blackstar2;

		// Token: 0x0400BDE9 RID: 48617
		[Token(Token = "0x400BDE9")]
		[FieldOffset(Offset = "0x168")]
		public GameObject blackstar3;

		// Token: 0x0400BDEA RID: 48618
		[Token(Token = "0x400BDEA")]
		[FieldOffset(Offset = "0x170")]
		public GameObject blackstar4;

		// Token: 0x0400BDEB RID: 48619
		[Token(Token = "0x400BDEB")]
		[FieldOffset(Offset = "0x178")]
		public GameObject blackstar5;

		// Token: 0x0400BDEC RID: 48620
		[Token(Token = "0x400BDEC")]
		[FieldOffset(Offset = "0x180")]
		public UILabel MaxRankTxt;

		// Token: 0x0400BDED RID: 48621
		[Token(Token = "0x400BDED")]
		[FieldOffset(Offset = "0x188")]
		public GameObject StarIcon;

		// Token: 0x0400BDEE RID: 48622
		[Token(Token = "0x400BDEE")]
		[FieldOffset(Offset = "0x190")]
		public UISprite CSRankIcon;

		// Token: 0x0400BDEF RID: 48623
		[Token(Token = "0x400BDEF")]
		[FieldOffset(Offset = "0x198")]
		public UILabel CSRankName;

		// Token: 0x0400BDF0 RID: 48624
		[Token(Token = "0x400BDF0")]
		[FieldOffset(Offset = "0x1A0")]
		public UILabel CSPointNum;
	}
}
