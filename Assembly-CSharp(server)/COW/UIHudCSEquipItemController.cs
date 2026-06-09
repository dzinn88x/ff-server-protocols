using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x020014B6 RID: 5302
	[Token(Token = "0x20014B6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED614", Offset = "0x10ED614")]
	internal class UIHudCSEquipItemController : UIBaseController
	{
		// Token: 0x060059F1 RID: 23025 RVA: 0x0001A7D8 File Offset: 0x000189D8
		[Token(Token = "0x60059F1")]
		[Address(RVA = "0x19B8068", Offset = "0x19B8068", VA = "0x7BBC1B8068")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F2")]
		[Address(RVA = "0x19B80B8", Offset = "0x19B80B8", VA = "0x7BBC1B80B8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060059F3 RID: 23027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F3")]
		[Address(RVA = "0x19B8430", Offset = "0x19B8430", VA = "0x7BBC1B8430", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x19B86F4", Offset = "0x19B86F4", VA = "0x7BBC1B86F4")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x19B6DE8", Offset = "0x19B6DE8", VA = "0x7BBC1B6DE8")]
		public void SetUIData(CSShopItemData data, uint quality = 0U)
		{
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x19B7A44", Offset = "0x19B7A44", VA = "0x7BBC1B7A44")]
		public UIToggleButton GetToggleButton()
		{
			return null;
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x19B8DE0", Offset = "0x19B8DE0", VA = "0x7BBC1B8DE0")]
		private void RefreshPrice(params object[] data)
		{
		}

		// Token: 0x060059F8 RID: 23032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F8")]
		[Address(RVA = "0x19B8AFC", Offset = "0x19B8AFC", VA = "0x7BBC1B8AFC")]
		private void CheckLimitation()
		{
		}

		// Token: 0x060059F9 RID: 23033 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Token(Token = "0x60059F9")]
		[Address(RVA = "0x19B88DC", Offset = "0x19B88DC", VA = "0x7BBC1B88DC")]
		private uint GetLimitCount()
		{
			return 0U;
		}

		// Token: 0x060059FA RID: 23034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FA")]
		[Address(RVA = "0x19B8E90", Offset = "0x19B8E90", VA = "0x7BBC1B8E90")]
		private void OnItemPurchased(params object[] data)
		{
		}

		// Token: 0x060059FB RID: 23035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FB")]
		[Address(RVA = "0x19B8968", Offset = "0x19B8968", VA = "0x7BBC1B8968")]
		private void CheckPriceValid()
		{
		}

		// Token: 0x060059FC RID: 23036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FC")]
		[Address(RVA = "0x19B9048", Offset = "0x19B9048", VA = "0x7BBC1B9048")]
		private void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x060059FD RID: 23037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FD")]
		[Address(RVA = "0x19B8838", Offset = "0x19B8838", VA = "0x7BBC1B8838")]
		private void SetSelected(bool v)
		{
		}

		// Token: 0x060059FE RID: 23038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FE")]
		[Address(RVA = "0x19B9148", Offset = "0x19B9148", VA = "0x7BBC1B9148")]
		private void OnCoinChanged(params object[] data)
		{
		}

		// Token: 0x060059FF RID: 23039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059FF")]
		[Address(RVA = "0x19B916C", Offset = "0x19B916C", VA = "0x7BBC1B916C")]
		private void OnShow(params object[] data)
		{
		}

		// Token: 0x06005A00 RID: 23040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A00")]
		[Address(RVA = "0x19B9170", Offset = "0x19B9170", VA = "0x7BBC1B9170")]
		private void OnPurchaseSuccess(params object[] data)
		{
		}

		// Token: 0x06005A01 RID: 23041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A01")]
		[Address(RVA = "0x19B92A0", Offset = "0x19B92A0", VA = "0x7BBC1B92A0")]
		private void OnFreeCardCountChanged(params object[] data)
		{
		}

		// Token: 0x06005A02 RID: 23042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A02")]
		[Address(RVA = "0x19B93A4", Offset = "0x19B93A4", VA = "0x7BBC1B93A4")]
		public UIHudCSEquipItemController()
		{
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x0001A808 File Offset: 0x00018A08
		[Token(Token = "0x6005A03")]
		[Address(RVA = "0x19B93AC", Offset = "0x19B93AC", VA = "0x7BBC1B93AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F518", Offset = "0x113F518")]
		private bool <OnPurchaseSuccess>b__22_0(uUSV\u0080k{ i)
		{
			return default(bool);
		}

		// Token: 0x04007D32 RID: 32050
		[Token(Token = "0x4007D32")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopItemViewExt m_View;

		// Token: 0x04007D33 RID: 32051
		[Token(Token = "0x4007D33")]
		[FieldOffset(Offset = "0x60")]
		private CSShopItemData m_Data;

		// Token: 0x04007D34 RID: 32052
		[Token(Token = "0x4007D34")]
		[FieldOffset(Offset = "0x68")]
		private bool m_Selected;

		// Token: 0x04007D35 RID: 32053
		[Token(Token = "0x4007D35")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_PurchaseCnt;

		// Token: 0x04007D36 RID: 32054
		[Token(Token = "0x4007D36")]
		[FieldOffset(Offset = "0x70")]
		private uint m_LimitCnt;

		// Token: 0x04007D37 RID: 32055
		[Token(Token = "0x4007D37")]
		[FieldOffset(Offset = "0x74")]
		private uint m_Quality;

		// Token: 0x04007D38 RID: 32056
		[Token(Token = "0x4007D38")]
		[FieldOffset(Offset = "0x78")]
		private uint m_Price;
	}
}
