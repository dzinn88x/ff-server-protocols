using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002147 RID: 8519
	[Token(Token = "0x2002147")]
	internal class UIChangeNamePopupWindowView : UIBaseView
	{
		// Token: 0x0600BD9E RID: 48542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9E")]
		[Address(RVA = "0x1BDDB80", Offset = "0x1BDDB80", VA = "0x7BBC3DDB80", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9F")]
		[Address(RVA = "0x1BDDE68", Offset = "0x1BDDE68", VA = "0x7BBC3DDE68")]
		public UIChangeNamePopupWindowView()
		{
		}

		// Token: 0x0400C487 RID: 50311
		[Token(Token = "0x400C487")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelCurrentName;

		// Token: 0x0400C488 RID: 50312
		[Token(Token = "0x400C488")]
		[FieldOffset(Offset = "0x28")]
		public UIInput InputNewName;

		// Token: 0x0400C489 RID: 50313
		[Token(Token = "0x400C489")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid BtnsContainer;

		// Token: 0x0400C48A RID: 50314
		[Token(Token = "0x400C48A")]
		[FieldOffset(Offset = "0x38")]
		public GameObject DiamondBtnGroup;

		// Token: 0x0400C48B RID: 50315
		[Token(Token = "0x400C48B")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelPrice;

		// Token: 0x0400C48C RID: 50316
		[Token(Token = "0x400C48C")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnConfirm;

		// Token: 0x0400C48D RID: 50317
		[Token(Token = "0x400C48D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ConfirmBtnBg;

		// Token: 0x0400C48E RID: 50318
		[Token(Token = "0x400C48E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject CardBtnGroup;

		// Token: 0x0400C48F RID: 50319
		[Token(Token = "0x400C48F")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnUseCard;

		// Token: 0x0400C490 RID: 50320
		[Token(Token = "0x400C490")]
		[FieldOffset(Offset = "0x68")]
		public UISprite UseCardBtnBg;
	}
}
