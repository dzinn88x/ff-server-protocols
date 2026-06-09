using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002471 RID: 9329
	[Token(Token = "0x2002471")]
	internal class UIPaymentDiamondEventView : UIBaseView
	{
		// Token: 0x0600C3F2 RID: 50162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F2")]
		[Address(RVA = "0x1F23434", Offset = "0x1F23434", VA = "0x7BBC723434", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F3")]
		[Address(RVA = "0x1F23714", Offset = "0x1F23714", VA = "0x7BBC723714")]
		public UIPaymentDiamondEventView()
		{
		}

		// Token: 0x0400EA13 RID: 59923
		[Token(Token = "0x400EA13")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Desc1;

		// Token: 0x0400EA14 RID: 59924
		[Token(Token = "0x400EA14")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid PackPrice;

		// Token: 0x0400EA15 RID: 59925
		[Token(Token = "0x400EA15")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ItemBG;

		// Token: 0x0400EA16 RID: 59926
		[Token(Token = "0x400EA16")]
		[FieldOffset(Offset = "0x38")]
		public UILabel purchasingCountLabel;

		// Token: 0x0400EA17 RID: 59927
		[Token(Token = "0x400EA17")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PaymentBtn;

		// Token: 0x0400EA18 RID: 59928
		[Token(Token = "0x400EA18")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PriceLabel;

		// Token: 0x0400EA19 RID: 59929
		[Token(Token = "0x400EA19")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Remaining;

		// Token: 0x0400EA1A RID: 59930
		[Token(Token = "0x400EA1A")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CountLabel;

		// Token: 0x0400EA1B RID: 59931
		[Token(Token = "0x400EA1B")]
		[FieldOffset(Offset = "0x60")]
		public UISprite Diamond;

		// Token: 0x0400EA1C RID: 59932
		[Token(Token = "0x400EA1C")]
		[FieldOffset(Offset = "0x68")]
		public UICountDownLabel EndTime;
	}
}
