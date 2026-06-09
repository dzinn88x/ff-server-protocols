using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002412 RID: 9234
	[Token(Token = "0x2002412")]
	public class UIMallBoxItemView : UIBaseView
	{
		// Token: 0x0600C334 RID: 49972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C334")]
		[Address(RVA = "0x1CE969C", Offset = "0x1CE969C", VA = "0x7BBC4E969C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C335 RID: 49973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C335")]
		[Address(RVA = "0x1CE9B54", Offset = "0x1CE9B54", VA = "0x7BBC4E9B54")]
		public UIMallBoxItemView()
		{
		}

		// Token: 0x0400E3E9 RID: 58345
		[Token(Token = "0x400E3E9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIMallBoxItem;

		// Token: 0x0400E3EA RID: 58346
		[Token(Token = "0x400E3EA")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Widget;

		// Token: 0x0400E3EB RID: 58347
		[Token(Token = "0x400E3EB")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha TweenAlpha;

		// Token: 0x0400E3EC RID: 58348
		[Token(Token = "0x400E3EC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Default;

		// Token: 0x0400E3ED RID: 58349
		[Token(Token = "0x400E3ED")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400E3EE RID: 58350
		[Token(Token = "0x400E3EE")]
		[FieldOffset(Offset = "0x48")]
		public GameObject HighLightBG;

		// Token: 0x0400E3EF RID: 58351
		[Token(Token = "0x400E3EF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject DiscountItemIcon;

		// Token: 0x0400E3F0 RID: 58352
		[Token(Token = "0x400E3F0")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WebTitleContainer;

		// Token: 0x0400E3F1 RID: 58353
		[Token(Token = "0x400E3F1")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DiscountLabel;

		// Token: 0x0400E3F2 RID: 58354
		[Token(Token = "0x400E3F2")]
		[FieldOffset(Offset = "0x68")]
		public GameObject DiscountVFX;

		// Token: 0x0400E3F3 RID: 58355
		[Token(Token = "0x400E3F3")]
		[FieldOffset(Offset = "0x70")]
		public UITable PriceContainer;

		// Token: 0x0400E3F4 RID: 58356
		[Token(Token = "0x400E3F4")]
		[FieldOffset(Offset = "0x78")]
		public GameObject DiamondIcon;

		// Token: 0x0400E3F5 RID: 58357
		[Token(Token = "0x400E3F5")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DiamondPrice;

		// Token: 0x0400E3F6 RID: 58358
		[Token(Token = "0x400E3F6")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Slash;

		// Token: 0x0400E3F7 RID: 58359
		[Token(Token = "0x400E3F7")]
		[FieldOffset(Offset = "0x90")]
		public GameObject GoldIcon;

		// Token: 0x0400E3F8 RID: 58360
		[Token(Token = "0x400E3F8")]
		[FieldOffset(Offset = "0x98")]
		public UILabel GoldPrice;

		// Token: 0x0400E3F9 RID: 58361
		[Token(Token = "0x400E3F9")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel OriginalPrice;

		// Token: 0x0400E3FA RID: 58362
		[Token(Token = "0x400E3FA")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite PriceBG;
	}
}
