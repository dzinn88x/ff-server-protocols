using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236F RID: 9071
	[Token(Token = "0x200236F")]
	public class UIHudSuicideView : UIBaseView
	{
		// Token: 0x0600C1EE RID: 49646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EE")]
		[Address(RVA = "0x16752A8", Offset = "0x16752A8", VA = "0x7BBBE752A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EF")]
		[Address(RVA = "0x1675490", Offset = "0x1675490", VA = "0x7BBBE75490")]
		public UIHudSuicideView()
		{
		}

		// Token: 0x0400DBF4 RID: 56308
		[Token(Token = "0x400DBF4")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Root;

		// Token: 0x0400DBF5 RID: 56309
		[Token(Token = "0x400DBF5")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Button;

		// Token: 0x0400DBF6 RID: 56310
		[Token(Token = "0x400DBF6")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CancelBtn;

		// Token: 0x0400DBF7 RID: 56311
		[Token(Token = "0x400DBF7")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDIcon;

		// Token: 0x0400DBF8 RID: 56312
		[Token(Token = "0x400DBF8")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Circle;

		// Token: 0x0400DBF9 RID: 56313
		[Token(Token = "0x400DBF9")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TimeLabel;
	}
}
