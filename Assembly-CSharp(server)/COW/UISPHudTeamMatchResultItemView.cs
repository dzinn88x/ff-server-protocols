using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200253F RID: 9535
	[Token(Token = "0x200253F")]
	internal class UISPHudTeamMatchResultItemView : UIBaseView
	{
		// Token: 0x0600C58E RID: 50574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58E")]
		[Address(RVA = "0x1EF8E58", Offset = "0x1EF8E58", VA = "0x7BBC6F8E58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C58F RID: 50575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C58F")]
		[Address(RVA = "0x1EF9118", Offset = "0x1EF9118", VA = "0x7BBC6F9118")]
		public UISPHudTeamMatchResultItemView()
		{
		}

		// Token: 0x0400F3E1 RID: 62433
		[Token(Token = "0x400F3E1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400F3E2 RID: 62434
		[Token(Token = "0x400F3E2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite RankIcon;

		// Token: 0x0400F3E3 RID: 62435
		[Token(Token = "0x400F3E3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel RankTxt;

		// Token: 0x0400F3E4 RID: 62436
		[Token(Token = "0x400F3E4")]
		[FieldOffset(Offset = "0x38")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F3E5 RID: 62437
		[Token(Token = "0x400F3E5")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F3E6 RID: 62438
		[Token(Token = "0x400F3E6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TeamTxt;

		// Token: 0x0400F3E7 RID: 62439
		[Token(Token = "0x400F3E7")]
		[FieldOffset(Offset = "0x50")]
		public UILabel KillTxt;

		// Token: 0x0400F3E8 RID: 62440
		[Token(Token = "0x400F3E8")]
		[FieldOffset(Offset = "0x58")]
		public UILabel RankScoreTxt;

		// Token: 0x0400F3E9 RID: 62441
		[Token(Token = "0x400F3E9")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TotalScoreTxt;

		// Token: 0x0400F3EA RID: 62442
		[Token(Token = "0x400F3EA")]
		[FieldOffset(Offset = "0x68")]
		public UISprite HighlightBg;
	}
}
