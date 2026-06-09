using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018E7 RID: 6375
	[Token(Token = "0x20018E7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F520C", Offset = "0x10F520C")]
	internal class UIHudInventoryAttachmentLockedSlotItemController : UIHudInventoryAttachmentSlotItemController
	{
		// Token: 0x06007F6C RID: 32620 RVA: 0x00022C98 File Offset: 0x00020E98
		[Token(Token = "0x6007F6C")]
		[Address(RVA = "0x1990250", Offset = "0x1990250", VA = "0x7BBC190250")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6D")]
		[Address(RVA = "0x19902F0", Offset = "0x19902F0", VA = "0x7BBC1902F0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6E")]
		[Address(RVA = "0x1990414", Offset = "0x1990414", VA = "0x7BBC190414", Slot = "39")]
		public override void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG, UIInventoryItemDragDropContainer parentContainer)
		{
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F6F")]
		[Address(RVA = "0x1990498", Offset = "0x1990498", VA = "0x7BBC190498", Slot = "30")]
		public override void OnDrapStart()
		{
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x00022CB0 File Offset: 0x00020EB0
		[Token(Token = "0x6007F70")]
		[Address(RVA = "0x199049C", Offset = "0x199049C", VA = "0x7BBC19049C", Slot = "31")]
		public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F71")]
		[Address(RVA = "0x19904A4", Offset = "0x19904A4", VA = "0x7BBC1904A4", Slot = "33")]
		protected override void OnItemToggleChanged()
		{
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F72")]
		[Address(RVA = "0x19904A8", Offset = "0x19904A8", VA = "0x7BBC1904A8")]
		public UIHudInventoryAttachmentLockedSlotItemController()
		{
		}
	}
}
