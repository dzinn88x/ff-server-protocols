using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002369 RID: 9065
	[Token(Token = "0x2002369")]
	public class UIHudSkySurfingView : UIBaseView
	{
		// Token: 0x0600C1E2 RID: 49634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E2")]
		[Address(RVA = "0x166C238", Offset = "0x166C238", VA = "0x7BBBE6C238", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1E3")]
		[Address(RVA = "0x166C3AC", Offset = "0x166C3AC", VA = "0x7BBBE6C3AC")]
		public UIHudSkySurfingView()
		{
		}

		// Token: 0x0400DBD3 RID: 56275
		[Token(Token = "0x400DBD3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnSkySurfing;

		// Token: 0x0400DBD4 RID: 56276
		[Token(Token = "0x400DBD4")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActionNameTxt;

		// Token: 0x0400DBD5 RID: 56277
		[Token(Token = "0x400DBD5")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BGSkySurfing;

		// Token: 0x0400DBD6 RID: 56278
		[Token(Token = "0x400DBD6")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SkySurfingIcon;
	}
}
