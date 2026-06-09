using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002183 RID: 8579
	[Token(Token = "0x2002183")]
	public class UICommonRewardSecondConfirmWndView : UIBaseView
	{
		// Token: 0x0600BE16 RID: 48662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE16")]
		[Address(RVA = "0x1807604", Offset = "0x1807604", VA = "0x7BBC007604", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE17 RID: 48663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE17")]
		[Address(RVA = "0x1807724", Offset = "0x1807724", VA = "0x7BBC007724")]
		public UICommonRewardSecondConfirmWndView()
		{
		}

		// Token: 0x0400C7A3 RID: 51107
		[Token(Token = "0x400C7A3")]
		[FieldOffset(Offset = "0x20")]
		public UIButton CancelBtn;

		// Token: 0x0400C7A4 RID: 51108
		[Token(Token = "0x400C7A4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton ConfirmBtn;

		// Token: 0x0400C7A5 RID: 51109
		[Token(Token = "0x400C7A5")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;
	}
}
