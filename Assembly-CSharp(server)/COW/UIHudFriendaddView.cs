using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022D2 RID: 8914
	[Token(Token = "0x20022D2")]
	public class UIHudFriendaddView : UIBaseView
	{
		// Token: 0x0600C0B4 RID: 49332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B4")]
		[Address(RVA = "0x1C10724", Offset = "0x1C10724", VA = "0x7BBC410724", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0B5")]
		[Address(RVA = "0x1C108C0", Offset = "0x1C108C0", VA = "0x7BBC4108C0")]
		public UIHudFriendaddView()
		{
		}

		// Token: 0x0400D6A6 RID: 54950
		[Token(Token = "0x400D6A6")]
		[FieldOffset(Offset = "0x20")]
		public Transform ProfileContainer;

		// Token: 0x0400D6A7 RID: 54951
		[Token(Token = "0x400D6A7")]
		[FieldOffset(Offset = "0x28")]
		public UIButton AddFriendBtn;

		// Token: 0x0400D6A8 RID: 54952
		[Token(Token = "0x400D6A8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject AddIcon;

		// Token: 0x0400D6A9 RID: 54953
		[Token(Token = "0x400D6A9")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SendedIcon;

		// Token: 0x0400D6AA RID: 54954
		[Token(Token = "0x400D6AA")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FriendIcon;
	}
}
