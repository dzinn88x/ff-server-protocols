using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002496 RID: 9366
	[Token(Token = "0x2002496")]
	internal class UIPolicyPopupView : UIBaseView
	{
		// Token: 0x0600C43C RID: 50236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43C")]
		[Address(RVA = "0x20E8940", Offset = "0x20E8940", VA = "0x7BBC8E8940", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C43D")]
		[Address(RVA = "0x20E8BF8", Offset = "0x20E8BF8", VA = "0x7BBC8E8BF8")]
		public UIPolicyPopupView()
		{
		}

		// Token: 0x0400EBB1 RID: 60337
		[Token(Token = "0x400EBB1")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400EBB2 RID: 60338
		[Token(Token = "0x400EBB2")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Content;

		// Token: 0x0400EBB3 RID: 60339
		[Token(Token = "0x400EBB3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel URLLabel;

		// Token: 0x0400EBB4 RID: 60340
		[Token(Token = "0x400EBB4")]
		[FieldOffset(Offset = "0x38")]
		public UIButton URLBtn;

		// Token: 0x0400EBB5 RID: 60341
		[Token(Token = "0x400EBB5")]
		[FieldOffset(Offset = "0x40")]
		public UIButton OKBtn;

		// Token: 0x0400EBB6 RID: 60342
		[Token(Token = "0x400EBB6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel OKTxt;

		// Token: 0x0400EBB7 RID: 60343
		[Token(Token = "0x400EBB7")]
		[FieldOffset(Offset = "0x50")]
		public UIButton CancelBtn;

		// Token: 0x0400EBB8 RID: 60344
		[Token(Token = "0x400EBB8")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CancelTxt;

		// Token: 0x0400EBB9 RID: 60345
		[Token(Token = "0x400EBB9")]
		[FieldOffset(Offset = "0x60")]
		public UIToggle Check;

		// Token: 0x0400EBBA RID: 60346
		[Token(Token = "0x400EBBA")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Tips;
	}
}
