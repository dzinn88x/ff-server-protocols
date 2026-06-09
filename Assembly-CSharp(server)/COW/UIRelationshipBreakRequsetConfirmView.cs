using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024CB RID: 9419
	[Token(Token = "0x20024CB")]
	public class UIRelationshipBreakRequsetConfirmView : UIBaseView
	{
		// Token: 0x0600C4A6 RID: 50342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A6")]
		[Address(RVA = "0x1E1A284", Offset = "0x1E1A284", VA = "0x7BBC61A284", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A7")]
		[Address(RVA = "0x1E1A3A4", Offset = "0x1E1A3A4", VA = "0x7BBC61A3A4")]
		public UIRelationshipBreakRequsetConfirmView()
		{
		}

		// Token: 0x0400EFAD RID: 61357
		[Token(Token = "0x400EFAD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ConfirmBtn;

		// Token: 0x0400EFAE RID: 61358
		[Token(Token = "0x400EFAE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton RefuseBtn;

		// Token: 0x0400EFAF RID: 61359
		[Token(Token = "0x400EFAF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ConfirmInfoText;
	}
}
