using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024CF RID: 9423
	[Token(Token = "0x20024CF")]
	public class UIRelationshipInviteMsgItemView : UIBaseView
	{
		// Token: 0x0600C4AE RID: 50350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AE")]
		[Address(RVA = "0x1E1D53C", Offset = "0x1E1D53C", VA = "0x7BBC61D53C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4AF RID: 50351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4AF")]
		[Address(RVA = "0x1E1D6D8", Offset = "0x1E1D6D8", VA = "0x7BBC61D6D8")]
		public UIRelationshipInviteMsgItemView()
		{
		}

		// Token: 0x0400EFB9 RID: 61369
		[Token(Token = "0x400EFB9")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BaseProfileInfo;

		// Token: 0x0400EFBA RID: 61370
		[Token(Token = "0x400EFBA")]
		[FieldOffset(Offset = "0x28")]
		public UILabel MsgLabel;

		// Token: 0x0400EFBB RID: 61371
		[Token(Token = "0x400EFBB")]
		[FieldOffset(Offset = "0x30")]
		public UICountDownLabel TimeLabel;

		// Token: 0x0400EFBC RID: 61372
		[Token(Token = "0x400EFBC")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ShowMsgDetailBtn;

		// Token: 0x0400EFBD RID: 61373
		[Token(Token = "0x400EFBD")]
		[FieldOffset(Offset = "0x40")]
		public UILabel MsgStateLabel;
	}
}
