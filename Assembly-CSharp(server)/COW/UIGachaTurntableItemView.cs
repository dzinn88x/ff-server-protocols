using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200222D RID: 8749
	[Token(Token = "0x200222D")]
	public class UIGachaTurntableItemView : UIBaseView
	{
		// Token: 0x0600BF6B RID: 49003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6B")]
		[Address(RVA = "0x1FAF87C", Offset = "0x1FAF87C", VA = "0x7BBC7AF87C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6C")]
		[Address(RVA = "0x1FAFCD0", Offset = "0x1FAFCD0", VA = "0x7BBC7AFCD0")]
		public UIGachaTurntableItemView()
		{
		}

		// Token: 0x0400D086 RID: 53382
		[Token(Token = "0x400D086")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIGachaTurntableItem;

		// Token: 0x0400D087 RID: 53383
		[Token(Token = "0x400D087")]
		[FieldOffset(Offset = "0x28")]
		public Animation Animation;

		// Token: 0x0400D088 RID: 53384
		[Token(Token = "0x400D088")]
		[FieldOffset(Offset = "0x30")]
		public TweenAlpha AnimAlpha;

		// Token: 0x0400D089 RID: 53385
		[Token(Token = "0x400D089")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ItemInfoContainer;

		// Token: 0x0400D08A RID: 53386
		[Token(Token = "0x400D08A")]
		[FieldOffset(Offset = "0x40")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400D08B RID: 53387
		[Token(Token = "0x400D08B")]
		[FieldOffset(Offset = "0x48")]
		public TweenScale AnimScale;

		// Token: 0x0400D08C RID: 53388
		[Token(Token = "0x400D08C")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SelectedBG;

		// Token: 0x0400D08D RID: 53389
		[Token(Token = "0x400D08D")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnTip;

		// Token: 0x0400D08E RID: 53390
		[Token(Token = "0x400D08E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite QualityBG;

		// Token: 0x0400D08F RID: 53391
		[Token(Token = "0x400D08F")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Quality;

		// Token: 0x0400D090 RID: 53392
		[Token(Token = "0x400D090")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ObtainedSprite;

		// Token: 0x0400D091 RID: 53393
		[Token(Token = "0x400D091")]
		[FieldOffset(Offset = "0x78")]
		public GameObject LimitTimeLabel;

		// Token: 0x0400D092 RID: 53394
		[Token(Token = "0x400D092")]
		[FieldOffset(Offset = "0x80")]
		public UILabel DropUpLabel;

		// Token: 0x0400D093 RID: 53395
		[Token(Token = "0x400D093")]
		[FieldOffset(Offset = "0x88")]
		public GameObject FlickerEffect;

		// Token: 0x0400D094 RID: 53396
		[Token(Token = "0x400D094")]
		[FieldOffset(Offset = "0x90")]
		public GameObject SeniorVFX;

		// Token: 0x0400D095 RID: 53397
		[Token(Token = "0x400D095")]
		[FieldOffset(Offset = "0x98")]
		public GameObject JuniorVFX;
	}
}
