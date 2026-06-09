using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023F6 RID: 9206
	[Token(Token = "0x20023F6")]
	public class UILobbyCoinsView : UIBaseView
	{
		// Token: 0x0600C2FC RID: 49916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FC")]
		[Address(RVA = "0x152DC34", Offset = "0x152DC34", VA = "0x7BBBD2DC34", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FD")]
		[Address(RVA = "0x152E060", Offset = "0x152E060", VA = "0x7BBBD2E060")]
		public UILobbyCoinsView()
		{
		}

		// Token: 0x0400E164 RID: 57700
		[Token(Token = "0x400E164")]
		[FieldOffset(Offset = "0x20")]
		public UIButton btnCoin;

		// Token: 0x0400E165 RID: 57701
		[Token(Token = "0x400E165")]
		[FieldOffset(Offset = "0x28")]
		public UILabel coinCount;

		// Token: 0x0400E166 RID: 57702
		[Token(Token = "0x400E166")]
		[FieldOffset(Offset = "0x30")]
		public UILabel diamondCount;

		// Token: 0x0400E167 RID: 57703
		[Token(Token = "0x400E167")]
		[FieldOffset(Offset = "0x38")]
		public UIButton btnDiamond;

		// Token: 0x0400E168 RID: 57704
		[Token(Token = "0x400E168")]
		[FieldOffset(Offset = "0x40")]
		public UISprite PaymentNewRedDotSprite;

		// Token: 0x0400E169 RID: 57705
		[Token(Token = "0x400E169")]
		[FieldOffset(Offset = "0x48")]
		public UIButton btnEnergy;

		// Token: 0x0400E16A RID: 57706
		[Token(Token = "0x400E16A")]
		[FieldOffset(Offset = "0x50")]
		public UILabel energyCount;

		// Token: 0x0400E16B RID: 57707
		[Token(Token = "0x400E16B")]
		[FieldOffset(Offset = "0x58")]
		public UIButton BtnRebateCard;

		// Token: 0x0400E16C RID: 57708
		[Token(Token = "0x400E16C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RebateCardSprites;

		// Token: 0x0400E16D RID: 57709
		[Token(Token = "0x400E16D")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RedeemableEffect;

		// Token: 0x0400E16E RID: 57710
		[Token(Token = "0x400E16E")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RedDotSprite;

		// Token: 0x0400E16F RID: 57711
		[Token(Token = "0x400E16F")]
		[FieldOffset(Offset = "0x78")]
		public UISprite WeekCardIcon;

		// Token: 0x0400E170 RID: 57712
		[Token(Token = "0x400E170")]
		[FieldOffset(Offset = "0x80")]
		public UISprite MonthCardIcon;

		// Token: 0x0400E171 RID: 57713
		[Token(Token = "0x400E171")]
		[FieldOffset(Offset = "0x88")]
		public UISprite BothCardsIcon;

		// Token: 0x0400E172 RID: 57714
		[Token(Token = "0x400E172")]
		[FieldOffset(Offset = "0x90")]
		public UISprite NoCardIcon;

		// Token: 0x0400E173 RID: 57715
		[Token(Token = "0x400E173")]
		[FieldOffset(Offset = "0x98")]
		public GameObject RebateCardEffect;
	}
}
