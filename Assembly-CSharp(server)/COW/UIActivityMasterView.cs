using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E2 RID: 8418
	[Token(Token = "0x20020E2")]
	public class UIActivityMasterView : UIBaseView
	{
		// Token: 0x0600BCD5 RID: 48341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD5")]
		[Address(RVA = "0x1956520", Offset = "0x1956520", VA = "0x7BBC156520", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCD6 RID: 48342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCD6")]
		[Address(RVA = "0x1956694", Offset = "0x1956694", VA = "0x7BBC156694")]
		public UIActivityMasterView()
		{
		}

		// Token: 0x0400BF1B RID: 48923
		[Token(Token = "0x400BF1B")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTexture BGCDN;

		// Token: 0x0400BF1C RID: 48924
		[Token(Token = "0x400BF1C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite BG;

		// Token: 0x0400BF1D RID: 48925
		[Token(Token = "0x400BF1D")]
		[FieldOffset(Offset = "0x30")]
		public Transform TopTabContainer;

		// Token: 0x0400BF1E RID: 48926
		[Token(Token = "0x400BF1E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Content;
	}
}
