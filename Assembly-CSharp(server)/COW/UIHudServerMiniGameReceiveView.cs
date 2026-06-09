using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200235D RID: 9053
	[Token(Token = "0x200235D")]
	public class UIHudServerMiniGameReceiveView : UIBaseView
	{
		// Token: 0x0600C1CA RID: 49610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1CA")]
		[Address(RVA = "0x1664478", Offset = "0x1664478", VA = "0x7BBBE64478", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1CB RID: 49611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1CB")]
		[Address(RVA = "0x16646C4", Offset = "0x16646C4", VA = "0x7BBBE646C4")]
		public UIHudServerMiniGameReceiveView()
		{
		}

		// Token: 0x0400DB72 RID: 56178
		[Token(Token = "0x400DB72")]
		[FieldOffset(Offset = "0x20")]
		public UILabel IgnoreDesc;

		// Token: 0x0400DB73 RID: 56179
		[Token(Token = "0x400DB73")]
		[FieldOffset(Offset = "0x28")]
		public UIButton IgnoreToggle;

		// Token: 0x0400DB74 RID: 56180
		[Token(Token = "0x400DB74")]
		[FieldOffset(Offset = "0x30")]
		public GameObject IgnoreCheck;

		// Token: 0x0400DB75 RID: 56181
		[Token(Token = "0x400DB75")]
		[FieldOffset(Offset = "0x38")]
		public UILabel InviteDesc;

		// Token: 0x0400DB76 RID: 56182
		[Token(Token = "0x400DB76")]
		[FieldOffset(Offset = "0x40")]
		public UILabel UserNameLabel;

		// Token: 0x0400DB77 RID: 56183
		[Token(Token = "0x400DB77")]
		[FieldOffset(Offset = "0x48")]
		public UIButton AgreeBtn;

		// Token: 0x0400DB78 RID: 56184
		[Token(Token = "0x400DB78")]
		[FieldOffset(Offset = "0x50")]
		public UIButton DisagreeBtn;

		// Token: 0x0400DB79 RID: 56185
		[Token(Token = "0x400DB79")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DisagreeTimeLabel;
	}
}
