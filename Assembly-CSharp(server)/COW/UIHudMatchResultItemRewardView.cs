using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002312 RID: 8978
	[Token(Token = "0x2002312")]
	public class UIHudMatchResultItemRewardView : UIBaseView
	{
		// Token: 0x0600C134 RID: 49460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C134")]
		[Address(RVA = "0x17ABD58", Offset = "0x17ABD58", VA = "0x7BBBFABD58", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C135")]
		[Address(RVA = "0x17ABE70", Offset = "0x17ABE70", VA = "0x7BBBFABE70")]
		public UIHudMatchResultItemRewardView()
		{
		}

		// Token: 0x0400D907 RID: 55559
		[Token(Token = "0x400D907")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SkipMask;

		// Token: 0x0400D908 RID: 55560
		[Token(Token = "0x400D908")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid DebrisRewardGrid;

		// Token: 0x0400D909 RID: 55561
		[Token(Token = "0x400D909")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid CommonRewardGrid;
	}
}
