using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258E RID: 9614
	[Token(Token = "0x200258E")]
	public class UIWaitingForRequestView : UIBaseView
	{
		// Token: 0x0600C62C RID: 50732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62C")]
		[Address(RVA = "0x1685600", Offset = "0x1685600", VA = "0x7BBBE85600", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C62D RID: 50733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C62D")]
		[Address(RVA = "0x168569C", Offset = "0x168569C", VA = "0x7BBBE8569C")]
		public UIWaitingForRequestView()
		{
		}

		// Token: 0x0400F734 RID: 63284
		[Token(Token = "0x400F734")]
		[FieldOffset(Offset = "0x20")]
		public BoxCollider MaskCollider;
	}
}
