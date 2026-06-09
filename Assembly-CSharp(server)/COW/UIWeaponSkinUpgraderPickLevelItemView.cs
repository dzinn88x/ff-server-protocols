using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200259A RID: 9626
	[Token(Token = "0x200259A")]
	public class UIWeaponSkinUpgraderPickLevelItemView : UIBaseView
	{
		// Token: 0x0600C644 RID: 50756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C644")]
		[Address(RVA = "0x2230F9C", Offset = "0x2230F9C", VA = "0x7BBCA30F9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C645 RID: 50757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C645")]
		[Address(RVA = "0x223117C", Offset = "0x223117C", VA = "0x7BBCA3117C")]
		public UIWeaponSkinUpgraderPickLevelItemView()
		{
		}

		// Token: 0x0400F81E RID: 63518
		[Token(Token = "0x400F81E")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnWeaponSkinPickLevel;

		// Token: 0x0400F81F RID: 63519
		[Token(Token = "0x400F81F")]
		[FieldOffset(Offset = "0x28")]
		public UISprite SpriteRoundLight;

		// Token: 0x0400F820 RID: 63520
		[Token(Token = "0x400F820")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid propertyGrid;

		// Token: 0x0400F821 RID: 63521
		[Token(Token = "0x400F821")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteWeaponSkinPickLevel;

		// Token: 0x0400F822 RID: 63522
		[Token(Token = "0x400F822")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SpriteLock;

		// Token: 0x0400F823 RID: 63523
		[Token(Token = "0x400F823")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelLevel;
	}
}
