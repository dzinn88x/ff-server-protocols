using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002408 RID: 9224
	[Token(Token = "0x2002408")]
	public class UILoginQueueInfoPopupWndView : UIBaseView
	{
		// Token: 0x0600C320 RID: 49952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C320")]
		[Address(RVA = "0x19E8048", Offset = "0x19E8048", VA = "0x7BBC1E8048", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C321 RID: 49953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C321")]
		[Address(RVA = "0x19E81BC", Offset = "0x19E81BC", VA = "0x7BBC1E81BC")]
		public UILoginQueueInfoPopupWndView()
		{
		}

		// Token: 0x0400E35F RID: 58207
		[Token(Token = "0x400E35F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel QueuePos;

		// Token: 0x0400E360 RID: 58208
		[Token(Token = "0x400E360")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar Progress;

		// Token: 0x0400E361 RID: 58209
		[Token(Token = "0x400E361")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel CountDownLabel;

		// Token: 0x0400E362 RID: 58210
		[Token(Token = "0x400E362")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnClose;
	}
}
