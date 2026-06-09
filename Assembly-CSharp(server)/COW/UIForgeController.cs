using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020017BE RID: 6078
	[Token(Token = "0x20017BE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2A9C", Offset = "0x10F2A9C")]
	public class UIForgeController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06007472 RID: 29810 RVA: 0x00020508 File Offset: 0x0001E708
		[Token(Token = "0x6007472")]
		[Address(RVA = "0x1DB82E8", Offset = "0x1DB82E8", VA = "0x7BBC5B82E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007473 RID: 29811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007473")]
		[Address(RVA = "0x1DB8338", Offset = "0x1DB8338", VA = "0x7BBC5B8338", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007474 RID: 29812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007474")]
		[Address(RVA = "0x1DB876C", Offset = "0x1DB876C", VA = "0x7BBC5B876C")]
		private void InitMaterialDict()
		{
		}

		// Token: 0x06007475 RID: 29813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007475")]
		[Address(RVA = "0x1DB8844", Offset = "0x1DB8844", VA = "0x7BBC5B8844")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x06007476 RID: 29814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007476")]
		[Address(RVA = "0x1DB9084", Offset = "0x1DB9084", VA = "0x7BBC5B9084")]
		private void OnMaterial1BtnClick(params object[] data)
		{
		}

		// Token: 0x06007477 RID: 29815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007477")]
		[Address(RVA = "0x1DB939C", Offset = "0x1DB939C", VA = "0x7BBC5B939C")]
		private void OnMaterial2BtnClick(params object[] data)
		{
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007478")]
		[Address(RVA = "0x1DB9118", Offset = "0x1DB9118", VA = "0x7BBC5B9118")]
		private void ShowMaterialDesc(Vector3 pos, int index)
		{
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007479")]
		[Address(RVA = "0x1DB9430", Offset = "0x1DB9430", VA = "0x7BBC5B9430")]
		private void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747A")]
		[Address(RVA = "0x1DB94CC", Offset = "0x1DB94CC", VA = "0x7BBC5B94CC")]
		private void RefreshItemView(uint itemId)
		{
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747B")]
		[Address(RVA = "0x1DBA270", Offset = "0x1DBA270", VA = "0x7BBC5BA270")]
		private void OnRefreshForgeItem(params object[] data)
		{
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747C")]
		[Address(RVA = "0x1DBA0C4", Offset = "0x1DBA0C4", VA = "0x7BBC5BA0C4")]
		private void ShowBigAwardBtn(string effectIcon)
		{
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747D")]
		[Address(RVA = "0x1DB9750", Offset = "0x1DB9750", VA = "0x7BBC5B9750")]
		private void RefreshMaterialView(ChestSpecialExchangeDesc desc)
		{
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747E")]
		[Address(RVA = "0x1DBA33C", Offset = "0x1DBA33C", VA = "0x7BBC5BA33C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600747F")]
		[Address(RVA = "0x1DBA854", Offset = "0x1DBA854", VA = "0x7BBC5BA854")]
		private void InitNavigationData(UINavigationData navigationData)
		{
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007480")]
		[Address(RVA = "0x1DBB02C", Offset = "0x1DBB02C", VA = "0x7BBC5BB02C", Slot = "31")]
		protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
		{
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007481")]
		[Address(RVA = "0x1DBB114", Offset = "0x1DBB114", VA = "0x7BBC5BB114", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007482")]
		[Address(RVA = "0x1DBB1A8", Offset = "0x1DBB1A8", VA = "0x7BBC5BB1A8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007483 RID: 29827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007483")]
		[Address(RVA = "0x1DBA644", Offset = "0x1DBA644", VA = "0x7BBC5BA644")]
		private void SetCommonPanel()
		{
		}

		// Token: 0x06007484 RID: 29828 RVA: 0x00020520 File Offset: 0x0001E720
		[Token(Token = "0x6007484")]
		[Address(RVA = "0x1DBB46C", Offset = "0x1DBB46C", VA = "0x7BBC5BB46C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06007485 RID: 29829 RVA: 0x00020538 File Offset: 0x0001E738
		[Token(Token = "0x6007485")]
		[Address(RVA = "0x1DBB474", Offset = "0x1DBB474", VA = "0x7BBC5BB474", Slot = "34")]
		public override AdType GetBackgroundCDNImageType()
		{
			return AdType.AdType_NONE;
		}

		// Token: 0x06007486 RID: 29830 RVA: 0x00020550 File Offset: 0x0001E750
		[Token(Token = "0x6007486")]
		[Address(RVA = "0x1DBB47C", Offset = "0x1DBB47C", VA = "0x7BBC5BB47C", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007487 RID: 29831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007487")]
		[Address(RVA = "0x1DBB4E0", Offset = "0x1DBB4E0", VA = "0x7BBC5BB4E0", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007488 RID: 29832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007488")]
		[Address(RVA = "0x1DBAEA0", Offset = "0x1DBAEA0", VA = "0x7BBC5BAEA0")]
		private void HighlightCurrent()
		{
		}

		// Token: 0x06007489 RID: 29833 RVA: 0x00020568 File Offset: 0x0001E768
		[Token(Token = "0x6007489")]
		[Address(RVA = "0x1DBB934", Offset = "0x1DBB934", VA = "0x7BBC5BB934", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x0600748A RID: 29834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748A")]
		[Address(RVA = "0x1DBB7B4", Offset = "0x1DBB7B4", VA = "0x7BBC5BB7B4")]
		private void RefreshView()
		{
		}

		// Token: 0x0600748B RID: 29835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748B")]
		[Address(RVA = "0x1DBB93C", Offset = "0x1DBB93C", VA = "0x7BBC5BB93C")]
		private void InitToggles()
		{
		}

		// Token: 0x0600748C RID: 29836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748C")]
		[Address(RVA = "0x1DBC410", Offset = "0x1DBC410", VA = "0x7BBC5BC410")]
		private void OnTabToggleSelected()
		{
		}

		// Token: 0x0600748D RID: 29837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748D")]
		[Address(RVA = "0x1DBB840", Offset = "0x1DBB840", VA = "0x7BBC5BB840")]
		private void RefreshViewData(List<ChestSpecialExchangeDesc> dataList, bool needSort = true)
		{
		}

		// Token: 0x0600748E RID: 29838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600748E")]
		[Address(RVA = "0x1DBC6B4", Offset = "0x1DBC6B4", VA = "0x7BBC5BC6B4", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600748F RID: 29839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600748F")]
		[Address(RVA = "0x1DBC748", Offset = "0x1DBC748", VA = "0x7BBC5BC748", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007490 RID: 29840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007490")]
		[Address(RVA = "0x1DBA9F0", Offset = "0x1DBA9F0", VA = "0x7BBC5BA9F0")]
		private void NavigationToItem(uint tabType, uint itemId)
		{
		}

		// Token: 0x06007491 RID: 29841 RVA: 0x00020580 File Offset: 0x0001E780
		[Token(Token = "0x6007491")]
		[Address(RVA = "0x1DBC780", Offset = "0x1DBC780", VA = "0x7BBC5BC780")]
		private int SortItem(ChestSpecialExchangeDesc x, ChestSpecialExchangeDesc y)
		{
			return 0;
		}

		// Token: 0x06007492 RID: 29842 RVA: 0x00020598 File Offset: 0x0001E798
		[Token(Token = "0x6007492")]
		[Address(RVA = "0x1DBA324", Offset = "0x1DBA324", VA = "0x7BBC5BA324")]
		private bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
		{
			return default(bool);
		}

		// Token: 0x06007493 RID: 29843 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[Token(Token = "0x6007493")]
		[Address(RVA = "0x1DBCA78", Offset = "0x1DBCA78", VA = "0x7BBC5BCA78", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06007494 RID: 29844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007494")]
		[Address(RVA = "0x1DBCA80", Offset = "0x1DBCA80", VA = "0x7BBC5BCA80")]
		public UIForgeController()
		{
		}

		// Token: 0x06007495 RID: 29845 RVA: 0x000205C8 File Offset: 0x0001E7C8
		[Token(Token = "0x6007495")]
		[Address(RVA = "0x1DBCB20", Offset = "0x1DBCB20", VA = "0x7BBC5BCB20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11419C0", Offset = "0x11419C0")]
		private bool <HighlightCurrent>b__42_0(ChestSpecialExchangeDesc item)
		{
			return default(bool);
		}

		// Token: 0x04008C4B RID: 35915
		[Token(Token = "0x4008C4B")]
		[FieldOffset(Offset = "0xB0")]
		private UIForgeView m_View;

		// Token: 0x04008C4C RID: 35916
		[Token(Token = "0x4008C4C")]
		[FieldOffset(Offset = "0xB8")]
		private UINavigationData m_LastNavigationData;

		// Token: 0x04008C4D RID: 35917
		[Token(Token = "0x4008C4D")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_NavToggleType;

		// Token: 0x04008C4E RID: 35918
		[Token(Token = "0x4008C4E")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_NavItemId;

		// Token: 0x04008C4F RID: 35919
		[Token(Token = "0x4008C4F")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<uint, UIToggleButton> m_ToggleDict;

		// Token: 0x04008C50 RID: 35920
		[Token(Token = "0x4008C50")]
		[FieldOffset(Offset = "0xD0")]
		private List<ChestSpecialExchangeDesc> m_CurrentDataList;

		// Token: 0x04008C51 RID: 35921
		[Token(Token = "0x4008C51")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_CurrentTab;

		// Token: 0x04008C52 RID: 35922
		[Token(Token = "0x4008C52")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_ForgeDataInitialized;

		// Token: 0x04008C53 RID: 35923
		[Token(Token = "0x4008C53")]
		[FieldOffset(Offset = "0xDD")]
		private bool m_NavigationDataInitialized;

		// Token: 0x04008C54 RID: 35924
		[Token(Token = "0x4008C54")]
		[FieldOffset(Offset = "0xDE")]
		private bool m_IsSelectedFirstToggleOnInit;

		// Token: 0x04008C55 RID: 35925
		[Token(Token = "0x4008C55")]
		[FieldOffset(Offset = "0xE0")]
		private List<UISprite> m_NotEnoughMaterial;

		// Token: 0x04008C56 RID: 35926
		[Token(Token = "0x4008C56")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_SelectedItemId;

		// Token: 0x04008C57 RID: 35927
		[Token(Token = "0x4008C57")]
		[FieldOffset(Offset = "0xEC")]
		private bool m_HaveEnoughMaterial;

		// Token: 0x04008C58 RID: 35928
		[Token(Token = "0x4008C58")]
		private const uint MATERIAL_LABEL_RED = 4281150975U;

		// Token: 0x04008C59 RID: 35929
		[Token(Token = "0x4008C59")]
		private const uint EXCHANGE_LABEL_GREY = 2139062271U;

		// Token: 0x04008C5A RID: 35930
		[Token(Token = "0x4008C5A")]
		[FieldOffset(Offset = "0xED")]
		private bool m_ItemCanExchange;

		// Token: 0x04008C5B RID: 35931
		[Token(Token = "0x4008C5B")]
		[FieldOffset(Offset = "0xF0")]
		private UIRoot m_UIRoot;

		// Token: 0x04008C5C RID: 35932
		[Token(Token = "0x4008C5C")]
		[FieldOffset(Offset = "0xF8")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008C5D RID: 35933
		[Token(Token = "0x4008C5D")]
		[FieldOffset(Offset = "0x100")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04008C5E RID: 35934
		[Token(Token = "0x4008C5E")]
		[FieldOffset(Offset = "0x108")]
		private UIModelMall m_ModelMall;

		// Token: 0x020017BF RID: 6079
		[Token(Token = "0x20017BF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2AD4", Offset = "0x10F2AD4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007497 RID: 29847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007497")]
			[Address(RVA = "0x1DBCBC0", Offset = "0x1DBCBC0", VA = "0x7BBC5BCBC0")]
			public <>c()
			{
			}

			// Token: 0x06007498 RID: 29848 RVA: 0x000205E0 File Offset: 0x0001E7E0
			[Token(Token = "0x6007498")]
			[Address(RVA = "0x1DBCBC8", Offset = "0x1DBCBC8", VA = "0x7BBC5BCBC8")]
			internal int <InitToggles>b__45_0(uint a, uint b)
			{
				return 0;
			}

			// Token: 0x04008C5F RID: 35935
			[Token(Token = "0x4008C5F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIForgeController.<>c <>9;

			// Token: 0x04008C60 RID: 35936
			[Token(Token = "0x4008C60")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<uint> <>9__45_0;
		}

		// Token: 0x020017C0 RID: 6080
		[Token(Token = "0x20017C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F2AE4", Offset = "0x10F2AE4")]
		private sealed class <>c__DisplayClass50_0
		{
			// Token: 0x06007499 RID: 29849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007499")]
			[Address(RVA = "0x1DBC778", Offset = "0x1DBC778", VA = "0x7BBC5BC778")]
			public <>c__DisplayClass50_0()
			{
			}

			// Token: 0x0600749A RID: 29850 RVA: 0x000205F8 File Offset: 0x0001E7F8
			[Token(Token = "0x600749A")]
			[Address(RVA = "0x1DBCBF4", Offset = "0x1DBCBF4", VA = "0x7BBC5BCBF4")]
			internal bool <NavigationToItem>b__0(ChestSpecialExchangeDesc item)
			{
				return default(bool);
			}

			// Token: 0x04008C61 RID: 35937
			[Token(Token = "0x4008C61")]
			[FieldOffset(Offset = "0x10")]
			public uint itemId;
		}
	}
}
