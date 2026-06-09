using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241A RID: 9242
	[Token(Token = "0x200241A")]
	public class UIMallGiftView : UIBaseView
	{
		// Token: 0x0600C344 RID: 49988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C344")]
		[Address(RVA = "0x1C74388", Offset = "0x1C74388", VA = "0x7BBC474388", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C345 RID: 49989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C345")]
		[Address(RVA = "0x1C74AC4", Offset = "0x1C74AC4", VA = "0x7BBC474AC4")]
		public UIMallGiftView()
		{
		}

		// Token: 0x0400E4A8 RID: 58536
		[Token(Token = "0x400E4A8")]
		[FieldOffset(Offset = "0x20")]
		public Transform UIMallGift;

		// Token: 0x0400E4A9 RID: 58537
		[Token(Token = "0x400E4A9")]
		[FieldOffset(Offset = "0x28")]
		public UITable Table;

		// Token: 0x0400E4AA RID: 58538
		[Token(Token = "0x400E4AA")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SelectNum;

		// Token: 0x0400E4AB RID: 58539
		[Token(Token = "0x400E4AB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Diamond;

		// Token: 0x0400E4AC RID: 58540
		[Token(Token = "0x400E4AC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel DiamondPrice;

		// Token: 0x0400E4AD RID: 58541
		[Token(Token = "0x400E4AD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject OR;

		// Token: 0x0400E4AE RID: 58542
		[Token(Token = "0x400E4AE")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Gold;

		// Token: 0x0400E4AF RID: 58543
		[Token(Token = "0x400E4AF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel GoldPrice;

		// Token: 0x0400E4B0 RID: 58544
		[Token(Token = "0x400E4B0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SelectFriendPanel;

		// Token: 0x0400E4B1 RID: 58545
		[Token(Token = "0x400E4B1")]
		[FieldOffset(Offset = "0x68")]
		public UIInput SearchInput;

		// Token: 0x0400E4B2 RID: 58546
		[Token(Token = "0x400E4B2")]
		[FieldOffset(Offset = "0x70")]
		public UIButton SearchBtn;

		// Token: 0x0400E4B3 RID: 58547
		[Token(Token = "0x400E4B3")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton FriendBtn;

		// Token: 0x0400E4B4 RID: 58548
		[Token(Token = "0x400E4B4")]
		[FieldOffset(Offset = "0x80")]
		public UIToggleButton ClanFriendBtn;

		// Token: 0x0400E4B5 RID: 58549
		[Token(Token = "0x400E4B5")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButton AllSelectBtn;

		// Token: 0x0400E4B6 RID: 58550
		[Token(Token = "0x400E4B6")]
		[FieldOffset(Offset = "0x90")]
		public UIButton NextBtn;

		// Token: 0x0400E4B7 RID: 58551
		[Token(Token = "0x400E4B7")]
		[FieldOffset(Offset = "0x98")]
		public UIEasyList Grid;

		// Token: 0x0400E4B8 RID: 58552
		[Token(Token = "0x400E4B8")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel Tips;

		// Token: 0x0400E4B9 RID: 58553
		[Token(Token = "0x400E4B9")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton RuleButton;

		// Token: 0x0400E4BA RID: 58554
		[Token(Token = "0x400E4BA")]
		[FieldOffset(Offset = "0xB0")]
		public Transform SelectPanelTablePos;

		// Token: 0x0400E4BB RID: 58555
		[Token(Token = "0x400E4BB")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject GiveGiftPanel;

		// Token: 0x0400E4BC RID: 58556
		[Token(Token = "0x400E4BC")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel ReceiversNum;

		// Token: 0x0400E4BD RID: 58557
		[Token(Token = "0x400E4BD")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject CallSignList;

		// Token: 0x0400E4BE RID: 58558
		[Token(Token = "0x400E4BE")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject CallsingPanel;

		// Token: 0x0400E4BF RID: 58559
		[Token(Token = "0x400E4BF")]
		[FieldOffset(Offset = "0xD8")]
		public UIEasyList NameListGrid;

		// Token: 0x0400E4C0 RID: 58560
		[Token(Token = "0x400E4C0")]
		[FieldOffset(Offset = "0xE0")]
		public UIGrid ReceiverCallsignGrid;

		// Token: 0x0400E4C1 RID: 58561
		[Token(Token = "0x400E4C1")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton ShowReceiverListBtn;

		// Token: 0x0400E4C2 RID: 58562
		[Token(Token = "0x400E4C2")]
		[FieldOffset(Offset = "0xF0")]
		public UIInput MessageInput;

		// Token: 0x0400E4C3 RID: 58563
		[Token(Token = "0x400E4C3")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton SendBtn;

		// Token: 0x0400E4C4 RID: 58564
		[Token(Token = "0x400E4C4")]
		[FieldOffset(Offset = "0x100")]
		public Transform GivePanelTablePos;
	}
}
