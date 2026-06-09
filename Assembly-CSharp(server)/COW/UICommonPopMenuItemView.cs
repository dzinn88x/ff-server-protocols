using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002180 RID: 8576
	[Token(Token = "0x2002180")]
	public class UICommonPopMenuItemView : UIBaseView
	{
		// Token: 0x0600BE10 RID: 48656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE10")]
		[Address(RVA = "0x1803D48", Offset = "0x1803D48", VA = "0x7BBC003D48", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE11 RID: 48657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE11")]
		[Address(RVA = "0x1803DE4", Offset = "0x1803DE4", VA = "0x7BBC003DE4")]
		public UICommonPopMenuItemView()
		{
		}

		// Token: 0x0400C791 RID: 51089
		[Token(Token = "0x400C791")]
		[FieldOffset(Offset = "0x20")]
		public PopMenuItemView View;
	}
}
