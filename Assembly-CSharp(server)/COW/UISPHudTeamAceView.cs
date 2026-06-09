using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253C RID: 9532
	[Token(Token = "0x200253C")]
	public class UISPHudTeamAceView : UIBaseView
	{
		// Token: 0x0600C588 RID: 50568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C588")]
		[Address(RVA = "0x1EF5FE0", Offset = "0x1EF5FE0", VA = "0x7BBC6F5FE0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C589 RID: 50569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C589")]
		[Address(RVA = "0x1EF62E0", Offset = "0x1EF62E0", VA = "0x7BBC6F62E0")]
		public UISPHudTeamAceView()
		{
		}

		// Token: 0x0400F39D RID: 62365
		[Token(Token = "0x400F39D")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha TKTweenAlpha;

		// Token: 0x0400F39E RID: 62366
		[Token(Token = "0x400F39E")]
		[FieldOffset(Offset = "0x28")]
		public TweenPosition TKTweenPosition;

		// Token: 0x0400F39F RID: 62367
		[Token(Token = "0x400F39F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;

		// Token: 0x0400F3A0 RID: 62368
		[Token(Token = "0x400F3A0")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamIcon;

		// Token: 0x0400F3A1 RID: 62369
		[Token(Token = "0x400F3A1")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F3A2 RID: 62370
		[Token(Token = "0x400F3A2")]
		[FieldOffset(Offset = "0x48")]
		public UISprite TeamColor;

		// Token: 0x0400F3A3 RID: 62371
		[Token(Token = "0x400F3A3")]
		[FieldOffset(Offset = "0x50")]
		public UILabel TeamKillTxt;

		// Token: 0x0400F3A4 RID: 62372
		[Token(Token = "0x400F3A4")]
		[FieldOffset(Offset = "0x58")]
		public UIEffectSprite FlagIcon;

		// Token: 0x0400F3A5 RID: 62373
		[Token(Token = "0x400F3A5")]
		[FieldOffset(Offset = "0x60")]
		public UISprite BockenIcon;

		// Token: 0x0400F3A6 RID: 62374
		[Token(Token = "0x400F3A6")]
		[FieldOffset(Offset = "0x68")]
		public UILabel BockenTxt;

		// Token: 0x0400F3A7 RID: 62375
		[Token(Token = "0x400F3A7")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SelfRank;
	}
}
