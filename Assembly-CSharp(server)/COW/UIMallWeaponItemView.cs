using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002422 RID: 9250
	[Token(Token = "0x2002422")]
	public class UIMallWeaponItemView : UIBaseView
	{
		// Token: 0x0600C354 RID: 50004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C354")]
		[Address(RVA = "0x1DF4D98", Offset = "0x1DF4D98", VA = "0x7BBC5F4D98", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C355 RID: 50005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C355")]
		[Address(RVA = "0x1DF5250", Offset = "0x1DF5250", VA = "0x7BBC5F5250")]
		public UIMallWeaponItemView()
		{
		}

		// Token: 0x0400E546 RID: 58694
		[Token(Token = "0x400E546")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIMallWeaponItem;

		// Token: 0x0400E547 RID: 58695
		[Token(Token = "0x400E547")]
		[FieldOffset(Offset = "0x28")]
		public GameObject HighLightBG;

		// Token: 0x0400E548 RID: 58696
		[Token(Token = "0x400E548")]
		[FieldOffset(Offset = "0x30")]
		public SetRelativeDepth WeaponVFX;

		// Token: 0x0400E549 RID: 58697
		[Token(Token = "0x400E549")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Default;

		// Token: 0x0400E54A RID: 58698
		[Token(Token = "0x400E54A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite LocalImg;

		// Token: 0x0400E54B RID: 58699
		[Token(Token = "0x400E54B")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400E54C RID: 58700
		[Token(Token = "0x400E54C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject DiscountItemIcon;

		// Token: 0x0400E54D RID: 58701
		[Token(Token = "0x400E54D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WebTitleContainer;

		// Token: 0x0400E54E RID: 58702
		[Token(Token = "0x400E54E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DiscountLabel;

		// Token: 0x0400E54F RID: 58703
		[Token(Token = "0x400E54F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject DiscountVFX;

		// Token: 0x0400E550 RID: 58704
		[Token(Token = "0x400E550")]
		[FieldOffset(Offset = "0x70")]
		public UITable PriceContainer;

		// Token: 0x0400E551 RID: 58705
		[Token(Token = "0x400E551")]
		[FieldOffset(Offset = "0x78")]
		public GameObject DiamondIcon;

		// Token: 0x0400E552 RID: 58706
		[Token(Token = "0x400E552")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DiamondPrice;

		// Token: 0x0400E553 RID: 58707
		[Token(Token = "0x400E553")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Slash;

		// Token: 0x0400E554 RID: 58708
		[Token(Token = "0x400E554")]
		[FieldOffset(Offset = "0x90")]
		public GameObject GoldIcon;

		// Token: 0x0400E555 RID: 58709
		[Token(Token = "0x400E555")]
		[FieldOffset(Offset = "0x98")]
		public UILabel GoldPrice;

		// Token: 0x0400E556 RID: 58710
		[Token(Token = "0x400E556")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel OriginalPrice;

		// Token: 0x0400E557 RID: 58711
		[Token(Token = "0x400E557")]
		[FieldOffset(Offset = "0xA8")]
		public UIWidget PriceBG;
	}
}
