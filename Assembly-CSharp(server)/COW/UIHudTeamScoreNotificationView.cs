using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200237C RID: 9084
	[Token(Token = "0x200237C")]
	public class UIHudTeamScoreNotificationView : UIBaseView
	{
		// Token: 0x0600C208 RID: 49672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C208")]
		[Address(RVA = "0x15DA2D8", Offset = "0x15DA2D8", VA = "0x7BBBDDA2D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C209 RID: 49673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C209")]
		[Address(RVA = "0x15DA374", Offset = "0x15DA374", VA = "0x7BBBDDA374")]
		public UIHudTeamScoreNotificationView()
		{
		}

		// Token: 0x0400DC6E RID: 56430
		[Token(Token = "0x400DC6E")]
		[FieldOffset(Offset = "0x20")]
		public UILabel content;
	}
}
