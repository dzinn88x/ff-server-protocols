using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200223C RID: 8764
	[Token(Token = "0x200223C")]
	public class UIGoliathFriendItemView : UIBaseView
	{
		// Token: 0x0600BF89 RID: 49033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF89")]
		[Address(RVA = "0x1A6F33C", Offset = "0x1A6F33C", VA = "0x7BBC26F33C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8A")]
		[Address(RVA = "0x1A6F4D8", Offset = "0x1A6F4D8", VA = "0x7BBC26F4D8")]
		public UIGoliathFriendItemView()
		{
		}

		// Token: 0x0400D19D RID: 53661
		[Token(Token = "0x400D19D")]
		[FieldOffset(Offset = "0x20")]
		public Transform ProfileContainer;

		// Token: 0x0400D19E RID: 53662
		[Token(Token = "0x400D19E")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnInvite;

		// Token: 0x0400D19F RID: 53663
		[Token(Token = "0x400D19F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite InviteBtnSprite;

		// Token: 0x0400D1A0 RID: 53664
		[Token(Token = "0x400D1A0")]
		[FieldOffset(Offset = "0x38")]
		public UILabel InviteBtnLabel;

		// Token: 0x0400D1A1 RID: 53665
		[Token(Token = "0x400D1A1")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnInvited;
	}
}
