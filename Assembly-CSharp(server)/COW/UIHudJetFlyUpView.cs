using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F6 RID: 8950
	[Token(Token = "0x20022F6")]
	internal class UIHudJetFlyUpView : UIBaseView
	{
		// Token: 0x0600C0FC RID: 49404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FC")]
		[Address(RVA = "0x1C4D268", Offset = "0x1C4D268", VA = "0x7BBC44D268", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0FD RID: 49405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FD")]
		[Address(RVA = "0x1C4D388", Offset = "0x1C4D388", VA = "0x7BBC44D388")]
		public UIHudJetFlyUpView()
		{
		}

		// Token: 0x0400D7DE RID: 55262
		[Token(Token = "0x400D7DE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnJetFlyUp;

		// Token: 0x0400D7DF RID: 55263
		[Token(Token = "0x400D7DF")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BtnSprite;

		// Token: 0x0400D7E0 RID: 55264
		[Token(Token = "0x400D7E0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnName;
	}
}
