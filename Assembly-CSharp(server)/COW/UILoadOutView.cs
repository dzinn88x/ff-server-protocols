using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F1 RID: 9201
	[Token(Token = "0x20023F1")]
	public class UILoadOutView : UIBaseView
	{
		// Token: 0x0600C2F2 RID: 49906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F2")]
		[Address(RVA = "0x1CC87B0", Offset = "0x1CC87B0", VA = "0x7BBC4C87B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2F3 RID: 49907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F3")]
		[Address(RVA = "0x1CC88D0", Offset = "0x1CC88D0", VA = "0x7BBC4C88D0")]
		public UILoadOutView()
		{
		}

		// Token: 0x0400E13D RID: 57661
		[Token(Token = "0x400E13D")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid GridOld;

		// Token: 0x0400E13E RID: 57662
		[Token(Token = "0x400E13E")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid GridNew;

		// Token: 0x0400E13F RID: 57663
		[Token(Token = "0x400E13F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ConfirmBtn;
	}
}
