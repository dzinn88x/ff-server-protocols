using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001818 RID: 6168
	[Token(Token = "0x2001818")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F35FC", Offset = "0x10F35FC")]
	public class UIGachaPurchaseConfirmWndController : UIPopupWindowController
	{
		// Token: 0x17000964 RID: 2404
		// (set) Token: 0x06007842 RID: 30786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000964")]
		public UIModelGacha.GachaDrawType DrawType
		{
			[Token(Token = "0x6007842")]
			[Address(RVA = "0x2072384", Offset = "0x2072384", VA = "0x7BBC872384")]
			set
			{
			}
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007843")]
		[Address(RVA = "0x207238C", Offset = "0x207238C", VA = "0x7BBC87238C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x000212D0 File Offset: 0x0001F4D0
		[Token(Token = "0x6007844")]
		[Address(RVA = "0x2072638", Offset = "0x2072638", VA = "0x7BBC872638")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007845")]
		[Address(RVA = "0x2072688", Offset = "0x2072688", VA = "0x7BBC872688")]
		public void RefreshUIData(bool isRepurchase, uint chestID)
		{
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007846")]
		[Address(RVA = "0x2072BA8", Offset = "0x2072BA8", VA = "0x7BBC872BA8")]
		private void ShowDrawInfo(UIModelGacha.GachaDrawType m_drawType)
		{
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007847")]
		[Address(RVA = "0x2073358", Offset = "0x2073358", VA = "0x7BBC873358")]
		private void RefreshIcon(EInventory.CurrencyType type, UIModelGacha.GachaDrawType drawType)
		{
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007848")]
		[Address(RVA = "0x207388C", Offset = "0x207388C", VA = "0x7BBC87388C")]
		private void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x000212E8 File Offset: 0x0001F4E8
		[Token(Token = "0x6007849")]
		[Address(RVA = "0x2073AE4", Offset = "0x2073AE4", VA = "0x7BBC873AE4")]
		private bool OnPurchaseBtnClickByEnter()
		{
			return default(bool);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784A")]
		[Address(RVA = "0x2073AFC", Offset = "0x2073AFC", VA = "0x7BBC873AFC")]
		private void OnNoShowBtnClick()
		{
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784B")]
		[Address(RVA = "0x2073BD8", Offset = "0x2073BD8", VA = "0x7BBC873BD8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784C")]
		[Address(RVA = "0x2073D10", Offset = "0x2073D10", VA = "0x7BBC873D10", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600784D")]
		[Address(RVA = "0x2073DD8", Offset = "0x2073DD8", VA = "0x7BBC873DD8")]
		public UIGachaPurchaseConfirmWndController()
		{
		}

		// Token: 0x04008E39 RID: 36409
		[Token(Token = "0x4008E39")]
		[FieldOffset(Offset = "0x98")]
		private UIGachaPurchaseConfirmWndView m_View;

		// Token: 0x04008E3A RID: 36410
		[Token(Token = "0x4008E3A")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelGacha.GachaDrawType m_DrawType;

		// Token: 0x04008E3B RID: 36411
		[Token(Token = "0x4008E3B")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_IsRepurchase;

		// Token: 0x04008E3C RID: 36412
		[Token(Token = "0x4008E3C")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_GachaID;

		// Token: 0x04008E3D RID: 36413
		[Token(Token = "0x4008E3D")]
		[FieldOffset(Offset = "0x0")]
		private static Color GemChestNameColor;

		// Token: 0x04008E3E RID: 36414
		[Token(Token = "0x4008E3E")]
		[FieldOffset(Offset = "0x10")]
		private static Color CoinChestNameColor;
	}
}
