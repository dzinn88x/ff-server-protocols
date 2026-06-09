using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A5 RID: 9637
	[Token(Token = "0x20025A5")]
	internal class UIWinnerModeEntranceView : UIBaseView
	{
		// Token: 0x0600C65A RID: 50778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65A")]
		[Address(RVA = "0x1793358", Offset = "0x1793358", VA = "0x7BBBF93358", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C65B")]
		[Address(RVA = "0x1793728", Offset = "0x1793728", VA = "0x7BBBF93728")]
		public UIWinnerModeEntranceView()
		{
		}

		// Token: 0x0400F8D6 RID: 63702
		[Token(Token = "0x400F8D6")]
		[FieldOffset(Offset = "0x20")]
		public GameObject line;

		// Token: 0x0400F8D7 RID: 63703
		[Token(Token = "0x400F8D7")]
		[FieldOffset(Offset = "0x28")]
		public UILabel TitleLabel;

		// Token: 0x0400F8D8 RID: 63704
		[Token(Token = "0x400F8D8")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;

		// Token: 0x0400F8D9 RID: 63705
		[Token(Token = "0x400F8D9")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ItemIcon;

		// Token: 0x0400F8DA RID: 63706
		[Token(Token = "0x400F8DA")]
		[FieldOffset(Offset = "0x40")]
		public UISprite quality;

		// Token: 0x0400F8DB RID: 63707
		[Token(Token = "0x400F8DB")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ItemCnt;

		// Token: 0x0400F8DC RID: 63708
		[Token(Token = "0x400F8DC")]
		[FieldOffset(Offset = "0x50")]
		public UILabel rewardDetails;

		// Token: 0x0400F8DD RID: 63709
		[Token(Token = "0x400F8DD")]
		[FieldOffset(Offset = "0x58")]
		public UIButton moreInfoBtn;

		// Token: 0x0400F8DE RID: 63710
		[Token(Token = "0x400F8DE")]
		[FieldOffset(Offset = "0x60")]
		public UIButton PurchaseBtn;

		// Token: 0x0400F8DF RID: 63711
		[Token(Token = "0x400F8DF")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PriceLabel;

		// Token: 0x0400F8E0 RID: 63712
		[Token(Token = "0x400F8E0")]
		[FieldOffset(Offset = "0x70")]
		public UISprite MoneyBgSprite;

		// Token: 0x0400F8E1 RID: 63713
		[Token(Token = "0x400F8E1")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ExchangeBtn;

		// Token: 0x0400F8E2 RID: 63714
		[Token(Token = "0x400F8E2")]
		[FieldOffset(Offset = "0x80")]
		public UILabel ExchagneLabel;

		// Token: 0x0400F8E3 RID: 63715
		[Token(Token = "0x400F8E3")]
		[FieldOffset(Offset = "0x88")]
		public UIButton FreeBtn;

		// Token: 0x0400F8E4 RID: 63716
		[Token(Token = "0x400F8E4")]
		[FieldOffset(Offset = "0x90")]
		public GameObject free;
	}
}
