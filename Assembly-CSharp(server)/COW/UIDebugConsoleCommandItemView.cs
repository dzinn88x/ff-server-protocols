using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219A RID: 8602
	[Token(Token = "0x200219A")]
	public class UIDebugConsoleCommandItemView : UIBaseView
	{
		// Token: 0x0600BE44 RID: 48708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE44")]
		[Address(RVA = "0x1BB2CAC", Offset = "0x1BB2CAC", VA = "0x7BBC3B2CAC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE45")]
		[Address(RVA = "0x1BB2D9C", Offset = "0x1BB2D9C", VA = "0x7BBC3B2D9C")]
		public UIDebugConsoleCommandItemView()
		{
		}

		// Token: 0x0400C8C1 RID: 51393
		[Token(Token = "0x400C8C1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CmdBtn;

		// Token: 0x0400C8C2 RID: 51394
		[Token(Token = "0x400C8C2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Name;
	}
}
