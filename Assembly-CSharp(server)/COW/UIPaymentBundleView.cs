using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002470 RID: 9328
	[Token(Token = "0x2002470")]
	public class UIPaymentBundleView : UIBaseView
	{
		// Token: 0x0600C3F0 RID: 50160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F0")]
		[Address(RVA = "0x16FB8C0", Offset = "0x16FB8C0", VA = "0x7BBBEFB8C0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3F1 RID: 50161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3F1")]
		[Address(RVA = "0x16FBBD0", Offset = "0x16FBBD0", VA = "0x7BBBEFBBD0")]
		public UIPaymentBundleView()
		{
		}

		// Token: 0x0400EA08 RID: 59912
		[Token(Token = "0x400EA08")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Top;

		// Token: 0x0400EA09 RID: 59913
		[Token(Token = "0x400EA09")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView BundleTitleScrollView;

		// Token: 0x0400EA0A RID: 59914
		[Token(Token = "0x400EA0A")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid BundleTitleGrid;

		// Token: 0x0400EA0B RID: 59915
		[Token(Token = "0x400EA0B")]
		[FieldOffset(Offset = "0x38")]
		public Transform Middle;

		// Token: 0x0400EA0C RID: 59916
		[Token(Token = "0x400EA0C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ListRoot;

		// Token: 0x0400EA0D RID: 59917
		[Token(Token = "0x400EA0D")]
		[FieldOffset(Offset = "0x48")]
		public UIScrollView BundlesScrollView;

		// Token: 0x0400EA0E RID: 59918
		[Token(Token = "0x400EA0E")]
		[FieldOffset(Offset = "0x50")]
		public UIEasyList BundlesList;

		// Token: 0x0400EA0F RID: 59919
		[Token(Token = "0x400EA0F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject TableRoot;

		// Token: 0x0400EA10 RID: 59920
		[Token(Token = "0x400EA10")]
		[FieldOffset(Offset = "0x60")]
		public UIScrollView BundlesTableScrollView;

		// Token: 0x0400EA11 RID: 59921
		[Token(Token = "0x400EA11")]
		[FieldOffset(Offset = "0x68")]
		public UITable TableContent;

		// Token: 0x0400EA12 RID: 59922
		[Token(Token = "0x400EA12")]
		[FieldOffset(Offset = "0x70")]
		public GameObject EmptyHint;
	}
}
