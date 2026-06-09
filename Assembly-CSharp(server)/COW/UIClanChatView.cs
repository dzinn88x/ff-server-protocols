using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002166 RID: 8550
	[Token(Token = "0x2002166")]
	public class UIClanChatView : UIBaseView
	{
		// Token: 0x0600BDDC RID: 48604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDC")]
		[Address(RVA = "0x1CEF49C", Offset = "0x1CEF49C", VA = "0x7BBC4EF49C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDD")]
		[Address(RVA = "0x1CEFBFC", Offset = "0x1CEFBFC", VA = "0x7BBC4EFBFC")]
		public UIClanChatView()
		{
		}

		// Token: 0x0400C5B2 RID: 50610
		[Token(Token = "0x400C5B2")]
		[FieldOffset(Offset = "0x20")]
		public GameObject EmptyNode;

		// Token: 0x0400C5B3 RID: 50611
		[Token(Token = "0x400C5B3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ContentNode;

		// Token: 0x0400C5B4 RID: 50612
		[Token(Token = "0x400C5B4")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView MessageList;

		// Token: 0x0400C5B5 RID: 50613
		[Token(Token = "0x400C5B5")]
		[FieldOffset(Offset = "0x38")]
		public UITable MessageListTable;

		// Token: 0x0400C5B6 RID: 50614
		[Token(Token = "0x400C5B6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject MutedNode;

		// Token: 0x0400C5B7 RID: 50615
		[Token(Token = "0x400C5B7")]
		[FieldOffset(Offset = "0x48")]
		public UIButton MutedHintBtn;

		// Token: 0x0400C5B8 RID: 50616
		[Token(Token = "0x400C5B8")]
		[FieldOffset(Offset = "0x50")]
		public Transform MutedCountDown;

		// Token: 0x0400C5B9 RID: 50617
		[Token(Token = "0x400C5B9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SendMessageContainer;

		// Token: 0x0400C5BA RID: 50618
		[Token(Token = "0x400C5BA")]
		[FieldOffset(Offset = "0x60")]
		public UIInput InputContainer;

		// Token: 0x0400C5BB RID: 50619
		[Token(Token = "0x400C5BB")]
		[FieldOffset(Offset = "0x68")]
		public UIButton EnterBtn;

		// Token: 0x0400C5BC RID: 50620
		[Token(Token = "0x400C5BC")]
		[FieldOffset(Offset = "0x70")]
		public UIButton OpenStickerBtn;

		// Token: 0x0400C5BD RID: 50621
		[Token(Token = "0x400C5BD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NewMessage;

		// Token: 0x0400C5BE RID: 50622
		[Token(Token = "0x400C5BE")]
		[FieldOffset(Offset = "0x80")]
		public UIButton NewMessageBtn;

		// Token: 0x0400C5BF RID: 50623
		[Token(Token = "0x400C5BF")]
		[FieldOffset(Offset = "0x88")]
		public UILabel NewMessageLabel;

		// Token: 0x0400C5C0 RID: 50624
		[Token(Token = "0x400C5C0")]
		[FieldOffset(Offset = "0x90")]
		public GameObject IngameHint;

		// Token: 0x0400C5C1 RID: 50625
		[Token(Token = "0x400C5C1")]
		[FieldOffset(Offset = "0x98")]
		public UILabel WhisperStatusHint;

		// Token: 0x0400C5C2 RID: 50626
		[Token(Token = "0x400C5C2")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject StickerNode;

		// Token: 0x0400C5C3 RID: 50627
		[Token(Token = "0x400C5C3")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton CloseStickerBtn;

		// Token: 0x0400C5C4 RID: 50628
		[Token(Token = "0x400C5C4")]
		[FieldOffset(Offset = "0xB0")]
		public UIToggleButtonGroup StickerToggleBtnGroup;

		// Token: 0x0400C5C5 RID: 50629
		[Token(Token = "0x400C5C5")]
		[FieldOffset(Offset = "0xB8")]
		public UIGrid StickerTabGrid;

		// Token: 0x0400C5C6 RID: 50630
		[Token(Token = "0x400C5C6")]
		[FieldOffset(Offset = "0xC0")]
		public StickerTabView StickerTabItemInstance;

		// Token: 0x0400C5C7 RID: 50631
		[Token(Token = "0x400C5C7")]
		[FieldOffset(Offset = "0xC8")]
		public UIScrollView StickerSpriteList;

		// Token: 0x0400C5C8 RID: 50632
		[Token(Token = "0x400C5C8")]
		[FieldOffset(Offset = "0xD0")]
		public UITable StickerSpriteTable;

		// Token: 0x0400C5C9 RID: 50633
		[Token(Token = "0x400C5C9")]
		[FieldOffset(Offset = "0xD8")]
		public StickerSpriteView StickerSpriteInstance;

		// Token: 0x0400C5CA RID: 50634
		[Token(Token = "0x400C5CA")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject OwnedObject;

		// Token: 0x0400C5CB RID: 50635
		[Token(Token = "0x400C5CB")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton PurchaseBtn;

		// Token: 0x0400C5CC RID: 50636
		[Token(Token = "0x400C5CC")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject DiamondGO;

		// Token: 0x0400C5CD RID: 50637
		[Token(Token = "0x400C5CD")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel StickerPriceDiamond;

		// Token: 0x0400C5CE RID: 50638
		[Token(Token = "0x400C5CE")]
		[FieldOffset(Offset = "0x100")]
		public GameObject CoinGO;

		// Token: 0x0400C5CF RID: 50639
		[Token(Token = "0x400C5CF")]
		[FieldOffset(Offset = "0x108")]
		public UILabel StickerPriceCoin;
	}
}
