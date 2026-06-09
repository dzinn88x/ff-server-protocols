using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200197A RID: 6522
	[Token(Token = "0x200197A")]
	internal class UIHudTeamScoreNotificationController : UIHudKillNotificationBaseController
	{
		// Token: 0x060084EA RID: 34026 RVA: 0x00024078 File Offset: 0x00022278
		[Token(Token = "0x60084EA")]
		[Address(RVA = "0x15D9D6C", Offset = "0x15D9D6C", VA = "0x7BBBDD9D6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084EB")]
		[Address(RVA = "0x15D9DBC", Offset = "0x15D9DBC", VA = "0x7BBBDD9DBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084EC")]
		[Address(RVA = "0x15D9E20", Offset = "0x15D9E20", VA = "0x7BBBDD9E20", Slot = "30")]
		protected override void OnKill(Player killer, Player beKiller, params object[] param)
		{
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084ED")]
		[Address(RVA = "0x15DA13C", Offset = "0x15DA13C", VA = "0x7BBBDDA13C")]
		public UIHudTeamScoreNotificationController()
		{
		}

		// Token: 0x040094D6 RID: 38102
		[Token(Token = "0x40094D6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<int, uint> HYPELEVEL_COLOR;

		// Token: 0x040094D7 RID: 38103
		[Token(Token = "0x40094D7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly uint DEFAULT_COLOR;

		// Token: 0x040094D8 RID: 38104
		[Token(Token = "0x40094D8")]
		[FieldOffset(Offset = "0x68")]
		private UIHudTeamScoreNotificationView m_View;
	}
}
