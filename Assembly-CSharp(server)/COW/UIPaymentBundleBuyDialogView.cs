using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200246B RID: 9323
	[Token(Token = "0x200246B")]
	public class UIPaymentBundleBuyDialogView : UIBaseView
	{
		// Token: 0x0600C3E6 RID: 50150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E6")]
		[Address(RVA = "0x16F0FD4", Offset = "0x16F0FD4", VA = "0x7BBBEF0FD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3E7 RID: 50151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3E7")]
		[Address(RVA = "0x16F11C4", Offset = "0x16F11C4", VA = "0x7BBBEF11C4")]
		public UIPaymentBundleBuyDialogView()
		{
		}

		// Token: 0x0400E9BB RID: 59835
		[Token(Token = "0x400E9BB")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid RewardGrid;

		// Token: 0x0400E9BC RID: 59836
		[Token(Token = "0x400E9BC")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Button;

		// Token: 0x0400E9BD RID: 59837
		[Token(Token = "0x400E9BD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel BundlePriceDiamondLabel;

		// Token: 0x0400E9BE RID: 59838
		[Token(Token = "0x400E9BE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel OriginalPriceDiamondLabel;

		// Token: 0x0400E9BF RID: 59839
		[Token(Token = "0x400E9BF")]
		[FieldOffset(Offset = "0x40")]
		public UISprite PercentageSprite;

		// Token: 0x0400E9C0 RID: 59840
		[Token(Token = "0x400E9C0")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PercentageLabel;
	}
}
