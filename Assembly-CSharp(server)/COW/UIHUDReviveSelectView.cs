using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002358 RID: 9048
	[Token(Token = "0x2002358")]
	public class UIHUDReviveSelectView : UIBaseView
	{
		// Token: 0x0600C1C0 RID: 49600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C0")]
		[Address(RVA = "0x1D4CA48", Offset = "0x1D4CA48", VA = "0x7BBC54CA48", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1C1")]
		[Address(RVA = "0x1D4CE00", Offset = "0x1D4CE00", VA = "0x7BBC54CE00")]
		public UIHUDReviveSelectView()
		{
		}

		// Token: 0x0400DB20 RID: 56096
		[Token(Token = "0x400DB20")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ReviveSingleNode;

		// Token: 0x0400DB21 RID: 56097
		[Token(Token = "0x400DB21")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid NameGrid;

		// Token: 0x0400DB22 RID: 56098
		[Token(Token = "0x400DB22")]
		[FieldOffset(Offset = "0x30")]
		public UIButton PlayerBtn1;

		// Token: 0x0400DB23 RID: 56099
		[Token(Token = "0x400DB23")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Select1;

		// Token: 0x0400DB24 RID: 56100
		[Token(Token = "0x400DB24")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Name1;

		// Token: 0x0400DB25 RID: 56101
		[Token(Token = "0x400DB25")]
		[FieldOffset(Offset = "0x48")]
		public UIButton PlayerBtn2;

		// Token: 0x0400DB26 RID: 56102
		[Token(Token = "0x400DB26")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Select2;

		// Token: 0x0400DB27 RID: 56103
		[Token(Token = "0x400DB27")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Name2;

		// Token: 0x0400DB28 RID: 56104
		[Token(Token = "0x400DB28")]
		[FieldOffset(Offset = "0x60")]
		public UIButton PlayerBtn3;

		// Token: 0x0400DB29 RID: 56105
		[Token(Token = "0x400DB29")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Select3;

		// Token: 0x0400DB2A RID: 56106
		[Token(Token = "0x400DB2A")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Name3;

		// Token: 0x0400DB2B RID: 56107
		[Token(Token = "0x400DB2B")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ReviveAllNode;

		// Token: 0x0400DB2C RID: 56108
		[Token(Token = "0x400DB2C")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnConfirm;

		// Token: 0x0400DB2D RID: 56109
		[Token(Token = "0x400DB2D")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnCancel;
	}
}
