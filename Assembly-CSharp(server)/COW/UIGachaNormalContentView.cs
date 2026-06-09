using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002224 RID: 8740
	[Token(Token = "0x2002224")]
	public class UIGachaNormalContentView : UIBaseView
	{
		// Token: 0x0600BF59 RID: 48985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF59")]
		[Address(RVA = "0x206C068", Offset = "0x206C068", VA = "0x7BBC86C068", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5A")]
		[Address(RVA = "0x206C7F0", Offset = "0x206C7F0", VA = "0x7BBC86C7F0")]
		public UIGachaNormalContentView()
		{
		}

		// Token: 0x0400CFC9 RID: 53193
		[Token(Token = "0x400CFC9")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UIGachaNormalContent;

		// Token: 0x0400CFCA RID: 53194
		[Token(Token = "0x400CFCA")]
		[FieldOffset(Offset = "0x28")]
		public GameObject itemDescLabel;

		// Token: 0x0400CFCB RID: 53195
		[Token(Token = "0x400CFCB")]
		[FieldOffset(Offset = "0x30")]
		public GameObject itemdesc;

		// Token: 0x0400CFCC RID: 53196
		[Token(Token = "0x400CFCC")]
		[FieldOffset(Offset = "0x38")]
		public GameObject itemname;

		// Token: 0x0400CFCD RID: 53197
		[Token(Token = "0x400CFCD")]
		[FieldOffset(Offset = "0x40")]
		public UISprite itemdescrightposspr;

		// Token: 0x0400CFCE RID: 53198
		[Token(Token = "0x400CFCE")]
		[FieldOffset(Offset = "0x48")]
		public UISprite itemnamerightposser;

		// Token: 0x0400CFCF RID: 53199
		[Token(Token = "0x400CFCF")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NewQualityicon;

		// Token: 0x0400CFD0 RID: 53200
		[Token(Token = "0x400CFD0")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ExtraAwardContainer;

		// Token: 0x0400CFD1 RID: 53201
		[Token(Token = "0x400CFD1")]
		[FieldOffset(Offset = "0x60")]
		public UILabel ExtraAwardTitleCount;

		// Token: 0x0400CFD2 RID: 53202
		[Token(Token = "0x400CFD2")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid ExtraAwardGrid;

		// Token: 0x0400CFD3 RID: 53203
		[Token(Token = "0x400CFD3")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget PreviewLeftSide;

		// Token: 0x0400CFD4 RID: 53204
		[Token(Token = "0x400CFD4")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget PreviewRightSide;

		// Token: 0x0400CFD5 RID: 53205
		[Token(Token = "0x400CFD5")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Anim;

		// Token: 0x0400CFD6 RID: 53206
		[Token(Token = "0x400CFD6")]
		[FieldOffset(Offset = "0x88")]
		public GameObject CDNContent;

		// Token: 0x0400CFD7 RID: 53207
		[Token(Token = "0x400CFD7")]
		[FieldOffset(Offset = "0x90")]
		public Animation VFX_EFF_Luck;

		// Token: 0x0400CFD8 RID: 53208
		[Token(Token = "0x400CFD8")]
		[FieldOffset(Offset = "0x98")]
		public UISprite star01;

		// Token: 0x0400CFD9 RID: 53209
		[Token(Token = "0x400CFD9")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite star02;

		// Token: 0x0400CFDA RID: 53210
		[Token(Token = "0x400CFDA")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite star03;

		// Token: 0x0400CFDB RID: 53211
		[Token(Token = "0x400CFDB")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton LuckyBg;

		// Token: 0x0400CFDC RID: 53212
		[Token(Token = "0x400CFDC")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel EnergyPointLabel;

		// Token: 0x0400CFDD RID: 53213
		[Token(Token = "0x400CFDD")]
		[FieldOffset(Offset = "0xC0")]
		public Animation LuckyAnimation;

		// Token: 0x0400CFDE RID: 53214
		[Token(Token = "0x400CFDE")]
		[FieldOffset(Offset = "0xC8")]
		public UICountDownIcon CountDownIcon;

		// Token: 0x0400CFDF RID: 53215
		[Token(Token = "0x400CFDF")]
		[FieldOffset(Offset = "0xD0")]
		public UICountDownLabel GachaCountDownLabel;

		// Token: 0x0400CFE0 RID: 53216
		[Token(Token = "0x400CFE0")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton BGClickLottery;

		// Token: 0x0400CFE1 RID: 53217
		[Token(Token = "0x400CFE1")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject ADScrollView;

		// Token: 0x0400CFE2 RID: 53218
		[Token(Token = "0x400CFE2")]
		[FieldOffset(Offset = "0xE8")]
		public UIWrapContent ADContent;

		// Token: 0x0400CFE3 RID: 53219
		[Token(Token = "0x400CFE3")]
		[FieldOffset(Offset = "0xF0")]
		public UIWidget GachaPreviewPosition;

		// Token: 0x0400CFE4 RID: 53220
		[Token(Token = "0x400CFE4")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject CDNMask01;

		// Token: 0x0400CFE5 RID: 53221
		[Token(Token = "0x400CFE5")]
		[FieldOffset(Offset = "0x100")]
		public GameObject CDNMask02;

		// Token: 0x0400CFE6 RID: 53222
		[Token(Token = "0x400CFE6")]
		[FieldOffset(Offset = "0x108")]
		public GameObject BuyBtnGroup;
	}
}
