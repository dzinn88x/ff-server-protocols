using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FB RID: 8955
	[Token(Token = "0x20022FB")]
	public class UIHudLadderMatchResultView : UIBaseView
	{
		// Token: 0x0600C106 RID: 49414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C106")]
		[Address(RVA = "0x15B7778", Offset = "0x15B7778", VA = "0x7BBBDB7778", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C107 RID: 49415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C107")]
		[Address(RVA = "0x15B8014", Offset = "0x15B8014", VA = "0x7BBBDB8014")]
		public UIHudLadderMatchResultView()
		{
		}

		// Token: 0x0400D7FC RID: 55292
		[Token(Token = "0x400D7FC")]
		[FieldOffset(Offset = "0x20")]
		public Animation HudLadderMatchResultAnim;

		// Token: 0x0400D7FD RID: 55293
		[Token(Token = "0x400D7FD")]
		[FieldOffset(Offset = "0x28")]
		public Animation LadderRankInfoAnim;

		// Token: 0x0400D7FE RID: 55294
		[Token(Token = "0x400D7FE")]
		[FieldOffset(Offset = "0x30")]
		public UISprite RankAfterSprite;

		// Token: 0x0400D7FF RID: 55295
		[Token(Token = "0x400D7FF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RankNameAfter;

		// Token: 0x0400D800 RID: 55296
		[Token(Token = "0x400D800")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HeroicLevelAfterContainer;

		// Token: 0x0400D801 RID: 55297
		[Token(Token = "0x400D801")]
		[FieldOffset(Offset = "0x48")]
		public GameObject AfterStar1;

		// Token: 0x0400D802 RID: 55298
		[Token(Token = "0x400D802")]
		[FieldOffset(Offset = "0x50")]
		public GameObject AfterStar2;

		// Token: 0x0400D803 RID: 55299
		[Token(Token = "0x400D803")]
		[FieldOffset(Offset = "0x58")]
		public GameObject AfterStar3;

		// Token: 0x0400D804 RID: 55300
		[Token(Token = "0x400D804")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AfterStar4;

		// Token: 0x0400D805 RID: 55301
		[Token(Token = "0x400D805")]
		[FieldOffset(Offset = "0x68")]
		public GameObject AfterStar5;

		// Token: 0x0400D806 RID: 55302
		[Token(Token = "0x400D806")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RankBeforeSprite;

		// Token: 0x0400D807 RID: 55303
		[Token(Token = "0x400D807")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RankNameBefore;

		// Token: 0x0400D808 RID: 55304
		[Token(Token = "0x400D808")]
		[FieldOffset(Offset = "0x80")]
		public GameObject HeroicLevelBeforeContainer;

		// Token: 0x0400D809 RID: 55305
		[Token(Token = "0x400D809")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BeforeStar1;

		// Token: 0x0400D80A RID: 55306
		[Token(Token = "0x400D80A")]
		[FieldOffset(Offset = "0x90")]
		public GameObject BeforeStar2;

		// Token: 0x0400D80B RID: 55307
		[Token(Token = "0x400D80B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject BeforeStar3;

		// Token: 0x0400D80C RID: 55308
		[Token(Token = "0x400D80C")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject BeforeStar4;

		// Token: 0x0400D80D RID: 55309
		[Token(Token = "0x400D80D")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject BeforeStar5;

		// Token: 0x0400D80E RID: 55310
		[Token(Token = "0x400D80E")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Shine;

		// Token: 0x0400D80F RID: 55311
		[Token(Token = "0x400D80F")]
		[FieldOffset(Offset = "0xB8")]
		public UIProgressBar ProgressBar;

		// Token: 0x0400D810 RID: 55312
		[Token(Token = "0x400D810")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel CurScoreTxt;

		// Token: 0x0400D811 RID: 55313
		[Token(Token = "0x400D811")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel AddScoreTxt;

		// Token: 0x0400D812 RID: 55314
		[Token(Token = "0x400D812")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel ResultBonousInfoTxt;

		// Token: 0x0400D813 RID: 55315
		[Token(Token = "0x400D813")]
		[FieldOffset(Offset = "0xD8")]
		public UITable ScoreInfoTable;

		// Token: 0x0400D814 RID: 55316
		[Token(Token = "0x400D814")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject ScoreFirstWinOB;

		// Token: 0x0400D815 RID: 55317
		[Token(Token = "0x400D815")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel FirstWinAddTxt;

		// Token: 0x0400D816 RID: 55318
		[Token(Token = "0x400D816")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject ScoreRankScOB;

		// Token: 0x0400D817 RID: 55319
		[Token(Token = "0x400D817")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel RankScAddTxt;

		// Token: 0x0400D818 RID: 55320
		[Token(Token = "0x400D818")]
		[FieldOffset(Offset = "0x100")]
		public GameObject ScoreBattleScOB;

		// Token: 0x0400D819 RID: 55321
		[Token(Token = "0x400D819")]
		[FieldOffset(Offset = "0x108")]
		public UILabel BattleScAddTxt;

		// Token: 0x0400D81A RID: 55322
		[Token(Token = "0x400D81A")]
		[FieldOffset(Offset = "0x110")]
		public GameObject ScoreMapScOB;

		// Token: 0x0400D81B RID: 55323
		[Token(Token = "0x400D81B")]
		[FieldOffset(Offset = "0x118")]
		public UILabel MapScAddTxt;

		// Token: 0x0400D81C RID: 55324
		[Token(Token = "0x400D81C")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TokeInfoOB;

		// Token: 0x0400D81D RID: 55325
		[Token(Token = "0x400D81D")]
		[FieldOffset(Offset = "0x128")]
		public UILabel SurvivalTimeTxt;

		// Token: 0x0400D81E RID: 55326
		[Token(Token = "0x400D81E")]
		[FieldOffset(Offset = "0x130")]
		public UILabel TokenTxt;

		// Token: 0x0400D81F RID: 55327
		[Token(Token = "0x400D81F")]
		[FieldOffset(Offset = "0x138")]
		public UIButton TokenDetailBtn;

		// Token: 0x0400D820 RID: 55328
		[Token(Token = "0x400D820")]
		[FieldOffset(Offset = "0x140")]
		public UIButton BackMaskBtn;
	}
}
