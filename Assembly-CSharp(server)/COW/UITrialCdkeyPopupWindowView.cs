using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002579 RID: 9593
	[Token(Token = "0x2002579")]
	public class UITrialCdkeyPopupWindowView : UIBaseView
	{
		// Token: 0x0600C602 RID: 50690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C602")]
		[Address(RVA = "0x19F370C", Offset = "0x19F370C", VA = "0x7BBC1F370C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C603 RID: 50691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C603")]
		[Address(RVA = "0x19F382C", Offset = "0x19F382C", VA = "0x7BBC1F382C")]
		public UITrialCdkeyPopupWindowView()
		{
		}

		// Token: 0x0400F67B RID: 63099
		[Token(Token = "0x400F67B")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LabelTip;

		// Token: 0x0400F67C RID: 63100
		[Token(Token = "0x400F67C")]
		[FieldOffset(Offset = "0x28")]
		public UIInput InputCode;

		// Token: 0x0400F67D RID: 63101
		[Token(Token = "0x400F67D")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnConfirm;
	}
}
