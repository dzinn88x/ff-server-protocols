using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022EE RID: 8942
	[Token(Token = "0x20022EE")]
	internal class UIHudInventoryItemView : UIBaseView
	{
		// Token: 0x0600C0EC RID: 49388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0EC")]
		[Address(RVA = "0x1C454D8", Offset = "0x1C454D8", VA = "0x7BBC4454D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0ED RID: 49389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0ED")]
		[Address(RVA = "0x1C4584C", Offset = "0x1C4584C", VA = "0x7BBC44584C")]
		public UIHudInventoryItemView()
		{
		}

		// Token: 0x0400D773 RID: 55155
		[Token(Token = "0x400D773")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ItemToggle;

		// Token: 0x0400D774 RID: 55156
		[Token(Token = "0x400D774")]
		[FieldOffset(Offset = "0x28")]
		public UIInventoryItemDragDropContainer DragDropContainer;

		// Token: 0x0400D775 RID: 55157
		[Token(Token = "0x400D775")]
		[FieldOffset(Offset = "0x30")]
		public UIInventoryItemDrapDrop DragDropItem;

		// Token: 0x0400D776 RID: 55158
		[Token(Token = "0x400D776")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NonDragGO;

		// Token: 0x0400D777 RID: 55159
		[Token(Token = "0x400D777")]
		[FieldOffset(Offset = "0x40")]
		public UILabel ItemName;

		// Token: 0x0400D778 RID: 55160
		[Token(Token = "0x400D778")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ItemCount;

		// Token: 0x0400D779 RID: 55161
		[Token(Token = "0x400D779")]
		[FieldOffset(Offset = "0x50")]
		public GameObject OpBtnGO;

		// Token: 0x0400D77A RID: 55162
		[Token(Token = "0x400D77A")]
		[FieldOffset(Offset = "0x58")]
		public UIButton OpBtn;

		// Token: 0x0400D77B RID: 55163
		[Token(Token = "0x400D77B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HighlightGO;

		// Token: 0x0400D77C RID: 55164
		[Token(Token = "0x400D77C")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ItemIcon;

		// Token: 0x0400D77D RID: 55165
		[Token(Token = "0x400D77D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DragGO;

		// Token: 0x0400D77E RID: 55166
		[Token(Token = "0x400D77E")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ItemDragIcon;

		// Token: 0x0400D77F RID: 55167
		[Token(Token = "0x400D77F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DeleteMask;
	}
}
