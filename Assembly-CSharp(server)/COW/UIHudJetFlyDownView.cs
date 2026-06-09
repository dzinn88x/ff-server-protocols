using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022F5 RID: 8949
	[Token(Token = "0x20022F5")]
	internal class UIHudJetFlyDownView : UIBaseView
	{
		// Token: 0x0600C0FA RID: 49402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FA")]
		[Address(RVA = "0x1C4D024", Offset = "0x1C4D024", VA = "0x7BBC44D024", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0FB RID: 49403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0FB")]
		[Address(RVA = "0x1C4D144", Offset = "0x1C4D144", VA = "0x7BBC44D144")]
		public UIHudJetFlyDownView()
		{
		}

		// Token: 0x0400D7DB RID: 55259
		[Token(Token = "0x400D7DB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnJetFlyDown;

		// Token: 0x0400D7DC RID: 55260
		[Token(Token = "0x400D7DC")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BtnSprite;

		// Token: 0x0400D7DD RID: 55261
		[Token(Token = "0x400D7DD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BtnName;
	}
}
