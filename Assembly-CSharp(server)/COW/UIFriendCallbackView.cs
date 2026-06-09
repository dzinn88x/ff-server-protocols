using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F9 RID: 8697
	[Token(Token = "0x20021F9")]
	public class UIFriendCallbackView : UIBaseView
	{
		// Token: 0x0600BF03 RID: 48899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF03")]
		[Address(RVA = "0x1DC1D94", Offset = "0x1DC1D94", VA = "0x7BBC5C1D94", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF04")]
		[Address(RVA = "0x1DC1F8C", Offset = "0x1DC1F8C", VA = "0x7BBC5C1F8C")]
		public UIFriendCallbackView()
		{
		}

		// Token: 0x0400CD8F RID: 52623
		[Token(Token = "0x400CD8F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Title;

		// Token: 0x0400CD90 RID: 52624
		[Token(Token = "0x400CD90")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView FriendListScrollView;

		// Token: 0x0400CD91 RID: 52625
		[Token(Token = "0x400CD91")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList FriendList;

		// Token: 0x0400CD92 RID: 52626
		[Token(Token = "0x400CD92")]
		[FieldOffset(Offset = "0x38")]
		public UILabel FriendListEmptyHint;

		// Token: 0x0400CD93 RID: 52627
		[Token(Token = "0x400CD93")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RequestContainer;

		// Token: 0x0400CD94 RID: 52628
		[Token(Token = "0x400CD94")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnInviteFriends;
	}
}
