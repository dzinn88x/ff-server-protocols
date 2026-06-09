using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002306 RID: 8966
	[Token(Token = "0x2002306")]
	public class UIHudMatchEndShowTimeView : UIBaseView
	{
		// Token: 0x0600C11C RID: 49436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11C")]
		[Address(RVA = "0x15BF900", Offset = "0x15BF900", VA = "0x7BBBDBF900", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C11D RID: 49437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C11D")]
		[Address(RVA = "0x15BFCE8", Offset = "0x15BFCE8", VA = "0x7BBBDBFCE8")]
		public UIHudMatchEndShowTimeView()
		{
		}

		// Token: 0x0400D85D RID: 55389
		[Token(Token = "0x400D85D")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400D85E RID: 55390
		[Token(Token = "0x400D85E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ScoreContainer;

		// Token: 0x0400D85F RID: 55391
		[Token(Token = "0x400D85F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LeftTeamScoreBG;

		// Token: 0x0400D860 RID: 55392
		[Token(Token = "0x400D860")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LeftTeamScore;

		// Token: 0x0400D861 RID: 55393
		[Token(Token = "0x400D861")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LeftTeamIcon;

		// Token: 0x0400D862 RID: 55394
		[Token(Token = "0x400D862")]
		[FieldOffset(Offset = "0x48")]
		public UISprite RightTeamScoreBG;

		// Token: 0x0400D863 RID: 55395
		[Token(Token = "0x400D863")]
		[FieldOffset(Offset = "0x50")]
		public UILabel RightTeamScore;

		// Token: 0x0400D864 RID: 55396
		[Token(Token = "0x400D864")]
		[FieldOffset(Offset = "0x58")]
		public UISprite RightTeamIcon;

		// Token: 0x0400D865 RID: 55397
		[Token(Token = "0x400D865")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BooyahContainer;

		// Token: 0x0400D866 RID: 55398
		[Token(Token = "0x400D866")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BOOYAHSprite;

		// Token: 0x0400D867 RID: 55399
		[Token(Token = "0x400D867")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DefeatedContainer;

		// Token: 0x0400D868 RID: 55400
		[Token(Token = "0x400D868")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Lose;

		// Token: 0x0400D869 RID: 55401
		[Token(Token = "0x400D869")]
		[FieldOffset(Offset = "0x80")]
		public UIButton ShowResultBtn;

		// Token: 0x0400D86A RID: 55402
		[Token(Token = "0x400D86A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ShowResultLabel;

		// Token: 0x0400D86B RID: 55403
		[Token(Token = "0x400D86B")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Time;
	}
}
