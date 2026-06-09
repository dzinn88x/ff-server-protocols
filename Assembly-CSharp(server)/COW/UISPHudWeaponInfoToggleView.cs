using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002545 RID: 9541
	[Token(Token = "0x2002545")]
	internal class UISPHudWeaponInfoToggleView : UIBaseView
	{
		// Token: 0x0600C59A RID: 50586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59A")]
		[Address(RVA = "0x1627944", Offset = "0x1627944", VA = "0x7BBBE27944", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C59B RID: 50587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59B")]
		[Address(RVA = "0x1627AA0", Offset = "0x1627AA0", VA = "0x7BBBE27AA0")]
		public UISPHudWeaponInfoToggleView()
		{
		}

		// Token: 0x0400F426 RID: 62502
		[Token(Token = "0x400F426")]
		[FieldOffset(Offset = "0x20")]
		public UIButton WeaponInfoBtn;

		// Token: 0x0400F427 RID: 62503
		[Token(Token = "0x400F427")]
		[FieldOffset(Offset = "0x28")]
		public UISprite normal;

		// Token: 0x0400F428 RID: 62504
		[Token(Token = "0x400F428")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HideWeapon;

		// Token: 0x0400F429 RID: 62505
		[Token(Token = "0x400F429")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ShowWeapon;
	}
}
