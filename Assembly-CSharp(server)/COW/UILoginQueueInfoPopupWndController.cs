using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A29 RID: 6697
	[Token(Token = "0x2001A29")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7A44", Offset = "0x10F7A44")]
	public class UILoginQueueInfoPopupWndController : UIPopupWindowController
	{
		// Token: 0x06008C72 RID: 35954 RVA: 0x00025788 File Offset: 0x00023988
		[Token(Token = "0x6008C72")]
		[Address(RVA = "0x19E7990", Offset = "0x19E7990", VA = "0x7BBC1E7990")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008C73 RID: 35955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C73")]
		[Address(RVA = "0x19E79E0", Offset = "0x19E79E0", VA = "0x7BBC1E79E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C74")]
		[Address(RVA = "0x19E7B1C", Offset = "0x19E7B1C", VA = "0x7BBC1E7B1C")]
		public void UpdateQueueInfo(LoginQueueInfo info, bool IsNew = false)
		{
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C75")]
		[Address(RVA = "0x19E7CB4", Offset = "0x19E7CB4", VA = "0x7BBC1E7CB4")]
		private void SetCountDown(uint sec)
		{
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C76")]
		[Address(RVA = "0x19E7EB4", Offset = "0x19E7EB4", VA = "0x7BBC1E7EB4")]
		private void UpdateProgressBar()
		{
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C77")]
		[Address(RVA = "0x19E7F8C", Offset = "0x19E7F8C", VA = "0x7BBC1E7F8C")]
		private void ReRequestQueueInfo()
		{
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C78")]
		[Address(RVA = "0x19E7FBC", Offset = "0x19E7FBC", VA = "0x7BBC1E7FBC")]
		private void OnCancleClick()
		{
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x000257A0 File Offset: 0x000239A0
		[Token(Token = "0x6008C79")]
		[Address(RVA = "0x19E7FD0", Offset = "0x19E7FD0", VA = "0x7BBC1E7FD0", Slot = "36")]
		public override bool ClosedByEsc()
		{
			return default(bool);
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x000257B8 File Offset: 0x000239B8
		[Token(Token = "0x6008C7A")]
		[Address(RVA = "0x19E7FD8", Offset = "0x19E7FD8", VA = "0x7BBC1E7FD8", Slot = "37")]
		public override bool IgnoreEsc()
		{
			return default(bool);
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C7B")]
		[Address(RVA = "0x19E7FCC", Offset = "0x19E7FCC", VA = "0x7BBC1E7FCC")]
		private void ClearData()
		{
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008C7C")]
		[Address(RVA = "0x19E7FE0", Offset = "0x19E7FE0", VA = "0x7BBC1E7FE0")]
		public UILoginQueueInfoPopupWndController()
		{
		}

		// Token: 0x040098ED RID: 39149
		[Token(Token = "0x40098ED")]
		[FieldOffset(Offset = "0x98")]
		private UILoginQueueInfoPopupWndView m_View;

		// Token: 0x040098EE RID: 39150
		[Token(Token = "0x40098EE")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelLogin m_ModelLogin;

		// Token: 0x040098EF RID: 39151
		[Token(Token = "0x40098EF")]
		[FieldOffset(Offset = "0xA8")]
		private uint m_Hours;

		// Token: 0x040098F0 RID: 39152
		[Token(Token = "0x40098F0")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_Mins;

		// Token: 0x040098F1 RID: 39153
		[Token(Token = "0x40098F1")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_Secs;

		// Token: 0x040098F2 RID: 39154
		[Token(Token = "0x40098F2")]
		[FieldOffset(Offset = "0xB4")]
		private uint m_FirstFetchQueuePos;

		// Token: 0x040098F3 RID: 39155
		[Token(Token = "0x40098F3")]
		[FieldOffset(Offset = "0xB8")]
		private uint m_DelayCallID;

		// Token: 0x040098F4 RID: 39156
		[Token(Token = "0x40098F4")]
		[FieldOffset(Offset = "0xBC")]
		private uint m_RequestInterval;

		// Token: 0x040098F5 RID: 39157
		[Token(Token = "0x40098F5")]
		[FieldOffset(Offset = "0xC0")]
		private CountDownConfig m_Config;

		// Token: 0x040098F6 RID: 39158
		[Token(Token = "0x40098F6")]
		[FieldOffset(Offset = "0xC8")]
		private ulong m_StartCountDownTime;

		// Token: 0x040098F7 RID: 39159
		[Token(Token = "0x40098F7")]
		[FieldOffset(Offset = "0xD0")]
		private ulong m_TotalWaitSec;
	}
}
