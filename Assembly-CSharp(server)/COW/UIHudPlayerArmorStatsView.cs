using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232C RID: 9004
	[Token(Token = "0x200232C")]
	public class UIHudPlayerArmorStatsView : UIBaseView
	{
		// Token: 0x0600C168 RID: 49512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C168")]
		[Address(RVA = "0x1D7B4D4", Offset = "0x1D7B4D4", VA = "0x7BBC57B4D4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C169")]
		[Address(RVA = "0x1D7B8CC", Offset = "0x1D7B8CC", VA = "0x7BBC57B8CC")]
		public UIHudPlayerArmorStatsView()
		{
		}

		// Token: 0x0400DA46 RID: 55878
		[Token(Token = "0x400DA46")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HelmetBG;

		// Token: 0x0400DA47 RID: 55879
		[Token(Token = "0x400DA47")]
		[FieldOffset(Offset = "0x28")]
		public UISprite FilledHelmet;

		// Token: 0x0400DA48 RID: 55880
		[Token(Token = "0x400DA48")]
		[FieldOffset(Offset = "0x30")]
		public UISprite FilledHelmetEnhanced;

		// Token: 0x0400DA49 RID: 55881
		[Token(Token = "0x400DA49")]
		[FieldOffset(Offset = "0x38")]
		public UISprite HelmetLevel;

		// Token: 0x0400DA4A RID: 55882
		[Token(Token = "0x400DA4A")]
		[FieldOffset(Offset = "0x40")]
		public TweenAlpha HelmetDurabilityRecoverEffect;

		// Token: 0x0400DA4B RID: 55883
		[Token(Token = "0x400DA4B")]
		[FieldOffset(Offset = "0x48")]
		public UILabel HelmetBuffCountLabel;

		// Token: 0x0400DA4C RID: 55884
		[Token(Token = "0x400DA4C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArmorBG;

		// Token: 0x0400DA4D RID: 55885
		[Token(Token = "0x400DA4D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite FilledArmor;

		// Token: 0x0400DA4E RID: 55886
		[Token(Token = "0x400DA4E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite FilledArmorEnhanced;

		// Token: 0x0400DA4F RID: 55887
		[Token(Token = "0x400DA4F")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ArmorLevel;

		// Token: 0x0400DA50 RID: 55888
		[Token(Token = "0x400DA50")]
		[FieldOffset(Offset = "0x70")]
		public TweenAlpha ArmorDurabilityRecoverEffect;

		// Token: 0x0400DA51 RID: 55889
		[Token(Token = "0x400DA51")]
		[FieldOffset(Offset = "0x78")]
		public UILabel VestBuffCountLabel;

		// Token: 0x0400DA52 RID: 55890
		[Token(Token = "0x400DA52")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget UseWidget;

		// Token: 0x0400DA53 RID: 55891
		[Token(Token = "0x400DA53")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnQuickUse;

		// Token: 0x0400DA54 RID: 55892
		[Token(Token = "0x400DA54")]
		[FieldOffset(Offset = "0x90")]
		public ParticleSystem FlashEffect;
	}
}
