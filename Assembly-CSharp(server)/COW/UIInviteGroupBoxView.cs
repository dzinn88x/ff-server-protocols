using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023CF RID: 9167
	[Token(Token = "0x20023CF")]
	public class UIInviteGroupBoxView : UIBaseView
	{
		// Token: 0x0600C2AE RID: 49838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2AE")]
		[Address(RVA = "0x1928D10", Offset = "0x1928D10", VA = "0x7BBC128D10", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2AF RID: 49839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2AF")]
		[Address(RVA = "0x19294FC", Offset = "0x19294FC", VA = "0x7BBC1294FC")]
		public UIInviteGroupBoxView()
		{
		}

		// Token: 0x0400DF2E RID: 57134
		[Token(Token = "0x400DF2E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Mask;

		// Token: 0x0400DF2F RID: 57135
		[Token(Token = "0x400DF2F")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ClickFilter;

		// Token: 0x0400DF30 RID: 57136
		[Token(Token = "0x400DF30")]
		[FieldOffset(Offset = "0x30")]
		public Transform CenterParent;

		// Token: 0x0400DF31 RID: 57137
		[Token(Token = "0x400DF31")]
		[FieldOffset(Offset = "0x38")]
		public TweenPosition Pivot;

		// Token: 0x0400DF32 RID: 57138
		[Token(Token = "0x400DF32")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RecentTitle;

		// Token: 0x0400DF33 RID: 57139
		[Token(Token = "0x400DF33")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView ScrollView;

		// Token: 0x0400DF34 RID: 57140
		[Token(Token = "0x400DF34")]
		[FieldOffset(Offset = "0x50")]
		public UIEasyList List;

		// Token: 0x0400DF35 RID: 57141
		[Token(Token = "0x400DF35")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid RightGrid;

		// Token: 0x0400DF36 RID: 57142
		[Token(Token = "0x400DF36")]
		[FieldOffset(Offset = "0x60")]
		public UIToggleButtonGroup RightGroup;

		// Token: 0x0400DF37 RID: 57143
		[Token(Token = "0x400DF37")]
		[FieldOffset(Offset = "0x68")]
		public UIToggleButton FriendTab;

		// Token: 0x0400DF38 RID: 57144
		[Token(Token = "0x400DF38")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton ClanTab;

		// Token: 0x0400DF39 RID: 57145
		[Token(Token = "0x400DF39")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton RecentTab;

		// Token: 0x0400DF3A RID: 57146
		[Token(Token = "0x400DF3A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BottomBG;

		// Token: 0x0400DF3B RID: 57147
		[Token(Token = "0x400DF3B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject BottomGrid;

		// Token: 0x0400DF3C RID: 57148
		[Token(Token = "0x400DF3C")]
		[FieldOffset(Offset = "0x90")]
		public UIButton QuickEnter;

		// Token: 0x0400DF3D RID: 57149
		[Token(Token = "0x400DF3D")]
		[FieldOffset(Offset = "0x98")]
		public UIButton Community;

		// Token: 0x0400DF3E RID: 57150
		[Token(Token = "0x400DF3E")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel CommunityLabel;

		// Token: 0x0400DF3F RID: 57151
		[Token(Token = "0x400DF3F")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton AddFriend;

		// Token: 0x0400DF40 RID: 57152
		[Token(Token = "0x400DF40")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton CloseBtn;

		// Token: 0x0400DF41 RID: 57153
		[Token(Token = "0x400DF41")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SearchObj;

		// Token: 0x0400DF42 RID: 57154
		[Token(Token = "0x400DF42")]
		[FieldOffset(Offset = "0xC0")]
		public UIInput SearchInput;

		// Token: 0x0400DF43 RID: 57155
		[Token(Token = "0x400DF43")]
		[FieldOffset(Offset = "0xC8")]
		public TweenAlpha SearchTweenLabel;

		// Token: 0x0400DF44 RID: 57156
		[Token(Token = "0x400DF44")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton SearchBtn;

		// Token: 0x0400DF45 RID: 57157
		[Token(Token = "0x400DF45")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite SearchBtnSprite;

		// Token: 0x0400DF46 RID: 57158
		[Token(Token = "0x400DF46")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SearchClearSprite;

		// Token: 0x0400DF47 RID: 57159
		[Token(Token = "0x400DF47")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton RefreshBtn;

		// Token: 0x0400DF48 RID: 57160
		[Token(Token = "0x400DF48")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject RefreshNormalObj;

		// Token: 0x0400DF49 RID: 57161
		[Token(Token = "0x400DF49")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject RefreshGreyObj;

		// Token: 0x0400DF4A RID: 57162
		[Token(Token = "0x400DF4A")]
		[FieldOffset(Offset = "0x100")]
		public UICountDownLabel RefreshCDLabel;

		// Token: 0x0400DF4B RID: 57163
		[Token(Token = "0x400DF4B")]
		[FieldOffset(Offset = "0x108")]
		public UIButton AddClan;

		// Token: 0x0400DF4C RID: 57164
		[Token(Token = "0x400DF4C")]
		[FieldOffset(Offset = "0x110")]
		public GameObject EmptyClanObj;

		// Token: 0x0400DF4D RID: 57165
		[Token(Token = "0x400DF4D")]
		[FieldOffset(Offset = "0x118")]
		public GameObject EmptyRecentObj;
	}
}
