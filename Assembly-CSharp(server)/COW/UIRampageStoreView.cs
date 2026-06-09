using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024BE RID: 9406
	[Token(Token = "0x20024BE")]
	public class UIRampageStoreView : UIBaseView
	{
		// Token: 0x0600C48C RID: 50316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48C")]
		[Address(RVA = "0x1E08D2C", Offset = "0x1E08D2C", VA = "0x7BBC608D2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C48D")]
		[Address(RVA = "0x1E09360", Offset = "0x1E09360", VA = "0x7BBC609360")]
		public UIRampageStoreView()
		{
		}

		// Token: 0x0400EF1F RID: 61215
		[Token(Token = "0x400EF1F")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid TogglesGrid;

		// Token: 0x0400EF20 RID: 61216
		[Token(Token = "0x400EF20")]
		[FieldOffset(Offset = "0x28")]
		public UIToggleButtonGroup ToggleButtonGroup;

		// Token: 0x0400EF21 RID: 61217
		[Token(Token = "0x400EF21")]
		[FieldOffset(Offset = "0x30")]
		public Animation AnimationScale;

		// Token: 0x0400EF22 RID: 61218
		[Token(Token = "0x400EF22")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Toggle;

		// Token: 0x0400EF23 RID: 61219
		[Token(Token = "0x400EF23")]
		[FieldOffset(Offset = "0x40")]
		public UIToggleButton ToggleBtn;

		// Token: 0x0400EF24 RID: 61220
		[Token(Token = "0x400EF24")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture Texture;

		// Token: 0x0400EF25 RID: 61221
		[Token(Token = "0x400EF25")]
		[FieldOffset(Offset = "0x50")]
		public GameObject EffectShine;

		// Token: 0x0400EF26 RID: 61222
		[Token(Token = "0x400EF26")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Light;

		// Token: 0x0400EF27 RID: 61223
		[Token(Token = "0x400EF27")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Lock;

		// Token: 0x0400EF28 RID: 61224
		[Token(Token = "0x400EF28")]
		[FieldOffset(Offset = "0x68")]
		public GameObject UnLockAnim;

		// Token: 0x0400EF29 RID: 61225
		[Token(Token = "0x400EF29")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Mask;

		// Token: 0x0400EF2A RID: 61226
		[Token(Token = "0x400EF2A")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView ScrollView;

		// Token: 0x0400EF2B RID: 61227
		[Token(Token = "0x400EF2B")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList EasyList;

		// Token: 0x0400EF2C RID: 61228
		[Token(Token = "0x400EF2C")]
		[FieldOffset(Offset = "0x88")]
		public GameObject LockTips;

		// Token: 0x0400EF2D RID: 61229
		[Token(Token = "0x400EF2D")]
		[FieldOffset(Offset = "0x90")]
		public GameObject LockTipsIcon;

		// Token: 0x0400EF2E RID: 61230
		[Token(Token = "0x400EF2E")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LockTipsLabel;

		// Token: 0x0400EF2F RID: 61231
		[Token(Token = "0x400EF2F")]
		[FieldOffset(Offset = "0xA0")]
		public UINetworkTexture TitleTexture;

		// Token: 0x0400EF30 RID: 61232
		[Token(Token = "0x400EF30")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnRule;

		// Token: 0x0400EF31 RID: 61233
		[Token(Token = "0x400EF31")]
		[FieldOffset(Offset = "0xB0")]
		public Transform CountDownTimeContainer;

		// Token: 0x0400EF32 RID: 61234
		[Token(Token = "0x400EF32")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton TimeBtn;

		// Token: 0x0400EF33 RID: 61235
		[Token(Token = "0x400EF33")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel LabelDate;

		// Token: 0x0400EF34 RID: 61236
		[Token(Token = "0x400EF34")]
		[FieldOffset(Offset = "0xC8")]
		public UINetworkTexture BGTexture;

		// Token: 0x0400EF35 RID: 61237
		[Token(Token = "0x400EF35")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton Token;

		// Token: 0x0400EF36 RID: 61238
		[Token(Token = "0x400EF36")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite TokenIcon;

		// Token: 0x0400EF37 RID: 61239
		[Token(Token = "0x400EF37")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel TokenNum;
	}
}
