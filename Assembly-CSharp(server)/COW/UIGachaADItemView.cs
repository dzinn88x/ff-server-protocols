using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002205 RID: 8709
	[Token(Token = "0x2002205")]
	internal class UIGachaADItemView : UIBaseView
	{
		// Token: 0x0600BF1B RID: 48923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1B")]
		[Address(RVA = "0x214F8AC", Offset = "0x214F8AC", VA = "0x7BBC94F8AC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF1C")]
		[Address(RVA = "0x214F9CC", Offset = "0x214F9CC", VA = "0x7BBC94F9CC")]
		public UIGachaADItemView()
		{
		}

		// Token: 0x0400CE48 RID: 52808
		[Token(Token = "0x400CE48")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIGachaADItem;

		// Token: 0x0400CE49 RID: 52809
		[Token(Token = "0x400CE49")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Default;

		// Token: 0x0400CE4A RID: 52810
		[Token(Token = "0x400CE4A")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture NetworkTexture;
	}
}
