using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002211 RID: 8721
	[Token(Token = "0x2002211")]
	public class UIGachaFeatureView : UIBaseView
	{
		// Token: 0x0600BF33 RID: 48947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF33")]
		[Address(RVA = "0x205601C", Offset = "0x205601C", VA = "0x7BBC85601C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF34")]
		[Address(RVA = "0x205651C", Offset = "0x205651C", VA = "0x7BBC85651C")]
		public UIGachaFeatureView()
		{
		}

		// Token: 0x0400CEBD RID: 52925
		[Token(Token = "0x400CEBD")]
		[FieldOffset(Offset = "0x20")]
		public Animator ShowFeatureAnim;

		// Token: 0x0400CEBE RID: 52926
		[Token(Token = "0x400CEBE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject UIContent;

		// Token: 0x0400CEBF RID: 52927
		[Token(Token = "0x400CEBF")]
		[FieldOffset(Offset = "0x30")]
		public UIButton Mask;

		// Token: 0x0400CEC0 RID: 52928
		[Token(Token = "0x400CEC0")]
		[FieldOffset(Offset = "0x38")]
		public UITexture GachaFeature_Bg;

		// Token: 0x0400CEC1 RID: 52929
		[Token(Token = "0x400CEC1")]
		[FieldOffset(Offset = "0x40")]
		public GameObject InterfaceMask;

		// Token: 0x0400CEC2 RID: 52930
		[Token(Token = "0x400CEC2")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ItemShow;

		// Token: 0x0400CEC3 RID: 52931
		[Token(Token = "0x400CEC3")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ItemInfoContainer;

		// Token: 0x0400CEC4 RID: 52932
		[Token(Token = "0x400CEC4")]
		[FieldOffset(Offset = "0x58")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400CEC5 RID: 52933
		[Token(Token = "0x400CEC5")]
		[FieldOffset(Offset = "0x60")]
		public UIButton SkipMask;

		// Token: 0x0400CEC6 RID: 52934
		[Token(Token = "0x400CEC6")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Bottom_btn;

		// Token: 0x0400CEC7 RID: 52935
		[Token(Token = "0x400CEC7")]
		[FieldOffset(Offset = "0x70")]
		public UIButton ShareBtn;

		// Token: 0x0400CEC8 RID: 52936
		[Token(Token = "0x400CEC8")]
		[FieldOffset(Offset = "0x78")]
		public Animator ShareIconAnimator;

		// Token: 0x0400CEC9 RID: 52937
		[Token(Token = "0x400CEC9")]
		[FieldOffset(Offset = "0x80")]
		public UIButton OkBtn;

		// Token: 0x0400CECA RID: 52938
		[Token(Token = "0x400CECA")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ItemNameLabel;

		// Token: 0x0400CECB RID: 52939
		[Token(Token = "0x400CECB")]
		[FieldOffset(Offset = "0x90")]
		public UISprite IPTag;

		// Token: 0x0400CECC RID: 52940
		[Token(Token = "0x400CECC")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ItemNameVioLabel;

		// Token: 0x0400CECD RID: 52941
		[Token(Token = "0x400CECD")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite IPTagVio;

		// Token: 0x0400CECE RID: 52942
		[Token(Token = "0x400CECE")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ItemNameRedLabel;

		// Token: 0x0400CECF RID: 52943
		[Token(Token = "0x400CECF")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite IPRedTag;
	}
}
