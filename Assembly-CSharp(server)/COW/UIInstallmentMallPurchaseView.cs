using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C4 RID: 9156
	[Token(Token = "0x20023C4")]
	public class UIInstallmentMallPurchaseView : UIBaseView
	{
		// Token: 0x0600C298 RID: 49816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C298")]
		[Address(RVA = "0x1910044", Offset = "0x1910044", VA = "0x7BBC110044", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C299 RID: 49817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C299")]
		[Address(RVA = "0x191041C", Offset = "0x191041C", VA = "0x7BBC11041C")]
		public UIInstallmentMallPurchaseView()
		{
		}

		// Token: 0x0400DEDB RID: 57051
		[Token(Token = "0x400DEDB")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400DEDC RID: 57052
		[Token(Token = "0x400DEDC")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemIcon;

		// Token: 0x0400DEDD RID: 57053
		[Token(Token = "0x400DEDD")]
		[FieldOffset(Offset = "0x30")]
		public UISprite WeaponIcon;

		// Token: 0x0400DEDE RID: 57054
		[Token(Token = "0x400DEDE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ItemNameLabel;

		// Token: 0x0400DEDF RID: 57055
		[Token(Token = "0x400DEDF")]
		[FieldOffset(Offset = "0x40")]
		public UISprite QualityBG;

		// Token: 0x0400DEE0 RID: 57056
		[Token(Token = "0x400DEE0")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Quality;

		// Token: 0x0400DEE1 RID: 57057
		[Token(Token = "0x400DEE1")]
		[FieldOffset(Offset = "0x50")]
		public UISprite VoucherIcon;

		// Token: 0x0400DEE2 RID: 57058
		[Token(Token = "0x400DEE2")]
		[FieldOffset(Offset = "0x58")]
		public UIButton PurchaseBtn;

		// Token: 0x0400DEE3 RID: 57059
		[Token(Token = "0x400DEE3")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Price;

		// Token: 0x0400DEE4 RID: 57060
		[Token(Token = "0x400DEE4")]
		[FieldOffset(Offset = "0x68")]
		public UISprite MoneyBgSprite;

		// Token: 0x0400DEE5 RID: 57061
		[Token(Token = "0x400DEE5")]
		[FieldOffset(Offset = "0x70")]
		public GameObject PurchaseContainer;

		// Token: 0x0400DEE6 RID: 57062
		[Token(Token = "0x400DEE6")]
		[FieldOffset(Offset = "0x78")]
		public GameObject OverDueContainer;

		// Token: 0x0400DEE7 RID: 57063
		[Token(Token = "0x400DEE7")]
		[FieldOffset(Offset = "0x80")]
		public UILabel PurchaseDesc;

		// Token: 0x0400DEE8 RID: 57064
		[Token(Token = "0x400DEE8")]
		[FieldOffset(Offset = "0x88")]
		public UIEasyList Grid;

		// Token: 0x0400DEE9 RID: 57065
		[Token(Token = "0x400DEE9")]
		[FieldOffset(Offset = "0x90")]
		public UINetworkTexture NetworkTexture;
	}
}
