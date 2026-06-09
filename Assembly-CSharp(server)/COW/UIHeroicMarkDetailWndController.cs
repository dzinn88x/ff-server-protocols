using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200185F RID: 6239
	[Token(Token = "0x200185F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3E7C", Offset = "0x10F3E7C")]
	public class UIHeroicMarkDetailWndController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x06007AE5 RID: 31461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE5")]
		[Address(RVA = "0x1D5C7A4", Offset = "0x1D5C7A4", VA = "0x7BBC55C7A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007AE6 RID: 31462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE6")]
		[Address(RVA = "0x1D5CBC4", Offset = "0x1D5CBC4", VA = "0x7BBC55CBC4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00021D38 File Offset: 0x0001FF38
		[Token(Token = "0x6007AE7")]
		[Address(RVA = "0x1D5CCB0", Offset = "0x1D5CCB0", VA = "0x7BBC55CCB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007AE8 RID: 31464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE8")]
		[Address(RVA = "0x1D5CD00", Offset = "0x1D5CD00", VA = "0x7BBC55CD00")]
		private void OnMoreDetailClick()
		{
		}

		// Token: 0x06007AE9 RID: 31465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AE9")]
		[Address(RVA = "0x1D5CD04", Offset = "0x1D5CD04", VA = "0x7BBC55CD04")]
		private void OnSelectRule(params object[] data)
		{
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEA")]
		[Address(RVA = "0x1D5D3C0", Offset = "0x1D5D3C0", VA = "0x7BBC55D3C0")]
		private void GotoTab()
		{
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEB")]
		[Address(RVA = "0x1D5CE50", Offset = "0x1D5CE50", VA = "0x7BBC55CE50")]
		private void RefreshInfo()
		{
		}

		// Token: 0x06007AEC RID: 31468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEC")]
		[Address(RVA = "0x1D5CA50", Offset = "0x1D5CA50", VA = "0x7BBC55CA50")]
		private void CreateTab()
		{
		}

		// Token: 0x06007AED RID: 31469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AED")]
		[Address(RVA = "0x1D5D94C", Offset = "0x1D5D94C", VA = "0x7BBC55D94C")]
		public void Init(ulong account_id, string tab)
		{
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AEE")]
		[Address(RVA = "0x1D5D804", Offset = "0x1D5D804", VA = "0x7BBC55D804")]
		private void UpdateDesc(bool isBR)
		{
		}

		// Token: 0x06007AEF RID: 31471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007AEF")]
		[Address(RVA = "0x1D5D988", Offset = "0x1D5D988", VA = "0x7BBC55D988", Slot = "40")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007AF0 RID: 31472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF0")]
		[Address(RVA = "0x1D5DA1C", Offset = "0x1D5DA1C", VA = "0x7BBC55DA1C", Slot = "41")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF1")]
		[Address(RVA = "0x1D5DA4C", Offset = "0x1D5DA4C", VA = "0x7BBC55DA4C", Slot = "42")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x00021D50 File Offset: 0x0001FF50
		[Token(Token = "0x6007AF2")]
		[Address(RVA = "0x1D5DAC0", Offset = "0x1D5DAC0", VA = "0x7BBC55DAC0", Slot = "43")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007AF3")]
		[Address(RVA = "0x1D5DB04", Offset = "0x1D5DB04", VA = "0x7BBC55DB04")]
		public UIHeroicMarkDetailWndController()
		{
		}

		// Token: 0x04008F72 RID: 36722
		[Token(Token = "0x4008F72")]
		[FieldOffset(Offset = "0x98")]
		private UIHeroicMarkDetailWndView m_View;

		// Token: 0x04008F73 RID: 36723
		[Token(Token = "0x4008F73")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelProfile m_Model;

		// Token: 0x04008F74 RID: 36724
		[Token(Token = "0x4008F74")]
		[FieldOffset(Offset = "0xA8")]
		private string m_Tab;

		// Token: 0x04008F75 RID: 36725
		[Token(Token = "0x4008F75")]
		[FieldOffset(Offset = "0xB0")]
		private ulong m_CacheAccountID;

		// Token: 0x04008F76 RID: 36726
		[Token(Token = "0x4008F76")]
		[FieldOffset(Offset = "0xB8")]
		private bool isDataReady;

		// Token: 0x04008F77 RID: 36727
		[Token(Token = "0x4008F77")]
		[FieldOffset(Offset = "0xB9")]
		private bool hasInitInfo;

		// Token: 0x04008F78 RID: 36728
		[Token(Token = "0x4008F78")]
		[FieldOffset(Offset = "0xC0")]
		private List<UIHeroicMarkItemCtrl> m_MarkItems;

		// Token: 0x04008F79 RID: 36729
		[Token(Token = "0x4008F79")]
		[FieldOffset(Offset = "0xC8")]
		private uint cellH;

		// Token: 0x04008F7A RID: 36730
		[Token(Token = "0x4008F7A")]
		[FieldOffset(Offset = "0xCC")]
		private uint cellCntPerLine;
	}
}
