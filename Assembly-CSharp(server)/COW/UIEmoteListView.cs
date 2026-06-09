using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021C4 RID: 8644
	[Token(Token = "0x20021C4")]
	public class UIEmoteListView : UIBaseView
	{
		// Token: 0x0600BE98 RID: 48792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE98")]
		[Address(RVA = "0x1E76E00", Offset = "0x1E76E00", VA = "0x7BBC676E00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE99 RID: 48793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE99")]
		[Address(RVA = "0x1E7713C", Offset = "0x1E7713C", VA = "0x7BBC67713C")]
		public UIEmoteListView()
		{
		}

		// Token: 0x0400CAF6 RID: 51958
		[Token(Token = "0x400CAF6")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView list;

		// Token: 0x0400CAF7 RID: 51959
		[Token(Token = "0x400CAF7")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid Grid;

		// Token: 0x0400CAF8 RID: 51960
		[Token(Token = "0x400CAF8")]
		[FieldOffset(Offset = "0x30")]
		public Transform Slot1;

		// Token: 0x0400CAF9 RID: 51961
		[Token(Token = "0x400CAF9")]
		[FieldOffset(Offset = "0x38")]
		public Transform Slot2;

		// Token: 0x0400CAFA RID: 51962
		[Token(Token = "0x400CAFA")]
		[FieldOffset(Offset = "0x40")]
		public Transform Slot3;

		// Token: 0x0400CAFB RID: 51963
		[Token(Token = "0x400CAFB")]
		[FieldOffset(Offset = "0x48")]
		public Transform Slot4;

		// Token: 0x0400CAFC RID: 51964
		[Token(Token = "0x400CAFC")]
		[FieldOffset(Offset = "0x50")]
		public Transform Slot5;

		// Token: 0x0400CAFD RID: 51965
		[Token(Token = "0x400CAFD")]
		[FieldOffset(Offset = "0x58")]
		public Transform Slot6;

		// Token: 0x0400CAFE RID: 51966
		[Token(Token = "0x400CAFE")]
		[FieldOffset(Offset = "0x60")]
		public Transform Slot7;

		// Token: 0x0400CAFF RID: 51967
		[Token(Token = "0x400CAFF")]
		[FieldOffset(Offset = "0x68")]
		public Transform Slot8;

		// Token: 0x0400CB00 RID: 51968
		[Token(Token = "0x400CB00")]
		[FieldOffset(Offset = "0x70")]
		public UIWidget dragScrollView;

		// Token: 0x0400CB01 RID: 51969
		[Token(Token = "0x400CB01")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget GuideWidgt;
	}
}
