using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002560 RID: 9568
	[Token(Token = "0x2002560")]
	public class UISuperCarInviteItemView : UIBaseView
	{
		// Token: 0x0600C5D0 RID: 50640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D0")]
		[Address(RVA = "0x2146508", Offset = "0x2146508", VA = "0x7BBC946508", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5D1 RID: 50641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D1")]
		[Address(RVA = "0x21466A4", Offset = "0x21466A4", VA = "0x7BBC9466A4")]
		public UISuperCarInviteItemView()
		{
		}

		// Token: 0x0400F53F RID: 62783
		[Token(Token = "0x400F53F")]
		[FieldOffset(Offset = "0x20")]
		public Transform ProfileContainer;

		// Token: 0x0400F540 RID: 62784
		[Token(Token = "0x400F540")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnInvite;

		// Token: 0x0400F541 RID: 62785
		[Token(Token = "0x400F541")]
		[FieldOffset(Offset = "0x30")]
		public UISprite InviteBtnSprite;

		// Token: 0x0400F542 RID: 62786
		[Token(Token = "0x400F542")]
		[FieldOffset(Offset = "0x38")]
		public UILabel InviteBtnLabel;

		// Token: 0x0400F543 RID: 62787
		[Token(Token = "0x400F543")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnInvited;
	}
}
