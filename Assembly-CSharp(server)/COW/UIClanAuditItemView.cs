using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002160 RID: 8544
	[Token(Token = "0x2002160")]
	internal class UIClanAuditItemView : UIBaseView
	{
		// Token: 0x0600BDD0 RID: 48592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD0")]
		[Address(RVA = "0x1BF9BDC", Offset = "0x1BF9BDC", VA = "0x7BBC3F9BDC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDD1 RID: 48593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD1")]
		[Address(RVA = "0x1BF9D78", Offset = "0x1BF9D78", VA = "0x7BBC3F9D78")]
		public UIClanAuditItemView()
		{
		}

		// Token: 0x0400C592 RID: 50578
		[Token(Token = "0x400C592")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C593 RID: 50579
		[Token(Token = "0x400C593")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400C594 RID: 50580
		[Token(Token = "0x400C594")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400C595 RID: 50581
		[Token(Token = "0x400C595")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400C596 RID: 50582
		[Token(Token = "0x400C596")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SelectedPoint;
	}
}
