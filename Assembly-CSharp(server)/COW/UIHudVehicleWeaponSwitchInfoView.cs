using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239E RID: 9118
	[Token(Token = "0x200239E")]
	internal class UIHudVehicleWeaponSwitchInfoView : UIBaseView
	{
		// Token: 0x0600C24C RID: 49740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24C")]
		[Address(RVA = "0x15F4280", Offset = "0x15F4280", VA = "0x7BBBDF4280", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C24D RID: 49741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24D")]
		[Address(RVA = "0x15F44F4", Offset = "0x15F44F4", VA = "0x7BBBDF44F4")]
		public UIHudVehicleWeaponSwitchInfoView()
		{
		}

		// Token: 0x0400DD46 RID: 56646
		[Token(Token = "0x400DD46")]
		[FieldOffset(Offset = "0x20")]
		public UIButton WeaponSwitchButton;

		// Token: 0x0400DD47 RID: 56647
		[Token(Token = "0x400DD47")]
		[FieldOffset(Offset = "0x28")]
		public TweenAlpha EquipHint;

		// Token: 0x0400DD48 RID: 56648
		[Token(Token = "0x400DD48")]
		[FieldOffset(Offset = "0x30")]
		public UISprite PrimaryIcon;

		// Token: 0x0400DD49 RID: 56649
		[Token(Token = "0x400DD49")]
		[FieldOffset(Offset = "0x38")]
		public GameObject AmmoInfoGO;

		// Token: 0x0400DD4A RID: 56650
		[Token(Token = "0x400DD4A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MaxAmmoCount;

		// Token: 0x0400DD4B RID: 56651
		[Token(Token = "0x400DD4B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite InfiniteSprite;

		// Token: 0x0400DD4C RID: 56652
		[Token(Token = "0x400DD4C")]
		[FieldOffset(Offset = "0x50")]
		public UIProgressBar AmmoStatusBar;

		// Token: 0x0400DD4D RID: 56653
		[Token(Token = "0x400DD4D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject AutoShooting;
	}
}
