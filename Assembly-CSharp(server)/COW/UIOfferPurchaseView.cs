using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002467 RID: 9319
	[Token(Token = "0x2002467")]
	public class UIOfferPurchaseView : UIBaseView
	{
		// Token: 0x0600C3DE RID: 50142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DE")]
		[Address(RVA = "0x16E1190", Offset = "0x16E1190", VA = "0x7BBBEE1190", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3DF RID: 50143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3DF")]
		[Address(RVA = "0x16E13DC", Offset = "0x16E13DC", VA = "0x7BBBEE13DC")]
		public UIOfferPurchaseView()
		{
		}

		// Token: 0x0400E98D RID: 59789
		[Token(Token = "0x400E98D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Name;

		// Token: 0x0400E98E RID: 59790
		[Token(Token = "0x400E98E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Desc;

		// Token: 0x0400E98F RID: 59791
		[Token(Token = "0x400E98F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemContainer;

		// Token: 0x0400E990 RID: 59792
		[Token(Token = "0x400E990")]
		[FieldOffset(Offset = "0x38")]
		public UIButton PurchaseBtn;

		// Token: 0x0400E991 RID: 59793
		[Token(Token = "0x400E991")]
		[FieldOffset(Offset = "0x40")]
		public UIButton CloseBtn;

		// Token: 0x0400E992 RID: 59794
		[Token(Token = "0x400E992")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Price;

		// Token: 0x0400E993 RID: 59795
		[Token(Token = "0x400E993")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BasePrice;

		// Token: 0x0400E994 RID: 59796
		[Token(Token = "0x400E994")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Discount;
	}
}
