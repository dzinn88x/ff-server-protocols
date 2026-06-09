using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D5 RID: 9173
	[Token(Token = "0x20023D5")]
	public class UILauncherPopupMessageView : UIBaseView
	{
		// Token: 0x0600C2BA RID: 49850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BA")]
		[Address(RVA = "0x1E29078", Offset = "0x1E29078", VA = "0x7BBC629078", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2BB")]
		[Address(RVA = "0x1E296F8", Offset = "0x1E296F8", VA = "0x7BBC6296F8")]
		public UILauncherPopupMessageView()
		{
		}

		// Token: 0x0400DF81 RID: 57217
		[Token(Token = "0x400DF81")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel MainWidget;

		// Token: 0x0400DF82 RID: 57218
		[Token(Token = "0x400DF82")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel FullScreenRect;

		// Token: 0x0400DF83 RID: 57219
		[Token(Token = "0x400DF83")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VersionNode;

		// Token: 0x0400DF84 RID: 57220
		[Token(Token = "0x400DF84")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDNList;

		// Token: 0x0400DF85 RID: 57221
		[Token(Token = "0x400DF85")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView CDNScrollView;

		// Token: 0x0400DF86 RID: 57222
		[Token(Token = "0x400DF86")]
		[FieldOffset(Offset = "0x48")]
		public UINetworkTexture CdnTextureInstance;

		// Token: 0x0400DF87 RID: 57223
		[Token(Token = "0x400DF87")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid CDNGrid;

		// Token: 0x0400DF88 RID: 57224
		[Token(Token = "0x400DF88")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid DotGrid;

		// Token: 0x0400DF89 RID: 57225
		[Token(Token = "0x400DF89")]
		[FieldOffset(Offset = "0x60")]
		public UIWidget WebView;

		// Token: 0x0400DF8A RID: 57226
		[Token(Token = "0x400DF8A")]
		[FieldOffset(Offset = "0x68")]
		public UINetworkTexture BillboardCDNBG;

		// Token: 0x0400DF8B RID: 57227
		[Token(Token = "0x400DF8B")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnPatchNote;

		// Token: 0x0400DF8C RID: 57228
		[Token(Token = "0x400DF8C")]
		[FieldOffset(Offset = "0x78")]
		public UILabel BtnPatchLabel;

		// Token: 0x0400DF8D RID: 57229
		[Token(Token = "0x400DF8D")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BtnOKGO;

		// Token: 0x0400DF8E RID: 57230
		[Token(Token = "0x400DF8E")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnOK;

		// Token: 0x0400DF8F RID: 57231
		[Token(Token = "0x400DF8F")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BtnOKLabel;

		// Token: 0x0400DF90 RID: 57232
		[Token(Token = "0x400DF90")]
		[FieldOffset(Offset = "0x98")]
		public GameObject MaxHint;

		// Token: 0x0400DF91 RID: 57233
		[Token(Token = "0x400DF91")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject UpdateLabel;

		// Token: 0x0400DF92 RID: 57234
		[Token(Token = "0x400DF92")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel UpdateInfo;

		// Token: 0x0400DF93 RID: 57235
		[Token(Token = "0x400DF93")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject TextInfo;

		// Token: 0x0400DF94 RID: 57236
		[Token(Token = "0x400DF94")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel Info;

		// Token: 0x0400DF95 RID: 57237
		[Token(Token = "0x400DF95")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel Title;

		// Token: 0x0400DF96 RID: 57238
		[Token(Token = "0x400DF96")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject MaintenancePic;

		// Token: 0x0400DF97 RID: 57239
		[Token(Token = "0x400DF97")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject ErrorPic;

		// Token: 0x0400DF98 RID: 57240
		[Token(Token = "0x400DF98")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject UpdatePic;

		// Token: 0x0400DF99 RID: 57241
		[Token(Token = "0x400DF99")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton TxtInfoOkBtn;

		// Token: 0x0400DF9A RID: 57242
		[Token(Token = "0x400DF9A")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel TxtInfoOkLabel;
	}
}
