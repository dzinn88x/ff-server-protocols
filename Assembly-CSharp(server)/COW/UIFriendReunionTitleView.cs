using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002202 RID: 8706
	[Token(Token = "0x2002202")]
	public class UIFriendReunionTitleView : UIBaseView
	{
		// Token: 0x0600BF15 RID: 48917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF15")]
		[Address(RVA = "0x15A0480", Offset = "0x15A0480", VA = "0x7BBBDA0480", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF16")]
		[Address(RVA = "0x15A0704", Offset = "0x15A0704", VA = "0x7BBBDA0704")]
		public UIFriendReunionTitleView()
		{
		}

		// Token: 0x0400CE1D RID: 52765
		[Token(Token = "0x400CE1D")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIFriendReunionTitle;

		// Token: 0x0400CE1E RID: 52766
		[Token(Token = "0x400CE1E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400CE1F RID: 52767
		[Token(Token = "0x400CE1F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton DetailButton;

		// Token: 0x0400CE20 RID: 52768
		[Token(Token = "0x400CE20")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SelfLink;

		// Token: 0x0400CE21 RID: 52769
		[Token(Token = "0x400CE21")]
		[FieldOffset(Offset = "0x40")]
		public UILabel Label;

		// Token: 0x0400CE22 RID: 52770
		[Token(Token = "0x400CE22")]
		[FieldOffset(Offset = "0x48")]
		public UIButton LinkButton;

		// Token: 0x0400CE23 RID: 52771
		[Token(Token = "0x400CE23")]
		[FieldOffset(Offset = "0x50")]
		public UIButton CallbackButton;

		// Token: 0x0400CE24 RID: 52772
		[Token(Token = "0x400CE24")]
		[FieldOffset(Offset = "0x58")]
		public UILabel BtnOperateLabelWhite;

		// Token: 0x0400CE25 RID: 52773
		[Token(Token = "0x400CE25")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ReunionInviterItemBg;
	}
}
