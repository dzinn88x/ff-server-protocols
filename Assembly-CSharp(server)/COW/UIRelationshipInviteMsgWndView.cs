using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024D0 RID: 9424
	[Token(Token = "0x20024D0")]
	public class UIRelationshipInviteMsgWndView : UIBaseView
	{
		// Token: 0x0600C4B0 RID: 50352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B0")]
		[Address(RVA = "0x1E1DD68", Offset = "0x1E1DD68", VA = "0x7BBC61DD68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4B1 RID: 50353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4B1")]
		[Address(RVA = "0x1E1DE58", Offset = "0x1E1DE58", VA = "0x7BBC61DE58")]
		public UIRelationshipInviteMsgWndView()
		{
		}

		// Token: 0x0400EFBE RID: 61374
		[Token(Token = "0x400EFBE")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList msgGrid;

		// Token: 0x0400EFBF RID: 61375
		[Token(Token = "0x400EFBF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject NoneMsgLabel;
	}
}
