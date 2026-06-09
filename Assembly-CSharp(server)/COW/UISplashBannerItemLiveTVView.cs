using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002547 RID: 9543
	[Token(Token = "0x2002547")]
	public class UISplashBannerItemLiveTVView : UIBaseView
	{
		// Token: 0x0600C59E RID: 50590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59E")]
		[Address(RVA = "0x163A454", Offset = "0x163A454", VA = "0x7BBBE3A454", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C59F RID: 50591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59F")]
		[Address(RVA = "0x163A900", Offset = "0x163A900", VA = "0x7BBBE3A900")]
		public UISplashBannerItemLiveTVView()
		{
		}

		// Token: 0x0400F430 RID: 62512
		[Token(Token = "0x400F430")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400F431 RID: 62513
		[Token(Token = "0x400F431")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel WebViewPanel;

		// Token: 0x0400F432 RID: 62514
		[Token(Token = "0x400F432")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;

		// Token: 0x0400F433 RID: 62515
		[Token(Token = "0x400F433")]
		[FieldOffset(Offset = "0x38")]
		public TweenScale ScaleTween;

		// Token: 0x0400F434 RID: 62516
		[Token(Token = "0x400F434")]
		[FieldOffset(Offset = "0x40")]
		public TweenPosition PosTween;

		// Token: 0x0400F435 RID: 62517
		[Token(Token = "0x400F435")]
		[FieldOffset(Offset = "0x48")]
		public UIPanel ContainerPanel;

		// Token: 0x0400F436 RID: 62518
		[Token(Token = "0x400F436")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Title;

		// Token: 0x0400F437 RID: 62519
		[Token(Token = "0x400F437")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BG;

		// Token: 0x0400F438 RID: 62520
		[Token(Token = "0x400F438")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTexture NetworkTextureBG;

		// Token: 0x0400F439 RID: 62521
		[Token(Token = "0x400F439")]
		[FieldOffset(Offset = "0x68")]
		public GameObject Content;

		// Token: 0x0400F43A RID: 62522
		[Token(Token = "0x400F43A")]
		[FieldOffset(Offset = "0x70")]
		public UIButton LiveCloseBtn;

		// Token: 0x0400F43B RID: 62523
		[Token(Token = "0x400F43B")]
		[FieldOffset(Offset = "0x78")]
		public UIButton DetailBtn;

		// Token: 0x0400F43C RID: 62524
		[Token(Token = "0x400F43C")]
		[FieldOffset(Offset = "0x80")]
		public UIWidget DetailBtnWidget;

		// Token: 0x0400F43D RID: 62525
		[Token(Token = "0x400F43D")]
		[FieldOffset(Offset = "0x88")]
		public UIButton FullScreenPlayBtn;

		// Token: 0x0400F43E RID: 62526
		[Token(Token = "0x400F43E")]
		[FieldOffset(Offset = "0x90")]
		public UIWidget FullScreenBtnWidget;

		// Token: 0x0400F43F RID: 62527
		[Token(Token = "0x400F43F")]
		[FieldOffset(Offset = "0x98")]
		public UIWidget LiveWebViewWidget;

		// Token: 0x0400F440 RID: 62528
		[Token(Token = "0x400F440")]
		[FieldOffset(Offset = "0xA0")]
		public UINetworkTexture liveBgTexture;
	}
}
