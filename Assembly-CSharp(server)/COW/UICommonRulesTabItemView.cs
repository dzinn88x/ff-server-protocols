using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002186 RID: 8582
	[Token(Token = "0x2002186")]
	internal class UICommonRulesTabItemView : UIBaseView
	{
		// Token: 0x0600BE1C RID: 48668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1C")]
		[Address(RVA = "0x1814FDC", Offset = "0x1814FDC", VA = "0x7BBC014FDC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE1D RID: 48669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE1D")]
		[Address(RVA = "0x1815140", Offset = "0x1815140", VA = "0x7BBC015140")]
		public UICommonRulesTabItemView()
		{
		}

		// Token: 0x0400C7BD RID: 51133
		[Token(Token = "0x400C7BD")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UICommonRulesTabItem;

		// Token: 0x0400C7BE RID: 51134
		[Token(Token = "0x400C7BE")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelUniversal;

		// Token: 0x0400C7BF RID: 51135
		[Token(Token = "0x400C7BF")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelUniversalUnSelected;

		// Token: 0x0400C7C0 RID: 51136
		[Token(Token = "0x400C7C0")]
		[FieldOffset(Offset = "0x38")]
		public GameObject SpriteUniversalSelected;
	}
}
