using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021AD RID: 8621
	[Token(Token = "0x20021AD")]
	public class UIDownloadCentreView : UIBaseView
	{
		// Token: 0x0600BE6A RID: 48746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6A")]
		[Address(RVA = "0x220BD68", Offset = "0x220BD68", VA = "0x7BBCA0BD68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE6B")]
		[Address(RVA = "0x220BE58", Offset = "0x220BE58", VA = "0x7BBCA0BE58")]
		public UIDownloadCentreView()
		{
		}

		// Token: 0x0400C999 RID: 51609
		[Token(Token = "0x400C999")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList DownloadListContainer;

		// Token: 0x0400C99A RID: 51610
		[Token(Token = "0x400C99A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel HintLabel;
	}
}
