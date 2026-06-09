using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002390 RID: 9104
	[Token(Token = "0x2002390")]
	internal class UIHudTurnRightView : UIBaseView
	{
		// Token: 0x0600C230 RID: 49712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C230")]
		[Address(RVA = "0x15ED608", Offset = "0x15ED608", VA = "0x7BBBDED608", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C231")]
		[Address(RVA = "0x15ED6F8", Offset = "0x15ED6F8", VA = "0x7BBBDED6F8")]
		public UIHudTurnRightView()
		{
		}

		// Token: 0x0400DD07 RID: 56583
		[Token(Token = "0x400DD07")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnTurnRight;

		// Token: 0x0400DD08 RID: 56584
		[Token(Token = "0x400DD08")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BtnName;
	}
}
