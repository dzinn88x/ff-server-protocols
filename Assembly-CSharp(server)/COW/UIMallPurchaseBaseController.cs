using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020015A4 RID: 5540
	[Token(Token = "0x20015A4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EEF34", Offset = "0x10EEF34")]
	public class UIMallPurchaseBaseController : UIPopupWindowController, IVoucher
	{
		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06006162 RID: 24930 RVA: 0x0001C0E0 File Offset: 0x0001A2E0
		// (set) Token: 0x06006163 RID: 24931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008C3")]
		protected virtual int ItemCount
		{
			[Token(Token = "0x6006162")]
			[Address(RVA = "0x1DEE3F4", Offset = "0x1DEE3F4", VA = "0x7BBC5EE3F4", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6006163")]
			[Address(RVA = "0x1DEE3FC", Offset = "0x1DEE3FC", VA = "0x7BBC5EE3FC", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x0001C0F8 File Offset: 0x0001A2F8
		[Token(Token = "0x6006164")]
		[Address(RVA = "0x1DEE7A4", Offset = "0x1DEE7A4", VA = "0x7BBC5EE7A4")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006165")]
		[Address(RVA = "0x1DEE570", Offset = "0x1DEE570", VA = "0x7BBC5EE570")]
		protected void SetPriceLabelText()
		{
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006166")]
		[Address(RVA = "0x1DEE6BC", Offset = "0x1DEE6BC", VA = "0x7BBC5EE6BC")]
		protected void RefreshVoucherCtrlTotalPrice()
		{
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x0001C110 File Offset: 0x0001A310
		[Token(Token = "0x6006167")]
		[Address(RVA = "0x1DEE7AC", Offset = "0x1DEE7AC", VA = "0x7BBC5EE7AC")]
		protected uint GetVoucherID()
		{
			return 0U;
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x0001C128 File Offset: 0x0001A328
		[Token(Token = "0x6006168")]
		[Address(RVA = "0x1DEE7C4", Offset = "0x1DEE7C4", VA = "0x7BBC5EE7C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006169")]
		[Address(RVA = "0x1DED984", Offset = "0x1DED984", VA = "0x7BBC5ED984", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616A")]
		[Address(RVA = "0x1DEE814", Offset = "0x1DEE814", VA = "0x7BBC5EE814", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616B")]
		[Address(RVA = "0x1DEE81C", Offset = "0x1DEE81C", VA = "0x7BBC5EE81C")]
		protected void OnPlusBtnClick()
		{
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616C")]
		[Address(RVA = "0x1DEE9EC", Offset = "0x1DEE9EC", VA = "0x7BBC5EE9EC")]
		protected void OnMinsBtnClick()
		{
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616D")]
		[Address(RVA = "0x1DEEA54", Offset = "0x1DEEA54", VA = "0x7BBC5EEA54")]
		protected void OnMaxBtnClick()
		{
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616E")]
		[Address(RVA = "0x1DEEA68", Offset = "0x1DEEA68", VA = "0x7BBC5EEA68")]
		private void OnAddTenBtnClick()
		{
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600616F")]
		[Address(RVA = "0x1DEEC24", Offset = "0x1DEEC24", VA = "0x7BBC5EEC24")]
		protected void RefreshModifyBtn(uint limited_purchase_times)
		{
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006170")]
		[Address(RVA = "0x1DEDFC8", Offset = "0x1DEDFC8", VA = "0x7BBC5EDFC8")]
		protected void SetMaxCount(int maxCount)
		{
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006171")]
		[Address(RVA = "0x1DEDFD0", Offset = "0x1DEDFD0", VA = "0x7BBC5EDFD0")]
		protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times)
		{
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006172")]
		[Address(RVA = "0x1DEED10", Offset = "0x1DEED10", VA = "0x7BBC5EED10")]
		protected void ShowLimitedPurchase(uint limited_purchase_times, uint purchase_times)
		{
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006173")]
		[Address(RVA = "0x1DEE068", Offset = "0x1DEE068", VA = "0x7BBC5EE068")]
		protected void ShowModifyCountContainer()
		{
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006174")]
		[Address(RVA = "0x1DEEF5C", Offset = "0x1DEEF5C", VA = "0x7BBC5EEF5C")]
		protected void ShowVoucherContainer()
		{
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006175")]
		[Address(RVA = "0x1DEEFE8", Offset = "0x1DEEFE8", VA = "0x7BBC5EEFE8", Slot = "40")]
		public UIVoucherController OpenVoucherController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006176")]
		[Address(RVA = "0x1DEF08C", Offset = "0x1DEF08C", VA = "0x7BBC5EF08C", Slot = "42")]
		public UIVoucherItemController OpenVoucherItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006177")]
		[Address(RVA = "0x1DEF120", Offset = "0x1DEF120", VA = "0x7BBC5EF120", Slot = "41")]
		public void OnVoucherItemClick(params object[] data)
		{
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006178")]
		[Address(RVA = "0x1DEF26C", Offset = "0x1DEF26C", VA = "0x7BBC5EF26C")]
		private void ShowVoucherEffect()
		{
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006179")]
		[Address(RVA = "0x1DEE13C", Offset = "0x1DEE13C", VA = "0x7BBC5EE13C")]
		protected void InitItemInfo(BaseItemInfo baseItemInfo)
		{
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x0001C140 File Offset: 0x0001A340
		[Token(Token = "0x600617A")]
		[Address(RVA = "0x1DEF404", Offset = "0x1DEF404", VA = "0x7BBC5EF404")]
		protected bool CanShowModifyCountContainer(uint awardTime, uint limited_purchase_times)
		{
			return default(bool);
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617B")]
		[Address(RVA = "0x1DEF49C", Offset = "0x1DEF49C", VA = "0x7BBC5EF49C")]
		protected void EnableInput(bool enable)
		{
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617C")]
		[Address(RVA = "0x1DEF720", Offset = "0x1DEF720", VA = "0x7BBC5EF720")]
		private void OnCountInputSubmit()
		{
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617D")]
		[Address(RVA = "0x1DEF974", Offset = "0x1DEF974", VA = "0x7BBC5EF974")]
		private void RefreshCountInput()
		{
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617E")]
		[Address(RVA = "0x1DEF9F4", Offset = "0x1DEF9F4", VA = "0x7BBC5EF9F4")]
		private void OnCountInputChanged()
		{
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600617F")]
		[Address(RVA = "0x1DEE3E4", Offset = "0x1DEE3E4", VA = "0x7BBC5EE3E4")]
		public UIMallPurchaseBaseController()
		{
		}

		// Token: 0x0400814B RID: 33099
		[Token(Token = "0x400814B")]
		[FieldOffset(Offset = "0x98")]
		protected CSSharedItemData m_ItemData;

		// Token: 0x0400814C RID: 33100
		[Token(Token = "0x400814C")]
		[FieldOffset(Offset = "0xA0")]
		protected int m_Count;

		// Token: 0x0400814D RID: 33101
		[Token(Token = "0x400814D")]
		[FieldOffset(Offset = "0xA4")]
		protected int m_MaxCount;

		// Token: 0x0400814E RID: 33102
		[Token(Token = "0x400814E")]
		[FieldOffset(Offset = "0xA8")]
		protected VoucherData m_VoucherData;

		// Token: 0x0400814F RID: 33103
		[Token(Token = "0x400814F")]
		[FieldOffset(Offset = "0xB0")]
		protected UIVoucherController m_VoucherCtrl;

		// Token: 0x04008150 RID: 33104
		[Token(Token = "0x4008150")]
		[FieldOffset(Offset = "0xB8")]
		protected UIModelMall m_ModelMall;

		// Token: 0x04008151 RID: 33105
		[Token(Token = "0x4008151")]
		[FieldOffset(Offset = "0xC0")]
		protected UIMallPurchaseViewExt m_View;

		// Token: 0x04008152 RID: 33106
		[Token(Token = "0x4008152")]
		[FieldOffset(Offset = "0xC8")]
		protected uint m_CoinsPrice;

		// Token: 0x04008153 RID: 33107
		[Token(Token = "0x4008153")]
		[FieldOffset(Offset = "0xCC")]
		protected uint m_GemsPrice;

		// Token: 0x04008154 RID: 33108
		[Token(Token = "0x4008154")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_ShowVoucher;

		// Token: 0x04008155 RID: 33109
		[Token(Token = "0x4008155")]
		[FieldOffset(Offset = "0xD1")]
		protected bool m_InputExceedNotify;

		// Token: 0x04008156 RID: 33110
		[Token(Token = "0x4008156")]
		[FieldOffset(Offset = "0xD2")]
		private bool m_CanShowModifyContainer;
	}
}
