using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002548 RID: 9544
	[Token(Token = "0x2002548")]
	public class UISplashBannerItemVideoView : UIBaseView
	{
		// Token: 0x0600C5A0 RID: 50592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A0")]
		[Address(RVA = "0x163AEF0", Offset = "0x163AEF0", VA = "0x7BBBE3AEF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5A1 RID: 50593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5A1")]
		[Address(RVA = "0x163B118", Offset = "0x163B118", VA = "0x7BBBE3B118")]
		public UISplashBannerItemVideoView()
		{
		}

		// Token: 0x0400F441 RID: 62529
		[Token(Token = "0x400F441")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400F442 RID: 62530
		[Token(Token = "0x400F442")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel WebViewPanel;

		// Token: 0x0400F443 RID: 62531
		[Token(Token = "0x400F443")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Content;

		// Token: 0x0400F444 RID: 62532
		[Token(Token = "0x400F444")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Title;

		// Token: 0x0400F445 RID: 62533
		[Token(Token = "0x400F445")]
		[FieldOffset(Offset = "0x40")]
		public UIButton CloseBtn;

		// Token: 0x0400F446 RID: 62534
		[Token(Token = "0x400F446")]
		[FieldOffset(Offset = "0x48")]
		public UISprite WebViewArea;

		// Token: 0x0400F447 RID: 62535
		[Token(Token = "0x400F447")]
		[FieldOffset(Offset = "0x50")]
		public UIButton GotoBtn;
	}
}
