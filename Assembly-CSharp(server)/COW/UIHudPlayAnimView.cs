using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232A RID: 9002
	[Token(Token = "0x200232A")]
	internal class UIHudPlayAnimView : UIBaseView
	{
		// Token: 0x0600C164 RID: 49508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C164")]
		[Address(RVA = "0x1D74F10", Offset = "0x1D74F10", VA = "0x7BBC574F10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C165")]
		[Address(RVA = "0x1D74FAC", Offset = "0x1D74FAC", VA = "0x7BBC574FAC")]
		public UIHudPlayAnimView()
		{
		}

		// Token: 0x0400DA3A RID: 55866
		[Token(Token = "0x400DA3A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCustomAnim;
	}
}
