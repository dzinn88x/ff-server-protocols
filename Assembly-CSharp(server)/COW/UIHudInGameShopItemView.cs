using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E8 RID: 8936
	[Token(Token = "0x20022E8")]
	public class UIHudInGameShopItemView : UIBaseView
	{
		// Token: 0x0600C0E0 RID: 49376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E0")]
		[Address(RVA = "0x198BCCC", Offset = "0x198BCCC", VA = "0x7BBC18BCCC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E1")]
		[Address(RVA = "0x198C144", Offset = "0x198C144", VA = "0x7BBC18C144")]
		public UIHudInGameShopItemView()
		{
		}

		// Token: 0x0400D727 RID: 55079
		[Token(Token = "0x400D727")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ItemBtn;

		// Token: 0x0400D728 RID: 55080
		[Token(Token = "0x400D728")]
		[FieldOffset(Offset = "0x28")]
		public GameObject OneObjectContainer;

		// Token: 0x0400D729 RID: 55081
		[Token(Token = "0x400D729")]
		[FieldOffset(Offset = "0x30")]
		public UISprite itemSprite;

		// Token: 0x0400D72A RID: 55082
		[Token(Token = "0x400D72A")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelItemCount;

		// Token: 0x0400D72B RID: 55083
		[Token(Token = "0x400D72B")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TwoObjectContainer;

		// Token: 0x0400D72C RID: 55084
		[Token(Token = "0x400D72C")]
		[FieldOffset(Offset = "0x48")]
		public UISprite itemSprite1;

		// Token: 0x0400D72D RID: 55085
		[Token(Token = "0x400D72D")]
		[FieldOffset(Offset = "0x50")]
		public UISprite itemSprite2;

		// Token: 0x0400D72E RID: 55086
		[Token(Token = "0x400D72E")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ItemName;

		// Token: 0x0400D72F RID: 55087
		[Token(Token = "0x400D72F")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Highlight;

		// Token: 0x0400D730 RID: 55088
		[Token(Token = "0x400D730")]
		[FieldOffset(Offset = "0x68")]
		public UISprite CoinIcon;

		// Token: 0x0400D731 RID: 55089
		[Token(Token = "0x400D731")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Price;

		// Token: 0x0400D732 RID: 55090
		[Token(Token = "0x400D732")]
		[FieldOffset(Offset = "0x78")]
		public GameObject GrayMask;

		// Token: 0x0400D733 RID: 55091
		[Token(Token = "0x400D733")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Limitation;

		// Token: 0x0400D734 RID: 55092
		[Token(Token = "0x400D734")]
		[FieldOffset(Offset = "0x88")]
		public UILabel SoldOut;

		// Token: 0x0400D735 RID: 55093
		[Token(Token = "0x400D735")]
		[FieldOffset(Offset = "0x90")]
		public UISprite qualityBg;

		// Token: 0x0400D736 RID: 55094
		[Token(Token = "0x400D736")]
		[FieldOffset(Offset = "0x98")]
		public UISprite bonus;

		// Token: 0x0400D737 RID: 55095
		[Token(Token = "0x400D737")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject CSMysteryBoxVFX;

		// Token: 0x0400D738 RID: 55096
		[Token(Token = "0x400D738")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite TagNew;
	}
}
