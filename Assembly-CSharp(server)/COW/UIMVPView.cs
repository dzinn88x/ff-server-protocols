using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002451 RID: 9297
	[Token(Token = "0x2002451")]
	public class UIMVPView : UIBaseView
	{
		// Token: 0x0600C3B2 RID: 50098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B2")]
		[Address(RVA = "0x1CDD6C4", Offset = "0x1CDD6C4", VA = "0x7BBC4DD6C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3B3")]
		[Address(RVA = "0x1CDDF04", Offset = "0x1CDDF04", VA = "0x7BBC4DDF04")]
		public UIMVPView()
		{
		}

		// Token: 0x0400E828 RID: 59432
		[Token(Token = "0x400E828")]
		[FieldOffset(Offset = "0x20")]
		public Animation OpenAnimation;

		// Token: 0x0400E829 RID: 59433
		[Token(Token = "0x400E829")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTextureExt TitleCDN;

		// Token: 0x0400E82A RID: 59434
		[Token(Token = "0x400E82A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelDate;

		// Token: 0x0400E82B RID: 59435
		[Token(Token = "0x400E82B")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid EntrenceGrid;

		// Token: 0x0400E82C RID: 59436
		[Token(Token = "0x400E82C")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnPeakDay;

		// Token: 0x0400E82D RID: 59437
		[Token(Token = "0x400E82D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Bubble;

		// Token: 0x0400E82E RID: 59438
		[Token(Token = "0x400E82E")]
		[FieldOffset(Offset = "0x50")]
		public UILabel BubbleLabel;

		// Token: 0x0400E82F RID: 59439
		[Token(Token = "0x400E82F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BubbleShakeVFX;

		// Token: 0x0400E830 RID: 59440
		[Token(Token = "0x400E830")]
		[FieldOffset(Offset = "0x60")]
		public UILabel PeakDayDate;

		// Token: 0x0400E831 RID: 59441
		[Token(Token = "0x400E831")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnGoGachaLegendary;

		// Token: 0x0400E832 RID: 59442
		[Token(Token = "0x400E832")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BtnGoGachaTip;

		// Token: 0x0400E833 RID: 59443
		[Token(Token = "0x400E833")]
		[FieldOffset(Offset = "0x78")]
		public UIButton BtnActivityPage;

		// Token: 0x0400E834 RID: 59444
		[Token(Token = "0x400E834")]
		[FieldOffset(Offset = "0x80")]
		public GameObject BtnGoWebTip;

		// Token: 0x0400E835 RID: 59445
		[Token(Token = "0x400E835")]
		[FieldOffset(Offset = "0x88")]
		public UINetworkTextureExt CdnGoMystery;

		// Token: 0x0400E836 RID: 59446
		[Token(Token = "0x400E836")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnRule;

		// Token: 0x0400E837 RID: 59447
		[Token(Token = "0x400E837")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid BtnGrid;

		// Token: 0x0400E838 RID: 59448
		[Token(Token = "0x400E838")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnSign;

		// Token: 0x0400E839 RID: 59449
		[Token(Token = "0x400E839")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject BtnSignTip;

		// Token: 0x0400E83A RID: 59450
		[Token(Token = "0x400E83A")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite BgCallDeath;

		// Token: 0x0400E83B RID: 59451
		[Token(Token = "0x400E83B")]
		[FieldOffset(Offset = "0xB8")]
		public UIButton BtnExchange;

		// Token: 0x0400E83C RID: 59452
		[Token(Token = "0x400E83C")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject BtnExchangeTip;

		// Token: 0x0400E83D RID: 59453
		[Token(Token = "0x400E83D")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject TopRightContainer;

		// Token: 0x0400E83E RID: 59454
		[Token(Token = "0x400E83E")]
		[FieldOffset(Offset = "0xD0")]
		public UIButton SugarTokenBtn;

		// Token: 0x0400E83F RID: 59455
		[Token(Token = "0x400E83F")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite Money1Icon;

		// Token: 0x0400E840 RID: 59456
		[Token(Token = "0x400E840")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel SugarTokenCount;

		// Token: 0x0400E841 RID: 59457
		[Token(Token = "0x400E841")]
		[FieldOffset(Offset = "0xE8")]
		public UIButton ExchangeTokenBtn;

		// Token: 0x0400E842 RID: 59458
		[Token(Token = "0x400E842")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite Money2Icon;

		// Token: 0x0400E843 RID: 59459
		[Token(Token = "0x400E843")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel ExchangeTokenCount;

		// Token: 0x0400E844 RID: 59460
		[Token(Token = "0x400E844")]
		[FieldOffset(Offset = "0x100")]
		public UIButton BtnDiceGame;

		// Token: 0x0400E845 RID: 59461
		[Token(Token = "0x400E845")]
		[FieldOffset(Offset = "0x108")]
		public GameObject MonopolyTips;

		// Token: 0x0400E846 RID: 59462
		[Token(Token = "0x400E846")]
		[FieldOffset(Offset = "0x110")]
		public UIButton BtnClose;

		// Token: 0x0400E847 RID: 59463
		[Token(Token = "0x400E847")]
		[FieldOffset(Offset = "0x118")]
		public GameObject CenterContainer;

		// Token: 0x0400E848 RID: 59464
		[Token(Token = "0x400E848")]
		[FieldOffset(Offset = "0x120")]
		public UINetworkTextureExt BgTexture;

		// Token: 0x0400E849 RID: 59465
		[Token(Token = "0x400E849")]
		[FieldOffset(Offset = "0x128")]
		public GameObject Mask;
	}
}
