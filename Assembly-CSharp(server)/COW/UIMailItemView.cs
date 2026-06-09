using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200240D RID: 9229
	[Token(Token = "0x200240D")]
	public class UIMailItemView : UIBaseView
	{
		// Token: 0x0600C32A RID: 49962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C32A")]
		[Address(RVA = "0x1CE5338", Offset = "0x1CE5338", VA = "0x7BBC4E5338", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C32B RID: 49963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C32B")]
		[Address(RVA = "0x1CE559C", Offset = "0x1CE559C", VA = "0x7BBC4E559C")]
		public UIMailItemView()
		{
		}

		// Token: 0x0400E3BD RID: 58301
		[Token(Token = "0x400E3BD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIMailItem;

		// Token: 0x0400E3BE RID: 58302
		[Token(Token = "0x400E3BE")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemSprite;

		// Token: 0x0400E3BF RID: 58303
		[Token(Token = "0x400E3BF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpriteMailUnRead;

		// Token: 0x0400E3C0 RID: 58304
		[Token(Token = "0x400E3C0")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteMailRead;

		// Token: 0x0400E3C1 RID: 58305
		[Token(Token = "0x400E3C1")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ReadSprite;

		// Token: 0x0400E3C2 RID: 58306
		[Token(Token = "0x400E3C2")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelTitle;

		// Token: 0x0400E3C3 RID: 58307
		[Token(Token = "0x400E3C3")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelTime;

		// Token: 0x0400E3C4 RID: 58308
		[Token(Token = "0x400E3C4")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SpriteTimeIcon;

		// Token: 0x0400E3C5 RID: 58309
		[Token(Token = "0x400E3C5")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SelectedBG;
	}
}
