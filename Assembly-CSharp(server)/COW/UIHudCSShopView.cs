using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022AF RID: 8879
	[Token(Token = "0x20022AF")]
	public class UIHudCSShopView : UIBaseView
	{
		// Token: 0x0600C06E RID: 49262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06E")]
		[Address(RVA = "0x19CFC90", Offset = "0x19CFC90", VA = "0x7BBC1CFC90", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C06F RID: 49263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06F")]
		[Address(RVA = "0x19CFF34", Offset = "0x19CFF34", VA = "0x7BBC1CFF34")]
		public UIHudCSShopView()
		{
		}

		// Token: 0x0400D541 RID: 54593
		[Token(Token = "0x400D541")]
		[FieldOffset(Offset = "0x20")]
		public Animation UIAimCSShop;

		// Token: 0x0400D542 RID: 54594
		[Token(Token = "0x400D542")]
		[FieldOffset(Offset = "0x28")]
		public Transform UIContainer;

		// Token: 0x0400D543 RID: 54595
		[Token(Token = "0x400D543")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Close;

		// Token: 0x0400D544 RID: 54596
		[Token(Token = "0x400D544")]
		[FieldOffset(Offset = "0x38")]
		public UIButton bgBtn;

		// Token: 0x0400D545 RID: 54597
		[Token(Token = "0x400D545")]
		[FieldOffset(Offset = "0x40")]
		public UILabel cost;

		// Token: 0x0400D546 RID: 54598
		[Token(Token = "0x400D546")]
		[FieldOffset(Offset = "0x48")]
		public UILabel left;

		// Token: 0x0400D547 RID: 54599
		[Token(Token = "0x400D547")]
		[FieldOffset(Offset = "0x50")]
		public UIScrollView ScrollView;

		// Token: 0x0400D548 RID: 54600
		[Token(Token = "0x400D548")]
		[FieldOffset(Offset = "0x58")]
		public UITable shopTable;

		// Token: 0x0400D549 RID: 54601
		[Token(Token = "0x400D549")]
		[FieldOffset(Offset = "0x60")]
		public UIButton purchaseBtn;
	}
}
