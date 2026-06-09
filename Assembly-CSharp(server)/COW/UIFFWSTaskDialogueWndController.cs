using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200136C RID: 4972
	[Token(Token = "0x200136C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB4A8", Offset = "0x10EB4A8")]
	public class UIFFWSTaskDialogueWndController : UIPopupWindowController
	{
		// Token: 0x06004FA7 RID: 20391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA7")]
		[Address(RVA = "0x228CAC4", Offset = "0x228CAC4", VA = "0x7BBCA8CAC4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00018390 File Offset: 0x00016590
		[Token(Token = "0x6004FA8")]
		[Address(RVA = "0x228CCB0", Offset = "0x228CCB0", VA = "0x7BBCA8CCB0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FA9")]
		[Address(RVA = "0x228CC08", Offset = "0x228CC08", VA = "0x7BBCA8CC08")]
		public void InitView()
		{
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAA")]
		[Address(RVA = "0x228CD00", Offset = "0x228CD00", VA = "0x7BBCA8CD00")]
		public void ShowFirstDialogue()
		{
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAB")]
		[Address(RVA = "0x228CDEC", Offset = "0x228CDEC", VA = "0x7BBCA8CDEC")]
		public void SetData([Optional] FFWSSpecialTaskTextDesc desc)
		{
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAC")]
		[Address(RVA = "0x228CFF8", Offset = "0x228CFF8", VA = "0x7BBCA8CFF8")]
		private void OnContinueClick()
		{
		}

		// Token: 0x06004FAD RID: 20397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAD")]
		[Address(RVA = "0x228D1BC", Offset = "0x228D1BC", VA = "0x7BBCA8D1BC")]
		private void OnAcceptClick()
		{
		}

		// Token: 0x06004FAE RID: 20398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FAE")]
		[Address(RVA = "0x228D1C4", Offset = "0x228D1C4", VA = "0x7BBCA8D1C4")]
		public UIFFWSTaskDialogueWndController()
		{
		}

		// Token: 0x04007650 RID: 30288
		[Token(Token = "0x4007650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIFFWSTaskDialogueWndView m_View;

		// Token: 0x04007651 RID: 30289
		[Token(Token = "0x4007651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int m_TaskTextIndex;

		// Token: 0x04007652 RID: 30290
		[Token(Token = "0x4007652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<string> m_TaskTextList;
	}
}
