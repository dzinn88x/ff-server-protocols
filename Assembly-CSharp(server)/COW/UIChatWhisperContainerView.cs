using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002155 RID: 8533
	[Token(Token = "0x2002155")]
	public class UIChatWhisperContainerView : UIBaseView
	{
		// Token: 0x0600BDBA RID: 48570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBA")]
		[Address(RVA = "0x1BEF740", Offset = "0x1BEF740", VA = "0x7BBC3EF740", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDBB RID: 48571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDBB")]
		[Address(RVA = "0x1BEFDF8", Offset = "0x1BEFDF8", VA = "0x7BBC3EFDF8")]
		public UIChatWhisperContainerView()
		{
		}

		// Token: 0x0400C51A RID: 50458
		[Token(Token = "0x400C51A")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget Widget;

		// Token: 0x0400C51B RID: 50459
		[Token(Token = "0x400C51B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C51C RID: 50460
		[Token(Token = "0x400C51C")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView WhisperMessageList;

		// Token: 0x0400C51D RID: 50461
		[Token(Token = "0x400C51D")]
		[FieldOffset(Offset = "0x38")]
		public GameObject EmptyNode;

		// Token: 0x0400C51E RID: 50462
		[Token(Token = "0x400C51E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject NoMessageHint;

		// Token: 0x0400C51F RID: 50463
		[Token(Token = "0x400C51F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NoWhisperObjcetHint;

		// Token: 0x0400C520 RID: 50464
		[Token(Token = "0x400C520")]
		[FieldOffset(Offset = "0x50")]
		public GameObject TopMessage;

		// Token: 0x0400C521 RID: 50465
		[Token(Token = "0x400C521")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ChatWith;

		// Token: 0x0400C522 RID: 50466
		[Token(Token = "0x400C522")]
		[FieldOffset(Offset = "0x60")]
		public UIButton SendGift;

		// Token: 0x0400C523 RID: 50467
		[Token(Token = "0x400C523")]
		[FieldOffset(Offset = "0x68")]
		public UIButton Profile;

		// Token: 0x0400C524 RID: 50468
		[Token(Token = "0x400C524")]
		[FieldOffset(Offset = "0x70")]
		public UIDragScrollView WhisperNameListDrag;

		// Token: 0x0400C525 RID: 50469
		[Token(Token = "0x400C525")]
		[FieldOffset(Offset = "0x78")]
		public UIScrollView WhisperNameListSV;

		// Token: 0x0400C526 RID: 50470
		[Token(Token = "0x400C526")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList WhisperNameEasyList;

		// Token: 0x0400C527 RID: 50471
		[Token(Token = "0x400C527")]
		[FieldOffset(Offset = "0x88")]
		public UIScrollView WhisperNameListRecentSV;

		// Token: 0x0400C528 RID: 50472
		[Token(Token = "0x400C528")]
		[FieldOffset(Offset = "0x90")]
		public UIEasyList WhisperNameRecentEasyList;

		// Token: 0x0400C529 RID: 50473
		[Token(Token = "0x400C529")]
		[FieldOffset(Offset = "0x98")]
		public UIButton AddFriendBtn;

		// Token: 0x0400C52A RID: 50474
		[Token(Token = "0x400C52A")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject NoRecentWhisperGO;

		// Token: 0x0400C52B RID: 50475
		[Token(Token = "0x400C52B")]
		[FieldOffset(Offset = "0xA8")]
		public UIToggleButton FriendTabBtn;

		// Token: 0x0400C52C RID: 50476
		[Token(Token = "0x400C52C")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButton RecentTabBtn;

		// Token: 0x0400C52D RID: 50477
		[Token(Token = "0x400C52D")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject UnreadTip;

		// Token: 0x0400C52E RID: 50478
		[Token(Token = "0x400C52E")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject SearchGO;

		// Token: 0x0400C52F RID: 50479
		[Token(Token = "0x400C52F")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton RefreshBtn;

		// Token: 0x0400C530 RID: 50480
		[Token(Token = "0x400C530")]
		[FieldOffset(Offset = "0xD0")]
		public UIInput InputIDField;

		// Token: 0x0400C531 RID: 50481
		[Token(Token = "0x400C531")]
		[FieldOffset(Offset = "0xD8")]
		public TweenAlpha DefaultLabelWink;

		// Token: 0x0400C532 RID: 50482
		[Token(Token = "0x400C532")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton SearchBtn;

		// Token: 0x0400C533 RID: 50483
		[Token(Token = "0x400C533")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject SearchBtnSprite;

		// Token: 0x0400C534 RID: 50484
		[Token(Token = "0x400C534")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject SearchClearSprite;
	}
}
