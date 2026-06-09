using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023B0 RID: 9136
	[Token(Token = "0x20023B0")]
	public class UIHudWereWolvesTaskWolfListView : UIBaseView
	{
		// Token: 0x0600C270 RID: 49776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C270")]
		[Address(RVA = "0x1D185B0", Offset = "0x1D185B0", VA = "0x7BBC5185B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C271 RID: 49777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C271")]
		[Address(RVA = "0x1D187A0", Offset = "0x1D187A0", VA = "0x7BBC5187A0")]
		public UIHudWereWolvesTaskWolfListView()
		{
		}

		// Token: 0x0400DDE4 RID: 56804
		[Token(Token = "0x400DDE4")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ExpandNode;

		// Token: 0x0400DDE5 RID: 56805
		[Token(Token = "0x400DDE5")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollView ContentScrollView;

		// Token: 0x0400DDE6 RID: 56806
		[Token(Token = "0x400DDE6")]
		[FieldOffset(Offset = "0x30")]
		public UIEasyList ContentList;

		// Token: 0x0400DDE7 RID: 56807
		[Token(Token = "0x400DDE7")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnShrink;

		// Token: 0x0400DDE8 RID: 56808
		[Token(Token = "0x400DDE8")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ShrinkNode;

		// Token: 0x0400DDE9 RID: 56809
		[Token(Token = "0x400DDE9")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnExpand;
	}
}
