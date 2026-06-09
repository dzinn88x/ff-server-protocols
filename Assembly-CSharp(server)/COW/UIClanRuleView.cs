using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200216E RID: 8558
	[Token(Token = "0x200216E")]
	internal class UIClanRuleView : UIBaseView
	{
		// Token: 0x0600BDEC RID: 48620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDEC")]
		[Address(RVA = "0x1CFF7DC", Offset = "0x1CFF7DC", VA = "0x7BBC4FF7DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDED")]
		[Address(RVA = "0x1CFF8CC", Offset = "0x1CFF8CC", VA = "0x7BBC4FF8CC")]
		public UIClanRuleView()
		{
		}

		// Token: 0x0400C633 RID: 50739
		[Token(Token = "0x400C633")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400C634 RID: 50740
		[Token(Token = "0x400C634")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnConfirm;
	}
}
