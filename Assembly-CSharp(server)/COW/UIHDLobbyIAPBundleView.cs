using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002251 RID: 8785
	[Token(Token = "0x2002251")]
	public class UIHDLobbyIAPBundleView : UIBaseView
	{
		// Token: 0x0600BFB3 RID: 49075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB3")]
		[Address(RVA = "0x16AE924", Offset = "0x16AE924", VA = "0x7BBBEAE924", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFB4")]
		[Address(RVA = "0x16AEA44", Offset = "0x16AEA44", VA = "0x7BBBEAEA44")]
		public UIHDLobbyIAPBundleView()
		{
		}

		// Token: 0x0400D2F1 RID: 54001
		[Token(Token = "0x400D2F1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton IAPBundleButton;

		// Token: 0x0400D2F2 RID: 54002
		[Token(Token = "0x400D2F2")]
		[FieldOffset(Offset = "0x28")]
		public UICountDownLabel CountdownLabel;

		// Token: 0x0400D2F3 RID: 54003
		[Token(Token = "0x400D2F3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite IconSpriteBG;
	}
}
