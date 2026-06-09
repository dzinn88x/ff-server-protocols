using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002226 RID: 8742
	[Token(Token = "0x2002226")]
	public class UIGachaPurchaseConfirmWndView : UIBaseView
	{
		// Token: 0x0600BF5D RID: 48989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5D")]
		[Address(RVA = "0x1F9F83C", Offset = "0x1F9F83C", VA = "0x7BBC79F83C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BF5E RID: 48990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BF5E")]
		[Address(RVA = "0x1F9FCB0", Offset = "0x1F9FCB0", VA = "0x7BBC79FCB0")]
		public UIGachaPurchaseConfirmWndView()
		{
		}

		// Token: 0x0400CFEC RID: 53228
		[Token(Token = "0x400CFEC")]
		[FieldOffset(Offset = "0x20")]
		public UISprite BuffIcon;

		// Token: 0x0400CFED RID: 53229
		[Token(Token = "0x400CFED")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemIcon;

		// Token: 0x0400CFEE RID: 53230
		[Token(Token = "0x400CFEE")]
		[FieldOffset(Offset = "0x30")]
		public GameObject headhunterWeaponIcon;

		// Token: 0x0400CFEF RID: 53231
		[Token(Token = "0x400CFEF")]
		[FieldOffset(Offset = "0x38")]
		public GameObject WeaponIconEffect;

		// Token: 0x0400CFF0 RID: 53232
		[Token(Token = "0x400CFF0")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemNameLabel;

		// Token: 0x0400CFF1 RID: 53233
		[Token(Token = "0x400CFF1")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ConfirmLabel;

		// Token: 0x0400CFF2 RID: 53234
		[Token(Token = "0x400CFF2")]
		[FieldOffset(Offset = "0x50")]
		public UIButton PlusBtn;

		// Token: 0x0400CFF3 RID: 53235
		[Token(Token = "0x400CFF3")]
		[FieldOffset(Offset = "0x58")]
		public UILabel CountLabel;

		// Token: 0x0400CFF4 RID: 53236
		[Token(Token = "0x400CFF4")]
		[FieldOffset(Offset = "0x60")]
		public UIButton MinusBtn;

		// Token: 0x0400CFF5 RID: 53237
		[Token(Token = "0x400CFF5")]
		[FieldOffset(Offset = "0x68")]
		public UISprite LotteryNum;

		// Token: 0x0400CFF6 RID: 53238
		[Token(Token = "0x400CFF6")]
		[FieldOffset(Offset = "0x70")]
		public GameObject LegendBox;

		// Token: 0x0400CFF7 RID: 53239
		[Token(Token = "0x400CFF7")]
		[FieldOffset(Offset = "0x78")]
		public UIButton PurchaseBtn;

		// Token: 0x0400CFF8 RID: 53240
		[Token(Token = "0x400CFF8")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DiamondBtn;

		// Token: 0x0400CFF9 RID: 53241
		[Token(Token = "0x400CFF9")]
		[FieldOffset(Offset = "0x88")]
		public UILabel DiamondLabel;

		// Token: 0x0400CFFA RID: 53242
		[Token(Token = "0x400CFFA")]
		[FieldOffset(Offset = "0x90")]
		public GameObject CoindBtn;

		// Token: 0x0400CFFB RID: 53243
		[Token(Token = "0x400CFFB")]
		[FieldOffset(Offset = "0x98")]
		public UILabel CoinLabel;

		// Token: 0x0400CFFC RID: 53244
		[Token(Token = "0x400CFFC")]
		[FieldOffset(Offset = "0xA0")]
		public UIToggle NoShowToggle;
	}
}
