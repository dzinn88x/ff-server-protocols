using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015C3 RID: 5571
	[Token(Token = "0x20015C3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF27C", Offset = "0x10EF27C")]
	public class UIWeaponMallDetailController : UIMallDetailBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06006291 RID: 25233 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		[Token(Token = "0x6006291")]
		[Address(RVA = "0x168B61C", Offset = "0x168B61C", VA = "0x7BBBE8B61C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006292")]
		[Address(RVA = "0x168B66C", Offset = "0x168B66C", VA = "0x7BBBE8B66C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006293")]
		[Address(RVA = "0x168BF30", Offset = "0x168BF30", VA = "0x7BBBE8BF30", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006294")]
		[Address(RVA = "0x168BFE4", Offset = "0x168BFE4", VA = "0x7BBBE8BFE4", Slot = "28")]
		protected override void InitBuyBtnStyle()
		{
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006295")]
		[Address(RVA = "0x168C3A4", Offset = "0x168C3A4", VA = "0x7BBBE8C3A4")]
		private void OnBuyBtnClick()
		{
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006296")]
		[Address(RVA = "0x168C734", Offset = "0x168C734", VA = "0x7BBBE8C734")]
		private void RefreshViewData(List<StoreDesc> dataList, bool needResort = true)
		{
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006297")]
		[Address(RVA = "0x168C82C", Offset = "0x168C82C", VA = "0x7BBBE8C82C", Slot = "57")]
		public override void InitMallView()
		{
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006298")]
		[Address(RVA = "0x168CAE8", Offset = "0x168CAE8", VA = "0x7BBBE8CAE8", Slot = "58")]
		public override void RefreshMallView()
		{
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006299")]
		[Address(RVA = "0x168C9D8", Offset = "0x168C9D8", VA = "0x7BBBE8C9D8")]
		private void UpdateTabs()
		{
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629A")]
		[Address(RVA = "0x168CB10", Offset = "0x168CB10", VA = "0x7BBBE8CB10")]
		private void GenerateWeaponTypeFilterData()
		{
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629B")]
		[Address(RVA = "0x168D018", Offset = "0x168D018", VA = "0x7BBBE8D018")]
		private void GenerateWeaponModelFilterData()
		{
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629C")]
		[Address(RVA = "0x168D564", Offset = "0x168D564", VA = "0x7BBBE8D564")]
		private void ConductFilterByWeaponType(object data)
		{
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		[Token(Token = "0x600629D")]
		[Address(RVA = "0x168D7C0", Offset = "0x168D7C0", VA = "0x7BBBE8D7C0", Slot = "32")]
		protected override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629E")]
		[Address(RVA = "0x168D804", Offset = "0x168D804", VA = "0x7BBBE8D804")]
		private void UpdateWeaponTypeFilterInfo()
		{
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600629F")]
		[Address(RVA = "0x168DA98", Offset = "0x168DA98", VA = "0x7BBBE8DA98")]
		private void UpdateWeaponModelFilterInfo()
		{
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A0")]
		[Address(RVA = "0x168DD0C", Offset = "0x168DD0C", VA = "0x7BBBE8DD0C")]
		private void ConductFilterByWeaponId(object data)
		{
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A1")]
		[Address(RVA = "0x168D644", Offset = "0x168D644", VA = "0x7BBBE8D644")]
		private void RefreshCurrentFilterWeaponType(CollectionDataManager.ECollectionWeaponType selectType)
		{
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A2")]
		[Address(RVA = "0x168D6A0", Offset = "0x168D6A0", VA = "0x7BBBE8D6A0")]
		private void RefreshCurrentFilterWeaponModel(uint selectModel)
		{
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A3")]
		[Address(RVA = "0x168BD80", Offset = "0x168BD80", VA = "0x7BBBE8BD80")]
		private void ResetFilter(bool showTips = false)
		{
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A4")]
		[Address(RVA = "0x168DDDC", Offset = "0x168DDDC", VA = "0x7BBBE8DDDC", Slot = "67")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A5")]
		[Address(RVA = "0x168DE70", Offset = "0x168DE70", VA = "0x7BBBE8DE70", Slot = "68")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A6")]
		[Address(RVA = "0x168DEA0", Offset = "0x168DEA0", VA = "0x7BBBE8DEA0", Slot = "50")]
		public override void HideItemEffect()
		{
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A7")]
		[Address(RVA = "0x168DFD4", Offset = "0x168DFD4", VA = "0x7BBBE8DFD4", Slot = "33")]
		public override void HighlightCurrent()
		{
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A8")]
		[Address(RVA = "0x168E10C", Offset = "0x168E10C", VA = "0x7BBBE8E10C")]
		private void OnWeaponToggleSelectedNotOverride()
		{
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062A9")]
		[Address(RVA = "0x168E84C", Offset = "0x168E84C", VA = "0x7BBBE8E84C", Slot = "36")]
		protected override void AddMallToggleClickEvent()
		{
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062AA")]
		[Address(RVA = "0x168EA18", Offset = "0x168EA18", VA = "0x7BBBE8EA18", Slot = "54")]
		protected override string GetMallTabName(uint type)
		{
			return null;
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AB")]
		[Address(RVA = "0x168EA54", Offset = "0x168EA54", VA = "0x7BBBE8EA54", Slot = "53")]
		protected override void ResetUIStateOnToggleSelected()
		{
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AC")]
		[Address(RVA = "0x168EABC", Offset = "0x168EABC", VA = "0x7BBBE8EABC")]
		public void ConductFilter(CollectionDataManager.ECollectionWeaponType weaponType, uint weaponId)
		{
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		[Token(Token = "0x60062AD")]
		[Address(RVA = "0x168EDF8", Offset = "0x168EDF8", VA = "0x7BBBE8EDF8")]
		private bool CheckCanFilterByWeaponType(CollectionDataManager.ECollectionWeaponType weaponType)
		{
			return default(bool);
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		[Token(Token = "0x60062AE")]
		[Address(RVA = "0x168EF5C", Offset = "0x168EF5C", VA = "0x7BBBE8EF5C")]
		private bool CheckCanFilterByWeaponId(uint weaponId)
		{
			return default(bool);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062AF")]
		[Address(RVA = "0x168F0C0", Offset = "0x168F0C0", VA = "0x7BBBE8F0C0", Slot = "60")]
		public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
		{
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B0")]
		[Address(RVA = "0x168F670", Offset = "0x168F670", VA = "0x7BBBE8F670", Slot = "63")]
		public override void ShowMall()
		{
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B1")]
		[Address(RVA = "0x168F80C", Offset = "0x168F80C", VA = "0x7BBBE8F80C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x0001C608 File Offset: 0x0001A808
		[Token(Token = "0x60062B2")]
		[Address(RVA = "0x168FA14", Offset = "0x168FA14", VA = "0x7BBBE8FA14", Slot = "70")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B3")]
		[Address(RVA = "0x168FA58", Offset = "0x168FA58", VA = "0x7BBBE8FA58", Slot = "69")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B4")]
		[Address(RVA = "0x168FAEC", Offset = "0x168FAEC", VA = "0x7BBBE8FAEC", Slot = "61")]
		public override void RefreshCurrentMallView(bool clickItem)
		{
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B5")]
		[Address(RVA = "0x168D6A8", Offset = "0x168D6A8", VA = "0x7BBBE8D6A8")]
		private void RefreshDataListByFilter()
		{
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B6")]
		[Address(RVA = "0x168FB38", Offset = "0x168FB38", VA = "0x7BBBE8FB38", Slot = "55")]
		public override void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B7")]
		[Address(RVA = "0x168FC14", Offset = "0x168FC14", VA = "0x7BBBE8FC14")]
		private void RefreshItemView(uint storeID)
		{
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B8")]
		[Address(RVA = "0x1690260", Offset = "0x1690260", VA = "0x7BBBE90260")]
		private void OnGoToDiscountBtnClick()
		{
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B9")]
		[Address(RVA = "0x16902A4", Offset = "0x16902A4", VA = "0x7BBBE902A4", Slot = "65")]
		protected override void OnCommonWndFinish(params object[] data)
		{
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BA")]
		[Address(RVA = "0x169032C", Offset = "0x169032C", VA = "0x7BBBE9032C")]
		private void ShowOfferPurchase()
		{
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BB")]
		[Address(RVA = "0x168E404", Offset = "0x168E404", VA = "0x7BBBE8E404")]
		private void RefreshCurrentTabFilterDict()
		{
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BC")]
		[Address(RVA = "0x1690444", Offset = "0x1690444", VA = "0x7BBBE90444")]
		private void AddWeaponToSortedDict(uint itemID, StoreDesc storeDesc)
		{
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062BD")]
		[Address(RVA = "0x16907FC", Offset = "0x16907FC", VA = "0x7BBBE907FC")]
		public UIWeaponMallDetailController()
		{
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x0001C620 File Offset: 0x0001A820
		[Token(Token = "0x60062BE")]
		[Address(RVA = "0x1690904", Offset = "0x1690904", VA = "0x7BBBE90904")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FEEC", Offset = "0x113FEEC")]
		private bool <HighlightCurrent>b__33_0(StoreDesc item)
		{
			return default(bool);
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x0001C638 File Offset: 0x0001A838
		[Token(Token = "0x60062BF")]
		[Address(RVA = "0x1690940", Offset = "0x1690940", VA = "0x7BBBE90940")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FEFC", Offset = "0x113FEFC")]
		private bool <HighlightCurrent>b__33_1(StoreDesc item)
		{
			return default(bool);
		}

		// Token: 0x040081BA RID: 33210
		[Token(Token = "0x40081BA")]
		[FieldOffset(Offset = "0x148")]
		private List<StoreDesc> m_CurrentDataList;

		// Token: 0x040081BB RID: 33211
		[Token(Token = "0x40081BB")]
		[FieldOffset(Offset = "0x150")]
		private List<PopMenuData> m_WeaponTypeFilterPopMenuList;

		// Token: 0x040081BC RID: 33212
		[Token(Token = "0x40081BC")]
		[FieldOffset(Offset = "0x158")]
		private List<PopMenuData> m_WeaponModelFilterPopMenuList;

		// Token: 0x040081BD RID: 33213
		[Token(Token = "0x40081BD")]
		[FieldOffset(Offset = "0x160")]
		private UIPopMenuBigController m_WeaponTypeFilterPopMenu;

		// Token: 0x040081BE RID: 33214
		[Token(Token = "0x40081BE")]
		[FieldOffset(Offset = "0x168")]
		private UIPopMenuBigController m_WeaponModelFilterPopMenu;

		// Token: 0x040081BF RID: 33215
		[Token(Token = "0x40081BF")]
		[FieldOffset(Offset = "0x170")]
		private CollectionDataManager.ECollectionWeaponType m_CurrentFilterWeaponType;

		// Token: 0x040081C0 RID: 33216
		[Token(Token = "0x40081C0")]
		[FieldOffset(Offset = "0x174")]
		private uint m_CurrentFilterWeaponModel;

		// Token: 0x040081C1 RID: 33217
		[Token(Token = "0x40081C1")]
		[FieldOffset(Offset = "0x178")]
		private bool m_IsNavigation;

		// Token: 0x040081C2 RID: 33218
		[Token(Token = "0x40081C2")]
		private const uint WEAPONMODELFILTERALL = 0U;

		// Token: 0x040081C3 RID: 33219
		[Token(Token = "0x40081C3")]
		[FieldOffset(Offset = "0x179")]
		private bool m_PurchaseSuccess;

		// Token: 0x040081C4 RID: 33220
		[Token(Token = "0x40081C4")]
		[FieldOffset(Offset = "0x180")]
		private Dictionary<CollectionDataManager.ECollectionWeaponType, Dictionary<uint, List<StoreDesc>>> m_DictWeaponDataSortedByType;

		// Token: 0x020015C4 RID: 5572
		[Token(Token = "0x20015C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF2B4", Offset = "0x10EF2B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060062C1 RID: 25281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C1")]
			[Address(RVA = "0x16909E0", Offset = "0x16909E0", VA = "0x7BBBE909E0")]
			public <>c()
			{
			}

			// Token: 0x060062C2 RID: 25282 RVA: 0x0001C650 File Offset: 0x0001A850
			[Token(Token = "0x60062C2")]
			[Address(RVA = "0x16909E8", Offset = "0x16909E8", VA = "0x7BBBE909E8")]
			internal int <GenerateWeaponTypeFilterData>b__20_0(CollectionDataManager.ECollectionWeaponType a, CollectionDataManager.ECollectionWeaponType b)
			{
				return 0;
			}

			// Token: 0x060062C3 RID: 25283 RVA: 0x0001C668 File Offset: 0x0001A868
			[Token(Token = "0x60062C3")]
			[Address(RVA = "0x1690AB0", Offset = "0x1690AB0", VA = "0x7BBBE90AB0")]
			internal int <GenerateWeaponModelFilterData>b__21_0(PopMenuData a, PopMenuData b)
			{
				return 0;
			}

			// Token: 0x040081C5 RID: 33221
			[Token(Token = "0x40081C5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIWeaponMallDetailController.<>c <>9;

			// Token: 0x040081C6 RID: 33222
			[Token(Token = "0x40081C6")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<CollectionDataManager.ECollectionWeaponType> <>9__20_0;

			// Token: 0x040081C7 RID: 33223
			[Token(Token = "0x40081C7")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<PopMenuData> <>9__21_0;
		}

		// Token: 0x020015C5 RID: 5573
		[Token(Token = "0x20015C5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF2C4", Offset = "0x10EF2C4")]
		private sealed class <>c__DisplayClass41_0
		{
			// Token: 0x060062C4 RID: 25284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062C4")]
			[Address(RVA = "0x168F668", Offset = "0x168F668", VA = "0x7BBBE8F668")]
			public <>c__DisplayClass41_0()
			{
			}

			// Token: 0x060062C5 RID: 25285 RVA: 0x0001C680 File Offset: 0x0001A880
			[Token(Token = "0x60062C5")]
			[Address(RVA = "0x1690B50", Offset = "0x1690B50", VA = "0x7BBBE90B50")]
			internal bool <NavigationToItem>b__0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x060062C6 RID: 25286 RVA: 0x0001C698 File Offset: 0x0001A898
			[Token(Token = "0x60062C6")]
			[Address(RVA = "0x1690B8C", Offset = "0x1690B8C", VA = "0x7BBBE90B8C")]
			internal bool <NavigationToItem>b__1(StoreDesc item)
			{
				return default(bool);
			}

			// Token: 0x060062C7 RID: 25287 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
			[Token(Token = "0x60062C7")]
			[Address(RVA = "0x1690BC8", Offset = "0x1690BC8", VA = "0x7BBBE90BC8")]
			internal bool <NavigationToItem>b__2(StoreDesc item)
			{
				return default(bool);
			}

			// Token: 0x040081C8 RID: 33224
			[Token(Token = "0x40081C8")]
			[FieldOffset(Offset = "0x10")]
			public uint mallSubType;

			// Token: 0x040081C9 RID: 33225
			[Token(Token = "0x40081C9")]
			[FieldOffset(Offset = "0x14")]
			public uint storeID;
		}
	}
}
