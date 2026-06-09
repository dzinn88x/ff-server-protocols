using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002203 RID: 8707
	[Token(Token = "0x2002203")]
	public class UIFriendView : UIBaseView
	{
		// Token: 0x0600BF17 RID: 48919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF17")]
		[Address(RVA = "0x15A070C", Offset = "0x15A070C", VA = "0x7BBBDA070C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF18 RID: 48920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF18")]
		[Address(RVA = "0x15A0E58", Offset = "0x15A0E58", VA = "0x7BBBDA0E58")]
		public UIFriendView()
		{
		}

		// Token: 0x0400CE26 RID: 52774
		[Token(Token = "0x400CE26")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BG;

		// Token: 0x0400CE27 RID: 52775
		[Token(Token = "0x400CE27")]
		[FieldOffset(Offset = "0x28")]
		public UILabel FriendListEmptyHint;

		// Token: 0x0400CE28 RID: 52776
		[Token(Token = "0x400CE28")]
		[FieldOffset(Offset = "0x30")]
		public Transform LeftContainer;

		// Token: 0x0400CE29 RID: 52777
		[Token(Token = "0x400CE29")]
		[FieldOffset(Offset = "0x38")]
		public UITable InviteBtnGroup;

		// Token: 0x0400CE2A RID: 52778
		[Token(Token = "0x400CE2A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ShareLabel;

		// Token: 0x0400CE2B RID: 52779
		[Token(Token = "0x400CE2B")]
		[FieldOffset(Offset = "0x48")]
		public UIButton CopyLink;

		// Token: 0x0400CE2C RID: 52780
		[Token(Token = "0x400CE2C")]
		[FieldOffset(Offset = "0x50")]
		public UIButton LineInvite;

		// Token: 0x0400CE2D RID: 52781
		[Token(Token = "0x400CE2D")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BindInvite;

		// Token: 0x0400CE2E RID: 52782
		[Token(Token = "0x400CE2E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite BindInviteSprite;

		// Token: 0x0400CE2F RID: 52783
		[Token(Token = "0x400CE2F")]
		[FieldOffset(Offset = "0x68")]
		public UIButton OtherInvite;

		// Token: 0x0400CE30 RID: 52784
		[Token(Token = "0x400CE30")]
		[FieldOffset(Offset = "0x70")]
		public Transform CountdownTime;

		// Token: 0x0400CE31 RID: 52785
		[Token(Token = "0x400CE31")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnFriendsRequest;

		// Token: 0x0400CE32 RID: 52786
		[Token(Token = "0x400CE32")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ApplyHint;

		// Token: 0x0400CE33 RID: 52787
		[Token(Token = "0x400CE33")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnWatchLive;

		// Token: 0x0400CE34 RID: 52788
		[Token(Token = "0x400CE34")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnRelationshipGraph;

		// Token: 0x0400CE35 RID: 52789
		[Token(Token = "0x400CE35")]
		[FieldOffset(Offset = "0x98")]
		public UIWidget RelationshipGraphWidget;

		// Token: 0x0400CE36 RID: 52790
		[Token(Token = "0x400CE36")]
		[FieldOffset(Offset = "0xA0")]
		public UIInput SearchInput;

		// Token: 0x0400CE37 RID: 52791
		[Token(Token = "0x400CE37")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton SearchButton;

		// Token: 0x0400CE38 RID: 52792
		[Token(Token = "0x400CE38")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject SearchClearSprite;

		// Token: 0x0400CE39 RID: 52793
		[Token(Token = "0x400CE39")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SearchSprite;

		// Token: 0x0400CE3A RID: 52794
		[Token(Token = "0x400CE3A")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel FriendCountTitle;

		// Token: 0x0400CE3B RID: 52795
		[Token(Token = "0x400CE3B")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel FriendCountLabel;

		// Token: 0x0400CE3C RID: 52796
		[Token(Token = "0x400CE3C")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject MiddleContents;

		// Token: 0x0400CE3D RID: 52797
		[Token(Token = "0x400CE3D")]
		[FieldOffset(Offset = "0xD8")]
		public UIScrollView FriendListScrollView;

		// Token: 0x0400CE3E RID: 52798
		[Token(Token = "0x400CE3E")]
		[FieldOffset(Offset = "0xE0")]
		public UIEasyList FriendList;

		// Token: 0x0400CE3F RID: 52799
		[Token(Token = "0x400CE3F")]
		[FieldOffset(Offset = "0xE8")]
		public UIScrollView FriendCallbackScrollView;

		// Token: 0x0400CE40 RID: 52800
		[Token(Token = "0x400CE40")]
		[FieldOffset(Offset = "0xF0")]
		public UITable TableContent;

		// Token: 0x0400CE41 RID: 52801
		[Token(Token = "0x400CE41")]
		[FieldOffset(Offset = "0xF8")]
		public Transform AddFriendRoot;

		// Token: 0x0400CE42 RID: 52802
		[Token(Token = "0x400CE42")]
		[FieldOffset(Offset = "0x100")]
		public Transform FriendRelationshipGraphRoot;
	}
}
