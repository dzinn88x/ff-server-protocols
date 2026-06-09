using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BFD RID: 7165
	[Token(Token = "0x2001BFD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB50C", Offset = "0x10FB50C")]
	public class UIVoucherListController : UIPopupWindowController, IEasyList
	{
		// Token: 0x06009BB0 RID: 39856 RVA: 0x00028E18 File Offset: 0x00027018
		[Token(Token = "0x6009BB0")]
		[Address(RVA = "0x1684680", Offset = "0x1684680", VA = "0x7BBBE84680")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009BB1 RID: 39857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB1")]
		[Address(RVA = "0x16846D0", Offset = "0x16846D0", VA = "0x7BBBE846D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009BB2 RID: 39858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB2")]
		[Address(RVA = "0x16847E4", Offset = "0x16847E4", VA = "0x7BBBE847E4")]
		private void OnVoucherItemClick(params object[] data)
		{
		}

		// Token: 0x06009BB3 RID: 39859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB3")]
		[Address(RVA = "0x16848A0", Offset = "0x16848A0", VA = "0x7BBBE848A0", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06009BB4 RID: 39860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB4")]
		[Address(RVA = "0x168494C", Offset = "0x168494C", VA = "0x7BBBE8494C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009BB5 RID: 39861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB5")]
		[Address(RVA = "0x1684A28", Offset = "0x1684A28", VA = "0x7BBBE84A28")]
		public void SetData(int totalGemsPrice, int totalCoinsPrice, VoucherData selectedVoucher, Func<Transform, UIVoucherItemController> customItemCreator)
		{
		}

		// Token: 0x06009BB6 RID: 39862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB6")]
		[Address(RVA = "0x1684DF4", Offset = "0x1684DF4", VA = "0x7BBBE84DF4", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06009BB7 RID: 39863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009BB7")]
		[Address(RVA = "0x1684EAC", Offset = "0x1684EAC", VA = "0x7BBBE84EAC")]
		public UIVoucherItemController SwitchVoucherItemCtrl(Transform parent)
		{
			return null;
		}

		// Token: 0x06009BB8 RID: 39864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB8")]
		[Address(RVA = "0x1684F64", Offset = "0x1684F64", VA = "0x7BBBE84F64", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BB9")]
		[Address(RVA = "0x1684F94", Offset = "0x1684F94", VA = "0x7BBBE84F94")]
		public UIVoucherListController()
		{
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x00028E30 File Offset: 0x00027030
		[Token(Token = "0x6009BBA")]
		[Address(RVA = "0x1685004", Offset = "0x1685004", VA = "0x7BBBE85004")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145254", Offset = "0x1145254")]
		private int <SetData>b__12_0(VoucherData a, VoucherData b)
		{
			return 0;
		}

		// Token: 0x0400A1E7 RID: 41447
		[Token(Token = "0x400A1E7")]
		[FieldOffset(Offset = "0x98")]
		private UIVoucherListView m_View;

		// Token: 0x0400A1E8 RID: 41448
		[Token(Token = "0x400A1E8")]
		[FieldOffset(Offset = "0xA0")]
		private List<VoucherData> m_VoucherDataList;

		// Token: 0x0400A1E9 RID: 41449
		[Token(Token = "0x400A1E9")]
		[FieldOffset(Offset = "0xA8")]
		private UIClickMask m_ClickMask;

		// Token: 0x0400A1EA RID: 41450
		[Token(Token = "0x400A1EA")]
		[FieldOffset(Offset = "0xB0")]
		private int m_TotalGemsPrice;

		// Token: 0x0400A1EB RID: 41451
		[Token(Token = "0x400A1EB")]
		[FieldOffset(Offset = "0xB4")]
		private int m_TotalCoinsPrice;

		// Token: 0x0400A1EC RID: 41452
		[Token(Token = "0x400A1EC")]
		[FieldOffset(Offset = "0xB8")]
		private VoucherData m_VoucherData;

		// Token: 0x0400A1ED RID: 41453
		[Token(Token = "0x400A1ED")]
		[FieldOffset(Offset = "0xC0")]
		private Func<Transform, UIVoucherItemController> m_CustomItemCreator;
	}
}
