using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002500 RID: 9472
	[Token(Token = "0x2002500")]
	public class UISPHudConsoleView : UIBaseView
	{
		// Token: 0x0600C512 RID: 50450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C512")]
		[Address(RVA = "0x1EE6E10", Offset = "0x1EE6E10", VA = "0x7BBC6E6E10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C513")]
		[Address(RVA = "0x1EE6EAC", Offset = "0x1EE6EAC", VA = "0x7BBC6E6EAC")]
		public UISPHudConsoleView()
		{
		}

		// Token: 0x0400F164 RID: 61796
		[Token(Token = "0x400F164")]
		[FieldOffset(Offset = "0x20")]
		public UIInput Console;
	}
}
