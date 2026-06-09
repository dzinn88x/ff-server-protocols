using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002442 RID: 9282
	[Token(Token = "0x2002442")]
	public class UIMaxCdkeyPopupWindowView : UIBaseView
	{
		// Token: 0x0600C394 RID: 50068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C394")]
		[Address(RVA = "0x1484578", Offset = "0x1484578", VA = "0x7BBBC84578", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C395")]
		[Address(RVA = "0x1484704", Offset = "0x1484704", VA = "0x7BBBC84704")]
		public UIMaxCdkeyPopupWindowView()
		{
		}

		// Token: 0x0400E75B RID: 59227
		[Token(Token = "0x400E75B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelTip;

		// Token: 0x0400E75C RID: 59228
		[Token(Token = "0x400E75C")]
		[FieldOffset(Offset = "0x28")]
		public UIInput InputEmail;

		// Token: 0x0400E75D RID: 59229
		[Token(Token = "0x400E75D")]
		[FieldOffset(Offset = "0x30")]
		public UIInput InputCode;

		// Token: 0x0400E75E RID: 59230
		[Token(Token = "0x400E75E")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnUrl;

		// Token: 0x0400E75F RID: 59231
		[Token(Token = "0x400E75F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnConfirm;
	}
}
