using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022C0 RID: 8896
	[Token(Token = "0x20022C0")]
	public class UIHudEmoteDownLoadStateView : UIBaseView
	{
		// Token: 0x0600C090 RID: 49296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C090")]
		[Address(RVA = "0x1C01960", Offset = "0x1C01960", VA = "0x7BBC401960", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C091 RID: 49297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C091")]
		[Address(RVA = "0x1C019FC", Offset = "0x1C019FC", VA = "0x7BBC4019FC")]
		public UIHudEmoteDownLoadStateView()
		{
		}

		// Token: 0x0400D646 RID: 54854
		[Token(Token = "0x400D646")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DownloadSprite;
	}
}
