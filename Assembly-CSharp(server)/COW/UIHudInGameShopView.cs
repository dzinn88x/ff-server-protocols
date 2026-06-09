using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E9 RID: 8937
	[Token(Token = "0x20022E9")]
	public class UIHudInGameShopView : UIBaseView
	{
		// Token: 0x0600C0E2 RID: 49378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E2")]
		[Address(RVA = "0x198C4A0", Offset = "0x198C4A0", VA = "0x7BBC18C4A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E3")]
		[Address(RVA = "0x198C940", Offset = "0x198C940", VA = "0x7BBC18C940")]
		public UIHudInGameShopView()
		{
		}

		// Token: 0x0400D739 RID: 55097
		[Token(Token = "0x400D739")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BGBtn;

		// Token: 0x0400D73A RID: 55098
		[Token(Token = "0x400D73A")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ScrollView;

		// Token: 0x0400D73B RID: 55099
		[Token(Token = "0x400D73B")]
		[FieldOffset(Offset = "0x30")]
		public UITable ShopTable;

		// Token: 0x0400D73C RID: 55100
		[Token(Token = "0x400D73C")]
		[FieldOffset(Offset = "0x38")]
		public UIButton CloseBtn;

		// Token: 0x0400D73D RID: 55101
		[Token(Token = "0x400D73D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject LeftTimeShow;

		// Token: 0x0400D73E RID: 55102
		[Token(Token = "0x400D73E")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LeftTime;

		// Token: 0x0400D73F RID: 55103
		[Token(Token = "0x400D73F")]
		[FieldOffset(Offset = "0x50")]
		public UISprite CoinIcon;

		// Token: 0x0400D740 RID: 55104
		[Token(Token = "0x400D740")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CoinValue;

		// Token: 0x0400D741 RID: 55105
		[Token(Token = "0x400D741")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CoinBtn;

		// Token: 0x0400D742 RID: 55106
		[Token(Token = "0x400D742")]
		[FieldOffset(Offset = "0x68")]
		public GameObject CoinTipAnchor;

		// Token: 0x0400D743 RID: 55107
		[Token(Token = "0x400D743")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BuySameBtn;

		// Token: 0x0400D744 RID: 55108
		[Token(Token = "0x400D744")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BuyBtn;

		// Token: 0x0400D745 RID: 55109
		[Token(Token = "0x400D745")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Capacity;

		// Token: 0x0400D746 RID: 55110
		[Token(Token = "0x400D746")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CapacityValue;

		// Token: 0x0400D747 RID: 55111
		[Token(Token = "0x400D747")]
		[FieldOffset(Offset = "0x90")]
		public UIButton CapacityBtn;

		// Token: 0x0400D748 RID: 55112
		[Token(Token = "0x400D748")]
		[FieldOffset(Offset = "0x98")]
		public GameObject CapacityTipAnchor;

		// Token: 0x0400D749 RID: 55113
		[Token(Token = "0x400D749")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel TipLabel;

		// Token: 0x0400D74A RID: 55114
		[Token(Token = "0x400D74A")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton HelpBtn;
	}
}
