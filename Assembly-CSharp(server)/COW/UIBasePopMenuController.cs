using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020016E6 RID: 5862
	[Token(Token = "0x20016E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0FC4", Offset = "0x10F0FC4")]
	public class UIBasePopMenuController<T> : UIPopupWindowController where T : UICommonPopMenuItemController
	{
		// Token: 0x06006C57 RID: 27735 RVA: 0x0001EA08 File Offset: 0x0001CC08
		[Token(Token = "0x6006C57")]
		protected override bool UseCustomizedAnimation()
		{
			return default(bool);
		}

		// Token: 0x06006C58 RID: 27736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C58")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006C59 RID: 27737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C59")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006C5A RID: 27738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5A")]
		public void UpdateMenuData(List<CommonPopMenuData> list)
		{
		}

		// Token: 0x06006C5B RID: 27739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5B")]
		protected void CreateMenuData(List<CommonPopMenuData> list)
		{
		}

		// Token: 0x06006C5C RID: 27740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5C")]
		private void ResizeMenuWidth()
		{
		}

		// Token: 0x06006C5D RID: 27741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5D")]
		private void ComputePopPosition(int itemNum)
		{
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5E")]
		private void OnClickeMenuItem(object[] data)
		{
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5F")]
		public UIBasePopMenuController()
		{
		}

		// Token: 0x04008805 RID: 34821
		[Token(Token = "0x4008805")]
		[FieldOffset(Offset = "0x0")]
		protected int CellWidth;

		// Token: 0x04008806 RID: 34822
		[Token(Token = "0x4008806")]
		[FieldOffset(Offset = "0x0")]
		protected int CellHeight;

		// Token: 0x04008807 RID: 34823
		[Token(Token = "0x4008807")]
		[FieldOffset(Offset = "0x0")]
		protected int CellWidthPadding;

		// Token: 0x04008808 RID: 34824
		[Token(Token = "0x4008808")]
		[FieldOffset(Offset = "0x0")]
		protected int m_NewCellWidth;

		// Token: 0x04008809 RID: 34825
		[Token(Token = "0x4008809")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_showOffset;

		// Token: 0x0400880A RID: 34826
		[Token(Token = "0x400880A")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_clickPos;

		// Token: 0x0400880B RID: 34827
		[Token(Token = "0x400880B")]
		[FieldOffset(Offset = "0x0")]
		private int m_offset;

		// Token: 0x0400880C RID: 34828
		[Token(Token = "0x400880C")]
		[FieldOffset(Offset = "0x0")]
		private int m_activatedMenuWidth;

		// Token: 0x0400880D RID: 34829
		[Token(Token = "0x400880D")]
		[FieldOffset(Offset = "0x0")]
		private int m_activatedMenuHeight;

		// Token: 0x0400880E RID: 34830
		[Token(Token = "0x400880E")]
		[FieldOffset(Offset = "0x0")]
		private float m_scale;

		// Token: 0x0400880F RID: 34831
		[Token(Token = "0x400880F")]
		[FieldOffset(Offset = "0x0")]
		private UIClickMask m_ClickMask;

		// Token: 0x04008810 RID: 34832
		[Token(Token = "0x4008810")]
		[FieldOffset(Offset = "0x0")]
		private UICommonPopMenuView m_View;

		// Token: 0x04008811 RID: 34833
		[Token(Token = "0x4008811")]
		[FieldOffset(Offset = "0x0")]
		protected List<T> m_ItemControllerList;
	}
}
