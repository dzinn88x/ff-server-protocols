using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020CC RID: 8396
	[Token(Token = "0x20020CC")]
	public class PVEHUDExitGameUIView : UIBaseView
	{
		// Token: 0x0600BCA9 RID: 48297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA9")]
		[Address(RVA = "0x203CC58", Offset = "0x203CC58", VA = "0x7BBC83CC58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCAA RID: 48298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCAA")]
		[Address(RVA = "0x203CD48", Offset = "0x203CD48", VA = "0x7BBC83CD48")]
		public PVEHUDExitGameUIView()
		{
		}

		// Token: 0x0400BE27 RID: 48679
		[Token(Token = "0x400BE27")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ExitBtn;

		// Token: 0x0400BE28 RID: 48680
		[Token(Token = "0x400BE28")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountdownLabel;
	}
}
