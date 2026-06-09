using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022AE RID: 8878
	[Token(Token = "0x20022AE")]
	public class UIHudCSShopMysteryBoxOpenView : UIBaseView
	{
		// Token: 0x0600C06C RID: 49260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06C")]
		[Address(RVA = "0x19CF9F4", Offset = "0x19CF9F4", VA = "0x7BBC1CF9F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C06D RID: 49261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C06D")]
		[Address(RVA = "0x19CFC88", Offset = "0x19CFC88", VA = "0x7BBC1CFC88")]
		public UIHudCSShopMysteryBoxOpenView()
		{
		}

		// Token: 0x0400D538 RID: 54584
		[Token(Token = "0x400D538")]
		[FieldOffset(Offset = "0x20")]
		public UILabel title;

		// Token: 0x0400D539 RID: 54585
		[Token(Token = "0x400D539")]
		[FieldOffset(Offset = "0x28")]
		public UIButton bgBtn;

		// Token: 0x0400D53A RID: 54586
		[Token(Token = "0x400D53A")]
		[FieldOffset(Offset = "0x30")]
		public UIButton helpBtn;

		// Token: 0x0400D53B RID: 54587
		[Token(Token = "0x400D53B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel countdown;

		// Token: 0x0400D53C RID: 54588
		[Token(Token = "0x400D53C")]
		[FieldOffset(Offset = "0x40")]
		public UIGrid grid;

		// Token: 0x0400D53D RID: 54589
		[Token(Token = "0x400D53D")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButtonGroup gridToggleGroup;

		// Token: 0x0400D53E RID: 54590
		[Token(Token = "0x400D53E")]
		[FieldOffset(Offset = "0x50")]
		public UIHudCSMysteryBoxOptionItemView optionItem;

		// Token: 0x0400D53F RID: 54591
		[Token(Token = "0x400D53F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HL;

		// Token: 0x0400D540 RID: 54592
		[Token(Token = "0x400D540")]
		[FieldOffset(Offset = "0x60")]
		public UIButton confirmBtn;
	}
}
