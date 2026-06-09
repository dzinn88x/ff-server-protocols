using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200217F RID: 8575
	[Token(Token = "0x200217F")]
	public class UICommonOptionalDownloaderView : UIBaseView
	{
		// Token: 0x0600BE0E RID: 48654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0E")]
		[Address(RVA = "0x180333C", Offset = "0x180333C", VA = "0x7BBC00333C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE0F RID: 48655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE0F")]
		[Address(RVA = "0x180345C", Offset = "0x180345C", VA = "0x7BBC00345C")]
		public UICommonOptionalDownloaderView()
		{
		}

		// Token: 0x0400C78E RID: 51086
		[Token(Token = "0x400C78E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400C78F RID: 51087
		[Token(Token = "0x400C78F")]
		[FieldOffset(Offset = "0x28")]
		public UISprite RunningSprite;

		// Token: 0x0400C790 RID: 51088
		[Token(Token = "0x400C790")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ControlBtn;
	}
}
