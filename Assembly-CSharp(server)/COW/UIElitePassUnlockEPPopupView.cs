using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C1 RID: 8641
	[Token(Token = "0x20021C1")]
	public class UIElitePassUnlockEPPopupView : UIBaseView
	{
		// Token: 0x0600BE92 RID: 48786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE92")]
		[Address(RVA = "0x1E7095C", Offset = "0x1E7095C", VA = "0x7BBC67095C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE93")]
		[Address(RVA = "0x1E70AF8", Offset = "0x1E70AF8", VA = "0x7BBC670AF8")]
		public UIElitePassUnlockEPPopupView()
		{
		}

		// Token: 0x0400CADB RID: 51931
		[Token(Token = "0x400CADB")]
		[FieldOffset(Offset = "0x20")]
		public UILabel title;

		// Token: 0x0400CADC RID: 51932
		[Token(Token = "0x400CADC")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnLabel;

		// Token: 0x0400CADD RID: 51933
		[Token(Token = "0x400CADD")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;

		// Token: 0x0400CADE RID: 51934
		[Token(Token = "0x400CADE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject EPPrivilegeBundle;

		// Token: 0x0400CADF RID: 51935
		[Token(Token = "0x400CADF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EPPrivilege;
	}
}
