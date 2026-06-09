using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200155C RID: 5468
	[Token(Token = "0x200155C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE62C", Offset = "0x10EE62C")]
	public class UIBoxMallDetailController : UIMallDetailBaseController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06005EA8 RID: 24232 RVA: 0x0001B660 File Offset: 0x00019860
		[Token(Token = "0x6005EA8")]
		[Address(RVA = "0x1433928", Offset = "0x1433928", VA = "0x7BBBC33928")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0x1433978", Offset = "0x1433978", VA = "0x7BBBC33978", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0x1433D24", Offset = "0x1433D24", VA = "0x7BBBC33D24", Slot = "28")]
		protected override void InitBuyBtnStyle()
		{
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0x14340E4", Offset = "0x14340E4", VA = "0x7BBBC340E4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0x1434198", Offset = "0x1434198", VA = "0x7BBBC34198")]
		private void OnBuyBtnClick()
		{
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0x1434528", Offset = "0x1434528", VA = "0x7BBBC34528")]
		private void RefreshViewData(List<StoreDesc> dataList, bool needResort = true)
		{
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0x143461C", Offset = "0x143461C", VA = "0x7BBBC3461C", Slot = "57")]
		public override void InitMallView()
		{
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x143474C", Offset = "0x143474C", VA = "0x7BBBC3474C", Slot = "58")]
		public override void RefreshMallView()
		{
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0x1434644", Offset = "0x1434644", VA = "0x7BBBC34644")]
		private void UpdateTabs()
		{
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x0001B678 File Offset: 0x00019878
		[Token(Token = "0x6005EB1")]
		[Address(RVA = "0x1434774", Offset = "0x1434774", VA = "0x7BBBC34774", Slot = "32")]
		protected override bool CanFindStoreItem(uint storeID)
		{
			return default(bool);
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EB2")]
		[Address(RVA = "0x14347B8", Offset = "0x14347B8", VA = "0x7BBBC347B8", Slot = "67")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x143484C", Offset = "0x143484C", VA = "0x7BBBC3484C", Slot = "33")]
		public override void HighlightCurrent()
		{
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB4")]
		[Address(RVA = "0x1434984", Offset = "0x1434984", VA = "0x7BBBC34984", Slot = "68")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x14349B4", Offset = "0x14349B4", VA = "0x7BBBC349B4", Slot = "60")]
		public override void NavigationToItem(uint mallTabType, uint mallSubType, uint storeID)
		{
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x1434F1C", Offset = "0x1434F1C", VA = "0x7BBBC34F1C")]
		private void OnBoxToggleSelected()
		{
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x14351F0", Offset = "0x14351F0", VA = "0x7BBBC351F0", Slot = "36")]
		protected override void AddMallToggleClickEvent()
		{
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x14353BC", Offset = "0x14353BC", VA = "0x7BBBC353BC", Slot = "54")]
		protected override string GetMallTabName(uint type)
		{
			return null;
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x14353F8", Offset = "0x14353F8", VA = "0x7BBBC353F8", Slot = "53")]
		protected override void ResetUIStateOnToggleSelected()
		{
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x0001B690 File Offset: 0x00019890
		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0x1435460", Offset = "0x1435460", VA = "0x7BBBC35460", Slot = "70")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0x14354A4", Offset = "0x14354A4", VA = "0x7BBBC354A4", Slot = "69")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBC")]
		[Address(RVA = "0x1435538", Offset = "0x1435538", VA = "0x7BBBC35538", Slot = "55")]
		public override void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0x1435614", Offset = "0x1435614", VA = "0x7BBBC35614")]
		private void RefreshItemView(uint storeID)
		{
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0x14360E0", Offset = "0x14360E0", VA = "0x7BBBC360E0", Slot = "50")]
		public override void HideItemEffect()
		{
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBF")]
		[Address(RVA = "0x1435C68", Offset = "0x1435C68", VA = "0x7BBBC35C68")]
		private void RefreshBtnGoExchangeState()
		{
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC0")]
		[Address(RVA = "0x1436214", Offset = "0x1436214", VA = "0x7BBBC36214")]
		private void OnGoToDiscountBtnClick()
		{
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0x1436258", Offset = "0x1436258", VA = "0x7BBBC36258", Slot = "65")]
		protected override void OnCommonWndFinish(params object[] data)
		{
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0x14363F4", Offset = "0x14363F4", VA = "0x7BBBC363F4", Slot = "61")]
		public override void RefreshCurrentMallView(bool clickItem)
		{
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0x14362DC", Offset = "0x14362DC", VA = "0x7BBBC362DC")]
		private void ShowOfferPurchase()
		{
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0x1436440", Offset = "0x1436440", VA = "0x7BBBC36440")]
		public void OnBtnGoExchangeClick()
		{
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0x1436734", Offset = "0x1436734", VA = "0x7BBBC36734")]
		public UIBoxMallDetailController()
		{
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x0001B6A8 File Offset: 0x000198A8
		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0x14367C4", Offset = "0x14367C4", VA = "0x7BBBC367C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FBF0", Offset = "0x113FBF0")]
		private bool <HighlightCurrent>b__14_0(StoreDesc item)
		{
			return default(bool);
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x0001B6C0 File Offset: 0x000198C0
		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x1436800", Offset = "0x1436800", VA = "0x7BBBC36800")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113FC00", Offset = "0x113FC00")]
		private bool <HighlightCurrent>b__14_1(StoreDesc item)
		{
			return default(bool);
		}

		// Token: 0x04007FCD RID: 32717
		[Token(Token = "0x4007FCD")]
		[FieldOffset(Offset = "0x148")]
		private UICommonGuideController m_GoExchangeGuide;

		// Token: 0x04007FCE RID: 32718
		[Token(Token = "0x4007FCE")]
		[FieldOffset(Offset = "0x150")]
		private bool m_PurchaseSuccess;

		// Token: 0x04007FCF RID: 32719
		[Token(Token = "0x4007FCF")]
		[FieldOffset(Offset = "0x158")]
		private List<StoreDesc> m_CurrentDataList;

		// Token: 0x0200155D RID: 5469
		[Token(Token = "0x200155D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EE664", Offset = "0x10EE664")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06005EC8 RID: 24264 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005EC8")]
			[Address(RVA = "0x1434F14", Offset = "0x1434F14", VA = "0x7BBBC34F14")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06005EC9 RID: 24265 RVA: 0x0001B6D8 File Offset: 0x000198D8
			[Token(Token = "0x6005EC9")]
			[Address(RVA = "0x143683C", Offset = "0x143683C", VA = "0x7BBBC3683C")]
			internal bool <NavigationToItem>b__0(SubTabInfo temp)
			{
				return default(bool);
			}

			// Token: 0x06005ECA RID: 24266 RVA: 0x0001B6F0 File Offset: 0x000198F0
			[Token(Token = "0x6005ECA")]
			[Address(RVA = "0x1436878", Offset = "0x1436878", VA = "0x7BBBC36878")]
			internal bool <NavigationToItem>b__1(StoreDesc item)
			{
				return default(bool);
			}

			// Token: 0x06005ECB RID: 24267 RVA: 0x0001B708 File Offset: 0x00019908
			[Token(Token = "0x6005ECB")]
			[Address(RVA = "0x14368B4", Offset = "0x14368B4", VA = "0x7BBBC368B4")]
			internal bool <NavigationToItem>b__2(StoreDesc item)
			{
				return default(bool);
			}

			// Token: 0x04007FD0 RID: 32720
			[Token(Token = "0x4007FD0")]
			[FieldOffset(Offset = "0x10")]
			public uint mallSubType;

			// Token: 0x04007FD1 RID: 32721
			[Token(Token = "0x4007FD1")]
			[FieldOffset(Offset = "0x14")]
			public uint storeID;
		}
	}
}
