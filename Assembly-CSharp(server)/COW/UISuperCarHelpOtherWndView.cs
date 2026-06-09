using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200255D RID: 9565
	[Token(Token = "0x200255D")]
	public class UISuperCarHelpOtherWndView : UIBaseView
	{
		// Token: 0x0600C5CA RID: 50634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CA")]
		[Address(RVA = "0x2144830", Offset = "0x2144830", VA = "0x7BBC944830", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5CB")]
		[Address(RVA = "0x2144A58", Offset = "0x2144A58", VA = "0x7BBC944A58")]
		public UISuperCarHelpOtherWndView()
		{
		}

		// Token: 0x0400F52E RID: 62766
		[Token(Token = "0x400F52E")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400F52F RID: 62767
		[Token(Token = "0x400F52F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400F530 RID: 62768
		[Token(Token = "0x400F530")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton BtnGameFriend;

		// Token: 0x0400F531 RID: 62769
		[Token(Token = "0x400F531")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton BtnPlatformFriend;

		// Token: 0x0400F532 RID: 62770
		[Token(Token = "0x400F532")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList FriendEasyList;

		// Token: 0x0400F533 RID: 62771
		[Token(Token = "0x400F533")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NoFriendDesc;

		// Token: 0x0400F534 RID: 62772
		[Token(Token = "0x400F534")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ClickMask;
	}
}
