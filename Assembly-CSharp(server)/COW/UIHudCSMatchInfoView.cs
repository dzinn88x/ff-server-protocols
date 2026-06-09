using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022A9 RID: 8873
	[Token(Token = "0x20022A9")]
	internal class UIHudCSMatchInfoView : UIBaseView
	{
		// Token: 0x0600C063 RID: 49251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C063")]
		[Address(RVA = "0x19C0A44", Offset = "0x19C0A44", VA = "0x7BBC1C0A44", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C064 RID: 49252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C064")]
		[Address(RVA = "0x19C0C54", Offset = "0x19C0C54", VA = "0x7BBC1C0C54")]
		public UIHudCSMatchInfoView()
		{
		}

		// Token: 0x0400D523 RID: 54563
		[Token(Token = "0x400D523")]
		[FieldOffset(Offset = "0x20")]
		public Transform myTeam;

		// Token: 0x0400D524 RID: 54564
		[Token(Token = "0x400D524")]
		[FieldOffset(Offset = "0x28")]
		public Transform oppoTeam;

		// Token: 0x0400D525 RID: 54565
		[Token(Token = "0x400D525")]
		[FieldOffset(Offset = "0x30")]
		public UILabel myWinNum;

		// Token: 0x0400D526 RID: 54566
		[Token(Token = "0x400D526")]
		[FieldOffset(Offset = "0x38")]
		public UILabel remainTime;

		// Token: 0x0400D527 RID: 54567
		[Token(Token = "0x400D527")]
		[FieldOffset(Offset = "0x40")]
		public UILabel oppoWinNum;

		// Token: 0x0400D528 RID: 54568
		[Token(Token = "0x400D528")]
		[FieldOffset(Offset = "0x48")]
		public UILabel curRound;

		// Token: 0x0400D529 RID: 54569
		[Token(Token = "0x400D529")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnLeaderboard;
	}
}
