using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ACA RID: 6858
	[Token(Token = "0x2001ACA")]
	public class UIPaymentFirstTimeController : UIPaymentController.PaymentTabContentController
	{
		// Token: 0x060090B5 RID: 37045 RVA: 0x000269A0 File Offset: 0x00024BA0
		[Token(Token = "0x60090B5")]
		[Address(RVA = "0x1F23A14", Offset = "0x1F23A14", VA = "0x7BBC723A14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090B6 RID: 37046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B6")]
		[Address(RVA = "0x1F23A64", Offset = "0x1F23A64", VA = "0x7BBC723A64", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B7")]
		[Address(RVA = "0x1F23C58", Offset = "0x1F23C58", VA = "0x7BBC723C58", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B8")]
		[Address(RVA = "0x1F23C60", Offset = "0x1F23C60", VA = "0x7BBC723C60", Slot = "29")]
		public override void RefreshContent()
		{
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090B9")]
		[Address(RVA = "0x1F242C8", Offset = "0x1F242C8", VA = "0x7BBC7242C8")]
		private void OnHelpButtonClick()
		{
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090BA")]
		[Address(RVA = "0x1F244B4", Offset = "0x1F244B4", VA = "0x7BBC7244B4")]
		private void OnGotoButtonClick()
		{
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090BB")]
		[Address(RVA = "0x1F2459C", Offset = "0x1F2459C", VA = "0x7BBC72459C")]
		private void ApplyCdnUrlKeyToNetworkTexture(UINetworkTextureExt networkTexture, string key)
		{
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090BC")]
		[Address(RVA = "0x1F24284", Offset = "0x1F24284", VA = "0x7BBC724284")]
		private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
		{
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090BD")]
		[Address(RVA = "0x1F2465C", Offset = "0x1F2465C", VA = "0x7BBC72465C")]
		private void OnCDNImgClick()
		{
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090BE")]
		[Address(RVA = "0x1F24728", Offset = "0x1F24728", VA = "0x7BBC724728")]
		public UIPaymentFirstTimeController()
		{
		}

		// Token: 0x04009C51 RID: 40017
		[Token(Token = "0x4009C51")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentFirstTimeView m_View;

		// Token: 0x04009C52 RID: 40018
		[Token(Token = "0x4009C52")]
		[FieldOffset(Offset = "0x60")]
		private List<AdvertDesc> _MainAds;
	}
}
