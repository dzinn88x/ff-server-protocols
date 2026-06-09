using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002191 RID: 8593
	[Token(Token = "0x2002191")]
	public class UICustomRoomCountDownWindowView : UIBaseView
	{
		// Token: 0x0600BE32 RID: 48690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE32")]
		[Address(RVA = "0x1BAB098", Offset = "0x1BAB098", VA = "0x7BBC3AB098", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE33")]
		[Address(RVA = "0x1BAB134", Offset = "0x1BAB134", VA = "0x7BBC3AB134")]
		public UICustomRoomCountDownWindowView()
		{
		}

		// Token: 0x0400C84C RID: 51276
		[Token(Token = "0x400C84C")]
		[FieldOffset(Offset = "0x20")]
		public UILabel CountDownLabel;
	}
}
