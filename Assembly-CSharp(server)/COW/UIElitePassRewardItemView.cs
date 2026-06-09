using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021BC RID: 8636
	[Token(Token = "0x20021BC")]
	public class UIElitePassRewardItemView : UIBaseView
	{
		// Token: 0x0600BE88 RID: 48776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE88")]
		[Address(RVA = "0x1E6E288", Offset = "0x1E6E288", VA = "0x7BBC66E288", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE89")]
		[Address(RVA = "0x1E6F004", Offset = "0x1E6F004", VA = "0x7BBC66F004")]
		public UIElitePassRewardItemView()
		{
		}

		// Token: 0x0400CA8A RID: 51850
		[Token(Token = "0x400CA8A")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale AnimAlpha;

		// Token: 0x0400CA8B RID: 51851
		[Token(Token = "0x400CA8B")]
		[FieldOffset(Offset = "0x28")]
		public TweenScale AnimScale;

		// Token: 0x0400CA8C RID: 51852
		[Token(Token = "0x400CA8C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton FPContainer;

		// Token: 0x0400CA8D RID: 51853
		[Token(Token = "0x400CA8D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FPRewardContainer;

		// Token: 0x0400CA8E RID: 51854
		[Token(Token = "0x400CA8E")]
		[FieldOffset(Offset = "0x40")]
		public BaseItemView FPItemView;

		// Token: 0x0400CA8F RID: 51855
		[Token(Token = "0x400CA8F")]
		[FieldOffset(Offset = "0x48")]
		public UIButton FPGetBtn;

		// Token: 0x0400CA90 RID: 51856
		[Token(Token = "0x400CA90")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FPLockIcon;

		// Token: 0x0400CA91 RID: 51857
		[Token(Token = "0x400CA91")]
		[FieldOffset(Offset = "0x58")]
		public GameObject FPTipsIcon;

		// Token: 0x0400CA92 RID: 51858
		[Token(Token = "0x400CA92")]
		[FieldOffset(Offset = "0x60")]
		public GameObject FPAchievedIcon;

		// Token: 0x0400CA93 RID: 51859
		[Token(Token = "0x400CA93")]
		[FieldOffset(Offset = "0x68")]
		public UISprite FPQuality;

		// Token: 0x0400CA94 RID: 51860
		[Token(Token = "0x400CA94")]
		[FieldOffset(Offset = "0x70")]
		public UISprite FPBgQuality;

		// Token: 0x0400CA95 RID: 51861
		[Token(Token = "0x400CA95")]
		[FieldOffset(Offset = "0x78")]
		public GameObject FPHL;

		// Token: 0x0400CA96 RID: 51862
		[Token(Token = "0x400CA96")]
		[FieldOffset(Offset = "0x80")]
		public GameObject FPBg;

		// Token: 0x0400CA97 RID: 51863
		[Token(Token = "0x400CA97")]
		[FieldOffset(Offset = "0x88")]
		public UIButton EPContainer;

		// Token: 0x0400CA98 RID: 51864
		[Token(Token = "0x400CA98")]
		[FieldOffset(Offset = "0x90")]
		public GameObject EPRewardContainer;

		// Token: 0x0400CA99 RID: 51865
		[Token(Token = "0x400CA99")]
		[FieldOffset(Offset = "0x98")]
		public BaseItemView EPItemView;

		// Token: 0x0400CA9A RID: 51866
		[Token(Token = "0x400CA9A")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject EPGetSprite;

		// Token: 0x0400CA9B RID: 51867
		[Token(Token = "0x400CA9B")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton EPGetBtn;

		// Token: 0x0400CA9C RID: 51868
		[Token(Token = "0x400CA9C")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject EPHL;

		// Token: 0x0400CA9D RID: 51869
		[Token(Token = "0x400CA9D")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject EPLockIcon;

		// Token: 0x0400CA9E RID: 51870
		[Token(Token = "0x400CA9E")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject EPTipsIcon;

		// Token: 0x0400CA9F RID: 51871
		[Token(Token = "0x400CA9F")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject EPAchievedIcon;

		// Token: 0x0400CAA0 RID: 51872
		[Token(Token = "0x400CAA0")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite EPQuality;

		// Token: 0x0400CAA1 RID: 51873
		[Token(Token = "0x400CAA1")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite EPBgQuality;

		// Token: 0x0400CAA2 RID: 51874
		[Token(Token = "0x400CAA2")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject EPBg;

		// Token: 0x0400CAA3 RID: 51875
		[Token(Token = "0x400CAA3")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject BigAwardEffect;

		// Token: 0x0400CAA4 RID: 51876
		[Token(Token = "0x400CAA4")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject ExclusiveAwardEffect;

		// Token: 0x0400CAA5 RID: 51877
		[Token(Token = "0x400CAA5")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject EPLockedBg;

		// Token: 0x0400CAA6 RID: 51878
		[Token(Token = "0x400CAA6")]
		[FieldOffset(Offset = "0x100")]
		public UIButton ExtraAwardContainer;

		// Token: 0x0400CAA7 RID: 51879
		[Token(Token = "0x400CAA7")]
		[FieldOffset(Offset = "0x108")]
		public GameObject EPExtraRewardContainer;

		// Token: 0x0400CAA8 RID: 51880
		[Token(Token = "0x400CAA8")]
		[FieldOffset(Offset = "0x110")]
		public BaseItemView EPExtraItemView;

		// Token: 0x0400CAA9 RID: 51881
		[Token(Token = "0x400CAA9")]
		[FieldOffset(Offset = "0x118")]
		public UIButton EPExtraGetBtn;

		// Token: 0x0400CAAA RID: 51882
		[Token(Token = "0x400CAAA")]
		[FieldOffset(Offset = "0x120")]
		public UIButton EPGetAllExtraBtn;

		// Token: 0x0400CAAB RID: 51883
		[Token(Token = "0x400CAAB")]
		[FieldOffset(Offset = "0x128")]
		public GameObject EPExtraTipsIcon;

		// Token: 0x0400CAAC RID: 51884
		[Token(Token = "0x400CAAC")]
		[FieldOffset(Offset = "0x130")]
		public GameObject MaxRewardToClaimNum;

		// Token: 0x0400CAAD RID: 51885
		[Token(Token = "0x400CAAD")]
		[FieldOffset(Offset = "0x138")]
		public UILabel MaxRewardToClaimNumLabel;

		// Token: 0x0400CAAE RID: 51886
		[Token(Token = "0x400CAAE")]
		[FieldOffset(Offset = "0x140")]
		public GameObject EPExtraBg;

		// Token: 0x0400CAAF RID: 51887
		[Token(Token = "0x400CAAF")]
		[FieldOffset(Offset = "0x148")]
		public GameObject Left;

		// Token: 0x0400CAB0 RID: 51888
		[Token(Token = "0x400CAB0")]
		[FieldOffset(Offset = "0x150")]
		public GameObject Right;

		// Token: 0x0400CAB1 RID: 51889
		[Token(Token = "0x400CAB1")]
		[FieldOffset(Offset = "0x158")]
		public GameObject EPExtraHint;

		// Token: 0x0400CAB2 RID: 51890
		[Token(Token = "0x400CAB2")]
		[FieldOffset(Offset = "0x160")]
		public UILabel NextAwardLabel;

		// Token: 0x0400CAB3 RID: 51891
		[Token(Token = "0x400CAB3")]
		[FieldOffset(Offset = "0x168")]
		public UILabel CurrentAwardUnlockedLabel;

		// Token: 0x0400CAB4 RID: 51892
		[Token(Token = "0x400CAB4")]
		[FieldOffset(Offset = "0x170")]
		public UIButton HelpBtn;

		// Token: 0x0400CAB5 RID: 51893
		[Token(Token = "0x400CAB5")]
		[FieldOffset(Offset = "0x178")]
		public GameObject BadgeProgress;

		// Token: 0x0400CAB6 RID: 51894
		[Token(Token = "0x400CAB6")]
		[FieldOffset(Offset = "0x180")]
		public UIButton BigBadgeDot;

		// Token: 0x0400CAB7 RID: 51895
		[Token(Token = "0x400CAB7")]
		[FieldOffset(Offset = "0x188")]
		public UISprite BadgeIcon;

		// Token: 0x0400CAB8 RID: 51896
		[Token(Token = "0x400CAB8")]
		[FieldOffset(Offset = "0x190")]
		public UILabel BadgeCountLabel;

		// Token: 0x0400CAB9 RID: 51897
		[Token(Token = "0x400CAB9")]
		[FieldOffset(Offset = "0x198")]
		public GameObject HighlightDot;

		// Token: 0x0400CABA RID: 51898
		[Token(Token = "0x400CABA")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject BigDotGrey;

		// Token: 0x0400CABB RID: 51899
		[Token(Token = "0x400CABB")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject SmallBadgeDot1;

		// Token: 0x0400CABC RID: 51900
		[Token(Token = "0x400CABC")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject SmallDotGrey1;

		// Token: 0x0400CABD RID: 51901
		[Token(Token = "0x400CABD")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject SmallBadgeDot2;

		// Token: 0x0400CABE RID: 51902
		[Token(Token = "0x400CABE")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject SmallDotGrey2;

		// Token: 0x0400CABF RID: 51903
		[Token(Token = "0x400CABF")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject SmallBadgeDot3;

		// Token: 0x0400CAC0 RID: 51904
		[Token(Token = "0x400CAC0")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject SmallDotGrey3;

		// Token: 0x0400CAC1 RID: 51905
		[Token(Token = "0x400CAC1")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject SmallBadgeDot4;

		// Token: 0x0400CAC2 RID: 51906
		[Token(Token = "0x400CAC2")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject SmallDotGrey4;

		// Token: 0x0400CAC3 RID: 51907
		[Token(Token = "0x400CAC3")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject BadgeProgressExtra;

		// Token: 0x0400CAC4 RID: 51908
		[Token(Token = "0x400CAC4")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject BadgeProgressExtraUnlokced;

		// Token: 0x0400CAC5 RID: 51909
		[Token(Token = "0x400CAC5")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject BadgeProgressExtraLocked;
	}
}
