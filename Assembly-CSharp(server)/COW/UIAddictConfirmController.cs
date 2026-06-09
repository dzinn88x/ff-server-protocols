using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016A0 RID: 5792
	[Token(Token = "0x20016A0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F0764", Offset = "0x10F0764")]
	public class UIAddictConfirmController : UIPopupWindowController
	{
		// Token: 0x06006980 RID: 27008 RVA: 0x0001DE80 File Offset: 0x0001C080
		[Token(Token = "0x6006980")]
		[Address(RVA = "0x1968CAC", Offset = "0x1968CAC", VA = "0x7BBC168CAC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006981")]
		[Address(RVA = "0x1968CFC", Offset = "0x1968CFC", VA = "0x7BBC168CFC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006982")]
		[Address(RVA = "0x1968E28", Offset = "0x1968E28", VA = "0x7BBC168E28")]
		private void OnConfirmBtnClick()
		{
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006983")]
		[Address(RVA = "0x1968E30", Offset = "0x1968E30", VA = "0x7BBC168E30")]
		public void ShowGuide(string message, string tipmessage)
		{
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006984")]
		[Address(RVA = "0x1968EB8", Offset = "0x1968EB8", VA = "0x7BBC168EB8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006985")]
		[Address(RVA = "0x1968EC0", Offset = "0x1968EC0", VA = "0x7BBC168EC0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006986")]
		[Address(RVA = "0x1968EC8", Offset = "0x1968EC8", VA = "0x7BBC168EC8", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006987")]
		[Address(RVA = "0x1968ED0", Offset = "0x1968ED0", VA = "0x7BBC168ED0")]
		public UIAddictConfirmController()
		{
		}

		// Token: 0x04008661 RID: 34401
		[Token(Token = "0x4008661")]
		[FieldOffset(Offset = "0x98")]
		private UIAddictConfirmView m_View;
	}
}
