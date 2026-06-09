using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A3 RID: 8867
	[Token(Token = "0x20022A3")]
	public class UIHudCrouchView : UIBaseView
	{
		// Token: 0x0600C057 RID: 49239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C057")]
		[Address(RVA = "0x1A9F9EC", Offset = "0x1A9F9EC", VA = "0x7BBC29F9EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C058 RID: 49240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C058")]
		[Address(RVA = "0x1A9FB78", Offset = "0x1A9FB78", VA = "0x7BBC29FB78")]
		public UIHudCrouchView()
		{
		}

		// Token: 0x0400D4F1 RID: 54513
		[Token(Token = "0x400D4F1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnCrouch;

		// Token: 0x0400D4F2 RID: 54514
		[Token(Token = "0x400D4F2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BGCrouch;

		// Token: 0x0400D4F3 RID: 54515
		[Token(Token = "0x400D4F3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CrouchSprite;

		// Token: 0x0400D4F4 RID: 54516
		[Token(Token = "0x400D4F4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HightlightSpr;

		// Token: 0x0400D4F5 RID: 54517
		[Token(Token = "0x400D4F5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel BtnName;
	}
}
