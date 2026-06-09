using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023DF RID: 9183
	[Token(Token = "0x20023DF")]
	public class UILegendGachaReRandomConfirmWndView : UIBaseView
	{
		// Token: 0x0600C2CE RID: 49870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CE")]
		[Address(RVA = "0x1CB5020", Offset = "0x1CB5020", VA = "0x7BBC4B5020", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C2CF RID: 49871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2CF")]
		[Address(RVA = "0x1CB5248", Offset = "0x1CB5248", VA = "0x7BBC4B5248")]
		public UILegendGachaReRandomConfirmWndView()
		{
		}

		// Token: 0x0400E06C RID: 57452
		[Token(Token = "0x400E06C")]
		[FieldOffset(Offset = "0x20")]
		public GameObject LegendBox;

		// Token: 0x0400E06D RID: 57453
		[Token(Token = "0x400E06D")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ItemIcon;

		// Token: 0x0400E06E RID: 57454
		[Token(Token = "0x400E06E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemNameLabel;

		// Token: 0x0400E06F RID: 57455
		[Token(Token = "0x400E06F")]
		[FieldOffset(Offset = "0x38")]
		public UILabel ConfirmLabel;

		// Token: 0x0400E070 RID: 57456
		[Token(Token = "0x400E070")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PurchaseBtn;

		// Token: 0x0400E071 RID: 57457
		[Token(Token = "0x400E071")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DiamondBtn;

		// Token: 0x0400E072 RID: 57458
		[Token(Token = "0x400E072")]
		[FieldOffset(Offset = "0x50")]
		public UIToggle NoShowToggle;
	}
}
