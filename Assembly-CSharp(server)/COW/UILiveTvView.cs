using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023EB RID: 9195
	[Token(Token = "0x20023EB")]
	public class UILiveTvView : UIBaseView
	{
		// Token: 0x0600C2E6 RID: 49894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E6")]
		[Address(RVA = "0x1CC3E38", Offset = "0x1CC3E38", VA = "0x7BBC4C3E38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2E7")]
		[Address(RVA = "0x1CC4110", Offset = "0x1CC4110", VA = "0x7BBC4C4110")]
		public UILiveTvView()
		{
		}

		// Token: 0x0400E0F7 RID: 57591
		[Token(Token = "0x400E0F7")]
		[FieldOffset(Offset = "0x20")]
		public UITexture BG;

		// Token: 0x0400E0F8 RID: 57592
		[Token(Token = "0x400E0F8")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget WebViewArea;

		// Token: 0x0400E0F9 RID: 57593
		[Token(Token = "0x400E0F9")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton LiveTv;

		// Token: 0x0400E0FA RID: 57594
		[Token(Token = "0x400E0FA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LiveSelectLabel;

		// Token: 0x0400E0FB RID: 57595
		[Token(Token = "0x400E0FB")]
		[FieldOffset(Offset = "0x40")]
		public UILabel LiveUnSelectLabel;

		// Token: 0x0400E0FC RID: 57596
		[Token(Token = "0x400E0FC")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton BooyahTv;

		// Token: 0x0400E0FD RID: 57597
		[Token(Token = "0x400E0FD")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BooyahSelectLabel;

		// Token: 0x0400E0FE RID: 57598
		[Token(Token = "0x400E0FE")]
		[FieldOffset(Offset = "0x58")]
		public UILabel BooyahUnSelectLabel;

		// Token: 0x0400E0FF RID: 57599
		[Token(Token = "0x400E0FF")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnClose;

		// Token: 0x0400E100 RID: 57600
		[Token(Token = "0x400E100")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnRefresh;
	}
}
