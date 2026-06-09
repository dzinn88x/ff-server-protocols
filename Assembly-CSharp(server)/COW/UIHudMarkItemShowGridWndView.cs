using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002304 RID: 8964
	[Token(Token = "0x2002304")]
	public class UIHudMarkItemShowGridWndView : UIBaseView
	{
		// Token: 0x0600C118 RID: 49432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C118")]
		[Address(RVA = "0x15BDD00", Offset = "0x15BDD00", VA = "0x7BBBDBDD00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C119 RID: 49433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C119")]
		[Address(RVA = "0x15BDDF0", Offset = "0x15BDDF0", VA = "0x7BBBDBDDF0")]
		public UIHudMarkItemShowGridWndView()
		{
		}

		// Token: 0x0400D84F RID: 55375
		[Token(Token = "0x400D84F")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid ItemGrid;

		// Token: 0x0400D850 RID: 55376
		[Token(Token = "0x400D850")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ItemViewClickMask;
	}
}
