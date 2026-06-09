using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200242F RID: 9263
	[Token(Token = "0x200242F")]
	internal class UIManualWebViewView : UIBaseView
	{
		// Token: 0x0600C36E RID: 50030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C36E")]
		[Address(RVA = "0x18EBB8C", Offset = "0x18EBB8C", VA = "0x7BBC0EBB8C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C36F")]
		[Address(RVA = "0x18EBD9C", Offset = "0x18EBD9C", VA = "0x7BBC0EBD9C")]
		public UIManualWebViewView()
		{
		}

		// Token: 0x0400E648 RID: 58952
		[Token(Token = "0x400E648")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WebViewWindow;

		// Token: 0x0400E649 RID: 58953
		[Token(Token = "0x400E649")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Window;

		// Token: 0x0400E64A RID: 58954
		[Token(Token = "0x400E64A")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget Buttons;

		// Token: 0x0400E64B RID: 58955
		[Token(Token = "0x400E64B")]
		[FieldOffset(Offset = "0x38")]
		public UIButton CloseButton;

		// Token: 0x0400E64C RID: 58956
		[Token(Token = "0x400E64C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite WebViewArea;

		// Token: 0x0400E64D RID: 58957
		[Token(Token = "0x400E64D")]
		[FieldOffset(Offset = "0x48")]
		public UIProgressBar WebViewProgressBar;

		// Token: 0x0400E64E RID: 58958
		[Token(Token = "0x400E64E")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget WebViewProgressBarThumb;
	}
}
