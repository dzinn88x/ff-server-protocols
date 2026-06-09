using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200244F RID: 9295
	[Token(Token = "0x200244F")]
	public class UIMVPStoreItemView : UIBaseView
	{
		// Token: 0x0600C3AE RID: 50094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AE")]
		[Address(RVA = "0x1CDCDF4", Offset = "0x1CDCDF4", VA = "0x7BBC4DCDF4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AF")]
		[Address(RVA = "0x1CDD138", Offset = "0x1CDD138", VA = "0x7BBC4DD138")]
		public UIMVPStoreItemView()
		{
		}

		// Token: 0x0400E807 RID: 59399
		[Token(Token = "0x400E807")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGLight;

		// Token: 0x0400E808 RID: 59400
		[Token(Token = "0x400E808")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGDark;

		// Token: 0x0400E809 RID: 59401
		[Token(Token = "0x400E809")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemContainer;

		// Token: 0x0400E80A RID: 59402
		[Token(Token = "0x400E80A")]
		[FieldOffset(Offset = "0x38")]
		public UIButton PurchaseBtn;

		// Token: 0x0400E80B RID: 59403
		[Token(Token = "0x400E80B")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BtnBG;

		// Token: 0x0400E80C RID: 59404
		[Token(Token = "0x400E80C")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CostNum;

		// Token: 0x0400E80D RID: 59405
		[Token(Token = "0x400E80D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite CurrencyIcon;

		// Token: 0x0400E80E RID: 59406
		[Token(Token = "0x400E80E")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnShadow;

		// Token: 0x0400E80F RID: 59407
		[Token(Token = "0x400E80F")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LimitedNum;

		// Token: 0x0400E810 RID: 59408
		[Token(Token = "0x400E810")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SellOut;

		// Token: 0x0400E811 RID: 59409
		[Token(Token = "0x400E811")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Owned;

		// Token: 0x0400E812 RID: 59410
		[Token(Token = "0x400E812")]
		[FieldOffset(Offset = "0x78")]
		public UIButton PreviewBtn;
	}
}
