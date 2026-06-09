using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024CE RID: 9422
	[Token(Token = "0x20024CE")]
	public class UIRelationshipInviteConfirmView : UIBaseView
	{
		// Token: 0x0600C4AC RID: 50348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AC")]
		[Address(RVA = "0x1E1BDD4", Offset = "0x1E1BDD4", VA = "0x7BBC61BDD4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4AD RID: 50349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AD")]
		[Address(RVA = "0x1E1BEEC", Offset = "0x1E1BEEC", VA = "0x7BBC61BEEC")]
		public UIRelationshipInviteConfirmView()
		{
		}

		// Token: 0x0400EFB6 RID: 61366
		[Token(Token = "0x400EFB6")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ConfirmInfoText;

		// Token: 0x0400EFB7 RID: 61367
		[Token(Token = "0x400EFB7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CancelBtn;

		// Token: 0x0400EFB8 RID: 61368
		[Token(Token = "0x400EFB8")]
		[FieldOffset(Offset = "0x30")]
		public UIButton ConfirmBtn;
	}
}
