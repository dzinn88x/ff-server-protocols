using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F1 RID: 8945
	[Token(Token = "0x20022F1")]
	public class UIHudItemMarkBtnView : UIBaseView
	{
		// Token: 0x0600C0F2 RID: 49394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F2")]
		[Address(RVA = "0x1C481A8", Offset = "0x1C481A8", VA = "0x7BBC4481A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0F3 RID: 49395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0F3")]
		[Address(RVA = "0x1C4831C", Offset = "0x1C4831C", VA = "0x7BBC44831C")]
		public UIHudItemMarkBtnView()
		{
		}

		// Token: 0x0400D7C9 RID: 55241
		[Token(Token = "0x400D7C9")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BtnColdDownMask;

		// Token: 0x0400D7CA RID: 55242
		[Token(Token = "0x400D7CA")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnFireModeSwitch;

		// Token: 0x0400D7CB RID: 55243
		[Token(Token = "0x400D7CB")]
		[FieldOffset(Offset = "0x30")]
		public UIEventListener EventListener;

		// Token: 0x0400D7CC RID: 55244
		[Token(Token = "0x400D7CC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OnPressed;
	}
}
