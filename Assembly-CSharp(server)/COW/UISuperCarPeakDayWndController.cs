using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013C2 RID: 5058
	[Token(Token = "0x20013C2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBDA8", Offset = "0x10EBDA8")]
	public class UISuperCarPeakDayWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600529F RID: 21151 RVA: 0x00018C90 File Offset: 0x00016E90
		[Token(Token = "0x600529F")]
		[Address(RVA = "0x2149468", Offset = "0x2149468", VA = "0x7BBC949468")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x21494B8", Offset = "0x21494B8", VA = "0x7BBC9494B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x2149FD8", Offset = "0x2149FD8", VA = "0x7BBC949FD8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x214A018", Offset = "0x214A018", VA = "0x7BBC94A018")]
		private void CloseAllItem()
		{
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x214973C", Offset = "0x214973C", VA = "0x7BBC94973C")]
		public void SetViewData()
		{
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x214A164", Offset = "0x214A164", VA = "0x7BBC94A164")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x214A16C", Offset = "0x214A16C", VA = "0x7BBC94A16C")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x214A248", Offset = "0x214A248", VA = "0x7BBC94A248", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00018CA8 File Offset: 0x00016EA8
		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x214A2C8", Offset = "0x214A2C8", VA = "0x7BBC94A2C8", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x214A30C", Offset = "0x214A30C", VA = "0x7BBC94A30C")]
		public UISuperCarPeakDayWndController()
		{
		}

		// Token: 0x04007885 RID: 30853
		[Token(Token = "0x4007885")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarPeakDayWndView m_View;

		// Token: 0x04007886 RID: 30854
		[Token(Token = "0x4007886")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007887 RID: 30855
		[Token(Token = "0x4007887")]
		[FieldOffset(Offset = "0xA8")]
		private ClientActivityDesc desc;

		// Token: 0x04007888 RID: 30856
		[Token(Token = "0x4007888")]
		[FieldOffset(Offset = "0xB0")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007889 RID: 30857
		[Token(Token = "0x4007889")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIStandardItemMAXBController> itemList;

		// Token: 0x0400788A RID: 30858
		[Token(Token = "0x400788A")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_PeakDayAwardClaimed;
	}
}
