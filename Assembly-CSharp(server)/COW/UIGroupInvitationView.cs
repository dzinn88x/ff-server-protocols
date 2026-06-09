using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002249 RID: 8777
	[Token(Token = "0x2002249")]
	internal class UIGroupInvitationView : UIBaseView
	{
		// Token: 0x0600BFA3 RID: 49059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA3")]
		[Address(RVA = "0x1A88AB4", Offset = "0x1A88AB4", VA = "0x7BBC288AB4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA4")]
		[Address(RVA = "0x1A8908C", Offset = "0x1A8908C", VA = "0x7BBC28908C")]
		public UIGroupInvitationView()
		{
		}

		// Token: 0x0400D273 RID: 53875
		[Token(Token = "0x400D273")]
		[FieldOffset(Offset = "0x20")]
		public GameObject UIGroupInvitation;

		// Token: 0x0400D274 RID: 53876
		[Token(Token = "0x400D274")]
		[FieldOffset(Offset = "0x28")]
		public GameObject friends;

		// Token: 0x0400D275 RID: 53877
		[Token(Token = "0x400D275")]
		[FieldOffset(Offset = "0x30")]
		public UIButton refreshBtn;

		// Token: 0x0400D276 RID: 53878
		[Token(Token = "0x400D276")]
		[FieldOffset(Offset = "0x38")]
		public UIInput InputName;

		// Token: 0x0400D277 RID: 53879
		[Token(Token = "0x400D277")]
		[FieldOffset(Offset = "0x40")]
		public UIButton searchBtn;

		// Token: 0x0400D278 RID: 53880
		[Token(Token = "0x400D278")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView scrollview;

		// Token: 0x0400D279 RID: 53881
		[Token(Token = "0x400D279")]
		[FieldOffset(Offset = "0x50")]
		public UIPanel ScrollPanel;

		// Token: 0x0400D27A RID: 53882
		[Token(Token = "0x400D27A")]
		[FieldOffset(Offset = "0x58")]
		public UIEasyList ListGrid;

		// Token: 0x0400D27B RID: 53883
		[Token(Token = "0x400D27B")]
		[FieldOffset(Offset = "0x60")]
		public UIWrapContent wrapcontent;

		// Token: 0x0400D27C RID: 53884
		[Token(Token = "0x400D27C")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelInterAppInvite;

		// Token: 0x0400D27D RID: 53885
		[Token(Token = "0x400D27D")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid GridInterAppInvite;

		// Token: 0x0400D27E RID: 53886
		[Token(Token = "0x400D27E")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnLineInvite;

		// Token: 0x0400D27F RID: 53887
		[Token(Token = "0x400D27F")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnFBInvite;

		// Token: 0x0400D280 RID: 53888
		[Token(Token = "0x400D280")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnVKInvite;

		// Token: 0x0400D281 RID: 53889
		[Token(Token = "0x400D281")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnOtherInvite;

		// Token: 0x0400D282 RID: 53890
		[Token(Token = "0x400D282")]
		[FieldOffset(Offset = "0x98")]
		public UILabel NumCnt;

		// Token: 0x0400D283 RID: 53891
		[Token(Token = "0x400D283")]
		[FieldOffset(Offset = "0xA0")]
		public UITable TabTable;

		// Token: 0x0400D284 RID: 53892
		[Token(Token = "0x400D284")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject FriendTab;

		// Token: 0x0400D285 RID: 53893
		[Token(Token = "0x400D285")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButton FriendToggleBtn;

		// Token: 0x0400D286 RID: 53894
		[Token(Token = "0x400D286")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject ClanTab;

		// Token: 0x0400D287 RID: 53895
		[Token(Token = "0x400D287")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggleButton ClanToggleBtn;

		// Token: 0x0400D288 RID: 53896
		[Token(Token = "0x400D288")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton Mask;
	}
}
