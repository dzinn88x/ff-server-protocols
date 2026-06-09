using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020D1 RID: 8401
	[Token(Token = "0x20020D1")]
	internal class TipsWithItemsView : UIBaseView
	{
		// Token: 0x0600BCB3 RID: 48307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB3")]
		[Address(RVA = "0x1B499DC", Offset = "0x1B499DC", VA = "0x7BBC3499DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCB4 RID: 48308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCB4")]
		[Address(RVA = "0x1B49B78", Offset = "0x1B49B78", VA = "0x7BBC349B78")]
		public TipsWithItemsView()
		{
		}

		// Token: 0x0400BE5F RID: 48735
		[Token(Token = "0x400BE5F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BGPivot;

		// Token: 0x0400BE60 RID: 48736
		[Token(Token = "0x400BE60")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget BG;

		// Token: 0x0400BE61 RID: 48737
		[Token(Token = "0x400BE61")]
		[FieldOffset(Offset = "0x30")]
		public UITable Table;

		// Token: 0x0400BE62 RID: 48738
		[Token(Token = "0x400BE62")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TablePivot;

		// Token: 0x0400BE63 RID: 48739
		[Token(Token = "0x400BE63")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Mask;
	}
}
