using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002230 RID: 8752
	[Token(Token = "0x2002230")]
	internal class UIGameModeBaseItemView : UIBaseView
	{
		// Token: 0x0600BF71 RID: 49009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF71")]
		[Address(RVA = "0x1FFD37C", Offset = "0x1FFD37C", VA = "0x7BBC7FD37C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF72")]
		[Address(RVA = "0x1FFD7C0", Offset = "0x1FFD7C0", VA = "0x7BBC7FD7C0")]
		public UIGameModeBaseItemView()
		{
		}

		// Token: 0x0400D0BE RID: 53438
		[Token(Token = "0x400D0BE")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton ModeBtn;

		// Token: 0x0400D0BF RID: 53439
		[Token(Token = "0x400D0BF")]
		[FieldOffset(Offset = "0x28")]
		public Transform ModeInfo;

		// Token: 0x0400D0C0 RID: 53440
		[Token(Token = "0x400D0C0")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ModeSprite;

		// Token: 0x0400D0C1 RID: 53441
		[Token(Token = "0x400D0C1")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture NetworkTexture;

		// Token: 0x0400D0C2 RID: 53442
		[Token(Token = "0x400D0C2")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture UINetworkTexture02;

		// Token: 0x0400D0C3 RID: 53443
		[Token(Token = "0x400D0C3")]
		[FieldOffset(Offset = "0x48")]
		public Transform TopLeft;

		// Token: 0x0400D0C4 RID: 53444
		[Token(Token = "0x400D0C4")]
		[FieldOffset(Offset = "0x50")]
		public TweenScale TweenObjScale;

		// Token: 0x0400D0C5 RID: 53445
		[Token(Token = "0x400D0C5")]
		[FieldOffset(Offset = "0x58")]
		public TweenAlpha TweenObjAlpha;

		// Token: 0x0400D0C6 RID: 53446
		[Token(Token = "0x400D0C6")]
		[FieldOffset(Offset = "0x60")]
		public UIPanel TweenObjPanel;

		// Token: 0x0400D0C7 RID: 53447
		[Token(Token = "0x400D0C7")]
		[FieldOffset(Offset = "0x68")]
		public GameObject loadingSprite;

		// Token: 0x0400D0C8 RID: 53448
		[Token(Token = "0x400D0C8")]
		[FieldOffset(Offset = "0x70")]
		public UITexture clippedNetworkTexture;

		// Token: 0x0400D0C9 RID: 53449
		[Token(Token = "0x400D0C9")]
		[FieldOffset(Offset = "0x78")]
		public GameObject clickEffect;

		// Token: 0x0400D0CA RID: 53450
		[Token(Token = "0x400D0CA")]
		[FieldOffset(Offset = "0x80")]
		public GameObject download;

		// Token: 0x0400D0CB RID: 53451
		[Token(Token = "0x400D0CB")]
		[FieldOffset(Offset = "0x88")]
		public UIPanel liveEffectsPanel;

		// Token: 0x0400D0CC RID: 53452
		[Token(Token = "0x400D0CC")]
		[FieldOffset(Offset = "0x90")]
		public GameObject bg;

		// Token: 0x0400D0CD RID: 53453
		[Token(Token = "0x400D0CD")]
		[FieldOffset(Offset = "0x98")]
		public UIPanel panelOverLiveEffects;
	}
}
