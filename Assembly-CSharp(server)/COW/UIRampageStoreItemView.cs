using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BD RID: 9405
	[Token(Token = "0x20024BD")]
	public class UIRampageStoreItemView : UIBaseView
	{
		// Token: 0x0600C48A RID: 50314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48A")]
		[Address(RVA = "0x1E089E0", Offset = "0x1E089E0", VA = "0x7BBC6089E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C48B RID: 50315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48B")]
		[Address(RVA = "0x1E08D24", Offset = "0x1E08D24", VA = "0x7BBC608D24")]
		public UIRampageStoreItemView()
		{
		}

		// Token: 0x0400EF13 RID: 61203
		[Token(Token = "0x400EF13")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGLight;

		// Token: 0x0400EF14 RID: 61204
		[Token(Token = "0x400EF14")]
		[FieldOffset(Offset = "0x28")]
		public GameObject BGDark;

		// Token: 0x0400EF15 RID: 61205
		[Token(Token = "0x400EF15")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemContainer;

		// Token: 0x0400EF16 RID: 61206
		[Token(Token = "0x400EF16")]
		[FieldOffset(Offset = "0x38")]
		public UIButton PurchaseBtn;

		// Token: 0x0400EF17 RID: 61207
		[Token(Token = "0x400EF17")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BtnBG;

		// Token: 0x0400EF18 RID: 61208
		[Token(Token = "0x400EF18")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CostNum;

		// Token: 0x0400EF19 RID: 61209
		[Token(Token = "0x400EF19")]
		[FieldOffset(Offset = "0x50")]
		public UISprite CurrencyIcon;

		// Token: 0x0400EF1A RID: 61210
		[Token(Token = "0x400EF1A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BtnShadow;

		// Token: 0x0400EF1B RID: 61211
		[Token(Token = "0x400EF1B")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LimitedNum;

		// Token: 0x0400EF1C RID: 61212
		[Token(Token = "0x400EF1C")]
		[FieldOffset(Offset = "0x68")]
		public GameObject SellOut;

		// Token: 0x0400EF1D RID: 61213
		[Token(Token = "0x400EF1D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Owned;

		// Token: 0x0400EF1E RID: 61214
		[Token(Token = "0x400EF1E")]
		[FieldOffset(Offset = "0x78")]
		public UIButton PreviewBtn;
	}
}
