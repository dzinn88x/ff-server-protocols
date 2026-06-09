using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B7F RID: 7039
	[Token(Token = "0x2001B7F")]
	public class UISettingTabButton
	{
		// Token: 0x060097B0 RID: 38832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B0")]
		[Address(RVA = "0x163232C", Offset = "0x163232C", VA = "0x7BBBE3232C")]
		public UISettingTabButton(UIToggleButton button, SettingPageType type, UISettingTabButton.ClickCallback callback)
		{
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B1")]
		[Address(RVA = "0x1635D94", Offset = "0x1635D94", VA = "0x7BBBE35D94")]
		private void OnButtonClick()
		{
		}

		// Token: 0x04009FB6 RID: 40886
		[Token(Token = "0x4009FB6")]
		[FieldOffset(Offset = "0x10")]
		private UIToggleButton Button;

		// Token: 0x04009FB7 RID: 40887
		[Token(Token = "0x4009FB7")]
		[FieldOffset(Offset = "0x18")]
		private SettingPageType ToggleType;

		// Token: 0x04009FB8 RID: 40888
		[Token(Token = "0x4009FB8")]
		[FieldOffset(Offset = "0x20")]
		private UISettingTabButton.ClickCallback m_Callback;

		// Token: 0x02001B80 RID: 7040
		// (Invoke) Token: 0x060097B3 RID: 38835
		[Token(Token = "0x2001B80")]
		public delegate void ClickCallback(SettingPageType pageType);
	}
}
