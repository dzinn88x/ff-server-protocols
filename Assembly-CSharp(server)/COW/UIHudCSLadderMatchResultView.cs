using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A8 RID: 8872
	[Token(Token = "0x20022A8")]
	public class UIHudCSLadderMatchResultView : UIBaseView
	{
		// Token: 0x0600C061 RID: 49249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C061")]
		[Address(RVA = "0x19BCFA4", Offset = "0x19BCFA4", VA = "0x7BBC1BCFA4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C062 RID: 49250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C062")]
		[Address(RVA = "0x19BD54C", Offset = "0x19BD54C", VA = "0x7BBC1BD54C")]
		public UIHudCSLadderMatchResultView()
		{
		}

		// Token: 0x0400D50C RID: 54540
		[Token(Token = "0x400D50C")]
		[FieldOffset(Offset = "0x20")]
		public Animation HudCSLadderMatchResultAnim;

		// Token: 0x0400D50D RID: 54541
		[Token(Token = "0x400D50D")]
		[FieldOffset(Offset = "0x28")]
		public Animation RankInfoAnim;

		// Token: 0x0400D50E RID: 54542
		[Token(Token = "0x400D50E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite RankAfterSprite;

		// Token: 0x0400D50F RID: 54543
		[Token(Token = "0x400D50F")]
		[FieldOffset(Offset = "0x38")]
		public UITable RankAfterStarTable;

		// Token: 0x0400D510 RID: 54544
		[Token(Token = "0x400D510")]
		[FieldOffset(Offset = "0x40")]
		public Animation AfterLabelAnim;

		// Token: 0x0400D511 RID: 54545
		[Token(Token = "0x400D511")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CurRankCountLabel_2;

		// Token: 0x0400D512 RID: 54546
		[Token(Token = "0x400D512")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CurRankCountLabel;

		// Token: 0x0400D513 RID: 54547
		[Token(Token = "0x400D513")]
		[FieldOffset(Offset = "0x58")]
		public UILabel RankNameAfter;

		// Token: 0x0400D514 RID: 54548
		[Token(Token = "0x400D514")]
		[FieldOffset(Offset = "0x60")]
		public UISprite RankBeforeSprite;

		// Token: 0x0400D515 RID: 54549
		[Token(Token = "0x400D515")]
		[FieldOffset(Offset = "0x68")]
		public UITable RankBeforeStarTable;

		// Token: 0x0400D516 RID: 54550
		[Token(Token = "0x400D516")]
		[FieldOffset(Offset = "0x70")]
		public Animation BeforeLabelAnim;

		// Token: 0x0400D517 RID: 54551
		[Token(Token = "0x400D517")]
		[FieldOffset(Offset = "0x78")]
		public UILabel BeforeRankCountLabel;

		// Token: 0x0400D518 RID: 54552
		[Token(Token = "0x400D518")]
		[FieldOffset(Offset = "0x80")]
		public UILabel BeforeRankCountLabel_2;

		// Token: 0x0400D519 RID: 54553
		[Token(Token = "0x400D519")]
		[FieldOffset(Offset = "0x88")]
		public UILabel RankNameBefore;

		// Token: 0x0400D51A RID: 54554
		[Token(Token = "0x400D51A")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ScoreInfoContainer;

		// Token: 0x0400D51B RID: 54555
		[Token(Token = "0x400D51B")]
		[FieldOffset(Offset = "0x98")]
		public Animation ScoreInfoAnim;

		// Token: 0x0400D51C RID: 54556
		[Token(Token = "0x400D51C")]
		[FieldOffset(Offset = "0xA0")]
		public UITable ScoreTable;

		// Token: 0x0400D51D RID: 54557
		[Token(Token = "0x400D51D")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ScoreInfo1;

		// Token: 0x0400D51E RID: 54558
		[Token(Token = "0x400D51E")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel ScoreInfo2;

		// Token: 0x0400D51F RID: 54559
		[Token(Token = "0x400D51F")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ProtectContent;

		// Token: 0x0400D520 RID: 54560
		[Token(Token = "0x400D520")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel ProtectLabel;

		// Token: 0x0400D521 RID: 54561
		[Token(Token = "0x400D521")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton BackMaskBtn;

		// Token: 0x0400D522 RID: 54562
		[Token(Token = "0x400D522")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject RankStar;
	}
}
