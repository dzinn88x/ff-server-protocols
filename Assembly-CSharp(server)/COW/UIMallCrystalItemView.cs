using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002413 RID: 9235
	[Token(Token = "0x2002413")]
	public class UIMallCrystalItemView : UIBaseView
	{
		// Token: 0x0600C336 RID: 49974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C336")]
		[Address(RVA = "0x1C5FDE4", Offset = "0x1C5FDE4", VA = "0x7BBC45FDE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C337 RID: 49975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C337")]
		[Address(RVA = "0x1C60040", Offset = "0x1C60040", VA = "0x7BBC460040")]
		public UIMallCrystalItemView()
		{
		}

		// Token: 0x0400E3FB RID: 58363
		[Token(Token = "0x400E3FB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIMallCrystalItem;

		// Token: 0x0400E3FC RID: 58364
		[Token(Token = "0x400E3FC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Default;

		// Token: 0x0400E3FD RID: 58365
		[Token(Token = "0x400E3FD")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400E3FE RID: 58366
		[Token(Token = "0x400E3FE")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLightBG;

		// Token: 0x0400E3FF RID: 58367
		[Token(Token = "0x400E3FF")]
		[FieldOffset(Offset = "0x40")]
		public GameObject UniquedTitle;

		// Token: 0x0400E400 RID: 58368
		[Token(Token = "0x400E400")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ExchangeContainer;

		// Token: 0x0400E401 RID: 58369
		[Token(Token = "0x400E401")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ExchangePriceLabel;

		// Token: 0x0400E402 RID: 58370
		[Token(Token = "0x400E402")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ExchangeIcon;
	}
}
