using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002329 RID: 9001
	[Token(Token = "0x2002329")]
	public class UIHudPickupListView : UIBaseView
	{
		// Token: 0x0600C162 RID: 49506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C162")]
		[Address(RVA = "0x1D74AE8", Offset = "0x1D74AE8", VA = "0x7BBC574AE8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C163")]
		[Address(RVA = "0x1D74D4C", Offset = "0x1D74D4C", VA = "0x7BBC574D4C")]
		public UIHudPickupListView()
		{
		}

		// Token: 0x0400DA32 RID: 55858
		[Token(Token = "0x400DA32")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView InventoryTrashScrollview;

		// Token: 0x0400DA33 RID: 55859
		[Token(Token = "0x400DA33")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid InventoryTrashItemListGrid;

		// Token: 0x0400DA34 RID: 55860
		[Token(Token = "0x400DA34")]
		[FieldOffset(Offset = "0x30")]
		public Transform InventoryTrashItemListGridTF;

		// Token: 0x0400DA35 RID: 55861
		[Token(Token = "0x400DA35")]
		[FieldOffset(Offset = "0x38")]
		public Transform CustomNode;

		// Token: 0x0400DA36 RID: 55862
		[Token(Token = "0x400DA36")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ScrollViewRoot;

		// Token: 0x0400DA37 RID: 55863
		[Token(Token = "0x400DA37")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid ItemListGrid;

		// Token: 0x0400DA38 RID: 55864
		[Token(Token = "0x400DA38")]
		[FieldOffset(Offset = "0x50")]
		public Transform ItemListGridTF;

		// Token: 0x0400DA39 RID: 55865
		[Token(Token = "0x400DA39")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Mask;
	}
}
