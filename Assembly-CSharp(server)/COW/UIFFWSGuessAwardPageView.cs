using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E2 RID: 8674
	[Token(Token = "0x20021E2")]
	public class UIFFWSGuessAwardPageView : UIBaseView
	{
		// Token: 0x0600BED5 RID: 48853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED5")]
		[Address(RVA = "0x2274B38", Offset = "0x2274B38", VA = "0x7BBCA74B38", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BED6")]
		[Address(RVA = "0x2274E20", Offset = "0x2274E20", VA = "0x7BBCA74E20")]
		public UIFFWSGuessAwardPageView()
		{
		}

		// Token: 0x0400CC23 RID: 52259
		[Token(Token = "0x400CC23")]
		[FieldOffset(Offset = "0x20")]
		public Animation AnimationEntrance;

		// Token: 0x0400CC24 RID: 52260
		[Token(Token = "0x400CC24")]
		[FieldOffset(Offset = "0x28")]
		public Transform TrCloseMask;

		// Token: 0x0400CC25 RID: 52261
		[Token(Token = "0x400CC25")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;

		// Token: 0x0400CC26 RID: 52262
		[Token(Token = "0x400CC26")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelCloseTip;

		// Token: 0x0400CC27 RID: 52263
		[Token(Token = "0x400CC27")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt TextureLoseTitleCDN;

		// Token: 0x0400CC28 RID: 52264
		[Token(Token = "0x400CC28")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelLoseDesc;

		// Token: 0x0400CC29 RID: 52265
		[Token(Token = "0x400CC29")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid GridLoseAwards;

		// Token: 0x0400CC2A RID: 52266
		[Token(Token = "0x400CC2A")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTextureExt TextureWinTitleCDN;

		// Token: 0x0400CC2B RID: 52267
		[Token(Token = "0x400CC2B")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelWinDesc;

		// Token: 0x0400CC2C RID: 52268
		[Token(Token = "0x400CC2C")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid GridWinAwards;
	}
}
