using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002113 RID: 8467
	[Token(Token = "0x2002113")]
	public class UIAwakenRefreshTaskConfirmWndView : UIBaseView
	{
		// Token: 0x0600BD37 RID: 48439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD37")]
		[Address(RVA = "0x141C6E8", Offset = "0x141C6E8", VA = "0x7BBBC1C6E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD38 RID: 48440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD38")]
		[Address(RVA = "0x141C808", Offset = "0x141C808", VA = "0x7BBBC1C808")]
		public UIAwakenRefreshTaskConfirmWndView()
		{
		}

		// Token: 0x0400C1C1 RID: 49601
		[Token(Token = "0x400C1C1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CancelBtn;

		// Token: 0x0400C1C2 RID: 49602
		[Token(Token = "0x400C1C2")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;

		// Token: 0x0400C1C3 RID: 49603
		[Token(Token = "0x400C1C3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;
	}
}
