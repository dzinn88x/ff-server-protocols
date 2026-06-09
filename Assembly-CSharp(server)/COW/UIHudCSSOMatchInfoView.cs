using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B3 RID: 8883
	[Token(Token = "0x20022B3")]
	public class UIHudCSSOMatchInfoView : UIBaseView
	{
		// Token: 0x0600C076 RID: 49270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C076")]
		[Address(RVA = "0x19C8D28", Offset = "0x19C8D28", VA = "0x7BBC1C8D28", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C077 RID: 49271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C077")]
		[Address(RVA = "0x19C9008", Offset = "0x19C9008", VA = "0x7BBC1C9008")]
		public UIHudCSSOMatchInfoView()
		{
		}

		// Token: 0x0400D56F RID: 54639
		[Token(Token = "0x400D56F")]
		[FieldOffset(Offset = "0x20")]
		public GameObject BattleContainer;

		// Token: 0x0400D570 RID: 54640
		[Token(Token = "0x400D570")]
		[FieldOffset(Offset = "0x28")]
		public Transform myTeam;

		// Token: 0x0400D571 RID: 54641
		[Token(Token = "0x400D571")]
		[FieldOffset(Offset = "0x30")]
		public Transform oppoTeam;

		// Token: 0x0400D572 RID: 54642
		[Token(Token = "0x400D572")]
		[FieldOffset(Offset = "0x38")]
		public UILabel curRound;

		// Token: 0x0400D573 RID: 54643
		[Token(Token = "0x400D573")]
		[FieldOffset(Offset = "0x40")]
		public UILabel remainTime;

		// Token: 0x0400D574 RID: 54644
		[Token(Token = "0x400D574")]
		[FieldOffset(Offset = "0x48")]
		public Transform MyTeamHP;

		// Token: 0x0400D575 RID: 54645
		[Token(Token = "0x400D575")]
		[FieldOffset(Offset = "0x50")]
		public Transform OppoTeamHP;

		// Token: 0x0400D576 RID: 54646
		[Token(Token = "0x400D576")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WaitingContainer;

		// Token: 0x0400D577 RID: 54647
		[Token(Token = "0x400D577")]
		[FieldOffset(Offset = "0x60")]
		public UILabel waiting;

		// Token: 0x0400D578 RID: 54648
		[Token(Token = "0x400D578")]
		[FieldOffset(Offset = "0x68")]
		public UILabel tips;

		// Token: 0x0400D579 RID: 54649
		[Token(Token = "0x400D579")]
		[FieldOffset(Offset = "0x70")]
		public UIButton BtnLeaderboard;
	}
}
