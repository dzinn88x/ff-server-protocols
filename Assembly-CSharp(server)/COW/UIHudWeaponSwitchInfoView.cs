using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A0 RID: 9120
	[Token(Token = "0x20023A0")]
	public class UIHudWeaponSwitchInfoView : UIBaseView
	{
		// Token: 0x0600C250 RID: 49744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C250")]
		[Address(RVA = "0x1D105A0", Offset = "0x1D105A0", VA = "0x7BBC5105A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C251")]
		[Address(RVA = "0x1D10AFC", Offset = "0x1D10AFC", VA = "0x7BBC510AFC")]
		public UIHudWeaponSwitchInfoView()
		{
		}

		// Token: 0x0400DD6F RID: 56687
		[Token(Token = "0x400DD6F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton WeaponSwitchButton;

		// Token: 0x0400DD70 RID: 56688
		[Token(Token = "0x400DD70")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget WeaponSwitchWidget;

		// Token: 0x0400DD71 RID: 56689
		[Token(Token = "0x400DD71")]
		[FieldOffset(Offset = "0x30")]
		public Transform EffectRoot;

		// Token: 0x0400DD72 RID: 56690
		[Token(Token = "0x400DD72")]
		[FieldOffset(Offset = "0x38")]
		public UISprite PrimaryIcon;

		// Token: 0x0400DD73 RID: 56691
		[Token(Token = "0x400DD73")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SecondaryIcon;

		// Token: 0x0400DD74 RID: 56692
		[Token(Token = "0x400DD74")]
		[FieldOffset(Offset = "0x48")]
		public UISprite NoWeapon01;

		// Token: 0x0400DD75 RID: 56693
		[Token(Token = "0x400DD75")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NoWeapon02;

		// Token: 0x0400DD76 RID: 56694
		[Token(Token = "0x400DD76")]
		[FieldOffset(Offset = "0x58")]
		public UISprite MeleeIcon;

		// Token: 0x0400DD77 RID: 56695
		[Token(Token = "0x400DD77")]
		[FieldOffset(Offset = "0x60")]
		public GameObject PVEAmmoInfo;

		// Token: 0x0400DD78 RID: 56696
		[Token(Token = "0x400DD78")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PVECurAmmo;

		// Token: 0x0400DD79 RID: 56697
		[Token(Token = "0x400DD79")]
		[FieldOffset(Offset = "0x70")]
		public UISprite PVEInfiniteSprite;

		// Token: 0x0400DD7A RID: 56698
		[Token(Token = "0x400DD7A")]
		[FieldOffset(Offset = "0x78")]
		public UILabel PVEMaxAmmo;

		// Token: 0x0400DD7B RID: 56699
		[Token(Token = "0x400DD7B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject PVESep;

		// Token: 0x0400DD7C RID: 56700
		[Token(Token = "0x400DD7C")]
		[FieldOffset(Offset = "0x88")]
		public UIProgressBar PVEAmmoStatusBar;

		// Token: 0x0400DD7D RID: 56701
		[Token(Token = "0x400DD7D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject AmmoInfoGO;

		// Token: 0x0400DD7E RID: 56702
		[Token(Token = "0x400DD7E")]
		[FieldOffset(Offset = "0x98")]
		public UILabel MaxAmmoCount;

		// Token: 0x0400DD7F RID: 56703
		[Token(Token = "0x400DD7F")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite InfiniteSprite;

		// Token: 0x0400DD80 RID: 56704
		[Token(Token = "0x400DD80")]
		[FieldOffset(Offset = "0xA8")]
		public UIProgressBar AmmoStatusBar;

		// Token: 0x0400DD81 RID: 56705
		[Token(Token = "0x400DD81")]
		[FieldOffset(Offset = "0xB0")]
		public UIHudWeaponShield Shield;

		// Token: 0x0400DD82 RID: 56706
		[Token(Token = "0x400DD82")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject CombineSprite;

		// Token: 0x0400DD83 RID: 56707
		[Token(Token = "0x400DD83")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject CombineSpriteDissolve;
	}
}
