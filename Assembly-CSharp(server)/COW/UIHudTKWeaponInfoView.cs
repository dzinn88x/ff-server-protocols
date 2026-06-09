using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002381 RID: 9089
	[Token(Token = "0x2002381")]
	internal class UIHudTKWeaponInfoView : UIBaseView
	{
		// Token: 0x0600C212 RID: 49682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C212")]
		[Address(RVA = "0x167C750", Offset = "0x167C750", VA = "0x7BBBE7C750", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C213 RID: 49683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C213")]
		[Address(RVA = "0x167C970", Offset = "0x167C970", VA = "0x7BBBE7C970")]
		public UIHudTKWeaponInfoView()
		{
		}

		// Token: 0x0400DC93 RID: 56467
		[Token(Token = "0x400DC93")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget NormalWidget;

		// Token: 0x0400DC94 RID: 56468
		[Token(Token = "0x400DC94")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha EquipHint;

		// Token: 0x0400DC95 RID: 56469
		[Token(Token = "0x400DC95")]
		[FieldOffset(Offset = "0x30")]
		public UILabel WeaponName;

		// Token: 0x0400DC96 RID: 56470
		[Token(Token = "0x400DC96")]
		[FieldOffset(Offset = "0x38")]
		public UISprite WeaponIcon;

		// Token: 0x0400DC97 RID: 56471
		[Token(Token = "0x400DC97")]
		[FieldOffset(Offset = "0x40")]
		public UILabel WeaponCnt;

		// Token: 0x0400DC98 RID: 56472
		[Token(Token = "0x400DC98")]
		[FieldOffset(Offset = "0x48")]
		public UIProgressBar progressBar;

		// Token: 0x0400DC99 RID: 56473
		[Token(Token = "0x400DC99")]
		[FieldOffset(Offset = "0x50")]
		public UISprite foreground;
	}
}
