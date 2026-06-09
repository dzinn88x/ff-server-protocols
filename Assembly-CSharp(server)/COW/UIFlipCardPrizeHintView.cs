using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F3 RID: 8691
	[Token(Token = "0x20021F3")]
	internal class UIFlipCardPrizeHintView : UIBaseView
	{
		// Token: 0x0600BEF7 RID: 48887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF7")]
		[Address(RVA = "0x1DB81F0", Offset = "0x1DB81F0", VA = "0x7BBC5B81F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEF8")]
		[Address(RVA = "0x1DB82E0", Offset = "0x1DB82E0", VA = "0x7BBC5B82E0")]
		public UIFlipCardPrizeHintView()
		{
		}

		// Token: 0x0400CD4D RID: 52557
		[Token(Token = "0x400CD4D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CloseBtn;

		// Token: 0x0400CD4E RID: 52558
		[Token(Token = "0x400CD4E")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture Texture;
	}
}
