using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022BE RID: 8894
	[Token(Token = "0x20022BE")]
	internal class UIHudDynamicInfoPopupView : UIBaseView
	{
		// Token: 0x0600C08C RID: 49292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08C")]
		[Address(RVA = "0x1C00640", Offset = "0x1C00640", VA = "0x7BBC400640", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C08D")]
		[Address(RVA = "0x1C00730", Offset = "0x1C00730", VA = "0x7BBC400730")]
		public UIHudDynamicInfoPopupView()
		{
		}

		// Token: 0x0400D640 RID: 54848
		[Token(Token = "0x400D640")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Message;

		// Token: 0x0400D641 RID: 54849
		[Token(Token = "0x400D641")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;
	}
}
