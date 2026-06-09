using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E4 RID: 8676
	[Token(Token = "0x20021E4")]
	public class UIFFWSGuessTeamItemView : UIBaseView
	{
		// Token: 0x0600BED9 RID: 48857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED9")]
		[Address(RVA = "0x227B420", Offset = "0x227B420", VA = "0x7BBCA7B420", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEDA RID: 48858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDA")]
		[Address(RVA = "0x227B9B8", Offset = "0x227B9B8", VA = "0x7BBCA7B9B8")]
		public UIFFWSGuessTeamItemView()
		{
		}

		// Token: 0x0400CC31 RID: 52273
		[Token(Token = "0x400CC31")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIFFWSGuessTeamItem;

		// Token: 0x0400CC32 RID: 52274
		[Token(Token = "0x400CC32")]
		[FieldOffset(Offset = "0x28")]
		public Transform TrContent;

		// Token: 0x0400CC33 RID: 52275
		[Token(Token = "0x400CC33")]
		[FieldOffset(Offset = "0x30")]
		public Animation AnimationTeamPick;

		// Token: 0x0400CC34 RID: 52276
		[Token(Token = "0x400CC34")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnTeamChoose;

		// Token: 0x0400CC35 RID: 52277
		[Token(Token = "0x400CC35")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt TextureTeamIconCDN;

		// Token: 0x0400CC36 RID: 52278
		[Token(Token = "0x400CC36")]
		[FieldOffset(Offset = "0x48")]
		public TweenAlpha TweenAlphaBreathe;

		// Token: 0x0400CC37 RID: 52279
		[Token(Token = "0x400CC37")]
		[FieldOffset(Offset = "0x50")]
		public UILabel LabelTeamName;

		// Token: 0x0400CC38 RID: 52280
		[Token(Token = "0x400CC38")]
		[FieldOffset(Offset = "0x58")]
		public Transform TrAIPick;

		// Token: 0x0400CC39 RID: 52281
		[Token(Token = "0x400CC39")]
		[FieldOffset(Offset = "0x60")]
		public Transform TrPlayerPick;

		// Token: 0x0400CC3A RID: 52282
		[Token(Token = "0x400CC3A")]
		[FieldOffset(Offset = "0x68")]
		public UIMaskEffectSprite SpritePlayerHeadIcon;

		// Token: 0x0400CC3B RID: 52283
		[Token(Token = "0x400CC3B")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnTeamDetail;

		// Token: 0x0400CC3C RID: 52284
		[Token(Token = "0x400CC3C")]
		[FieldOffset(Offset = "0x78")]
		public UISprite SpriteTeamDetailPick;

		// Token: 0x0400CC3D RID: 52285
		[Token(Token = "0x400CC3D")]
		[FieldOffset(Offset = "0x80")]
		public UISprite SpriteTeamDetailUnpick;

		// Token: 0x0400CC3E RID: 52286
		[Token(Token = "0x400CC3E")]
		[FieldOffset(Offset = "0x88")]
		public Animation AnimationBreathe;

		// Token: 0x0400CC3F RID: 52287
		[Token(Token = "0x400CC3F")]
		[FieldOffset(Offset = "0x90")]
		public Animation AnimationAIPick;

		// Token: 0x0400CC40 RID: 52288
		[Token(Token = "0x400CC40")]
		[FieldOffset(Offset = "0x98")]
		public Animation AnimationPlayerPick;

		// Token: 0x0400CC41 RID: 52289
		[Token(Token = "0x400CC41")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LabelPoint;

		// Token: 0x0400CC42 RID: 52290
		[Token(Token = "0x400CC42")]
		[FieldOffset(Offset = "0xA8")]
		public TweenAlpha TweenAlphaLabelPoint;

		// Token: 0x0400CC43 RID: 52291
		[Token(Token = "0x400CC43")]
		[FieldOffset(Offset = "0xB0")]
		public Transform VFX_Computer;

		// Token: 0x0400CC44 RID: 52292
		[Token(Token = "0x400CC44")]
		[FieldOffset(Offset = "0xB8")]
		public Transform VFX_Player;

		// Token: 0x0400CC45 RID: 52293
		[Token(Token = "0x400CC45")]
		[FieldOffset(Offset = "0xC0")]
		public Transform VFX_Remind;

		// Token: 0x0400CC46 RID: 52294
		[Token(Token = "0x400CC46")]
		[FieldOffset(Offset = "0xC8")]
		public Transform TrPlayerPickTemp;
	}
}
