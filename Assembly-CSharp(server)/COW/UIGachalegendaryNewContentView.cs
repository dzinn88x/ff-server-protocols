using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002214 RID: 8724
	[Token(Token = "0x2002214")]
	public class UIGachalegendaryNewContentView : UIBaseView
	{
		// Token: 0x0600BF39 RID: 48953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF39")]
		[Address(RVA = "0x1FBBA50", Offset = "0x1FBBA50", VA = "0x7BBC7BBA50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF3A")]
		[Address(RVA = "0x1FBC380", Offset = "0x1FBC380", VA = "0x7BBC7BC380")]
		public UIGachalegendaryNewContentView()
		{
		}

		// Token: 0x0400CEF3 RID: 52979
		[Token(Token = "0x400CEF3")]
		[FieldOffset(Offset = "0x20")]
		public Animator UIGachalegendaryAnim;

		// Token: 0x0400CEF4 RID: 52980
		[Token(Token = "0x400CEF4")]
		[FieldOffset(Offset = "0x28")]
		public GameObject LeftContains;

		// Token: 0x0400CEF5 RID: 52981
		[Token(Token = "0x400CEF5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ItemDesc;

		// Token: 0x0400CEF6 RID: 52982
		[Token(Token = "0x400CEF6")]
		[FieldOffset(Offset = "0x38")]
		public GameObject LuckyRoyaleLabelContent;

		// Token: 0x0400CEF7 RID: 52983
		[Token(Token = "0x400CEF7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SnakeSprite;

		// Token: 0x0400CEF8 RID: 52984
		[Token(Token = "0x400CEF8")]
		[FieldOffset(Offset = "0x48")]
		public GameObject VFXLegendThem;

		// Token: 0x0400CEF9 RID: 52985
		[Token(Token = "0x400CEF9")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTexture TitleTexture;

		// Token: 0x0400CEFA RID: 52986
		[Token(Token = "0x400CEFA")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ItemDescLabel;

		// Token: 0x0400CEFB RID: 52987
		[Token(Token = "0x400CEFB")]
		[FieldOffset(Offset = "0x60")]
		public UIButton PrivewBtn;

		// Token: 0x0400CEFC RID: 52988
		[Token(Token = "0x400CEFC")]
		[FieldOffset(Offset = "0x68")]
		public UIButton TempBagBtn;

		// Token: 0x0400CEFD RID: 52989
		[Token(Token = "0x400CEFD")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NewTips;

		// Token: 0x0400CEFE RID: 52990
		[Token(Token = "0x400CEFE")]
		[FieldOffset(Offset = "0x78")]
		public UILabel BagNum;

		// Token: 0x0400CEFF RID: 52991
		[Token(Token = "0x400CEFF")]
		[FieldOffset(Offset = "0x80")]
		public Animation BagNumAnim;

		// Token: 0x0400CF00 RID: 52992
		[Token(Token = "0x400CF00")]
		[FieldOffset(Offset = "0x88")]
		public UILabel BagDesc;

		// Token: 0x0400CF01 RID: 52993
		[Token(Token = "0x400CF01")]
		[FieldOffset(Offset = "0x90")]
		public UILabel BagNumTotal;

		// Token: 0x0400CF02 RID: 52994
		[Token(Token = "0x400CF02")]
		[FieldOffset(Offset = "0x98")]
		public UISprite BagIcon;

		// Token: 0x0400CF03 RID: 52995
		[Token(Token = "0x400CF03")]
		[FieldOffset(Offset = "0xA0")]
		public UICountDownLabel FreeCountdownLabel;

		// Token: 0x0400CF04 RID: 52996
		[Token(Token = "0x400CF04")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject RightContains;

		// Token: 0x0400CF05 RID: 52997
		[Token(Token = "0x400CF05")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject TokenProgress;

		// Token: 0x0400CF06 RID: 52998
		[Token(Token = "0x400CF06")]
		[FieldOffset(Offset = "0xB8")]
		public UIWidget TokenProgressWiget;

		// Token: 0x0400CF07 RID: 52999
		[Token(Token = "0x400CF07")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel TokenNum;

		// Token: 0x0400CF08 RID: 53000
		[Token(Token = "0x400CF08")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton progressBar;

		// Token: 0x0400CF09 RID: 53001
		[Token(Token = "0x400CF09")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject ItemPanel;

		// Token: 0x0400CF0A RID: 53002
		[Token(Token = "0x400CF0A")]
		[FieldOffset(Offset = "0xD8")]
		public Transform Spot1;

		// Token: 0x0400CF0B RID: 53003
		[Token(Token = "0x400CF0B")]
		[FieldOffset(Offset = "0xE0")]
		public Transform Spot2;

		// Token: 0x0400CF0C RID: 53004
		[Token(Token = "0x400CF0C")]
		[FieldOffset(Offset = "0xE8")]
		public Transform Spot3;

		// Token: 0x0400CF0D RID: 53005
		[Token(Token = "0x400CF0D")]
		[FieldOffset(Offset = "0xF0")]
		public Transform Spot4;

		// Token: 0x0400CF0E RID: 53006
		[Token(Token = "0x400CF0E")]
		[FieldOffset(Offset = "0xF8")]
		public Transform Spot5;

		// Token: 0x0400CF0F RID: 53007
		[Token(Token = "0x400CF0F")]
		[FieldOffset(Offset = "0x100")]
		public UIProgressBar LuckyProgressBar;

		// Token: 0x0400CF10 RID: 53008
		[Token(Token = "0x400CF10")]
		[FieldOffset(Offset = "0x108")]
		public GameObject TokenVfxDestination;

		// Token: 0x0400CF11 RID: 53009
		[Token(Token = "0x400CF11")]
		[FieldOffset(Offset = "0x110")]
		public UIButton InventoryBtn;

		// Token: 0x0400CF12 RID: 53010
		[Token(Token = "0x400CF12")]
		[FieldOffset(Offset = "0x118")]
		public GameObject BagGuideVfx;

		// Token: 0x0400CF13 RID: 53011
		[Token(Token = "0x400CF13")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TokenVfx;

		// Token: 0x0400CF14 RID: 53012
		[Token(Token = "0x400CF14")]
		[FieldOffset(Offset = "0x128")]
		public GameObject DrawAnim;

		// Token: 0x0400CF15 RID: 53013
		[Token(Token = "0x400CF15")]
		[FieldOffset(Offset = "0x130")]
		public Transform BagGuideVfxStartPos;

		// Token: 0x0400CF16 RID: 53014
		[Token(Token = "0x400CF16")]
		[FieldOffset(Offset = "0x138")]
		public Transform TokenVfxStartPos;

		// Token: 0x0400CF17 RID: 53015
		[Token(Token = "0x400CF17")]
		[FieldOffset(Offset = "0x140")]
		public GameObject UIGachaLegendaryBuyBtn;

		// Token: 0x0400CF18 RID: 53016
		[Token(Token = "0x400CF18")]
		[FieldOffset(Offset = "0x148")]
		public UIWidget PreviewRightSideMiddle;

		// Token: 0x0400CF19 RID: 53017
		[Token(Token = "0x400CF19")]
		[FieldOffset(Offset = "0x150")]
		public UIWidget PreviewLeftSideMiddle;
	}
}
