using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002576 RID: 9590
	[Token(Token = "0x2002576")]
	public class UITokenTipsView : UIBaseView
	{
		// Token: 0x0600C5FC RID: 50684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FC")]
		[Address(RVA = "0x1F56BF0", Offset = "0x1F56BF0", VA = "0x7BBC756BF0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5FD RID: 50685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5FD")]
		[Address(RVA = "0x1F56FB0", Offset = "0x1F56FB0", VA = "0x7BBC756FB0")]
		public UITokenTipsView()
		{
		}

		// Token: 0x0400F634 RID: 63028
		[Token(Token = "0x400F634")]
		[FieldOffset(Offset = "0x20")]
		public GameObject PosRoot;

		// Token: 0x0400F635 RID: 63029
		[Token(Token = "0x400F635")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ItemAnchor;

		// Token: 0x0400F636 RID: 63030
		[Token(Token = "0x400F636")]
		[FieldOffset(Offset = "0x30")]
		public UITable ContentTable;

		// Token: 0x0400F637 RID: 63031
		[Token(Token = "0x400F637")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TopLine;

		// Token: 0x0400F638 RID: 63032
		[Token(Token = "0x400F638")]
		[FieldOffset(Offset = "0x40")]
		public GameObject EmptyItem;

		// Token: 0x0400F639 RID: 63033
		[Token(Token = "0x400F639")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Description;

		// Token: 0x0400F63A RID: 63034
		[Token(Token = "0x400F63A")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Gain;

		// Token: 0x0400F63B RID: 63035
		[Token(Token = "0x400F63B")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid Grid;

		// Token: 0x0400F63C RID: 63036
		[Token(Token = "0x400F63C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BottomLine;

		// Token: 0x0400F63D RID: 63037
		[Token(Token = "0x400F63D")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BGPivot;

		// Token: 0x0400F63E RID: 63038
		[Token(Token = "0x400F63E")]
		[FieldOffset(Offset = "0x70")]
		public UISprite BG;

		// Token: 0x0400F63F RID: 63039
		[Token(Token = "0x400F63F")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ArrowAnchor;

		// Token: 0x0400F640 RID: 63040
		[Token(Token = "0x400F640")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BgBtn;

		// Token: 0x0400F641 RID: 63041
		[Token(Token = "0x400F641")]
		[FieldOffset(Offset = "0x88")]
		public UIButton Mask;
	}
}
