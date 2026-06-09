using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002172 RID: 8562
	[Token(Token = "0x2002172")]
	public class UICloseFriendView : UIBaseView
	{
		// Token: 0x0600BDF4 RID: 48628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF4")]
		[Address(RVA = "0x209568C", Offset = "0x209568C", VA = "0x7BBC89568C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDF5 RID: 48629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF5")]
		[Address(RVA = "0x2096100", Offset = "0x2096100", VA = "0x7BBC896100")]
		public UICloseFriendView()
		{
		}

		// Token: 0x0400C69F RID: 50847
		[Token(Token = "0x400C69F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel RelationshipTitle;

		// Token: 0x0400C6A0 RID: 50848
		[Token(Token = "0x400C6A0")]
		[FieldOffset(Offset = "0x28")]
		public UIButton DescTipsBtn;

		// Token: 0x0400C6A1 RID: 50849
		[Token(Token = "0x400C6A1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject CloseFriendOwn;

		// Token: 0x0400C6A2 RID: 50850
		[Token(Token = "0x400C6A2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CheckboxForNotifyBoxContent;

		// Token: 0x0400C6A3 RID: 50851
		[Token(Token = "0x400C6A3")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle CheckboxForNotify;

		// Token: 0x0400C6A4 RID: 50852
		[Token(Token = "0x400C6A4")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BreakTipsShowBtn;

		// Token: 0x0400C6A5 RID: 50853
		[Token(Token = "0x400C6A5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BreakTipsLabel;

		// Token: 0x0400C6A6 RID: 50854
		[Token(Token = "0x400C6A6")]
		[FieldOffset(Offset = "0x58")]
		public UICountDownLabel BreakTipsCountdownLabel;

		// Token: 0x0400C6A7 RID: 50855
		[Token(Token = "0x400C6A7")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CallBackBtn;

		// Token: 0x0400C6A8 RID: 50856
		[Token(Token = "0x400C6A8")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ClickMask;

		// Token: 0x0400C6A9 RID: 50857
		[Token(Token = "0x400C6A9")]
		[FieldOffset(Offset = "0x70")]
		public UIButton RelationshipSettingBtn;

		// Token: 0x0400C6AA RID: 50858
		[Token(Token = "0x400C6AA")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BreakRequestBtn;

		// Token: 0x0400C6AB RID: 50859
		[Token(Token = "0x400C6AB")]
		[FieldOffset(Offset = "0x80")]
		public UIButton ClickMask_2;

		// Token: 0x0400C6AC RID: 50860
		[Token(Token = "0x400C6AC")]
		[FieldOffset(Offset = "0x88")]
		public UISprite myHeadPic;

		// Token: 0x0400C6AD RID: 50861
		[Token(Token = "0x400C6AD")]
		[FieldOffset(Offset = "0x90")]
		public UILabel myNickName;

		// Token: 0x0400C6AE RID: 50862
		[Token(Token = "0x400C6AE")]
		[FieldOffset(Offset = "0x98")]
		public UISprite CloseFriendPic;

		// Token: 0x0400C6AF RID: 50863
		[Token(Token = "0x400C6AF")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel CloseFriendNickName;

		// Token: 0x0400C6B0 RID: 50864
		[Token(Token = "0x400C6B0")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject RelationshipVfx;

		// Token: 0x0400C6B1 RID: 50865
		[Token(Token = "0x400C6B1")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel Exp;

		// Token: 0x0400C6B2 RID: 50866
		[Token(Token = "0x400C6B2")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel levellabel;

		// Token: 0x0400C6B3 RID: 50867
		[Token(Token = "0x400C6B3")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite RelationshipIcon;

		// Token: 0x0400C6B4 RID: 50868
		[Token(Token = "0x400C6B4")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton AnniversaryBtn;

		// Token: 0x0400C6B5 RID: 50869
		[Token(Token = "0x400C6B5")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject AnniversaryTips;

		// Token: 0x0400C6B6 RID: 50870
		[Token(Token = "0x400C6B6")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel AnniversaryLabel;

		// Token: 0x0400C6B7 RID: 50871
		[Token(Token = "0x400C6B7")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject RewardList;

		// Token: 0x0400C6B8 RID: 50872
		[Token(Token = "0x400C6B8")]
		[FieldOffset(Offset = "0xE8")]
		public UIProgressBar RewardProgressBar;

		// Token: 0x0400C6B9 RID: 50873
		[Token(Token = "0x400C6B9")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton SendGiftBtn;

		// Token: 0x0400C6BA RID: 50874
		[Token(Token = "0x400C6BA")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton RequestChatBtn;

		// Token: 0x0400C6BB RID: 50875
		[Token(Token = "0x400C6BB")]
		[FieldOffset(Offset = "0x100")]
		public UIButton RequestTeamBtn;

		// Token: 0x0400C6BC RID: 50876
		[Token(Token = "0x400C6BC")]
		[FieldOffset(Offset = "0x108")]
		public GameObject CloseFriendStateNone;

		// Token: 0x0400C6BD RID: 50877
		[Token(Token = "0x400C6BD")]
		[FieldOffset(Offset = "0x110")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400C6BE RID: 50878
		[Token(Token = "0x400C6BE")]
		[FieldOffset(Offset = "0x118")]
		public UISprite PlayerHeadPic;

		// Token: 0x0400C6BF RID: 50879
		[Token(Token = "0x400C6BF")]
		[FieldOffset(Offset = "0x120")]
		public UIButton SelectFriendBtn;

		// Token: 0x0400C6C0 RID: 50880
		[Token(Token = "0x400C6C0")]
		[FieldOffset(Offset = "0x128")]
		public UILabel SelectFriendName;

		// Token: 0x0400C6C1 RID: 50881
		[Token(Token = "0x400C6C1")]
		[FieldOffset(Offset = "0x130")]
		public UICountDownLabel LabelWaitForReply;

		// Token: 0x0400C6C2 RID: 50882
		[Token(Token = "0x400C6C2")]
		[FieldOffset(Offset = "0x138")]
		public GameObject InviteBtnGroup;

		// Token: 0x0400C6C3 RID: 50883
		[Token(Token = "0x400C6C3")]
		[FieldOffset(Offset = "0x140")]
		public GameObject BtnSprite_unchoose;

		// Token: 0x0400C6C4 RID: 50884
		[Token(Token = "0x400C6C4")]
		[FieldOffset(Offset = "0x148")]
		public UIButton UnSelectInviteBtn;

		// Token: 0x0400C6C5 RID: 50885
		[Token(Token = "0x400C6C5")]
		[FieldOffset(Offset = "0x150")]
		public GameObject BtnSprite;

		// Token: 0x0400C6C6 RID: 50886
		[Token(Token = "0x400C6C6")]
		[FieldOffset(Offset = "0x158")]
		public UIButton InviteBtn;

		// Token: 0x0400C6C7 RID: 50887
		[Token(Token = "0x400C6C7")]
		[FieldOffset(Offset = "0x160")]
		public UISprite InviteItemIcon;

		// Token: 0x0400C6C8 RID: 50888
		[Token(Token = "0x400C6C8")]
		[FieldOffset(Offset = "0x168")]
		public UILabel InviteItemCount;

		// Token: 0x0400C6C9 RID: 50889
		[Token(Token = "0x400C6C9")]
		[FieldOffset(Offset = "0x170")]
		public UIButton InvitationListBtn;

		// Token: 0x0400C6CA RID: 50890
		[Token(Token = "0x400C6CA")]
		[FieldOffset(Offset = "0x178")]
		public GameObject tipsNum;
	}
}
