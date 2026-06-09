using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020C7 RID: 8391
	[Token(Token = "0x20020C7")]
	public class LadderMatchSeasonChangePopupView : UIBaseView
	{
		// Token: 0x0600BC9F RID: 48287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC9F")]
		[Address(RVA = "0x13FC388", Offset = "0x13FC388", VA = "0x7BBBBFC388", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCA0")]
		[Address(RVA = "0x13FC838", Offset = "0x13FC838", VA = "0x7BBBBFC838")]
		public LadderMatchSeasonChangePopupView()
		{
		}

		// Token: 0x0400BDAD RID: 48557
		[Token(Token = "0x400BDAD")]
		[FieldOffset(Offset = "0x20")]
		public Animator ViewAnimator;

		// Token: 0x0400BDAE RID: 48558
		[Token(Token = "0x400BDAE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject SeasonRankContainer;

		// Token: 0x0400BDAF RID: 48559
		[Token(Token = "0x400BDAF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject RankIconAnim;

		// Token: 0x0400BDB0 RID: 48560
		[Token(Token = "0x400BDB0")]
		[FieldOffset(Offset = "0x38")]
		public UILadderMatchHeroicLevelView HeroicLevelView;

		// Token: 0x0400BDB1 RID: 48561
		[Token(Token = "0x400BDB1")]
		[FieldOffset(Offset = "0x40")]
		public GameObject RankIconRoot;

		// Token: 0x0400BDB2 RID: 48562
		[Token(Token = "0x400BDB2")]
		[FieldOffset(Offset = "0x48")]
		public UILabel RankLabel;

		// Token: 0x0400BDB3 RID: 48563
		[Token(Token = "0x400BDB3")]
		[FieldOffset(Offset = "0x50")]
		public UILabel RankSeasonLabel;

		// Token: 0x0400BDB4 RID: 48564
		[Token(Token = "0x400BDB4")]
		[FieldOffset(Offset = "0x58")]
		public UILabel NickName;

		// Token: 0x0400BDB5 RID: 48565
		[Token(Token = "0x400BDB5")]
		[FieldOffset(Offset = "0x60")]
		public UINetworkTexture SelfIcon;

		// Token: 0x0400BDB6 RID: 48566
		[Token(Token = "0x400BDB6")]
		[FieldOffset(Offset = "0x68")]
		public UISprite HeadSprite;

		// Token: 0x0400BDB7 RID: 48567
		[Token(Token = "0x400BDB7")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NewSeasonInfoContainer;

		// Token: 0x0400BDB8 RID: 48568
		[Token(Token = "0x400BDB8")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NewSeasonLabelAnim;

		// Token: 0x0400BDB9 RID: 48569
		[Token(Token = "0x400BDB9")]
		[FieldOffset(Offset = "0x80")]
		public UILabel NewSeasonLabel;

		// Token: 0x0400BDBA RID: 48570
		[Token(Token = "0x400BDBA")]
		[FieldOffset(Offset = "0x88")]
		public Animation NewSeasonInfo;

		// Token: 0x0400BDBB RID: 48571
		[Token(Token = "0x400BDBB")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Txt_NewSeasonTime;

		// Token: 0x0400BDBC RID: 48572
		[Token(Token = "0x400BDBC")]
		[FieldOffset(Offset = "0x98")]
		public UILabel SeasonIconLabel;

		// Token: 0x0400BDBD RID: 48573
		[Token(Token = "0x400BDBD")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ContinueBtnAnim;

		// Token: 0x0400BDBE RID: 48574
		[Token(Token = "0x400BDBE")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel BtnLabel;

		// Token: 0x0400BDBF RID: 48575
		[Token(Token = "0x400BDBF")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton ContinueBtn;
	}
}
