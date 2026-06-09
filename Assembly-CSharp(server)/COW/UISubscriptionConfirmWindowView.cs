using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002557 RID: 9559
	[Token(Token = "0x2002557")]
	internal class UISubscriptionConfirmWindowView : UIBaseView
	{
		// Token: 0x0600C5BE RID: 50622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BE")]
		[Address(RVA = "0x2139CFC", Offset = "0x2139CFC", VA = "0x7BBC939CFC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5BF RID: 50623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5BF")]
		[Address(RVA = "0x2139F70", Offset = "0x2139F70", VA = "0x7BBC939F70")]
		public UISubscriptionConfirmWindowView()
		{
		}

		// Token: 0x0400F4F8 RID: 62712
		[Token(Token = "0x400F4F8")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F4F9 RID: 62713
		[Token(Token = "0x400F4F9")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelTitle;

		// Token: 0x0400F4FA RID: 62714
		[Token(Token = "0x400F4FA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DescLabel_1;

		// Token: 0x0400F4FB RID: 62715
		[Token(Token = "0x400F4FB")]
		[FieldOffset(Offset = "0x38")]
		public UILabel DescLabel_2;

		// Token: 0x0400F4FC RID: 62716
		[Token(Token = "0x400F4FC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DescLabel_3;

		// Token: 0x0400F4FD RID: 62717
		[Token(Token = "0x400F4FD")]
		[FieldOffset(Offset = "0x48")]
		public UILabel DescLabel_Whole;

		// Token: 0x0400F4FE RID: 62718
		[Token(Token = "0x400F4FE")]
		[FieldOffset(Offset = "0x50")]
		public UIButton ConfirmButton;

		// Token: 0x0400F4FF RID: 62719
		[Token(Token = "0x400F4FF")]
		[FieldOffset(Offset = "0x58")]
		public UIButton CancelButton;

		// Token: 0x0400F500 RID: 62720
		[Token(Token = "0x400F500")]
		[FieldOffset(Offset = "0x60")]
		public UIButton OKButton;
	}
}
