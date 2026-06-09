using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002130 RID: 8496
	[Token(Token = "0x2002130")]
	internal class UIChampionshipGameStatsView : UIBaseView
	{
		// Token: 0x0600BD70 RID: 48496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD70")]
		[Address(RVA = "0x1C36CF8", Offset = "0x1C36CF8", VA = "0x7BBC436CF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD71")]
		[Address(RVA = "0x1C3740C", Offset = "0x1C3740C", VA = "0x7BBC43740C")]
		public UIChampionshipGameStatsView()
		{
		}

		// Token: 0x0400C364 RID: 50020
		[Token(Token = "0x400C364")]
		[FieldOffset(Offset = "0x20")]
		public UILabel SeasonLabel;

		// Token: 0x0400C365 RID: 50021
		[Token(Token = "0x400C365")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SeasonInfoLabel;

		// Token: 0x0400C366 RID: 50022
		[Token(Token = "0x400C366")]
		[FieldOffset(Offset = "0x30")]
		public UITable MatchStatsTable;

		// Token: 0x0400C367 RID: 50023
		[Token(Token = "0x400C367")]
		[FieldOffset(Offset = "0x38")]
		public UILabel mMatchCount;

		// Token: 0x0400C368 RID: 50024
		[Token(Token = "0x400C368")]
		[FieldOffset(Offset = "0x40")]
		public UILabel mMostRankPoint;

		// Token: 0x0400C369 RID: 50025
		[Token(Token = "0x400C369")]
		[FieldOffset(Offset = "0x48")]
		public UILabel mWins;

		// Token: 0x0400C36A RID: 50026
		[Token(Token = "0x400C36A")]
		[FieldOffset(Offset = "0x50")]
		public UILabel mTop10P;

		// Token: 0x0400C36B RID: 50027
		[Token(Token = "0x400C36B")]
		[FieldOffset(Offset = "0x58")]
		public UILabel mTop50P;

		// Token: 0x0400C36C RID: 50028
		[Token(Token = "0x400C36C")]
		[FieldOffset(Offset = "0x60")]
		public UILabel mSurvialTime;

		// Token: 0x0400C36D RID: 50029
		[Token(Token = "0x400C36D")]
		[FieldOffset(Offset = "0x68")]
		public UILabel mMoveDistance;

		// Token: 0x0400C36E RID: 50030
		[Token(Token = "0x400C36E")]
		[FieldOffset(Offset = "0x70")]
		public UITable BattleStatsTable;

		// Token: 0x0400C36F RID: 50031
		[Token(Token = "0x400C36F")]
		[FieldOffset(Offset = "0x78")]
		public UILabel bTotalKill;

		// Token: 0x0400C370 RID: 50032
		[Token(Token = "0x400C370")]
		[FieldOffset(Offset = "0x80")]
		public UILabel bAvgKill;

		// Token: 0x0400C371 RID: 50033
		[Token(Token = "0x400C371")]
		[FieldOffset(Offset = "0x88")]
		public UILabel bAvgDamage;

		// Token: 0x0400C372 RID: 50034
		[Token(Token = "0x400C372")]
		[FieldOffset(Offset = "0x90")]
		public UILabel bKD;

		// Token: 0x0400C373 RID: 50035
		[Token(Token = "0x400C373")]
		[FieldOffset(Offset = "0x98")]
		public UILabel bMostKill;

		// Token: 0x0400C374 RID: 50036
		[Token(Token = "0x400C374")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel bMostDamage;

		// Token: 0x0400C375 RID: 50037
		[Token(Token = "0x400C375")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel bHeadShot;

		// Token: 0x0400C376 RID: 50038
		[Token(Token = "0x400C376")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton ViewMatchHistoryBtn;

		// Token: 0x0400C377 RID: 50039
		[Token(Token = "0x400C377")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton ShareBtn;

		// Token: 0x0400C378 RID: 50040
		[Token(Token = "0x400C378")]
		[FieldOffset(Offset = "0xC0")]
		public Animator ShareIconAnimator;

		// Token: 0x0400C379 RID: 50041
		[Token(Token = "0x400C379")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite ScreenshotTopBanner;

		// Token: 0x0400C37A RID: 50042
		[Token(Token = "0x400C37A")]
		[FieldOffset(Offset = "0xD0")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400C37B RID: 50043
		[Token(Token = "0x400C37B")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject HeadshotDefault;

		// Token: 0x0400C37C RID: 50044
		[Token(Token = "0x400C37C")]
		[FieldOffset(Offset = "0xE0")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400C37D RID: 50045
		[Token(Token = "0x400C37D")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel PlayerNickname;

		// Token: 0x0400C37E RID: 50046
		[Token(Token = "0x400C37E")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel PlayerID;

		// Token: 0x0400C37F RID: 50047
		[Token(Token = "0x400C37F")]
		[FieldOffset(Offset = "0xF8")]
		public UISprite FreeFireLogo;

		// Token: 0x0400C380 RID: 50048
		[Token(Token = "0x400C380")]
		[FieldOffset(Offset = "0x100")]
		public Transform TeamOverview;
	}
}
