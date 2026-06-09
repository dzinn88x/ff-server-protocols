using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E1 RID: 8673
	[Token(Token = "0x20021E1")]
	internal class UIFeedPetView : UIBaseView
	{
		// Token: 0x0600BED3 RID: 48851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED3")]
		[Address(RVA = "0x1DB6604", Offset = "0x1DB6604", VA = "0x7BBC5B6604", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED4")]
		[Address(RVA = "0x1DB6A40", Offset = "0x1DB6A40", VA = "0x7BBC5B6A40")]
		public UIFeedPetView()
		{
		}

		// Token: 0x0400CC12 RID: 52242
		[Token(Token = "0x400CC12")]
		[FieldOffset(Offset = "0x20")]
		public GameObject line;

		// Token: 0x0400CC13 RID: 52243
		[Token(Token = "0x400CC13")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CloseBtn;

		// Token: 0x0400CC14 RID: 52244
		[Token(Token = "0x400CC14")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ItemIcon;

		// Token: 0x0400CC15 RID: 52245
		[Token(Token = "0x400CC15")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ItemNameLabel;

		// Token: 0x0400CC16 RID: 52246
		[Token(Token = "0x400CC16")]
		[FieldOffset(Offset = "0x40")]
		public UILabel FeedPetLabel;

		// Token: 0x0400CC17 RID: 52247
		[Token(Token = "0x400CC17")]
		[FieldOffset(Offset = "0x48")]
		public UISprite quality;

		// Token: 0x0400CC18 RID: 52248
		[Token(Token = "0x400CC18")]
		[FieldOffset(Offset = "0x50")]
		public UIButton PurchaseBtn;

		// Token: 0x0400CC19 RID: 52249
		[Token(Token = "0x400CC19")]
		[FieldOffset(Offset = "0x58")]
		public GameObject GoldIcon;

		// Token: 0x0400CC1A RID: 52250
		[Token(Token = "0x400CC1A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject DiamondIcon;

		// Token: 0x0400CC1B RID: 52251
		[Token(Token = "0x400CC1B")]
		[FieldOffset(Offset = "0x68")]
		public UILabel FeedPetCountLabel;

		// Token: 0x0400CC1C RID: 52252
		[Token(Token = "0x400CC1C")]
		[FieldOffset(Offset = "0x70")]
		public UISprite MoneyBgSprite;

		// Token: 0x0400CC1D RID: 52253
		[Token(Token = "0x400CC1D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ModifyNumContainer;

		// Token: 0x0400CC1E RID: 52254
		[Token(Token = "0x400CC1E")]
		[FieldOffset(Offset = "0x80")]
		public UIButton PlusBtn;

		// Token: 0x0400CC1F RID: 52255
		[Token(Token = "0x400CC1F")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CountLabel;

		// Token: 0x0400CC20 RID: 52256
		[Token(Token = "0x400CC20")]
		[FieldOffset(Offset = "0x90")]
		public UIButton MinusBtn;

		// Token: 0x0400CC21 RID: 52257
		[Token(Token = "0x400CC21")]
		[FieldOffset(Offset = "0x98")]
		public UIButton MaxBtn;

		// Token: 0x0400CC22 RID: 52258
		[Token(Token = "0x400CC22")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel Label;
	}
}
