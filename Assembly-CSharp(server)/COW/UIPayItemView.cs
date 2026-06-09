using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002469 RID: 9321
	[Token(Token = "0x2002469")]
	internal class UIPayItemView : UIBaseView
	{
		// Token: 0x0600C3E2 RID: 50146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E2")]
		[Address(RVA = "0x16EC6B8", Offset = "0x16EC6B8", VA = "0x7BBBEEC6B8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E3")]
		[Address(RVA = "0x16EC91C", Offset = "0x16EC91C", VA = "0x7BBBEEC91C")]
		public UIPayItemView()
		{
		}

		// Token: 0x0400E9AC RID: 59820
		[Token(Token = "0x400E9AC")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClickBtn;

		// Token: 0x0400E9AD RID: 59821
		[Token(Token = "0x400E9AD")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BaseDiamondCount;

		// Token: 0x0400E9AE RID: 59822
		[Token(Token = "0x400E9AE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject FirstTopUp;

		// Token: 0x0400E9AF RID: 59823
		[Token(Token = "0x400E9AF")]
		[FieldOffset(Offset = "0x38")]
		public UILabel FirstTopUpDiamondCount;

		// Token: 0x0400E9B0 RID: 59824
		[Token(Token = "0x400E9B0")]
		[FieldOffset(Offset = "0x40")]
		public Animator Bonus;

		// Token: 0x0400E9B1 RID: 59825
		[Token(Token = "0x400E9B1")]
		[FieldOffset(Offset = "0x48")]
		public UILabel BonusNum;

		// Token: 0x0400E9B2 RID: 59826
		[Token(Token = "0x400E9B2")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTextureExt IOSNetworkImage;

		// Token: 0x0400E9B3 RID: 59827
		[Token(Token = "0x400E9B3")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CostAmountLabel;
	}
}
