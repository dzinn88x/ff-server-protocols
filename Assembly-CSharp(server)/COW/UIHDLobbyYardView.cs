using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002253 RID: 8787
	[Token(Token = "0x2002253")]
	public class UIHDLobbyYardView : UIBaseView
	{
		// Token: 0x0600BFB7 RID: 49079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB7")]
		[Address(RVA = "0x16AF428", Offset = "0x16AF428", VA = "0x7BBBEAF428", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB8")]
		[Address(RVA = "0x16AF5B4", Offset = "0x16AF5B4", VA = "0x7BBBEAF5B4")]
		public UIHDLobbyYardView()
		{
		}

		// Token: 0x0400D2F6 RID: 54006
		[Token(Token = "0x400D2F6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NaviPage;

		// Token: 0x0400D2F7 RID: 54007
		[Token(Token = "0x400D2F7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton HelpBtn;

		// Token: 0x0400D2F8 RID: 54008
		[Token(Token = "0x400D2F8")]
		[FieldOffset(Offset = "0x30")]
		public UIButton leaveBtn;

		// Token: 0x0400D2F9 RID: 54009
		[Token(Token = "0x400D2F9")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ShareButton;

		// Token: 0x0400D2FA RID: 54010
		[Token(Token = "0x400D2FA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Mask;
	}
}
