using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002181 RID: 8577
	[Token(Token = "0x2002181")]
	public class UICommonPopMenuView : UIBaseView
	{
		// Token: 0x0600BE12 RID: 48658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE12")]
		[Address(RVA = "0x1803DEC", Offset = "0x1803DEC", VA = "0x7BBC003DEC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE13 RID: 48659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE13")]
		[Address(RVA = "0x1803F60", Offset = "0x1803F60", VA = "0x7BBC003F60")]
		public UICommonPopMenuView()
		{
		}

		// Token: 0x0400C792 RID: 51090
		[Token(Token = "0x400C792")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel WindowPanel;

		// Token: 0x0400C793 RID: 51091
		[Token(Token = "0x400C793")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Container;

		// Token: 0x0400C794 RID: 51092
		[Token(Token = "0x400C794")]
		[FieldOffset(Offset = "0x30")]
		public Transform ProfileContainer;

		// Token: 0x0400C795 RID: 51093
		[Token(Token = "0x400C795")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid ItemGrid;
	}
}
