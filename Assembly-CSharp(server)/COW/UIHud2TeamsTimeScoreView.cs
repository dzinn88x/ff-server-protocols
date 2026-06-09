using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002257 RID: 8791
	[Token(Token = "0x2002257")]
	public class UIHud2TeamsTimeScoreView : UIBaseView
	{
		// Token: 0x0600BFBF RID: 49087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFBF")]
		[Address(RVA = "0x1D615F8", Offset = "0x1D615F8", VA = "0x7BBC5615F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFC0")]
		[Address(RVA = "0x1D6185C", Offset = "0x1D6185C", VA = "0x7BBC56185C")]
		public UIHud2TeamsTimeScoreView()
		{
		}

		// Token: 0x0400D31D RID: 54045
		[Token(Token = "0x400D31D")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnLeaderboard;

		// Token: 0x0400D31E RID: 54046
		[Token(Token = "0x400D31E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel team1Score;

		// Token: 0x0400D31F RID: 54047
		[Token(Token = "0x400D31F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel time;

		// Token: 0x0400D320 RID: 54048
		[Token(Token = "0x400D320")]
		[FieldOffset(Offset = "0x38")]
		public UILabel team2Score;

		// Token: 0x0400D321 RID: 54049
		[Token(Token = "0x400D321")]
		[FieldOffset(Offset = "0x40")]
		public UILabel targetScore;

		// Token: 0x0400D322 RID: 54050
		[Token(Token = "0x400D322")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Effect1;

		// Token: 0x0400D323 RID: 54051
		[Token(Token = "0x400D323")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Effect2;

		// Token: 0x0400D324 RID: 54052
		[Token(Token = "0x400D324")]
		[FieldOffset(Offset = "0x58")]
		public GameObject VFX_Team1Win;

		// Token: 0x0400D325 RID: 54053
		[Token(Token = "0x400D325")]
		[FieldOffset(Offset = "0x60")]
		public GameObject VFX_Team2Win;
	}
}
