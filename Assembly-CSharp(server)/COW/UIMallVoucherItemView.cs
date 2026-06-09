using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002420 RID: 9248
	[Token(Token = "0x2002420")]
	public class UIMallVoucherItemView : UIBaseView
	{
		// Token: 0x0600C350 RID: 50000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C350")]
		[Address(RVA = "0x1DF3CD8", Offset = "0x1DF3CD8", VA = "0x7BBC5F3CD8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C351 RID: 50001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C351")]
		[Address(RVA = "0x1DF3EB8", Offset = "0x1DF3EB8", VA = "0x7BBC5F3EB8")]
		public UIMallVoucherItemView()
		{
		}

		// Token: 0x0400E53C RID: 58684
		[Token(Token = "0x400E53C")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400E53D RID: 58685
		[Token(Token = "0x400E53D")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget Container;

		// Token: 0x0400E53E RID: 58686
		[Token(Token = "0x400E53E")]
		[FieldOffset(Offset = "0x30")]
		public UILabel PriceLabel;

		// Token: 0x0400E53F RID: 58687
		[Token(Token = "0x400E53F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400E540 RID: 58688
		[Token(Token = "0x400E540")]
		[FieldOffset(Offset = "0x40")]
		public GameObject GemsIcon;

		// Token: 0x0400E541 RID: 58689
		[Token(Token = "0x400E541")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GoldIcon;
	}
}
