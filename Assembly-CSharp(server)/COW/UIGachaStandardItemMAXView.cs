using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002228 RID: 8744
	[Token(Token = "0x2002228")]
	public class UIGachaStandardItemMAXView : UIBaseView
	{
		// Token: 0x0600BF61 RID: 48993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF61")]
		[Address(RVA = "0x1FA1978", Offset = "0x1FA1978", VA = "0x7BBC7A1978", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF62 RID: 48994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF62")]
		[Address(RVA = "0x1FA24B4", Offset = "0x1FA24B4", VA = "0x7BBC7A24B4")]
		public UIGachaStandardItemMAXView()
		{
		}

		// Token: 0x0400D00D RID: 53261
		[Token(Token = "0x400D00D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400D00E RID: 53262
		[Token(Token = "0x400D00E")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400D00F RID: 53263
		[Token(Token = "0x400D00F")]
		[FieldOffset(Offset = "0x30")]
		public GameObject VFX;

		// Token: 0x0400D010 RID: 53264
		[Token(Token = "0x400D010")]
		[FieldOffset(Offset = "0x38")]
		public GameObject GreyBg;

		// Token: 0x0400D011 RID: 53265
		[Token(Token = "0x400D011")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLightBG;

		// Token: 0x0400D012 RID: 53266
		[Token(Token = "0x400D012")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NewLabel;

		// Token: 0x0400D013 RID: 53267
		[Token(Token = "0x400D013")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LimitedLabel;

		// Token: 0x0400D014 RID: 53268
		[Token(Token = "0x400D014")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LimitedPurchaseLabel;

		// Token: 0x0400D015 RID: 53269
		[Token(Token = "0x400D015")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HotLabel;

		// Token: 0x0400D016 RID: 53270
		[Token(Token = "0x400D016")]
		[FieldOffset(Offset = "0x68")]
		public UILabel DiscountLabel;

		// Token: 0x0400D017 RID: 53271
		[Token(Token = "0x400D017")]
		[FieldOffset(Offset = "0x70")]
		public GameObject EarlyBirdLabel;

		// Token: 0x0400D018 RID: 53272
		[Token(Token = "0x400D018")]
		[FieldOffset(Offset = "0x78")]
		public UILabel ExpireTime;

		// Token: 0x0400D019 RID: 53273
		[Token(Token = "0x400D019")]
		[FieldOffset(Offset = "0x80")]
		public UISprite QualityBG;

		// Token: 0x0400D01A RID: 53274
		[Token(Token = "0x400D01A")]
		[FieldOffset(Offset = "0x88")]
		public UISprite QualityNameBG01;

		// Token: 0x0400D01B RID: 53275
		[Token(Token = "0x400D01B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject BaseItemView;

		// Token: 0x0400D01C RID: 53276
		[Token(Token = "0x400D01C")]
		[FieldOffset(Offset = "0x98")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400D01D RID: 53277
		[Token(Token = "0x400D01D")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite VoucherIcon;

		// Token: 0x0400D01E RID: 53278
		[Token(Token = "0x400D01E")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject BaseitemName;

		// Token: 0x0400D01F RID: 53279
		[Token(Token = "0x400D01F")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Free;

		// Token: 0x0400D020 RID: 53280
		[Token(Token = "0x400D020")]
		[FieldOffset(Offset = "0xB8")]
		public UIGrid PriceContainer;

		// Token: 0x0400D021 RID: 53281
		[Token(Token = "0x400D021")]
		[FieldOffset(Offset = "0xC0")]
		public Transform GoldContainer;

		// Token: 0x0400D022 RID: 53282
		[Token(Token = "0x400D022")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel GoldPriceLabel;

		// Token: 0x0400D023 RID: 53283
		[Token(Token = "0x400D023")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel GoldOriginalPriceLabel;

		// Token: 0x0400D024 RID: 53284
		[Token(Token = "0x400D024")]
		[FieldOffset(Offset = "0xD8")]
		public Transform DiamondContainer;

		// Token: 0x0400D025 RID: 53285
		[Token(Token = "0x400D025")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel DiamondPriceLabel;

		// Token: 0x0400D026 RID: 53286
		[Token(Token = "0x400D026")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel DiamondOriginalPriceLabel;

		// Token: 0x0400D027 RID: 53287
		[Token(Token = "0x400D027")]
		[FieldOffset(Offset = "0xF0")]
		public Transform ExchangeContainer;

		// Token: 0x0400D028 RID: 53288
		[Token(Token = "0x400D028")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel ExchangePriceLabel;

		// Token: 0x0400D029 RID: 53289
		[Token(Token = "0x400D029")]
		[FieldOffset(Offset = "0x100")]
		public UISprite ExchangeIcon;

		// Token: 0x0400D02A RID: 53290
		[Token(Token = "0x400D02A")]
		[FieldOffset(Offset = "0x108")]
		public GameObject GemsAndGoldContainer;

		// Token: 0x0400D02B RID: 53291
		[Token(Token = "0x400D02B")]
		[FieldOffset(Offset = "0x110")]
		public UILabel DualCurrencyGoldPrice;

		// Token: 0x0400D02C RID: 53292
		[Token(Token = "0x400D02C")]
		[FieldOffset(Offset = "0x118")]
		public UILabel DualCurrencyGemsPrice;

		// Token: 0x0400D02D RID: 53293
		[Token(Token = "0x400D02D")]
		[FieldOffset(Offset = "0x120")]
		public GameObject CheckIcon;

		// Token: 0x0400D02E RID: 53294
		[Token(Token = "0x400D02E")]
		[FieldOffset(Offset = "0x128")]
		public GameObject OverDueTitle;

		// Token: 0x0400D02F RID: 53295
		[Token(Token = "0x400D02F")]
		[FieldOffset(Offset = "0x130")]
		public GameObject LockedTitle;

		// Token: 0x0400D030 RID: 53296
		[Token(Token = "0x400D030")]
		[FieldOffset(Offset = "0x138")]
		public GameObject OwnedTitle;

		// Token: 0x0400D031 RID: 53297
		[Token(Token = "0x400D031")]
		[FieldOffset(Offset = "0x140")]
		public GameObject ClaimedTitle;

		// Token: 0x0400D032 RID: 53298
		[Token(Token = "0x400D032")]
		[FieldOffset(Offset = "0x148")]
		public GameObject LimitedTitle;

		// Token: 0x0400D033 RID: 53299
		[Token(Token = "0x400D033")]
		[FieldOffset(Offset = "0x150")]
		public UILabel CanNotEquipTitle;

		// Token: 0x0400D034 RID: 53300
		[Token(Token = "0x400D034")]
		[FieldOffset(Offset = "0x158")]
		public GameObject PreviewFemale;

		// Token: 0x0400D035 RID: 53301
		[Token(Token = "0x400D035")]
		[FieldOffset(Offset = "0x160")]
		public GameObject PreviewMale;

		// Token: 0x0400D036 RID: 53302
		[Token(Token = "0x400D036")]
		[FieldOffset(Offset = "0x168")]
		public GameObject PreviewCommon;

		// Token: 0x0400D037 RID: 53303
		[Token(Token = "0x400D037")]
		[FieldOffset(Offset = "0x170")]
		public GameObject WebTitleContainer;

		// Token: 0x0400D038 RID: 53304
		[Token(Token = "0x400D038")]
		[FieldOffset(Offset = "0x178")]
		public UISprite RankIcon;

		// Token: 0x0400D039 RID: 53305
		[Token(Token = "0x400D039")]
		[FieldOffset(Offset = "0x180")]
		public UISprite Descargar;

		// Token: 0x0400D03A RID: 53306
		[Token(Token = "0x400D03A")]
		[FieldOffset(Offset = "0x188")]
		public UILabel ClanLevelLabel;

		// Token: 0x0400D03B RID: 53307
		[Token(Token = "0x400D03B")]
		[FieldOffset(Offset = "0x190")]
		public UISprite IPTag;

		// Token: 0x0400D03C RID: 53308
		[Token(Token = "0x400D03C")]
		[FieldOffset(Offset = "0x198")]
		public GameObject DiscountEffect;

		// Token: 0x0400D03D RID: 53309
		[Token(Token = "0x400D03D")]
		[FieldOffset(Offset = "0x1A0")]
		public UITipsButton Tips;
	}
}
