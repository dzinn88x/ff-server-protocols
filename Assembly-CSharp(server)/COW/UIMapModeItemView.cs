using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002432 RID: 9266
	[Token(Token = "0x2002432")]
	internal class UIMapModeItemView : UIBaseView
	{
		// Token: 0x0600C374 RID: 50036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C374")]
		[Address(RVA = "0x146D5BC", Offset = "0x146D5BC", VA = "0x7BBBC6D5BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C375")]
		[Address(RVA = "0x146DB98", Offset = "0x146DB98", VA = "0x7BBBC6DB98")]
		public UIMapModeItemView()
		{
		}

		// Token: 0x0400E6B1 RID: 59057
		[Token(Token = "0x400E6B1")]
		[FieldOffset(Offset = "0x20")]
		public UIToggleButton MapModeBtn;

		// Token: 0x0400E6B2 RID: 59058
		[Token(Token = "0x400E6B2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject gray;

		// Token: 0x0400E6B3 RID: 59059
		[Token(Token = "0x400E6B3")]
		[FieldOffset(Offset = "0x30")]
		public UISprite mapBg;

		// Token: 0x0400E6B4 RID: 59060
		[Token(Token = "0x400E6B4")]
		[FieldOffset(Offset = "0x38")]
		public UISprite tagBg;

		// Token: 0x0400E6B5 RID: 59061
		[Token(Token = "0x400E6B5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel matchMode;

		// Token: 0x0400E6B6 RID: 59062
		[Token(Token = "0x400E6B6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject MapModeTipsAnim;

		// Token: 0x0400E6B7 RID: 59063
		[Token(Token = "0x400E6B7")]
		[FieldOffset(Offset = "0x50")]
		public GameObject selected;

		// Token: 0x0400E6B8 RID: 59064
		[Token(Token = "0x400E6B8")]
		[FieldOffset(Offset = "0x58")]
		public UILabel tips;

		// Token: 0x0400E6B9 RID: 59065
		[Token(Token = "0x400E6B9")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LimitLabel;

		// Token: 0x0400E6BA RID: 59066
		[Token(Token = "0x400E6BA")]
		[FieldOffset(Offset = "0x68")]
		public GameObject NewLabel;

		// Token: 0x0400E6BB RID: 59067
		[Token(Token = "0x400E6BB")]
		[FieldOffset(Offset = "0x70")]
		public Transform NormalView;

		// Token: 0x0400E6BC RID: 59068
		[Token(Token = "0x400E6BC")]
		[FieldOffset(Offset = "0x78")]
		public UILabel gameMode;

		// Token: 0x0400E6BD RID: 59069
		[Token(Token = "0x400E6BD")]
		[FieldOffset(Offset = "0x80")]
		public UILabel mapMode;

		// Token: 0x0400E6BE RID: 59070
		[Token(Token = "0x400E6BE")]
		[FieldOffset(Offset = "0x88")]
		public Transform BonusView;

		// Token: 0x0400E6BF RID: 59071
		[Token(Token = "0x400E6BF")]
		[FieldOffset(Offset = "0x90")]
		public GameObject BonusReward;

		// Token: 0x0400E6C0 RID: 59072
		[Token(Token = "0x400E6C0")]
		[FieldOffset(Offset = "0x98")]
		public UILabel ladderExtraBonusRateTxt;

		// Token: 0x0400E6C1 RID: 59073
		[Token(Token = "0x400E6C1")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ChampionshipBonusReward;

		// Token: 0x0400E6C2 RID: 59074
		[Token(Token = "0x400E6C2")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel ExpBonusLabel;

		// Token: 0x0400E6C3 RID: 59075
		[Token(Token = "0x400E6C3")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel GoldBonusLabel;

		// Token: 0x0400E6C4 RID: 59076
		[Token(Token = "0x400E6C4")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel BgameMode;

		// Token: 0x0400E6C5 RID: 59077
		[Token(Token = "0x400E6C5")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel BmapMode;

		// Token: 0x0400E6C6 RID: 59078
		[Token(Token = "0x400E6C6")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject DoublePointView;

		// Token: 0x0400E6C7 RID: 59079
		[Token(Token = "0x400E6C7")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject DoubleTokenView;

		// Token: 0x0400E6C8 RID: 59080
		[Token(Token = "0x400E6C8")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject NoDudectView;
	}
}
