using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002575 RID: 9589
	[Token(Token = "0x2002575")]
	public class UITokenTipsBtnItemView : UIBaseView
	{
		// Token: 0x0600C5FA RID: 50682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FA")]
		[Address(RVA = "0x1F560E0", Offset = "0x1F560E0", VA = "0x7BBC7560E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5FB RID: 50683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FB")]
		[Address(RVA = "0x1F561D0", Offset = "0x1F561D0", VA = "0x7BBC7561D0")]
		public UITokenTipsBtnItemView()
		{
		}

		// Token: 0x0400F632 RID: 63026
		[Token(Token = "0x400F632")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UITokenTipsBtnItem;

		// Token: 0x0400F633 RID: 63027
		[Token(Token = "0x400F633")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;
	}
}
