using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023C1 RID: 9153
	[Token(Token = "0x20023C1")]
	public class UIImageSharePreviewWindowView : UIBaseView
	{
		// Token: 0x0600C292 RID: 49810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C292")]
		[Address(RVA = "0x139019C", Offset = "0x139019C", VA = "0x7BBBB9019C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C293")]
		[Address(RVA = "0x1390824", Offset = "0x1390824", VA = "0x7BBBB90824")]
		public UIImageSharePreviewWindowView()
		{
		}

		// Token: 0x0400DE9C RID: 56988
		[Token(Token = "0x400DE9C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400DE9D RID: 56989
		[Token(Token = "0x400DE9D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClosePortrait;

		// Token: 0x0400DE9E RID: 56990
		[Token(Token = "0x400DE9E")]
		[FieldOffset(Offset = "0x30")]
		public UISprite bg;

		// Token: 0x0400DE9F RID: 56991
		[Token(Token = "0x400DE9F")]
		[FieldOffset(Offset = "0x38")]
		public Transform ShareBtnGroupContainer;

		// Token: 0x0400DEA0 RID: 56992
		[Token(Token = "0x400DEA0")]
		[FieldOffset(Offset = "0x40")]
		public Transform LandscapeGroup;

		// Token: 0x0400DEA1 RID: 56993
		[Token(Token = "0x400DEA1")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnDownloadToAlbum;

		// Token: 0x0400DEA2 RID: 56994
		[Token(Token = "0x400DEA2")]
		[FieldOffset(Offset = "0x50")]
		public UIButton CopyShareLink;

		// Token: 0x0400DEA3 RID: 56995
		[Token(Token = "0x400DEA3")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid Grid;

		// Token: 0x0400DEA4 RID: 56996
		[Token(Token = "0x400DEA4")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ShareHint;

		// Token: 0x0400DEA5 RID: 56997
		[Token(Token = "0x400DEA5")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnLineShare;

		// Token: 0x0400DEA6 RID: 56998
		[Token(Token = "0x400DEA6")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnFBShare;

		// Token: 0x0400DEA7 RID: 56999
		[Token(Token = "0x400DEA7")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnVKShare;

		// Token: 0x0400DEA8 RID: 57000
		[Token(Token = "0x400DEA8")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnGarenaShare;

		// Token: 0x0400DEA9 RID: 57001
		[Token(Token = "0x400DEA9")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnOtherShare;

		// Token: 0x0400DEAA RID: 57002
		[Token(Token = "0x400DEAA")]
		[FieldOffset(Offset = "0x90")]
		public Transform PortraitGroup;

		// Token: 0x0400DEAB RID: 57003
		[Token(Token = "0x400DEAB")]
		[FieldOffset(Offset = "0x98")]
		public UIButton CopyShareLink_P;

		// Token: 0x0400DEAC RID: 57004
		[Token(Token = "0x400DEAC")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnDownloadToAlbum_P;

		// Token: 0x0400DEAD RID: 57005
		[Token(Token = "0x400DEAD")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid Grid_P;

		// Token: 0x0400DEAE RID: 57006
		[Token(Token = "0x400DEAE")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BtnLineShare_P;

		// Token: 0x0400DEAF RID: 57007
		[Token(Token = "0x400DEAF")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnFBShare_P;

		// Token: 0x0400DEB0 RID: 57008
		[Token(Token = "0x400DEB0")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton BtnVKShare_P;

		// Token: 0x0400DEB1 RID: 57009
		[Token(Token = "0x400DEB1")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton BtnGarenaShare_P;

		// Token: 0x0400DEB2 RID: 57010
		[Token(Token = "0x400DEB2")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton BtnOtherShare_P;

		// Token: 0x0400DEB3 RID: 57011
		[Token(Token = "0x400DEB3")]
		[FieldOffset(Offset = "0xD8")]
		public UITexture SharePreview;

		// Token: 0x0400DEB4 RID: 57012
		[Token(Token = "0x400DEB4")]
		[FieldOffset(Offset = "0xE0")]
		public UIPanel TipsPanel;

		// Token: 0x0400DEB5 RID: 57013
		[Token(Token = "0x400DEB5")]
		[FieldOffset(Offset = "0xE8")]
		public TweenAlpha TipsTween;

		// Token: 0x0400DEB6 RID: 57014
		[Token(Token = "0x400DEB6")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel TipTxt;
	}
}
