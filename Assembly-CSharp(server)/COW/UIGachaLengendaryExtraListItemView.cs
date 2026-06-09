using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200221A RID: 8730
	[Token(Token = "0x200221A")]
	public class UIGachaLengendaryExtraListItemView : UIBaseView
	{
		// Token: 0x0600BF45 RID: 48965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF45")]
		[Address(RVA = "0x205D06C", Offset = "0x205D06C", VA = "0x7BBC85D06C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF46")]
		[Address(RVA = "0x205D51C", Offset = "0x205D51C", VA = "0x7BBC85D51C")]
		public UIGachaLengendaryExtraListItemView()
		{
		}

		// Token: 0x0400CF32 RID: 53042
		[Token(Token = "0x400CF32")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget RootViewWidget;

		// Token: 0x0400CF33 RID: 53043
		[Token(Token = "0x400CF33")]
		[FieldOffset(Offset = "0x28")]
		public UISprite TokenSprite;

		// Token: 0x0400CF34 RID: 53044
		[Token(Token = "0x400CF34")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TokenNum;

		// Token: 0x0400CF35 RID: 53045
		[Token(Token = "0x400CF35")]
		[FieldOffset(Offset = "0x38")]
		public UIButton ClickButon;

		// Token: 0x0400CF36 RID: 53046
		[Token(Token = "0x400CF36")]
		[FieldOffset(Offset = "0x40")]
		public UISprite PrizeBg;

		// Token: 0x0400CF37 RID: 53047
		[Token(Token = "0x400CF37")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ItemUnLock;

		// Token: 0x0400CF38 RID: 53048
		[Token(Token = "0x400CF38")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ItemLocked;

		// Token: 0x0400CF39 RID: 53049
		[Token(Token = "0x400CF39")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ItemGained;

		// Token: 0x0400CF3A RID: 53050
		[Token(Token = "0x400CF3A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject ItemMini;

		// Token: 0x0400CF3B RID: 53051
		[Token(Token = "0x400CF3B")]
		[FieldOffset(Offset = "0x68")]
		public BaseItemView RewardItem;

		// Token: 0x0400CF3C RID: 53052
		[Token(Token = "0x400CF3C")]
		[FieldOffset(Offset = "0x70")]
		public UISprite QualityBG;

		// Token: 0x0400CF3D RID: 53053
		[Token(Token = "0x400CF3D")]
		[FieldOffset(Offset = "0x78")]
		public UISprite QualityNameBG01;

		// Token: 0x0400CF3E RID: 53054
		[Token(Token = "0x400CF3E")]
		[FieldOffset(Offset = "0x80")]
		public GameObject IconGroup;

		// Token: 0x0400CF3F RID: 53055
		[Token(Token = "0x400CF3F")]
		[FieldOffset(Offset = "0x88")]
		public UISprite Sprite_Debris;

		// Token: 0x0400CF40 RID: 53056
		[Token(Token = "0x400CF40")]
		[FieldOffset(Offset = "0x90")]
		public UISprite VoucherIcon;

		// Token: 0x0400CF41 RID: 53057
		[Token(Token = "0x400CF41")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LimitLabel;

		// Token: 0x0400CF42 RID: 53058
		[Token(Token = "0x400CF42")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel QuantityLabel;

		// Token: 0x0400CF43 RID: 53059
		[Token(Token = "0x400CF43")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject VfxRareReward;

		// Token: 0x0400CF44 RID: 53060
		[Token(Token = "0x400CF44")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite NodeSprite;
	}
}
