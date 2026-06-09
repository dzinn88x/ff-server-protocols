using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022FA RID: 8954
	[Token(Token = "0x20022FA")]
	internal class UIHudKillNotificationView : UIBaseView
	{
		// Token: 0x0600C104 RID: 49412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C104")]
		[Address(RVA = "0x1C53430", Offset = "0x1C53430", VA = "0x7BBC453430", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C105 RID: 49413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C105")]
		[Address(RVA = "0x1C535F8", Offset = "0x1C535F8", VA = "0x7BBC4535F8")]
		public UIHudKillNotificationView()
		{
		}

		// Token: 0x0400D7F6 RID: 55286
		[Token(Token = "0x400D7F6")]
		[FieldOffset(Offset = "0x20")]
		public UIHudKillNotificationItem Item1;

		// Token: 0x0400D7F7 RID: 55287
		[Token(Token = "0x400D7F7")]
		[FieldOffset(Offset = "0x28")]
		public UIHudKillNotificationItem Item2;

		// Token: 0x0400D7F8 RID: 55288
		[Token(Token = "0x400D7F8")]
		[FieldOffset(Offset = "0x30")]
		public UIHudKillNotificationItem Item3;

		// Token: 0x0400D7F9 RID: 55289
		[Token(Token = "0x400D7F9")]
		[FieldOffset(Offset = "0x38")]
		public UIHudKillNotificationItem MiniItem1;

		// Token: 0x0400D7FA RID: 55290
		[Token(Token = "0x400D7FA")]
		[FieldOffset(Offset = "0x40")]
		public UIHudKillNotificationItem MiniItem2;

		// Token: 0x0400D7FB RID: 55291
		[Token(Token = "0x400D7FB")]
		[FieldOffset(Offset = "0x48")]
		public UIHudKillNotificationItem MiniItem3;
	}
}
