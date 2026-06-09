using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002237 RID: 8759
	[Token(Token = "0x2002237")]
	public class UIGameModeRankInfoView : UIBaseView
	{
		// Token: 0x0600BF7F RID: 49023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF7F")]
		[Address(RVA = "0x200B398", Offset = "0x200B398", VA = "0x7BBC80B398", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF80")]
		[Address(RVA = "0x200BA44", Offset = "0x200BA44", VA = "0x7BBC80BA44")]
		public UIGameModeRankInfoView()
		{
		}

		// Token: 0x0400D14E RID: 53582
		[Token(Token = "0x400D14E")]
		[FieldOffset(Offset = "0x20")]
		public UISprite bg;

		// Token: 0x0400D14F RID: 53583
		[Token(Token = "0x400D14F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton HelperBtn;

		// Token: 0x0400D150 RID: 53584
		[Token(Token = "0x400D150")]
		[FieldOffset(Offset = "0x30")]
		public GameObject HelperTipsContainer;

		// Token: 0x0400D151 RID: 53585
		[Token(Token = "0x400D151")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HelperTips;

		// Token: 0x0400D152 RID: 53586
		[Token(Token = "0x400D152")]
		[FieldOffset(Offset = "0x40")]
		public UIButton HelperMaskBtn;

		// Token: 0x0400D153 RID: 53587
		[Token(Token = "0x400D153")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NormalView;

		// Token: 0x0400D154 RID: 53588
		[Token(Token = "0x400D154")]
		[FieldOffset(Offset = "0x50")]
		public UILabel gameMode;

		// Token: 0x0400D155 RID: 53589
		[Token(Token = "0x400D155")]
		[FieldOffset(Offset = "0x58")]
		public UILabel mapMode;

		// Token: 0x0400D156 RID: 53590
		[Token(Token = "0x400D156")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BonusView;

		// Token: 0x0400D157 RID: 53591
		[Token(Token = "0x400D157")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BonusReward;

		// Token: 0x0400D158 RID: 53592
		[Token(Token = "0x400D158")]
		[FieldOffset(Offset = "0x70")]
		public UILabel ladderExtraBonusRateTxt;

		// Token: 0x0400D159 RID: 53593
		[Token(Token = "0x400D159")]
		[FieldOffset(Offset = "0x78")]
		public GameObject RP;

		// Token: 0x0400D15A RID: 53594
		[Token(Token = "0x400D15A")]
		[FieldOffset(Offset = "0x80")]
		public UILabel RPLabel;

		// Token: 0x0400D15B RID: 53595
		[Token(Token = "0x400D15B")]
		[FieldOffset(Offset = "0x88")]
		public UILabel BgameMode;

		// Token: 0x0400D15C RID: 53596
		[Token(Token = "0x400D15C")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BmapMode;

		// Token: 0x0400D15D RID: 53597
		[Token(Token = "0x400D15D")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ChampionshipBonusReward;

		// Token: 0x0400D15E RID: 53598
		[Token(Token = "0x400D15E")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel GoldBonusLabel;

		// Token: 0x0400D15F RID: 53599
		[Token(Token = "0x400D15F")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ExpBonusLabel;

		// Token: 0x0400D160 RID: 53600
		[Token(Token = "0x400D160")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton MapChangeButton;

		// Token: 0x0400D161 RID: 53601
		[Token(Token = "0x400D161")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton rankBtn;

		// Token: 0x0400D162 RID: 53602
		[Token(Token = "0x400D162")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel matchMode;

		// Token: 0x0400D163 RID: 53603
		[Token(Token = "0x400D163")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject NoDudectView;

		// Token: 0x0400D164 RID: 53604
		[Token(Token = "0x400D164")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject DoubleTokenView;

		// Token: 0x0400D165 RID: 53605
		[Token(Token = "0x400D165")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject DoublePointView;

		// Token: 0x0400D166 RID: 53606
		[Token(Token = "0x400D166")]
		[FieldOffset(Offset = "0xE0")]
		public Transform ladderMatchEntry;

		// Token: 0x0400D167 RID: 53607
		[Token(Token = "0x400D167")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject openTime;

		// Token: 0x0400D168 RID: 53608
		[Token(Token = "0x400D168")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel openPeriod;

		// Token: 0x0400D169 RID: 53609
		[Token(Token = "0x400D169")]
		[FieldOffset(Offset = "0xF8")]
		public UIWidget RankGuideInfo;
	}
}
