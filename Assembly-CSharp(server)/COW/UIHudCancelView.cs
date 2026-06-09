using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200228E RID: 8846
	[Token(Token = "0x200228E")]
	internal class UIHudCancelView : UIBaseView
	{
		// Token: 0x0600C02D RID: 49197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02D")]
		[Address(RVA = "0x19D0F60", Offset = "0x19D0F60", VA = "0x7BBC1D0F60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C02E")]
		[Address(RVA = "0x19D0FFC", Offset = "0x19D0FFC", VA = "0x7BBC1D0FFC")]
		public UIHudCancelView()
		{
		}

		// Token: 0x0400D45F RID: 54367
		[Token(Token = "0x400D45F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCancel;
	}
}
