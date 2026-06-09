using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253E RID: 9534
	[Token(Token = "0x200253E")]
	public class UISPHudTeamBattleMatchResultView : UIBaseView
	{
		// Token: 0x0600C58C RID: 50572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58C")]
		[Address(RVA = "0x1EF65F8", Offset = "0x1EF65F8", VA = "0x7BBC6F65F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C58D RID: 50573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58D")]
		[Address(RVA = "0x1EF7098", Offset = "0x1EF7098", VA = "0x7BBC6F7098")]
		public UISPHudTeamBattleMatchResultView()
		{
		}

		// Token: 0x0400F3B3 RID: 62387
		[Token(Token = "0x400F3B3")]
		[FieldOffset(Offset = "0x20")]
		public Animator HudTeamBattleAni;

		// Token: 0x0400F3B4 RID: 62388
		[Token(Token = "0x400F3B4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject MaskBG;

		// Token: 0x0400F3B5 RID: 62389
		[Token(Token = "0x400F3B5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ResultDesc;

		// Token: 0x0400F3B6 RID: 62390
		[Token(Token = "0x400F3B6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GameModeTxt;

		// Token: 0x0400F3B7 RID: 62391
		[Token(Token = "0x400F3B7")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GameMapTxt;

		// Token: 0x0400F3B8 RID: 62392
		[Token(Token = "0x400F3B8")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Victory;

		// Token: 0x0400F3B9 RID: 62393
		[Token(Token = "0x400F3B9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WinTeamInfoOB;

		// Token: 0x0400F3BA RID: 62394
		[Token(Token = "0x400F3BA")]
		[FieldOffset(Offset = "0x58")]
		public UILabel WinTeamName;

		// Token: 0x0400F3BB RID: 62395
		[Token(Token = "0x400F3BB")]
		[FieldOffset(Offset = "0x60")]
		public UISprite WinTeamIcon;

		// Token: 0x0400F3BC RID: 62396
		[Token(Token = "0x400F3BC")]
		[FieldOffset(Offset = "0x68")]
		public GameObject DetailInfoUI;

		// Token: 0x0400F3BD RID: 62397
		[Token(Token = "0x400F3BD")]
		[FieldOffset(Offset = "0x70")]
		public UISprite LeftTeamScoreBG;

		// Token: 0x0400F3BE RID: 62398
		[Token(Token = "0x400F3BE")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LeftTeamScore;

		// Token: 0x0400F3BF RID: 62399
		[Token(Token = "0x400F3BF")]
		[FieldOffset(Offset = "0x80")]
		public GameObject LeftTeamDividingLine;

		// Token: 0x0400F3C0 RID: 62400
		[Token(Token = "0x400F3C0")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LeftTeamDefaultIconOB;

		// Token: 0x0400F3C1 RID: 62401
		[Token(Token = "0x400F3C1")]
		[FieldOffset(Offset = "0x90")]
		public GameObject LeftTeamDefaultIcon;

		// Token: 0x0400F3C2 RID: 62402
		[Token(Token = "0x400F3C2")]
		[FieldOffset(Offset = "0x98")]
		public UISprite LeftTeamIcon;

		// Token: 0x0400F3C3 RID: 62403
		[Token(Token = "0x400F3C3")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LeftTeamName;

		// Token: 0x0400F3C4 RID: 62404
		[Token(Token = "0x400F3C4")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite LeftTeamCustomIcon;

		// Token: 0x0400F3C5 RID: 62405
		[Token(Token = "0x400F3C5")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LeftTitleInfo1Txt;

		// Token: 0x0400F3C6 RID: 62406
		[Token(Token = "0x400F3C6")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel LeftTitleInfo2Txt;

		// Token: 0x0400F3C7 RID: 62407
		[Token(Token = "0x400F3C7")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel LeftTitleInfo3Txt;

		// Token: 0x0400F3C8 RID: 62408
		[Token(Token = "0x400F3C8")]
		[FieldOffset(Offset = "0xC8")]
		public Transform LeftTeammate1;

		// Token: 0x0400F3C9 RID: 62409
		[Token(Token = "0x400F3C9")]
		[FieldOffset(Offset = "0xD0")]
		public Transform LeftTeammate2;

		// Token: 0x0400F3CA RID: 62410
		[Token(Token = "0x400F3CA")]
		[FieldOffset(Offset = "0xD8")]
		public Transform LeftTeammate3;

		// Token: 0x0400F3CB RID: 62411
		[Token(Token = "0x400F3CB")]
		[FieldOffset(Offset = "0xE0")]
		public Transform LeftTeammate4;

		// Token: 0x0400F3CC RID: 62412
		[Token(Token = "0x400F3CC")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite RightTeamScoreBG;

		// Token: 0x0400F3CD RID: 62413
		[Token(Token = "0x400F3CD")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel RightTeamScore;

		// Token: 0x0400F3CE RID: 62414
		[Token(Token = "0x400F3CE")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject RightTeamDividingLine;

		// Token: 0x0400F3CF RID: 62415
		[Token(Token = "0x400F3CF")]
		[FieldOffset(Offset = "0x100")]
		public GameObject RightTeamDefaultIconOB;

		// Token: 0x0400F3D0 RID: 62416
		[Token(Token = "0x400F3D0")]
		[FieldOffset(Offset = "0x108")]
		public GameObject RightTeamDefaultIcon;

		// Token: 0x0400F3D1 RID: 62417
		[Token(Token = "0x400F3D1")]
		[FieldOffset(Offset = "0x110")]
		public UISprite RightTeamIcon;

		// Token: 0x0400F3D2 RID: 62418
		[Token(Token = "0x400F3D2")]
		[FieldOffset(Offset = "0x118")]
		public UILabel RightTeamName;

		// Token: 0x0400F3D3 RID: 62419
		[Token(Token = "0x400F3D3")]
		[FieldOffset(Offset = "0x120")]
		public UISprite RightTeamCustomIcon;

		// Token: 0x0400F3D4 RID: 62420
		[Token(Token = "0x400F3D4")]
		[FieldOffset(Offset = "0x128")]
		public UILabel RightTitleInfo1Txt;

		// Token: 0x0400F3D5 RID: 62421
		[Token(Token = "0x400F3D5")]
		[FieldOffset(Offset = "0x130")]
		public UILabel RightTitleInfo2Txt;

		// Token: 0x0400F3D6 RID: 62422
		[Token(Token = "0x400F3D6")]
		[FieldOffset(Offset = "0x138")]
		public UILabel RightTitleInfo3Txt;

		// Token: 0x0400F3D7 RID: 62423
		[Token(Token = "0x400F3D7")]
		[FieldOffset(Offset = "0x140")]
		public Transform RightTeammate1;

		// Token: 0x0400F3D8 RID: 62424
		[Token(Token = "0x400F3D8")]
		[FieldOffset(Offset = "0x148")]
		public Transform RightTeammate2;

		// Token: 0x0400F3D9 RID: 62425
		[Token(Token = "0x400F3D9")]
		[FieldOffset(Offset = "0x150")]
		public Transform RightTeammate3;

		// Token: 0x0400F3DA RID: 62426
		[Token(Token = "0x400F3DA")]
		[FieldOffset(Offset = "0x158")]
		public Transform RightTeammate4;

		// Token: 0x0400F3DB RID: 62427
		[Token(Token = "0x400F3DB")]
		[FieldOffset(Offset = "0x160")]
		public UIButton DetailsBtn;

		// Token: 0x0400F3DC RID: 62428
		[Token(Token = "0x400F3DC")]
		[FieldOffset(Offset = "0x168")]
		public GameObject DetailBtnShowIcon;

		// Token: 0x0400F3DD RID: 62429
		[Token(Token = "0x400F3DD")]
		[FieldOffset(Offset = "0x170")]
		public GameObject DetailBtnHideIcon;

		// Token: 0x0400F3DE RID: 62430
		[Token(Token = "0x400F3DE")]
		[FieldOffset(Offset = "0x178")]
		public UIButton NextBtn;

		// Token: 0x0400F3DF RID: 62431
		[Token(Token = "0x400F3DF")]
		[FieldOffset(Offset = "0x180")]
		public UILabel NextBtnLable;

		// Token: 0x0400F3E0 RID: 62432
		[Token(Token = "0x400F3E0")]
		[FieldOffset(Offset = "0x188")]
		public Transform CallSignContainer;
	}
}
