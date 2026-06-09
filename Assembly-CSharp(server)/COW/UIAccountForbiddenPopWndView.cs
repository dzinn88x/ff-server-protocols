using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D4 RID: 8404
	[Token(Token = "0x20020D4")]
	public class UIAccountForbiddenPopWndView : UIBaseView
	{
		// Token: 0x0600BCB9 RID: 48313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB9")]
		[Address(RVA = "0x1A3B240", Offset = "0x1A3B240", VA = "0x7BBC23B240", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCBA RID: 48314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCBA")]
		[Address(RVA = "0x1A3B3A4", Offset = "0x1A3B3A4", VA = "0x7BBC23B3A4")]
		public UIAccountForbiddenPopWndView()
		{
		}

		// Token: 0x0400BE77 RID: 48759
		[Token(Token = "0x400BE77")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ForbiddenReasonTxt;

		// Token: 0x0400BE78 RID: 48760
		[Token(Token = "0x400BE78")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;

		// Token: 0x0400BE79 RID: 48761
		[Token(Token = "0x400BE79")]
		[FieldOffset(Offset = "0x30")]
		public UIButton HelpBtn;

		// Token: 0x0400BE7A RID: 48762
		[Token(Token = "0x400BE7A")]
		[FieldOffset(Offset = "0x38")]
		public Transform CountDownContainer;
	}
}
