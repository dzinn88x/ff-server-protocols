using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002198 RID: 8600
	[Token(Token = "0x2002198")]
	public class UIDebugConsoleCommandItem1View : UIBaseView
	{
		// Token: 0x0600BE40 RID: 48704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE40")]
		[Address(RVA = "0x1BB1CB4", Offset = "0x1BB1CB4", VA = "0x7BBC3B1CB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE41")]
		[Address(RVA = "0x1BB1E20", Offset = "0x1BB1E20", VA = "0x7BBC3B1E20")]
		public UIDebugConsoleCommandItem1View()
		{
		}

		// Token: 0x0400C8B6 RID: 51382
		[Token(Token = "0x400C8B6")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CmdBtn;

		// Token: 0x0400C8B7 RID: 51383
		[Token(Token = "0x400C8B7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CmdName;

		// Token: 0x0400C8B8 RID: 51384
		[Token(Token = "0x400C8B8")]
		[FieldOffset(Offset = "0x30")]
		public UIInput Arg1;

		// Token: 0x0400C8B9 RID: 51385
		[Token(Token = "0x400C8B9")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Arg1Name;
	}
}
