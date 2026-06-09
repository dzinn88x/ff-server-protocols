using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DC RID: 9180
	[Token(Token = "0x20023DC")]
	public class UILegendClothVaultSlotItemView : UIBaseView
	{
		// Token: 0x0600C2C8 RID: 49864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C8")]
		[Address(RVA = "0x1CB21C4", Offset = "0x1CB21C4", VA = "0x7BBC4B21C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2C9 RID: 49865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C9")]
		[Address(RVA = "0x1CB23AC", Offset = "0x1CB23AC", VA = "0x7BBC4B23AC")]
		public UILegendClothVaultSlotItemView()
		{
		}

		// Token: 0x0400E00A RID: 57354
		[Token(Token = "0x400E00A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnChoose;

		// Token: 0x0400E00B RID: 57355
		[Token(Token = "0x400E00B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteBtnChoose;

		// Token: 0x0400E00C RID: 57356
		[Token(Token = "0x400E00C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GoWearing;

		// Token: 0x0400E00D RID: 57357
		[Token(Token = "0x400E00D")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteSlotIcon;

		// Token: 0x0400E00E RID: 57358
		[Token(Token = "0x400E00E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnCancel;

		// Token: 0x0400E00F RID: 57359
		[Token(Token = "0x400E00F")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteNoItem;
	}
}
