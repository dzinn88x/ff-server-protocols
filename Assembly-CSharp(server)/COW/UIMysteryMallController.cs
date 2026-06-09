using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020015A8 RID: 5544
	[Token(Token = "0x20015A8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF014", Offset = "0x10EF014")]
	internal class UIMysteryMallController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x060061A4 RID: 24996 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		[Token(Token = "0x60061A4")]
		[Address(RVA = "0x14CDDA4", Offset = "0x14CDDA4", VA = "0x7BBBCCDDA4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A5")]
		[Address(RVA = "0x14CDDF4", Offset = "0x14CDDF4", VA = "0x7BBBCCDDF4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A6")]
		[Address(RVA = "0x14CE380", Offset = "0x14CE380", VA = "0x7BBBCCE380", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A7")]
		[Address(RVA = "0x14CF3E8", Offset = "0x14CF3E8", VA = "0x7BBBCCF3E8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A8")]
		[Address(RVA = "0x14CF4BC", Offset = "0x14CF4BC", VA = "0x7BBBCCF4BC")]
		private void Update()
		{
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x14CF784", Offset = "0x14CF784", VA = "0x7BBBCCF784")]
		private void RefreshView(bool needSort = false)
		{
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x14D0B50", Offset = "0x14D0B50", VA = "0x7BBBCD0B50")]
		private void RefreshBarUVMaterial(MeshRenderer barUV01, MeshRenderer barUV02)
		{
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0x14D0DF8", Offset = "0x14D0DF8", VA = "0x7BBBCD0DF8")]
		private void RefreshBarUV(MeshRenderer barUV, float barValue, float maxPosX, float maxScaleX)
		{
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0x14D1984", Offset = "0x14D1984", VA = "0x7BBBCD1984")]
		private void RefreshNormalItemList(List<MysteryPoolStoreItem> poolItemList)
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0x14CF204", Offset = "0x14CF204", VA = "0x7BBBCCF204")]
		private void RefreshBtnSwitchPool()
		{
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AE")]
		[Address(RVA = "0x14D1AFC", Offset = "0x14D1AFC", VA = "0x7BBBCD1AFC")]
		private void OnBtnSwitchPoolClick()
		{
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061AF")]
		[Address(RVA = "0x14D20E4", Offset = "0x14D20E4", VA = "0x7BBBCD20E4")]
		private void OnBtnPurchaseSuperClick()
		{
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0x14D2578", Offset = "0x14D2578", VA = "0x7BBBCD2578")]
		private void OnBtnRuleClick()
		{
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B1")]
		[Address(RVA = "0x14D2788", Offset = "0x14D2788", VA = "0x7BBBCD2788")]
		private void OnBtnGoWebClick()
		{
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0x14D2D5C", Offset = "0x14D2D5C", VA = "0x7BBBCD2D5C", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0x14D2DB8", Offset = "0x14D2DB8", VA = "0x7BBBCD2DB8", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061B4")]
		[Address(RVA = "0x14D2FEC", Offset = "0x14D2FEC", VA = "0x7BBBCD2FEC")]
		public UIMysteryMallController()
		{
		}

		// Token: 0x0400815F RID: 33119
		[Token(Token = "0x400815F")]
		[FieldOffset(Offset = "0xB0")]
		private UIMysteryMallView m_View;

		// Token: 0x04008160 RID: 33120
		[Token(Token = "0x4008160")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelMysteryMall m_ModelMall;

		// Token: 0x04008161 RID: 33121
		[Token(Token = "0x4008161")]
		[FieldOffset(Offset = "0xC0")]
		private UIMysteryMallItemController m_ItemSuperCtrl;

		// Token: 0x04008162 RID: 33122
		[Token(Token = "0x4008162")]
		[FieldOffset(Offset = "0xC8")]
		private List<UIMysteryMallItemController> m_ItemNormalCtrlList;

		// Token: 0x04008163 RID: 33123
		[Token(Token = "0x4008163")]
		[FieldOffset(Offset = "0xD0")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04008164 RID: 33124
		[Token(Token = "0x4008164")]
		[FieldOffset(Offset = "0xD8")]
		private UICountDownController m_TopCountDownCtrl;

		// Token: 0x04008165 RID: 33125
		[Token(Token = "0x4008165")]
		[FieldOffset(Offset = "0xE0")]
		private Transform m_ScollViewTrans;

		// Token: 0x04008166 RID: 33126
		[Token(Token = "0x4008166")]
		private const int MAX_NORMAL_ITEM_NUM = 13;

		// Token: 0x04008167 RID: 33127
		[Token(Token = "0x4008167")]
		[FieldOffset(Offset = "0xE8")]
		private uint m_CurPoolId;

		// Token: 0x04008168 RID: 33128
		[Token(Token = "0x4008168")]
		[FieldOffset(Offset = "0xEC")]
		private float m_ShowTopThreshold;

		// Token: 0x020015A9 RID: 5545
		[Token(Token = "0x20015A9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF04C", Offset = "0x10EF04C")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x060061B5 RID: 25013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061B5")]
			[Address(RVA = "0x14D20DC", Offset = "0x14D20DC", VA = "0x7BBBCD20DC")]
			public <>c__DisplayClass20_0()
			{
			}

			// Token: 0x060061B6 RID: 25014 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60061B6")]
			[Address(RVA = "0x14D306C", Offset = "0x14D306C", VA = "0x7BBBCD306C")]
			internal void <OnBtnSwitchPoolClick>b__0()
			{
			}

			// Token: 0x04008169 RID: 33129
			[Token(Token = "0x4008169")]
			[FieldOffset(Offset = "0x10")]
			public UISecondConfirmSmallContoller confirmWnd;

			// Token: 0x0400816A RID: 33130
			[Token(Token = "0x400816A")]
			[FieldOffset(Offset = "0x18")]
			public UIMysteryMallController <>4__this;
		}
	}
}
