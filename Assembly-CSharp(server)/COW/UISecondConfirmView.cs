using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024F0 RID: 9456
	[Token(Token = "0x20024F0")]
	public class UISecondConfirmView : UIBaseView
	{
		// Token: 0x0600C4F0 RID: 50416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F0")]
		[Address(RVA = "0x162FAAC", Offset = "0x162FAAC", VA = "0x7BBBE2FAAC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F1")]
		[Address(RVA = "0x162FD94", Offset = "0x162FD94", VA = "0x7BBBE2FD94")]
		public UISecondConfirmView()
		{
		}

		// Token: 0x0400F0D3 RID: 61651
		[Token(Token = "0x400F0D3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject line;

		// Token: 0x0400F0D4 RID: 61652
		[Token(Token = "0x400F0D4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400F0D5 RID: 61653
		[Token(Token = "0x400F0D5")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ConfirmBtn;

		// Token: 0x0400F0D6 RID: 61654
		[Token(Token = "0x400F0D6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ConfirmBtnLabel;

		// Token: 0x0400F0D7 RID: 61655
		[Token(Token = "0x400F0D7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject IconGoodsStyle;

		// Token: 0x0400F0D8 RID: 61656
		[Token(Token = "0x400F0D8")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Item;

		// Token: 0x0400F0D9 RID: 61657
		[Token(Token = "0x400F0D9")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ConfirmLabel;

		// Token: 0x0400F0DA RID: 61658
		[Token(Token = "0x400F0DA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject TextGoodsStyle;

		// Token: 0x0400F0DB RID: 61659
		[Token(Token = "0x400F0DB")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TextAwards;

		// Token: 0x0400F0DC RID: 61660
		[Token(Token = "0x400F0DC")]
		[FieldOffset(Offset = "0x68")]
		public GameObject OneTextStyle;

		// Token: 0x0400F0DD RID: 61661
		[Token(Token = "0x400F0DD")]
		[FieldOffset(Offset = "0x70")]
		public UILabel OneTextContent;
	}
}
