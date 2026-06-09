using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E6 RID: 8678
	[Token(Token = "0x20021E6")]
	public class UIFFWSLiveTvPopWndView : UIBaseView
	{
		// Token: 0x0600BEDD RID: 48861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDD")]
		[Address(RVA = "0x227DCE4", Offset = "0x227DCE4", VA = "0x7BBCA7DCE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEDE RID: 48862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDE")]
		[Address(RVA = "0x227DE04", Offset = "0x227DE04", VA = "0x7BBCA7DE04")]
		public UIFFWSLiveTvPopWndView()
		{
		}

		// Token: 0x0400CC79 RID: 52345
		[Token(Token = "0x400CC79")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400CC7A RID: 52346
		[Token(Token = "0x400CC7A")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel WebViewPanel;

		// Token: 0x0400CC7B RID: 52347
		[Token(Token = "0x400CC7B")]
		[FieldOffset(Offset = "0x30")]
		public UIWidget WidgetTvView;
	}
}
