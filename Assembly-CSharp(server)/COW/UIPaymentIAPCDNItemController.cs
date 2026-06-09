using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001ACF RID: 6863
	[Token(Token = "0x2001ACF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8B3C", Offset = "0x10F8B3C")]
	public class UIPaymentIAPCDNItemController : UIBaseController
	{
		// Token: 0x060090E5 RID: 37093 RVA: 0x00026A60 File Offset: 0x00024C60
		[Token(Token = "0x60090E5")]
		[Address(RVA = "0x1F29174", Offset = "0x1F29174", VA = "0x7BBC729174")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E6")]
		[Address(RVA = "0x1F291C4", Offset = "0x1F291C4", VA = "0x7BBC7291C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E7")]
		[Address(RVA = "0x1F29228", Offset = "0x1F29228", VA = "0x7BBC729228")]
		public void SetData(AdvertDesc info)
		{
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E8")]
		[Address(RVA = "0x1F29328", Offset = "0x1F29328", VA = "0x7BBC729328")]
		public void SetDefaultTexture(ResourceID resourceId)
		{
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090E9")]
		[Address(RVA = "0x1F292E4", Offset = "0x1F292E4", VA = "0x7BBC7292E4")]
		private void ApplyCdnUrlToNetworkTexture(UINetworkTextureExt networkTexture, string url)
		{
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60090EA")]
		[Address(RVA = "0x1F2932C", Offset = "0x1F2932C", VA = "0x7BBC72932C")]
		public UIPaymentIAPCDNItemController()
		{
		}

		// Token: 0x04009C60 RID: 40032
		[Token(Token = "0x4009C60")]
		[FieldOffset(Offset = "0x58")]
		private UIPaymentIAPCDNItemView m_View;

		// Token: 0x04009C61 RID: 40033
		[Token(Token = "0x4009C61")]
		[FieldOffset(Offset = "0x60")]
		public int AdIndex;
	}
}
