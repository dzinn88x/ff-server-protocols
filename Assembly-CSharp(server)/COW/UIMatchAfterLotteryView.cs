using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002436 RID: 9270
	[Token(Token = "0x2002436")]
	internal class UIMatchAfterLotteryView : UIBaseView
	{
		// Token: 0x0600C37C RID: 50044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37C")]
		[Address(RVA = "0x1477328", Offset = "0x1477328", VA = "0x7BBBC77328", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C37D")]
		[Address(RVA = "0x1477610", Offset = "0x1477610", VA = "0x7BBBC77610")]
		public UIMatchAfterLotteryView()
		{
		}

		// Token: 0x0400E6E5 RID: 59109
		[Token(Token = "0x400E6E5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject MaskBG;

		// Token: 0x0400E6E6 RID: 59110
		[Token(Token = "0x400E6E6")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid ItemsGrid;

		// Token: 0x0400E6E7 RID: 59111
		[Token(Token = "0x400E6E7")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LuckyTodayLabel;

		// Token: 0x0400E6E8 RID: 59112
		[Token(Token = "0x400E6E8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OpenAllObj;

		// Token: 0x0400E6E9 RID: 59113
		[Token(Token = "0x400E6E9")]
		[FieldOffset(Offset = "0x40")]
		public UIButton PurchaseBtn;

		// Token: 0x0400E6EA RID: 59114
		[Token(Token = "0x400E6EA")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FreeBG;

		// Token: 0x0400E6EB RID: 59115
		[Token(Token = "0x400E6EB")]
		[FieldOffset(Offset = "0x50")]
		public GameObject CostBG;

		// Token: 0x0400E6EC RID: 59116
		[Token(Token = "0x400E6EC")]
		[FieldOffset(Offset = "0x58")]
		public UILabel DiamondCount;

		// Token: 0x0400E6ED RID: 59117
		[Token(Token = "0x400E6ED")]
		[FieldOffset(Offset = "0x60")]
		public UIButton CloseBtn;

		// Token: 0x0400E6EE RID: 59118
		[Token(Token = "0x400E6EE")]
		[FieldOffset(Offset = "0x68")]
		public UIButton PrizeHintBtn;
	}
}
