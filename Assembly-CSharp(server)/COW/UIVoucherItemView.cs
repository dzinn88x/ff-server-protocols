using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258B RID: 9611
	[Token(Token = "0x200258B")]
	internal class UIVoucherItemView : UIBaseView
	{
		// Token: 0x0600C626 RID: 50726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C626")]
		[Address(RVA = "0x1684504", Offset = "0x1684504", VA = "0x7BBBE84504", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C627 RID: 50727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C627")]
		[Address(RVA = "0x1684678", Offset = "0x1684678", VA = "0x7BBBE84678")]
		public UIVoucherItemView()
		{
		}

		// Token: 0x0400F72D RID: 63277
		[Token(Token = "0x400F72D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400F72E RID: 63278
		[Token(Token = "0x400F72E")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Container;

		// Token: 0x0400F72F RID: 63279
		[Token(Token = "0x400F72F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel PriceLabel;

		// Token: 0x0400F730 RID: 63280
		[Token(Token = "0x400F730")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;
	}
}
