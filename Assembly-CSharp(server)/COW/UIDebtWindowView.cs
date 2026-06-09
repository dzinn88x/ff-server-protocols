using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002197 RID: 8599
	[Token(Token = "0x2002197")]
	internal class UIDebtWindowView : UIBaseView
	{
		// Token: 0x0600BE3E RID: 48702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3E")]
		[Address(RVA = "0x1BB0518", Offset = "0x1BB0518", VA = "0x7BBC3B0518", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE3F")]
		[Address(RVA = "0x1BB0608", Offset = "0x1BB0608", VA = "0x7BBC3B0608")]
		public UIDebtWindowView()
		{
		}

		// Token: 0x0400C8B4 RID: 51380
		[Token(Token = "0x400C8B4")]
		[FieldOffset(Offset = "0x20")]
		public UILabel DebtNumLabel;

		// Token: 0x0400C8B5 RID: 51381
		[Token(Token = "0x400C8B5")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ChargeBtn;
	}
}
