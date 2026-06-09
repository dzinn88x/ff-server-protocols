using System;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020025BA RID: 9658
	[Token(Token = "0x20025BA")]
	internal class UIHudInGameShopItemViewExt : UIHudInGameShopItemView
	{
		// Token: 0x0600C6A9 RID: 50857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6A9")]
		[Address(RVA = "0x198A84C", Offset = "0x198A84C", VA = "0x7BBC18A84C")]
		public void OnInit()
		{
		}

		// Token: 0x0600C6AA RID: 50858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6AA")]
		[Address(RVA = "0x198ADFC", Offset = "0x198ADFC", VA = "0x7BBC18ADFC")]
		public void SetUIData(nS}etYj itemData1, uint count1, bool showSkin = false, [Optional] nS}etYj itemData2, uint price = 0U, uint quality = 0U, bool hasBonus = false, bool isLimited = false, bool showNewTag = false, bool showCoin = true, UIHudInGameShopItemViewExt.CoinIconType coinType = UIHudInGameShopItemViewExt.CoinIconType.ShopCoin)
		{
		}

		// Token: 0x0600C6AB RID: 50859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6AB")]
		[Address(RVA = "0x198C14C", Offset = "0x198C14C", VA = "0x7BBC18C14C")]
		private void SetImageInOtherAtlas(bool hasBonus, bool showNewTag)
		{
		}

		// Token: 0x0600C6AC RID: 50860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6AC")]
		[Address(RVA = "0x198B824", Offset = "0x198B824", VA = "0x7BBC18B824")]
		public void UpdateGrayCondition(uint condType, bool condValue)
		{
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x000354D8 File Offset: 0x000336D8
		[Token(Token = "0x600C6AD")]
		[Address(RVA = "0x198C3A8", Offset = "0x198C3A8", VA = "0x7BBC18C3A8")]
		public bool IsAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600C6AE RID: 50862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6AE")]
		[Address(RVA = "0x198C258", Offset = "0x198C258", VA = "0x7BBC18C258")]
		public void RefreshShortCoinStatus(bool shortCoin)
		{
		}

		// Token: 0x0600C6AF RID: 50863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6AF")]
		[Address(RVA = "0x198C32C", Offset = "0x198C32C", VA = "0x7BBC18C32C")]
		public void RefreshLimiteStatus(bool isLimited)
		{
		}

		// Token: 0x0600C6B0 RID: 50864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6B0")]
		[Address(RVA = "0x1987190", Offset = "0x1987190", VA = "0x7BBC187190")]
		public static string GetCoinIconByType(UIHudInGameShopItemViewExt.CoinIconType iconType)
		{
			return null;
		}

		// Token: 0x0600C6B1 RID: 50865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6B1")]
		[Address(RVA = "0x198C3E4", Offset = "0x198C3E4", VA = "0x7BBC18C3E4")]
		public UIHudInGameShopItemViewExt()
		{
		}

		// Token: 0x0400F93D RID: 63805
		[Token(Token = "0x400F93D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private BitArrayBoolean m_ShowGraySprite;

		// Token: 0x0400F93E RID: 63806
		[Token(Token = "0x400F93E")]
		public const uint ISUNLOCK = 1U;

		// Token: 0x0400F93F RID: 63807
		[Token(Token = "0x400F93F")]
		public const uint TOKEN_LACK = 2U;

		// Token: 0x0400F940 RID: 63808
		[Token(Token = "0x400F940")]
		public const uint CAPACITY_LACK = 4U;

		// Token: 0x0400F941 RID: 63809
		[Token(Token = "0x400F941")]
		public const uint LIMIT_LACK = 8U;

		// Token: 0x0400F942 RID: 63810
		[Token(Token = "0x400F942")]
		public const uint PLIERS_NOTOK = 16U;

		// Token: 0x0400F943 RID: 63811
		[Token(Token = "0x400F943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Color limitColor;

		// Token: 0x020025BB RID: 9659
		[Token(Token = "0x20025BB")]
		public enum CoinIconType
		{
			// Token: 0x0400F945 RID: 63813
			[Token(Token = "0x400F945")]
			ExchangeToken,
			// Token: 0x0400F946 RID: 63814
			[Token(Token = "0x400F946")]
			ShopCoin,
			// Token: 0x0400F947 RID: 63815
			[Token(Token = "0x400F947")]
			TrainingToken
		}
	}
}
