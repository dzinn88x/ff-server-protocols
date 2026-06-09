using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200244D RID: 9293
	[Token(Token = "0x200244D")]
	public class UIMVPRewardWndView : UIBaseView
	{
		// Token: 0x0600C3AA RID: 50090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AA")]
		[Address(RVA = "0x1CD7374", Offset = "0x1CD7374", VA = "0x7BBC4D7374", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3AB")]
		[Address(RVA = "0x1CD7D5C", Offset = "0x1CD7D5C", VA = "0x7BBC4D7D5C")]
		public UIMVPRewardWndView()
		{
		}

		// Token: 0x0400E7CE RID: 59342
		[Token(Token = "0x400E7CE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Mask;

		// Token: 0x0400E7CF RID: 59343
		[Token(Token = "0x400E7CF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RewardContainer;

		// Token: 0x0400E7D0 RID: 59344
		[Token(Token = "0x400E7D0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ExtraItem;

		// Token: 0x0400E7D1 RID: 59345
		[Token(Token = "0x400E7D1")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid RewardGrid;

		// Token: 0x0400E7D2 RID: 59346
		[Token(Token = "0x400E7D2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RewardGridLeftPos;

		// Token: 0x0400E7D3 RID: 59347
		[Token(Token = "0x400E7D3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject RewardGridMiddlePos;

		// Token: 0x0400E7D4 RID: 59348
		[Token(Token = "0x400E7D4")]
		[FieldOffset(Offset = "0x50")]
		public GameObject RewardGridLeftPosLegend;

		// Token: 0x0400E7D5 RID: 59349
		[Token(Token = "0x400E7D5")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid BtnGroup;

		// Token: 0x0400E7D6 RID: 59350
		[Token(Token = "0x400E7D6")]
		[FieldOffset(Offset = "0x60")]
		public UIButton RepurchaseBtn;

		// Token: 0x0400E7D7 RID: 59351
		[Token(Token = "0x400E7D7")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RepurchaseLabel;

		// Token: 0x0400E7D8 RID: 59352
		[Token(Token = "0x400E7D8")]
		[FieldOffset(Offset = "0x70")]
		public UILabel FreeLabel;

		// Token: 0x0400E7D9 RID: 59353
		[Token(Token = "0x400E7D9")]
		[FieldOffset(Offset = "0x78")]
		public UICountDownIcon CountDownIcon;

		// Token: 0x0400E7DA RID: 59354
		[Token(Token = "0x400E7DA")]
		[FieldOffset(Offset = "0x80")]
		public UICountDownLabel GachaCountDownLabel;

		// Token: 0x0400E7DB RID: 59355
		[Token(Token = "0x400E7DB")]
		[FieldOffset(Offset = "0x88")]
		public UISprite CurrencyIcon;

		// Token: 0x0400E7DC RID: 59356
		[Token(Token = "0x400E7DC")]
		[FieldOffset(Offset = "0x90")]
		public UILabel CurrencyCountLabel;

		// Token: 0x0400E7DD RID: 59357
		[Token(Token = "0x400E7DD")]
		[FieldOffset(Offset = "0x98")]
		public UIButton OKBtn;

		// Token: 0x0400E7DE RID: 59358
		[Token(Token = "0x400E7DE")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton OpenBtn;

		// Token: 0x0400E7DF RID: 59359
		[Token(Token = "0x400E7DF")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton FastEquipBtn;

		// Token: 0x0400E7E0 RID: 59360
		[Token(Token = "0x400E7E0")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VoucherGroup;

		// Token: 0x0400E7E1 RID: 59361
		[Token(Token = "0x400E7E1")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton ExchangeBtn;

		// Token: 0x0400E7E2 RID: 59362
		[Token(Token = "0x400E7E2")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel TotalVourcherCntLabel;

		// Token: 0x0400E7E3 RID: 59363
		[Token(Token = "0x400E7E3")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel CurVoucherCntLabel;

		// Token: 0x0400E7E4 RID: 59364
		[Token(Token = "0x400E7E4")]
		[FieldOffset(Offset = "0xD0")]
		public UISprite VoucherIcon;

		// Token: 0x0400E7E5 RID: 59365
		[Token(Token = "0x400E7E5")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject Share;

		// Token: 0x0400E7E6 RID: 59366
		[Token(Token = "0x400E7E6")]
		[FieldOffset(Offset = "0xE0")]
		public UIButton GoToSharePreViewBtn;

		// Token: 0x0400E7E7 RID: 59367
		[Token(Token = "0x400E7E7")]
		[FieldOffset(Offset = "0xE8")]
		public Animator ShareIconAnimator;

		// Token: 0x0400E7E8 RID: 59368
		[Token(Token = "0x400E7E8")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel DescLabel;

		// Token: 0x0400E7E9 RID: 59369
		[Token(Token = "0x400E7E9")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject VFX;

		// Token: 0x0400E7EA RID: 59370
		[Token(Token = "0x400E7EA")]
		[FieldOffset(Offset = "0x100")]
		public GameObject Glow_Green;

		// Token: 0x0400E7EB RID: 59371
		[Token(Token = "0x400E7EB")]
		[FieldOffset(Offset = "0x108")]
		public GameObject Glow_Orange;

		// Token: 0x0400E7EC RID: 59372
		[Token(Token = "0x400E7EC")]
		[FieldOffset(Offset = "0x110")]
		public GameObject Glow_Purple;

		// Token: 0x0400E7ED RID: 59373
		[Token(Token = "0x400E7ED")]
		[FieldOffset(Offset = "0x118")]
		public GameObject Glow_Orange_Permanent;

		// Token: 0x0400E7EE RID: 59374
		[Token(Token = "0x400E7EE")]
		[FieldOffset(Offset = "0x120")]
		public GameObject Glow_White;

		// Token: 0x0400E7EF RID: 59375
		[Token(Token = "0x400E7EF")]
		[FieldOffset(Offset = "0x128")]
		public GameObject Glow_Blue;

		// Token: 0x0400E7F0 RID: 59376
		[Token(Token = "0x400E7F0")]
		[FieldOffset(Offset = "0x130")]
		public GameObject Glow_Light_Permanent;

		// Token: 0x0400E7F1 RID: 59377
		[Token(Token = "0x400E7F1")]
		[FieldOffset(Offset = "0x138")]
		public GameObject Glow_Red;

		// Token: 0x0400E7F2 RID: 59378
		[Token(Token = "0x400E7F2")]
		[FieldOffset(Offset = "0x140")]
		public GameObject Glow_Red_Permanent;

		// Token: 0x0400E7F3 RID: 59379
		[Token(Token = "0x400E7F3")]
		[FieldOffset(Offset = "0x148")]
		public GameObject BG;

		// Token: 0x0400E7F4 RID: 59380
		[Token(Token = "0x400E7F4")]
		[FieldOffset(Offset = "0x150")]
		public GameObject BGStyle0;

		// Token: 0x0400E7F5 RID: 59381
		[Token(Token = "0x400E7F5")]
		[FieldOffset(Offset = "0x158")]
		public UIButton BtnClose;

		// Token: 0x0400E7F6 RID: 59382
		[Token(Token = "0x400E7F6")]
		[FieldOffset(Offset = "0x160")]
		public UILabel WndTitle;

		// Token: 0x0400E7F7 RID: 59383
		[Token(Token = "0x400E7F7")]
		[FieldOffset(Offset = "0x168")]
		public Transform BGTopPos0;

		// Token: 0x0400E7F8 RID: 59384
		[Token(Token = "0x400E7F8")]
		[FieldOffset(Offset = "0x170")]
		public Transform BGBottomPos0;
	}
}
