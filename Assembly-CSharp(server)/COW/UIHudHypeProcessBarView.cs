using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022E6 RID: 8934
	[Token(Token = "0x20022E6")]
	public class UIHudHypeProcessBarView : UIBaseView
	{
		// Token: 0x0600C0DC RID: 49372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DC")]
		[Address(RVA = "0x19844C0", Offset = "0x19844C0", VA = "0x7BBC1844C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0DD")]
		[Address(RVA = "0x1984B18", Offset = "0x1984B18", VA = "0x7BBC184B18")]
		public UIHudHypeProcessBarView()
		{
		}

		// Token: 0x0400D708 RID: 55048
		[Token(Token = "0x400D708")]
		[FieldOffset(Offset = "0x20")]
		public UILabel HypeValueTxt;

		// Token: 0x0400D709 RID: 55049
		[Token(Token = "0x400D709")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SliderContainer;

		// Token: 0x0400D70A RID: 55050
		[Token(Token = "0x400D70A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ArrowUp;

		// Token: 0x0400D70B RID: 55051
		[Token(Token = "0x400D70B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ArrowDown;

		// Token: 0x0400D70C RID: 55052
		[Token(Token = "0x400D70C")]
		[FieldOffset(Offset = "0x40")]
		public Transform ProcessSliderBg0;

		// Token: 0x0400D70D RID: 55053
		[Token(Token = "0x400D70D")]
		[FieldOffset(Offset = "0x48")]
		public Transform ProcessSliderBg1;

		// Token: 0x0400D70E RID: 55054
		[Token(Token = "0x400D70E")]
		[FieldOffset(Offset = "0x50")]
		public Transform ProcessSliderBg2;

		// Token: 0x0400D70F RID: 55055
		[Token(Token = "0x400D70F")]
		[FieldOffset(Offset = "0x58")]
		public Transform ProcessSliderBg3;

		// Token: 0x0400D710 RID: 55056
		[Token(Token = "0x400D710")]
		[FieldOffset(Offset = "0x60")]
		public Transform ProcessSliderBg4;

		// Token: 0x0400D711 RID: 55057
		[Token(Token = "0x400D711")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ProcessSlider;

		// Token: 0x0400D712 RID: 55058
		[Token(Token = "0x400D712")]
		[FieldOffset(Offset = "0x70")]
		public Transform movingFrame;

		// Token: 0x0400D713 RID: 55059
		[Token(Token = "0x400D713")]
		[FieldOffset(Offset = "0x78")]
		public ParticleSystem HypeIncreasingEffect;

		// Token: 0x0400D714 RID: 55060
		[Token(Token = "0x400D714")]
		[FieldOffset(Offset = "0x80")]
		public Transform lv1pos;

		// Token: 0x0400D715 RID: 55061
		[Token(Token = "0x400D715")]
		[FieldOffset(Offset = "0x88")]
		public Transform lv2pos;

		// Token: 0x0400D716 RID: 55062
		[Token(Token = "0x400D716")]
		[FieldOffset(Offset = "0x90")]
		public Transform lv3pos;

		// Token: 0x0400D717 RID: 55063
		[Token(Token = "0x400D717")]
		[FieldOffset(Offset = "0x98")]
		public Transform lv4pos;

		// Token: 0x0400D718 RID: 55064
		[Token(Token = "0x400D718")]
		[FieldOffset(Offset = "0xA0")]
		public Transform lv5pos;

		// Token: 0x0400D719 RID: 55065
		[Token(Token = "0x400D719")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem LevelUpEffect;

		// Token: 0x0400D71A RID: 55066
		[Token(Token = "0x400D71A")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject DevideLine;

		// Token: 0x0400D71B RID: 55067
		[Token(Token = "0x400D71B")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SnowManCloth;

		// Token: 0x0400D71C RID: 55068
		[Token(Token = "0x400D71C")]
		[FieldOffset(Offset = "0xC0")]
		public Transform Down;

		// Token: 0x0400D71D RID: 55069
		[Token(Token = "0x400D71D")]
		[FieldOffset(Offset = "0xC8")]
		public Transform Up;

		// Token: 0x0400D71E RID: 55070
		[Token(Token = "0x400D71E")]
		[FieldOffset(Offset = "0xD0")]
		public Transform All;

		// Token: 0x0400D71F RID: 55071
		[Token(Token = "0x400D71F")]
		[FieldOffset(Offset = "0xD8")]
		public Transform MaxHypeLevelEffect;

		// Token: 0x0400D720 RID: 55072
		[Token(Token = "0x400D720")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject BallRadiusBarContainer;

		// Token: 0x0400D721 RID: 55073
		[Token(Token = "0x400D721")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite BallRadiusBar;

		// Token: 0x0400D722 RID: 55074
		[Token(Token = "0x400D722")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite Ball;
	}
}
