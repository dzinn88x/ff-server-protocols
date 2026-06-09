using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017AA RID: 6058
	[Token(Token = "0x20017AA")]
	internal class UIEmoteDragDropItem : UIDragDropItem
	{
		// Token: 0x060073B1 RID: 29617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B1")]
		[Address(RVA = "0x1E73868", Offset = "0x1E73868", VA = "0x7BBC673868", Slot = "7")]
		protected override void Start()
		{
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x00020220 File Offset: 0x0001E420
		[Token(Token = "0x60073B2")]
		[Address(RVA = "0x1E73900", Offset = "0x1E73900", VA = "0x7BBC673900", Slot = "11")]
		public override bool StartDragging()
		{
			return default(bool);
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B3")]
		[Address(RVA = "0x1E73AFC", Offset = "0x1E73AFC", VA = "0x7BBC673AFC", Slot = "20")]
		protected override void OnDragDropRelease(GameObject surface)
		{
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B4")]
		[Address(RVA = "0x1E74090", Offset = "0x1E74090", VA = "0x7BBC674090", Slot = "17")]
		public override void OnDragOverObject(GameObject obj)
		{
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x1E74330", Offset = "0x1E74330", VA = "0x7BBC674330")]
		public UIEmoteDragDropItem()
		{
		}

		// Token: 0x04008BFD RID: 35837
		[Token(Token = "0x4008BFD")]
		[FieldOffset(Offset = "0xB8")]
		public EmoteDragDropItemType type;

		// Token: 0x04008BFE RID: 35838
		[Token(Token = "0x4008BFE")]
		[FieldOffset(Offset = "0xC0")]
		private UIEmoteSlotController slotController;

		// Token: 0x04008BFF RID: 35839
		[Token(Token = "0x4008BFF")]
		[FieldOffset(Offset = "0xC8")]
		private UICollectionEmoteItemController emoteItemController;
	}
}
