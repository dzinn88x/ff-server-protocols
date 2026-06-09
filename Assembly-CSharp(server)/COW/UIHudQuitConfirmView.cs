using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200233F RID: 9023
	[Token(Token = "0x200233F")]
	internal class UIHudQuitConfirmView : UIBaseView
	{
		// Token: 0x0600C18E RID: 49550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18E")]
		[Address(RVA = "0x17E76CC", Offset = "0x17E76CC", VA = "0x7BBBFE76CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C18F")]
		[Address(RVA = "0x17E77BC", Offset = "0x17E77BC", VA = "0x7BBBFE77BC")]
		public UIHudQuitConfirmView()
		{
		}

		// Token: 0x0400DAAE RID: 55982
		[Token(Token = "0x400DAAE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCancel;

		// Token: 0x0400DAAF RID: 55983
		[Token(Token = "0x400DAAF")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnOK;
	}
}
