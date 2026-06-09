using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022ED RID: 8941
	[Token(Token = "0x20022ED")]
	internal class UIHudInventoryEquipSlotItemView : UIBaseView
	{
		// Token: 0x0600C0EA RID: 49386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0EA")]
		[Address(RVA = "0x1C43E9C", Offset = "0x1C43E9C", VA = "0x7BBC443E9C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0EB RID: 49387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0EB")]
		[Address(RVA = "0x1C44218", Offset = "0x1C44218", VA = "0x7BBC444218")]
		public UIHudInventoryEquipSlotItemView()
		{
		}

		// Token: 0x0400D766 RID: 55142
		[Token(Token = "0x400D766")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle ItemToggle;

		// Token: 0x0400D767 RID: 55143
		[Token(Token = "0x400D767")]
		[FieldOffset(Offset = "0x28")]
		public UIInventoryItemDragDropContainer DragDropContainer;

		// Token: 0x0400D768 RID: 55144
		[Token(Token = "0x400D768")]
		[FieldOffset(Offset = "0x30")]
		public UIInventoryItemDrapDrop DragDropItem;

		// Token: 0x0400D769 RID: 55145
		[Token(Token = "0x400D769")]
		[FieldOffset(Offset = "0x38")]
		public GameObject NonDragGO;

		// Token: 0x0400D76A RID: 55146
		[Token(Token = "0x400D76A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite ItemLevelInfo;

		// Token: 0x0400D76B RID: 55147
		[Token(Token = "0x400D76B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ItemIcon;

		// Token: 0x0400D76C RID: 55148
		[Token(Token = "0x400D76C")]
		[FieldOffset(Offset = "0x50")]
		public UILabel ItemName;

		// Token: 0x0400D76D RID: 55149
		[Token(Token = "0x400D76D")]
		[FieldOffset(Offset = "0x58")]
		public UILabel ItemCount;

		// Token: 0x0400D76E RID: 55150
		[Token(Token = "0x400D76E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject CountBGGO;

		// Token: 0x0400D76F RID: 55151
		[Token(Token = "0x400D76F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject HighlightGO;

		// Token: 0x0400D770 RID: 55152
		[Token(Token = "0x400D770")]
		[FieldOffset(Offset = "0x70")]
		public GameObject DragGO;

		// Token: 0x0400D771 RID: 55153
		[Token(Token = "0x400D771")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ItemDragIcon;

		// Token: 0x0400D772 RID: 55154
		[Token(Token = "0x400D772")]
		[FieldOffset(Offset = "0x80")]
		public GameObject DeleteMask;
	}
}
