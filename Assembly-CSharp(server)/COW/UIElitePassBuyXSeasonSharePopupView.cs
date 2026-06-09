using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021B1 RID: 8625
	[Token(Token = "0x20021B1")]
	internal class UIElitePassBuyXSeasonSharePopupView : UIBaseView
	{
		// Token: 0x0600BE72 RID: 48754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE72")]
		[Address(RVA = "0x1ADDBF8", Offset = "0x1ADDBF8", VA = "0x7BBC2DDBF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE73 RID: 48755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE73")]
		[Address(RVA = "0x1ADDFB8", Offset = "0x1ADDFB8", VA = "0x7BBC2DDFB8")]
		public UIElitePassBuyXSeasonSharePopupView()
		{
		}

		// Token: 0x0400C9D8 RID: 51672
		[Token(Token = "0x400C9D8")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture BgTexture;

		// Token: 0x0400C9D9 RID: 51673
		[Token(Token = "0x400C9D9")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ScreenshotTopBanner;

		// Token: 0x0400C9DA RID: 51674
		[Token(Token = "0x400C9DA")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400C9DB RID: 51675
		[Token(Token = "0x400C9DB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HeadshotDefault;

		// Token: 0x0400C9DC RID: 51676
		[Token(Token = "0x400C9DC")]
		[FieldOffset(Offset = "0x40")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400C9DD RID: 51677
		[Token(Token = "0x400C9DD")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PlayerNickname;

		// Token: 0x0400C9DE RID: 51678
		[Token(Token = "0x400C9DE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PlayerID;

		// Token: 0x0400C9DF RID: 51679
		[Token(Token = "0x400C9DF")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ScreenShotLine;

		// Token: 0x0400C9E0 RID: 51680
		[Token(Token = "0x400C9E0")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ScreenShotBg;

		// Token: 0x0400C9E1 RID: 51681
		[Token(Token = "0x400C9E1")]
		[FieldOffset(Offset = "0x68")]
		public UILabel CurEPLabel;

		// Token: 0x0400C9E2 RID: 51682
		[Token(Token = "0x400C9E2")]
		[FieldOffset(Offset = "0x70")]
		public UILabel BuySeasonLabel;

		// Token: 0x0400C9E3 RID: 51683
		[Token(Token = "0x400C9E3")]
		[FieldOffset(Offset = "0x78")]
		public UIButton ShareBtn;

		// Token: 0x0400C9E4 RID: 51684
		[Token(Token = "0x400C9E4")]
		[FieldOffset(Offset = "0x80")]
		public Animator ShareIconAnimator;

		// Token: 0x0400C9E5 RID: 51685
		[Token(Token = "0x400C9E5")]
		[FieldOffset(Offset = "0x88")]
		public UIButton CloseBtn;
	}
}
