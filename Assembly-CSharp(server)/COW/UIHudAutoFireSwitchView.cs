using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002270 RID: 8816
	[Token(Token = "0x2002270")]
	internal class UIHudAutoFireSwitchView : UIBaseView
	{
		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF1")]
		[Address(RVA = "0x1888D74", Offset = "0x1888D74", VA = "0x7BBC088D74", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF2")]
		[Address(RVA = "0x1888E94", Offset = "0x1888E94", VA = "0x7BBC088E94")]
		public UIHudAutoFireSwitchView()
		{
		}

		// Token: 0x0400D3B1 RID: 54193
		[Token(Token = "0x400D3B1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnFireModeSwitch;

		// Token: 0x0400D3B2 RID: 54194
		[Token(Token = "0x400D3B2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel FireModeInfo;

		// Token: 0x0400D3B3 RID: 54195
		[Token(Token = "0x400D3B3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject On;
	}
}
