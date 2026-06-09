using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200225C RID: 8796
	[Token(Token = "0x200225C")]
	public class UIHudADSpaceHintView : UIBaseView
	{
		// Token: 0x0600BFC9 RID: 49097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC9")]
		[Address(RVA = "0x1D64070", Offset = "0x1D64070", VA = "0x7BBC564070", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFCA")]
		[Address(RVA = "0x1D64520", Offset = "0x1D64520", VA = "0x7BBC564520")]
		public UIHudADSpaceHintView()
		{
		}

		// Token: 0x0400D33E RID: 54078
		[Token(Token = "0x400D33E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Enter1v1Warning;

		// Token: 0x0400D33F RID: 54079
		[Token(Token = "0x400D33F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Enter1v1Hint;

		// Token: 0x0400D340 RID: 54080
		[Token(Token = "0x400D340")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Avatar;

		// Token: 0x0400D341 RID: 54081
		[Token(Token = "0x400D341")]
		[FieldOffset(Offset = "0x38")]
		public UILabel HintLabel;

		// Token: 0x0400D342 RID: 54082
		[Token(Token = "0x400D342")]
		[FieldOffset(Offset = "0x40")]
		public GameObject End1v1TimeOut;

		// Token: 0x0400D343 RID: 54083
		[Token(Token = "0x400D343")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Start1v1Info;

		// Token: 0x0400D344 RID: 54084
		[Token(Token = "0x400D344")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Start1v1InfoIcon;

		// Token: 0x0400D345 RID: 54085
		[Token(Token = "0x400D345")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Start1v1InfoTitle;

		// Token: 0x0400D346 RID: 54086
		[Token(Token = "0x400D346")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Start1v1InfoInfo;

		// Token: 0x0400D347 RID: 54087
		[Token(Token = "0x400D347")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Win1V1Kill;

		// Token: 0x0400D348 RID: 54088
		[Token(Token = "0x400D348")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Win1v1;

		// Token: 0x0400D349 RID: 54089
		[Token(Token = "0x400D349")]
		[FieldOffset(Offset = "0x78")]
		public UISprite WinAvatar;

		// Token: 0x0400D34A RID: 54090
		[Token(Token = "0x400D34A")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Win1v1Label;

		// Token: 0x0400D34B RID: 54091
		[Token(Token = "0x400D34B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject SelfWinBg;

		// Token: 0x0400D34C RID: 54092
		[Token(Token = "0x400D34C")]
		[FieldOffset(Offset = "0x90")]
		public GameObject RivalWinBg;

		// Token: 0x0400D34D RID: 54093
		[Token(Token = "0x400D34D")]
		[FieldOffset(Offset = "0x98")]
		public GameObject Win1v1BonusScore;

		// Token: 0x0400D34E RID: 54094
		[Token(Token = "0x400D34E")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite TeamIcon;

		// Token: 0x0400D34F RID: 54095
		[Token(Token = "0x400D34F")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject SelfWinBgTeam;

		// Token: 0x0400D350 RID: 54096
		[Token(Token = "0x400D350")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject RivalWinBgTeam;
	}
}
