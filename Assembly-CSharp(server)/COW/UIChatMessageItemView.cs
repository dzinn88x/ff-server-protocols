using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200214E RID: 8526
	[Token(Token = "0x200214E")]
	public class UIChatMessageItemView : UIBaseView
	{
		// Token: 0x0600BDAC RID: 48556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAC")]
		[Address(RVA = "0x1BE5270", Offset = "0x1BE5270", VA = "0x7BBC3E5270", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDAD")]
		[Address(RVA = "0x1BE5650", Offset = "0x1BE5650", VA = "0x7BBC3E5650")]
		public UIChatMessageItemView()
		{
		}

		// Token: 0x0400C4B7 RID: 50359
		[Token(Token = "0x400C4B7")]
		[FieldOffset(Offset = "0x20")]
		public BaseChatMessageView RightView;

		// Token: 0x0400C4B8 RID: 50360
		[Token(Token = "0x400C4B8")]
		[FieldOffset(Offset = "0x28")]
		public UIButton headbtn;

		// Token: 0x0400C4B9 RID: 50361
		[Token(Token = "0x400C4B9")]
		[FieldOffset(Offset = "0x30")]
		public UIButton RightContentBtn;

		// Token: 0x0400C4BA RID: 50362
		[Token(Token = "0x400C4BA")]
		[FieldOffset(Offset = "0x38")]
		public BaseChatMessageView LeftView;

		// Token: 0x0400C4BB RID: 50363
		[Token(Token = "0x400C4BB")]
		[FieldOffset(Offset = "0x40")]
		public UIButton headbtnleft;

		// Token: 0x0400C4BC RID: 50364
		[Token(Token = "0x400C4BC")]
		[FieldOffset(Offset = "0x48")]
		public UIButton LeftContentBtn;

		// Token: 0x0400C4BD RID: 50365
		[Token(Token = "0x400C4BD")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ChatTips;

		// Token: 0x0400C4BE RID: 50366
		[Token(Token = "0x400C4BE")]
		[FieldOffset(Offset = "0x58")]
		public GameObject PrivateWarning;

		// Token: 0x0400C4BF RID: 50367
		[Token(Token = "0x400C4BF")]
		[FieldOffset(Offset = "0x60")]
		public GameObject AddFriendTip;

		// Token: 0x0400C4C0 RID: 50368
		[Token(Token = "0x400C4C0")]
		[FieldOffset(Offset = "0x68")]
		public UILabel QuickAddFriendLabel;

		// Token: 0x0400C4C1 RID: 50369
		[Token(Token = "0x400C4C1")]
		[FieldOffset(Offset = "0x70")]
		public GameObject AddFriendBtnContainer;

		// Token: 0x0400C4C2 RID: 50370
		[Token(Token = "0x400C4C2")]
		[FieldOffset(Offset = "0x78")]
		public UIButton quickAddFriendBtn;

		// Token: 0x0400C4C3 RID: 50371
		[Token(Token = "0x400C4C3")]
		[FieldOffset(Offset = "0x80")]
		public UISprite AddFriendBtnSprite;

		// Token: 0x0400C4C4 RID: 50372
		[Token(Token = "0x400C4C4")]
		[FieldOffset(Offset = "0x88")]
		public UISprite AddFriendBtnIcon;

		// Token: 0x0400C4C5 RID: 50373
		[Token(Token = "0x400C4C5")]
		[FieldOffset(Offset = "0x90")]
		public UISprite AddFriendBtnLight;
	}
}
