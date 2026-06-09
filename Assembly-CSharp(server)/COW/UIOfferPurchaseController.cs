using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015C2 RID: 5570
	[Token(Token = "0x20015C2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF244", Offset = "0x10EF244")]
	public class UIOfferPurchaseController : UIPopupWindowController
	{
		// Token: 0x0600628A RID: 25226 RVA: 0x0001C590 File Offset: 0x0001A790
		[Token(Token = "0x600628A")]
		[Address(RVA = "0x16E0A74", Offset = "0x16E0A74", VA = "0x7BBBEE0A74")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628B")]
		[Address(RVA = "0x16E0AC4", Offset = "0x16E0AC4", VA = "0x7BBBEE0AC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628C")]
		[Address(RVA = "0x16E0C58", Offset = "0x16E0C58", VA = "0x7BBBEE0C58")]
		private void OnPurchaseBtn()
		{
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628D")]
		[Address(RVA = "0x16E0D0C", Offset = "0x16E0D0C", VA = "0x7BBBEE0D0C")]
		private void OnClose()
		{
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628E")]
		[Address(RVA = "0x16E0D4C", Offset = "0x16E0D4C", VA = "0x7BBBEE0D4C")]
		public void RefreshData(OfferGoodsDesc offerGoods)
		{
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600628F")]
		[Address(RVA = "0x16E0FEC", Offset = "0x16E0FEC", VA = "0x7BBBEE0FEC")]
		private void CreateStandItemMini()
		{
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006290")]
		[Address(RVA = "0x16E1188", Offset = "0x16E1188", VA = "0x7BBBEE1188")]
		public UIOfferPurchaseController()
		{
		}

		// Token: 0x040081B7 RID: 33207
		[Token(Token = "0x40081B7")]
		[FieldOffset(Offset = "0x98")]
		private UIOfferPurchaseView m_View;

		// Token: 0x040081B8 RID: 33208
		[Token(Token = "0x40081B8")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMall m_ModelMall;

		// Token: 0x040081B9 RID: 33209
		[Token(Token = "0x40081B9")]
		[FieldOffset(Offset = "0xA8")]
		private OfferGoodsDesc m_OffGoods;
	}
}
