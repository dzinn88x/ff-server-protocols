using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200255A RID: 9562
	[Token(Token = "0x200255A")]
	public class UISuperCarDailyItemView : UIBaseView
	{
		// Token: 0x0600C5C4 RID: 50628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C4")]
		[Address(RVA = "0x2142D4C", Offset = "0x2142D4C", VA = "0x7BBC942D4C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5C5 RID: 50629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5C5")]
		[Address(RVA = "0x2142FD8", Offset = "0x2142FD8", VA = "0x7BBC942FD8")]
		public UISuperCarDailyItemView()
		{
		}

		// Token: 0x0400F51F RID: 62751
		[Token(Token = "0x400F51F")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Progress;

		// Token: 0x0400F520 RID: 62752
		[Token(Token = "0x400F520")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Label;

		// Token: 0x0400F521 RID: 62753
		[Token(Token = "0x400F521")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Reward;

		// Token: 0x0400F522 RID: 62754
		[Token(Token = "0x400F522")]
		[FieldOffset(Offset = "0x38")]
		public UIButton Operation;

		// Token: 0x0400F523 RID: 62755
		[Token(Token = "0x400F523")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BGGray;

		// Token: 0x0400F524 RID: 62756
		[Token(Token = "0x400F524")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BGYellow;

		// Token: 0x0400F525 RID: 62757
		[Token(Token = "0x400F525")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Gained;

		// Token: 0x0400F526 RID: 62758
		[Token(Token = "0x400F526")]
		[FieldOffset(Offset = "0x58")]
		public UILabel GainedLabel;

		// Token: 0x0400F527 RID: 62759
		[Token(Token = "0x400F527")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Title;
	}
}
