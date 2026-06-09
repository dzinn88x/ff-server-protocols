using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F9 RID: 9209
	[Token(Token = "0x20023F9")]
	internal class UILobbyIAPBundleView : UIBaseView
	{
		// Token: 0x0600C302 RID: 49922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C302")]
		[Address(RVA = "0x15398A0", Offset = "0x15398A0", VA = "0x7BBBD398A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C303")]
		[Address(RVA = "0x15399C0", Offset = "0x15399C0", VA = "0x7BBBD399C0")]
		public UILobbyIAPBundleView()
		{
		}

		// Token: 0x0400E1C8 RID: 57800
		[Token(Token = "0x400E1C8")]
		[FieldOffset(Offset = "0x20")]
		public UIButton IAPBundleButton;

		// Token: 0x0400E1C9 RID: 57801
		[Token(Token = "0x400E1C9")]
		[FieldOffset(Offset = "0x28")]
		public UICountDownLabel CountdownLabel;

		// Token: 0x0400E1CA RID: 57802
		[Token(Token = "0x400E1CA")]
		[FieldOffset(Offset = "0x30")]
		public UISprite IconSprite;
	}
}
