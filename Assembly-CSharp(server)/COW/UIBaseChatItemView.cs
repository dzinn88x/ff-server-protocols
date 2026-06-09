using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002118 RID: 8472
	[Token(Token = "0x2002118")]
	internal class UIBaseChatItemView : UIBaseView
	{
		// Token: 0x0600BD41 RID: 48449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD41")]
		[Address(RVA = "0x1421C4C", Offset = "0x1421C4C", VA = "0x7BBBC21C4C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD42 RID: 48450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD42")]
		[Address(RVA = "0x1421E1C", Offset = "0x1421E1C", VA = "0x7BBBC21E1C")]
		public UIBaseChatItemView()
		{
		}

		// Token: 0x0400C1D8 RID: 49624
		[Token(Token = "0x400C1D8")]
		[FieldOffset(Offset = "0x20")]
		public BaseChatMessageView LeftView;

		// Token: 0x0400C1D9 RID: 49625
		[Token(Token = "0x400C1D9")]
		[FieldOffset(Offset = "0x28")]
		public UIButton headbtnleft;

		// Token: 0x0400C1DA RID: 49626
		[Token(Token = "0x400C1DA")]
		[FieldOffset(Offset = "0x30")]
		public UIButton LeftContentBtn;

		// Token: 0x0400C1DB RID: 49627
		[Token(Token = "0x400C1DB")]
		[FieldOffset(Offset = "0x38")]
		public BaseChatMessageView RightView;

		// Token: 0x0400C1DC RID: 49628
		[Token(Token = "0x400C1DC")]
		[FieldOffset(Offset = "0x40")]
		public UIButton headbtn;

		// Token: 0x0400C1DD RID: 49629
		[Token(Token = "0x400C1DD")]
		[FieldOffset(Offset = "0x48")]
		public UIButton RightContentBtn;
	}
}
