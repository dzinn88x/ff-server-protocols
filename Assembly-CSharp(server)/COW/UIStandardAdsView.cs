using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200254D RID: 9549
	[Token(Token = "0x200254D")]
	public class UIStandardAdsView : UIBaseView
	{
		// Token: 0x0600C5AA RID: 50602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AA")]
		[Address(RVA = "0x163C544", Offset = "0x163C544", VA = "0x7BBBE3C544", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5AB RID: 50603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AB")]
		[Address(RVA = "0x163C6E8", Offset = "0x163C6E8", VA = "0x7BBBE3C6E8")]
		public UIStandardAdsView()
		{
		}

		// Token: 0x0400F46A RID: 62570
		[Token(Token = "0x400F46A")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Content;

		// Token: 0x0400F46B RID: 62571
		[Token(Token = "0x400F46B")]
		[FieldOffset(Offset = "0x28")]
		public UIPanel Dots;

		// Token: 0x0400F46C RID: 62572
		[Token(Token = "0x400F46C")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Grid;

		// Token: 0x0400F46D RID: 62573
		[Token(Token = "0x400F46D")]
		[FieldOffset(Offset = "0x38")]
		public UIScrollView Scrollview;

		// Token: 0x0400F46E RID: 62574
		[Token(Token = "0x400F46E")]
		[FieldOffset(Offset = "0x40")]
		public UIWrapContent WrapContent;
	}
}
