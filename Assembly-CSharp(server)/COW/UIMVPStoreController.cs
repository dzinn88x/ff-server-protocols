using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013A7 RID: 5031
	[Token(Token = "0x20013A7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBA18", Offset = "0x10EBA18")]
	public class UIMVPStoreController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060051BB RID: 20923 RVA: 0x00018A20 File Offset: 0x00016C20
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x1CD9314", Offset = "0x1CD9314", VA = "0x7BBC4D9314")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x00018A38 File Offset: 0x00016C38
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x1CD9364", Offset = "0x1CD9364", VA = "0x7BBC4D9364", Slot = "35")]
		public override EFrontendBGMType GetBGMType()
		{
			return EFrontendBGMType.NONE;
		}

		// Token: 0x060051BD RID: 20925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x1CD936C", Offset = "0x1CD936C", VA = "0x7BBC4D936C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x1CD96AC", Offset = "0x1CD96AC", VA = "0x7BBC4D96AC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E170", Offset = "0x113E170")]
		private IEnumerator WaitStoreHttpReq(HttpRequest req)
		{
			return null;
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x1CD9770", Offset = "0x1CD9770", VA = "0x7BBC4D9770", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x1CD97D8", Offset = "0x1CD97D8", VA = "0x7BBC4D97D8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060051C1 RID: 20929 RVA: 0x00018A50 File Offset: 0x00016C50
		[Token(Token = "0x60051C1")]
		[Address(RVA = "0x1CD9818", Offset = "0x1CD9818", VA = "0x7BBC4D9818", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x060051C2 RID: 20930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C2")]
		[Address(RVA = "0x1CD9820", Offset = "0x1CD9820", VA = "0x7BBC4D9820")]
		private void RefreshView()
		{
		}

		// Token: 0x060051C3 RID: 20931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C3")]
		[Address(RVA = "0x1CD9F24", Offset = "0x1CD9F24", VA = "0x7BBC4D9F24")]
		private void OnTimeBtnClick()
		{
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C4")]
		[Address(RVA = "0x1CD9F28", Offset = "0x1CD9F28", VA = "0x7BBC4D9F28")]
		private void OnTokenBtnClick()
		{
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C5")]
		[Address(RVA = "0x1CD9C7C", Offset = "0x1CD9C7C", VA = "0x7BBC4D9C7C")]
		private void RefreshCountDownTime()
		{
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x1CD9E24", Offset = "0x1CD9E24", VA = "0x7BBC4D9E24")]
		private void RefreshBG()
		{
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x1CD9A5C", Offset = "0x1CD9A5C", VA = "0x7BBC4D9A5C")]
		private void RefreshToken()
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x1CDA194", Offset = "0x1CDA194", VA = "0x7BBC4DA194")]
		private void InitTab(UIMVPStoreController.TabItem item, LimitedEventStore storeDesc)
		{
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x1CDA280", Offset = "0x1CDA280", VA = "0x7BBC4DA280")]
		private void CreateTabs()
		{
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x1CDA678", Offset = "0x1CDA678", VA = "0x7BBC4DA678")]
		private void SelectTab()
		{
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x1CDA73C", Offset = "0x1CDA73C", VA = "0x7BBC4DA73C")]
		private void OnTabClick()
		{
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x1CDACD4", Offset = "0x1CDACD4", VA = "0x7BBC4DACD4")]
		private void RefreshEasyList(List<BigEventStoreCommodityDesc> dataList, bool sort = true)
		{
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CD")]
		[Address(RVA = "0x1CDADD4", Offset = "0x1CDADD4", VA = "0x7BBC4DADD4", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x00018A68 File Offset: 0x00016C68
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x1CDB0F0", Offset = "0x1CDB0F0", VA = "0x7BBC4DB0F0", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x1CDB154", Offset = "0x1CDB154", VA = "0x7BBC4DB154", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060051D0 RID: 20944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D0")]
		[Address(RVA = "0x1CDB2E4", Offset = "0x1CDB2E4", VA = "0x7BBC4DB2E4", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060051D1 RID: 20945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D1")]
		[Address(RVA = "0x1CDB314", Offset = "0x1CDB314", VA = "0x7BBC4DB314")]
		private void OnRedTipsOnOffClick()
		{
		}

		// Token: 0x060051D2 RID: 20946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D2")]
		[Address(RVA = "0x1CDB4C4", Offset = "0x1CDB4C4", VA = "0x7BBC4DB4C4")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x060051D3 RID: 20947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D3")]
		[Address(RVA = "0x1CDB660", Offset = "0x1CDB660", VA = "0x7BBC4DB660")]
		private void CloseNaviPop()
		{
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051D4")]
		[Address(RVA = "0x1CDB6FC", Offset = "0x1CDB6FC", VA = "0x7BBC4DB6FC")]
		public UIMVPStoreController()
		{
		}

		// Token: 0x040077FF RID: 30719
		[Token(Token = "0x40077FF")]
		[FieldOffset(Offset = "0xAC")]
		private float TabOffset;

		// Token: 0x04007800 RID: 30720
		[Token(Token = "0x4007800")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsDark;

		// Token: 0x04007801 RID: 30721
		[Token(Token = "0x4007801")]
		[FieldOffset(Offset = "0xB8")]
		private UIMVPStoreView m_View;

		// Token: 0x04007802 RID: 30722
		[Token(Token = "0x4007802")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelMVP m_ModelMVP;

		// Token: 0x04007803 RID: 30723
		[Token(Token = "0x4007803")]
		[FieldOffset(Offset = "0xC8")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04007804 RID: 30724
		[Token(Token = "0x4007804")]
		[FieldOffset(Offset = "0xD0")]
		private UIMVPStoreController.TabItem m_Tab1;

		// Token: 0x04007805 RID: 30725
		[Token(Token = "0x4007805")]
		[FieldOffset(Offset = "0xD8")]
		private UIMVPStoreController.TabItem m_Tab2;

		// Token: 0x04007806 RID: 30726
		[Token(Token = "0x4007806")]
		[FieldOffset(Offset = "0xE0")]
		private uint m_CurrentTab;

		// Token: 0x04007807 RID: 30727
		[Token(Token = "0x4007807")]
		[FieldOffset(Offset = "0xE8")]
		private IEnumerator m_WaitStoreHttpReq;

		// Token: 0x020013A8 RID: 5032
		[Token(Token = "0x20013A8")]
		public class TabItem : UIInnerView
		{
			// Token: 0x060051D5 RID: 20949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D5")]
			[Address(RVA = "0x1CDA538", Offset = "0x1CDA538", VA = "0x7BBC4DA538")]
			public void BindVars1(GameObject ui)
			{
			}

			// Token: 0x060051D6 RID: 20950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D6")]
			[Address(RVA = "0x1CDA5D8", Offset = "0x1CDA5D8", VA = "0x7BBC4DA5D8")]
			public void BindVars2(GameObject ui)
			{
			}

			// Token: 0x060051D7 RID: 20951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D7")]
			[Address(RVA = "0x1CDB790", Offset = "0x1CDB790", VA = "0x7BBC4DB790")]
			public TabItem()
			{
			}

			// Token: 0x04007808 RID: 30728
			[Token(Token = "0x4007808")]
			[FieldOffset(Offset = "0x28")]
			public UIToggleButton ToggleBtn;

			// Token: 0x04007809 RID: 30729
			[Token(Token = "0x4007809")]
			[FieldOffset(Offset = "0x30")]
			public Animation AnimationScale;

			// Token: 0x0400780A RID: 30730
			[Token(Token = "0x400780A")]
			[FieldOffset(Offset = "0x38")]
			public bool Selected;

			// Token: 0x0400780B RID: 30731
			[Token(Token = "0x400780B")]
			[FieldOffset(Offset = "0x3C")]
			public uint storeID;
		}

		// Token: 0x020013A9 RID: 5033
		[Token(Token = "0x20013A9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBA50", Offset = "0x10EBA50")]
		private sealed class <WaitStoreHttpReq>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060051D8 RID: 20952 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D8")]
			[Address(RVA = "0x1CD9744", Offset = "0x1CD9744", VA = "0x7BBC4D9744")]
			[DebuggerHidden]
			public <WaitStoreHttpReq>d__13(int <>1__state)
			{
			}

			// Token: 0x060051D9 RID: 20953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051D9")]
			[Address(RVA = "0x1CDB848", Offset = "0x1CDB848", VA = "0x7BBC4DB848", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060051DA RID: 20954 RVA: 0x00018A80 File Offset: 0x00016C80
			[Token(Token = "0x60051DA")]
			[Address(RVA = "0x1CDB84C", Offset = "0x1CDB84C", VA = "0x7BBC4DB84C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x060051DB RID: 20955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086C")]
			private object Current
			{
				[Token(Token = "0x60051DB")]
				[Address(RVA = "0x1CDB934", Offset = "0x1CDB934", VA = "0x7BBC4DB934", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060051DC RID: 20956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051DC")]
			[Address(RVA = "0x1CDB93C", Offset = "0x1CDB93C", VA = "0x7BBC4DB93C", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x060051DD RID: 20957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700086D")]
			private object Current
			{
				[Token(Token = "0x60051DD")]
				[Address(RVA = "0x1CDB9A4", Offset = "0x1CDB9A4", VA = "0x7BBC4DB9A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400780C RID: 30732
			[Token(Token = "0x400780C")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400780D RID: 30733
			[Token(Token = "0x400780D")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400780E RID: 30734
			[Token(Token = "0x400780E")]
			[FieldOffset(Offset = "0x20")]
			public HttpRequest req;

			// Token: 0x0400780F RID: 30735
			[Token(Token = "0x400780F")]
			[FieldOffset(Offset = "0x28")]
			public UIMVPStoreController <>4__this;
		}

		// Token: 0x020013AA RID: 5034
		[Token(Token = "0x20013AA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBA60", Offset = "0x10EBA60")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060051DF RID: 20959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051DF")]
			[Address(RVA = "0x1CDB7FC", Offset = "0x1CDB7FC", VA = "0x7BBC4DB7FC")]
			public <>c()
			{
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051E0")]
			[Address(RVA = "0x1CDB804", Offset = "0x1CDB804", VA = "0x7BBC4DB804")]
			internal void <CreateTabs>b__24_0(UIToggleButton e)
			{
			}

			// Token: 0x060051E1 RID: 20961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051E1")]
			[Address(RVA = "0x1CDB808", Offset = "0x1CDB808", VA = "0x7BBC4DB808")]
			internal void <CreateTabs>b__24_1(UIToggleButton e)
			{
			}

			// Token: 0x04007810 RID: 30736
			[Token(Token = "0x4007810")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMVPStoreController.<>c <>9;

			// Token: 0x04007811 RID: 30737
			[Token(Token = "0x4007811")]
			[FieldOffset(Offset = "0x8")]
			public static UIToggleButtonGroup.OnItemSelect <>9__24_0;

			// Token: 0x04007812 RID: 30738
			[Token(Token = "0x4007812")]
			[FieldOffset(Offset = "0x10")]
			public static UIToggleButtonGroup.OnItemSelect <>9__24_1;
		}

		// Token: 0x020013AB RID: 5035
		[Token(Token = "0x20013AB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBA70", Offset = "0x10EBA70")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x060051E2 RID: 20962 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60051E2")]
			[Address(RVA = "0x1CDB0E8", Offset = "0x1CDB0E8", VA = "0x7BBC4DB0E8")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x060051E3 RID: 20963 RVA: 0x00018A98 File Offset: 0x00016C98
			[Token(Token = "0x60051E3")]
			[Address(RVA = "0x1CDB80C", Offset = "0x1CDB80C", VA = "0x7BBC4DB80C")]
			internal bool <OnDataChanged>b__0(BigEventStoreCommodityDesc data)
			{
				return default(bool);
			}

			// Token: 0x04007813 RID: 30739
			[Token(Token = "0x4007813")]
			[FieldOffset(Offset = "0x10")]
			public uint skuID;
		}
	}
}
