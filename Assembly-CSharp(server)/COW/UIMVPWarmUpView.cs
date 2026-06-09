using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002452 RID: 9298
	[Token(Token = "0x2002452")]
	public class UIMVPWarmUpView : UIBaseView
	{
		// Token: 0x0600C3B4 RID: 50100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B4")]
		[Address(RVA = "0x1CDE1F0", Offset = "0x1CDE1F0", VA = "0x7BBC4DE1F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B5")]
		[Address(RVA = "0x1CDE38C", Offset = "0x1CDE38C", VA = "0x7BBC4DE38C")]
		public UIMVPWarmUpView()
		{
		}

		// Token: 0x0400E84A RID: 59466
		[Token(Token = "0x400E84A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnWinnerClose;

		// Token: 0x0400E84B RID: 59467
		[Token(Token = "0x400E84B")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt CdnTexture;

		// Token: 0x0400E84C RID: 59468
		[Token(Token = "0x400E84C")]
		[FieldOffset(Offset = "0x30")]
		public Transform CountDownContainer;

		// Token: 0x0400E84D RID: 59469
		[Token(Token = "0x400E84D")]
		[FieldOffset(Offset = "0x38")]
		public UICountDownLabel WarmUpLabel;

		// Token: 0x0400E84E RID: 59470
		[Token(Token = "0x400E84E")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTextureExt CdnChar;
	}
}
