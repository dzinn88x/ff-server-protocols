using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020013FD RID: 5117
	[Token(Token = "0x20013FD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC418", Offset = "0x10EC418")]
	internal class UIActivityPopWindowBase : UINaviPopController
	{
		// Token: 0x0600542E RID: 21550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542E")]
		[Address(RVA = "0x195484C", Offset = "0x195484C", VA = "0x7BBC15484C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542F")]
		[Address(RVA = "0x1954C04", Offset = "0x1954C04", VA = "0x7BBC154C04", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005430 RID: 21552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005430")]
		[Address(RVA = "0x1956028", Offset = "0x1956028", VA = "0x7BBC156028")]
		protected Transform ContentMountPoint()
		{
			return null;
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005431")]
		[Address(RVA = "0x1958360", Offset = "0x1958360", VA = "0x7BBC158360")]
		protected void WaitForNetworkDataUI(bool noData)
		{
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005432")]
		[Address(RVA = "0x19583C4", Offset = "0x19583C4", VA = "0x7BBC1583C4", Slot = "40")]
		public virtual void UpdateUI()
		{
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005433")]
		[Address(RVA = "0x19556CC", Offset = "0x19556CC", VA = "0x7BBC1556CC", Slot = "41")]
		public virtual void PrepareTopTabData()
		{
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x00019230 File Offset: 0x00017430
		[Token(Token = "0x6005434")]
		[Address(RVA = "0x1958BAC", Offset = "0x1958BAC", VA = "0x7BBC158BAC")]
		private int GetFullWidth()
		{
			return 0;
		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005435")]
		[Address(RVA = "0x19585A4", Offset = "0x19585A4", VA = "0x7BBC1585A4")]
		private void CreateTopTabs()
		{
		}

		// Token: 0x06005436 RID: 21558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005436")]
		[Address(RVA = "0x1958CF8", Offset = "0x1958CF8", VA = "0x7BBC158CF8")]
		public void UpdateTabs()
		{
		}

		// Token: 0x06005437 RID: 21559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005437")]
		[Address(RVA = "0x1958FA8", Offset = "0x1958FA8", VA = "0x7BBC158FA8")]
		private void AdjustTabsWidth(UIToggleButton tab, int index, int width)
		{
		}

		// Token: 0x06005438 RID: 21560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005438")]
		[Address(RVA = "0x195896C", Offset = "0x195896C", VA = "0x7BBC15896C")]
		public void GotoSpecificCategory(int categoryType, uint id)
		{
		}

		// Token: 0x06005439 RID: 21561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005439")]
		[Address(RVA = "0x195956C", Offset = "0x195956C", VA = "0x7BBC15956C")]
		public void GotoSpecificTCategoryByTabType(uint tabTabType, uint id)
		{
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543A")]
		[Address(RVA = "0x195959C", Offset = "0x195959C", VA = "0x7BBC15959C")]
		private void TopTabSelected(int index)
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543B")]
		[Address(RVA = "0x1959C08", Offset = "0x1959C08", VA = "0x7BBC159C08", Slot = "42")]
		protected virtual void OnMainTabSelect(UIActivityPopWindowBase.CategoryTabData data)
		{
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543C")]
		[Address(RVA = "0x1959740", Offset = "0x1959740", VA = "0x7BBC159740")]
		private void HideCurrentContent()
		{
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543D")]
		[Address(RVA = "0x1955A98", Offset = "0x1955A98", VA = "0x7BBC155A98")]
		protected UIActivityBaseController GetCurrentContent()
		{
			return null;
		}

		// Token: 0x0600543E RID: 21566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600543E")]
		[Address(RVA = "0x19593C0", Offset = "0x19593C0", VA = "0x7BBC1593C0")]
		private void ShowHighestPriorityTab()
		{
		}

		// Token: 0x0600543F RID: 21567 RVA: 0x00019248 File Offset: 0x00017448
		[Token(Token = "0x600543F")]
		[Address(RVA = "0x1959C0C", Offset = "0x1959C0C", VA = "0x7BBC159C0C", Slot = "43")]
		protected virtual int GetTabPriority(UIActivityPopWindowBase.CategoryTabData tabData)
		{
			return 0;
		}

		// Token: 0x06005440 RID: 21568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005440")]
		[Address(RVA = "0x1959C14", Offset = "0x1959C14", VA = "0x7BBC159C14")]
		protected void SelectToggle(UIToggleButton toggle)
		{
		}

		// Token: 0x06005441 RID: 21569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005441")]
		[Address(RVA = "0x1959C8C", Offset = "0x1959C8C", VA = "0x7BBC159C8C")]
		private void OnActivityGotoClick(params object[] data)
		{
		}

		// Token: 0x06005442 RID: 21570 RVA: 0x00019260 File Offset: 0x00017460
		[Token(Token = "0x6005442")]
		[Address(RVA = "0x19556E8", Offset = "0x19556E8", VA = "0x7BBC1556E8")]
		public int TabType2ActivityCategory(uint tabType)
		{
			return 0;
		}

		// Token: 0x06005443 RID: 21571 RVA: 0x00019278 File Offset: 0x00017478
		[Token(Token = "0x6005443")]
		[Address(RVA = "0x19562A4", Offset = "0x19562A4", VA = "0x7BBC1562A4")]
		public uint ActivityCategory2TabType(int category)
		{
			return 0U;
		}

		// Token: 0x06005444 RID: 21572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005444")]
		[Address(RVA = "0x1954E70", Offset = "0x1954E70", VA = "0x7BBC154E70")]
		public void UpdateBGCDN(string url)
		{
		}

		// Token: 0x06005445 RID: 21573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005445")]
		[Address(RVA = "0x1955E90", Offset = "0x1955E90", VA = "0x7BBC155E90")]
		public UIActivityPopWindowBase()
		{
		}

		// Token: 0x040079AA RID: 31146
		[Token(Token = "0x40079AA")]
		[FieldOffset(Offset = "0xB8")]
		private UIActivityMasterView m_View;

		// Token: 0x040079AB RID: 31147
		[Token(Token = "0x40079AB")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<int, UIActivityBaseController> m_Contents;

		// Token: 0x040079AC RID: 31148
		[Token(Token = "0x40079AC")]
		[FieldOffset(Offset = "0xC8")]
		private int m_CurrentTabIndex;

		// Token: 0x040079AD RID: 31149
		[Token(Token = "0x40079AD")]
		[FieldOffset(Offset = "0xD0")]
		protected Dictionary<uint, int> m_TabTypeActivityCategoryMap;

		// Token: 0x040079AE RID: 31150
		[Token(Token = "0x40079AE")]
		[FieldOffset(Offset = "0x0")]
		public static ResourceID m_UIResourceID;

		// Token: 0x040079AF RID: 31151
		[Token(Token = "0x40079AF")]
		[FieldOffset(Offset = "0xD8")]
		protected float m_RequestTimeout;

		// Token: 0x040079B0 RID: 31152
		[Token(Token = "0x40079B0")]
		[FieldOffset(Offset = "0xDC")]
		protected int m_CurrentType;

		// Token: 0x040079B1 RID: 31153
		[Token(Token = "0x40079B1")]
		[FieldOffset(Offset = "0xE0")]
		private int m_TabSpace;

		// Token: 0x040079B2 RID: 31154
		[Token(Token = "0x40079B2")]
		[FieldOffset(Offset = "0xE8")]
		protected List<UIActivityPopWindowBase.CategoryTabData> m_CategoryDatas;

		// Token: 0x040079B3 RID: 31155
		[Token(Token = "0x40079B3")]
		[FieldOffset(Offset = "0xF0")]
		private UIActivityPopWindowBase.GoToArgs m_GoToArgs;

		// Token: 0x040079B4 RID: 31156
		[Token(Token = "0x40079B4")]
		[FieldOffset(Offset = "0xF8")]
		private List<StandardTopTabItemViewData> m_TabDataList;

		// Token: 0x040079B5 RID: 31157
		[Token(Token = "0x40079B5")]
		[FieldOffset(Offset = "0x100")]
		private UIStandardTopTabController m_TabCtrl;

		// Token: 0x020013FE RID: 5118
		[Token(Token = "0x20013FE")]
		private class GoToArgs
		{
			// Token: 0x06005447 RID: 21575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005447")]
			[Address(RVA = "0x19593B8", Offset = "0x19593B8", VA = "0x7BBC1593B8")]
			public GoToArgs()
			{
			}

			// Token: 0x040079B6 RID: 31158
			[Token(Token = "0x40079B6")]
			[FieldOffset(Offset = "0x10")]
			public int categoryType;

			// Token: 0x040079B7 RID: 31159
			[Token(Token = "0x40079B7")]
			[FieldOffset(Offset = "0x14")]
			public uint id;
		}

		// Token: 0x020013FF RID: 5119
		// (Invoke) Token: 0x06005449 RID: 21577
		[Token(Token = "0x20013FF")]
		protected delegate UIActivityBaseController ContentCreator();

		// Token: 0x02001400 RID: 5120
		[Token(Token = "0x2001400")]
		protected class CategoryTabData
		{
			// Token: 0x0600544C RID: 21580 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600544C")]
			[Address(RVA = "0x19556D0", Offset = "0x19556D0", VA = "0x7BBC1556D0")]
			public CategoryTabData()
			{
			}

			// Token: 0x040079B8 RID: 31160
			[Token(Token = "0x40079B8")]
			[FieldOffset(Offset = "0x10")]
			public UIActivityPopWindowBase.ContentCreator content;

			// Token: 0x040079B9 RID: 31161
			[Token(Token = "0x40079B9")]
			[FieldOffset(Offset = "0x18")]
			public string title;

			// Token: 0x040079BA RID: 31162
			[Token(Token = "0x40079BA")]
			[FieldOffset(Offset = "0x20")]
			public string icon;

			// Token: 0x040079BB RID: 31163
			[Token(Token = "0x40079BB")]
			[FieldOffset(Offset = "0x28")]
			public ETipsType redPoint;

			// Token: 0x040079BC RID: 31164
			[Token(Token = "0x40079BC")]
			[FieldOffset(Offset = "0x30")]
			public object data;

			// Token: 0x040079BD RID: 31165
			[Token(Token = "0x40079BD")]
			[FieldOffset(Offset = "0x38")]
			public string colorValue;

			// Token: 0x040079BE RID: 31166
			[Token(Token = "0x40079BE")]
			[FieldOffset(Offset = "0x40")]
			public string selectLine;

			// Token: 0x040079BF RID: 31167
			[Token(Token = "0x40079BF")]
			[FieldOffset(Offset = "0x48")]
			public uint prioritySelectItemID;

			// Token: 0x040079C0 RID: 31168
			[Token(Token = "0x40079C0")]
			[FieldOffset(Offset = "0x4C")]
			public int optActivityCategory;
		}

		// Token: 0x02001401 RID: 5121
		[Token(Token = "0x2001401")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC450", Offset = "0x10EC450")]
		private sealed class <>c__DisplayClass25_0
		{
			// Token: 0x0600544D RID: 21581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600544D")]
			[Address(RVA = "0x19593B0", Offset = "0x19593B0", VA = "0x7BBC1593B0")]
			public <>c__DisplayClass25_0()
			{
			}

			// Token: 0x0600544E RID: 21582 RVA: 0x00019290 File Offset: 0x00017490
			[Token(Token = "0x600544E")]
			[Address(RVA = "0x1959D9C", Offset = "0x1959D9C", VA = "0x7BBC159D9C")]
			internal bool <GotoSpecificCategory>b__0(UIActivityPopWindowBase.CategoryTabData e)
			{
				return default(bool);
			}

			// Token: 0x040079C1 RID: 31169
			[Token(Token = "0x40079C1")]
			[FieldOffset(Offset = "0x10")]
			public int categoryType;
		}
	}
}
