using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002419 RID: 9241
	[Token(Token = "0x2002419")]
	internal class UIMallGiftSendSuccessView : UIBaseView
	{
		// Token: 0x0600C342 RID: 49986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C342")]
		[Address(RVA = "0x1C74260", Offset = "0x1C74260", VA = "0x7BBC474260", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C343 RID: 49987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C343")]
		[Address(RVA = "0x1C74380", Offset = "0x1C74380", VA = "0x7BBC474380")]
		public UIMallGiftSendSuccessView()
		{
		}

		// Token: 0x0400E4A5 RID: 58533
		[Token(Token = "0x400E4A5")]
		[FieldOffset(Offset = "0x20")]
		public Transform UIMallGiftSendSuccess;

		// Token: 0x0400E4A6 RID: 58534
		[Token(Token = "0x400E4A6")]
		[FieldOffset(Offset = "0x28")]
		public TweenColor tweenColor;

		// Token: 0x0400E4A7 RID: 58535
		[Token(Token = "0x400E4A7")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CloseBtn;
	}
}
