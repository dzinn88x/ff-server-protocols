using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F7 RID: 8695
	[Token(Token = "0x20021F7")]
	public class UIFriendCallbackAddFriendView : UIBaseView
	{
		// Token: 0x0600BEFF RID: 48895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFF")]
		[Address(RVA = "0x1DC0128", Offset = "0x1DC0128", VA = "0x7BBC5C0128", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF00")]
		[Address(RVA = "0x1DC02B4", Offset = "0x1DC02B4", VA = "0x7BBC5C02B4")]
		public UIFriendCallbackAddFriendView()
		{
		}

		// Token: 0x0400CD81 RID: 52609
		[Token(Token = "0x400CD81")]
		[FieldOffset(Offset = "0x20")]
		public GameObject GameFriendProfileContainer;

		// Token: 0x0400CD82 RID: 52610
		[Token(Token = "0x400CD82")]
		[FieldOffset(Offset = "0x28")]
		public UILabel IDLabel;

		// Token: 0x0400CD83 RID: 52611
		[Token(Token = "0x400CD83")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TipLabel;

		// Token: 0x0400CD84 RID: 52612
		[Token(Token = "0x400CD84")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnReWrite;

		// Token: 0x0400CD85 RID: 52613
		[Token(Token = "0x400CD85")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnAddFriend;
	}
}
