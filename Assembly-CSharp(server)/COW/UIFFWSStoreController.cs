using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001365 RID: 4965
	[Token(Token = "0x2001365")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB3E0", Offset = "0x10EB3E0")]
	public class UIFFWSStoreController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x06004F56 RID: 20310 RVA: 0x000182B8 File Offset: 0x000164B8
		[Token(Token = "0x6004F56")]
		[Address(RVA = "0x2284E94", Offset = "0x2284E94", VA = "0x7BBCA84E94")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F57 RID: 20311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F57")]
		[Address(RVA = "0x2284EE4", Offset = "0x2284EE4", VA = "0x7BBCA84EE4", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06004F58 RID: 20312 RVA: 0x000182D0 File Offset: 0x000164D0
		[Token(Token = "0x6004F58")]
		[Address(RVA = "0x22856AC", Offset = "0x22856AC", VA = "0x7BBCA856AC", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06004F59 RID: 20313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F59")]
		[Address(RVA = "0x2285710", Offset = "0x2285710", VA = "0x7BBCA85710", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06004F5A RID: 20314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5A")]
		[Address(RVA = "0x228581C", Offset = "0x228581C", VA = "0x7BBCA8581C", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06004F5B RID: 20315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5B")]
		[Address(RVA = "0x228584C", Offset = "0x228584C", VA = "0x7BBCA8584C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004F5C RID: 20316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5C")]
		[Address(RVA = "0x228605C", Offset = "0x228605C", VA = "0x7BBCA8605C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06004F5D RID: 20317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5D")]
		[Address(RVA = "0x2286130", Offset = "0x2286130", VA = "0x7BBCA86130", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06004F5E RID: 20318 RVA: 0x000182E8 File Offset: 0x000164E8
		[Token(Token = "0x6004F5E")]
		[Address(RVA = "0x2286280", Offset = "0x2286280", VA = "0x7BBCA86280", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F5F")]
		[Address(RVA = "0x2285E70", Offset = "0x2285E70", VA = "0x7BBCA85E70")]
		private void RefreshNetworkBg()
		{
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F60")]
		[Address(RVA = "0x2285550", Offset = "0x2285550", VA = "0x7BBCA85550")]
		private void RefreshTokenView()
		{
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F61")]
		[Address(RVA = "0x2286288", Offset = "0x2286288", VA = "0x7BBCA86288")]
		private void OnTabClick()
		{
		}

		// Token: 0x06004F62 RID: 20322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F62")]
		[Address(RVA = "0x2285410", Offset = "0x2285410", VA = "0x7BBCA85410")]
		private void RefreshAwakenStatus()
		{
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F63")]
		[Address(RVA = "0x22868C4", Offset = "0x22868C4", VA = "0x7BBCA868C4")]
		private void InitTab(UIFFWSStoreController.TabItem item, LimitedEventStore storeDesc)
		{
		}

		// Token: 0x06004F64 RID: 20324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F64")]
		[Address(RVA = "0x2285C60", Offset = "0x2285C60", VA = "0x7BBCA85C60")]
		private void CreateTabs()
		{
		}

		// Token: 0x06004F65 RID: 20325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F65")]
		[Address(RVA = "0x2285224", Offset = "0x2285224", VA = "0x7BBCA85224")]
		private void RefreshTabs()
		{
		}

		// Token: 0x06004F66 RID: 20326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F66")]
		[Address(RVA = "0x2286AF0", Offset = "0x2286AF0", VA = "0x7BBCA86AF0")]
		private void SelectTab()
		{
		}

		// Token: 0x06004F67 RID: 20327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F67")]
		[Address(RVA = "0x2285310", Offset = "0x2285310", VA = "0x7BBCA85310")]
		private void RefreshEasyList(List<BigEventStoreCommodityDesc> dataList, bool sort = true)
		{
		}

		// Token: 0x06004F68 RID: 20328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F68")]
		[Address(RVA = "0x2286BB4", Offset = "0x2286BB4", VA = "0x7BBCA86BB4")]
		private void OnRedTipsOnOffClick()
		{
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x2286D64", Offset = "0x2286D64", VA = "0x7BBCA86D64")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x06004F6A RID: 20330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6A")]
		[Address(RVA = "0x2286F20", Offset = "0x2286F20", VA = "0x7BBCA86F20")]
		private void CloseNaviPop()
		{
		}

		// Token: 0x06004F6B RID: 20331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6B")]
		[Address(RVA = "0x2286FBC", Offset = "0x2286FBC", VA = "0x7BBCA86FBC")]
		private void OnTokenBtnClick()
		{
		}

		// Token: 0x06004F6C RID: 20332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6C")]
		[Address(RVA = "0x22871FC", Offset = "0x22871FC", VA = "0x7BBCA871FC")]
		private void OnAwakenEntranceBtnClick()
		{
		}

		// Token: 0x06004F6D RID: 20333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6D")]
		[Address(RVA = "0x2287340", Offset = "0x2287340", VA = "0x7BBCA87340")]
		private void OnAwakenEntranceBannedBtnClick()
		{
		}

		// Token: 0x06004F6E RID: 20334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F6E")]
		[Address(RVA = "0x22874BC", Offset = "0x22874BC", VA = "0x7BBCA874BC")]
		public UIFFWSStoreController()
		{
		}

		// Token: 0x04007624 RID: 30244
		[Token(Token = "0x4007624")]
		private const uint AVATARID = 102000005U;

		// Token: 0x04007625 RID: 30245
		[Token(Token = "0x4007625")]
		[FieldOffset(Offset = "0xB0")]
		private UIFFWSStoreView m_View;

		// Token: 0x04007626 RID: 30246
		[Token(Token = "0x4007626")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelFFWS m_ModelFFWS;

		// Token: 0x04007627 RID: 30247
		[Token(Token = "0x4007627")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007628 RID: 30248
		[Token(Token = "0x4007628")]
		[FieldOffset(Offset = "0xC8")]
		private UIFFWSStoreController.TabItem m_Tab1;

		// Token: 0x04007629 RID: 30249
		[Token(Token = "0x4007629")]
		[FieldOffset(Offset = "0xD0")]
		private UIFFWSStoreController.TabItem m_Tab2;

		// Token: 0x0400762A RID: 30250
		[Token(Token = "0x400762A")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_CurrentTab;

		// Token: 0x0400762B RID: 30251
		[Token(Token = "0x400762B")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_IsAwaken;

		// Token: 0x02001366 RID: 4966
		[Token(Token = "0x2001366")]
		public class TabItem : UIInnerView
		{
			// Token: 0x06004F6F RID: 20335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F6F")]
			[Address(RVA = "0x22869B0", Offset = "0x22869B0", VA = "0x7BBCA869B0")]
			public void BindVars1(GameObject ui)
			{
			}

			// Token: 0x06004F70 RID: 20336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F70")]
			[Address(RVA = "0x2286A50", Offset = "0x2286A50", VA = "0x7BBCA86A50")]
			public void BindVars2(GameObject ui)
			{
			}

			// Token: 0x06004F71 RID: 20337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F71")]
			[Address(RVA = "0x2287544", Offset = "0x2287544", VA = "0x7BBCA87544")]
			public TabItem()
			{
			}

			// Token: 0x0400762C RID: 30252
			[Token(Token = "0x400762C")]
			[FieldOffset(Offset = "0x28")]
			public UIToggleButton ToggleBtn;

			// Token: 0x0400762D RID: 30253
			[Token(Token = "0x400762D")]
			[FieldOffset(Offset = "0x30")]
			public Animation AnimationScale;

			// Token: 0x0400762E RID: 30254
			[Token(Token = "0x400762E")]
			[FieldOffset(Offset = "0x38")]
			public bool Selected;

			// Token: 0x0400762F RID: 30255
			[Token(Token = "0x400762F")]
			[FieldOffset(Offset = "0x3C")]
			public uint storeID;
		}

		// Token: 0x02001367 RID: 4967
		[Token(Token = "0x2001367")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB418", Offset = "0x10EB418")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004F72 RID: 20338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F72")]
			[Address(RVA = "0x2285548", Offset = "0x2285548", VA = "0x7BBCA85548")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06004F73 RID: 20339 RVA: 0x00018300 File Offset: 0x00016500
			[Token(Token = "0x6004F73")]
			[Address(RVA = "0x22875C0", Offset = "0x22875C0", VA = "0x7BBCA875C0")]
			internal bool <OnDataChanged>b__0(BigEventStoreCommodityDesc data)
			{
				return default(bool);
			}

			// Token: 0x04007630 RID: 30256
			[Token(Token = "0x4007630")]
			[FieldOffset(Offset = "0x10")]
			public uint skuID;
		}

		// Token: 0x02001368 RID: 4968
		[Token(Token = "0x2001368")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB428", Offset = "0x10EB428")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004F75 RID: 20341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F75")]
			[Address(RVA = "0x22875B0", Offset = "0x22875B0", VA = "0x7BBCA875B0")]
			public <>c()
			{
			}

			// Token: 0x06004F76 RID: 20342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F76")]
			[Address(RVA = "0x22875B8", Offset = "0x22875B8", VA = "0x7BBCA875B8")]
			internal void <CreateTabs>b__23_0(UIToggleButton e)
			{
			}

			// Token: 0x06004F77 RID: 20343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004F77")]
			[Address(RVA = "0x22875BC", Offset = "0x22875BC", VA = "0x7BBCA875BC")]
			internal void <CreateTabs>b__23_1(UIToggleButton e)
			{
			}

			// Token: 0x04007631 RID: 30257
			[Token(Token = "0x4007631")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIFFWSStoreController.<>c <>9;

			// Token: 0x04007632 RID: 30258
			[Token(Token = "0x4007632")]
			[FieldOffset(Offset = "0x8")]
			public static UIToggleButtonGroup.OnItemSelect <>9__23_0;

			// Token: 0x04007633 RID: 30259
			[Token(Token = "0x4007633")]
			[FieldOffset(Offset = "0x10")]
			public static UIToggleButtonGroup.OnItemSelect <>9__23_1;
		}
	}
}
