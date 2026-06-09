using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001782 RID: 6018
	[Token(Token = "0x2001782")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2304", Offset = "0x10F2304")]
	public class UIDebrisPurchaseController : UIPopupWindowController, IVoucher
	{
		// Token: 0x06007233 RID: 29235 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		[Token(Token = "0x6007233")]
		[Address(RVA = "0x1BAE62C", Offset = "0x1BAE62C", VA = "0x7BBC3AE62C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007234")]
		[Address(RVA = "0x1BAE67C", Offset = "0x1BAE67C", VA = "0x7BBC3AE67C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007235 RID: 29237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007235")]
		[Address(RVA = "0x1BAE9E8", Offset = "0x1BAE9E8", VA = "0x7BBC3AE9E8")]
		private void OnPlusBtnClick()
		{
		}

		// Token: 0x06007236 RID: 29238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007236")]
		[Address(RVA = "0x1BAEA8C", Offset = "0x1BAEA8C", VA = "0x7BBC3AEA8C")]
		private void OnMinusBtnClick()
		{
		}

		// Token: 0x06007237 RID: 29239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007237")]
		[Address(RVA = "0x1BAEAB4", Offset = "0x1BAEAB4", VA = "0x7BBC3AEAB4")]
		private void OnMaxBtnClick()
		{
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007238")]
		[Address(RVA = "0x1BAEACC", Offset = "0x1BAEACC", VA = "0x7BBC3AEACC")]
		public void InitView(int cnt)
		{
		}

		// Token: 0x06007239 RID: 29241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007239")]
		[Address(RVA = "0x1BAEBD0", Offset = "0x1BAEBD0", VA = "0x7BBC3AEBD0")]
		private void ShowVoucher()
		{
		}

		// Token: 0x0600723A RID: 29242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723A")]
		[Address(RVA = "0x1BAEA10", Offset = "0x1BAEA10", VA = "0x7BBC3AEA10")]
		public void RefreshSliderInfo()
		{
		}

		// Token: 0x0600723B RID: 29243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723B")]
		[Address(RVA = "0x1BAEE9C", Offset = "0x1BAEE9C", VA = "0x7BBC3AEE9C")]
		private void RefreshCurDebrisInfo()
		{
		}

		// Token: 0x0600723C RID: 29244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723C")]
		[Address(RVA = "0x1BAEC90", Offset = "0x1BAEC90", VA = "0x7BBC3AEC90")]
		private void RefreshPriceBtnState()
		{
		}

		// Token: 0x0600723D RID: 29245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723D")]
		[Address(RVA = "0x1BAEFD8", Offset = "0x1BAEFD8", VA = "0x7BBC3AEFD8")]
		private void RefreshPrice()
		{
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723E")]
		[Address(RVA = "0x1BAF170", Offset = "0x1BAF170", VA = "0x7BBC3AF170")]
		private void SetPriceLabelText(int price)
		{
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600723F")]
		[Address(RVA = "0x1BAF230", Offset = "0x1BAF230", VA = "0x7BBC3AF230")]
		private void OnCoinBtnClick()
		{
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007240")]
		[Address(RVA = "0x1BAF34C", Offset = "0x1BAF34C", VA = "0x7BBC3AF34C")]
		private void OnGemBtnClick()
		{
		}

		// Token: 0x06007241 RID: 29249 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		[Token(Token = "0x6007241")]
		[Address(RVA = "0x1BAEC6C", Offset = "0x1BAEC6C", VA = "0x7BBC3AEC6C")]
		private int CalcTotalPriceForVoucher()
		{
			return 0;
		}

		// Token: 0x06007242 RID: 29250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007242")]
		[Address(RVA = "0x1BAF0BC", Offset = "0x1BAF0BC", VA = "0x7BBC3AF0BC")]
		private void RefreshVoucherCtrlTotalPrice()
		{
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		[Token(Token = "0x6007243")]
		[Address(RVA = "0x1BAF334", Offset = "0x1BAF334", VA = "0x7BBC3AF334")]
		private uint GetVoucherID()
		{
			return 0U;
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007244")]
		[Address(RVA = "0x1BAF454", Offset = "0x1BAF454", VA = "0x7BBC3AF454", Slot = "40")]
		public UIVoucherController OpenVoucherController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007245")]
		[Address(RVA = "0x1BAF4F0", Offset = "0x1BAF4F0", VA = "0x7BBC3AF4F0", Slot = "42")]
		public UIVoucherItemController OpenVoucherItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007246")]
		[Address(RVA = "0x1BAF584", Offset = "0x1BAF584", VA = "0x7BBC3AF584", Slot = "41")]
		public void OnVoucherItemClick(params object[] data)
		{
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007247")]
		[Address(RVA = "0x1BAEAEC", Offset = "0x1BAEAEC", VA = "0x7BBC3AEAEC")]
		private void RefreshView()
		{
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007248")]
		[Address(RVA = "0x1BAF6BC", Offset = "0x1BAF6BC", VA = "0x7BBC3AF6BC")]
		public UIDebrisPurchaseController()
		{
		}

		// Token: 0x04008B56 RID: 35670
		[Token(Token = "0x4008B56")]
		[FieldOffset(Offset = "0x98")]
		private UIDebrisPurchaseView m_View;

		// Token: 0x04008B57 RID: 35671
		[Token(Token = "0x4008B57")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelAvatarProfile m_ProfileModel;

		// Token: 0x04008B58 RID: 35672
		[Token(Token = "0x4008B58")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelMall m_ModelMall;

		// Token: 0x04008B59 RID: 35673
		[Token(Token = "0x4008B59")]
		[FieldOffset(Offset = "0xB0")]
		private int m_NextLevelDebrisPurchaseCnt;

		// Token: 0x04008B5A RID: 35674
		[Token(Token = "0x4008B5A")]
		[FieldOffset(Offset = "0xB4")]
		private int m_DebrisPurchaseCnt;

		// Token: 0x04008B5B RID: 35675
		[Token(Token = "0x4008B5B")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_PriceCoin;

		// Token: 0x04008B5C RID: 35676
		[Token(Token = "0x4008B5C")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_PriceGem;

		// Token: 0x04008B5D RID: 35677
		[Token(Token = "0x4008B5D")]
		[FieldOffset(Offset = "0xC0")]
		private uint m_Interval;

		// Token: 0x04008B5E RID: 35678
		[Token(Token = "0x4008B5E")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_ItemID;

		// Token: 0x04008B5F RID: 35679
		[Token(Token = "0x4008B5F")]
		[FieldOffset(Offset = "0xC8")]
		private int m_TotalPriceForVoucher;

		// Token: 0x04008B60 RID: 35680
		[Token(Token = "0x4008B60")]
		[FieldOffset(Offset = "0xCC")]
		private EInventory.CurrencyType m_VoucherCurrencyType;

		// Token: 0x04008B61 RID: 35681
		[Token(Token = "0x4008B61")]
		[FieldOffset(Offset = "0xD0")]
		protected VoucherData m_VoucherData;

		// Token: 0x04008B62 RID: 35682
		[Token(Token = "0x4008B62")]
		[FieldOffset(Offset = "0xD8")]
		protected UIVoucherController m_VoucherCtrl;

		// Token: 0x04008B63 RID: 35683
		[Token(Token = "0x4008B63")]
		[FieldOffset(Offset = "0xE0")]
		protected bool m_InputExceedNotify;
	}
}
