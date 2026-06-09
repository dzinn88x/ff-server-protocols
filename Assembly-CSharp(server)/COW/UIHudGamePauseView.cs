using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D5 RID: 8917
	[Token(Token = "0x20022D5")]
	internal class UIHudGamePauseView : UIBaseView
	{
		// Token: 0x0600C0BA RID: 49338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BA")]
		[Address(RVA = "0x1C133B8", Offset = "0x1C133B8", VA = "0x7BBC4133B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0BB")]
		[Address(RVA = "0x1C134D0", Offset = "0x1C134D0", VA = "0x7BBC4134D0")]
		public UIHudGamePauseView()
		{
		}

		// Token: 0x0400D6B6 RID: 54966
		[Token(Token = "0x400D6B6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PauseIcon;

		// Token: 0x0400D6B7 RID: 54967
		[Token(Token = "0x400D6B7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountDownTxt;

		// Token: 0x0400D6B8 RID: 54968
		[Token(Token = "0x400D6B8")]
		[FieldOffset(Offset = "0x30")]
		public UILabel InfoTxt;
	}
}
