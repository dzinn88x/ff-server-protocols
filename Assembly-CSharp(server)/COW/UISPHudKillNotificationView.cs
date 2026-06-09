using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002517 RID: 9495
	[Token(Token = "0x2002517")]
	internal class UISPHudKillNotificationView : UIBaseView
	{
		// Token: 0x0600C53E RID: 50494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53E")]
		[Address(RVA = "0x1EE9608", Offset = "0x1EE9608", VA = "0x7BBC6E9608", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C53F RID: 50495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C53F")]
		[Address(RVA = "0x1EE97F0", Offset = "0x1EE97F0", VA = "0x7BBC6E97F0")]
		public UISPHudKillNotificationView()
		{
		}

		// Token: 0x0400F26D RID: 62061
		[Token(Token = "0x400F26D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject DebugBtns;

		// Token: 0x0400F26E RID: 62062
		[Token(Token = "0x400F26E")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BlueTestBtn;

		// Token: 0x0400F26F RID: 62063
		[Token(Token = "0x400F26F")]
		[FieldOffset(Offset = "0x30")]
		public UIButton RedTestBtn;

		// Token: 0x0400F270 RID: 62064
		[Token(Token = "0x400F270")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid NotificationListGrid;

		// Token: 0x0400F271 RID: 62065
		[Token(Token = "0x400F271")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TeamAceContainer;

		// Token: 0x0400F272 RID: 62066
		[Token(Token = "0x400F272")]
		[FieldOffset(Offset = "0x48")]
		public GameObject GameAchievementContainer;
	}
}
