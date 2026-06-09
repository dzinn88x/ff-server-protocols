using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013FB RID: 5115
	[Token(Token = "0x20013FB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC3E0", Offset = "0x10EC3E0")]
	public class UIActivityOverviewItemController : UIBaseController
	{
		// Token: 0x06005426 RID: 21542 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x6005426")]
		[Address(RVA = "0x1957260", Offset = "0x1957260", VA = "0x7BBC157260")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005427 RID: 21543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005427")]
		[Address(RVA = "0x19572B0", Offset = "0x19572B0", VA = "0x7BBC1572B0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005428 RID: 21544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005428")]
		[Address(RVA = "0x1956F2C", Offset = "0x1956F2C", VA = "0x7BBC156F2C")]
		public void SetData(AdvertDesc data)
		{
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005429")]
		[Address(RVA = "0x19574D0", Offset = "0x19574D0", VA = "0x7BBC1574D0")]
		private void UpdateView()
		{
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542A")]
		[Address(RVA = "0x1957B84", Offset = "0x1957B84", VA = "0x7BBC157B84")]
		private void OnGoToClick()
		{
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542B")]
		[Address(RVA = "0x1957E14", Offset = "0x1957E14", VA = "0x7BBC157E14")]
		private void SendBannerClickLog(uint id)
		{
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542C")]
		[Address(RVA = "0x195713C", Offset = "0x195713C", VA = "0x7BBC15713C")]
		public void Reload()
		{
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600542D")]
		[Address(RVA = "0x1957F88", Offset = "0x1957F88", VA = "0x7BBC157F88")]
		public UIActivityOverviewItemController()
		{
		}

		// Token: 0x0400799E RID: 31134
		[Token(Token = "0x400799E")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityOverviewItemView m_View;

		// Token: 0x0400799F RID: 31135
		[Token(Token = "0x400799F")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040079A0 RID: 31136
		[Token(Token = "0x40079A0")]
		[FieldOffset(Offset = "0x68")]
		private AdvertDesc m_Data;

		// Token: 0x040079A1 RID: 31137
		[Token(Token = "0x40079A1")]
		[FieldOffset(Offset = "0x70")]
		private ClientActivityDesc m_OverViewDesc;

		// Token: 0x040079A2 RID: 31138
		[Token(Token = "0x40079A2")]
		private const string COMING_STRING = "TXT_OB8_GXQ_EVENT_NOTSTARTED";

		// Token: 0x040079A3 RID: 31139
		[Token(Token = "0x40079A3")]
		private const string ACTIVE_STRING = "TXT_LOBBY_EVENT_GOTO";

		// Token: 0x040079A4 RID: 31140
		[Token(Token = "0x40079A4")]
		private const string EXPIRED_STRING = "TXT_OB9_GXQ_GIFTMALL_TIMEOUT";

		// Token: 0x040079A5 RID: 31141
		[Token(Token = "0x40079A5")]
		[FieldOffset(Offset = "0x78")]
		private UIActivityOverviewItemController.EActivityState m_ActivityState;

		// Token: 0x020013FC RID: 5116
		[Token(Token = "0x20013FC")]
		public enum EActivityState
		{
			// Token: 0x040079A7 RID: 31143
			[Token(Token = "0x40079A7")]
			Coming,
			// Token: 0x040079A8 RID: 31144
			[Token(Token = "0x40079A8")]
			Normal,
			// Token: 0x040079A9 RID: 31145
			[Token(Token = "0x40079A9")]
			Expired
		}
	}
}
