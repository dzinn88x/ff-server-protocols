using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017F6 RID: 6134
	[Token(Token = "0x20017F6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F328C", Offset = "0x10F328C")]
	public class UIGachaLegendaryTempBagPackSecondConfriemWndController : UIPopupWindowController
	{
		// Token: 0x0600771B RID: 30491 RVA: 0x00020F10 File Offset: 0x0001F110
		[Token(Token = "0x600771B")]
		[Address(RVA = "0x2058B2C", Offset = "0x2058B2C", VA = "0x7BBC858B2C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771C")]
		[Address(RVA = "0x2058B7C", Offset = "0x2058B7C", VA = "0x7BBC858B7C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771D")]
		[Address(RVA = "0x2058D94", Offset = "0x2058D94", VA = "0x7BBC858D94")]
		private void OnToggleClick()
		{
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771E")]
		[Address(RVA = "0x2058DF4", Offset = "0x2058DF4", VA = "0x7BBC858DF4")]
		public void SetView(uint gachaID, string text, List<uint> list)
		{
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600771F")]
		[Address(RVA = "0x2058E58", Offset = "0x2058E58", VA = "0x7BBC858E58")]
		private void OnCancelClick()
		{
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007720")]
		[Address(RVA = "0x2058E60", Offset = "0x2058E60", VA = "0x7BBC858E60")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007721")]
		[Address(RVA = "0x2058F00", Offset = "0x2058F00", VA = "0x7BBC858F00")]
		public UIGachaLegendaryTempBagPackSecondConfriemWndController()
		{
		}

		// Token: 0x04008D9C RID: 36252
		[Token(Token = "0x4008D9C")]
		[FieldOffset(Offset = "0x94")]
		private uint m_GachaID;

		// Token: 0x04008D9D RID: 36253
		[Token(Token = "0x4008D9D")]
		[FieldOffset(Offset = "0x98")]
		private UIModelGacha m_Model;

		// Token: 0x04008D9E RID: 36254
		[Token(Token = "0x4008D9E")]
		[FieldOffset(Offset = "0xA0")]
		private UIGachaLegendaryTempBagPackSecondConfriemWndView m_View;

		// Token: 0x04008D9F RID: 36255
		[Token(Token = "0x4008D9F")]
		[FieldOffset(Offset = "0xA8")]
		private List<uint> m_List;
	}
}
