using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200215E RID: 8542
	[Token(Token = "0x200215E")]
	internal class UIClanApplyListView : UIBaseView
	{
		// Token: 0x0600BDCC RID: 48588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCC")]
		[Address(RVA = "0x1BF9000", Offset = "0x1BF9000", VA = "0x7BBC3F9000", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDCD RID: 48589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDCD")]
		[Address(RVA = "0x1BF91F8", Offset = "0x1BF91F8", VA = "0x7BBC3F91F8")]
		public UIClanApplyListView()
		{
		}

		// Token: 0x0400C587 RID: 50567
		[Token(Token = "0x400C587")]
		[FieldOffset(Offset = "0x20")]
		public UILabel TitleLabel;

		// Token: 0x0400C588 RID: 50568
		[Token(Token = "0x400C588")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CloseBtn;

		// Token: 0x0400C589 RID: 50569
		[Token(Token = "0x400C589")]
		[FieldOffset(Offset = "0x30")]
		public UISprite TailArrow;

		// Token: 0x0400C58A RID: 50570
		[Token(Token = "0x400C58A")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView ListScrollView_Apply;

		// Token: 0x0400C58B RID: 50571
		[Token(Token = "0x400C58B")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList ListGrid_Apply;

		// Token: 0x0400C58C RID: 50572
		[Token(Token = "0x400C58C")]
		[FieldOffset(Offset = "0x48")]
		public GameObject EmptyNode;
	}
}
