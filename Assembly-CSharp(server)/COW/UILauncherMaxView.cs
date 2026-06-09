using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D4 RID: 9172
	[Token(Token = "0x20023D4")]
	public class UILauncherMaxView : UIBaseView
	{
		// Token: 0x0600C2B8 RID: 49848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B8")]
		[Address(RVA = "0x1E26A84", Offset = "0x1E26A84", VA = "0x7BBC626A84", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B9")]
		[Address(RVA = "0x1E26CD0", Offset = "0x1E26CD0", VA = "0x7BBC626CD0")]
		public UILauncherMaxView()
		{
		}

		// Token: 0x0400DF79 RID: 57209
		[Token(Token = "0x400DF79")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainWidget;

		// Token: 0x0400DF7A RID: 57210
		[Token(Token = "0x400DF7A")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel FullScreenRect;

		// Token: 0x0400DF7B RID: 57211
		[Token(Token = "0x400DF7B")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture CDNBG;

		// Token: 0x0400DF7C RID: 57212
		[Token(Token = "0x400DF7C")]
		[FieldOffset(Offset = "0x38")]
		public UIButton GotoWebsiteBtn;

		// Token: 0x0400DF7D RID: 57213
		[Token(Token = "0x400DF7D")]
		[FieldOffset(Offset = "0x40")]
		public UIButton MaxDownloadBtn;

		// Token: 0x0400DF7E RID: 57214
		[Token(Token = "0x400DF7E")]
		[FieldOffset(Offset = "0x48")]
		public UIButton NormalUpdateBtn;

		// Token: 0x0400DF7F RID: 57215
		[Token(Token = "0x400DF7F")]
		[FieldOffset(Offset = "0x50")]
		public UIButton GotoVideoBtn;

		// Token: 0x0400DF80 RID: 57216
		[Token(Token = "0x400DF80")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CloseBtn;
	}
}
