using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200251E RID: 9502
	[Token(Token = "0x200251E")]
	public class UISPHudNewPlayerInfoView : UIBaseView
	{
		// Token: 0x0600C54C RID: 50508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54C")]
		[Address(RVA = "0x1EEBAD8", Offset = "0x1EEBAD8", VA = "0x7BBC6EBAD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C54D RID: 50509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54D")]
		[Address(RVA = "0x1EEC184", Offset = "0x1EEC184", VA = "0x7BBC6EC184")]
		public UISPHudNewPlayerInfoView()
		{
		}

		// Token: 0x0400F2D0 RID: 62160
		[Token(Token = "0x400F2D0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EPNode;

		// Token: 0x0400F2D1 RID: 62161
		[Token(Token = "0x400F2D1")]
		[FieldOffset(Offset = "0x28")]
		public UISprite EPBar;

		// Token: 0x0400F2D2 RID: 62162
		[Token(Token = "0x400F2D2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelHP;

		// Token: 0x0400F2D3 RID: 62163
		[Token(Token = "0x400F2D3")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HPBar;

		// Token: 0x0400F2D4 RID: 62164
		[Token(Token = "0x400F2D4")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F2D5 RID: 62165
		[Token(Token = "0x400F2D5")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F2D6 RID: 62166
		[Token(Token = "0x400F2D6")]
		[FieldOffset(Offset = "0x50")]
		public UIEffectSprite FlagIcon;

		// Token: 0x0400F2D7 RID: 62167
		[Token(Token = "0x400F2D7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TeamId;

		// Token: 0x0400F2D8 RID: 62168
		[Token(Token = "0x400F2D8")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TeamName;

		// Token: 0x0400F2D9 RID: 62169
		[Token(Token = "0x400F2D9")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Name;

		// Token: 0x0400F2DA RID: 62170
		[Token(Token = "0x400F2DA")]
		[FieldOffset(Offset = "0x70")]
		public UISprite TeamBG;

		// Token: 0x0400F2DB RID: 62171
		[Token(Token = "0x400F2DB")]
		[FieldOffset(Offset = "0x78")]
		public UISprite HelmetBG;

		// Token: 0x0400F2DC RID: 62172
		[Token(Token = "0x400F2DC")]
		[FieldOffset(Offset = "0x80")]
		public UISprite FilledHelmet;

		// Token: 0x0400F2DD RID: 62173
		[Token(Token = "0x400F2DD")]
		[FieldOffset(Offset = "0x88")]
		public UISprite FilledHelmetEnhanced;

		// Token: 0x0400F2DE RID: 62174
		[Token(Token = "0x400F2DE")]
		[FieldOffset(Offset = "0x90")]
		public UISprite HelmetLevel;

		// Token: 0x0400F2DF RID: 62175
		[Token(Token = "0x400F2DF")]
		[FieldOffset(Offset = "0x98")]
		public UISprite ArmorBG;

		// Token: 0x0400F2E0 RID: 62176
		[Token(Token = "0x400F2E0")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite FilledArmor;

		// Token: 0x0400F2E1 RID: 62177
		[Token(Token = "0x400F2E1")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite FilledArmorEnhanced;

		// Token: 0x0400F2E2 RID: 62178
		[Token(Token = "0x400F2E2")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite ArmorLevel;

		// Token: 0x0400F2E3 RID: 62179
		[Token(Token = "0x400F2E3")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel MedkitCount;

		// Token: 0x0400F2E4 RID: 62180
		[Token(Token = "0x400F2E4")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel IceWallCount;

		// Token: 0x0400F2E5 RID: 62181
		[Token(Token = "0x400F2E5")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite icon;

		// Token: 0x0400F2E6 RID: 62182
		[Token(Token = "0x400F2E6")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel ItemCount;

		// Token: 0x0400F2E7 RID: 62183
		[Token(Token = "0x400F2E7")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel Kill;

		// Token: 0x0400F2E8 RID: 62184
		[Token(Token = "0x400F2E8")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite WeaponIcon;

		// Token: 0x0400F2E9 RID: 62185
		[Token(Token = "0x400F2E9")]
		[FieldOffset(Offset = "0xE8")]
		public Transform LeftAnchor;

		// Token: 0x0400F2EA RID: 62186
		[Token(Token = "0x400F2EA")]
		[FieldOffset(Offset = "0xF0")]
		public UIGrid Skills;

		// Token: 0x0400F2EB RID: 62187
		[Token(Token = "0x400F2EB")]
		[FieldOffset(Offset = "0xF8")]
		public UISPHudSkillItemView SkillTemplate;
	}
}
