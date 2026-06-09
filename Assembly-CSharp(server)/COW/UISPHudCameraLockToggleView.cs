using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024FD RID: 9469
	[Token(Token = "0x20024FD")]
	internal class UISPHudCameraLockToggleView : UIBaseView
	{
		// Token: 0x0600C50C RID: 50444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50C")]
		[Address(RVA = "0x1EE5ADC", Offset = "0x1EE5ADC", VA = "0x7BBC6E5ADC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C50D RID: 50445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C50D")]
		[Address(RVA = "0x1EE5C38", Offset = "0x1EE5C38", VA = "0x7BBC6E5C38")]
		public UISPHudCameraLockToggleView()
		{
		}

		// Token: 0x0400F158 RID: 61784
		[Token(Token = "0x400F158")]
		[FieldOffset(Offset = "0x20")]
		public UIButton FixedBtn;

		// Token: 0x0400F159 RID: 61785
		[Token(Token = "0x400F159")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F15A RID: 61786
		[Token(Token = "0x400F15A")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LockCamera;

		// Token: 0x0400F15B RID: 61787
		[Token(Token = "0x400F15B")]
		[FieldOffset(Offset = "0x38")]
		public UISprite UnlockCamera;
	}
}
