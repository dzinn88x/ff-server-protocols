using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219E RID: 8606
	[Token(Token = "0x200219E")]
	public class UIDebugConsoleView : UIBaseView
	{
		// Token: 0x0600BE4C RID: 48716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4C")]
		[Address(RVA = "0x1BBA708", Offset = "0x1BBA708", VA = "0x7BBC3BA708", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4D")]
		[Address(RVA = "0x1BBA87C", Offset = "0x1BBA87C", VA = "0x7BBC3BA87C")]
		public UIDebugConsoleView()
		{
		}

		// Token: 0x0400C8C9 RID: 51401
		[Token(Token = "0x400C8C9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Close;

		// Token: 0x0400C8CA RID: 51402
		[Token(Token = "0x400C8CA")]
		[FieldOffset(Offset = "0x28")]
		public UITable2 CmdTable;

		// Token: 0x0400C8CB RID: 51403
		[Token(Token = "0x400C8CB")]
		[FieldOffset(Offset = "0x30")]
		public UIInput CustomCmd;

		// Token: 0x0400C8CC RID: 51404
		[Token(Token = "0x400C8CC")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Run;
	}
}
