using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024B4 RID: 9396
	[Token(Token = "0x20024B4")]
	public class UIPVEStartGameItemView : UIBaseView
	{
		// Token: 0x0600C478 RID: 50296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C478")]
		[Address(RVA = "0x16E6A24", Offset = "0x16E6A24", VA = "0x7BBBEE6A24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C479 RID: 50297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C479")]
		[Address(RVA = "0x16E6AC0", Offset = "0x16E6AC0", VA = "0x7BBBEE6AC0")]
		public UIPVEStartGameItemView()
		{
		}

		// Token: 0x0400EECB RID: 61131
		[Token(Token = "0x400EECB")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView Reward;
	}
}
