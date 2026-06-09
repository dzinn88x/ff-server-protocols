using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002382 RID: 9090
	[Token(Token = "0x2002382")]
	public class UIHudTokenComboView : UIBaseView
	{
		// Token: 0x0600C214 RID: 49684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C214")]
		[Address(RVA = "0x15E679C", Offset = "0x15E679C", VA = "0x7BBBDE679C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C215")]
		[Address(RVA = "0x15E698C", Offset = "0x15E698C", VA = "0x7BBBDE698C")]
		public UIHudTokenComboView()
		{
		}

		// Token: 0x0400DC9A RID: 56474
		[Token(Token = "0x400DC9A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject AnimWidget;

		// Token: 0x0400DC9B RID: 56475
		[Token(Token = "0x400DC9B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Num;

		// Token: 0x0400DC9C RID: 56476
		[Token(Token = "0x400DC9C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel NumShadow;

		// Token: 0x0400DC9D RID: 56477
		[Token(Token = "0x400DC9D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel NumShadow_Big;

		// Token: 0x0400DC9E RID: 56478
		[Token(Token = "0x400DC9E")]
		[FieldOffset(Offset = "0x40")]
		public UILabel combo;

		// Token: 0x0400DC9F RID: 56479
		[Token(Token = "0x400DC9F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ComboShadow;

		// Token: 0x0400DCA0 RID: 56480
		[Token(Token = "0x400DCA0")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ComboShadow_Big;
	}
}
