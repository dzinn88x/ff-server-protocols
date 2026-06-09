using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002301 RID: 8961
	[Token(Token = "0x2002301")]
	internal class UIHudLockedWarningView : UIBaseView
	{
		// Token: 0x0600C112 RID: 49426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C112")]
		[Address(RVA = "0x15BBE8C", Offset = "0x15BBE8C", VA = "0x7BBBDBBE8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C113 RID: 49427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C113")]
		[Address(RVA = "0x15BBF28", Offset = "0x15BBF28", VA = "0x7BBBDBBF28")]
		public UIHudLockedWarningView()
		{
		}

		// Token: 0x0400D845 RID: 55365
		[Token(Token = "0x400D845")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Message;
	}
}
