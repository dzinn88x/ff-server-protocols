using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215B RID: 8539
	[Token(Token = "0x200215B")]
	public class UIChooseHudStyleView : UIBaseView
	{
		// Token: 0x0600BDC6 RID: 48582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC6")]
		[Address(RVA = "0x1BF54EC", Offset = "0x1BF54EC", VA = "0x7BBC3F54EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDC7")]
		[Address(RVA = "0x1BF55DC", Offset = "0x1BF55DC", VA = "0x7BBC3F55DC")]
		public UIChooseHudStyleView()
		{
		}

		// Token: 0x0400C564 RID: 50532
		[Token(Token = "0x400C564")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnOld;

		// Token: 0x0400C565 RID: 50533
		[Token(Token = "0x400C565")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnNew;
	}
}
