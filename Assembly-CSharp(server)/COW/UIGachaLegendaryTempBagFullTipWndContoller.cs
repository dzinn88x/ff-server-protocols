using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017F4 RID: 6132
	[Token(Token = "0x20017F4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F321C", Offset = "0x10F321C")]
	public class UIGachaLegendaryTempBagFullTipWndContoller : UIPopupWindowController
	{
		// Token: 0x06007710 RID: 30480 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		[Token(Token = "0x6007710")]
		[Address(RVA = "0x2057424", Offset = "0x2057424", VA = "0x7BBC857424")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007711")]
		[Address(RVA = "0x2057474", Offset = "0x2057474", VA = "0x7BBC857474", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007712")]
		[Address(RVA = "0x20575B0", Offset = "0x20575B0", VA = "0x7BBC8575B0")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007713")]
		[Address(RVA = "0x205765C", Offset = "0x205765C", VA = "0x7BBC85765C")]
		public UIGachaLegendaryTempBagFullTipWndContoller()
		{
		}

		// Token: 0x04008D94 RID: 36244
		[Token(Token = "0x4008D94")]
		[FieldOffset(Offset = "0x98")]
		private UIModelGacha m_ModelGacha;

		// Token: 0x04008D95 RID: 36245
		[Token(Token = "0x4008D95")]
		[FieldOffset(Offset = "0xA0")]
		private uint m_GachaID;

		// Token: 0x04008D96 RID: 36246
		[Token(Token = "0x4008D96")]
		[FieldOffset(Offset = "0xA8")]
		private UIGachaLegendaryTempBagFullTipWndView m_View;
	}
}
