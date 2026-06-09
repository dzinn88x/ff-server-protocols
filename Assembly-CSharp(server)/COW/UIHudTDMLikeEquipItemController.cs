using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200196F RID: 6511
	[Token(Token = "0x200196F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F64A4", Offset = "0x10F64A4")]
	internal class UIHudTDMLikeEquipItemController : UIBaseController
	{
		// Token: 0x0600847E RID: 33918 RVA: 0x00023F58 File Offset: 0x00022158
		[Token(Token = "0x600847E")]
		[Address(RVA = "0x1678044", Offset = "0x1678044", VA = "0x7BBBE78044")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600847F")]
		[Address(RVA = "0x1678094", Offset = "0x1678094", VA = "0x7BBBE78094", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008480")]
		[Address(RVA = "0x16783B8", Offset = "0x16783B8", VA = "0x7BBBE783B8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008481")]
		[Address(RVA = "0x1678628", Offset = "0x1678628", VA = "0x7BBBE78628")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008482")]
		[Address(RVA = "0x16787BC", Offset = "0x16787BC", VA = "0x7BBBE787BC")]
		public void SetUIData(TDMLikeShopConfigData data)
		{
		}

		// Token: 0x06008483 RID: 33923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008483")]
		[Address(RVA = "0x1678E88", Offset = "0x1678E88", VA = "0x7BBBE78E88")]
		private void RefreshPrice(params object[] data)
		{
		}

		// Token: 0x06008484 RID: 33924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008484")]
		[Address(RVA = "0x1678F34", Offset = "0x1678F34", VA = "0x7BBBE78F34")]
		private void OnItemPurchased(params object[] data)
		{
		}

		// Token: 0x06008485 RID: 33925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008485")]
		[Address(RVA = "0x1678AD4", Offset = "0x1678AD4", VA = "0x7BBBE78AD4")]
		private void CheckPriceValid()
		{
		}

		// Token: 0x06008486 RID: 33926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008486")]
		[Address(RVA = "0x1678BE4", Offset = "0x1678BE4", VA = "0x7BBBE78BE4")]
		private void CheckItemsValid()
		{
		}

		// Token: 0x06008487 RID: 33927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008487")]
		[Address(RVA = "0x16790EC", Offset = "0x16790EC", VA = "0x7BBBE790EC")]
		private void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06008488 RID: 33928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008488")]
		[Address(RVA = "0x167876C", Offset = "0x167876C", VA = "0x7BBBE7876C")]
		private void SetSelected(bool v)
		{
		}

		// Token: 0x06008489 RID: 33929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008489")]
		[Address(RVA = "0x16791B0", Offset = "0x16791B0", VA = "0x7BBBE791B0")]
		private void OnCoinChanged(params object[] data)
		{
		}

		// Token: 0x0600848A RID: 33930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600848A")]
		[Address(RVA = "0x16791B4", Offset = "0x16791B4", VA = "0x7BBBE791B4")]
		private void OnPurchaseSuccess(params object[] data)
		{
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600848B")]
		[Address(RVA = "0x16792F4", Offset = "0x16792F4", VA = "0x7BBBE792F4")]
		private void OnODFactionChange(params object[] data)
		{
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600848C")]
		[Address(RVA = "0x16792F8", Offset = "0x16792F8", VA = "0x7BBBE792F8")]
		public UIHudTDMLikeEquipItemController()
		{
		}

		// Token: 0x040094B6 RID: 38070
		[Token(Token = "0x40094B6")]
		[FieldOffset(Offset = "0x58")]
		private UIHudInGameShopItemViewExt m_View;

		// Token: 0x040094B7 RID: 38071
		[Token(Token = "0x40094B7")]
		[FieldOffset(Offset = "0x60")]
		private TDMLikeShopConfigData m_Data;

		// Token: 0x040094B8 RID: 38072
		[Token(Token = "0x40094B8")]
		[FieldOffset(Offset = "0x68")]
		private bool m_Selected;

		// Token: 0x040094B9 RID: 38073
		[Token(Token = "0x40094B9")]
		[FieldOffset(Offset = "0x0")]
		private static Color PRICE_COLOR;

		// Token: 0x040094BA RID: 38074
		[Token(Token = "0x40094BA")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_Price;
	}
}
