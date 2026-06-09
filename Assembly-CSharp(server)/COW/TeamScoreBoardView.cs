using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CF RID: 8399
	[Token(Token = "0x20020CF")]
	public class TeamScoreBoardView : UIBaseView
	{
		// Token: 0x0600BCAF RID: 48303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAF")]
		[Address(RVA = "0x1B460A0", Offset = "0x1B460A0", VA = "0x7BBC3460A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCB0 RID: 48304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB0")]
		[Address(RVA = "0x1B46728", Offset = "0x1B46728", VA = "0x7BBC346728")]
		public TeamScoreBoardView()
		{
		}

		// Token: 0x0400BE40 RID: 48704
		[Token(Token = "0x400BE40")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LeftTeamScore;

		// Token: 0x0400BE41 RID: 48705
		[Token(Token = "0x400BE41")]
		[FieldOffset(Offset = "0x28")]
		public UISprite LeftScoreBackIcon;

		// Token: 0x0400BE42 RID: 48706
		[Token(Token = "0x400BE42")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LeftTeamDefaultIconOB;

		// Token: 0x0400BE43 RID: 48707
		[Token(Token = "0x400BE43")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LeftTeamDefaultIcon;

		// Token: 0x0400BE44 RID: 48708
		[Token(Token = "0x400BE44")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LeftTeamIcon;

		// Token: 0x0400BE45 RID: 48709
		[Token(Token = "0x400BE45")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LeftTeamName;

		// Token: 0x0400BE46 RID: 48710
		[Token(Token = "0x400BE46")]
		[FieldOffset(Offset = "0x50")]
		public UISprite LeftCustomIcon;

		// Token: 0x0400BE47 RID: 48711
		[Token(Token = "0x400BE47")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LeftTeammateInfoTitle;

		// Token: 0x0400BE48 RID: 48712
		[Token(Token = "0x400BE48")]
		[FieldOffset(Offset = "0x60")]
		public UIHudTeamBattleScoreTitle TeamScoreTitleLeft;

		// Token: 0x0400BE49 RID: 48713
		[Token(Token = "0x400BE49")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LeftTitleInfo1Txt;

		// Token: 0x0400BE4A RID: 48714
		[Token(Token = "0x400BE4A")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LeftTitleInfo2Txt;

		// Token: 0x0400BE4B RID: 48715
		[Token(Token = "0x400BE4B")]
		[FieldOffset(Offset = "0x78")]
		public UILabel LeftTitleInfo3Txt;

		// Token: 0x0400BE4C RID: 48716
		[Token(Token = "0x400BE4C")]
		[FieldOffset(Offset = "0x80")]
		public UIGrid LeftTeammateGrid;

		// Token: 0x0400BE4D RID: 48717
		[Token(Token = "0x400BE4D")]
		[FieldOffset(Offset = "0x88")]
		public UILabel RightTeamScore;

		// Token: 0x0400BE4E RID: 48718
		[Token(Token = "0x400BE4E")]
		[FieldOffset(Offset = "0x90")]
		public UISprite RightScoreBackIcon;

		// Token: 0x0400BE4F RID: 48719
		[Token(Token = "0x400BE4F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject RightTeamDefaultIconOB;

		// Token: 0x0400BE50 RID: 48720
		[Token(Token = "0x400BE50")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject RightTeamDefaultIcon;

		// Token: 0x0400BE51 RID: 48721
		[Token(Token = "0x400BE51")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite RightTeamIcon;

		// Token: 0x0400BE52 RID: 48722
		[Token(Token = "0x400BE52")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel RightTeamName;

		// Token: 0x0400BE53 RID: 48723
		[Token(Token = "0x400BE53")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite RightCustomIcon;

		// Token: 0x0400BE54 RID: 48724
		[Token(Token = "0x400BE54")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject RightTeammateInfoTitle;

		// Token: 0x0400BE55 RID: 48725
		[Token(Token = "0x400BE55")]
		[FieldOffset(Offset = "0xC8")]
		public UIHudTeamBattleScoreTitle TeamScoreTitleRight;

		// Token: 0x0400BE56 RID: 48726
		[Token(Token = "0x400BE56")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel RightTitleInfo1Txt;

		// Token: 0x0400BE57 RID: 48727
		[Token(Token = "0x400BE57")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel RightTitleInfo2Txt;

		// Token: 0x0400BE58 RID: 48728
		[Token(Token = "0x400BE58")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel RightTitleInfo3Txt;

		// Token: 0x0400BE59 RID: 48729
		[Token(Token = "0x400BE59")]
		[FieldOffset(Offset = "0xE8")]
		public UIGrid RightTeammateGrid;

		// Token: 0x0400BE5A RID: 48730
		[Token(Token = "0x400BE5A")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BackMask;
	}
}
