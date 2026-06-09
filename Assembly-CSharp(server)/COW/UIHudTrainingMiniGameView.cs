using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002388 RID: 9096
	[Token(Token = "0x2002388")]
	public class UIHudTrainingMiniGameView : UIBaseView
	{
		// Token: 0x0600C220 RID: 49696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C220")]
		[Address(RVA = "0x15E823C", Offset = "0x15E823C", VA = "0x7BBBDE823C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C221 RID: 49697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C221")]
		[Address(RVA = "0x15E8C64", Offset = "0x15E8C64", VA = "0x7BBBDE8C64")]
		public UIHudTrainingMiniGameView()
		{
		}

		// Token: 0x0400DCC5 RID: 56517
		[Token(Token = "0x400DCC5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject MiniGameMap;

		// Token: 0x0400DCC6 RID: 56518
		[Token(Token = "0x400DCC6")]
		[FieldOffset(Offset = "0x28")]
		public Transform CountDown;

		// Token: 0x0400DCC7 RID: 56519
		[Token(Token = "0x400DCC7")]
		[FieldOffset(Offset = "0x30")]
		public UILabel labelTips;

		// Token: 0x0400DCC8 RID: 56520
		[Token(Token = "0x400DCC8")]
		[FieldOffset(Offset = "0x38")]
		public UIWidget labelbgwidget;

		// Token: 0x0400DCC9 RID: 56521
		[Token(Token = "0x400DCC9")]
		[FieldOffset(Offset = "0x40")]
		public UISprite warningIcon;

		// Token: 0x0400DCCA RID: 56522
		[Token(Token = "0x400DCCA")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget warningwidget;

		// Token: 0x0400DCCB RID: 56523
		[Token(Token = "0x400DCCB")]
		[FieldOffset(Offset = "0x50")]
		public UILabel timeCount;

		// Token: 0x0400DCCC RID: 56524
		[Token(Token = "0x400DCCC")]
		[FieldOffset(Offset = "0x58")]
		public TweenAlpha TweenAlpha;

		// Token: 0x0400DCCD RID: 56525
		[Token(Token = "0x400DCCD")]
		[FieldOffset(Offset = "0x60")]
		public Transform ScoreInfo;

		// Token: 0x0400DCCE RID: 56526
		[Token(Token = "0x400DCCE")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Score;

		// Token: 0x0400DCCF RID: 56527
		[Token(Token = "0x400DCCF")]
		[FieldOffset(Offset = "0x70")]
		public UILabel PopScore;

		// Token: 0x0400DCD0 RID: 56528
		[Token(Token = "0x400DCD0")]
		[FieldOffset(Offset = "0x78")]
		public Animation AddScoreAnim;

		// Token: 0x0400DCD1 RID: 56529
		[Token(Token = "0x400DCD1")]
		[FieldOffset(Offset = "0x80")]
		public GameObject PreCountDown;

		// Token: 0x0400DCD2 RID: 56530
		[Token(Token = "0x400DCD2")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PreCountNum;

		// Token: 0x0400DCD3 RID: 56531
		[Token(Token = "0x400DCD3")]
		[FieldOffset(Offset = "0x90")]
		public UIButton QuitGameBtn;

		// Token: 0x0400DCD4 RID: 56532
		[Token(Token = "0x400DCD4")]
		[FieldOffset(Offset = "0x98")]
		public Transform Victory;

		// Token: 0x0400DCD5 RID: 56533
		[Token(Token = "0x400DCD5")]
		[FieldOffset(Offset = "0xA0")]
		public TweenScale VictoryTween;

		// Token: 0x0400DCD6 RID: 56534
		[Token(Token = "0x400DCD6")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel VictoryTxt;

		// Token: 0x0400DCD7 RID: 56535
		[Token(Token = "0x400DCD7")]
		[FieldOffset(Offset = "0xB0")]
		public Transform Defeat;

		// Token: 0x0400DCD8 RID: 56536
		[Token(Token = "0x400DCD8")]
		[FieldOffset(Offset = "0xB8")]
		public TweenScale DefeatTween;

		// Token: 0x0400DCD9 RID: 56537
		[Token(Token = "0x400DCD9")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel DefeatTxt;

		// Token: 0x0400DCDA RID: 56538
		[Token(Token = "0x400DCDA")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject End;

		// Token: 0x0400DCDB RID: 56539
		[Token(Token = "0x400DCDB")]
		[FieldOffset(Offset = "0xD0")]
		public Transform Btns;

		// Token: 0x0400DCDC RID: 56540
		[Token(Token = "0x400DCDC")]
		[FieldOffset(Offset = "0xD8")]
		public UIGrid Grid;

		// Token: 0x0400DCDD RID: 56541
		[Token(Token = "0x400DCDD")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton ShareBtn;

		// Token: 0x0400DCDE RID: 56542
		[Token(Token = "0x400DCDE")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton BackBtn;

		// Token: 0x0400DCDF RID: 56543
		[Token(Token = "0x400DCDF")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel LabelBack;

		// Token: 0x0400DCE0 RID: 56544
		[Token(Token = "0x400DCE0")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton PlayAgain;

		// Token: 0x0400DCE1 RID: 56545
		[Token(Token = "0x400DCE1")]
		[FieldOffset(Offset = "0x100")]
		public UIButton SkipMask;

		// Token: 0x0400DCE2 RID: 56546
		[Token(Token = "0x400DCE2")]
		[FieldOffset(Offset = "0x108")]
		public GameObject Result;

		// Token: 0x0400DCE3 RID: 56547
		[Token(Token = "0x400DCE3")]
		[FieldOffset(Offset = "0x110")]
		public UILabel ResultSummary;

		// Token: 0x0400DCE4 RID: 56548
		[Token(Token = "0x400DCE4")]
		[FieldOffset(Offset = "0x118")]
		public UILabel ResultTitle1;

		// Token: 0x0400DCE5 RID: 56549
		[Token(Token = "0x400DCE5")]
		[FieldOffset(Offset = "0x120")]
		public UILabel EndLeftTimeLabel;

		// Token: 0x0400DCE6 RID: 56550
		[Token(Token = "0x400DCE6")]
		[FieldOffset(Offset = "0x128")]
		public UILabel ResultTitle2;

		// Token: 0x0400DCE7 RID: 56551
		[Token(Token = "0x400DCE7")]
		[FieldOffset(Offset = "0x130")]
		public UILabel HeadShotCntLabel;

		// Token: 0x0400DCE8 RID: 56552
		[Token(Token = "0x400DCE8")]
		[FieldOffset(Offset = "0x138")]
		public UILabel ResultTitle3;

		// Token: 0x0400DCE9 RID: 56553
		[Token(Token = "0x400DCE9")]
		[FieldOffset(Offset = "0x140")]
		public UILabel KillLabel;

		// Token: 0x0400DCEA RID: 56554
		[Token(Token = "0x400DCEA")]
		[FieldOffset(Offset = "0x148")]
		public UILabel ResultTitle4;

		// Token: 0x0400DCEB RID: 56555
		[Token(Token = "0x400DCEB")]
		[FieldOffset(Offset = "0x150")]
		public UILabel EndScoreLabel;

		// Token: 0x0400DCEC RID: 56556
		[Token(Token = "0x400DCEC")]
		[FieldOffset(Offset = "0x158")]
		public GameObject Reward;

		// Token: 0x0400DCED RID: 56557
		[Token(Token = "0x400DCED")]
		[FieldOffset(Offset = "0x160")]
		public UISprite ItemIcon;

		// Token: 0x0400DCEE RID: 56558
		[Token(Token = "0x400DCEE")]
		[FieldOffset(Offset = "0x168")]
		public UILabel ItemNum;
	}
}
