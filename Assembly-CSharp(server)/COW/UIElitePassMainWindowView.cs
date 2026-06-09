using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B8 RID: 8632
	[Token(Token = "0x20021B8")]
	public class UIElitePassMainWindowView : UIBaseView
	{
		// Token: 0x0600BE80 RID: 48768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE80")]
		[Address(RVA = "0x1E66C58", Offset = "0x1E66C58", VA = "0x7BBC666C58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE81 RID: 48769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE81")]
		[Address(RVA = "0x1E67BB8", Offset = "0x1E67BB8", VA = "0x7BBC667BB8")]
		public UIElitePassMainWindowView()
		{
		}

		// Token: 0x0400CA36 RID: 51766
		[Token(Token = "0x400CA36")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClaimAllBtn;

		// Token: 0x0400CA37 RID: 51767
		[Token(Token = "0x400CA37")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ScrollView;

		// Token: 0x0400CA38 RID: 51768
		[Token(Token = "0x400CA38")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList RewardList;

		// Token: 0x0400CA39 RID: 51769
		[Token(Token = "0x400CA39")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ElitePassIcon;

		// Token: 0x0400CA3A RID: 51770
		[Token(Token = "0x400CA3A")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PrivilegeBtn1;

		// Token: 0x0400CA3B RID: 51771
		[Token(Token = "0x400CA3B")]
		[FieldOffset(Offset = "0x48")]
		public UIButton EPLockBtn;

		// Token: 0x0400CA3C RID: 51772
		[Token(Token = "0x400CA3C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton PreOrderEPBtn;

		// Token: 0x0400CA3D RID: 51773
		[Token(Token = "0x400CA3D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite PreorderIcon;

		// Token: 0x0400CA3E RID: 51774
		[Token(Token = "0x400CA3E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PreorderLabel;

		// Token: 0x0400CA3F RID: 51775
		[Token(Token = "0x400CA3F")]
		[FieldOffset(Offset = "0x68")]
		public UIButton SubscribeEPBtn;

		// Token: 0x0400CA40 RID: 51776
		[Token(Token = "0x400CA40")]
		[FieldOffset(Offset = "0x70")]
		public UISprite SubscribeIcon;

		// Token: 0x0400CA41 RID: 51777
		[Token(Token = "0x400CA41")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SubscriptionBonus;

		// Token: 0x0400CA42 RID: 51778
		[Token(Token = "0x400CA42")]
		[FieldOffset(Offset = "0x80")]
		public UILabel SubscriptionBonusAmountLabel;

		// Token: 0x0400CA43 RID: 51779
		[Token(Token = "0x400CA43")]
		[FieldOffset(Offset = "0x88")]
		public UILabel SubscribeLabel;

		// Token: 0x0400CA44 RID: 51780
		[Token(Token = "0x400CA44")]
		[FieldOffset(Offset = "0x90")]
		public UISprite SubscriptionTips;

		// Token: 0x0400CA45 RID: 51781
		[Token(Token = "0x400CA45")]
		[FieldOffset(Offset = "0x98")]
		public UISprite SubscribedPanel;

		// Token: 0x0400CA46 RID: 51782
		[Token(Token = "0x400CA46")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton SubscribeHintBtn;

		// Token: 0x0400CA47 RID: 51783
		[Token(Token = "0x400CA47")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ElitePassIconUpdated;

		// Token: 0x0400CA48 RID: 51784
		[Token(Token = "0x400CA48")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton PrivilegeBtn2;

		// Token: 0x0400CA49 RID: 51785
		[Token(Token = "0x400CA49")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ContentScrollBar;

		// Token: 0x0400CA4A RID: 51786
		[Token(Token = "0x400CA4A")]
		[FieldOffset(Offset = "0xC0")]
		public UIWidget ScrollbarBg;

		// Token: 0x0400CA4B RID: 51787
		[Token(Token = "0x400CA4B")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton BigAwardMark;

		// Token: 0x0400CA4C RID: 51788
		[Token(Token = "0x400CA4C")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject CurProgressMark;

		// Token: 0x0400CA4D RID: 51789
		[Token(Token = "0x400CA4D")]
		[FieldOffset(Offset = "0xD8")]
		public Transform CountDown;

		// Token: 0x0400CA4E RID: 51790
		[Token(Token = "0x400CA4E")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite BadgeCountIconSprite;

		// Token: 0x0400CA4F RID: 51791
		[Token(Token = "0x400CA4F")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton badgeInfoBtn;

		// Token: 0x0400CA50 RID: 51792
		[Token(Token = "0x400CA50")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel BadgeCount;

		// Token: 0x0400CA51 RID: 51793
		[Token(Token = "0x400CA51")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton GetBadgeButton;

		// Token: 0x0400CA52 RID: 51794
		[Token(Token = "0x400CA52")]
		[FieldOffset(Offset = "0x100")]
		public GameObject BottomSubscribePreorder;

		// Token: 0x0400CA53 RID: 51795
		[Token(Token = "0x400CA53")]
		[FieldOffset(Offset = "0x108")]
		public UIButton UpgradeEPBtn;

		// Token: 0x0400CA54 RID: 51796
		[Token(Token = "0x400CA54")]
		[FieldOffset(Offset = "0x110")]
		public UIButton BuyBadgeBtn;

		// Token: 0x0400CA55 RID: 51797
		[Token(Token = "0x400CA55")]
		[FieldOffset(Offset = "0x118")]
		public UIButton EPQuestBtn;

		// Token: 0x0400CA56 RID: 51798
		[Token(Token = "0x400CA56")]
		[FieldOffset(Offset = "0x120")]
		public GameObject ChallengeTips;

		// Token: 0x0400CA57 RID: 51799
		[Token(Token = "0x400CA57")]
		[FieldOffset(Offset = "0x128")]
		public GameObject TipGetMore;

		// Token: 0x0400CA58 RID: 51800
		[Token(Token = "0x400CA58")]
		[FieldOffset(Offset = "0x130")]
		public UILabel TipNeedBadgeCnt;

		// Token: 0x0400CA59 RID: 51801
		[Token(Token = "0x400CA59")]
		[FieldOffset(Offset = "0x138")]
		public UIButton TipNeedBadgeBtn;

		// Token: 0x0400CA5A RID: 51802
		[Token(Token = "0x400CA5A")]
		[FieldOffset(Offset = "0x140")]
		public UIButton GetMoreBtn;

		// Token: 0x0400CA5B RID: 51803
		[Token(Token = "0x400CA5B")]
		[FieldOffset(Offset = "0x148")]
		public GameObject TipUpgrade;

		// Token: 0x0400CA5C RID: 51804
		[Token(Token = "0x400CA5C")]
		[FieldOffset(Offset = "0x150")]
		public UIButton TipUpgradeBtn;

		// Token: 0x0400CA5D RID: 51805
		[Token(Token = "0x400CA5D")]
		[FieldOffset(Offset = "0x158")]
		public UIButton UpgradeBtn;

		// Token: 0x0400CA5E RID: 51806
		[Token(Token = "0x400CA5E")]
		[FieldOffset(Offset = "0x160")]
		public UILabel SubscribeInfoLabel;

		// Token: 0x0400CA5F RID: 51807
		[Token(Token = "0x400CA5F")]
		[FieldOffset(Offset = "0x168")]
		public UIButton SubscribedInfoBtn;

		// Token: 0x0400CA60 RID: 51808
		[Token(Token = "0x400CA60")]
		[FieldOffset(Offset = "0x170")]
		public UICountDownLabel SubscribedCountDown;

		// Token: 0x0400CA61 RID: 51809
		[Token(Token = "0x400CA61")]
		[FieldOffset(Offset = "0x178")]
		public GameObject BottomNormal;

		// Token: 0x0400CA62 RID: 51810
		[Token(Token = "0x400CA62")]
		[FieldOffset(Offset = "0x180")]
		public UIButton UpgradeEPBtn2;

		// Token: 0x0400CA63 RID: 51811
		[Token(Token = "0x400CA63")]
		[FieldOffset(Offset = "0x188")]
		public UIButton BuyBadgeBtn2;

		// Token: 0x0400CA64 RID: 51812
		[Token(Token = "0x400CA64")]
		[FieldOffset(Offset = "0x190")]
		public UIButton EPQuestBtn2;

		// Token: 0x0400CA65 RID: 51813
		[Token(Token = "0x400CA65")]
		[FieldOffset(Offset = "0x198")]
		public GameObject ChallengeTips2;

		// Token: 0x0400CA66 RID: 51814
		[Token(Token = "0x400CA66")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject TipGetMore2;

		// Token: 0x0400CA67 RID: 51815
		[Token(Token = "0x400CA67")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel TipNeedBadgeCnt2;

		// Token: 0x0400CA68 RID: 51816
		[Token(Token = "0x400CA68")]
		[FieldOffset(Offset = "0x1B0")]
		public UIButton TipNeedBadgeBtn2;

		// Token: 0x0400CA69 RID: 51817
		[Token(Token = "0x400CA69")]
		[FieldOffset(Offset = "0x1B8")]
		public UIButton GetMoreBtn2;

		// Token: 0x0400CA6A RID: 51818
		[Token(Token = "0x400CA6A")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject TipUpgrade2;

		// Token: 0x0400CA6B RID: 51819
		[Token(Token = "0x400CA6B")]
		[FieldOffset(Offset = "0x1C8")]
		public UIButton TipUpgradeBtn2;

		// Token: 0x0400CA6C RID: 51820
		[Token(Token = "0x400CA6C")]
		[FieldOffset(Offset = "0x1D0")]
		public UIButton UpgradeBtn2;

		// Token: 0x0400CA6D RID: 51821
		[Token(Token = "0x400CA6D")]
		[FieldOffset(Offset = "0x1D8")]
		public UIButton BadgeRankingButton;

		// Token: 0x0400CA6E RID: 51822
		[Token(Token = "0x400CA6E")]
		[FieldOffset(Offset = "0x1E0")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400CA6F RID: 51823
		[Token(Token = "0x400CA6F")]
		[FieldOffset(Offset = "0x1E8")]
		public UIButton Video_play;

		// Token: 0x0400CA70 RID: 51824
		[Token(Token = "0x400CA70")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject NewEffect;

		// Token: 0x0400CA71 RID: 51825
		[Token(Token = "0x400CA71")]
		[FieldOffset(Offset = "0x1F8")]
		public UINetworkTexture CDNTheme;

		// Token: 0x0400CA72 RID: 51826
		[Token(Token = "0x400CA72")]
		[FieldOffset(Offset = "0x200")]
		public UIButton WebsiteButton;

		// Token: 0x0400CA73 RID: 51827
		[Token(Token = "0x400CA73")]
		[FieldOffset(Offset = "0x208")]
		public GameObject Anim;

		// Token: 0x0400CA74 RID: 51828
		[Token(Token = "0x400CA74")]
		[FieldOffset(Offset = "0x210")]
		public UIButton AnimPlayBtn;

		// Token: 0x0400CA75 RID: 51829
		[Token(Token = "0x400CA75")]
		[FieldOffset(Offset = "0x218")]
		public UIButton DocumentButton;

		// Token: 0x0400CA76 RID: 51830
		[Token(Token = "0x400CA76")]
		[FieldOffset(Offset = "0x220")]
		public UIWidget PreviewRightContainer;

		// Token: 0x0400CA77 RID: 51831
		[Token(Token = "0x400CA77")]
		[FieldOffset(Offset = "0x228")]
		public UIWidget PreviewLeftContainer;

		// Token: 0x0400CA78 RID: 51832
		[Token(Token = "0x400CA78")]
		[FieldOffset(Offset = "0x230")]
		public Transform LeftPosition;
	}
}
