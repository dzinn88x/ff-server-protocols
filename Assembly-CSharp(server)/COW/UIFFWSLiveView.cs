using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021E7 RID: 8679
	[Token(Token = "0x20021E7")]
	public class UIFFWSLiveView : UIBaseView
	{
		// Token: 0x0600BEDF RID: 48863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEDF")]
		[Address(RVA = "0x227DE0C", Offset = "0x227DE0C", VA = "0x7BBCA7DE0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEE0")]
		[Address(RVA = "0x227E070", Offset = "0x227E070", VA = "0x7BBCA7E070")]
		public UIFFWSLiveView()
		{
		}

		// Token: 0x0400CC7C RID: 52348
		[Token(Token = "0x400CC7C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400CC7D RID: 52349
		[Token(Token = "0x400CC7D")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnRule;

		// Token: 0x0400CC7E RID: 52350
		[Token(Token = "0x400CC7E")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTextureExt TextureTitleCDN;

		// Token: 0x0400CC7F RID: 52351
		[Token(Token = "0x400CC7F")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnGoToGuess;

		// Token: 0x0400CC80 RID: 52352
		[Token(Token = "0x400CC80")]
		[FieldOffset(Offset = "0x40")]
		public Transform TrCountDownRoot;

		// Token: 0x0400CC81 RID: 52353
		[Token(Token = "0x400CC81")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelLiveTip;

		// Token: 0x0400CC82 RID: 52354
		[Token(Token = "0x400CC82")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnGoToWeb;

		// Token: 0x0400CC83 RID: 52355
		[Token(Token = "0x400CC83")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTexture TextureCDN;
	}
}
