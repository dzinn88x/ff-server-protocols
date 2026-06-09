using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002233 RID: 8755
	[Token(Token = "0x2002233")]
	public class UIGameModeClassicMapListView : UIBaseView
	{
		// Token: 0x0600BF77 RID: 49015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF77")]
		[Address(RVA = "0x2004C24", Offset = "0x2004C24", VA = "0x7BBC804C24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF78")]
		[Address(RVA = "0x2005044", Offset = "0x2005044", VA = "0x7BBC805044")]
		public UIGameModeClassicMapListView()
		{
		}

		// Token: 0x0400D105 RID: 53509
		[Token(Token = "0x400D105")]
		[FieldOffset(Offset = "0x20")]
		public TweenAlpha paradiseAlpha;

		// Token: 0x0400D106 RID: 53510
		[Token(Token = "0x400D106")]
		[FieldOffset(Offset = "0x28")]
		public TweenScale paradiseScale;

		// Token: 0x0400D107 RID: 53511
		[Token(Token = "0x400D107")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton ParadiseBtn;

		// Token: 0x0400D108 RID: 53512
		[Token(Token = "0x400D108")]
		[FieldOffset(Offset = "0x38")]
		public GameObject paradiseclickEffect;

		// Token: 0x0400D109 RID: 53513
		[Token(Token = "0x400D109")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ModeSpriteParadise;

		// Token: 0x0400D10A RID: 53514
		[Token(Token = "0x400D10A")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture NetworkTextureParadise;

		// Token: 0x0400D10B RID: 53515
		[Token(Token = "0x400D10B")]
		[FieldOffset(Offset = "0x50")]
		public UILabel modeNameParadise;

		// Token: 0x0400D10C RID: 53516
		[Token(Token = "0x400D10C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject download;

		// Token: 0x0400D10D RID: 53517
		[Token(Token = "0x400D10D")]
		[FieldOffset(Offset = "0x60")]
		public TweenAlpha azoreAlpha;

		// Token: 0x0400D10E RID: 53518
		[Token(Token = "0x400D10E")]
		[FieldOffset(Offset = "0x68")]
		public TweenScale azoreScale;

		// Token: 0x0400D10F RID: 53519
		[Token(Token = "0x400D10F")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton AzoreBtn;

		// Token: 0x0400D110 RID: 53520
		[Token(Token = "0x400D110")]
		[FieldOffset(Offset = "0x78")]
		public GameObject azoreclickEffect;

		// Token: 0x0400D111 RID: 53521
		[Token(Token = "0x400D111")]
		[FieldOffset(Offset = "0x80")]
		public UISprite ModeSpriteAzore;

		// Token: 0x0400D112 RID: 53522
		[Token(Token = "0x400D112")]
		[FieldOffset(Offset = "0x88")]
		public UILabel modeNameAzore;

		// Token: 0x0400D113 RID: 53523
		[Token(Token = "0x400D113")]
		[FieldOffset(Offset = "0x90")]
		public UINetworkTexture NetworkTextureAzore;
	}
}
