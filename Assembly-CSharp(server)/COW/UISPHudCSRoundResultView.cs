using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002506 RID: 9478
	[Token(Token = "0x2002506")]
	public class UISPHudCSRoundResultView : UIBaseView
	{
		// Token: 0x0600C51E RID: 50462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51E")]
		[Address(RVA = "0x1EE352C", Offset = "0x1EE352C", VA = "0x7BBC6E352C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C51F RID: 50463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C51F")]
		[Address(RVA = "0x1EE3850", Offset = "0x1EE3850", VA = "0x7BBC6E3850")]
		public UISPHudCSRoundResultView()
		{
		}

		// Token: 0x0400F1C2 RID: 61890
		[Token(Token = "0x400F1C2")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TeamName;

		// Token: 0x0400F1C3 RID: 61891
		[Token(Token = "0x400F1C3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject winSprite;

		// Token: 0x0400F1C4 RID: 61892
		[Token(Token = "0x400F1C4")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WinSpriteLeft;

		// Token: 0x0400F1C5 RID: 61893
		[Token(Token = "0x400F1C5")]
		[FieldOffset(Offset = "0x38")]
		public UISprite WinSpriteRight;

		// Token: 0x0400F1C6 RID: 61894
		[Token(Token = "0x400F1C6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DefaultFaction_Right;

		// Token: 0x0400F1C7 RID: 61895
		[Token(Token = "0x400F1C7")]
		[FieldOffset(Offset = "0x48")]
		public UISprite wolf_R;

		// Token: 0x0400F1C8 RID: 61896
		[Token(Token = "0x400F1C8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RightTeam;

		// Token: 0x0400F1C9 RID: 61897
		[Token(Token = "0x400F1C9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject DefaultFaction_Left;

		// Token: 0x0400F1CA RID: 61898
		[Token(Token = "0x400F1CA")]
		[FieldOffset(Offset = "0x60")]
		public UISprite wolf_L;

		// Token: 0x0400F1CB RID: 61899
		[Token(Token = "0x400F1CB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LeftTeam;

		// Token: 0x0400F1CC RID: 61900
		[Token(Token = "0x400F1CC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject FactionIcon;

		// Token: 0x0400F1CD RID: 61901
		[Token(Token = "0x400F1CD")]
		[FieldOffset(Offset = "0x78")]
		public UISprite wolf;
	}
}
