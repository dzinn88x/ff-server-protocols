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
	// Token: 0x020019AE RID: 6574
	[Token(Token = "0x20019AE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6D8C", Offset = "0x10F6D8C")]
	public class UIIAPBundleController : UIPopupWindowController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x060086AD RID: 34477 RVA: 0x00024708 File Offset: 0x00022908
		[Token(Token = "0x60086AD")]
		[Address(RVA = "0x1D23DE4", Offset = "0x1D23DE4", VA = "0x7BBC523DE4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086AE RID: 34478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086AE")]
		[Address(RVA = "0x1D23E34", Offset = "0x1D23E34", VA = "0x7BBC523E34", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086AF RID: 34479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086AF")]
		[Address(RVA = "0x1D2454C", Offset = "0x1D2454C", VA = "0x7BBC52454C", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060086B0 RID: 34480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B0")]
		[Address(RVA = "0x1D24614", Offset = "0x1D24614", VA = "0x7BBC524614", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060086B1 RID: 34481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B1")]
		[Address(RVA = "0x1D249C0", Offset = "0x1D249C0", VA = "0x7BBC5249C0")]
		private void OnClickHint()
		{
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B2")]
		[Address(RVA = "0x1D24B48", Offset = "0x1D24B48", VA = "0x7BBC524B48")]
		public void SetData(IAPBundleStoreData data)
		{
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B3")]
		[Address(RVA = "0x1D24BA4", Offset = "0x1D24BA4", VA = "0x7BBC524BA4")]
		private void ShowFirstItem()
		{
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B4")]
		[Address(RVA = "0x1D24B7C", Offset = "0x1D24B7C", VA = "0x7BBC524B7C")]
		private void ShowInternal()
		{
		}

		// Token: 0x060086B5 RID: 34485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B5")]
		[Address(RVA = "0x1D2490C", Offset = "0x1D2490C", VA = "0x7BBC52490C")]
		private void HideInternal()
		{
		}

		// Token: 0x060086B6 RID: 34486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B6")]
		[Address(RVA = "0x1D268F4", Offset = "0x1D268F4", VA = "0x7BBC5268F4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060086B7 RID: 34487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B7")]
		[Address(RVA = "0x1D26948", Offset = "0x1D26948", VA = "0x7BBC526948")]
		private void OnBundleImageClick()
		{
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B8")]
		[Address(RVA = "0x1D239C4", Offset = "0x1D239C4", VA = "0x7BBC5239C4")]
		public void SetItemID(uint id)
		{
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086B9")]
		[Address(RVA = "0x1D26B34", Offset = "0x1D26B34", VA = "0x7BBC526B34")]
		public void OnPurchaseButtonClick()
		{
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086BA")]
		[Address(RVA = "0x1D26CB0", Offset = "0x1D26CB0", VA = "0x7BBC526CB0")]
		public void OnDiamondPurchaseButtonClick()
		{
		}

		// Token: 0x060086BB RID: 34491 RVA: 0x00024720 File Offset: 0x00022920
		[Token(Token = "0x60086BB")]
		[Address(RVA = "0x1D26F7C", Offset = "0x1D26F7C", VA = "0x7BBC526F7C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060086BC RID: 34492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086BC")]
		[Address(RVA = "0x1D26FC0", Offset = "0x1D26FC0", VA = "0x7BBC526FC0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060086BD RID: 34493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086BD")]
		[Address(RVA = "0x1D27200", Offset = "0x1D27200", VA = "0x7BBC527200")]
		private void UpdateItemControllers(List<BundleShowData> bundleShowDataList)
		{
		}

		// Token: 0x060086BE RID: 34494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086BE")]
		[Address(RVA = "0x1D28200", Offset = "0x1D28200", VA = "0x7BBC528200")]
		private void ToggleUI(bool show)
		{
		}

		// Token: 0x060086BF RID: 34495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086BF")]
		[Address(RVA = "0x1D24294", Offset = "0x1D24294", VA = "0x7BBC524294")]
		private void ShowNameContent()
		{
		}

		// Token: 0x060086C0 RID: 34496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C0")]
		[Address(RVA = "0x1D283BC", Offset = "0x1D283BC", VA = "0x7BBC5283BC")]
		private void OnSuccessfullyDownloadTitleCDN()
		{
		}

		// Token: 0x060086C1 RID: 34497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C1")]
		[Address(RVA = "0x1D24C60", Offset = "0x1D24C60", VA = "0x7BBC524C60")]
		private void UpdateData()
		{
		}

		// Token: 0x060086C2 RID: 34498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60086C2")]
		[Address(RVA = "0x1D28590", Offset = "0x1D28590", VA = "0x7BBC528590", Slot = "42")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060086C3 RID: 34499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C3")]
		[Address(RVA = "0x1D2865C", Offset = "0x1D2865C", VA = "0x7BBC52865C", Slot = "43")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060086C4 RID: 34500 RVA: 0x00024738 File Offset: 0x00022938
		[Token(Token = "0x60086C4")]
		[Address(RVA = "0x1D28464", Offset = "0x1D28464", VA = "0x7BBC528464")]
		private bool ShowDiamondPurchaseBtn()
		{
			return default(bool);
		}

		// Token: 0x060086C5 RID: 34501 RVA: 0x00024750 File Offset: 0x00022950
		[Token(Token = "0x60086C5")]
		[Address(RVA = "0x1D284C4", Offset = "0x1D284C4", VA = "0x7BBC5284C4")]
		private bool ShowPurchaseBtn()
		{
			return default(bool);
		}

		// Token: 0x060086C6 RID: 34502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C6")]
		[Address(RVA = "0x1D2635C", Offset = "0x1D2635C", VA = "0x7BBC52635C")]
		private void _EnterPreview()
		{
		}

		// Token: 0x060086C7 RID: 34503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C7")]
		[Address(RVA = "0x1D26848", Offset = "0x1D26848", VA = "0x7BBC526848")]
		private void _ExitPreview()
		{
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086C8")]
		[Address(RVA = "0x1D2868C", Offset = "0x1D2868C", VA = "0x7BBC52868C", Slot = "39")]
		public override void OnPopupWindowListChange()
		{
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60086C9")]
		[Address(RVA = "0x1D2818C", Offset = "0x1D2818C", VA = "0x7BBC52818C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143488", Offset = "0x1143488")]
		private IEnumerator ShowItemControlers()
		{
			return null;
		}

		// Token: 0x060086CA RID: 34506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086CA")]
		[Address(RVA = "0x1D28A98", Offset = "0x1D28A98", VA = "0x7BBC528A98")]
		public UIIAPBundleController()
		{
		}

		// Token: 0x060086CB RID: 34507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086CB")]
		[Address(RVA = "0x1D28B08", Offset = "0x1D28B08", VA = "0x7BBC528B08")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11434EC", Offset = "0x11434EC")]
		private void <OnDiamondPurchaseButtonClick>b__27_0()
		{
		}

		// Token: 0x060086CC RID: 34508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086CC")]
		[Address(RVA = "0x1D28B3C", Offset = "0x1D28B3C", VA = "0x7BBC528B3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11434FC", Offset = "0x11434FC")]
		private void <UpdateData>b__35_1()
		{
		}

		// Token: 0x040095A2 RID: 38306
		[Token(Token = "0x40095A2")]
		private const string IAPBUNDLEFIRSTSHOW = "IapBundleFirstShow_{0}_{1}";

		// Token: 0x040095A3 RID: 38307
		[Token(Token = "0x40095A3")]
		[FieldOffset(Offset = "0x98")]
		private UIIAPBundleView m_View;

		// Token: 0x040095A4 RID: 38308
		[Token(Token = "0x40095A4")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelIAPBundle m_Model;

		// Token: 0x040095A5 RID: 38309
		[Token(Token = "0x40095A5")]
		[FieldOffset(Offset = "0xA8")]
		private IAPBundleStoreData m_Data;

		// Token: 0x040095A6 RID: 38310
		[Token(Token = "0x40095A6")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_IsCloseState;

		// Token: 0x040095A7 RID: 38311
		[Token(Token = "0x40095A7")]
		[FieldOffset(Offset = "0xB1")]
		private bool m_IsFirstShow;

		// Token: 0x040095A8 RID: 38312
		[Token(Token = "0x40095A8")]
		[FieldOffset(Offset = "0xB2")]
		private bool m_HasPlayedAnimation;

		// Token: 0x040095A9 RID: 38313
		[Token(Token = "0x40095A9")]
		private const int MAX_ITEM = 5;

		// Token: 0x040095AA RID: 38314
		[Token(Token = "0x40095AA")]
		[FieldOffset(Offset = "0xB8")]
		private Transform[] m_ItemRoots;

		// Token: 0x040095AB RID: 38315
		[Token(Token = "0x40095AB")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_ItemID;

		// Token: 0x040095AC RID: 38316
		[Token(Token = "0x40095AC")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_PreviewCameraCovered;

		// Token: 0x040095AD RID: 38317
		[Token(Token = "0x40095AD")]
		[FieldOffset(Offset = "0xC8")]
		private PreViewManager.Cameratype m_PreViewCameraType;

		// Token: 0x040095AE RID: 38318
		[Token(Token = "0x40095AE")]
		[FieldOffset(Offset = "0xD0")]
		private ShowBoostAvatarParams showBoostAvatarParams;

		// Token: 0x040095AF RID: 38319
		[Token(Token = "0x40095AF")]
		[FieldOffset(Offset = "0xD8")]
		private bool isItemABReady;

		// Token: 0x040095B0 RID: 38320
		[Token(Token = "0x40095B0")]
		[FieldOffset(Offset = "0xE0")]
		private List<UIIAPBundleContentItemController> m_GridItemControllers;

		// Token: 0x020019AF RID: 6575
		[Token(Token = "0x20019AF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6DC4", Offset = "0x10F6DC4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060086CE RID: 34510 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086CE")]
			[Address(RVA = "0x1D28C4C", Offset = "0x1D28C4C", VA = "0x7BBC528C4C")]
			public <>c()
			{
			}

			// Token: 0x060086CF RID: 34511 RVA: 0x00024768 File Offset: 0x00022968
			[Token(Token = "0x60086CF")]
			[Address(RVA = "0x1D28C54", Offset = "0x1D28C54", VA = "0x7BBC528C54")]
			internal bool <ShowNameContent>b__33_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x060086D0 RID: 34512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60086D0")]
			[Address(RVA = "0x1D28C88", Offset = "0x1D28C88", VA = "0x7BBC528C88")]
			internal string <UpdateData>b__35_0(KeyValuePair<uint, List<BundleShowData>> p)
			{
				return null;
			}

			// Token: 0x040095B1 RID: 38321
			[Token(Token = "0x40095B1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIIAPBundleController.<>c <>9;

			// Token: 0x040095B2 RID: 38322
			[Token(Token = "0x40095B2")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AdvertDesc> <>9__33_0;

			// Token: 0x040095B3 RID: 38323
			[Token(Token = "0x40095B3")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<KeyValuePair<uint, List<BundleShowData>>, string> <>9__35_0;
		}

		// Token: 0x020019B0 RID: 6576
		[Token(Token = "0x20019B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6DD4", Offset = "0x10F6DD4")]
		private sealed class <ShowItemControlers>d__43 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060086D1 RID: 34513 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086D1")]
			[Address(RVA = "0x1D28A6C", Offset = "0x1D28A6C", VA = "0x7BBC528A6C")]
			[DebuggerHidden]
			public <ShowItemControlers>d__43(int <>1__state)
			{
			}

			// Token: 0x060086D2 RID: 34514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086D2")]
			[Address(RVA = "0x1D28CF4", Offset = "0x1D28CF4", VA = "0x7BBC528CF4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060086D3 RID: 34515 RVA: 0x00024780 File Offset: 0x00022980
			[Token(Token = "0x60086D3")]
			[Address(RVA = "0x1D28CF8", Offset = "0x1D28CF8", VA = "0x7BBC528CF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x060086D4 RID: 34516 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B3")]
			private object Current
			{
				[Token(Token = "0x60086D4")]
				[Address(RVA = "0x1D29038", Offset = "0x1D29038", VA = "0x7BBC529038", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060086D5 RID: 34517 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60086D5")]
			[Address(RVA = "0x1D29040", Offset = "0x1D29040", VA = "0x7BBC529040", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x060086D6 RID: 34518 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009B4")]
			private object Current
			{
				[Token(Token = "0x60086D6")]
				[Address(RVA = "0x1D290A8", Offset = "0x1D290A8", VA = "0x7BBC5290A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040095B4 RID: 38324
			[Token(Token = "0x40095B4")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040095B5 RID: 38325
			[Token(Token = "0x40095B5")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040095B6 RID: 38326
			[Token(Token = "0x40095B6")]
			[FieldOffset(Offset = "0x20")]
			public UIIAPBundleController <>4__this;

			// Token: 0x040095B7 RID: 38327
			[Token(Token = "0x40095B7")]
			[FieldOffset(Offset = "0x28")]
			private int <i>5__2;
		}
	}
}
