using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018EE RID: 6382
	[Token(Token = "0x20018EE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F52FC", Offset = "0x10F52FC")]
	internal class UIHudInventoryEquipSlotItemController : UIInventoryItemControllerBase
	{
		// Token: 0x06007FCA RID: 32714 RVA: 0x00022DE8 File Offset: 0x00020FE8
		[Token(Token = "0x6007FCA")]
		[Address(RVA = "0x1C437C4", Offset = "0x1C437C4", VA = "0x7BBC4437C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCB")]
		[Address(RVA = "0x1C43814", Offset = "0x1C43814", VA = "0x7BBC443814", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCC")]
		[Address(RVA = "0x1C43880", Offset = "0x1C43880", VA = "0x7BBC443880", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007FCD RID: 32717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCD")]
		[Address(RVA = "0x1C39780", Offset = "0x1C39780", VA = "0x7BBC439780")]
		public void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG)
		{
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FCE")]
		[Address(RVA = "0x1C3F870", Offset = "0x1C3F870", VA = "0x7BBC43F870")]
		public void SetUIData(UIItem item)
		{
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x00022E00 File Offset: 0x00021000
		[Token(Token = "0x6007FCF")]
		[Address(RVA = "0x1C438F0", Offset = "0x1C438F0", VA = "0x7BBC4438F0", Slot = "32")]
		protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FD0")]
		[Address(RVA = "0x1C43A34", Offset = "0x1C43A34", VA = "0x7BBC443A34", Slot = "30")]
		public override void OnDrapStart()
		{
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FD1")]
		[Address(RVA = "0x1C43AE0", Offset = "0x1C43AE0", VA = "0x7BBC443AE0")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x00022E18 File Offset: 0x00021018
		[Token(Token = "0x6007FD2")]
		[Address(RVA = "0x1C43C9C", Offset = "0x1C43C9C", VA = "0x7BBC443C9C", Slot = "31")]
		public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD3")]
		[Address(RVA = "0x1C43DB8", Offset = "0x1C43DB8", VA = "0x7BBC443DB8", Slot = "34")]
		public override UIToggle GetToggle()
		{
			return null;
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD4")]
		[Address(RVA = "0x1C43DE4", Offset = "0x1C43DE4", VA = "0x7BBC443DE4", Slot = "35")]
		public override GameObject GetHighlightGO()
		{
			return null;
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD5")]
		[Address(RVA = "0x1C43E10", Offset = "0x1C43E10", VA = "0x7BBC443E10", Slot = "36")]
		public override GameObject GetDragGO()
		{
			return null;
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD6")]
		[Address(RVA = "0x1C43E3C", Offset = "0x1C43E3C", VA = "0x7BBC443E3C", Slot = "37")]
		public override GameObject GetNonDragGO()
		{
			return null;
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FD7")]
		[Address(RVA = "0x1C43E68", Offset = "0x1C43E68", VA = "0x7BBC443E68", Slot = "38")]
		public override GameObject GetDragRedGo()
		{
			return null;
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FD8")]
		[Address(RVA = "0x1C43E94", Offset = "0x1C43E94", VA = "0x7BBC443E94")]
		public UIHudInventoryEquipSlotItemController()
		{
		}

		// Token: 0x0400926E RID: 37486
		[Token(Token = "0x400926E")]
		[FieldOffset(Offset = "0x68")]
		private UIHudInventoryEquipSlotItemView m_View;

		// Token: 0x0400926F RID: 37487
		[Token(Token = "0x400926F")]
		[FieldOffset(Offset = "0x70")]
		private GameObject m_EmptyBG;
	}
}
