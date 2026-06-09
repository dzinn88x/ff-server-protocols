using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200211A RID: 8474
	[Token(Token = "0x200211A")]
	public class UIBaseProfileInfoView : UIBaseView
	{
		// Token: 0x0600BD44 RID: 48452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD44")]
		[Address(RVA = "0x1426D40", Offset = "0x1426D40", VA = "0x7BBBC26D40", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD45")]
		[Address(RVA = "0x14276E4", Offset = "0x14276E4", VA = "0x7BBBC276E4")]
		public UIBaseProfileInfoView()
		{
		}

		// Token: 0x0400C1EE RID: 49646
		[Token(Token = "0x400C1EE")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIBaseProfileInfo;

		// Token: 0x0400C1EF RID: 49647
		[Token(Token = "0x400C1EF")]
		[FieldOffset(Offset = "0x28")]
		public UILabel BadgeCntLabel;

		// Token: 0x0400C1F0 RID: 49648
		[Token(Token = "0x400C1F0")]
		[FieldOffset(Offset = "0x30")]
		public UISprite EPBadge;

		// Token: 0x0400C1F1 RID: 49649
		[Token(Token = "0x400C1F1")]
		[FieldOffset(Offset = "0x38")]
		public UIEffectSprite bg;

		// Token: 0x0400C1F2 RID: 49650
		[Token(Token = "0x400C1F2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject fakeBg;

		// Token: 0x0400C1F3 RID: 49651
		[Token(Token = "0x400C1F3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject gray;

		// Token: 0x0400C1F4 RID: 49652
		[Token(Token = "0x400C1F4")]
		[FieldOffset(Offset = "0x50")]
		public UIButton headbtn;

		// Token: 0x0400C1F5 RID: 49653
		[Token(Token = "0x400C1F5")]
		[FieldOffset(Offset = "0x58")]
		public UINetworkTexture HeadIcon;

		// Token: 0x0400C1F6 RID: 49654
		[Token(Token = "0x400C1F6")]
		[FieldOffset(Offset = "0x60")]
		public UISprite HeadSprite;

		// Token: 0x0400C1F7 RID: 49655
		[Token(Token = "0x400C1F7")]
		[FieldOffset(Offset = "0x68")]
		public GameObject FakeSprite;

		// Token: 0x0400C1F8 RID: 49656
		[Token(Token = "0x400C1F8")]
		[FieldOffset(Offset = "0x70")]
		public GameObject infoContainer;

		// Token: 0x0400C1F9 RID: 49657
		[Token(Token = "0x400C1F9")]
		[FieldOffset(Offset = "0x78")]
		public UISprite CSRank;

		// Token: 0x0400C1FA RID: 49658
		[Token(Token = "0x400C1FA")]
		[FieldOffset(Offset = "0x80")]
		public GameObject MaxCSStar;

		// Token: 0x0400C1FB RID: 49659
		[Token(Token = "0x400C1FB")]
		[FieldOffset(Offset = "0x88")]
		public UILabel MaxCSRankTxt;

		// Token: 0x0400C1FC RID: 49660
		[Token(Token = "0x400C1FC")]
		[FieldOffset(Offset = "0x90")]
		public UIGrid CSGrid;

		// Token: 0x0400C1FD RID: 49661
		[Token(Token = "0x400C1FD")]
		[FieldOffset(Offset = "0x98")]
		public GameObject star1;

		// Token: 0x0400C1FE RID: 49662
		[Token(Token = "0x400C1FE")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject star2;

		// Token: 0x0400C1FF RID: 49663
		[Token(Token = "0x400C1FF")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject star3;

		// Token: 0x0400C200 RID: 49664
		[Token(Token = "0x400C200")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject star4;

		// Token: 0x0400C201 RID: 49665
		[Token(Token = "0x400C201")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject star5;

		// Token: 0x0400C202 RID: 49666
		[Token(Token = "0x400C202")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject blackstar1;

		// Token: 0x0400C203 RID: 49667
		[Token(Token = "0x400C203")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject blackstar2;

		// Token: 0x0400C204 RID: 49668
		[Token(Token = "0x400C204")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject blackstar3;

		// Token: 0x0400C205 RID: 49669
		[Token(Token = "0x400C205")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject blackstar4;

		// Token: 0x0400C206 RID: 49670
		[Token(Token = "0x400C206")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject blackstar5;

		// Token: 0x0400C207 RID: 49671
		[Token(Token = "0x400C207")]
		[FieldOffset(Offset = "0xE8")]
		public UISprite rank;

		// Token: 0x0400C208 RID: 49672
		[Token(Token = "0x400C208")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel rankLv;

		// Token: 0x0400C209 RID: 49673
		[Token(Token = "0x400C209")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject NickNameWithGender;

		// Token: 0x0400C20A RID: 49674
		[Token(Token = "0x400C20A")]
		[FieldOffset(Offset = "0x100")]
		public UISprite PlayerSex;

		// Token: 0x0400C20B RID: 49675
		[Token(Token = "0x400C20B")]
		[FieldOffset(Offset = "0x108")]
		public UILabel NickNameWithGenderLabel;

		// Token: 0x0400C20C RID: 49676
		[Token(Token = "0x400C20C")]
		[FieldOffset(Offset = "0x110")]
		public UILabel nickname;

		// Token: 0x0400C20D RID: 49677
		[Token(Token = "0x400C20D")]
		[FieldOffset(Offset = "0x118")]
		public UILabel level;

		// Token: 0x0400C20E RID: 49678
		[Token(Token = "0x400C20E")]
		[FieldOffset(Offset = "0x120")]
		public UILabel clanName;

		// Token: 0x0400C20F RID: 49679
		[Token(Token = "0x400C20F")]
		[FieldOffset(Offset = "0x128")]
		public UISprite platformIcon;

		// Token: 0x0400C210 RID: 49680
		[Token(Token = "0x400C210")]
		[FieldOffset(Offset = "0x130")]
		public UILabel online;

		// Token: 0x0400C211 RID: 49681
		[Token(Token = "0x400C211")]
		[FieldOffset(Offset = "0x138")]
		public GameObject LadderEffect;

		// Token: 0x0400C212 RID: 49682
		[Token(Token = "0x400C212")]
		[FieldOffset(Offset = "0x140")]
		public UISprite Favor;

		// Token: 0x0400C213 RID: 49683
		[Token(Token = "0x400C213")]
		[FieldOffset(Offset = "0x148")]
		public UISprite PinIcon;

		// Token: 0x0400C214 RID: 49684
		[Token(Token = "0x400C214")]
		[FieldOffset(Offset = "0x150")]
		public UIButton BtnPin;

		// Token: 0x0400C215 RID: 49685
		[Token(Token = "0x400C215")]
		[FieldOffset(Offset = "0x158")]
		public UISprite BtnPinIcon;

		// Token: 0x0400C216 RID: 49686
		[Token(Token = "0x400C216")]
		[FieldOffset(Offset = "0x160")]
		public GameObject Icon_Celebrity;
	}
}
