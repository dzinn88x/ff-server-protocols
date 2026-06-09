using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215F RID: 8543
	[Token(Token = "0x200215F")]
	internal class UIClanAreaItemView : UIBaseView
	{
		// Token: 0x0600BDCE RID: 48590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCE")]
		[Address(RVA = "0x1BF9668", Offset = "0x1BF9668", VA = "0x7BBC3F9668", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDCF RID: 48591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCF")]
		[Address(RVA = "0x1BF9804", Offset = "0x1BF9804", VA = "0x7BBC3F9804")]
		public UIClanAreaItemView()
		{
		}

		// Token: 0x0400C58D RID: 50573
		[Token(Token = "0x400C58D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C58E RID: 50574
		[Token(Token = "0x400C58E")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400C58F RID: 50575
		[Token(Token = "0x400C58F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400C590 RID: 50576
		[Token(Token = "0x400C590")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400C591 RID: 50577
		[Token(Token = "0x400C591")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SelectedPoint;
	}
}
