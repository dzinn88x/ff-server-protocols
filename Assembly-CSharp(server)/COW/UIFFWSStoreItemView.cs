using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021EA RID: 8682
	[Token(Token = "0x20021EA")]
	public class UIFFWSStoreItemView : UIBaseView
	{
		// Token: 0x0600BEE5 RID: 48869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE5")]
		[Address(RVA = "0x2288AA0", Offset = "0x2288AA0", VA = "0x7BBCA88AA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE6")]
		[Address(RVA = "0x2288DE4", Offset = "0x2288DE4", VA = "0x7BBCA88DE4")]
		public UIFFWSStoreItemView()
		{
		}

		// Token: 0x0400CCC0 RID: 52416
		[Token(Token = "0x400CCC0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGLight;

		// Token: 0x0400CCC1 RID: 52417
		[Token(Token = "0x400CCC1")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGDark;

		// Token: 0x0400CCC2 RID: 52418
		[Token(Token = "0x400CCC2")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemContainer;

		// Token: 0x0400CCC3 RID: 52419
		[Token(Token = "0x400CCC3")]
		[FieldOffset(Offset = "0x38")]
		public UIButton PurchaseBtn;

		// Token: 0x0400CCC4 RID: 52420
		[Token(Token = "0x400CCC4")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BtnBG;

		// Token: 0x0400CCC5 RID: 52421
		[Token(Token = "0x400CCC5")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CostNum;

		// Token: 0x0400CCC6 RID: 52422
		[Token(Token = "0x400CCC6")]
		[FieldOffset(Offset = "0x50")]
		public UISprite CurrencyIcon;

		// Token: 0x0400CCC7 RID: 52423
		[Token(Token = "0x400CCC7")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnShadow;

		// Token: 0x0400CCC8 RID: 52424
		[Token(Token = "0x400CCC8")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LimitedNum;

		// Token: 0x0400CCC9 RID: 52425
		[Token(Token = "0x400CCC9")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SellOut;

		// Token: 0x0400CCCA RID: 52426
		[Token(Token = "0x400CCCA")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Owned;

		// Token: 0x0400CCCB RID: 52427
		[Token(Token = "0x400CCCB")]
		[FieldOffset(Offset = "0x78")]
		public UIButton PreviewBtn;
	}
}
