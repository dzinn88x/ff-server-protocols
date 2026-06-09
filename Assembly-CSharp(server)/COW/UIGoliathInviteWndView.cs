using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200223E RID: 8766
	[Token(Token = "0x200223E")]
	public class UIGoliathInviteWndView : UIBaseView
	{
		// Token: 0x0600BF8D RID: 49037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8D")]
		[Address(RVA = "0x1A74118", Offset = "0x1A74118", VA = "0x7BBC274118", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF8E")]
		[Address(RVA = "0x1A74584", Offset = "0x1A74584", VA = "0x7BBC274584")]
		public UIGoliathInviteWndView()
		{
		}

		// Token: 0x0400D1BD RID: 53693
		[Token(Token = "0x400D1BD")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400D1BE RID: 53694
		[Token(Token = "0x400D1BE")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnClose;

		// Token: 0x0400D1BF RID: 53695
		[Token(Token = "0x400D1BF")]
		[FieldOffset(Offset = "0x30")]
		public UIToggleButton BtnGameFriend;

		// Token: 0x0400D1C0 RID: 53696
		[Token(Token = "0x400D1C0")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton BtnPlatformFriend;

		// Token: 0x0400D1C1 RID: 53697
		[Token(Token = "0x400D1C1")]
		[FieldOffset(Offset = "0x40")]
		public UIEasyList FriendEasyList;

		// Token: 0x0400D1C2 RID: 53698
		[Token(Token = "0x400D1C2")]
		[FieldOffset(Offset = "0x48")]
		public UILabel NoFriendDesc;

		// Token: 0x0400D1C3 RID: 53699
		[Token(Token = "0x400D1C3")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnRecruit;

		// Token: 0x0400D1C4 RID: 53700
		[Token(Token = "0x400D1C4")]
		[FieldOffset(Offset = "0x58")]
		public UIWidget RecruitGuideRegion;

		// Token: 0x0400D1C5 RID: 53701
		[Token(Token = "0x400D1C5")]
		[FieldOffset(Offset = "0x60")]
		public UIGrid ShareGrid;

		// Token: 0x0400D1C6 RID: 53702
		[Token(Token = "0x400D1C6")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnFBInvite;

		// Token: 0x0400D1C7 RID: 53703
		[Token(Token = "0x400D1C7")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnLineInvite;

		// Token: 0x0400D1C8 RID: 53704
		[Token(Token = "0x400D1C8")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnVKInvite;

		// Token: 0x0400D1C9 RID: 53705
		[Token(Token = "0x400D1C9")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnOtherInvite;

		// Token: 0x0400D1CA RID: 53706
		[Token(Token = "0x400D1CA")]
		[FieldOffset(Offset = "0x88")]
		public GameObject GuideMask;

		// Token: 0x0400D1CB RID: 53707
		[Token(Token = "0x400D1CB")]
		[FieldOffset(Offset = "0x90")]
		public UILabel GuideDesc;

		// Token: 0x0400D1CC RID: 53708
		[Token(Token = "0x400D1CC")]
		[FieldOffset(Offset = "0x98")]
		public Transform GuideDescFrame;

		// Token: 0x0400D1CD RID: 53709
		[Token(Token = "0x400D1CD")]
		[FieldOffset(Offset = "0xA0")]
		public UITexture MaskBg;
	}
}
