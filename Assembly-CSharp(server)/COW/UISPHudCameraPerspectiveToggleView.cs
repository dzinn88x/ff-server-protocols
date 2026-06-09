using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FE RID: 9470
	[Token(Token = "0x20024FE")]
	internal class UISPHudCameraPerspectiveToggleView : UIBaseView
	{
		// Token: 0x0600C50E RID: 50446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50E")]
		[Address(RVA = "0x1EE6148", Offset = "0x1EE6148", VA = "0x7BBC6E6148", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C50F RID: 50447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50F")]
		[Address(RVA = "0x1EE62A4", Offset = "0x1EE62A4", VA = "0x7BBC6E62A4")]
		public UISPHudCameraPerspectiveToggleView()
		{
		}

		// Token: 0x0400F15C RID: 61788
		[Token(Token = "0x400F15C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton FixedBtn;

		// Token: 0x0400F15D RID: 61789
		[Token(Token = "0x400F15D")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F15E RID: 61790
		[Token(Token = "0x400F15E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Normal;

		// Token: 0x0400F15F RID: 61791
		[Token(Token = "0x400F15F")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Perspective;
	}
}
