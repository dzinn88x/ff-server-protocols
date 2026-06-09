using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002598 RID: 9624
	[Token(Token = "0x2002598")]
	public class UIWeaponSkinUpgraderGunPickItemView : UIBaseView
	{
		// Token: 0x0600C640 RID: 50752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C640")]
		[Address(RVA = "0x2230530", Offset = "0x2230530", VA = "0x7BBCA30530", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C641 RID: 50753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C641")]
		[Address(RVA = "0x22308BC", Offset = "0x22308BC", VA = "0x7BBCA308BC")]
		public UIWeaponSkinUpgraderGunPickItemView()
		{
		}

		// Token: 0x0400F80D RID: 63501
		[Token(Token = "0x400F80D")]
		[FieldOffset(Offset = "0x20")]
		public UISprite spriteQualityBar;

		// Token: 0x0400F80E RID: 63502
		[Token(Token = "0x400F80E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite spriteQualityLight;

		// Token: 0x0400F80F RID: 63503
		[Token(Token = "0x400F80F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Custom;

		// Token: 0x0400F810 RID: 63504
		[Token(Token = "0x400F810")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SpriteWeapon;

		// Token: 0x0400F811 RID: 63505
		[Token(Token = "0x400F811")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LabelTheme;

		// Token: 0x0400F812 RID: 63506
		[Token(Token = "0x400F812")]
		[FieldOffset(Offset = "0x48")]
		public UISprite SpriteLogo;

		// Token: 0x0400F813 RID: 63507
		[Token(Token = "0x400F813")]
		[FieldOffset(Offset = "0x50")]
		public GameObject WSUNewTag;

		// Token: 0x0400F814 RID: 63508
		[Token(Token = "0x400F814")]
		[FieldOffset(Offset = "0x58")]
		public GameObject CanGet;

		// Token: 0x0400F815 RID: 63509
		[Token(Token = "0x400F815")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HaveHad;

		// Token: 0x0400F816 RID: 63510
		[Token(Token = "0x400F816")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid GridLevelMark;

		// Token: 0x0400F817 RID: 63511
		[Token(Token = "0x400F817")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelLevel;

		// Token: 0x0400F818 RID: 63512
		[Token(Token = "0x400F818")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnGunPick;

		// Token: 0x0400F819 RID: 63513
		[Token(Token = "0x400F819")]
		[FieldOffset(Offset = "0x80")]
		public GameObject CantGet;
	}
}
