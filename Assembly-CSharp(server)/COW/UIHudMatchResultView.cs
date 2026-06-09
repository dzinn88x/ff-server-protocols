using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002314 RID: 8980
	[Token(Token = "0x2002314")]
	public class UIHudMatchResultView : UIBaseView
	{
		// Token: 0x0600C138 RID: 49464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C138")]
		[Address(RVA = "0x17B0064", Offset = "0x17B0064", VA = "0x7BBBFB0064", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C139")]
		[Address(RVA = "0x17B1290", Offset = "0x17B1290", VA = "0x7BBBFB1290")]
		public UIHudMatchResultView()
		{
		}

		// Token: 0x0400D918 RID: 55576
		[Token(Token = "0x400D918")]
		[FieldOffset(Offset = "0x20")]
		public UITexture BG;

		// Token: 0x0400D919 RID: 55577
		[Token(Token = "0x400D919")]
		[FieldOffset(Offset = "0x28")]
		public UIButton DetailMaskBtn;

		// Token: 0x0400D91A RID: 55578
		[Token(Token = "0x400D91A")]
		[FieldOffset(Offset = "0x30")]
		public UIMatchResultDetailView m_MatchResultDetailWindow;

		// Token: 0x0400D91B RID: 55579
		[Token(Token = "0x400D91B")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RewardDetailBtn;

		// Token: 0x0400D91C RID: 55580
		[Token(Token = "0x400D91C")]
		[FieldOffset(Offset = "0x40")]
		public UILabel PVEResultDesc;

		// Token: 0x0400D91D RID: 55581
		[Token(Token = "0x400D91D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject KillerInfoGO;

		// Token: 0x0400D91E RID: 55582
		[Token(Token = "0x400D91E")]
		[FieldOffset(Offset = "0x50")]
		public UILabel KillerName;

		// Token: 0x0400D91F RID: 55583
		[Token(Token = "0x400D91F")]
		[FieldOffset(Offset = "0x58")]
		public UILabel KillInfo;

		// Token: 0x0400D920 RID: 55584
		[Token(Token = "0x400D920")]
		[FieldOffset(Offset = "0x60")]
		public GameObject IDAndLike;

		// Token: 0x0400D921 RID: 55585
		[Token(Token = "0x400D921")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PlayerID;

		// Token: 0x0400D922 RID: 55586
		[Token(Token = "0x400D922")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Liked;

		// Token: 0x0400D923 RID: 55587
		[Token(Token = "0x400D923")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LikedCount;

		// Token: 0x0400D924 RID: 55588
		[Token(Token = "0x400D924")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ResultDesc;

		// Token: 0x0400D925 RID: 55589
		[Token(Token = "0x400D925")]
		[FieldOffset(Offset = "0x88")]
		public GameObject FactionInfo;

		// Token: 0x0400D926 RID: 55590
		[Token(Token = "0x400D926")]
		[FieldOffset(Offset = "0x90")]
		public UISprite FactionIcon;

		// Token: 0x0400D927 RID: 55591
		[Token(Token = "0x400D927")]
		[FieldOffset(Offset = "0x98")]
		public UILabel FactionName;

		// Token: 0x0400D928 RID: 55592
		[Token(Token = "0x400D928")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject CSResultDescAnchor;

		// Token: 0x0400D929 RID: 55593
		[Token(Token = "0x400D929")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject CSResultUserIDAnchor;

		// Token: 0x0400D92A RID: 55594
		[Token(Token = "0x400D92A")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel GameModeName;

		// Token: 0x0400D92B RID: 55595
		[Token(Token = "0x400D92B")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel MapName;

		// Token: 0x0400D92C RID: 55596
		[Token(Token = "0x400D92C")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel PVEDifficulty;

		// Token: 0x0400D92D RID: 55597
		[Token(Token = "0x400D92D")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject SingleModeIcon;

		// Token: 0x0400D92E RID: 55598
		[Token(Token = "0x400D92E")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject DualModeIcon;

		// Token: 0x0400D92F RID: 55599
		[Token(Token = "0x400D92F")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject QuadModeIcon;

		// Token: 0x0400D930 RID: 55600
		[Token(Token = "0x400D930")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject RankGo;

		// Token: 0x0400D931 RID: 55601
		[Token(Token = "0x400D931")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel BigRank;

		// Token: 0x0400D932 RID: 55602
		[Token(Token = "0x400D932")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel TotalPlayerCount;

		// Token: 0x0400D933 RID: 55603
		[Token(Token = "0x400D933")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite SpriteAchievementIcon;

		// Token: 0x0400D934 RID: 55604
		[Token(Token = "0x400D934")]
		[FieldOffset(Offset = "0x100")]
		public UILabel LabelAchievementDesc;

		// Token: 0x0400D935 RID: 55605
		[Token(Token = "0x400D935")]
		[FieldOffset(Offset = "0x108")]
		public UISprite BG_Shared;

		// Token: 0x0400D936 RID: 55606
		[Token(Token = "0x400D936")]
		[FieldOffset(Offset = "0x110")]
		public UITexture GameTexture;

		// Token: 0x0400D937 RID: 55607
		[Token(Token = "0x400D937")]
		[FieldOffset(Offset = "0x118")]
		public GameObject RedEnvelopeAwardContainer;

		// Token: 0x0400D938 RID: 55608
		[Token(Token = "0x400D938")]
		[FieldOffset(Offset = "0x120")]
		public UIButton RedAwardDetailButton;

		// Token: 0x0400D939 RID: 55609
		[Token(Token = "0x400D939")]
		[FieldOffset(Offset = "0x128")]
		public UILabel RedItemItemNameCnt;

		// Token: 0x0400D93A RID: 55610
		[Token(Token = "0x400D93A")]
		[FieldOffset(Offset = "0x130")]
		public UILabel Bg;

		// Token: 0x0400D93B RID: 55611
		[Token(Token = "0x400D93B")]
		[FieldOffset(Offset = "0x138")]
		public UIGrid RedAwardGrid;

		// Token: 0x0400D93C RID: 55612
		[Token(Token = "0x400D93C")]
		[FieldOffset(Offset = "0x140")]
		public GameObject RedCoinAward;

		// Token: 0x0400D93D RID: 55613
		[Token(Token = "0x400D93D")]
		[FieldOffset(Offset = "0x148")]
		public UILabel CoinCount;

		// Token: 0x0400D93E RID: 55614
		[Token(Token = "0x400D93E")]
		[FieldOffset(Offset = "0x150")]
		public GameObject RedGemAward;

		// Token: 0x0400D93F RID: 55615
		[Token(Token = "0x400D93F")]
		[FieldOffset(Offset = "0x158")]
		public UILabel GemCount;

		// Token: 0x0400D940 RID: 55616
		[Token(Token = "0x400D940")]
		[FieldOffset(Offset = "0x160")]
		public GameObject HasLuckyIcon;

		// Token: 0x0400D941 RID: 55617
		[Token(Token = "0x400D941")]
		[FieldOffset(Offset = "0x168")]
		public GameObject RewardPVEContainer;

		// Token: 0x0400D942 RID: 55618
		[Token(Token = "0x400D942")]
		[FieldOffset(Offset = "0x170")]
		public GameObject GoldIcon;

		// Token: 0x0400D943 RID: 55619
		[Token(Token = "0x400D943")]
		[FieldOffset(Offset = "0x178")]
		public UILabel GoldRewardCount;

		// Token: 0x0400D944 RID: 55620
		[Token(Token = "0x400D944")]
		[FieldOffset(Offset = "0x180")]
		public UISprite ExpIcon;

		// Token: 0x0400D945 RID: 55621
		[Token(Token = "0x400D945")]
		[FieldOffset(Offset = "0x188")]
		public UILabel m_ExpCount;

		// Token: 0x0400D946 RID: 55622
		[Token(Token = "0x400D946")]
		[FieldOffset(Offset = "0x190")]
		public UISprite PetExpIcon;

		// Token: 0x0400D947 RID: 55623
		[Token(Token = "0x400D947")]
		[FieldOffset(Offset = "0x198")]
		public UILabel m_PetExpCount;

		// Token: 0x0400D948 RID: 55624
		[Token(Token = "0x400D948")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject CurrentStarsContainer;

		// Token: 0x0400D949 RID: 55625
		[Token(Token = "0x400D949")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel CurrentStarsNumber;

		// Token: 0x0400D94A RID: 55626
		[Token(Token = "0x400D94A")]
		[FieldOffset(Offset = "0x1B0")]
		public UISprite ShareGoldBonus;

		// Token: 0x0400D94B RID: 55627
		[Token(Token = "0x400D94B")]
		[FieldOffset(Offset = "0x1B8")]
		public UIButton GoldTipsBtn;

		// Token: 0x0400D94C RID: 55628
		[Token(Token = "0x400D94C")]
		[FieldOffset(Offset = "0x1C0")]
		public UISprite ShareExpBonus;

		// Token: 0x0400D94D RID: 55629
		[Token(Token = "0x400D94D")]
		[FieldOffset(Offset = "0x1C8")]
		public UIButton ExpTipsBtn;

		// Token: 0x0400D94E RID: 55630
		[Token(Token = "0x400D94E")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject DebrisRewardContainer;

		// Token: 0x0400D94F RID: 55631
		[Token(Token = "0x400D94F")]
		[FieldOffset(Offset = "0x1D8")]
		public UISprite DebrisItemIcon;

		// Token: 0x0400D950 RID: 55632
		[Token(Token = "0x400D950")]
		[FieldOffset(Offset = "0x1E0")]
		public UILabel DebrisCountLabel;

		// Token: 0x0400D951 RID: 55633
		[Token(Token = "0x400D951")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject DebrisCountMaxLabel;

		// Token: 0x0400D952 RID: 55634
		[Token(Token = "0x400D952")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject ResultBtnContainer;

		// Token: 0x0400D953 RID: 55635
		[Token(Token = "0x400D953")]
		[FieldOffset(Offset = "0x1F8")]
		public UIGrid RewardBtns;

		// Token: 0x0400D954 RID: 55636
		[Token(Token = "0x400D954")]
		[FieldOffset(Offset = "0x200")]
		public UIButton FastSendGiftBtn;

		// Token: 0x0400D955 RID: 55637
		[Token(Token = "0x400D955")]
		[FieldOffset(Offset = "0x208")]
		public UIButton BtnReward;

		// Token: 0x0400D956 RID: 55638
		[Token(Token = "0x400D956")]
		[FieldOffset(Offset = "0x210")]
		public UIButton BtnShare;

		// Token: 0x0400D957 RID: 55639
		[Token(Token = "0x400D957")]
		[FieldOffset(Offset = "0x218")]
		public Animator ShareIconAnimator;

		// Token: 0x0400D958 RID: 55640
		[Token(Token = "0x400D958")]
		[FieldOffset(Offset = "0x220")]
		public GameObject NormalShareIcon;

		// Token: 0x0400D959 RID: 55641
		[Token(Token = "0x400D959")]
		[FieldOffset(Offset = "0x228")]
		public GameObject NormalShareIcon2;

		// Token: 0x0400D95A RID: 55642
		[Token(Token = "0x400D95A")]
		[FieldOffset(Offset = "0x230")]
		public UILabel CountdownInfo;

		// Token: 0x0400D95B RID: 55643
		[Token(Token = "0x400D95B")]
		[FieldOffset(Offset = "0x238")]
		public UIButton BackToLobbyButton;

		// Token: 0x0400D95C RID: 55644
		[Token(Token = "0x400D95C")]
		[FieldOffset(Offset = "0x240")]
		public Transform TeammatesGridTitle;

		// Token: 0x0400D95D RID: 55645
		[Token(Token = "0x400D95D")]
		[FieldOffset(Offset = "0x248")]
		public UIGrid TeammatesGrid;

		// Token: 0x0400D95E RID: 55646
		[Token(Token = "0x400D95E")]
		[FieldOffset(Offset = "0x250")]
		public GameObject BiaoQianContainer;

		// Token: 0x0400D95F RID: 55647
		[Token(Token = "0x400D95F")]
		[FieldOffset(Offset = "0x258")]
		public UIWidget Biaoqian1;

		// Token: 0x0400D960 RID: 55648
		[Token(Token = "0x400D960")]
		[FieldOffset(Offset = "0x260")]
		public UIWidget Biaoqian2;

		// Token: 0x0400D961 RID: 55649
		[Token(Token = "0x400D961")]
		[FieldOffset(Offset = "0x268")]
		public UIWidget Biaoqian3;

		// Token: 0x0400D962 RID: 55650
		[Token(Token = "0x400D962")]
		[FieldOffset(Offset = "0x270")]
		public UIWidget Biaoqian4;

		// Token: 0x0400D963 RID: 55651
		[Token(Token = "0x400D963")]
		[FieldOffset(Offset = "0x278")]
		public UIWidget PlaceHolderBiaoqian;

		// Token: 0x0400D964 RID: 55652
		[Token(Token = "0x400D964")]
		[FieldOffset(Offset = "0x280")]
		public GameObject BiaoQianContainerShare;

		// Token: 0x0400D965 RID: 55653
		[Token(Token = "0x400D965")]
		[FieldOffset(Offset = "0x288")]
		public UIWidget Biaoqian1Share;

		// Token: 0x0400D966 RID: 55654
		[Token(Token = "0x400D966")]
		[FieldOffset(Offset = "0x290")]
		public UIWidget Biaoqian2Share;

		// Token: 0x0400D967 RID: 55655
		[Token(Token = "0x400D967")]
		[FieldOffset(Offset = "0x298")]
		public UIWidget Biaoqian3Share;

		// Token: 0x0400D968 RID: 55656
		[Token(Token = "0x400D968")]
		[FieldOffset(Offset = "0x2A0")]
		public UIWidget Biaoqian4Share;
	}
}
