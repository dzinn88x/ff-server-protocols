using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200244A RID: 9290
	[Token(Token = "0x200244A")]
	public class UIMultiPopMenuItemView : UIBaseView
	{
		// Token: 0x0600C3A4 RID: 50084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A4")]
		[Address(RVA = "0x14CC620", Offset = "0x14CC620", VA = "0x7BBBCCC620", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3A5")]
		[Address(RVA = "0x14CC7BC", Offset = "0x14CC7BC", VA = "0x7BBBCCC7BC")]
		public UIMultiPopMenuItemView()
		{
		}

		// Token: 0x0400E7C0 RID: 59328
		[Token(Token = "0x400E7C0")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E7C1 RID: 59329
		[Token(Token = "0x400E7C1")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400E7C2 RID: 59330
		[Token(Token = "0x400E7C2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400E7C3 RID: 59331
		[Token(Token = "0x400E7C3")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400E7C4 RID: 59332
		[Token(Token = "0x400E7C4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SelectedPoint;
	}
}
