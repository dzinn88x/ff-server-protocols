using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002567 RID: 9575
	[Token(Token = "0x2002567")]
	public class UISuperCarTokenAccWndView : UIBaseView
	{
		// Token: 0x0600C5DE RID: 50654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DE")]
		[Address(RVA = "0x1F42734", Offset = "0x1F42734", VA = "0x7BBC742734", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5DF")]
		[Address(RVA = "0x1F42B98", Offset = "0x1F42B98", VA = "0x7BBC742B98")]
		public UISuperCarTokenAccWndView()
		{
		}

		// Token: 0x0400F574 RID: 62836
		[Token(Token = "0x400F574")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnUseToken;

		// Token: 0x0400F575 RID: 62837
		[Token(Token = "0x400F575")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CurSpeedLabel;

		// Token: 0x0400F576 RID: 62838
		[Token(Token = "0x400F576")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CurSpeedSprite;

		// Token: 0x0400F577 RID: 62839
		[Token(Token = "0x400F577")]
		[FieldOffset(Offset = "0x38")]
		public UISprite AccSpeedSprite;

		// Token: 0x0400F578 RID: 62840
		[Token(Token = "0x400F578")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MaxSpeedLabel;

		// Token: 0x0400F579 RID: 62841
		[Token(Token = "0x400F579")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CanNotAcc;

		// Token: 0x0400F57A RID: 62842
		[Token(Token = "0x400F57A")]
		[FieldOffset(Offset = "0x50")]
		public UILabel HaveNoTokenLabel;

		// Token: 0x0400F57B RID: 62843
		[Token(Token = "0x400F57B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SliderRelated;

		// Token: 0x0400F57C RID: 62844
		[Token(Token = "0x400F57C")]
		[FieldOffset(Offset = "0x60")]
		public UILabel TokenLabel;

		// Token: 0x0400F57D RID: 62845
		[Token(Token = "0x400F57D")]
		[FieldOffset(Offset = "0x68")]
		public UISettingSliderItem TokenAccSlider;

		// Token: 0x0400F57E RID: 62846
		[Token(Token = "0x400F57E")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnAddToken;

		// Token: 0x0400F57F RID: 62847
		[Token(Token = "0x400F57F")]
		[FieldOffset(Offset = "0x78")]
		public UISprite AddTokenSprite;

		// Token: 0x0400F580 RID: 62848
		[Token(Token = "0x400F580")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnDecToken;

		// Token: 0x0400F581 RID: 62849
		[Token(Token = "0x400F581")]
		[FieldOffset(Offset = "0x88")]
		public UISprite DecTokenSprite;

		// Token: 0x0400F582 RID: 62850
		[Token(Token = "0x400F582")]
		[FieldOffset(Offset = "0x90")]
		public UILabel CurAccSpeed;

		// Token: 0x0400F583 RID: 62851
		[Token(Token = "0x400F583")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TokenAccMaxLabel;

		// Token: 0x0400F584 RID: 62852
		[Token(Token = "0x400F584")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton RightMask;
	}
}
