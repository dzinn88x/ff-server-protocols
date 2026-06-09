using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001525 RID: 5413
	[Token(Token = "0x2001525")]
	public class UICollectionMainBaseController : UIBaseController
	{
		// Token: 0x06005CFF RID: 23807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0x20A8340", Offset = "0x20A8340", VA = "0x7BBC8A8340", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D00")]
		[Address(RVA = "0x20A88CC", Offset = "0x20A88CC", VA = "0x7BBC8A88CC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D01")]
		[Address(RVA = "0x20A8998", Offset = "0x20A8998", VA = "0x7BBC8A8998", Slot = "28")]
		protected virtual void GeneratePopMenuData()
		{
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D02")]
		[Address(RVA = "0x20A8A18", Offset = "0x20A8A18", VA = "0x7BBC8A8A18", Slot = "29")]
		protected virtual void OnEquipBtnClick()
		{
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D03")]
		[Address(RVA = "0x20A8AE8", Offset = "0x20A8AE8", VA = "0x7BBC8A8AE8")]
		protected void ShowNotReachRankItemUseLevelTips(uint itemID)
		{
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x20A8E0C", Offset = "0x20A8E0C", VA = "0x7BBC8A8E0C", Slot = "30")]
		protected virtual void OnShownBtnClick()
		{
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D05")]
		[Address(RVA = "0x20A86E8", Offset = "0x20A86E8", VA = "0x7BBC8A86E8")]
		private void InitUITable2()
		{
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D06")]
		protected void RefreshCategoryList<DataType>(List<DataType> dataList, bool weapon = false, bool vehicle = false)
		{
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D07")]
		[Address(RVA = "0x20A8E10", Offset = "0x20A8E10", VA = "0x7BBC8A8E10")]
		protected void SetEquipBtnStatus(bool isEquiped = false)
		{
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D08")]
		[Address(RVA = "0x20A9050", Offset = "0x20A9050", VA = "0x7BBC8A9050", Slot = "31")]
		protected virtual void RefreshShowBtn()
		{
		}

		// Token: 0x06005D09 RID: 23817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x20A9054", Offset = "0x20A9054", VA = "0x7BBC8A9054")]
		protected void SetShowBtnStatus(bool canBeShowed, bool isShowed)
		{
		}

		// Token: 0x06005D0A RID: 23818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D0A")]
		[Address(RVA = "0x20A9110", Offset = "0x20A9110", VA = "0x7BBC8A9110")]
		protected void UpdateNew3DPreview(uint collectionId)
		{
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D0B")]
		[Address(RVA = "0x20A94D0", Offset = "0x20A94D0", VA = "0x7BBC8A94D0")]
		protected void Update3DPreview(uint collectionId)
		{
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x0001B0A8 File Offset: 0x000192A8
		[Token(Token = "0x6005D0C")]
		[Address(RVA = "0x20A98D4", Offset = "0x20A98D4", VA = "0x7BBC8A98D4", Slot = "32")]
		protected virtual bool HaveItems()
		{
			return default(bool);
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D0D")]
		[Address(RVA = "0x20A9970", Offset = "0x20A9970", VA = "0x7BBC8A9970")]
		protected void ResetPreview()
		{
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D0E")]
		[Address(RVA = "0x20A9978", Offset = "0x20A9978", VA = "0x7BBC8A9978")]
		protected void ShowBtnGroup(bool v)
		{
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0x20A99C0", Offset = "0x20A99C0", VA = "0x7BBC8A99C0")]
		protected void ShowBgEffect(bool v)
		{
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D10")]
		[Address(RVA = "0x20A9A08", Offset = "0x20A9A08", VA = "0x7BBC8A9A08")]
		private void OnCollectionTabChange(object[] data)
		{
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D11")]
		[Address(RVA = "0x20A9008", Offset = "0x20A9008", VA = "0x7BBC8A9008")]
		private void ShowPreviewPanel(bool v)
		{
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D12")]
		[Address(RVA = "0x20A9A10", Offset = "0x20A9A10", VA = "0x7BBC8A9A10")]
		public UICollectionMainBaseController()
		{
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D13")]
		[Address(RVA = "0x20A9AAC", Offset = "0x20A9AAC", VA = "0x7BBC8A9AAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F8D4", Offset = "0x113F8D4")]
		private UITable2.IUITable2Item <InitUITable2>b__18_0()
		{
			return null;
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D14")]
		[Address(RVA = "0x20A9BB0", Offset = "0x20A9BB0", VA = "0x7BBC8A9BB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F8E4", Offset = "0x113F8E4")]
		private UITable2.IUITable2Item <InitUITable2>b__18_1()
		{
			return null;
		}

		// Token: 0x06005D15 RID: 23829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D15")]
		[Address(RVA = "0x20A9CB4", Offset = "0x20A9CB4", VA = "0x7BBC8A9CB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F8F4", Offset = "0x113F8F4")]
		private UITable2.IUITable2Item <InitUITable2>b__18_2()
		{
			return null;
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D16")]
		[Address(RVA = "0x20A9DCC", Offset = "0x20A9DCC", VA = "0x7BBC8A9DCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F904", Offset = "0x113F904")]
		private void <InitUITable2>b__18_3(int e)
		{
		}

		// Token: 0x04007ED8 RID: 32472
		[Token(Token = "0x4007ED8")]
		[FieldOffset(Offset = "0x58")]
		private UIWeaponMainView m_View;

		// Token: 0x04007ED9 RID: 32473
		[Token(Token = "0x4007ED9")]
		[FieldOffset(Offset = "0x60")]
		protected UIModelCollection m_ModelCollection;

		// Token: 0x04007EDA RID: 32474
		[Token(Token = "0x4007EDA")]
		[FieldOffset(Offset = "0x68")]
		protected List<PopMenuData> m_PopMenuDataList;

		// Token: 0x04007EDB RID: 32475
		[Token(Token = "0x4007EDB")]
		[FieldOffset(Offset = "0x70")]
		protected uint m_SelectedItemID;

		// Token: 0x04007EDC RID: 32476
		[Token(Token = "0x4007EDC")]
		[FieldOffset(Offset = "0x78")]
		protected UIPopMenuBigController m_Pop;

		// Token: 0x04007EDD RID: 32477
		[Token(Token = "0x4007EDD")]
		[FieldOffset(Offset = "0x80")]
		public CSSharedItemDataManager.CollectionSubType CurCollectionSubType;

		// Token: 0x04007EDE RID: 32478
		[Token(Token = "0x4007EDE")]
		[FieldOffset(Offset = "0x88")]
		private WeaponSkinBaseInfo m_SelectedWeaponSkinData;

		// Token: 0x04007EDF RID: 32479
		[Token(Token = "0x4007EDF")]
		[FieldOffset(Offset = "0x90")]
		public bool isNoItem;

		// Token: 0x04007EE0 RID: 32480
		[Token(Token = "0x4007EE0")]
		private const int ECategoryItemType_Title = 0;

		// Token: 0x04007EE1 RID: 32481
		[Token(Token = "0x4007EE1")]
		private const int ECategoryItemType_SplitLine = 1;

		// Token: 0x04007EE2 RID: 32482
		[Token(Token = "0x4007EE2")]
		private const int ECategoryItemType_Item = 2;

		// Token: 0x04007EE3 RID: 32483
		[Token(Token = "0x4007EE3")]
		[FieldOffset(Offset = "0x98")]
		private UITable2.Item m_SelectedItem;
	}
}
