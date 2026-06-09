using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200222F RID: 8751
	[Token(Token = "0x200222F")]
	internal class UIGainItemPreviewView : UIBaseView
	{
		// Token: 0x0600BF6F RID: 49007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF6F")]
		[Address(RVA = "0x1FF9C00", Offset = "0x1FF9C00", VA = "0x7BBC7F9C00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF70")]
		[Address(RVA = "0x1FF9FD8", Offset = "0x1FF9FD8", VA = "0x7BBC7F9FD8")]
		public UIGainItemPreviewView()
		{
		}

		// Token: 0x0400D0B0 RID: 53424
		[Token(Token = "0x400D0B0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400D0B1 RID: 53425
		[Token(Token = "0x400D0B1")]
		[FieldOffset(Offset = "0x28")]
		public UIButton btnClose;

		// Token: 0x0400D0B2 RID: 53426
		[Token(Token = "0x400D0B2")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ScreenshotTopBanner;

		// Token: 0x0400D0B3 RID: 53427
		[Token(Token = "0x400D0B3")]
		[FieldOffset(Offset = "0x38")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400D0B4 RID: 53428
		[Token(Token = "0x400D0B4")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HeadshotDefault;

		// Token: 0x0400D0B5 RID: 53429
		[Token(Token = "0x400D0B5")]
		[FieldOffset(Offset = "0x48")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400D0B6 RID: 53430
		[Token(Token = "0x400D0B6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PlayerNickname;

		// Token: 0x0400D0B7 RID: 53431
		[Token(Token = "0x400D0B7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PlayerID;

		// Token: 0x0400D0B8 RID: 53432
		[Token(Token = "0x400D0B8")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ShareBtn;

		// Token: 0x0400D0B9 RID: 53433
		[Token(Token = "0x400D0B9")]
		[FieldOffset(Offset = "0x68")]
		public Animator ShareIconAnimator;

		// Token: 0x0400D0BA RID: 53434
		[Token(Token = "0x400D0BA")]
		[FieldOffset(Offset = "0x70")]
		public UIButton leaveBtn;

		// Token: 0x0400D0BB RID: 53435
		[Token(Token = "0x400D0BB")]
		[FieldOffset(Offset = "0x78")]
		public UISprite iconBg;

		// Token: 0x0400D0BC RID: 53436
		[Token(Token = "0x400D0BC")]
		[FieldOffset(Offset = "0x80")]
		public UISprite ItemIcon;

		// Token: 0x0400D0BD RID: 53437
		[Token(Token = "0x400D0BD")]
		[FieldOffset(Offset = "0x88")]
		public UIWidget PreViewCommonContainer;
	}
}
