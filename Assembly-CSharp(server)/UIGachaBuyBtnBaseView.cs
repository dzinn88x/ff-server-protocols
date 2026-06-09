using System;
using COW;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000149 RID: 329
[Token(Token = "0x2000149")]
public class UIGachaBuyBtnBaseView : MonoBehaviour
{
	// Token: 0x06000649 RID: 1609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000649")]
	[Address(RVA = "0x1CA4194", Offset = "0x1CA4194", VA = "0x7BBC4A4194")]
	public UIGachaBuyBtnBaseView()
	{
	}

	// Token: 0x04000556 RID: 1366
	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x18")]
	public bool SupportOneBuyButton;

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x19")]
	public bool SupportMultiBuyButton;

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x1A")]
	public bool SupportOneBuyFree;

	// Token: 0x04000559 RID: 1369
	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x1B")]
	public bool SupportDiscountBuy;

	// Token: 0x0400055A RID: 1370
	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x1C")]
	public bool SupportCoupon;

	// Token: 0x0400055B RID: 1371
	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x1D")]
	public bool SupportLimitBuy;

	// Token: 0x0400055C RID: 1372
	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x1E")]
	public bool SupportFirstReward;

	// Token: 0x0400055D RID: 1373
	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x1F")]
	public bool SupportExtraReward;

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton OneBuyBtn;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OneBuyFree;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x30")]
	public UISprite OneConsumeTypeIcon;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x38")]
	public UISprite OneCurrencyIcon;

	// Token: 0x04000562 RID: 1378
	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x40")]
	public UISprite OneDiscountIcon;

	// Token: 0x04000563 RID: 1379
	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OnePriceLabel;

	// Token: 0x04000564 RID: 1380
	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x50")]
	public GameObject OneLimitContainer;

	// Token: 0x04000565 RID: 1381
	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x58")]
	public UILabel OneLimitPercentLabel;

	// Token: 0x04000566 RID: 1382
	[Token(Token = "0x4000566")]
	[FieldOffset(Offset = "0x60")]
	public GameObject OneDiscountContainer;

	// Token: 0x04000567 RID: 1383
	[Token(Token = "0x4000567")]
	[FieldOffset(Offset = "0x68")]
	public UILabel OnePercentLable;

	// Token: 0x04000568 RID: 1384
	[Token(Token = "0x4000568")]
	[FieldOffset(Offset = "0x70")]
	public UILabel OneOriginalPriceLabel;

	// Token: 0x04000569 RID: 1385
	[Token(Token = "0x4000569")]
	[FieldOffset(Offset = "0x78")]
	public UILabel OneDiscountPriceLabel;

	// Token: 0x0400056A RID: 1386
	[Token(Token = "0x400056A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel OneBuyTips;

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x88")]
	public UICountDownLabel FreeCountdownLabel;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x90")]
	public Transform StandardLabelPos;

	// Token: 0x0400056D RID: 1389
	[Token(Token = "0x400056D")]
	[FieldOffset(Offset = "0x98")]
	public UIButton TenBuyBtn;

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel TenPriceLabel;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite TenConsumeTypeIcon;

	// Token: 0x04000570 RID: 1392
	[Token(Token = "0x4000570")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite TenCurrencyIcon;

	// Token: 0x04000571 RID: 1393
	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite TenDiscountIcon;

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject TenLimitContainer;

	// Token: 0x04000573 RID: 1395
	[Token(Token = "0x4000573")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel TenLimitPercentLabel;

	// Token: 0x04000574 RID: 1396
	[Token(Token = "0x4000574")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject TenDiscountContainer;

	// Token: 0x04000575 RID: 1397
	[Token(Token = "0x4000575")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel TenPercentLable;

	// Token: 0x04000576 RID: 1398
	[Token(Token = "0x4000576")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel TenOriginalPriceLabel;

	// Token: 0x04000577 RID: 1399
	[Token(Token = "0x4000577")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel TenDiscountPriceLabel;

	// Token: 0x04000578 RID: 1400
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel TenBuyLabel;
}
