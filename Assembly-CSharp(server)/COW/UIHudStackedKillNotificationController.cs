using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001965 RID: 6501
	[Token(Token = "0x2001965")]
	internal class UIHudStackedKillNotificationController : UIHudKillNotificationBaseController
	{
		// Token: 0x06008434 RID: 33844 RVA: 0x00023E38 File Offset: 0x00022038
		[Token(Token = "0x6008434")]
		[Address(RVA = "0x167350C", Offset = "0x167350C", VA = "0x7BBBE7350C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008435")]
		[Address(RVA = "0x167355C", Offset = "0x167355C", VA = "0x7BBBE7355C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008436")]
		[Address(RVA = "0x1673640", Offset = "0x1673640", VA = "0x7BBBE73640")]
		private void OnEscortBossRuinInfo(params object[] data)
		{
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008437")]
		[Address(RVA = "0x1673C7C", Offset = "0x1673C7C", VA = "0x7BBBE73C7C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008438 RID: 33848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008438")]
		[Address(RVA = "0x1673D48", Offset = "0x1673D48", VA = "0x7BBBE73D48", Slot = "30")]
		protected override void OnKill(Player killer, Player beKiller, params object[] param)
		{
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008439")]
		[Address(RVA = "0x16743EC", Offset = "0x16743EC", VA = "0x7BBBE743EC")]
		public UIHudStackedKillNotificationController()
		{
		}

		// Token: 0x040094A5 RID: 38053
		[Token(Token = "0x40094A5")]
		[FieldOffset(Offset = "0x68")]
		private UIHudStackedKillNotificationView m_View;

		// Token: 0x040094A6 RID: 38054
		[Token(Token = "0x40094A6")]
		[FieldOffset(Offset = "0x70")]
		private Color MY_COLOR;

		// Token: 0x040094A7 RID: 38055
		[Token(Token = "0x40094A7")]
		[FieldOffset(Offset = "0x80")]
		private Color ENEMY_COLOR;
	}
}
