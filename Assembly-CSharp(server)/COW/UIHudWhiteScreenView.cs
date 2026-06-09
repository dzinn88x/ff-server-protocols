using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B9 RID: 9145
	[Token(Token = "0x20023B9")]
	internal class UIHudWhiteScreenView : UIBaseView
	{
		// Token: 0x0600C282 RID: 49794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C282")]
		[Address(RVA = "0x1D2175C", Offset = "0x1D2175C", VA = "0x7BBC52175C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C283 RID: 49795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C283")]
		[Address(RVA = "0x1D2184C", Offset = "0x1D2184C", VA = "0x7BBC52184C")]
		public UIHudWhiteScreenView()
		{
		}

		// Token: 0x0400DE3A RID: 56890
		[Token(Token = "0x400DE3A")]
		[FieldOffset(Offset = "0x20")]
		public UISprite WhiteSprite;

		// Token: 0x0400DE3B RID: 56891
		[Token(Token = "0x400DE3B")]
		[FieldOffset(Offset = "0x28")]
		public UITexture ScreenTexture;
	}
}
