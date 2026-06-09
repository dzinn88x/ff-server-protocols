using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002112 RID: 8466
	[Token(Token = "0x2002112")]
	public class UIAwakenLimitAvatarView : UIBaseView
	{
		// Token: 0x0600BD35 RID: 48437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD35")]
		[Address(RVA = "0x141C2FC", Offset = "0x141C2FC", VA = "0x7BBBC1C2FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD36 RID: 48438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD36")]
		[Address(RVA = "0x141C3EC", Offset = "0x141C3EC", VA = "0x7BBBC1C3EC")]
		public UIAwakenLimitAvatarView()
		{
		}

		// Token: 0x0400C1BF RID: 49599
		[Token(Token = "0x400C1BF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CloseBtn;

		// Token: 0x0400C1C0 RID: 49600
		[Token(Token = "0x400C1C0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton GotoBtn;
	}
}
