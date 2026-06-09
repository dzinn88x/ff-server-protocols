using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002195 RID: 8597
	[Token(Token = "0x2002195")]
	public class UIDebrisPurchaseView : UIBaseView
	{
		// Token: 0x0600BE3A RID: 48698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3A")]
		[Address(RVA = "0x1BAF6CC", Offset = "0x1BAF6CC", VA = "0x7BBC3AF6CC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE3B RID: 48699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3B")]
		[Address(RVA = "0x1BAFB28", Offset = "0x1BAFB28", VA = "0x7BBC3AFB28")]
		public UIDebrisPurchaseView()
		{
		}

		// Token: 0x0400C89A RID: 51354
		[Token(Token = "0x400C89A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite ItemIcon;

		// Token: 0x0400C89B RID: 51355
		[Token(Token = "0x400C89B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite QualityBg;

		// Token: 0x0400C89C RID: 51356
		[Token(Token = "0x400C89C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Quality;

		// Token: 0x0400C89D RID: 51357
		[Token(Token = "0x400C89D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel orLabel;

		// Token: 0x0400C89E RID: 51358
		[Token(Token = "0x400C89E")]
		[FieldOffset(Offset = "0x40")]
		public UITable PurchaseTable;

		// Token: 0x0400C89F RID: 51359
		[Token(Token = "0x400C89F")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CoinButton;

		// Token: 0x0400C8A0 RID: 51360
		[Token(Token = "0x400C8A0")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CoinCount;

		// Token: 0x0400C8A1 RID: 51361
		[Token(Token = "0x400C8A1")]
		[FieldOffset(Offset = "0x58")]
		public UIButton GemButton;

		// Token: 0x0400C8A2 RID: 51362
		[Token(Token = "0x400C8A2")]
		[FieldOffset(Offset = "0x60")]
		public UILabel GemCount;

		// Token: 0x0400C8A3 RID: 51363
		[Token(Token = "0x400C8A3")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VouchderObj;

		// Token: 0x0400C8A4 RID: 51364
		[Token(Token = "0x400C8A4")]
		[FieldOffset(Offset = "0x70")]
		public UIVoucher Voucher;

		// Token: 0x0400C8A5 RID: 51365
		[Token(Token = "0x400C8A5")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ModifyNumContainer;

		// Token: 0x0400C8A6 RID: 51366
		[Token(Token = "0x400C8A6")]
		[FieldOffset(Offset = "0x80")]
		public UIButton minusBtn;

		// Token: 0x0400C8A7 RID: 51367
		[Token(Token = "0x400C8A7")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CurrentShowlabel;

		// Token: 0x0400C8A8 RID: 51368
		[Token(Token = "0x400C8A8")]
		[FieldOffset(Offset = "0x90")]
		public UIInput CountInput;

		// Token: 0x0400C8A9 RID: 51369
		[Token(Token = "0x400C8A9")]
		[FieldOffset(Offset = "0x98")]
		public UIButton plusBtn;

		// Token: 0x0400C8AA RID: 51370
		[Token(Token = "0x400C8AA")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton maxBtn;
	}
}
