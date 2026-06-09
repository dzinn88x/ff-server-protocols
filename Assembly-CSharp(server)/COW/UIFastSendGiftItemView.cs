using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021DF RID: 8671
	[Token(Token = "0x20021DF")]
	internal class UIFastSendGiftItemView : UIBaseView
	{
		// Token: 0x0600BECF RID: 48847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BECF")]
		[Address(RVA = "0x1DB5DB8", Offset = "0x1DB5DB8", VA = "0x7BBC5B5DB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BED0 RID: 48848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED0")]
		[Address(RVA = "0x1DB61F4", Offset = "0x1DB61F4", VA = "0x7BBC5B61F4")]
		public UIFastSendGiftItemView()
		{
		}

		// Token: 0x0400CBF3 RID: 52211
		[Token(Token = "0x400CBF3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400CBF4 RID: 52212
		[Token(Token = "0x400CBF4")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400CBF5 RID: 52213
		[Token(Token = "0x400CBF5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoldContainer;

		// Token: 0x0400CBF6 RID: 52214
		[Token(Token = "0x400CBF6")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GoldPritceLabel;

		// Token: 0x0400CBF7 RID: 52215
		[Token(Token = "0x400CBF7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject DiamondContainer;

		// Token: 0x0400CBF8 RID: 52216
		[Token(Token = "0x400CBF8")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DiamondPriceLabel;

		// Token: 0x0400CBF9 RID: 52217
		[Token(Token = "0x400CBF9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ItemContainer;

		// Token: 0x0400CBFA RID: 52218
		[Token(Token = "0x400CBFA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HighLightBG;

		// Token: 0x0400CBFB RID: 52219
		[Token(Token = "0x400CBFB")]
		[FieldOffset(Offset = "0x60")]
		public BaseItemView BaseItemView;

		// Token: 0x0400CBFC RID: 52220
		[Token(Token = "0x400CBFC")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ItemIcon;

		// Token: 0x0400CBFD RID: 52221
		[Token(Token = "0x400CBFD")]
		[FieldOffset(Offset = "0x70")]
		public UISprite HeadIcon;

		// Token: 0x0400CBFE RID: 52222
		[Token(Token = "0x400CBFE")]
		[FieldOffset(Offset = "0x78")]
		public UISprite BannerIcon;

		// Token: 0x0400CBFF RID: 52223
		[Token(Token = "0x400CBFF")]
		[FieldOffset(Offset = "0x80")]
		public UISprite DebrisIcon;

		// Token: 0x0400CC00 RID: 52224
		[Token(Token = "0x400CC00")]
		[FieldOffset(Offset = "0x88")]
		public UISprite VehicleSkinIcon;

		// Token: 0x0400CC01 RID: 52225
		[Token(Token = "0x400CC01")]
		[FieldOffset(Offset = "0x90")]
		public UISprite WeaponSkinIcon;

		// Token: 0x0400CC02 RID: 52226
		[Token(Token = "0x400CC02")]
		[FieldOffset(Offset = "0x98")]
		public UISprite VoucherIcon;
	}
}
