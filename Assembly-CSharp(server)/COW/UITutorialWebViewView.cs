using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002580 RID: 9600
	[Token(Token = "0x2002580")]
	public class UITutorialWebViewView : UIBaseView
	{
		// Token: 0x0600C610 RID: 50704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C610")]
		[Address(RVA = "0x19FAD08", Offset = "0x19FAD08", VA = "0x7BBC1FAD08", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C611")]
		[Address(RVA = "0x19FADF8", Offset = "0x19FADF8", VA = "0x7BBC1FADF8")]
		public UITutorialWebViewView()
		{
		}

		// Token: 0x0400F6BB RID: 63163
		[Token(Token = "0x400F6BB")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WebViewWindow;

		// Token: 0x0400F6BC RID: 63164
		[Token(Token = "0x400F6BC")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget WebViewArea;
	}
}
