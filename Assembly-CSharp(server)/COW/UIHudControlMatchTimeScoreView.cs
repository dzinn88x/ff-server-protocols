using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200229E RID: 8862
	[Token(Token = "0x200229E")]
	public class UIHudControlMatchTimeScoreView : UIBaseView
	{
		// Token: 0x0600C04D RID: 49229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04D")]
		[Address(RVA = "0x1A95434", Offset = "0x1A95434", VA = "0x7BBC295434", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C04E RID: 49230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C04E")]
		[Address(RVA = "0x1A95888", Offset = "0x1A95888", VA = "0x7BBC295888")]
		public UIHudControlMatchTimeScoreView()
		{
		}

		// Token: 0x0400D4B2 RID: 54450
		[Token(Token = "0x400D4B2")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnLeaderboard;

		// Token: 0x0400D4B3 RID: 54451
		[Token(Token = "0x400D4B3")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ActivatingPoint;

		// Token: 0x0400D4B4 RID: 54452
		[Token(Token = "0x400D4B4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject NoActivatingPoint;

		// Token: 0x0400D4B5 RID: 54453
		[Token(Token = "0x400D4B5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel time;

		// Token: 0x0400D4B6 RID: 54454
		[Token(Token = "0x400D4B6")]
		[FieldOffset(Offset = "0x40")]
		public UILabel targetScore;

		// Token: 0x0400D4B7 RID: 54455
		[Token(Token = "0x400D4B7")]
		[FieldOffset(Offset = "0x48")]
		public UISprite NormalState;

		// Token: 0x0400D4B8 RID: 54456
		[Token(Token = "0x400D4B8")]
		[FieldOffset(Offset = "0x50")]
		public UISprite NormalStateLight;

		// Token: 0x0400D4B9 RID: 54457
		[Token(Token = "0x400D4B9")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ScrambleState;

		// Token: 0x0400D4BA RID: 54458
		[Token(Token = "0x400D4BA")]
		[FieldOffset(Offset = "0x60")]
		public GameObject PingJuEffect;

		// Token: 0x0400D4BB RID: 54459
		[Token(Token = "0x400D4BB")]
		[FieldOffset(Offset = "0x68")]
		public GameObject GetScoreVFX_Local;

		// Token: 0x0400D4BC RID: 54460
		[Token(Token = "0x400D4BC")]
		[FieldOffset(Offset = "0x70")]
		public GameObject GetScoreVFX_Opp;

		// Token: 0x0400D4BD RID: 54461
		[Token(Token = "0x400D4BD")]
		[FieldOffset(Offset = "0x78")]
		public GameObject OccupyVFX_Local;

		// Token: 0x0400D4BE RID: 54462
		[Token(Token = "0x400D4BE")]
		[FieldOffset(Offset = "0x80")]
		public GameObject OccupyVFX_Opp;

		// Token: 0x0400D4BF RID: 54463
		[Token(Token = "0x400D4BF")]
		[FieldOffset(Offset = "0x88")]
		public UILabel LocalTeamScore;

		// Token: 0x0400D4C0 RID: 54464
		[Token(Token = "0x400D4C0")]
		[FieldOffset(Offset = "0x90")]
		public UIProgressBar LocalTeamScoreBar;

		// Token: 0x0400D4C1 RID: 54465
		[Token(Token = "0x400D4C1")]
		[FieldOffset(Offset = "0x98")]
		public UILabel OppTeamScore;

		// Token: 0x0400D4C2 RID: 54466
		[Token(Token = "0x400D4C2")]
		[FieldOffset(Offset = "0xA0")]
		public UIProgressBar OppTeamScoreBar;
	}
}
