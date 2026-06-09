using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002472 RID: 9330
	[Token(Token = "0x2002472")]
	internal class UIPaymentDiamondItemView : UIBaseView
	{
		// Token: 0x0600C3F4 RID: 50164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F4")]
		[Address(RVA = "0x1F2382C", Offset = "0x1F2382C", VA = "0x7BBC72382C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F5")]
		[Address(RVA = "0x1F23A0C", Offset = "0x1F23A0C", VA = "0x7BBC723A0C")]
		public UIPaymentDiamondItemView()
		{
		}

		// Token: 0x0400EA1D RID: 59933
		[Token(Token = "0x400EA1D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Price;

		// Token: 0x0400EA1E RID: 59934
		[Token(Token = "0x400EA1E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Diamond;

		// Token: 0x0400EA1F RID: 59935
		[Token(Token = "0x400EA1F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Selected_diamond;

		// Token: 0x0400EA20 RID: 59936
		[Token(Token = "0x400EA20")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Unselected_diamond;

		// Token: 0x0400EA21 RID: 59937
		[Token(Token = "0x400EA21")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Arrow;

		// Token: 0x0400EA22 RID: 59938
		[Token(Token = "0x400EA22")]
		[FieldOffset(Offset = "0x48")]
		public UISprite lock_icon;
	}
}
