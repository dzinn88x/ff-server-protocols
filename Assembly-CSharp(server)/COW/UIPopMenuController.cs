using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B01 RID: 6913
	[Token(Token = "0x2001B01")]
	[Attribute(Name = "ObsoleteAttribute", RVA = "0x10F917C", Offset = "0x10F917C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F917C", Offset = "0x10F917C")]
	public class UIPopMenuController : UIBaseController
	{
		// Token: 0x060092E7 RID: 37607 RVA: 0x00027150 File Offset: 0x00025350
		[Token(Token = "0x60092E7")]
		[Address(RVA = "0x20EAF34", Offset = "0x20EAF34", VA = "0x7BBC8EAF34")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060092E8 RID: 37608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092E8")]
		[Address(RVA = "0x20EAF84", Offset = "0x20EAF84", VA = "0x7BBC8EAF84", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060092E9 RID: 37609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092E9")]
		[Address(RVA = "0x20EB0E4", Offset = "0x20EB0E4", VA = "0x7BBC8EB0E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060092EA RID: 37610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092EA")]
		[Address(RVA = "0x20EB1B0", Offset = "0x20EB1B0", VA = "0x7BBC8EB1B0")]
		public void SetPopMenu(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot)
		{
		}

		// Token: 0x060092EB RID: 37611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092EB")]
		public void SetCustomizePopMenu<T>(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, bool showBg = true, bool showCustomizedBg = true, bool setSize = false) where T : UIPopMenuItemBaseController
		{
		}

		// Token: 0x060092EC RID: 37612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092EC")]
		public void SetCustomizePopMenu<T>(List<PopMenuData> dataList, int CellWidth, int CellHeight, int PanelMaxHeight, float itemLocalPositionX, NGUIText.Alignment labelAlignment, UIWidget.Pivot labelPivot, bool showBg = true, bool showCustomizedBg = true) where T : UIPopMenuItemBaseController
		{
		}

		// Token: 0x060092ED RID: 37613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092ED")]
		[Address(RVA = "0x20EB88C", Offset = "0x20EB88C", VA = "0x7BBC8EB88C")]
		private void UpdateViewUI()
		{
		}

		// Token: 0x060092EE RID: 37614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092EE")]
		[Address(RVA = "0x20EB890", Offset = "0x20EB890", VA = "0x7BBC8EB890")]
		public void SetPopMenuDepth(int d)
		{
		}

		// Token: 0x060092EF RID: 37615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092EF")]
		[Address(RVA = "0x20EB92C", Offset = "0x20EB92C", VA = "0x7BBC8EB92C")]
		private void OnMaskClick()
		{
		}

		// Token: 0x060092F0 RID: 37616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F0")]
		[Address(RVA = "0x20EB934", Offset = "0x20EB934", VA = "0x7BBC8EB934")]
		private void OnClickeMenuItem(object[] data)
		{
		}

		// Token: 0x060092F1 RID: 37617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F1")]
		[Address(RVA = "0x20EB93C", Offset = "0x20EB93C", VA = "0x7BBC8EB93C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060092F2 RID: 37618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F2")]
		[Address(RVA = "0x20EB978", Offset = "0x20EB978", VA = "0x7BBC8EB978")]
		public void DisableMask()
		{
		}

		// Token: 0x060092F3 RID: 37619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F3")]
		[Address(RVA = "0x20EB9D4", Offset = "0x20EB9D4", VA = "0x7BBC8EB9D4")]
		public void ResetMutilPopMenuItemState()
		{
		}

		// Token: 0x060092F4 RID: 37620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092F4")]
		[Address(RVA = "0x20EBAB0", Offset = "0x20EBAB0", VA = "0x7BBC8EBAB0")]
		public UIPopMenuController()
		{
		}

		// Token: 0x04009D30 RID: 40240
		[Token(Token = "0x4009D30")]
		[FieldOffset(Offset = "0x58")]
		private UIPopMenuView m_View;

		// Token: 0x04009D31 RID: 40241
		[Token(Token = "0x4009D31")]
		[FieldOffset(Offset = "0x60")]
		public PopMenuDelegate onPopMenuClose;
	}
}
