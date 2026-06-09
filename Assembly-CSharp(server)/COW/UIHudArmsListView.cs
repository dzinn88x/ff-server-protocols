using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002263 RID: 8803
	[Token(Token = "0x2002263")]
	public class UIHudArmsListView : UIBaseView
	{
		// Token: 0x0600BFD7 RID: 49111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD7")]
		[Address(RVA = "0x18857DC", Offset = "0x18857DC", VA = "0x7BBC0857DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFD8")]
		[Address(RVA = "0x18858FC", Offset = "0x18858FC", VA = "0x7BBC0858FC")]
		public UIHudArmsListView()
		{
		}

		// Token: 0x0400D365 RID: 54117
		[Token(Token = "0x400D365")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Confirm;

		// Token: 0x0400D366 RID: 54118
		[Token(Token = "0x400D366")]
		[FieldOffset(Offset = "0x28")]
		public UILabel CountDown;

		// Token: 0x0400D367 RID: 54119
		[Token(Token = "0x400D367")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;
	}
}
