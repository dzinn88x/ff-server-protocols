using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001438 RID: 5176
	[Token(Token = "0x2001438")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECA48", Offset = "0x10ECA48")]
	public class UIAwakenRefreshTaskConfirmController : UIPopupWindowController
	{
		// Token: 0x060055E8 RID: 21992 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x60055E8")]
		[Address(RVA = "0x141C3F4", Offset = "0x141C3F4", VA = "0x7BBBC1C3F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060055E9 RID: 21993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055E9")]
		[Address(RVA = "0x141C444", Offset = "0x141C444", VA = "0x7BBBC1C444", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060055EA RID: 21994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EA")]
		[Address(RVA = "0x141C580", Offset = "0x141C580", VA = "0x7BBBC1C580")]
		protected void OnCancelClick()
		{
		}

		// Token: 0x060055EB RID: 21995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EB")]
		[Address(RVA = "0x141C5B4", Offset = "0x141C5B4", VA = "0x7BBBC1C5B4")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x060055EC RID: 21996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EC")]
		[Address(RVA = "0x141C5E8", Offset = "0x141C5E8", VA = "0x7BBBC1C5E8")]
		public void SetData(string content)
		{
		}

		// Token: 0x060055ED RID: 21997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055ED")]
		[Address(RVA = "0x141C6D0", Offset = "0x141C6D0", VA = "0x7BBBC1C6D0")]
		public void SetConfirmCallback(Action action)
		{
		}

		// Token: 0x060055EE RID: 21998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EE")]
		[Address(RVA = "0x141C6D8", Offset = "0x141C6D8", VA = "0x7BBBC1C6D8")]
		public void SetCancelCallback(Action action)
		{
		}

		// Token: 0x060055EF RID: 21999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055EF")]
		[Address(RVA = "0x141C6E0", Offset = "0x141C6E0", VA = "0x7BBBC1C6E0")]
		public UIAwakenRefreshTaskConfirmController()
		{
		}

		// Token: 0x04007AAE RID: 31406
		[Token(Token = "0x4007AAE")]
		[FieldOffset(Offset = "0x98")]
		private UIAwakenRefreshTaskConfirmWndView m_View;

		// Token: 0x04007AAF RID: 31407
		[Token(Token = "0x4007AAF")]
		[FieldOffset(Offset = "0xA0")]
		private Action m_CancelAction;

		// Token: 0x04007AB0 RID: 31408
		[Token(Token = "0x4007AB0")]
		[FieldOffset(Offset = "0xA8")]
		private Action m_ConfirmAction;
	}
}
