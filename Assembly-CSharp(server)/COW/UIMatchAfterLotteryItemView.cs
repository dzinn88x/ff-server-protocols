using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002435 RID: 9269
	[Token(Token = "0x2002435")]
	internal class UIMatchAfterLotteryItemView : UIBaseView
	{
		// Token: 0x0600C37A RID: 50042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37A")]
		[Address(RVA = "0x1476DB0", Offset = "0x1476DB0", VA = "0x7BBBC76DB0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37B")]
		[Address(RVA = "0x1477320", Offset = "0x1477320", VA = "0x7BBBC77320")]
		public UIMatchAfterLotteryItemView()
		{
		}

		// Token: 0x0400E6CF RID: 59087
		[Token(Token = "0x400E6CF")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Mask;

		// Token: 0x0400E6D0 RID: 59088
		[Token(Token = "0x400E6D0")]
		[FieldOffset(Offset = "0x28")]
		public UINetworkTexture MaskIcon;

		// Token: 0x0400E6D1 RID: 59089
		[Token(Token = "0x400E6D1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject ButtonsParent;

		// Token: 0x0400E6D2 RID: 59090
		[Token(Token = "0x400E6D2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject FreeObj;

		// Token: 0x0400E6D3 RID: 59091
		[Token(Token = "0x400E6D3")]
		[FieldOffset(Offset = "0x40")]
		public GameObject WinGift;

		// Token: 0x0400E6D4 RID: 59092
		[Token(Token = "0x400E6D4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject CostObj;

		// Token: 0x0400E6D5 RID: 59093
		[Token(Token = "0x400E6D5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DiamondCount;

		// Token: 0x0400E6D6 RID: 59094
		[Token(Token = "0x400E6D6")]
		[FieldOffset(Offset = "0x58")]
		public UISprite MaskIconSprite;

		// Token: 0x0400E6D7 RID: 59095
		[Token(Token = "0x400E6D7")]
		[FieldOffset(Offset = "0x60")]
		public GameObject Mask_Front;

		// Token: 0x0400E6D8 RID: 59096
		[Token(Token = "0x400E6D8")]
		[FieldOffset(Offset = "0x68")]
		public UISprite IconFront;

		// Token: 0x0400E6D9 RID: 59097
		[Token(Token = "0x400E6D9")]
		[FieldOffset(Offset = "0x70")]
		public BaseItemView m_BaseItemView;

		// Token: 0x0400E6DA RID: 59098
		[Token(Token = "0x400E6DA")]
		[FieldOffset(Offset = "0x78")]
		public GameObject GreyMask;

		// Token: 0x0400E6DB RID: 59099
		[Token(Token = "0x400E6DB")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Glow_Back;

		// Token: 0x0400E6DC RID: 59100
		[Token(Token = "0x400E6DC")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Glow_Front;

		// Token: 0x0400E6DD RID: 59101
		[Token(Token = "0x400E6DD")]
		[FieldOffset(Offset = "0x90")]
		public GameObject SilverFront;

		// Token: 0x0400E6DE RID: 59102
		[Token(Token = "0x400E6DE")]
		[FieldOffset(Offset = "0x98")]
		public GameObject GoldenFront;

		// Token: 0x0400E6DF RID: 59103
		[Token(Token = "0x400E6DF")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject DiamondFront;

		// Token: 0x0400E6E0 RID: 59104
		[Token(Token = "0x400E6E0")]
		[FieldOffset(Offset = "0xA8")]
		public Animator QualityAnimator;

		// Token: 0x0400E6E1 RID: 59105
		[Token(Token = "0x400E6E1")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject VFX_RollCard;

		// Token: 0x0400E6E2 RID: 59106
		[Token(Token = "0x400E6E2")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SilverFlip;

		// Token: 0x0400E6E3 RID: 59107
		[Token(Token = "0x400E6E3")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject GoldenFlip;

		// Token: 0x0400E6E4 RID: 59108
		[Token(Token = "0x400E6E4")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject DiamondFlip;
	}
}
