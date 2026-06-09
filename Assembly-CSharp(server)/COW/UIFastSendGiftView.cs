using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E0 RID: 8672
	[Token(Token = "0x20021E0")]
	public class UIFastSendGiftView : UIBaseView
	{
		// Token: 0x0600BED1 RID: 48849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED1")]
		[Address(RVA = "0x1DB61FC", Offset = "0x1DB61FC", VA = "0x7BBC5B61FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED2")]
		[Address(RVA = "0x1DB65FC", Offset = "0x1DB65FC", VA = "0x7BBC5B65FC")]
		public UIFastSendGiftView()
		{
		}

		// Token: 0x0400CC03 RID: 52227
		[Token(Token = "0x400CC03")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CloseBtn;

		// Token: 0x0400CC04 RID: 52228
		[Token(Token = "0x400CC04")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView GiftItemScrollView;

		// Token: 0x0400CC05 RID: 52229
		[Token(Token = "0x400CC05")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList GiftItemGrid;

		// Token: 0x0400CC06 RID: 52230
		[Token(Token = "0x400CC06")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Mask;

		// Token: 0x0400CC07 RID: 52231
		[Token(Token = "0x400CC07")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid TeamMateGrid;

		// Token: 0x0400CC08 RID: 52232
		[Token(Token = "0x400CC08")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BtnGroupContainer;

		// Token: 0x0400CC09 RID: 52233
		[Token(Token = "0x400CC09")]
		[FieldOffset(Offset = "0x50")]
		public UIButton SendBtn;

		// Token: 0x0400CC0A RID: 52234
		[Token(Token = "0x400CC0A")]
		[FieldOffset(Offset = "0x58")]
		public UITable Table;

		// Token: 0x0400CC0B RID: 52235
		[Token(Token = "0x400CC0B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Diamond;

		// Token: 0x0400CC0C RID: 52236
		[Token(Token = "0x400CC0C")]
		[FieldOffset(Offset = "0x68")]
		public UILabel GemsPriceLabel;

		// Token: 0x0400CC0D RID: 52237
		[Token(Token = "0x400CC0D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject OR;

		// Token: 0x0400CC0E RID: 52238
		[Token(Token = "0x400CC0E")]
		[FieldOffset(Offset = "0x78")]
		public GameObject Gold;

		// Token: 0x0400CC0F RID: 52239
		[Token(Token = "0x400CC0F")]
		[FieldOffset(Offset = "0x80")]
		public UILabel CoinsPriceLabel;

		// Token: 0x0400CC10 RID: 52240
		[Token(Token = "0x400CC10")]
		[FieldOffset(Offset = "0x88")]
		public UIScrollView HotItemScrollView;

		// Token: 0x0400CC11 RID: 52241
		[Token(Token = "0x400CC11")]
		[FieldOffset(Offset = "0x90")]
		public UIEasyList HotItemGrid;
	}
}
