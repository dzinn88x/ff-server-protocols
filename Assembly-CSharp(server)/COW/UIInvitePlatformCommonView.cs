using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023D0 RID: 9168
	[Token(Token = "0x20023D0")]
	public class UIInvitePlatformCommonView : UIBaseView
	{
		// Token: 0x0600C2B0 RID: 49840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B0")]
		[Address(RVA = "0x1E830B0", Offset = "0x1E830B0", VA = "0x7BBC6830B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2B1")]
		[Address(RVA = "0x1E832B8", Offset = "0x1E832B8", VA = "0x7BBC6832B8")]
		public UIInvitePlatformCommonView()
		{
		}

		// Token: 0x0400DF4E RID: 57166
		[Token(Token = "0x400DF4E")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid GridInterAppInvite;

		// Token: 0x0400DF4F RID: 57167
		[Token(Token = "0x400DF4F")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnCopyLink;

		// Token: 0x0400DF50 RID: 57168
		[Token(Token = "0x400DF50")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnLineInvite;

		// Token: 0x0400DF51 RID: 57169
		[Token(Token = "0x400DF51")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnBindInvite;

		// Token: 0x0400DF52 RID: 57170
		[Token(Token = "0x400DF52")]
		[FieldOffset(Offset = "0x40")]
		public UISprite BindInviteSprite;

		// Token: 0x0400DF53 RID: 57171
		[Token(Token = "0x400DF53")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnOtherInvite;

		// Token: 0x0400DF54 RID: 57172
		[Token(Token = "0x400DF54")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Tips;
	}
}
