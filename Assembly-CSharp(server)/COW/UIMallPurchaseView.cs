using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241D RID: 9245
	[Token(Token = "0x200241D")]
	public class UIMallPurchaseView : UIBaseView
	{
		// Token: 0x0600C34A RID: 49994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34A")]
		[Address(RVA = "0x1DF0EBC", Offset = "0x1DF0EBC", VA = "0x7BBC5F0EBC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C34B RID: 49995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C34B")]
		[Address(RVA = "0x1DF17C4", Offset = "0x1DF17C4", VA = "0x7BBC5F17C4")]
		public UIMallPurchaseView()
		{
		}

		// Token: 0x0400E4F8 RID: 58616
		[Token(Token = "0x400E4F8")]
		[FieldOffset(Offset = "0x20")]
		public UILabel ItemNameLabel;

		// Token: 0x0400E4F9 RID: 58617
		[Token(Token = "0x400E4F9")]
		[FieldOffset(Offset = "0x28")]
		public UILabel purchaseDescLabel;

		// Token: 0x0400E4FA RID: 58618
		[Token(Token = "0x400E4FA")]
		[FieldOffset(Offset = "0x30")]
		public Transform ItemContainer;

		// Token: 0x0400E4FB RID: 58619
		[Token(Token = "0x400E4FB")]
		[FieldOffset(Offset = "0x38")]
		public UIButton GoldPurchaseBtn;

		// Token: 0x0400E4FC RID: 58620
		[Token(Token = "0x400E4FC")]
		[FieldOffset(Offset = "0x40")]
		public UILabel GoldPrice;

		// Token: 0x0400E4FD RID: 58621
		[Token(Token = "0x400E4FD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GoldVoucherEffect;

		// Token: 0x0400E4FE RID: 58622
		[Token(Token = "0x400E4FE")]
		[FieldOffset(Offset = "0x50")]
		public UIButton GemsPurchaseBtn;

		// Token: 0x0400E4FF RID: 58623
		[Token(Token = "0x400E4FF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel GemsPrice;

		// Token: 0x0400E500 RID: 58624
		[Token(Token = "0x400E500")]
		[FieldOffset(Offset = "0x60")]
		public GameObject DiamondVoucherEffect;

		// Token: 0x0400E501 RID: 58625
		[Token(Token = "0x400E501")]
		[FieldOffset(Offset = "0x68")]
		public UIButton ExchangeBtn;

		// Token: 0x0400E502 RID: 58626
		[Token(Token = "0x400E502")]
		[FieldOffset(Offset = "0x70")]
		public UISprite ExchangeIcon;

		// Token: 0x0400E503 RID: 58627
		[Token(Token = "0x400E503")]
		[FieldOffset(Offset = "0x78")]
		public UILabel ExchagneLabel;

		// Token: 0x0400E504 RID: 58628
		[Token(Token = "0x400E504")]
		[FieldOffset(Offset = "0x80")]
		public UIButton ClanExchangeBtn;

		// Token: 0x0400E505 RID: 58629
		[Token(Token = "0x400E505")]
		[FieldOffset(Offset = "0x88")]
		public UISprite ClanExchangeIcon;

		// Token: 0x0400E506 RID: 58630
		[Token(Token = "0x400E506")]
		[FieldOffset(Offset = "0x90")]
		public UILabel ClanExchagneLabel;

		// Token: 0x0400E507 RID: 58631
		[Token(Token = "0x400E507")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ClanDiamondLabel;

		// Token: 0x0400E508 RID: 58632
		[Token(Token = "0x400E508")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject GoldAndGems;

		// Token: 0x0400E509 RID: 58633
		[Token(Token = "0x400E509")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton DualCurrencyGoldPurchaseBtn;

		// Token: 0x0400E50A RID: 58634
		[Token(Token = "0x400E50A")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel DualCurrencyGoldPrice;

		// Token: 0x0400E50B RID: 58635
		[Token(Token = "0x400E50B")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject DualCurrencyGoldVoucherEffect;

		// Token: 0x0400E50C RID: 58636
		[Token(Token = "0x400E50C")]
		[FieldOffset(Offset = "0xC0")]
		public UIButton DualCurrencyGemsPurchaseBtn;

		// Token: 0x0400E50D RID: 58637
		[Token(Token = "0x400E50D")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel DualCurrencyGemsPrice;

		// Token: 0x0400E50E RID: 58638
		[Token(Token = "0x400E50E")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject DualCurrencyDiamondVoucherEffect;

		// Token: 0x0400E50F RID: 58639
		[Token(Token = "0x400E50F")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton ForgeExchangeBtn;

		// Token: 0x0400E510 RID: 58640
		[Token(Token = "0x400E510")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite Material2Icon;

		// Token: 0x0400E511 RID: 58641
		[Token(Token = "0x400E511")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite Material1Icon;

		// Token: 0x0400E512 RID: 58642
		[Token(Token = "0x400E512")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel Material2Cnt;

		// Token: 0x0400E513 RID: 58643
		[Token(Token = "0x400E513")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel Material1Cnt;

		// Token: 0x0400E514 RID: 58644
		[Token(Token = "0x400E514")]
		[FieldOffset(Offset = "0x100")]
		public GameObject Add;

		// Token: 0x0400E515 RID: 58645
		[Token(Token = "0x400E515")]
		[FieldOffset(Offset = "0x108")]
		public UIVoucher Voucher;

		// Token: 0x0400E516 RID: 58646
		[Token(Token = "0x400E516")]
		[FieldOffset(Offset = "0x110")]
		public GameObject ModifyNumContainer;

		// Token: 0x0400E517 RID: 58647
		[Token(Token = "0x400E517")]
		[FieldOffset(Offset = "0x118")]
		public UIButton PlusBtn;

		// Token: 0x0400E518 RID: 58648
		[Token(Token = "0x400E518")]
		[FieldOffset(Offset = "0x120")]
		public UIInput CountInput;

		// Token: 0x0400E519 RID: 58649
		[Token(Token = "0x400E519")]
		[FieldOffset(Offset = "0x128")]
		public UILabel CountLabel;

		// Token: 0x0400E51A RID: 58650
		[Token(Token = "0x400E51A")]
		[FieldOffset(Offset = "0x130")]
		public UIButton MinusBtn;

		// Token: 0x0400E51B RID: 58651
		[Token(Token = "0x400E51B")]
		[FieldOffset(Offset = "0x138")]
		public UIButton MaxBtn;

		// Token: 0x0400E51C RID: 58652
		[Token(Token = "0x400E51C")]
		[FieldOffset(Offset = "0x140")]
		public UILabel LabelMax;

		// Token: 0x0400E51D RID: 58653
		[Token(Token = "0x400E51D")]
		[FieldOffset(Offset = "0x148")]
		public UIButton AddTenBtn;

		// Token: 0x0400E51E RID: 58654
		[Token(Token = "0x400E51E")]
		[FieldOffset(Offset = "0x150")]
		public UILabel limitedPurchaseLabel;
	}
}
