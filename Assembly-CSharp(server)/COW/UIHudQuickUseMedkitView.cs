using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200233C RID: 9020
	[Token(Token = "0x200233C")]
	public class UIHudQuickUseMedkitView : UIBaseView
	{
		// Token: 0x0600C188 RID: 49544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C188")]
		[Address(RVA = "0x17E3EC4", Offset = "0x17E3EC4", VA = "0x7BBBFE3EC4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C189")]
		[Address(RVA = "0x17E41A4", Offset = "0x17E41A4", VA = "0x7BBBFE41A4")]
		public UIHudQuickUseMedkitView()
		{
		}

		// Token: 0x0400DA9B RID: 55963
		[Token(Token = "0x400DA9B")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnQuickUse;

		// Token: 0x0400DA9C RID: 55964
		[Token(Token = "0x400DA9C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UrgencyTipObj;

		// Token: 0x0400DA9D RID: 55965
		[Token(Token = "0x400DA9D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject PrepTimer;

		// Token: 0x0400DA9E RID: 55966
		[Token(Token = "0x400DA9E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimeLabel;

		// Token: 0x0400DA9F RID: 55967
		[Token(Token = "0x400DA9F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Progress;

		// Token: 0x0400DAA0 RID: 55968
		[Token(Token = "0x400DAA0")]
		[FieldOffset(Offset = "0x48")]
		public UILabel MedkitCount;

		// Token: 0x0400DAA1 RID: 55969
		[Token(Token = "0x400DAA1")]
		[FieldOffset(Offset = "0x50")]
		public UIWidget Icon;

		// Token: 0x0400DAA2 RID: 55970
		[Token(Token = "0x400DAA2")]
		[FieldOffset(Offset = "0x58")]
		public UISprite MedkitIcon;

		// Token: 0x0400DAA3 RID: 55971
		[Token(Token = "0x400DAA3")]
		[FieldOffset(Offset = "0x60")]
		public ParticleSystem FlashEffect;

		// Token: 0x0400DAA4 RID: 55972
		[Token(Token = "0x400DAA4")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Effect_VFX;
	}
}
