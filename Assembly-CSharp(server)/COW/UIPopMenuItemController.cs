using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B04 RID: 6916
	[Token(Token = "0x2001B04")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x10F9274", Offset = "0x10F9274")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9274", Offset = "0x10F9274")]
	public class UIPopMenuItemController : UIBaseController
	{
		// Token: 0x06009301 RID: 37633 RVA: 0x00027180 File Offset: 0x00025380
		[Token(Token = "0x6009301")]
		[Address(RVA = "0x20EC0B0", Offset = "0x20EC0B0", VA = "0x7BBC8EC0B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009302 RID: 37634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009302")]
		[Address(RVA = "0x20EC100", Offset = "0x20EC100", VA = "0x7BBC8EC100", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009303 RID: 37635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009303")]
		[Address(RVA = "0x20EB674", Offset = "0x20EB674", VA = "0x7BBC8EB674")]
		public void SetItemData(PopMenuData data, int CellWidth, int CellHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
		{
		}

		// Token: 0x06009304 RID: 37636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009304")]
		[Address(RVA = "0x20EC1E4", Offset = "0x20EC1E4", VA = "0x7BBC8EC1E4")]
		private void SetSelectedState(bool selected)
		{
		}

		// Token: 0x06009305 RID: 37637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009305")]
		[Address(RVA = "0x20EC2FC", Offset = "0x20EC2FC", VA = "0x7BBC8EC2FC")]
		private void OnPopMenuItemClick()
		{
		}

		// Token: 0x06009306 RID: 37638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009306")]
		[Address(RVA = "0x20EC404", Offset = "0x20EC404", VA = "0x7BBC8EC404")]
		public UIPopMenuItemController()
		{
		}

		// Token: 0x04009D35 RID: 40245
		[Token(Token = "0x4009D35")]
		[FieldOffset(Offset = "0x58")]
		private UIPopMenuItemView m_View;

		// Token: 0x04009D36 RID: 40246
		[Token(Token = "0x4009D36")]
		[FieldOffset(Offset = "0x60")]
		private PopMenuData m_Data;
	}
}
