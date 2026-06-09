using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A0 RID: 9632
	[Token(Token = "0x20025A0")]
	public class UIWebViewWindowLiteView : UIBaseView
	{
		// Token: 0x0600C650 RID: 50768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C650")]
		[Address(RVA = "0x178843C", Offset = "0x178843C", VA = "0x7BBBF8843C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C651 RID: 50769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C651")]
		[Address(RVA = "0x178855C", Offset = "0x178855C", VA = "0x7BBBF8855C")]
		public UIWebViewWindowLiteView()
		{
		}

		// Token: 0x0400F87F RID: 63615
		[Token(Token = "0x400F87F")]
		[FieldOffset(Offset = "0x20")]
		public UISprite WebViewArea;

		// Token: 0x0400F880 RID: 63616
		[Token(Token = "0x400F880")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar WebViewProgressBar;

		// Token: 0x0400F881 RID: 63617
		[Token(Token = "0x400F881")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseButton;
	}
}
