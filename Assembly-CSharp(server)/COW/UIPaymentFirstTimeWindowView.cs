using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002474 RID: 9332
	[Token(Token = "0x2002474")]
	public class UIPaymentFirstTimeWindowView : UIBaseView
	{
		// Token: 0x0600C3F8 RID: 50168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F8")]
		[Address(RVA = "0x1F2505C", Offset = "0x1F2505C", VA = "0x7BBC72505C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3F9 RID: 50169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F9")]
		[Address(RVA = "0x1F2517C", Offset = "0x1F2517C", VA = "0x7BBC72517C")]
		public UIPaymentFirstTimeWindowView()
		{
		}

		// Token: 0x0400EA2C RID: 59948
		[Token(Token = "0x400EA2C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400EA2D RID: 59949
		[Token(Token = "0x400EA2D")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt BackgroundTexture;

		// Token: 0x0400EA2E RID: 59950
		[Token(Token = "0x400EA2E")]
		[FieldOffset(Offset = "0x30")]
		public UIButton GotoButton;
	}
}
