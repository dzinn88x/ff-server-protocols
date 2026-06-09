using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DA RID: 9178
	[Token(Token = "0x20023DA")]
	public class UILegendClothVaultColorView : UIBaseView
	{
		// Token: 0x0600C2C4 RID: 49860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C4")]
		[Address(RVA = "0x1E3D438", Offset = "0x1E3D438", VA = "0x7BBC63D438", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2C5 RID: 49861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C5")]
		[Address(RVA = "0x1E3D6A4", Offset = "0x1E3D6A4", VA = "0x7BBC63D6A4")]
		public UILegendClothVaultColorView()
		{
		}

		// Token: 0x0400DFF9 RID: 57337
		[Token(Token = "0x400DFF9")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnColor;

		// Token: 0x0400DFFA RID: 57338
		[Token(Token = "0x400DFFA")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteColor;

		// Token: 0x0400DFFB RID: 57339
		[Token(Token = "0x400DFFB")]
		[FieldOffset(Offset = "0x30")]
		public UISprite SpriteNotArmedMask;

		// Token: 0x0400DFFC RID: 57340
		[Token(Token = "0x400DFFC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GoColorSelect;

		// Token: 0x0400DFFD RID: 57341
		[Token(Token = "0x400DFFD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SpriteLock;

		// Token: 0x0400DFFE RID: 57342
		[Token(Token = "0x400DFFE")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnColorLittle;

		// Token: 0x0400DFFF RID: 57343
		[Token(Token = "0x400DFFF")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SpriteColorLittle;

		// Token: 0x0400E000 RID: 57344
		[Token(Token = "0x400E000")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SpriteLockLittle;

		// Token: 0x0400E001 RID: 57345
		[Token(Token = "0x400E001")]
		[FieldOffset(Offset = "0x60")]
		public UISprite SpriteColorLittleSelect;
	}
}
