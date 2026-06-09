using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002546 RID: 9542
	[Token(Token = "0x2002546")]
	public class UISplashBannerItemCDNView : UIBaseView
	{
		// Token: 0x0600C59C RID: 50588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59C")]
		[Address(RVA = "0x16394C4", Offset = "0x16394C4", VA = "0x7BBBE394C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C59D RID: 50589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C59D")]
		[Address(RVA = "0x16396B4", Offset = "0x16396B4", VA = "0x7BBBE396B4")]
		public UISplashBannerItemCDNView()
		{
		}

		// Token: 0x0400F42A RID: 62506
		[Token(Token = "0x400F42A")]
		[FieldOffset(Offset = "0x20")]
		public TweenScale ItemTween;

		// Token: 0x0400F42B RID: 62507
		[Token(Token = "0x400F42B")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel WebViewPanel;

		// Token: 0x0400F42C RID: 62508
		[Token(Token = "0x400F42C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Title;

		// Token: 0x0400F42D RID: 62509
		[Token(Token = "0x400F42D")]
		[FieldOffset(Offset = "0x38")]
		public UIButton close;

		// Token: 0x0400F42E RID: 62510
		[Token(Token = "0x400F42E")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture NetworkTextureContent;

		// Token: 0x0400F42F RID: 62511
		[Token(Token = "0x400F42F")]
		[FieldOffset(Offset = "0x48")]
		public UIButton NetworkTextureContentButton;
	}
}
