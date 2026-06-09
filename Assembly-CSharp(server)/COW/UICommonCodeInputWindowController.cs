using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001741 RID: 5953
	[Token(Token = "0x2001741")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F1D1C", Offset = "0x10F1D1C")]
	internal class UICommonCodeInputWindowController : UIPopupWindowController
	{
		// Token: 0x06006FF3 RID: 28659 RVA: 0x0001F608 File Offset: 0x0001D808
		[Token(Token = "0x6006FF3")]
		[Address(RVA = "0x20AEE84", Offset = "0x20AEE84", VA = "0x7BBC8AEE84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0x20AEED4", Offset = "0x20AEED4", VA = "0x7BBC8AEED4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x20AF0BC", Offset = "0x20AF0BC", VA = "0x7BBC8AF0BC")]
		public void SetUIData(CodeInputPopupData data)
		{
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x20AFFB0", Offset = "0x20AFFB0", VA = "0x7BBC8AFFB0")]
		public void OnToggleClick(object data)
		{
		}

		// Token: 0x06006FF7 RID: 28663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x20AFC88", Offset = "0x20AFC88", VA = "0x7BBC8AFC88")]
		private void SetToggleColor(int idx, bool colorHight = true)
		{
		}

		// Token: 0x06006FF8 RID: 28664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0x20AFDC8", Offset = "0x20AFDC8", VA = "0x7BBC8AFDC8")]
		private void ShowCursorAtIndex(int idx)
		{
		}

		// Token: 0x06006FF9 RID: 28665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF9")]
		[Address(RVA = "0x20B0738", Offset = "0x20B0738", VA = "0x7BBC8B0738")]
		private void ShowTextAtIndex(int idx, string text)
		{
		}

		// Token: 0x06006FFA RID: 28666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0x20B0A78", Offset = "0x20B0A78", VA = "0x7BBC8B0A78")]
		public UICommonCodeInputWindowController()
		{
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFB")]
		[Address(RVA = "0x20B0B60", Offset = "0x20B0B60", VA = "0x7BBC8B0B60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11414D0", Offset = "0x11414D0")]
		private void <OnUIInit>b__8_0()
		{
		}

		// Token: 0x040089EC RID: 35308
		[Token(Token = "0x40089EC")]
		[FieldOffset(Offset = "0x98")]
		private UICommonCodeInputWindowView m_View;

		// Token: 0x040089ED RID: 35309
		[Token(Token = "0x40089ED")]
		[FieldOffset(Offset = "0xA0")]
		private CodeInputPopupData m_Data;

		// Token: 0x040089EE RID: 35310
		[Token(Token = "0x40089EE")]
		[FieldOffset(Offset = "0xA8")]
		private List<string> m_CodeList;

		// Token: 0x040089EF RID: 35311
		[Token(Token = "0x40089EF")]
		[FieldOffset(Offset = "0xB0")]
		private List<UILabel> m_CodeLabels;

		// Token: 0x040089F0 RID: 35312
		[Token(Token = "0x40089F0")]
		[FieldOffset(Offset = "0xB8")]
		private List<UIToggleButton> m_ToggleList;

		// Token: 0x040089F1 RID: 35313
		[Token(Token = "0x40089F1")]
		[FieldOffset(Offset = "0xC0")]
		private List<GameObject> m_Items;

		// Token: 0x040089F2 RID: 35314
		[Token(Token = "0x40089F2")]
		[FieldOffset(Offset = "0xC8")]
		private Color m_TextColor;
	}
}
