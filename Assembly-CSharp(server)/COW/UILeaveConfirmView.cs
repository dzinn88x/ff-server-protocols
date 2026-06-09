using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D9 RID: 9177
	[Token(Token = "0x20023D9")]
	internal class UILeaveConfirmView : UIBaseView
	{
		// Token: 0x0600C2C2 RID: 49858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C2")]
		[Address(RVA = "0x1E3C2E0", Offset = "0x1E3C2E0", VA = "0x7BBC63C2E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2C3")]
		[Address(RVA = "0x1E3C444", Offset = "0x1E3C444", VA = "0x7BBC63C444")]
		public UILeaveConfirmView()
		{
		}

		// Token: 0x0400DFF5 RID: 57333
		[Token(Token = "0x400DFF5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton close;

		// Token: 0x0400DFF6 RID: 57334
		[Token(Token = "0x400DFF6")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400DFF7 RID: 57335
		[Token(Token = "0x400DFF7")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ConfirmBtn;

		// Token: 0x0400DFF8 RID: 57336
		[Token(Token = "0x400DFF8")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BtnSprite;
	}
}
