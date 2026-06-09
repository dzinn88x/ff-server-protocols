using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B7D RID: 7037
	[Token(Token = "0x2001B7D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA334", Offset = "0x10FA334")]
	public class UISelectLanguageController : UIPopupWindowController
	{
		// Token: 0x060097A6 RID: 38822 RVA: 0x00027FD8 File Offset: 0x000261D8
		[Token(Token = "0x60097A6")]
		[Address(RVA = "0x1630620", Offset = "0x1630620", VA = "0x7BBBE30620")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A7")]
		[Address(RVA = "0x1630670", Offset = "0x1630670", VA = "0x7BBBE30670", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A8")]
		[Address(RVA = "0x1630824", Offset = "0x1630824", VA = "0x7BBBE30824")]
		private void OnConfirmLanguage(object[] data)
		{
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097A9")]
		[Address(RVA = "0x163082C", Offset = "0x163082C", VA = "0x7BBBE3082C")]
		private void OnBGMaskClick()
		{
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AA")]
		[Address(RVA = "0x1630834", Offset = "0x1630834", VA = "0x7BBBE30834", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AB")]
		[Address(RVA = "0x1630954", Offset = "0x1630954", VA = "0x7BBBE30954", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AC")]
		[Address(RVA = "0x16309C0", Offset = "0x16309C0", VA = "0x7BBBE309C0")]
		public void SetUnLimitedData(PopMenuData data, int GroupID)
		{
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AD")]
		[Address(RVA = "0x1630B0C", Offset = "0x1630B0C", VA = "0x7BBBE30B0C")]
		public void SetDatas(List<PopMenuData> dataList, int GroupID)
		{
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AE")]
		[Address(RVA = "0x1630CB4", Offset = "0x1630CB4", VA = "0x7BBBE30CB4")]
		public void ReFreshToggles(object[] data)
		{
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097AF")]
		[Address(RVA = "0x1630D84", Offset = "0x1630D84", VA = "0x7BBBE30D84")]
		public UISelectLanguageController()
		{
		}

		// Token: 0x04009FA9 RID: 40873
		[Token(Token = "0x4009FA9")]
		[FieldOffset(Offset = "0x98")]
		private UISelectLanguageView m_View;

		// Token: 0x04009FAA RID: 40874
		[Token(Token = "0x4009FAA")]
		[FieldOffset(Offset = "0xA0")]
		private List<UISelectLangItemController> m_ToggleItemList;
	}
}
