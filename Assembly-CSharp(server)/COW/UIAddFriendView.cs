using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020ED RID: 8429
	[Token(Token = "0x20020ED")]
	public class UIAddFriendView : UIBaseView
	{
		// Token: 0x0600BCEB RID: 48363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEB")]
		[Address(RVA = "0x1968820", Offset = "0x1968820", VA = "0x7BBC168820", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCEC")]
		[Address(RVA = "0x1968CA4", Offset = "0x1968CA4", VA = "0x7BBC168CA4")]
		public UIAddFriendView()
		{
		}

		// Token: 0x0400BF75 RID: 49013
		[Token(Token = "0x400BF75")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ClearButton;

		// Token: 0x0400BF76 RID: 49014
		[Token(Token = "0x400BF76")]
		[FieldOffset(Offset = "0x28")]
		public UIInput SearchInput;

		// Token: 0x0400BF77 RID: 49015
		[Token(Token = "0x400BF77")]
		[FieldOffset(Offset = "0x30")]
		public UIButton SearchBtn;

		// Token: 0x0400BF78 RID: 49016
		[Token(Token = "0x400BF78")]
		[FieldOffset(Offset = "0x38")]
		public UIButton RefreshSelectBtn;

		// Token: 0x0400BF79 RID: 49017
		[Token(Token = "0x400BF79")]
		[FieldOffset(Offset = "0x40")]
		public UIButton RefreshBtn;

		// Token: 0x0400BF7A RID: 49018
		[Token(Token = "0x400BF7A")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RefreshGreyObj;

		// Token: 0x0400BF7B RID: 49019
		[Token(Token = "0x400BF7B")]
		[FieldOffset(Offset = "0x50")]
		public UICountDownLabel RefreshCDLabel;

		// Token: 0x0400BF7C RID: 49020
		[Token(Token = "0x400BF7C")]
		[FieldOffset(Offset = "0x58")]
		public UIButton Language;

		// Token: 0x0400BF7D RID: 49021
		[Token(Token = "0x400BF7D")]
		[FieldOffset(Offset = "0x60")]
		public UISprite LanguageSprite;

		// Token: 0x0400BF7E RID: 49022
		[Token(Token = "0x400BF7E")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LanguageLabel;

		// Token: 0x0400BF7F RID: 49023
		[Token(Token = "0x400BF7F")]
		[FieldOffset(Offset = "0x70")]
		public Transform TimeActive;

		// Token: 0x0400BF80 RID: 49024
		[Token(Token = "0x400BF80")]
		[FieldOffset(Offset = "0x78")]
		public Transform ModePrefer;

		// Token: 0x0400BF81 RID: 49025
		[Token(Token = "0x400BF81")]
		[FieldOffset(Offset = "0x80")]
		public Transform Gender;

		// Token: 0x0400BF82 RID: 49026
		[Token(Token = "0x400BF82")]
		[FieldOffset(Offset = "0x88")]
		public UILabel InterestLabel;

		// Token: 0x0400BF83 RID: 49027
		[Token(Token = "0x400BF83")]
		[FieldOffset(Offset = "0x90")]
		public UIScrollView FriendListScrollView;

		// Token: 0x0400BF84 RID: 49028
		[Token(Token = "0x400BF84")]
		[FieldOffset(Offset = "0x98")]
		public UIEasyList FriendList;

		// Token: 0x0400BF85 RID: 49029
		[Token(Token = "0x400BF85")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel FriendListEmptyHint;
	}
}
