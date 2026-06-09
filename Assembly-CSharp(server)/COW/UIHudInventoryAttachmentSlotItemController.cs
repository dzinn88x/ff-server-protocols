using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018E8 RID: 6376
	[Token(Token = "0x20018E8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5244", Offset = "0x10F5244")]
	internal class UIHudInventoryAttachmentSlotItemController : UIInventoryItemControllerBase
	{
		// Token: 0x06007F73 RID: 32627 RVA: 0x00022CC8 File Offset: 0x00020EC8
		[Token(Token = "0x6007F73")]
		[Address(RVA = "0x19902A0", Offset = "0x19902A0", VA = "0x7BBC1902A0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F74")]
		[Address(RVA = "0x19904B0", Offset = "0x19904B0", VA = "0x7BBC1904B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F75")]
		[Address(RVA = "0x198F94C", Offset = "0x198F94C", VA = "0x7BBC18F94C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F76")]
		[Address(RVA = "0x1990528", Offset = "0x1990528", VA = "0x7BBC190528")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06007F77 RID: 32631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F77")]
		[Address(RVA = "0x198F9BC", Offset = "0x198F9BC", VA = "0x7BBC18F9BC")]
		protected void EnableDrageDrop(bool enable)
		{
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F78")]
		[Address(RVA = "0x19906E4", Offset = "0x19906E4", VA = "0x7BBC1906E4", Slot = "39")]
		public virtual void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG, UIInventoryItemDragDropContainer parentContainer)
		{
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F79")]
		[Address(RVA = "0x198FA34", Offset = "0x198FA34", VA = "0x7BBC18FA34", Slot = "40")]
		public virtual void SetUIData(UIItem item)
		{
		}

		// Token: 0x06007F7A RID: 32634 RVA: 0x00022CE0 File Offset: 0x00020EE0
		[Token(Token = "0x6007F7A")]
		[Address(RVA = "0x1990770", Offset = "0x1990770", VA = "0x7BBC190770", Slot = "32")]
		protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007F7B RID: 32635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F7B")]
		[Address(RVA = "0x1990EC4", Offset = "0x1990EC4", VA = "0x7BBC190EC4", Slot = "30")]
		public override void OnDrapStart()
		{
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x00022CF8 File Offset: 0x00020EF8
		[Token(Token = "0x6007F7C")]
		[Address(RVA = "0x1990F70", Offset = "0x1990F70", VA = "0x7BBC190F70", Slot = "31")]
		public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F7D")]
		[Address(RVA = "0x199108C", Offset = "0x199108C", VA = "0x7BBC19108C", Slot = "34")]
		public override UIToggle GetToggle()
		{
			return null;
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F7E")]
		[Address(RVA = "0x19910B8", Offset = "0x19910B8", VA = "0x7BBC1910B8", Slot = "35")]
		public override GameObject GetHighlightGO()
		{
			return null;
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F7F")]
		[Address(RVA = "0x19910E4", Offset = "0x19910E4", VA = "0x7BBC1910E4", Slot = "36")]
		public override GameObject GetDragGO()
		{
			return null;
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F80")]
		[Address(RVA = "0x1991110", Offset = "0x1991110", VA = "0x7BBC191110", Slot = "37")]
		public override GameObject GetNonDragGO()
		{
			return null;
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F81")]
		[Address(RVA = "0x199113C", Offset = "0x199113C", VA = "0x7BBC19113C", Slot = "38")]
		public override GameObject GetDragRedGo()
		{
			return null;
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x00022D10 File Offset: 0x00020F10
		[Token(Token = "0x6007F82")]
		[Address(RVA = "0x1990EA8", Offset = "0x1990EA8", VA = "0x7BBC190EA8")]
		private ByGSUuj GetEquipSlotByContainerType(EInventoryDragDropContainerType containerType)
		{
			return ByGSUuj.PrimaryWeapon1;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F83")]
		[Address(RVA = "0x1990248", Offset = "0x1990248", VA = "0x7BBC190248")]
		public UIHudInventoryAttachmentSlotItemController()
		{
		}

		// Token: 0x04009241 RID: 37441
		[Token(Token = "0x4009241")]
		[FieldOffset(Offset = "0x68")]
		protected UIHudInventoryAttachmentSlotItemView m_View;

		// Token: 0x04009242 RID: 37442
		[Token(Token = "0x4009242")]
		[FieldOffset(Offset = "0x70")]
		protected GameObject m_EmptyBG;

		// Token: 0x04009243 RID: 37443
		[Token(Token = "0x4009243")]
		[FieldOffset(Offset = "0x78")]
		protected bool m_EnableDrag;
	}
}
