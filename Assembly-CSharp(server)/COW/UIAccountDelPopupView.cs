using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D3 RID: 8403
	[Token(Token = "0x20020D3")]
	internal class UIAccountDelPopupView : UIBaseView
	{
		// Token: 0x0600BCB7 RID: 48311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB7")]
		[Address(RVA = "0x1A3A898", Offset = "0x1A3A898", VA = "0x7BBC23A898", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCB8 RID: 48312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB8")]
		[Address(RVA = "0x1A3AB98", Offset = "0x1A3AB98", VA = "0x7BBC23AB98")]
		public UIAccountDelPopupView()
		{
		}

		// Token: 0x0400BE6C RID: 48748
		[Token(Token = "0x400BE6C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400BE6D RID: 48749
		[Token(Token = "0x400BE6D")]
		[FieldOffset(Offset = "0x28")]
		public UIInput PasswordInput;

		// Token: 0x0400BE6E RID: 48750
		[Token(Token = "0x400BE6E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Content;

		// Token: 0x0400BE6F RID: 48751
		[Token(Token = "0x400BE6F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel URLLabel;

		// Token: 0x0400BE70 RID: 48752
		[Token(Token = "0x400BE70")]
		[FieldOffset(Offset = "0x40")]
		public UIButton URLBtn;

		// Token: 0x0400BE71 RID: 48753
		[Token(Token = "0x400BE71")]
		[FieldOffset(Offset = "0x48")]
		public UIButton OKBtn;

		// Token: 0x0400BE72 RID: 48754
		[Token(Token = "0x400BE72")]
		[FieldOffset(Offset = "0x50")]
		public UILabel OKTxt;

		// Token: 0x0400BE73 RID: 48755
		[Token(Token = "0x400BE73")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CancelBtn;

		// Token: 0x0400BE74 RID: 48756
		[Token(Token = "0x400BE74")]
		[FieldOffset(Offset = "0x60")]
		public UILabel CancelTxt;

		// Token: 0x0400BE75 RID: 48757
		[Token(Token = "0x400BE75")]
		[FieldOffset(Offset = "0x68")]
		public UIToggle Check;

		// Token: 0x0400BE76 RID: 48758
		[Token(Token = "0x400BE76")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Tips;
	}
}
