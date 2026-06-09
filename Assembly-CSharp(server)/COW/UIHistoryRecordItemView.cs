using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002255 RID: 8789
	[Token(Token = "0x2002255")]
	public class UIHistoryRecordItemView : UIBaseView
	{
		// Token: 0x0600BFBB RID: 49083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBB")]
		[Address(RVA = "0x1D5FD38", Offset = "0x1D5FD38", VA = "0x7BBC55FD38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBC")]
		[Address(RVA = "0x1D60334", Offset = "0x1D60334", VA = "0x7BBC560334")]
		public UIHistoryRecordItemView()
		{
		}

		// Token: 0x0400D302 RID: 54018
		[Token(Token = "0x400D302")]
		[FieldOffset(Offset = "0x20")]
		public UISprite ColorBg;

		// Token: 0x0400D303 RID: 54019
		[Token(Token = "0x400D303")]
		[FieldOffset(Offset = "0x28")]
		public UILabel GameModeLabel;

		// Token: 0x0400D304 RID: 54020
		[Token(Token = "0x400D304")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GroupHC1;

		// Token: 0x0400D305 RID: 54021
		[Token(Token = "0x400D305")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GroupHC2;

		// Token: 0x0400D306 RID: 54022
		[Token(Token = "0x400D306")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GroupHC3;

		// Token: 0x0400D307 RID: 54023
		[Token(Token = "0x400D307")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GroupHC4;

		// Token: 0x0400D308 RID: 54024
		[Token(Token = "0x400D308")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Kill;

		// Token: 0x0400D309 RID: 54025
		[Token(Token = "0x400D309")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PassTime;

		// Token: 0x0400D30A RID: 54026
		[Token(Token = "0x400D30A")]
		[FieldOffset(Offset = "0x60")]
		public Transform DeltaTr1;

		// Token: 0x0400D30B RID: 54027
		[Token(Token = "0x400D30B")]
		[FieldOffset(Offset = "0x68")]
		public Transform DeltaTr2;

		// Token: 0x0400D30C RID: 54028
		[Token(Token = "0x400D30C")]
		[FieldOffset(Offset = "0x70")]
		public Transform DeltaTr3;

		// Token: 0x0400D30D RID: 54029
		[Token(Token = "0x400D30D")]
		[FieldOffset(Offset = "0x78")]
		public UILabel HistoryDeltaRating;

		// Token: 0x0400D30E RID: 54030
		[Token(Token = "0x400D30E")]
		[FieldOffset(Offset = "0x80")]
		public UILabel HistoryRating;

		// Token: 0x0400D30F RID: 54031
		[Token(Token = "0x400D30F")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BRShow;

		// Token: 0x0400D310 RID: 54032
		[Token(Token = "0x400D310")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Rank;

		// Token: 0x0400D311 RID: 54033
		[Token(Token = "0x400D311")]
		[FieldOffset(Offset = "0x98")]
		public UILabel SpecialRank;

		// Token: 0x0400D312 RID: 54034
		[Token(Token = "0x400D312")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject WinSprite;

		// Token: 0x0400D313 RID: 54035
		[Token(Token = "0x400D313")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject LoseSprite;

		// Token: 0x0400D314 RID: 54036
		[Token(Token = "0x400D314")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject CSShow;

		// Token: 0x0400D315 RID: 54037
		[Token(Token = "0x400D315")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject CS_V;

		// Token: 0x0400D316 RID: 54038
		[Token(Token = "0x400D316")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel V;

		// Token: 0x0400D317 RID: 54039
		[Token(Token = "0x400D317")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject CS_F;

		// Token: 0x0400D318 RID: 54040
		[Token(Token = "0x400D318")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel F;

		// Token: 0x0400D319 RID: 54041
		[Token(Token = "0x400D319")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject SelectedHL;

		// Token: 0x0400D31A RID: 54042
		[Token(Token = "0x400D31A")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton ItemBtn;
	}
}
