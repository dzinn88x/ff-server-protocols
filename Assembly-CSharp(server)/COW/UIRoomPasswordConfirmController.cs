using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001B6C RID: 7020
	[Token(Token = "0x2001B6C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA024", Offset = "0x10FA024")]
	public class UIRoomPasswordConfirmController : UIPopupWindowController
	{
		// Token: 0x06009723 RID: 38691 RVA: 0x00027E28 File Offset: 0x00026028
		[Token(Token = "0x6009723")]
		[Address(RVA = "0x1A1E2B8", Offset = "0x1A1E2B8", VA = "0x7BBC21E2B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009724")]
		[Address(RVA = "0x1A1E308", Offset = "0x1A1E308", VA = "0x7BBC21E308", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009725")]
		[Address(RVA = "0x1A16E94", Offset = "0x1A16E94", VA = "0x7BBC216E94")]
		public void SetUIStyle(UIRoomPasswordConfirmController.UIStyle style)
		{
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009726")]
		[Address(RVA = "0x1A16F68", Offset = "0x1A16F68", VA = "0x7BBC216F68")]
		public void SetConfirmCallback(Action<string, string, string> callback)
		{
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009727")]
		[Address(RVA = "0x1A1E444", Offset = "0x1A1E444", VA = "0x7BBC21E444")]
		private void OnBtnConfirm()
		{
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009728")]
		[Address(RVA = "0x1A1EB1C", Offset = "0x1A1EB1C", VA = "0x7BBC21EB1C")]
		private void OnBtnClose()
		{
		}

		// Token: 0x06009729 RID: 38697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009729")]
		[Address(RVA = "0x1A1EB24", Offset = "0x1A1EB24", VA = "0x7BBC21EB24")]
		public UIRoomPasswordConfirmController()
		{
		}

		// Token: 0x04009F62 RID: 40802
		[Token(Token = "0x4009F62")]
		[FieldOffset(Offset = "0x98")]
		private UIRoomPasswordConfirmView m_View;

		// Token: 0x04009F63 RID: 40803
		[Token(Token = "0x4009F63")]
		[FieldOffset(Offset = "0xA0")]
		private Action<string, string, string> m_ConfirmCallback;

		// Token: 0x04009F64 RID: 40804
		[Token(Token = "0x4009F64")]
		[FieldOffset(Offset = "0xA8")]
		private UIRoomPasswordConfirmController.UIStyle m_Style;

		// Token: 0x02001B6D RID: 7021
		[Token(Token = "0x2001B6D")]
		public enum UIStyle
		{
			// Token: 0x04009F66 RID: 40806
			[Token(Token = "0x4009F66")]
			PasswordOnly,
			// Token: 0x04009F67 RID: 40807
			[Token(Token = "0x4009F67")]
			GroupNameAndPassword
		}
	}
}
