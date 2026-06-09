using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200258C RID: 9612
	[Token(Token = "0x200258C")]
	internal class UIVoucherListView : UIBaseView
	{
		// Token: 0x0600C628 RID: 50728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C628")]
		[Address(RVA = "0x1685114", Offset = "0x1685114", VA = "0x7BBBE85114", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C629 RID: 50729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C629")]
		[Address(RVA = "0x1685204", Offset = "0x1685204", VA = "0x7BBBE85204")]
		public UIVoucherListView()
		{
		}

		// Token: 0x0400F731 RID: 63281
		[Token(Token = "0x400F731")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget VoucherContainer;

		// Token: 0x0400F732 RID: 63282
		[Token(Token = "0x400F732")]
		[FieldOffset(Offset = "0x28")]
		public UIEasyList VoucherItemGrid;
	}
}
