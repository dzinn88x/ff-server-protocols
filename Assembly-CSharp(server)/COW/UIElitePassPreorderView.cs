using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B9 RID: 8633
	[Token(Token = "0x20021B9")]
	public class UIElitePassPreorderView : UIBaseView
	{
		// Token: 0x0600BE82 RID: 48770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE82")]
		[Address(RVA = "0x1E69728", Offset = "0x1E69728", VA = "0x7BBC669728", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE83 RID: 48771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE83")]
		[Address(RVA = "0x1E69A84", Offset = "0x1E69A84", VA = "0x7BBC669A84")]
		public UIElitePassPreorderView()
		{
		}

		// Token: 0x0400CA79 RID: 51833
		[Token(Token = "0x400CA79")]
		[FieldOffset(Offset = "0x20")]
		public UIButton PreorderBtn;

		// Token: 0x0400CA7A RID: 51834
		[Token(Token = "0x400CA7A")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Price;

		// Token: 0x0400CA7B RID: 51835
		[Token(Token = "0x400CA7B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel OriginalPrice;

		// Token: 0x0400CA7C RID: 51836
		[Token(Token = "0x400CA7C")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Discount;

		// Token: 0x0400CA7D RID: 51837
		[Token(Token = "0x400CA7D")]
		[FieldOffset(Offset = "0x40")]
		public UICountDownLabel PreorderCountDown;

		// Token: 0x0400CA7E RID: 51838
		[Token(Token = "0x400CA7E")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture PreorderCDN;

		// Token: 0x0400CA7F RID: 51839
		[Token(Token = "0x400CA7F")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SubscribeBtn;

		// Token: 0x0400CA80 RID: 51840
		[Token(Token = "0x400CA80")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SubscriptionBonus;

		// Token: 0x0400CA81 RID: 51841
		[Token(Token = "0x400CA81")]
		[FieldOffset(Offset = "0x60")]
		public UILabel SubscriptionBonusAmountLabel;

		// Token: 0x0400CA82 RID: 51842
		[Token(Token = "0x400CA82")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid PreviewGrid;

		// Token: 0x0400CA83 RID: 51843
		[Token(Token = "0x400CA83")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CGAnim;

		// Token: 0x0400CA84 RID: 51844
		[Token(Token = "0x400CA84")]
		[FieldOffset(Offset = "0x78")]
		public UIButton AnimPlayBtn;
	}
}
