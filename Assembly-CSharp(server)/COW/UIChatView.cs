using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002154 RID: 8532
	[Token(Token = "0x2002154")]
	public class UIChatView : UIBaseView
	{
		// Token: 0x0600BDB8 RID: 48568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB8")]
		[Address(RVA = "0x1BEB1BC", Offset = "0x1BEB1BC", VA = "0x7BBC3EB1BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDB9")]
		[Address(RVA = "0x1BEBBA0", Offset = "0x1BEBBA0", VA = "0x7BBC3EBBA0")]
		public UIChatView()
		{
		}

		// Token: 0x0400C4F2 RID: 50418
		[Token(Token = "0x400C4F2")]
		[FieldOffset(Offset = "0x20")]
		public UIEasyList ChannelList;

		// Token: 0x0400C4F3 RID: 50419
		[Token(Token = "0x400C4F3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject InputNode;

		// Token: 0x0400C4F4 RID: 50420
		[Token(Token = "0x400C4F4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SendMessageContainer;

		// Token: 0x0400C4F5 RID: 50421
		[Token(Token = "0x400C4F5")]
		[FieldOffset(Offset = "0x38")]
		public UIInput InputContainer;

		// Token: 0x0400C4F6 RID: 50422
		[Token(Token = "0x400C4F6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel InputDefaultLabel;

		// Token: 0x0400C4F7 RID: 50423
		[Token(Token = "0x400C4F7")]
		[FieldOffset(Offset = "0x48")]
		public UIButton EnterBtn;

		// Token: 0x0400C4F8 RID: 50424
		[Token(Token = "0x400C4F8")]
		[FieldOffset(Offset = "0x50")]
		public UIGrid OtherSendBtnGrid;

		// Token: 0x0400C4F9 RID: 50425
		[Token(Token = "0x400C4F9")]
		[FieldOffset(Offset = "0x58")]
		public UIButton OpenStickerBtn;

		// Token: 0x0400C4FA RID: 50426
		[Token(Token = "0x400C4FA")]
		[FieldOffset(Offset = "0x60")]
		public UIButton LoudSpeakerBtn;

		// Token: 0x0400C4FB RID: 50427
		[Token(Token = "0x400C4FB")]
		[FieldOffset(Offset = "0x68")]
		public UISprite SpeakerIcon;

		// Token: 0x0400C4FC RID: 50428
		[Token(Token = "0x400C4FC")]
		[FieldOffset(Offset = "0x70")]
		public UILabel SpeakerNum;

		// Token: 0x0400C4FD RID: 50429
		[Token(Token = "0x400C4FD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject MutedNode;

		// Token: 0x0400C4FE RID: 50430
		[Token(Token = "0x400C4FE")]
		[FieldOffset(Offset = "0x80")]
		public UIButton MutedHintBtn;

		// Token: 0x0400C4FF RID: 50431
		[Token(Token = "0x400C4FF")]
		[FieldOffset(Offset = "0x88")]
		public Transform MutedCountDown;

		// Token: 0x0400C500 RID: 50432
		[Token(Token = "0x400C500")]
		[FieldOffset(Offset = "0x90")]
		public GameObject NewMessage;

		// Token: 0x0400C501 RID: 50433
		[Token(Token = "0x400C501")]
		[FieldOffset(Offset = "0x98")]
		public UIButton NewMessageBtn;

		// Token: 0x0400C502 RID: 50434
		[Token(Token = "0x400C502")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel NewMessageLabel;

		// Token: 0x0400C503 RID: 50435
		[Token(Token = "0x400C503")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject IngameHint;

		// Token: 0x0400C504 RID: 50436
		[Token(Token = "0x400C504")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel WhisperStatusHint;

		// Token: 0x0400C505 RID: 50437
		[Token(Token = "0x400C505")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject StickerNode;

		// Token: 0x0400C506 RID: 50438
		[Token(Token = "0x400C506")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton CloseStickerBtn;

		// Token: 0x0400C507 RID: 50439
		[Token(Token = "0x400C507")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButtonGroup StickerToggleBtnGroup;

		// Token: 0x0400C508 RID: 50440
		[Token(Token = "0x400C508")]
		[FieldOffset(Offset = "0xD0")]
		public UIGrid StickerTabGrid;

		// Token: 0x0400C509 RID: 50441
		[Token(Token = "0x400C509")]
		[FieldOffset(Offset = "0xD8")]
		public StickerTabView StickerTabItemInstance;

		// Token: 0x0400C50A RID: 50442
		[Token(Token = "0x400C50A")]
		[FieldOffset(Offset = "0xE0")]
		public UIScrollView StickerSpriteList;

		// Token: 0x0400C50B RID: 50443
		[Token(Token = "0x400C50B")]
		[FieldOffset(Offset = "0xE8")]
		public UITable StickerSpriteTable;

		// Token: 0x0400C50C RID: 50444
		[Token(Token = "0x400C50C")]
		[FieldOffset(Offset = "0xF0")]
		public StickerSpriteView StickerSpriteInstance;

		// Token: 0x0400C50D RID: 50445
		[Token(Token = "0x400C50D")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject PurchaseGameObject;

		// Token: 0x0400C50E RID: 50446
		[Token(Token = "0x400C50E")]
		[FieldOffset(Offset = "0x100")]
		public UIButton PurchaseBtn;

		// Token: 0x0400C50F RID: 50447
		[Token(Token = "0x400C50F")]
		[FieldOffset(Offset = "0x108")]
		public GameObject DiamondGO;

		// Token: 0x0400C510 RID: 50448
		[Token(Token = "0x400C510")]
		[FieldOffset(Offset = "0x110")]
		public UILabel StickerPriceDiamond;

		// Token: 0x0400C511 RID: 50449
		[Token(Token = "0x400C511")]
		[FieldOffset(Offset = "0x118")]
		public GameObject CoinGO;

		// Token: 0x0400C512 RID: 50450
		[Token(Token = "0x400C512")]
		[FieldOffset(Offset = "0x120")]
		public UILabel StickerPriceCoin;

		// Token: 0x0400C513 RID: 50451
		[Token(Token = "0x400C513")]
		[FieldOffset(Offset = "0x128")]
		public Transform MessageContainer;

		// Token: 0x0400C514 RID: 50452
		[Token(Token = "0x400C514")]
		[FieldOffset(Offset = "0x130")]
		public GameObject ContentNode;

		// Token: 0x0400C515 RID: 50453
		[Token(Token = "0x400C515")]
		[FieldOffset(Offset = "0x138")]
		public GameObject NormalMessageNode;

		// Token: 0x0400C516 RID: 50454
		[Token(Token = "0x400C516")]
		[FieldOffset(Offset = "0x140")]
		public UIScrollView MessageList;

		// Token: 0x0400C517 RID: 50455
		[Token(Token = "0x400C517")]
		[FieldOffset(Offset = "0x148")]
		public UITable MessageListTable;

		// Token: 0x0400C518 RID: 50456
		[Token(Token = "0x400C518")]
		[FieldOffset(Offset = "0x150")]
		public GameObject EmptyNode;

		// Token: 0x0400C519 RID: 50457
		[Token(Token = "0x400C519")]
		[FieldOffset(Offset = "0x158")]
		public GameObject NoMessageHint;
	}
}
