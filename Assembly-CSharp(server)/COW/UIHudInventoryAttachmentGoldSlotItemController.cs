using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018E6 RID: 6374
	[Token(Token = "0x20018E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F51D4", Offset = "0x10F51D4")]
	internal class UIHudInventoryAttachmentGoldSlotItemController : UIHudInventoryAttachmentSlotItemController
	{
		// Token: 0x06007F66 RID: 32614 RVA: 0x00022C68 File Offset: 0x00020E68
		[Token(Token = "0x6007F66")]
		[Address(RVA = "0x198F8D4", Offset = "0x198F8D4", VA = "0x7BBC18F8D4")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F67")]
		[Address(RVA = "0x198F924", Offset = "0x198F924", VA = "0x7BBC18F924", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F68")]
		[Address(RVA = "0x198FA1C", Offset = "0x198FA1C", VA = "0x7BBC18FA1C", Slot = "30")]
		public override void OnDrapStart()
		{
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x00022C80 File Offset: 0x00020E80
		[Token(Token = "0x6007F69")]
		[Address(RVA = "0x198FA20", Offset = "0x198FA20", VA = "0x7BBC18FA20", Slot = "31")]
		public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6A")]
		[Address(RVA = "0x198FA28", Offset = "0x198FA28", VA = "0x7BBC18FA28", Slot = "40")]
		public override void SetUIData(UIItem item)
		{
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6B")]
		[Address(RVA = "0x1990240", Offset = "0x1990240", VA = "0x7BBC190240")]
		public UIHudInventoryAttachmentGoldSlotItemController()
		{
		}
	}
}
