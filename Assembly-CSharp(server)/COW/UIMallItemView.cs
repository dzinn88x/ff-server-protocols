using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200241B RID: 9243
	[Token(Token = "0x200241B")]
	internal class UIMallItemView : UIBaseView
	{
		// Token: 0x0600C346 RID: 49990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C346")]
		[Address(RVA = "0x1DEC5A8", Offset = "0x1DEC5A8", VA = "0x7BBC5EC5A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C347 RID: 49991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C347")]
		[Address(RVA = "0x1DED088", Offset = "0x1DED088", VA = "0x7BBC5ED088")]
		public UIMallItemView()
		{
		}

		// Token: 0x0400E4C5 RID: 58565
		[Token(Token = "0x400E4C5")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E4C6 RID: 58566
		[Token(Token = "0x400E4C6")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400E4C7 RID: 58567
		[Token(Token = "0x400E4C7")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NormalContainer;

		// Token: 0x0400E4C8 RID: 58568
		[Token(Token = "0x400E4C8")]
		[FieldOffset(Offset = "0x38")]
		public BaseItemView BaseInfoView;

		// Token: 0x0400E4C9 RID: 58569
		[Token(Token = "0x400E4C9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject HighLightBG;

		// Token: 0x0400E4CA RID: 58570
		[Token(Token = "0x400E4CA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject timePanel;

		// Token: 0x0400E4CB RID: 58571
		[Token(Token = "0x400E4CB")]
		[FieldOffset(Offset = "0x50")]
		public UILabel time;

		// Token: 0x0400E4CC RID: 58572
		[Token(Token = "0x400E4CC")]
		[FieldOffset(Offset = "0x58")]
		public UISprite BG;

		// Token: 0x0400E4CD RID: 58573
		[Token(Token = "0x400E4CD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BG_grey;

		// Token: 0x0400E4CE RID: 58574
		[Token(Token = "0x400E4CE")]
		[FieldOffset(Offset = "0x68")]
		public GameObject LimitedTitle;

		// Token: 0x0400E4CF RID: 58575
		[Token(Token = "0x400E4CF")]
		[FieldOffset(Offset = "0x70")]
		public GameObject PreviewTitle;

		// Token: 0x0400E4D0 RID: 58576
		[Token(Token = "0x400E4D0")]
		[FieldOffset(Offset = "0x78")]
		public UISprite Descargar;

		// Token: 0x0400E4D1 RID: 58577
		[Token(Token = "0x400E4D1")]
		[FieldOffset(Offset = "0x80")]
		public UIButton DownloadBtn;

		// Token: 0x0400E4D2 RID: 58578
		[Token(Token = "0x400E4D2")]
		[FieldOffset(Offset = "0x88")]
		public UILabel ClanLevelTitle;

		// Token: 0x0400E4D3 RID: 58579
		[Token(Token = "0x400E4D3")]
		[FieldOffset(Offset = "0x90")]
		public UISprite ItemIcon;

		// Token: 0x0400E4D4 RID: 58580
		[Token(Token = "0x400E4D4")]
		[FieldOffset(Offset = "0x98")]
		public UISprite HeadIcon;

		// Token: 0x0400E4D5 RID: 58581
		[Token(Token = "0x400E4D5")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite BannerIcon;

		// Token: 0x0400E4D6 RID: 58582
		[Token(Token = "0x400E4D6")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite DebrisIcon;

		// Token: 0x0400E4D7 RID: 58583
		[Token(Token = "0x400E4D7")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite VehicleSkinIcon;

		// Token: 0x0400E4D8 RID: 58584
		[Token(Token = "0x400E4D8")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite WeaponSkinIcon;

		// Token: 0x0400E4D9 RID: 58585
		[Token(Token = "0x400E4D9")]
		[FieldOffset(Offset = "0xC0")]
		public Transform GoldContainer;

		// Token: 0x0400E4DA RID: 58586
		[Token(Token = "0x400E4DA")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject GoldIcon;

		// Token: 0x0400E4DB RID: 58587
		[Token(Token = "0x400E4DB")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel GoldPritceLabel;

		// Token: 0x0400E4DC RID: 58588
		[Token(Token = "0x400E4DC")]
		[FieldOffset(Offset = "0xD8")]
		public Transform DiamondContainer;

		// Token: 0x0400E4DD RID: 58589
		[Token(Token = "0x400E4DD")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel DiamondPritceLabel;

		// Token: 0x0400E4DE RID: 58590
		[Token(Token = "0x400E4DE")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject DiamonIcon;

		// Token: 0x0400E4DF RID: 58591
		[Token(Token = "0x400E4DF")]
		[FieldOffset(Offset = "0xF0")]
		public Transform ExchangeContainer;

		// Token: 0x0400E4E0 RID: 58592
		[Token(Token = "0x400E4E0")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel ExchangePriceLabel;

		// Token: 0x0400E4E1 RID: 58593
		[Token(Token = "0x400E4E1")]
		[FieldOffset(Offset = "0x100")]
		public UISprite ExchangeIcon;

		// Token: 0x0400E4E2 RID: 58594
		[Token(Token = "0x400E4E2")]
		[FieldOffset(Offset = "0x108")]
		public Transform ClanDiamondContainer;

		// Token: 0x0400E4E3 RID: 58595
		[Token(Token = "0x400E4E3")]
		[FieldOffset(Offset = "0x110")]
		public UILabel ClanDiamondPriceLabel;

		// Token: 0x0400E4E4 RID: 58596
		[Token(Token = "0x400E4E4")]
		[FieldOffset(Offset = "0x118")]
		public UISprite ClanDiamondIcon;

		// Token: 0x0400E4E5 RID: 58597
		[Token(Token = "0x400E4E5")]
		[FieldOffset(Offset = "0x120")]
		public GameObject UniquedTitle;

		// Token: 0x0400E4E6 RID: 58598
		[Token(Token = "0x400E4E6")]
		[FieldOffset(Offset = "0x128")]
		public GameObject DiscountItemIcon;

		// Token: 0x0400E4E7 RID: 58599
		[Token(Token = "0x400E4E7")]
		[FieldOffset(Offset = "0x130")]
		public GameObject WebTitleContainer;

		// Token: 0x0400E4E8 RID: 58600
		[Token(Token = "0x400E4E8")]
		[FieldOffset(Offset = "0x138")]
		public GameObject OverDueTitle;

		// Token: 0x0400E4E9 RID: 58601
		[Token(Token = "0x400E4E9")]
		[FieldOffset(Offset = "0x140")]
		public UISprite DiscountTag;

		// Token: 0x0400E4EA RID: 58602
		[Token(Token = "0x400E4EA")]
		[FieldOffset(Offset = "0x148")]
		public UILabel TagLabel;

		// Token: 0x0400E4EB RID: 58603
		[Token(Token = "0x400E4EB")]
		[FieldOffset(Offset = "0x150")]
		public UISprite NewTag;

		// Token: 0x0400E4EC RID: 58604
		[Token(Token = "0x400E4EC")]
		[FieldOffset(Offset = "0x158")]
		public UISprite HotTag;

		// Token: 0x0400E4ED RID: 58605
		[Token(Token = "0x400E4ED")]
		[FieldOffset(Offset = "0x160")]
		public UISprite LimitTag;

		// Token: 0x0400E4EE RID: 58606
		[Token(Token = "0x400E4EE")]
		[FieldOffset(Offset = "0x168")]
		public UISprite LimitCountTag;

		// Token: 0x0400E4EF RID: 58607
		[Token(Token = "0x400E4EF")]
		[FieldOffset(Offset = "0x170")]
		public UISprite EarlyAccess;

		// Token: 0x0400E4F0 RID: 58608
		[Token(Token = "0x400E4F0")]
		[FieldOffset(Offset = "0x178")]
		public UISprite RankIcon;

		// Token: 0x0400E4F1 RID: 58609
		[Token(Token = "0x400E4F1")]
		[FieldOffset(Offset = "0x180")]
		public UISprite VoucherIcon;

		// Token: 0x0400E4F2 RID: 58610
		[Token(Token = "0x400E4F2")]
		[FieldOffset(Offset = "0x188")]
		public UISprite RedEnvelopeIcon;

		// Token: 0x0400E4F3 RID: 58611
		[Token(Token = "0x400E4F3")]
		[FieldOffset(Offset = "0x190")]
		public GameObject DefaultContainer;
	}
}
