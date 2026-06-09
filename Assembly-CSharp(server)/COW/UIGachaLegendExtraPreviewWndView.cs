using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002219 RID: 8729
	[Token(Token = "0x2002219")]
	public class UIGachaLegendExtraPreviewWndView : UIBaseView
	{
		// Token: 0x0600BF43 RID: 48963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF43")]
		[Address(RVA = "0x2056DC4", Offset = "0x2056DC4", VA = "0x7BBC856DC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF44")]
		[Address(RVA = "0x2056F30", Offset = "0x2056F30", VA = "0x7BBC856F30")]
		public UIGachaLegendExtraPreviewWndView()
		{
		}

		// Token: 0x0400CF2E RID: 53038
		[Token(Token = "0x400CF2E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton OKBtn;

		// Token: 0x0400CF2F RID: 53039
		[Token(Token = "0x400CF2F")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnLabel;

		// Token: 0x0400CF30 RID: 53040
		[Token(Token = "0x400CF30")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid PreviewGrid;

		// Token: 0x0400CF31 RID: 53041
		[Token(Token = "0x400CF31")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Label;
	}
}
