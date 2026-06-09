using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022DD RID: 8925
	[Token(Token = "0x20022DD")]
	public class UIHudGiantMatchInfoView : UIBaseView
	{
		// Token: 0x0600C0CA RID: 49354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0CA")]
		[Address(RVA = "0x19743A0", Offset = "0x19743A0", VA = "0x7BBC1743A0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0CB")]
		[Address(RVA = "0x1974634", Offset = "0x1974634", VA = "0x7BBC174634")]
		public UIHudGiantMatchInfoView()
		{
		}

		// Token: 0x0400D6D2 RID: 54994
		[Token(Token = "0x400D6D2")]
		[FieldOffset(Offset = "0x20")]
		public Transform myTeam;

		// Token: 0x0400D6D3 RID: 54995
		[Token(Token = "0x400D6D3")]
		[FieldOffset(Offset = "0x28")]
		public Transform oppoTeam;

		// Token: 0x0400D6D4 RID: 54996
		[Token(Token = "0x400D6D4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel myWinNum;

		// Token: 0x0400D6D5 RID: 54997
		[Token(Token = "0x400D6D5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel remainTime;

		// Token: 0x0400D6D6 RID: 54998
		[Token(Token = "0x400D6D6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel oppoWinNum;

		// Token: 0x0400D6D7 RID: 54999
		[Token(Token = "0x400D6D7")]
		[FieldOffset(Offset = "0x48")]
		public UILabel curRound;

		// Token: 0x0400D6D8 RID: 55000
		[Token(Token = "0x400D6D8")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Team1ShowSpr;

		// Token: 0x0400D6D9 RID: 55001
		[Token(Token = "0x400D6D9")]
		[FieldOffset(Offset = "0x58")]
		public UISprite Team2ShowSpr;

		// Token: 0x0400D6DA RID: 55002
		[Token(Token = "0x400D6DA")]
		[FieldOffset(Offset = "0x60")]
		public UIButton BtnLeaderboard;
	}
}
