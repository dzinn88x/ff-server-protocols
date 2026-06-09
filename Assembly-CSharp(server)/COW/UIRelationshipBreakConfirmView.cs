using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024CA RID: 9418
	[Token(Token = "0x20024CA")]
	public class UIRelationshipBreakConfirmView : UIBaseView
	{
		// Token: 0x0600C4A4 RID: 50340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A4")]
		[Address(RVA = "0x1E19B28", Offset = "0x1E19B28", VA = "0x7BBC619B28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A5")]
		[Address(RVA = "0x1E19C48", Offset = "0x1E19C48", VA = "0x7BBC619C48")]
		public UIRelationshipBreakConfirmView()
		{
		}

		// Token: 0x0400EFAA RID: 61354
		[Token(Token = "0x400EFAA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ConfirmBtn;

		// Token: 0x0400EFAB RID: 61355
		[Token(Token = "0x400EFAB")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400EFAC RID: 61356
		[Token(Token = "0x400EFAC")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ConfirmInfoText;
	}
}
