using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C4 RID: 8388
	[Token(Token = "0x20020C4")]
	public class LadderMatchResultPopupView : UIBaseView
	{
		// Token: 0x0600BC99 RID: 48281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC99")]
		[Address(RVA = "0x13FB6FC", Offset = "0x13FB6FC", VA = "0x7BBBBFB6FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9A")]
		[Address(RVA = "0x13FBFA0", Offset = "0x13FBFA0", VA = "0x7BBBBFBFA0")]
		public LadderMatchResultPopupView()
		{
		}

		// Token: 0x0400BD7C RID: 48508
		[Token(Token = "0x400BD7C")]
		[FieldOffset(Offset = "0x20")]
		public Animator ViewAnimator;

		// Token: 0x0400BD7D RID: 48509
		[Token(Token = "0x400BD7D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BgClick;

		// Token: 0x0400BD7E RID: 48510
		[Token(Token = "0x400BD7E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject MaxLevel;

		// Token: 0x0400BD7F RID: 48511
		[Token(Token = "0x400BD7F")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnConfirm;

		// Token: 0x0400BD80 RID: 48512
		[Token(Token = "0x400BD80")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NextRankObject;

		// Token: 0x0400BD81 RID: 48513
		[Token(Token = "0x400BD81")]
		[FieldOffset(Offset = "0x48")]
		public UISprite NextRankIcon;

		// Token: 0x0400BD82 RID: 48514
		[Token(Token = "0x400BD82")]
		[FieldOffset(Offset = "0x50")]
		public UILabel NextLevelLabel;

		// Token: 0x0400BD83 RID: 48515
		[Token(Token = "0x400BD83")]
		[FieldOffset(Offset = "0x58")]
		public UISprite CurrentRankIcon;

		// Token: 0x0400BD84 RID: 48516
		[Token(Token = "0x400BD84")]
		[FieldOffset(Offset = "0x60")]
		public GameObject OldHeroicLevelContainer;

		// Token: 0x0400BD85 RID: 48517
		[Token(Token = "0x400BD85")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Oldstar;

		// Token: 0x0400BD86 RID: 48518
		[Token(Token = "0x400BD86")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Oldstar2;

		// Token: 0x0400BD87 RID: 48519
		[Token(Token = "0x400BD87")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Oldstar3;

		// Token: 0x0400BD88 RID: 48520
		[Token(Token = "0x400BD88")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Oldstar4;

		// Token: 0x0400BD89 RID: 48521
		[Token(Token = "0x400BD89")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Oldstar5;

		// Token: 0x0400BD8A RID: 48522
		[Token(Token = "0x400BD8A")]
		[FieldOffset(Offset = "0x90")]
		public UISprite NewRankIcon;

		// Token: 0x0400BD8B RID: 48523
		[Token(Token = "0x400BD8B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject NewHeroicLevelContainer;

		// Token: 0x0400BD8C RID: 48524
		[Token(Token = "0x400BD8C")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Newstar;

		// Token: 0x0400BD8D RID: 48525
		[Token(Token = "0x400BD8D")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Newstar2;

		// Token: 0x0400BD8E RID: 48526
		[Token(Token = "0x400BD8E")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Newstar3;

		// Token: 0x0400BD8F RID: 48527
		[Token(Token = "0x400BD8F")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject Newstar4;

		// Token: 0x0400BD90 RID: 48528
		[Token(Token = "0x400BD90")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject Newstar5;

		// Token: 0x0400BD91 RID: 48529
		[Token(Token = "0x400BD91")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel ResultBonousInfoTxt;

		// Token: 0x0400BD92 RID: 48530
		[Token(Token = "0x400BD92")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel FirstWinAdd;

		// Token: 0x0400BD93 RID: 48531
		[Token(Token = "0x400BD93")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel RankScAdd;

		// Token: 0x0400BD94 RID: 48532
		[Token(Token = "0x400BD94")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel BattleScAdd;

		// Token: 0x0400BD95 RID: 48533
		[Token(Token = "0x400BD95")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel MapScAdd;

		// Token: 0x0400BD96 RID: 48534
		[Token(Token = "0x400BD96")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel TotalScAdd;

		// Token: 0x0400BD97 RID: 48535
		[Token(Token = "0x400BD97")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel ServivedLabel;

		// Token: 0x0400BD98 RID: 48536
		[Token(Token = "0x400BD98")]
		[FieldOffset(Offset = "0x100")]
		public UILabel AddCoinLabel;

		// Token: 0x0400BD99 RID: 48537
		[Token(Token = "0x400BD99")]
		[FieldOffset(Offset = "0x108")]
		public UILabel addCoinDesc;

		// Token: 0x0400BD9A RID: 48538
		[Token(Token = "0x400BD9A")]
		[FieldOffset(Offset = "0x110")]
		public GameObject Shine;

		// Token: 0x0400BD9B RID: 48539
		[Token(Token = "0x400BD9B")]
		[FieldOffset(Offset = "0x118")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400BD9C RID: 48540
		[Token(Token = "0x400BD9C")]
		[FieldOffset(Offset = "0x120")]
		public UILabel StartValueLabel;

		// Token: 0x0400BD9D RID: 48541
		[Token(Token = "0x400BD9D")]
		[FieldOffset(Offset = "0x128")]
		public UILabel EndValueLabel;

		// Token: 0x0400BD9E RID: 48542
		[Token(Token = "0x400BD9E")]
		[FieldOffset(Offset = "0x130")]
		public UILabel DeltaValueLabel;

		// Token: 0x0400BD9F RID: 48543
		[Token(Token = "0x400BD9F")]
		[FieldOffset(Offset = "0x138")]
		public UILabel EndScoreLabel;

		// Token: 0x0400BDA0 RID: 48544
		[Token(Token = "0x400BDA0")]
		[FieldOffset(Offset = "0x140")]
		public UILabel CurLevelLabel;
	}
}
