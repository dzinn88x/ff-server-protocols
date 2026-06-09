using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200254E RID: 9550
	[Token(Token = "0x200254E")]
	public class UIStandardDrawerTabView : UIBaseView
	{
		// Token: 0x0600C5AC RID: 50604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AC")]
		[Address(RVA = "0x163CFF8", Offset = "0x163CFF8", VA = "0x7BBBE3CFF8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5AD RID: 50605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5AD")]
		[Address(RVA = "0x163D1E0", Offset = "0x163D1E0", VA = "0x7BBBE3D1E0")]
		public UIStandardDrawerTabView()
		{
		}

		// Token: 0x0400F46F RID: 62575
		[Token(Token = "0x400F46F")]
		[FieldOffset(Offset = "0x20")]
		public UIPanel TabPanel;

		// Token: 0x0400F470 RID: 62576
		[Token(Token = "0x400F470")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget GuideContainer;

		// Token: 0x0400F471 RID: 62577
		[Token(Token = "0x400F471")]
		[FieldOffset(Offset = "0x30")]
		public UIScrollView ScrollView;

		// Token: 0x0400F472 RID: 62578
		[Token(Token = "0x400F472")]
		[FieldOffset(Offset = "0x38")]
		public UITable Table;

		// Token: 0x0400F473 RID: 62579
		[Token(Token = "0x400F473")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget LeftBG;

		// Token: 0x0400F474 RID: 62580
		[Token(Token = "0x400F474")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DownArrow;
	}
}
