using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219D RID: 8605
	[Token(Token = "0x200219D")]
	public class UIDebugConsoleToggleView : UIBaseView
	{
		// Token: 0x0600BE4A RID: 48714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4A")]
		[Address(RVA = "0x1BBA610", Offset = "0x1BBA610", VA = "0x7BBC3BA610", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4B")]
		[Address(RVA = "0x1BBA700", Offset = "0x1BBA700", VA = "0x7BBC3BA700")]
		public UIDebugConsoleToggleView()
		{
		}

		// Token: 0x0400C8C7 RID: 51399
		[Token(Token = "0x400C8C7")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle Toggle;

		// Token: 0x0400C8C8 RID: 51400
		[Token(Token = "0x400C8C8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel name;
	}
}
