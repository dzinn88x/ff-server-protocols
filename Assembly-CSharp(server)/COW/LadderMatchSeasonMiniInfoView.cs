using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C9 RID: 8393
	[Token(Token = "0x20020C9")]
	public class LadderMatchSeasonMiniInfoView : UIBaseView
	{
		// Token: 0x0600BCA3 RID: 48291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA3")]
		[Address(RVA = "0x13FD38C", Offset = "0x13FD38C", VA = "0x7BBBBFD38C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCA4 RID: 48292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA4")]
		[Address(RVA = "0x13FDE64", Offset = "0x13FDE64", VA = "0x7BBBBFDE64")]
		public LadderMatchSeasonMiniInfoView()
		{
		}

		// Token: 0x0400BDF1 RID: 48625
		[Token(Token = "0x400BDF1")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ContentContainer;

		// Token: 0x0400BDF2 RID: 48626
		[Token(Token = "0x400BDF2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MatchCountLabel;

		// Token: 0x0400BDF3 RID: 48627
		[Token(Token = "0x400BDF3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel KDTitle;

		// Token: 0x0400BDF4 RID: 48628
		[Token(Token = "0x400BDF4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel KDLabel;

		// Token: 0x0400BDF5 RID: 48629
		[Token(Token = "0x400BDF5")]
		[FieldOffset(Offset = "0x40")]
		public UIButton DetailBtn;

		// Token: 0x0400BDF6 RID: 48630
		[Token(Token = "0x400BDF6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelSeason;

		// Token: 0x0400BDF7 RID: 48631
		[Token(Token = "0x400BDF7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel SeasonInfoLabel;

		// Token: 0x0400BDF8 RID: 48632
		[Token(Token = "0x400BDF8")]
		[FieldOffset(Offset = "0x58")]
		public UIButton RuleButton;

		// Token: 0x0400BDF9 RID: 48633
		[Token(Token = "0x400BDF9")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BRRankGroup;

		// Token: 0x0400BDFA RID: 48634
		[Token(Token = "0x400BDFA")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SeasonOpeningObj;

		// Token: 0x0400BDFB RID: 48635
		[Token(Token = "0x400BDFB")]
		[FieldOffset(Offset = "0x70")]
		public UILabel CurRankName;

		// Token: 0x0400BDFC RID: 48636
		[Token(Token = "0x400BDFC")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SeasonOpenHeroicLeveContainer;

		// Token: 0x0400BDFD RID: 48637
		[Token(Token = "0x400BDFD")]
		[FieldOffset(Offset = "0x80")]
		public UILadderMatchHeroicLevelView UILadderMatchHeroicSeasonOpening;

		// Token: 0x0400BDFE RID: 48638
		[Token(Token = "0x400BDFE")]
		[FieldOffset(Offset = "0x88")]
		public UISprite RankIconCurrent;

		// Token: 0x0400BDFF RID: 48639
		[Token(Token = "0x400BDFF")]
		[FieldOffset(Offset = "0x90")]
		public ParticleSystem RankNormalEffect;

		// Token: 0x0400BE00 RID: 48640
		[Token(Token = "0x400BE00")]
		[FieldOffset(Offset = "0x98")]
		public UILabel PeakRankPosLabel;

		// Token: 0x0400BE01 RID: 48641
		[Token(Token = "0x400BE01")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject LabelScoreTip;

		// Token: 0x0400BE02 RID: 48642
		[Token(Token = "0x400BE02")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject LabelProtectTip;

		// Token: 0x0400BE03 RID: 48643
		[Token(Token = "0x400BE03")]
		[FieldOffset(Offset = "0xB0")]
		public TweenAlpha TweenTip;

		// Token: 0x0400BE04 RID: 48644
		[Token(Token = "0x400BE04")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnProtectTip;

		// Token: 0x0400BE05 RID: 48645
		[Token(Token = "0x400BE05")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite BarPointBg;

		// Token: 0x0400BE06 RID: 48646
		[Token(Token = "0x400BE06")]
		[FieldOffset(Offset = "0xC8")]
		public TweenAlpha BarTween;

		// Token: 0x0400BE07 RID: 48647
		[Token(Token = "0x400BE07")]
		[FieldOffset(Offset = "0xD0")]
		public UIProgressBar BarProgressPoint;

		// Token: 0x0400BE08 RID: 48648
		[Token(Token = "0x400BE08")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel ScoreInfoLabel;

		// Token: 0x0400BE09 RID: 48649
		[Token(Token = "0x400BE09")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SeasonClosedObj;

		// Token: 0x0400BE0A RID: 48650
		[Token(Token = "0x400BE0A")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject SeasonCloseHeroicLeveContainer;

		// Token: 0x0400BE0B RID: 48651
		[Token(Token = "0x400BE0B")]
		[FieldOffset(Offset = "0xF0")]
		public UILadderMatchHeroicLevelView UILadderMatchHeroicSeasonClosed;

		// Token: 0x0400BE0C RID: 48652
		[Token(Token = "0x400BE0C")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel FinalRankName;

		// Token: 0x0400BE0D RID: 48653
		[Token(Token = "0x400BE0D")]
		[FieldOffset(Offset = "0x100")]
		public UISprite RankIconFinal;

		// Token: 0x0400BE0E RID: 48654
		[Token(Token = "0x400BE0E")]
		[FieldOffset(Offset = "0x108")]
		public GameObject SeasonClosedSprite;

		// Token: 0x0400BE0F RID: 48655
		[Token(Token = "0x400BE0F")]
		[FieldOffset(Offset = "0x110")]
		public GameObject CSRankGroup;

		// Token: 0x0400BE10 RID: 48656
		[Token(Token = "0x400BE10")]
		[FieldOffset(Offset = "0x118")]
		public UIGrid CSGrid;

		// Token: 0x0400BE11 RID: 48657
		[Token(Token = "0x400BE11")]
		[FieldOffset(Offset = "0x120")]
		public GameObject star1;

		// Token: 0x0400BE12 RID: 48658
		[Token(Token = "0x400BE12")]
		[FieldOffset(Offset = "0x128")]
		public GameObject star2;

		// Token: 0x0400BE13 RID: 48659
		[Token(Token = "0x400BE13")]
		[FieldOffset(Offset = "0x130")]
		public GameObject star3;

		// Token: 0x0400BE14 RID: 48660
		[Token(Token = "0x400BE14")]
		[FieldOffset(Offset = "0x138")]
		public GameObject star4;

		// Token: 0x0400BE15 RID: 48661
		[Token(Token = "0x400BE15")]
		[FieldOffset(Offset = "0x140")]
		public GameObject star5;

		// Token: 0x0400BE16 RID: 48662
		[Token(Token = "0x400BE16")]
		[FieldOffset(Offset = "0x148")]
		public GameObject blackstar1;

		// Token: 0x0400BE17 RID: 48663
		[Token(Token = "0x400BE17")]
		[FieldOffset(Offset = "0x150")]
		public GameObject blackstar2;

		// Token: 0x0400BE18 RID: 48664
		[Token(Token = "0x400BE18")]
		[FieldOffset(Offset = "0x158")]
		public GameObject blackstar3;

		// Token: 0x0400BE19 RID: 48665
		[Token(Token = "0x400BE19")]
		[FieldOffset(Offset = "0x160")]
		public GameObject blackstar4;

		// Token: 0x0400BE1A RID: 48666
		[Token(Token = "0x400BE1A")]
		[FieldOffset(Offset = "0x168")]
		public GameObject blackstar5;

		// Token: 0x0400BE1B RID: 48667
		[Token(Token = "0x400BE1B")]
		[FieldOffset(Offset = "0x170")]
		public UILabel MaxRankTxt;

		// Token: 0x0400BE1C RID: 48668
		[Token(Token = "0x400BE1C")]
		[FieldOffset(Offset = "0x178")]
		public UISprite CSRankIcon;

		// Token: 0x0400BE1D RID: 48669
		[Token(Token = "0x400BE1D")]
		[FieldOffset(Offset = "0x180")]
		public UILabel CSRankName;

		// Token: 0x0400BE1E RID: 48670
		[Token(Token = "0x400BE1E")]
		[FieldOffset(Offset = "0x188")]
		public UILabel CSPointNum;
	}
}
