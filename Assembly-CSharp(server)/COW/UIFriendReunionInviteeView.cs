using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021FF RID: 8703
	[Token(Token = "0x20021FF")]
	public class UIFriendReunionInviteeView : UIBaseView
	{
		// Token: 0x0600BF0F RID: 48911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF0F")]
		[Address(RVA = "0x159D814", Offset = "0x159D814", VA = "0x7BBBD9D814", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF10")]
		[Address(RVA = "0x159DA3C", Offset = "0x159DA3C", VA = "0x7BBBD9DA3C")]
		public UIFriendReunionInviteeView()
		{
		}

		// Token: 0x0400CE01 RID: 52737
		[Token(Token = "0x400CE01")]
		[FieldOffset(Offset = "0x20")]
		public GameObject SearchBarContainer;

		// Token: 0x0400CE02 RID: 52738
		[Token(Token = "0x400CE02")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget UIFriendReunionInvitee;

		// Token: 0x0400CE03 RID: 52739
		[Token(Token = "0x400CE03")]
		[FieldOffset(Offset = "0x30")]
		public UIInput InvitationInput;

		// Token: 0x0400CE04 RID: 52740
		[Token(Token = "0x400CE04")]
		[FieldOffset(Offset = "0x38")]
		public UILabel PlaceholderLabel;

		// Token: 0x0400CE05 RID: 52741
		[Token(Token = "0x400CE05")]
		[FieldOffset(Offset = "0x40")]
		public GameObject InviteeDescription;

		// Token: 0x0400CE06 RID: 52742
		[Token(Token = "0x400CE06")]
		[FieldOffset(Offset = "0x48")]
		public UIButton ClaimButton;

		// Token: 0x0400CE07 RID: 52743
		[Token(Token = "0x400CE07")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ReunionInviterItemBg;
	}
}
