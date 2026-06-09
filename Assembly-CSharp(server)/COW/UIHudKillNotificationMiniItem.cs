using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C51 RID: 7249
	[Token(Token = "0x2001C51")]
	internal class UIHudKillNotificationMiniItem : UIHudKillNotificationItem
	{
		// Token: 0x06009DAE RID: 40366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DAE")]
		[Address(RVA = "0x1C52DDC", Offset = "0x1C52DDC", VA = "0x7BBC452DDC", Slot = "4")]
		public override void SetKillInfo(float gameTime, PendingNotification notification)
		{
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DAF")]
		[Address(RVA = "0x1C52EB8", Offset = "0x1C52EB8", VA = "0x7BBC452EB8")]
		private void UpdateKillIcon(EPendingNotificationType type)
		{
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009DB0")]
		[Address(RVA = "0x1C530B4", Offset = "0x1C530B4", VA = "0x7BBC4530B4")]
		public UIHudKillNotificationMiniItem()
		{
		}

		// Token: 0x0400A3EE RID: 41966
		[Token(Token = "0x400A3EE")]
		[FieldOffset(Offset = "0x60")]
		public UISprite killIcon;

		// Token: 0x0400A3EF RID: 41967
		[Token(Token = "0x400A3EF")]
		[FieldOffset(Offset = "0x68")]
		private string[][] m_SpriteName;
	}
}
