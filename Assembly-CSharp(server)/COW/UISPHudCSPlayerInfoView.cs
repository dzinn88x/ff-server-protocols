using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002502 RID: 9474
	[Token(Token = "0x2002502")]
	public class UISPHudCSPlayerInfoView : UIBaseView
	{
		// Token: 0x0600C516 RID: 50454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C516")]
		[Address(RVA = "0x1EE12C0", Offset = "0x1EE12C0", VA = "0x7BBC6E12C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C517")]
		[Address(RVA = "0x1EE19D8", Offset = "0x1EE19D8", VA = "0x7BBC6E19D8")]
		public UISPHudCSPlayerInfoView()
		{
		}

		// Token: 0x0400F181 RID: 61825
		[Token(Token = "0x400F181")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EPNode;

		// Token: 0x0400F182 RID: 61826
		[Token(Token = "0x400F182")]
		[FieldOffset(Offset = "0x28")]
		public UISprite EPBar;

		// Token: 0x0400F183 RID: 61827
		[Token(Token = "0x400F183")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelHP;

		// Token: 0x0400F184 RID: 61828
		[Token(Token = "0x400F184")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HPBar;

		// Token: 0x0400F185 RID: 61829
		[Token(Token = "0x400F185")]
		[FieldOffset(Offset = "0x40")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F186 RID: 61830
		[Token(Token = "0x400F186")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F187 RID: 61831
		[Token(Token = "0x400F187")]
		[FieldOffset(Offset = "0x50")]
		public UIEffectSprite FlagIcon;

		// Token: 0x0400F188 RID: 61832
		[Token(Token = "0x400F188")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TeamId;

		// Token: 0x0400F189 RID: 61833
		[Token(Token = "0x400F189")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TeamName;

		// Token: 0x0400F18A RID: 61834
		[Token(Token = "0x400F18A")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Name;

		// Token: 0x0400F18B RID: 61835
		[Token(Token = "0x400F18B")]
		[FieldOffset(Offset = "0x70")]
		public UISprite NameBG;

		// Token: 0x0400F18C RID: 61836
		[Token(Token = "0x400F18C")]
		[FieldOffset(Offset = "0x78")]
		public UISprite TeamBG;

		// Token: 0x0400F18D RID: 61837
		[Token(Token = "0x400F18D")]
		[FieldOffset(Offset = "0x80")]
		public UISprite HelmetBG;

		// Token: 0x0400F18E RID: 61838
		[Token(Token = "0x400F18E")]
		[FieldOffset(Offset = "0x88")]
		public UISprite FilledHelmet;

		// Token: 0x0400F18F RID: 61839
		[Token(Token = "0x400F18F")]
		[FieldOffset(Offset = "0x90")]
		public UISprite FilledHelmetEnhanced;

		// Token: 0x0400F190 RID: 61840
		[Token(Token = "0x400F190")]
		[FieldOffset(Offset = "0x98")]
		public UISprite HelmetLevel;

		// Token: 0x0400F191 RID: 61841
		[Token(Token = "0x400F191")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite ArmorBG;

		// Token: 0x0400F192 RID: 61842
		[Token(Token = "0x400F192")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite FilledArmor;

		// Token: 0x0400F193 RID: 61843
		[Token(Token = "0x400F193")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite FilledArmorEnhanced;

		// Token: 0x0400F194 RID: 61844
		[Token(Token = "0x400F194")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite ArmorLevel;

		// Token: 0x0400F195 RID: 61845
		[Token(Token = "0x400F195")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel MedkitCount;

		// Token: 0x0400F196 RID: 61846
		[Token(Token = "0x400F196")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel IceWallCount;

		// Token: 0x0400F197 RID: 61847
		[Token(Token = "0x400F197")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel SmokeBombCount;

		// Token: 0x0400F198 RID: 61848
		[Token(Token = "0x400F198")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel GrenadeCount;

		// Token: 0x0400F199 RID: 61849
		[Token(Token = "0x400F199")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel Kill;

		// Token: 0x0400F19A RID: 61850
		[Token(Token = "0x400F19A")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel LabelKDA;

		// Token: 0x0400F19B RID: 61851
		[Token(Token = "0x400F19B")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite WeaponIcon;

		// Token: 0x0400F19C RID: 61852
		[Token(Token = "0x400F19C")]
		[FieldOffset(Offset = "0xF8")]
		public Transform LeftAnchor;

		// Token: 0x0400F19D RID: 61853
		[Token(Token = "0x400F19D")]
		[FieldOffset(Offset = "0x100")]
		public UIGrid Skills;

		// Token: 0x0400F19E RID: 61854
		[Token(Token = "0x400F19E")]
		[FieldOffset(Offset = "0x108")]
		public UISPHudSkillItemView SkillTemplate;
	}
}
