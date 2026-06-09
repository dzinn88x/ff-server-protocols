using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002578 RID: 9592
	[Token(Token = "0x2002578")]
	public class UITreasureBoxOpenWndView : UIBaseView
	{
		// Token: 0x0600C600 RID: 50688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C600")]
		[Address(RVA = "0x19F2040", Offset = "0x19F2040", VA = "0x7BBC1F2040", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C601 RID: 50689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C601")]
		[Address(RVA = "0x19F23C4", Offset = "0x19F23C4", VA = "0x7BBC1F23C4")]
		public UITreasureBoxOpenWndView()
		{
		}

		// Token: 0x0400F66E RID: 63086
		[Token(Token = "0x400F66E")]
		[FieldOffset(Offset = "0x20")]
		public BaseItemView BaseItemView;

		// Token: 0x0400F66F RID: 63087
		[Token(Token = "0x400F66F")]
		[FieldOffset(Offset = "0x28")]
		public Transform StandardItemContainer;

		// Token: 0x0400F670 RID: 63088
		[Token(Token = "0x400F670")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ItemNameLabel;

		// Token: 0x0400F671 RID: 63089
		[Token(Token = "0x400F671")]
		[FieldOffset(Offset = "0x38")]
		public UIButton OpenOneBtn;

		// Token: 0x0400F672 RID: 63090
		[Token(Token = "0x400F672")]
		[FieldOffset(Offset = "0x40")]
		public UILabel OpenOneLabel;

		// Token: 0x0400F673 RID: 63091
		[Token(Token = "0x400F673")]
		[FieldOffset(Offset = "0x48")]
		public UILabel CurrentCnt;

		// Token: 0x0400F674 RID: 63092
		[Token(Token = "0x400F674")]
		[FieldOffset(Offset = "0x50")]
		public UILabel MaxCnt;

		// Token: 0x0400F675 RID: 63093
		[Token(Token = "0x400F675")]
		[FieldOffset(Offset = "0x58")]
		public UIButton PlusBtn;

		// Token: 0x0400F676 RID: 63094
		[Token(Token = "0x400F676")]
		[FieldOffset(Offset = "0x60")]
		public UISprite PlusSprite1;

		// Token: 0x0400F677 RID: 63095
		[Token(Token = "0x400F677")]
		[FieldOffset(Offset = "0x68")]
		public UISprite PlusSprite2;

		// Token: 0x0400F678 RID: 63096
		[Token(Token = "0x400F678")]
		[FieldOffset(Offset = "0x70")]
		public UIButton MinusBtn;

		// Token: 0x0400F679 RID: 63097
		[Token(Token = "0x400F679")]
		[FieldOffset(Offset = "0x78")]
		public UISprite MinusSprite;

		// Token: 0x0400F67A RID: 63098
		[Token(Token = "0x400F67A")]
		[FieldOffset(Offset = "0x80")]
		public UISlider Slider;
	}
}
