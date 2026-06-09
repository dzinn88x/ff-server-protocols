using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D3 RID: 8915
	[Token(Token = "0x20022D3")]
	public class UIHudFriendinviteView : UIBaseView
	{
		// Token: 0x0600C0B6 RID: 49334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B6")]
		[Address(RVA = "0x1C108C8", Offset = "0x1C108C8", VA = "0x7BBC4108C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B7")]
		[Address(RVA = "0x1C10AE8", Offset = "0x1C10AE8", VA = "0x7BBC410AE8")]
		public UIHudFriendinviteView()
		{
		}

		// Token: 0x0400D6AB RID: 54955
		[Token(Token = "0x400D6AB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton IgnoreToggle;

		// Token: 0x0400D6AC RID: 54956
		[Token(Token = "0x400D6AC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject IgnoreCheck;

		// Token: 0x0400D6AD RID: 54957
		[Token(Token = "0x400D6AD")]
		[FieldOffset(Offset = "0x30")]
		public UILabel IgnoreDesc;

		// Token: 0x0400D6AE RID: 54958
		[Token(Token = "0x400D6AE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel UserNameLabel;

		// Token: 0x0400D6AF RID: 54959
		[Token(Token = "0x400D6AF")]
		[FieldOffset(Offset = "0x40")]
		public UIButton AgreeBtn;

		// Token: 0x0400D6B0 RID: 54960
		[Token(Token = "0x400D6B0")]
		[FieldOffset(Offset = "0x48")]
		public UIButton DisagreeBtn;

		// Token: 0x0400D6B1 RID: 54961
		[Token(Token = "0x400D6B1")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DisagreeTimeLabel;
	}
}
