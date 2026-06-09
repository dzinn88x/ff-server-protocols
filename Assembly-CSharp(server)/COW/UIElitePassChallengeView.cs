using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B3 RID: 8627
	[Token(Token = "0x20021B3")]
	public class UIElitePassChallengeView : UIBaseView
	{
		// Token: 0x0600BE76 RID: 48758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE76")]
		[Address(RVA = "0x1AE60A4", Offset = "0x1AE60A4", VA = "0x7BBC2E60A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE77 RID: 48759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE77")]
		[Address(RVA = "0x1AE6AC4", Offset = "0x1AE6AC4", VA = "0x7BBC2E6AC4")]
		public UIElitePassChallengeView()
		{
		}

		// Token: 0x0400C9F9 RID: 51705
		[Token(Token = "0x400C9F9")]
		[FieldOffset(Offset = "0x20")]
		public Transform LeftTabContainer;

		// Token: 0x0400C9FA RID: 51706
		[Token(Token = "0x400C9FA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ElitePassUpgrade;

		// Token: 0x0400C9FB RID: 51707
		[Token(Token = "0x400C9FB")]
		[FieldOffset(Offset = "0x30")]
		public UILabel EPUnlockTips;

		// Token: 0x0400C9FC RID: 51708
		[Token(Token = "0x400C9FC")]
		[FieldOffset(Offset = "0x38")]
		public UIButton UpgradeBtn;

		// Token: 0x0400C9FD RID: 51709
		[Token(Token = "0x400C9FD")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton DailyQuestBtn;

		// Token: 0x0400C9FE RID: 51710
		[Token(Token = "0x400C9FE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DailyTipsIcon;

		// Token: 0x0400C9FF RID: 51711
		[Token(Token = "0x400C9FF")]
		[FieldOffset(Offset = "0x50")]
		public UIToggleButton EPQuestBtn;

		// Token: 0x0400CA00 RID: 51712
		[Token(Token = "0x400CA00")]
		[FieldOffset(Offset = "0x58")]
		public GameObject EPNormalObj;

		// Token: 0x0400CA01 RID: 51713
		[Token(Token = "0x400CA01")]
		[FieldOffset(Offset = "0x60")]
		public GameObject EPTipsIcon;

		// Token: 0x0400CA02 RID: 51714
		[Token(Token = "0x400CA02")]
		[FieldOffset(Offset = "0x68")]
		public UIButton EPLockIcon;

		// Token: 0x0400CA03 RID: 51715
		[Token(Token = "0x400CA03")]
		[FieldOffset(Offset = "0x70")]
		public GameObject EPLockedObj;

		// Token: 0x0400CA04 RID: 51716
		[Token(Token = "0x400CA04")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton FPQuestBtn;

		// Token: 0x0400CA05 RID: 51717
		[Token(Token = "0x400CA05")]
		[FieldOffset(Offset = "0x80")]
		public GameObject FPNormalObj;

		// Token: 0x0400CA06 RID: 51718
		[Token(Token = "0x400CA06")]
		[FieldOffset(Offset = "0x88")]
		public GameObject FPTipsIcon;

		// Token: 0x0400CA07 RID: 51719
		[Token(Token = "0x400CA07")]
		[FieldOffset(Offset = "0x90")]
		public UIButton FPLockIcon;

		// Token: 0x0400CA08 RID: 51720
		[Token(Token = "0x400CA08")]
		[FieldOffset(Offset = "0x98")]
		public GameObject FPLockedObj;

		// Token: 0x0400CA09 RID: 51721
		[Token(Token = "0x400CA09")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite BadgeIcon;

		// Token: 0x0400CA0A RID: 51722
		[Token(Token = "0x400CA0A")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel BadgeCountLabel;

		// Token: 0x0400CA0B RID: 51723
		[Token(Token = "0x400CA0B")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton ElitePassBtn;

		// Token: 0x0400CA0C RID: 51724
		[Token(Token = "0x400CA0C")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject Tips;

		// Token: 0x0400CA0D RID: 51725
		[Token(Token = "0x400CA0D")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel EPBtnTips;

		// Token: 0x0400CA0E RID: 51726
		[Token(Token = "0x400CA0E")]
		[FieldOffset(Offset = "0xC8")]
		public UIPanel BGPanel;

		// Token: 0x0400CA0F RID: 51727
		[Token(Token = "0x400CA0F")]
		[FieldOffset(Offset = "0xD0")]
		public UIScrollView ChallengeScrollView;

		// Token: 0x0400CA10 RID: 51728
		[Token(Token = "0x400CA10")]
		[FieldOffset(Offset = "0xD8")]
		public UIEasyList EasyList;

		// Token: 0x0400CA11 RID: 51729
		[Token(Token = "0x400CA11")]
		[FieldOffset(Offset = "0xE0")]
		public UIWidget SpecialChallengeContainerWidget;

		// Token: 0x0400CA12 RID: 51730
		[Token(Token = "0x400CA12")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject SpecialChallengeContainer;

		// Token: 0x0400CA13 RID: 51731
		[Token(Token = "0x400CA13")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject SpProgressBarContainer;

		// Token: 0x0400CA14 RID: 51732
		[Token(Token = "0x400CA14")]
		[FieldOffset(Offset = "0xF8")]
		public ElitePassSpecialChallengeView ProgressMark;

		// Token: 0x0400CA15 RID: 51733
		[Token(Token = "0x400CA15")]
		[FieldOffset(Offset = "0x100")]
		public UIButton ProgressHintButton;

		// Token: 0x0400CA16 RID: 51734
		[Token(Token = "0x400CA16")]
		[FieldOffset(Offset = "0x108")]
		public UIProgressBar SpProgressBarBg;

		// Token: 0x0400CA17 RID: 51735
		[Token(Token = "0x400CA17")]
		[FieldOffset(Offset = "0x110")]
		public UIButton HelpBtn;

		// Token: 0x0400CA18 RID: 51736
		[Token(Token = "0x400CA18")]
		[FieldOffset(Offset = "0x118")]
		public Transform CountDown;

		// Token: 0x0400CA19 RID: 51737
		[Token(Token = "0x400CA19")]
		[FieldOffset(Offset = "0x120")]
		public GameObject WeeklyContainer;

		// Token: 0x0400CA1A RID: 51738
		[Token(Token = "0x400CA1A")]
		[FieldOffset(Offset = "0x128")]
		public Transform AwardContainer;

		// Token: 0x0400CA1B RID: 51739
		[Token(Token = "0x400CA1B")]
		[FieldOffset(Offset = "0x130")]
		public UIProgressBar SpProgressBar;

		// Token: 0x0400CA1C RID: 51740
		[Token(Token = "0x400CA1C")]
		[FieldOffset(Offset = "0x138")]
		public UILabel CurrentWeekTaskFinisedCnt;

		// Token: 0x0400CA1D RID: 51741
		[Token(Token = "0x400CA1D")]
		[FieldOffset(Offset = "0x140")]
		public UIEPWeeklyRewardItemController WeeklyAwarditem;

		// Token: 0x0400CA1E RID: 51742
		[Token(Token = "0x400CA1E")]
		[FieldOffset(Offset = "0x148")]
		public GameObject MovingEffect;

		// Token: 0x0400CA1F RID: 51743
		[Token(Token = "0x400CA1F")]
		[FieldOffset(Offset = "0x150")]
		public UILabel WeekLabel;

		// Token: 0x0400CA20 RID: 51744
		[Token(Token = "0x400CA20")]
		[FieldOffset(Offset = "0x158")]
		public UILabel WeekLabel_Shadow;

		// Token: 0x0400CA21 RID: 51745
		[Token(Token = "0x400CA21")]
		[FieldOffset(Offset = "0x160")]
		public GameObject DailyContainer;

		// Token: 0x0400CA22 RID: 51746
		[Token(Token = "0x400CA22")]
		[FieldOffset(Offset = "0x168")]
		public UIButton ClaimAllBtn;
	}
}
