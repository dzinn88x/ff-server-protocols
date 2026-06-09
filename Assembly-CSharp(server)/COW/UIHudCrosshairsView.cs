using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A2 RID: 8866
	[Token(Token = "0x20022A2")]
	public class UIHudCrosshairsView : UIBaseView
	{
		// Token: 0x0600C055 RID: 49237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C055")]
		[Address(RVA = "0x1A9EFA0", Offset = "0x1A9EFA0", VA = "0x7BBC29EFA0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C056 RID: 49238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C056")]
		[Address(RVA = "0x1A9F664", Offset = "0x1A9F664", VA = "0x7BBC29F664")]
		public UIHudCrosshairsView()
		{
		}

		// Token: 0x0400D4D5 RID: 54485
		[Token(Token = "0x400D4D5")]
		[FieldOffset(Offset = "0x20")]
		public UISprite AimSprite;

		// Token: 0x0400D4D6 RID: 54486
		[Token(Token = "0x400D4D6")]
		[FieldOffset(Offset = "0x28")]
		public UISprite MedicalAimSprite;

		// Token: 0x0400D4D7 RID: 54487
		[Token(Token = "0x400D4D7")]
		[FieldOffset(Offset = "0x30")]
		public UISprite AimClosePosSprite;

		// Token: 0x0400D4D8 RID: 54488
		[Token(Token = "0x400D4D8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HitEnhanced;

		// Token: 0x0400D4D9 RID: 54489
		[Token(Token = "0x400D4D9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject IngameHudEnhancedHit;

		// Token: 0x0400D4DA RID: 54490
		[Token(Token = "0x400D4DA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject IngameHudEnhancedKill;

		// Token: 0x0400D4DB RID: 54491
		[Token(Token = "0x400D4DB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Hit;

		// Token: 0x0400D4DC RID: 54492
		[Token(Token = "0x400D4DC")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SpriteGunSight;

		// Token: 0x0400D4DD RID: 54493
		[Token(Token = "0x400D4DD")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ChargeRateTxt;

		// Token: 0x0400D4DE RID: 54494
		[Token(Token = "0x400D4DE")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ChargeRate1;

		// Token: 0x0400D4DF RID: 54495
		[Token(Token = "0x400D4DF")]
		[FieldOffset(Offset = "0x70")]
		public UISprite ChargeRate2;

		// Token: 0x0400D4E0 RID: 54496
		[Token(Token = "0x400D4E0")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ChargeRate3;

		// Token: 0x0400D4E1 RID: 54497
		[Token(Token = "0x400D4E1")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ChargeVFX;

		// Token: 0x0400D4E2 RID: 54498
		[Token(Token = "0x400D4E2")]
		[FieldOffset(Offset = "0x88")]
		public ParticleSystemRenderer ChargePS;

		// Token: 0x0400D4E3 RID: 54499
		[Token(Token = "0x400D4E3")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ChargeBurst;

		// Token: 0x0400D4E4 RID: 54500
		[Token(Token = "0x400D4E4")]
		[FieldOffset(Offset = "0x98")]
		public ParticleSystem ChargeFire;

		// Token: 0x0400D4E5 RID: 54501
		[Token(Token = "0x400D4E5")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite SpriteGunSightCenter;

		// Token: 0x0400D4E6 RID: 54502
		[Token(Token = "0x400D4E6")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite SightCenterLight;

		// Token: 0x0400D4E7 RID: 54503
		[Token(Token = "0x400D4E7")]
		[FieldOffset(Offset = "0xB0")]
		public UITexture ThermalView;

		// Token: 0x0400D4E8 RID: 54504
		[Token(Token = "0x400D4E8")]
		[FieldOffset(Offset = "0xB8")]
		public UITexture PenetrableView;

		// Token: 0x0400D4E9 RID: 54505
		[Token(Token = "0x400D4E9")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite Sight;

		// Token: 0x0400D4EA RID: 54506
		[Token(Token = "0x400D4EA")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject GunShield;

		// Token: 0x0400D4EB RID: 54507
		[Token(Token = "0x400D4EB")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite GunShieldLeft;

		// Token: 0x0400D4EC RID: 54508
		[Token(Token = "0x400D4EC")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite GunShieldRight;

		// Token: 0x0400D4ED RID: 54509
		[Token(Token = "0x400D4ED")]
		[FieldOffset(Offset = "0xE0")]
		public ParticleSystem SightFireEffect01;

		// Token: 0x0400D4EE RID: 54510
		[Token(Token = "0x400D4EE")]
		[FieldOffset(Offset = "0xE8")]
		public ParticleSystem SightFireEffect02;

		// Token: 0x0400D4EF RID: 54511
		[Token(Token = "0x400D4EF")]
		[FieldOffset(Offset = "0xF0")]
		public TweenAlpha AimBanSprite;

		// Token: 0x0400D4F0 RID: 54512
		[Token(Token = "0x400D4F0")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject FlashHit;
	}
}
