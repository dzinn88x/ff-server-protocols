using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002385 RID: 9093
	[Token(Token = "0x2002385")]
	public class UIHudTrainingConfirmView : UIBaseView
	{
		// Token: 0x0600C21A RID: 49690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21A")]
		[Address(RVA = "0x15E76E8", Offset = "0x15E76E8", VA = "0x7BBBDE76E8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C21B")]
		[Address(RVA = "0x15E7954", Offset = "0x15E7954", VA = "0x7BBBDE7954")]
		public UIHudTrainingConfirmView()
		{
		}

		// Token: 0x0400DCB1 RID: 56497
		[Token(Token = "0x400DCB1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton MaskBtn;

		// Token: 0x0400DCB2 RID: 56498
		[Token(Token = "0x400DCB2")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x0400DCB3 RID: 56499
		[Token(Token = "0x400DCB3")]
		[FieldOffset(Offset = "0x30")]
		public UILabel DescLabel;

		// Token: 0x0400DCB4 RID: 56500
		[Token(Token = "0x400DCB4")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TitleLabel;

		// Token: 0x0400DCB5 RID: 56501
		[Token(Token = "0x400DCB5")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnCancel;

		// Token: 0x0400DCB6 RID: 56502
		[Token(Token = "0x400DCB6")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelCancel;

		// Token: 0x0400DCB7 RID: 56503
		[Token(Token = "0x400DCB7")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnConfirm;

		// Token: 0x0400DCB8 RID: 56504
		[Token(Token = "0x400DCB8")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LabelConfirm;
	}
}
