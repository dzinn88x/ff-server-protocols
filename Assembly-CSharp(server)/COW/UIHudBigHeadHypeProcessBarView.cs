using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002279 RID: 8825
	[Token(Token = "0x2002279")]
	public class UIHudBigHeadHypeProcessBarView : UIBaseView
	{
		// Token: 0x0600C003 RID: 49155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C003")]
		[Address(RVA = "0x189397C", Offset = "0x189397C", VA = "0x7BBC09397C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C004 RID: 49156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C004")]
		[Address(RVA = "0x1893E68", Offset = "0x1893E68", VA = "0x7BBC093E68")]
		public UIHudBigHeadHypeProcessBarView()
		{
		}

		// Token: 0x0400D3DE RID: 54238
		[Token(Token = "0x400D3DE")]
		[FieldOffset(Offset = "0x20")]
		public UILabel HypeValueTxt;

		// Token: 0x0400D3DF RID: 54239
		[Token(Token = "0x400D3DF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SliderContainer;

		// Token: 0x0400D3E0 RID: 54240
		[Token(Token = "0x400D3E0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ArrowUp;

		// Token: 0x0400D3E1 RID: 54241
		[Token(Token = "0x400D3E1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ArrowDown;

		// Token: 0x0400D3E2 RID: 54242
		[Token(Token = "0x400D3E2")]
		[FieldOffset(Offset = "0x40")]
		public Transform ProcessSliderBg0;

		// Token: 0x0400D3E3 RID: 54243
		[Token(Token = "0x400D3E3")]
		[FieldOffset(Offset = "0x48")]
		public Transform ProcessSliderBg1;

		// Token: 0x0400D3E4 RID: 54244
		[Token(Token = "0x400D3E4")]
		[FieldOffset(Offset = "0x50")]
		public Transform ProcessSliderBg2;

		// Token: 0x0400D3E5 RID: 54245
		[Token(Token = "0x400D3E5")]
		[FieldOffset(Offset = "0x58")]
		public Transform ProcessSliderBg3;

		// Token: 0x0400D3E6 RID: 54246
		[Token(Token = "0x400D3E6")]
		[FieldOffset(Offset = "0x60")]
		public Transform ProcessSliderBg4;

		// Token: 0x0400D3E7 RID: 54247
		[Token(Token = "0x400D3E7")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ProcessSlider;

		// Token: 0x0400D3E8 RID: 54248
		[Token(Token = "0x400D3E8")]
		[FieldOffset(Offset = "0x70")]
		public Transform movingFrame;

		// Token: 0x0400D3E9 RID: 54249
		[Token(Token = "0x400D3E9")]
		[FieldOffset(Offset = "0x78")]
		public ParticleSystem HypeIncreasingEffect;

		// Token: 0x0400D3EA RID: 54250
		[Token(Token = "0x400D3EA")]
		[FieldOffset(Offset = "0x80")]
		public Transform lv1pos;

		// Token: 0x0400D3EB RID: 54251
		[Token(Token = "0x400D3EB")]
		[FieldOffset(Offset = "0x88")]
		public Transform lv2pos;

		// Token: 0x0400D3EC RID: 54252
		[Token(Token = "0x400D3EC")]
		[FieldOffset(Offset = "0x90")]
		public Transform lv3pos;

		// Token: 0x0400D3ED RID: 54253
		[Token(Token = "0x400D3ED")]
		[FieldOffset(Offset = "0x98")]
		public Transform lv4pos;

		// Token: 0x0400D3EE RID: 54254
		[Token(Token = "0x400D3EE")]
		[FieldOffset(Offset = "0xA0")]
		public Transform lv5pos;

		// Token: 0x0400D3EF RID: 54255
		[Token(Token = "0x400D3EF")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem LevelUpEffect;

		// Token: 0x0400D3F0 RID: 54256
		[Token(Token = "0x400D3F0")]
		[FieldOffset(Offset = "0xB0")]
		public Transform MaxHypeLevelEffect;

		// Token: 0x0400D3F1 RID: 54257
		[Token(Token = "0x400D3F1")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SnowManCloth;
	}
}
