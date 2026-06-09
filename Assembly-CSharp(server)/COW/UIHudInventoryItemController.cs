using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020018EF RID: 6383
	[Token(Token = "0x20018EF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5334", Offset = "0x10F5334")]
	internal class UIHudInventoryItemController : UIInventoryItemControllerBase
	{
		// Token: 0x06007FD9 RID: 32729 RVA: 0x00022E30 File Offset: 0x00021030
		[Token(Token = "0x6007FD9")]
		[Address(RVA = "0x1C44220", Offset = "0x1C44220", VA = "0x7BBC444220")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDA")]
		[Address(RVA = "0x1C44270", Offset = "0x1C44270", VA = "0x7BBC444270", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDB")]
		[Address(RVA = "0x1C44388", Offset = "0x1C44388", VA = "0x7BBC444388", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDC")]
		[Address(RVA = "0x1C3CA8C", Offset = "0x1C3CA8C", VA = "0x7BBC43CA8C")]
		public void SetUIData(UIItem item)
		{
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDD")]
		[Address(RVA = "0x1C40DA4", Offset = "0x1C40DA4", VA = "0x7BBC440DA4")]
		public void RefeshCount(int count)
		{
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDE")]
		[Address(RVA = "0x1C443F8", Offset = "0x1C443F8", VA = "0x7BBC4443F8")]
		private void OnOpBtnGOClick()
		{
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FDF")]
		[Address(RVA = "0x1C44AF4", Offset = "0x1C44AF4", VA = "0x7BBC444AF4", Slot = "33")]
		protected override void OnItemToggleChanged()
		{
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FE0")]
		[Address(RVA = "0x1C3CE50", Offset = "0x1C3CE50", VA = "0x7BBC43CE50")]
		public void HideOpBtnGo()
		{
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE1")]
		[Address(RVA = "0x1C44D08", Offset = "0x1C44D08", VA = "0x7BBC444D08")]
		public GameObject GetOpBtnGo()
		{
			return null;
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE2")]
		[Address(RVA = "0x1C41ECC", Offset = "0x1C41ECC", VA = "0x7BBC441ECC")]
		public UISprite GetItemIcon()
		{
			return null;
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE3")]
		[Address(RVA = "0x1C44D34", Offset = "0x1C44D34", VA = "0x7BBC444D34", Slot = "34")]
		public override UIToggle GetToggle()
		{
			return null;
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE4")]
		[Address(RVA = "0x1C44D60", Offset = "0x1C44D60", VA = "0x7BBC444D60", Slot = "35")]
		public override GameObject GetHighlightGO()
		{
			return null;
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE5")]
		[Address(RVA = "0x1C44D8C", Offset = "0x1C44D8C", VA = "0x7BBC444D8C", Slot = "36")]
		public override GameObject GetDragGO()
		{
			return null;
		}

		// Token: 0x06007FE6 RID: 32742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE6")]
		[Address(RVA = "0x1C44DB8", Offset = "0x1C44DB8", VA = "0x7BBC444DB8", Slot = "37")]
		public override GameObject GetNonDragGO()
		{
			return null;
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FE7")]
		[Address(RVA = "0x1C44DE4", Offset = "0x1C44DE4", VA = "0x7BBC444DE4")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007FE8")]
		[Address(RVA = "0x1C44F50", Offset = "0x1C44F50", VA = "0x7BBC444F50", Slot = "38")]
		public override GameObject GetDragRedGo()
		{
			return null;
		}

		// Token: 0x06007FE9 RID: 32745 RVA: 0x00022E48 File Offset: 0x00021048
		[Token(Token = "0x6007FE9")]
		[Address(RVA = "0x1C44F7C", Offset = "0x1C44F7C", VA = "0x7BBC444F7C", Slot = "32")]
		protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
		{
			return default(bool);
		}

		// Token: 0x06007FEA RID: 32746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007FEA")]
		[Address(RVA = "0x1C454D0", Offset = "0x1C454D0", VA = "0x7BBC4454D0")]
		public UIHudInventoryItemController()
		{
		}

		// Token: 0x04009270 RID: 37488
		[Token(Token = "0x4009270")]
		[FieldOffset(Offset = "0x68")]
		private UIHudInventoryItemView m_View;
	}
}
