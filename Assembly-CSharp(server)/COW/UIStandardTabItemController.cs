using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001676 RID: 5750
	[Token(Token = "0x2001676")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F024C", Offset = "0x10F024C")]
	public class UIStandardTabItemController : UIEasyListItemController
	{
		// Token: 0x06006844 RID: 26692 RVA: 0x0001D940 File Offset: 0x0001BB40
		[Token(Token = "0x6006844")]
		[Address(RVA = "0x2131AA8", Offset = "0x2131AA8", VA = "0x7BBC931AA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006845")]
		[Address(RVA = "0x2131AF8", Offset = "0x2131AF8", VA = "0x7BBC931AF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006846")]
		[Address(RVA = "0x2131BDC", Offset = "0x2131BDC", VA = "0x7BBC931BDC", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006847")]
		[Address(RVA = "0x2132484", Offset = "0x2132484", VA = "0x7BBC932484")]
		public void SetFixRectState(bool value)
		{
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006848")]
		[Address(RVA = "0x2131EAC", Offset = "0x2131EAC", VA = "0x7BBC931EAC")]
		public void CheckTagState()
		{
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006849")]
		[Address(RVA = "0x21322D0", Offset = "0x21322D0", VA = "0x7BBC9322D0")]
		private void UpdateArrowState(bool value)
		{
		}

		// Token: 0x0600684A RID: 26698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684A")]
		[Address(RVA = "0x21324CC", Offset = "0x21324CC", VA = "0x7BBC9324CC")]
		public void CreateSubTabByDataList(List<StandardSubTabItemViewData> subTabDataist, Transform subTabContainer)
		{
		}

		// Token: 0x0600684B RID: 26699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684B")]
		[Address(RVA = "0x21326A8", Offset = "0x21326A8", VA = "0x7BBC9326A8")]
		private void UpdateSubTabState(bool value)
		{
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684C")]
		[Address(RVA = "0x2130D14", Offset = "0x2130D14", VA = "0x7BBC930D14")]
		public void SelectSubTabByIndex(int index)
		{
		}

		// Token: 0x0600684D RID: 26701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600684D")]
		[Address(RVA = "0x2132888", Offset = "0x2132888", VA = "0x7BBC932888")]
		public UIStandardSubTabItemController GetSubTabItemController(int index)
		{
			return null;
		}

		// Token: 0x0600684E RID: 26702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684E")]
		[Address(RVA = "0x2132954", Offset = "0x2132954", VA = "0x7BBC932954", Slot = "31")]
		public override void OnItemBtnSelect()
		{
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600684F")]
		[Address(RVA = "0x2132384", Offset = "0x2132384", VA = "0x7BBC932384")]
		public void CheckTipButton()
		{
		}

		// Token: 0x06006850 RID: 26704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006850")]
		[Address(RVA = "0x2132B58", Offset = "0x2132B58", VA = "0x7BBC932B58", Slot = "32")]
		public override void OnItemBtnUnSelect()
		{
		}

		// Token: 0x06006851 RID: 26705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006851")]
		[Address(RVA = "0x2132BF0", Offset = "0x2132BF0", VA = "0x7BBC932BF0")]
		public void InitDrawerTabItem()
		{
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006852")]
		[Address(RVA = "0x2132D64", Offset = "0x2132D64", VA = "0x7BBC932D64")]
		public void UpdateSelectState(bool isSelect)
		{
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006853")]
		[Address(RVA = "0x2132FA0", Offset = "0x2132FA0", VA = "0x7BBC932FA0")]
		public void ExecuteBtnTabItemClick()
		{
		}

		// Token: 0x06006854 RID: 26708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006854")]
		[Address(RVA = "0x2133004", Offset = "0x2133004", VA = "0x7BBC933004")]
		private void SelectCurSubTabItem()
		{
		}

		// Token: 0x06006855 RID: 26709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006855")]
		[Address(RVA = "0x2133018", Offset = "0x2133018", VA = "0x7BBC933018")]
		private void OnDrawerTabItemSelect()
		{
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x0001D958 File Offset: 0x0001BB58
		[Token(Token = "0x6006856")]
		[Address(RVA = "0x213310C", Offset = "0x213310C", VA = "0x7BBC93310C")]
		public bool IsNoSubTabItem()
		{
			return default(bool);
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006857")]
		[Address(RVA = "0x213311C", Offset = "0x213311C", VA = "0x7BBC93311C")]
		public void RegisterSubTabTipEvent(ETipsType tipType)
		{
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x0001D970 File Offset: 0x0001BB70
		[Token(Token = "0x6006858")]
		[Address(RVA = "0x213323C", Offset = "0x213323C", VA = "0x7BBC93323C")]
		public int GetTabCount()
		{
			return 0;
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006859")]
		[Address(RVA = "0x21317A8", Offset = "0x21317A8", VA = "0x7BBC9317A8")]
		public void ChangeLabelFontSize(int size)
		{
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600685A")]
		[Address(RVA = "0x21332E8", Offset = "0x21332E8", VA = "0x7BBC9332E8")]
		public UIStandardTabItemController()
		{
		}

		// Token: 0x0400852B RID: 34091
		[Token(Token = "0x400852B")]
		[FieldOffset(Offset = "0x70")]
		private UIStandardTabItemView m_View;

		// Token: 0x0400852C RID: 34092
		[Token(Token = "0x400852C")]
		[FieldOffset(Offset = "0x78")]
		private StandardTabItemViewData m_Data;

		// Token: 0x0400852D RID: 34093
		[Token(Token = "0x400852D")]
		[FieldOffset(Offset = "0x80")]
		private List<UIStandardSubTabItemController> subTabList;

		// Token: 0x0400852E RID: 34094
		[Token(Token = "0x400852E")]
		[FieldOffset(Offset = "0x88")]
		private int curSubTabIndex;

		// Token: 0x0400852F RID: 34095
		[Token(Token = "0x400852F")]
		[FieldOffset(Offset = "0x8C")]
		private int m_MainTabIndex;

		// Token: 0x04008530 RID: 34096
		[Token(Token = "0x4008530")]
		[FieldOffset(Offset = "0x90")]
		public bool isDrawerOpen;

		// Token: 0x04008531 RID: 34097
		[Token(Token = "0x4008531")]
		[FieldOffset(Offset = "0x0")]
		private static Color selectArrowColor;

		// Token: 0x04008532 RID: 34098
		[Token(Token = "0x4008532")]
		[FieldOffset(Offset = "0x10")]
		private static Color unselectArrowColor;
	}
}
