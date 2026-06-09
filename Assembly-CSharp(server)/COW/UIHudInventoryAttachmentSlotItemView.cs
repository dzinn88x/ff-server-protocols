using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022EB RID: 8939
	[Token(Token = "0x20022EB")]
	public class UIHudInventoryAttachmentSlotItemView : UIBaseView
	{
		// Token: 0x0600C0E6 RID: 49382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E6")]
		[Address(RVA = "0x1991168", Offset = "0x1991168", VA = "0x7BBC191168", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E7")]
		[Address(RVA = "0x19914E4", Offset = "0x19914E4", VA = "0x7BBC1914E4")]
		public UIHudInventoryAttachmentSlotItemView()
		{
		}

		// Token: 0x0400D753 RID: 55123
		[Token(Token = "0x400D753")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ItemToggle;

		// Token: 0x0400D754 RID: 55124
		[Token(Token = "0x400D754")]
		[FieldOffset(Offset = "0x28")]
		public UIInventoryItemDragDropContainer DragDropContainer;

		// Token: 0x0400D755 RID: 55125
		[Token(Token = "0x400D755")]
		[FieldOffset(Offset = "0x30")]
		public UIInventoryItemDrapDrop DragDropItem;

		// Token: 0x0400D756 RID: 55126
		[Token(Token = "0x400D756")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NonDragGO;

		// Token: 0x0400D757 RID: 55127
		[Token(Token = "0x400D757")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ItemIcon;

		// Token: 0x0400D758 RID: 55128
		[Token(Token = "0x400D758")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ItemLevelInfoLabel;

		// Token: 0x0400D759 RID: 55129
		[Token(Token = "0x400D759")]
		[FieldOffset(Offset = "0x50")]
		public UISprite ItemLevelInfo;

		// Token: 0x0400D75A RID: 55130
		[Token(Token = "0x400D75A")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ItemBg;

		// Token: 0x0400D75B RID: 55131
		[Token(Token = "0x400D75B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject HighlightGO;

		// Token: 0x0400D75C RID: 55132
		[Token(Token = "0x400D75C")]
		[FieldOffset(Offset = "0x68")]
		public UISprite HighlightSprite;

		// Token: 0x0400D75D RID: 55133
		[Token(Token = "0x400D75D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DragGO;

		// Token: 0x0400D75E RID: 55134
		[Token(Token = "0x400D75E")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ItemDragIcon;

		// Token: 0x0400D75F RID: 55135
		[Token(Token = "0x400D75F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DeleteMask;
	}
}
