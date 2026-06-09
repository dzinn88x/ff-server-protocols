using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025A1 RID: 9633
	[Token(Token = "0x20025A1")]
	public class UIWebViewWindowView : UIBaseView
	{
		// Token: 0x0600C652 RID: 50770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C652")]
		[Address(RVA = "0x1788564", Offset = "0x1788564", VA = "0x7BBBF88564", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C653")]
		[Address(RVA = "0x1788844", Offset = "0x1788844", VA = "0x7BBBF88844")]
		public UIWebViewWindowView()
		{
		}

		// Token: 0x0400F882 RID: 63618
		[Token(Token = "0x400F882")]
		[FieldOffset(Offset = "0x20")]
		public UISprite WebViewArea;

		// Token: 0x0400F883 RID: 63619
		[Token(Token = "0x400F883")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ProgressLabel;

		// Token: 0x0400F884 RID: 63620
		[Token(Token = "0x400F884")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LoadingGIF;

		// Token: 0x0400F885 RID: 63621
		[Token(Token = "0x400F885")]
		[FieldOffset(Offset = "0x38")]
		public UIProgressBar WebViewProgressBar;

		// Token: 0x0400F886 RID: 63622
		[Token(Token = "0x400F886")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget WebViewProgressBarThumb;

		// Token: 0x0400F887 RID: 63623
		[Token(Token = "0x400F887")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CloseButton;

		// Token: 0x0400F888 RID: 63624
		[Token(Token = "0x400F888")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ExternalButton;

		// Token: 0x0400F889 RID: 63625
		[Token(Token = "0x400F889")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ReloadButton;

		// Token: 0x0400F88A RID: 63626
		[Token(Token = "0x400F88A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ReloadTips;

		// Token: 0x0400F88B RID: 63627
		[Token(Token = "0x400F88B")]
		[FieldOffset(Offset = "0x68")]
		public UILabel ReloadLabel;
	}
}
