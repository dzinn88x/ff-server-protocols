using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001472 RID: 5234
	[Token(Token = "0x2001472")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECDD8", Offset = "0x10ECDD8")]
	public class UIChampionshipEmulatorErrorWndController : UIPopupWindowController
	{
		// Token: 0x06005838 RID: 22584 RVA: 0x0001A0A0 File Offset: 0x000182A0
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x1C30134", Offset = "0x1C30134", VA = "0x7BBC430134")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005839")]
		[Address(RVA = "0x1C30184", Offset = "0x1C30184", VA = "0x7BBC430184", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583A")]
		[Address(RVA = "0x1C30268", Offset = "0x1C30268", VA = "0x7BBC430268")]
		public void SetInfo(string message, bool needLogout = false)
		{
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583B")]
		[Address(RVA = "0x1C302CC", Offset = "0x1C302CC", VA = "0x7BBC4302CC", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583C")]
		[Address(RVA = "0x1C3038C", Offset = "0x1C3038C", VA = "0x7BBC43038C")]
		public UIChampionshipEmulatorErrorWndController()
		{
		}

		// Token: 0x04007C29 RID: 31785
		[Token(Token = "0x4007C29")]
		[FieldOffset(Offset = "0x98")]
		private UIChampionshipEmulatorErrorWndView m_View;

		// Token: 0x04007C2A RID: 31786
		[Token(Token = "0x4007C2A")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_NeedLogout;
	}
}
