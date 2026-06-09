using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023BE RID: 9150
	[Token(Token = "0x20023BE")]
	public class UIIAPBundlePreviewWindowView : UIBaseView
	{
		// Token: 0x0600C28C RID: 49804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28C")]
		[Address(RVA = "0x1D2ABE4", Offset = "0x1D2ABE4", VA = "0x7BBC52ABE4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C28D RID: 49805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28D")]
		[Address(RVA = "0x1D2AD04", Offset = "0x1D2AD04", VA = "0x7BBC52AD04")]
		public UIIAPBundlePreviewWindowView()
		{
		}

		// Token: 0x0400DE5A RID: 56922
		[Token(Token = "0x400DE5A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ItemsContainer;

		// Token: 0x0400DE5B RID: 56923
		[Token(Token = "0x400DE5B")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ItemsScrollview;

		// Token: 0x0400DE5C RID: 56924
		[Token(Token = "0x400DE5C")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid ItemsGrid;
	}
}
