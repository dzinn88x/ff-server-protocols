using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200239F RID: 9119
	[Token(Token = "0x200239F")]
	public class UIHudWeaponInfoView : UIBaseView
	{
		// Token: 0x0600C24E RID: 49742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24E")]
		[Address(RVA = "0x1D0D600", Offset = "0x1D0D600", VA = "0x7BBC50D600", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C24F RID: 49743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C24F")]
		[Address(RVA = "0x1D0DE24", Offset = "0x1D0DE24", VA = "0x7BBC50DE24")]
		public UIHudWeaponInfoView()
		{
		}

		// Token: 0x0400DD4E RID: 56654
		[Token(Token = "0x400DD4E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton HeavyWidget;

		// Token: 0x0400DD4F RID: 56655
		[Token(Token = "0x400DD4F")]
		[FieldOffset(Offset = "0x28")]
		public UILabel HeavyAmmoCount;

		// Token: 0x0400DD50 RID: 56656
		[Token(Token = "0x400DD50")]
		[FieldOffset(Offset = "0x30")]
		public UISprite HeavyWeaponIcon;

		// Token: 0x0400DD51 RID: 56657
		[Token(Token = "0x400DD51")]
		[FieldOffset(Offset = "0x38")]
		public UIButton GrenadeWidget;

		// Token: 0x0400DD52 RID: 56658
		[Token(Token = "0x400DD52")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GrenadeLabel;

		// Token: 0x0400DD53 RID: 56659
		[Token(Token = "0x400DD53")]
		[FieldOffset(Offset = "0x48")]
		public UIWidget NormalWidget;

		// Token: 0x0400DD54 RID: 56660
		[Token(Token = "0x400DD54")]
		[FieldOffset(Offset = "0x50")]
		public Transform EffectRoot;

		// Token: 0x0400DD55 RID: 56661
		[Token(Token = "0x400DD55")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LevelUp;

		// Token: 0x0400DD56 RID: 56662
		[Token(Token = "0x400DD56")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LevelDown;

		// Token: 0x0400DD57 RID: 56663
		[Token(Token = "0x400DD57")]
		[FieldOffset(Offset = "0x68")]
		public UILabel WeaponName;

		// Token: 0x0400DD58 RID: 56664
		[Token(Token = "0x400DD58")]
		[FieldOffset(Offset = "0x70")]
		public GameObject GoldEffect;

		// Token: 0x0400DD59 RID: 56665
		[Token(Token = "0x400DD59")]
		[FieldOffset(Offset = "0x78")]
		public UISprite WeaponIcon;

		// Token: 0x0400DD5A RID: 56666
		[Token(Token = "0x400DD5A")]
		[FieldOffset(Offset = "0x80")]
		public UISprite HeatWeaponIcon;

		// Token: 0x0400DD5B RID: 56667
		[Token(Token = "0x400DD5B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject AmmoInfoGO;

		// Token: 0x0400DD5C RID: 56668
		[Token(Token = "0x400DD5C")]
		[FieldOffset(Offset = "0x90")]
		public UILabel CurrentAmmoCount;

		// Token: 0x0400DD5D RID: 56669
		[Token(Token = "0x400DD5D")]
		[FieldOffset(Offset = "0x98")]
		public UILabel MaxAmmoCount;

		// Token: 0x0400DD5E RID: 56670
		[Token(Token = "0x400DD5E")]
		[FieldOffset(Offset = "0xA0")]
		public UIProgressBar AmmoStatusBar;

		// Token: 0x0400DD5F RID: 56671
		[Token(Token = "0x400DD5F")]
		[FieldOffset(Offset = "0xA8")]
		public Transform Reload;

		// Token: 0x0400DD60 RID: 56672
		[Token(Token = "0x400DD60")]
		[FieldOffset(Offset = "0xB0")]
		public UIGrid SwitchWeaponGrid;

		// Token: 0x0400DD61 RID: 56673
		[Token(Token = "0x400DD61")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite InfiniteSprite;

		// Token: 0x0400DD62 RID: 56674
		[Token(Token = "0x400DD62")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite BuffIcon;

		// Token: 0x0400DD63 RID: 56675
		[Token(Token = "0x400DD63")]
		[FieldOffset(Offset = "0xC8")]
		public UIHudWeaponShield Shield;

		// Token: 0x0400DD64 RID: 56676
		[Token(Token = "0x400DD64")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject CombineSprite;

		// Token: 0x0400DD65 RID: 56677
		[Token(Token = "0x400DD65")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject CombineSpriteDissolve;

		// Token: 0x0400DD66 RID: 56678
		[Token(Token = "0x400DD66")]
		[FieldOffset(Offset = "0xE0")]
		public ParticleSystem Effect_Kord;

		// Token: 0x0400DD67 RID: 56679
		[Token(Token = "0x400DD67")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject BuildingWidget;

		// Token: 0x0400DD68 RID: 56680
		[Token(Token = "0x400DD68")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BuildingBtn;

		// Token: 0x0400DD69 RID: 56681
		[Token(Token = "0x400DD69")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject BuildingLabel;

		// Token: 0x0400DD6A RID: 56682
		[Token(Token = "0x400DD6A")]
		[FieldOffset(Offset = "0x100")]
		public UIGrid BuildingGrid;

		// Token: 0x0400DD6B RID: 56683
		[Token(Token = "0x400DD6B")]
		[FieldOffset(Offset = "0x108")]
		public GameObject VehicleWidget;

		// Token: 0x0400DD6C RID: 56684
		[Token(Token = "0x400DD6C")]
		[FieldOffset(Offset = "0x110")]
		public UIGrid VehicleGrid;

		// Token: 0x0400DD6D RID: 56685
		[Token(Token = "0x400DD6D")]
		[FieldOffset(Offset = "0x118")]
		public GameObject HeatWeaponWidget;

		// Token: 0x0400DD6E RID: 56686
		[Token(Token = "0x400DD6E")]
		[FieldOffset(Offset = "0x120")]
		public UILabel HeatWeaponEnergy;
	}
}
