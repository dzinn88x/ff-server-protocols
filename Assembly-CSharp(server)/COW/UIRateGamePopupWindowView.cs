using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024C7 RID: 9415
	[Token(Token = "0x20024C7")]
	public class UIRateGamePopupWindowView : UIBaseView
	{
		// Token: 0x0600C49E RID: 50334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49E")]
		[Address(RVA = "0x1E11C18", Offset = "0x1E11C18", VA = "0x7BBC611C18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49F")]
		[Address(RVA = "0x1E11D30", Offset = "0x1E11D30", VA = "0x7BBC611D30")]
		public UIRateGamePopupWindowView()
		{
		}

		// Token: 0x0400EF72 RID: 61298
		[Token(Token = "0x400EF72")]
		[FieldOffset(Offset = "0x20")]
		public UIButton SuggestBtn;

		// Token: 0x0400EF73 RID: 61299
		[Token(Token = "0x400EF73")]
		[FieldOffset(Offset = "0x28")]
		public UIButton PraiseBtn;

		// Token: 0x0400EF74 RID: 61300
		[Token(Token = "0x400EF74")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnClose;
	}
}
