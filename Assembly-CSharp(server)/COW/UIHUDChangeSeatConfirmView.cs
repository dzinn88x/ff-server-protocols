using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002295 RID: 8853
	[Token(Token = "0x2002295")]
	public class UIHUDChangeSeatConfirmView : UIBaseView
	{
		// Token: 0x0600C03B RID: 49211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03B")]
		[Address(RVA = "0x16B7A58", Offset = "0x16B7A58", VA = "0x7BBBEB7A58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C03C RID: 49212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C03C")]
		[Address(RVA = "0x16B7B48", Offset = "0x16B7B48", VA = "0x7BBBEB7B48")]
		public UIHUDChangeSeatConfirmView()
		{
		}

		// Token: 0x0400D481 RID: 54401
		[Token(Token = "0x400D481")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TipLabel;

		// Token: 0x0400D482 RID: 54402
		[Token(Token = "0x400D482")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;
	}
}
