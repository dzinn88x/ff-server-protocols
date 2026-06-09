using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200210E RID: 8462
	[Token(Token = "0x200210E")]
	internal class UIAvatarSuitListView : UIBaseView
	{
		// Token: 0x0600BD2D RID: 48429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2D")]
		[Address(RVA = "0x1E52B64", Offset = "0x1E52B64", VA = "0x7BBC652B64", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD2E RID: 48430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD2E")]
		[Address(RVA = "0x1E52C54", Offset = "0x1E52C54", VA = "0x7BBC652C54")]
		public UIAvatarSuitListView()
		{
		}

		// Token: 0x0400C1AA RID: 49578
		[Token(Token = "0x400C1AA")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList SuitList;

		// Token: 0x0400C1AB RID: 49579
		[Token(Token = "0x400C1AB")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ResetButton;
	}
}
