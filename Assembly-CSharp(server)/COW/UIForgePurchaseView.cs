using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021F5 RID: 8693
	[Token(Token = "0x20021F5")]
	public class UIForgePurchaseView : UIBaseView
	{
		// Token: 0x0600BEFB RID: 48891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFB")]
		[Address(RVA = "0x1DBF0BC", Offset = "0x1DBF0BC", VA = "0x7BBC5BF0BC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEFC")]
		[Address(RVA = "0x1DBF4E0", Offset = "0x1DBF4E0", VA = "0x7BBC5BF4E0")]
		public UIForgePurchaseView()
		{
		}

		// Token: 0x0400CD5F RID: 52575
		[Token(Token = "0x400CD5F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject line;

		// Token: 0x0400CD60 RID: 52576
		[Token(Token = "0x400CD60")]
		[FieldOffset(Offset = "0x28")]
		public UIButton CloseBtn;

		// Token: 0x0400CD61 RID: 52577
		[Token(Token = "0x400CD61")]
		[FieldOffset(Offset = "0x30")]
		public UISprite ItemIcon;

		// Token: 0x0400CD62 RID: 52578
		[Token(Token = "0x400CD62")]
		[FieldOffset(Offset = "0x38")]
		public UISprite WeaponIcon;

		// Token: 0x0400CD63 RID: 52579
		[Token(Token = "0x400CD63")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemNameLabel;

		// Token: 0x0400CD64 RID: 52580
		[Token(Token = "0x400CD64")]
		[FieldOffset(Offset = "0x48")]
		public UILabel purchaseDescLabel;

		// Token: 0x0400CD65 RID: 52581
		[Token(Token = "0x400CD65")]
		[FieldOffset(Offset = "0x50")]
		public UISprite quality;

		// Token: 0x0400CD66 RID: 52582
		[Token(Token = "0x400CD66")]
		[FieldOffset(Offset = "0x58")]
		public UILabel time;

		// Token: 0x0400CD67 RID: 52583
		[Token(Token = "0x400CD67")]
		[FieldOffset(Offset = "0x60")]
		public UILabel cnt;

		// Token: 0x0400CD68 RID: 52584
		[Token(Token = "0x400CD68")]
		[FieldOffset(Offset = "0x68")]
		public BaseItemView Material1;

		// Token: 0x0400CD69 RID: 52585
		[Token(Token = "0x400CD69")]
		[FieldOffset(Offset = "0x70")]
		public UILabel Material1Count;

		// Token: 0x0400CD6A RID: 52586
		[Token(Token = "0x400CD6A")]
		[FieldOffset(Offset = "0x78")]
		public BaseItemView Material2;

		// Token: 0x0400CD6B RID: 52587
		[Token(Token = "0x400CD6B")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Material2Count;

		// Token: 0x0400CD6C RID: 52588
		[Token(Token = "0x400CD6C")]
		[FieldOffset(Offset = "0x88")]
		public BaseItemView Material3;

		// Token: 0x0400CD6D RID: 52589
		[Token(Token = "0x400CD6D")]
		[FieldOffset(Offset = "0x90")]
		public UILabel Material3Count;

		// Token: 0x0400CD6E RID: 52590
		[Token(Token = "0x400CD6E")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ExchangeBtn;
	}
}
