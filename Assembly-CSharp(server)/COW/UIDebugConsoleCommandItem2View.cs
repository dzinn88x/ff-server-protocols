using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002199 RID: 8601
	[Token(Token = "0x2002199")]
	public class UIDebugConsoleCommandItem2View : UIBaseView
	{
		// Token: 0x0600BE42 RID: 48706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE42")]
		[Address(RVA = "0x1BB2A94", Offset = "0x1BB2A94", VA = "0x7BBC3B2A94", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE43")]
		[Address(RVA = "0x1BB2CA4", Offset = "0x1BB2CA4", VA = "0x7BBC3B2CA4")]
		public UIDebugConsoleCommandItem2View()
		{
		}

		// Token: 0x0400C8BA RID: 51386
		[Token(Token = "0x400C8BA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CmdBtn;

		// Token: 0x0400C8BB RID: 51387
		[Token(Token = "0x400C8BB")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CmdName;

		// Token: 0x0400C8BC RID: 51388
		[Token(Token = "0x400C8BC")]
		[FieldOffset(Offset = "0x30")]
		public UIInput Arg1;

		// Token: 0x0400C8BD RID: 51389
		[Token(Token = "0x400C8BD")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Arg1Name;

		// Token: 0x0400C8BE RID: 51390
		[Token(Token = "0x400C8BE")]
		[FieldOffset(Offset = "0x40")]
		public UIInput Arg2;

		// Token: 0x0400C8BF RID: 51391
		[Token(Token = "0x400C8BF")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Arg2Label;

		// Token: 0x0400C8C0 RID: 51392
		[Token(Token = "0x400C8C0")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Arg2Name;
	}
}
