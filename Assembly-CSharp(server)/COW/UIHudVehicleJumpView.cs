using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002398 RID: 9112
	[Token(Token = "0x2002398")]
	internal class UIHudVehicleJumpView : UIBaseView
	{
		// Token: 0x0600C240 RID: 49728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C240")]
		[Address(RVA = "0x15F0848", Offset = "0x15F0848", VA = "0x7BBBDF0848", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C241")]
		[Address(RVA = "0x15F09AC", Offset = "0x15F09AC", VA = "0x7BBBDF09AC")]
		public UIHudVehicleJumpView()
		{
		}

		// Token: 0x0400DD23 RID: 56611
		[Token(Token = "0x400DD23")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400DD24 RID: 56612
		[Token(Token = "0x400DD24")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400DD25 RID: 56613
		[Token(Token = "0x400DD25")]
		[FieldOffset(Offset = "0x30")]
		public UISprite icon;

		// Token: 0x0400DD26 RID: 56614
		[Token(Token = "0x400DD26")]
		[FieldOffset(Offset = "0x38")]
		public TweenFill cooldown;
	}
}
