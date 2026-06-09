using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002266 RID: 8806
	[Token(Token = "0x2002266")]
	public class UIHUDArmsRaceKillPointsView : UIBaseView
	{
		// Token: 0x0600BFDD RID: 49117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDD")]
		[Address(RVA = "0x16B1EE0", Offset = "0x16B1EE0", VA = "0x7BBBEB1EE0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFDE RID: 49118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFDE")]
		[Address(RVA = "0x16B2000", Offset = "0x16B2000", VA = "0x7BBBEB2000")]
		public UIHUDArmsRaceKillPointsView()
		{
		}

		// Token: 0x0400D36A RID: 54122
		[Token(Token = "0x400D36A")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid PointsGrid;

		// Token: 0x0400D36B RID: 54123
		[Token(Token = "0x400D36B")]
		[FieldOffset(Offset = "0x28")]
		public UIHUDArmsRacePointItem PointItem;

		// Token: 0x0400D36C RID: 54124
		[Token(Token = "0x400D36C")]
		[FieldOffset(Offset = "0x30")]
		public Animator KillLeaderEffect;
	}
}
