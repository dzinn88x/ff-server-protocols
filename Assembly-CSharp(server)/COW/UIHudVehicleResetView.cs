using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239C RID: 9116
	[Token(Token = "0x200239C")]
	public class UIHudVehicleResetView : UIBaseView
	{
		// Token: 0x0600C248 RID: 49736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C248")]
		[Address(RVA = "0x15F17F4", Offset = "0x15F17F4", VA = "0x7BBBDF17F4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C249 RID: 49737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C249")]
		[Address(RVA = "0x15F1988", Offset = "0x15F1988", VA = "0x7BBBDF1988")]
		public UIHudVehicleResetView()
		{
		}

		// Token: 0x0400DD34 RID: 56628
		[Token(Token = "0x400DD34")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btn;

		// Token: 0x0400DD35 RID: 56629
		[Token(Token = "0x400DD35")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400DD36 RID: 56630
		[Token(Token = "0x400DD36")]
		[FieldOffset(Offset = "0x30")]
		public TweenFill cooldown;

		// Token: 0x0400DD37 RID: 56631
		[Token(Token = "0x400DD37")]
		[FieldOffset(Offset = "0x38")]
		public UISprite CoolDownSpr;

		// Token: 0x0400DD38 RID: 56632
		[Token(Token = "0x400DD38")]
		[FieldOffset(Offset = "0x40")]
		public UISprite icon;
	}
}
