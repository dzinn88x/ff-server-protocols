using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002165 RID: 8549
	[Token(Token = "0x2002165")]
	public class UIClanChatItemView : UIBaseView
	{
		// Token: 0x0600BDDA RID: 48602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDA")]
		[Address(RVA = "0x1CEF0B4", Offset = "0x1CEF0B4", VA = "0x7BBC4EF0B4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDB")]
		[Address(RVA = "0x1CEF494", Offset = "0x1CEF494", VA = "0x7BBC4EF494")]
		public UIClanChatItemView()
		{
		}

		// Token: 0x0400C5A3 RID: 50595
		[Token(Token = "0x400C5A3")]
		[FieldOffset(Offset = "0x20")]
		public BaseChatMessageView LeftView;

		// Token: 0x0400C5A4 RID: 50596
		[Token(Token = "0x400C5A4")]
		[FieldOffset(Offset = "0x28")]
		public UIButton headbtnleft;

		// Token: 0x0400C5A5 RID: 50597
		[Token(Token = "0x400C5A5")]
		[FieldOffset(Offset = "0x30")]
		public UIButton LeftContentBtn;

		// Token: 0x0400C5A6 RID: 50598
		[Token(Token = "0x400C5A6")]
		[FieldOffset(Offset = "0x38")]
		public BaseChatMessageView RightView;

		// Token: 0x0400C5A7 RID: 50599
		[Token(Token = "0x400C5A7")]
		[FieldOffset(Offset = "0x40")]
		public UIButton headbtn;

		// Token: 0x0400C5A8 RID: 50600
		[Token(Token = "0x400C5A8")]
		[FieldOffset(Offset = "0x48")]
		public UIButton RightContentBtn;

		// Token: 0x0400C5A9 RID: 50601
		[Token(Token = "0x400C5A9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ChatTips;

		// Token: 0x0400C5AA RID: 50602
		[Token(Token = "0x400C5AA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PrivateWarning;

		// Token: 0x0400C5AB RID: 50603
		[Token(Token = "0x400C5AB")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AddFriendTip;

		// Token: 0x0400C5AC RID: 50604
		[Token(Token = "0x400C5AC")]
		[FieldOffset(Offset = "0x68")]
		public UILabel QuickAddFriendLabel;

		// Token: 0x0400C5AD RID: 50605
		[Token(Token = "0x400C5AD")]
		[FieldOffset(Offset = "0x70")]
		public GameObject AddFriendBtnContainer;

		// Token: 0x0400C5AE RID: 50606
		[Token(Token = "0x400C5AE")]
		[FieldOffset(Offset = "0x78")]
		public UIButton quickAddFriendBtn;

		// Token: 0x0400C5AF RID: 50607
		[Token(Token = "0x400C5AF")]
		[FieldOffset(Offset = "0x80")]
		public UISprite AddFriendBtnSprite;

		// Token: 0x0400C5B0 RID: 50608
		[Token(Token = "0x400C5B0")]
		[FieldOffset(Offset = "0x88")]
		public UISprite AddFriendBtnIcon;

		// Token: 0x0400C5B1 RID: 50609
		[Token(Token = "0x400C5B1")]
		[FieldOffset(Offset = "0x90")]
		public UISprite AddFriendBtnLight;
	}
}
