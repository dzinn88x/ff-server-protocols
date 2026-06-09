using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002561 RID: 9569
	[Token(Token = "0x2002561")]
	public class UISuperCarInviteWndView : UIBaseView
	{
		// Token: 0x0600C5D2 RID: 50642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D2")]
		[Address(RVA = "0x2148340", Offset = "0x2148340", VA = "0x7BBC948340", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5D3 RID: 50643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5D3")]
		[Address(RVA = "0x2148648", Offset = "0x2148648", VA = "0x7BBC948648")]
		public UISuperCarInviteWndView()
		{
		}

		// Token: 0x0400F544 RID: 62788
		[Token(Token = "0x400F544")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400F545 RID: 62789
		[Token(Token = "0x400F545")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400F546 RID: 62790
		[Token(Token = "0x400F546")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton BtnGameFriend;

		// Token: 0x0400F547 RID: 62791
		[Token(Token = "0x400F547")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton BtnPlatformFriend;

		// Token: 0x0400F548 RID: 62792
		[Token(Token = "0x400F548")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList FriendEasyList;

		// Token: 0x0400F549 RID: 62793
		[Token(Token = "0x400F549")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NoFriendDesc;

		// Token: 0x0400F54A RID: 62794
		[Token(Token = "0x400F54A")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid ShareGrid;

		// Token: 0x0400F54B RID: 62795
		[Token(Token = "0x400F54B")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnFBInvite;

		// Token: 0x0400F54C RID: 62796
		[Token(Token = "0x400F54C")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnLineInvite;

		// Token: 0x0400F54D RID: 62797
		[Token(Token = "0x400F54D")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnVKInvite;

		// Token: 0x0400F54E RID: 62798
		[Token(Token = "0x400F54E")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnOtherInvite;
	}
}
