using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002250 RID: 8784
	[Token(Token = "0x2002250")]
	internal class UIGuildSignInView : UIBaseView
	{
		// Token: 0x0600BFB1 RID: 49073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB1")]
		[Address(RVA = "0x16AD734", Offset = "0x16AD734", VA = "0x7BBBEAD734", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB2")]
		[Address(RVA = "0x16AD9C0", Offset = "0x16AD9C0", VA = "0x7BBBEAD9C0")]
		public UIGuildSignInView()
		{
		}

		// Token: 0x0400D2E8 RID: 53992
		[Token(Token = "0x400D2E8")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400D2E9 RID: 53993
		[Token(Token = "0x400D2E9")]
		[FieldOffset(Offset = "0x28")]
		public UISprite CurClanIcon;

		// Token: 0x0400D2EA RID: 53994
		[Token(Token = "0x400D2EA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel CurLevelLabel;

		// Token: 0x0400D2EB RID: 53995
		[Token(Token = "0x400D2EB")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid TopPivot;

		// Token: 0x0400D2EC RID: 53996
		[Token(Token = "0x400D2EC")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid BottomPivot;

		// Token: 0x0400D2ED RID: 53997
		[Token(Token = "0x400D2ED")]
		[FieldOffset(Offset = "0x48")]
		public UISprite NextClanIcon;

		// Token: 0x0400D2EE RID: 53998
		[Token(Token = "0x400D2EE")]
		[FieldOffset(Offset = "0x50")]
		public UIButton NextClanBtn;

		// Token: 0x0400D2EF RID: 53999
		[Token(Token = "0x400D2EF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel NextLevelLabel;

		// Token: 0x0400D2F0 RID: 54000
		[Token(Token = "0x400D2F0")]
		[FieldOffset(Offset = "0x60")]
		public UILabel NextPageLabel;
	}
}
