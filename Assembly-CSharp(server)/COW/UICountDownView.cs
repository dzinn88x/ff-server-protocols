using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218B RID: 8587
	[Token(Token = "0x200218B")]
	public class UICountDownView : UIBaseView
	{
		// Token: 0x0600BE26 RID: 48678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE26")]
		[Address(RVA = "0x1819320", Offset = "0x1819320", VA = "0x7BBC019320", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE27 RID: 48679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE27")]
		[Address(RVA = "0x1819518", Offset = "0x1819518", VA = "0x7BBC019518")]
		public UICountDownView()
		{
		}

		// Token: 0x0400C7D4 RID: 51156
		[Token(Token = "0x400C7D4")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UICountDown;

		// Token: 0x0400C7D5 RID: 51157
		[Token(Token = "0x400C7D5")]
		[FieldOffset(Offset = "0x28")]
		public UICenterTargetHelper CenterHelper;

		// Token: 0x0400C7D6 RID: 51158
		[Token(Token = "0x400C7D6")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel CountDownLabel;

		// Token: 0x0400C7D7 RID: 51159
		[Token(Token = "0x400C7D7")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelContent;

		// Token: 0x0400C7D8 RID: 51160
		[Token(Token = "0x400C7D8")]
		[FieldOffset(Offset = "0x40")]
		public UISprite CountDownIcon;

		// Token: 0x0400C7D9 RID: 51161
		[Token(Token = "0x400C7D9")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CountDownIconBtn;
	}
}
