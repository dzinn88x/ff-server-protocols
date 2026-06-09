using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002274 RID: 8820
	[Token(Token = "0x2002274")]
	public class UIHudBanknoteMatchTimeScoreView : UIBaseView
	{
		// Token: 0x0600BFF9 RID: 49145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFF9")]
		[Address(RVA = "0x18902FC", Offset = "0x18902FC", VA = "0x7BBC0902FC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFFA")]
		[Address(RVA = "0x18907F0", Offset = "0x18907F0", VA = "0x7BBC0907F0")]
		public UIHudBanknoteMatchTimeScoreView()
		{
		}

		// Token: 0x0400D3BE RID: 54206
		[Token(Token = "0x400D3BE")]
		[FieldOffset(Offset = "0x20")]
		public GameObject NoActivatingPoint;

		// Token: 0x0400D3BF RID: 54207
		[Token(Token = "0x400D3BF")]
		[FieldOffset(Offset = "0x28")]
		public UIButton BtnLeaderboard;

		// Token: 0x0400D3C0 RID: 54208
		[Token(Token = "0x400D3C0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ActivatingPoint;

		// Token: 0x0400D3C1 RID: 54209
		[Token(Token = "0x400D3C1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel time;

		// Token: 0x0400D3C2 RID: 54210
		[Token(Token = "0x400D3C2")]
		[FieldOffset(Offset = "0x40")]
		public UILabel targetScore;

		// Token: 0x0400D3C3 RID: 54211
		[Token(Token = "0x400D3C3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject PingJuEffect;

		// Token: 0x0400D3C4 RID: 54212
		[Token(Token = "0x400D3C4")]
		[FieldOffset(Offset = "0x50")]
		public GameObject NoOccupyState;

		// Token: 0x0400D3C5 RID: 54213
		[Token(Token = "0x400D3C5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject LocalOccupyState;

		// Token: 0x0400D3C6 RID: 54214
		[Token(Token = "0x400D3C6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject OppOccupyState;

		// Token: 0x0400D3C7 RID: 54215
		[Token(Token = "0x400D3C7")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ScambleState;

		// Token: 0x0400D3C8 RID: 54216
		[Token(Token = "0x400D3C8")]
		[FieldOffset(Offset = "0x70")]
		public GameObject GetScoreVFX_Local;

		// Token: 0x0400D3C9 RID: 54217
		[Token(Token = "0x400D3C9")]
		[FieldOffset(Offset = "0x78")]
		public GameObject GetScoreVFX_Opp;

		// Token: 0x0400D3CA RID: 54218
		[Token(Token = "0x400D3CA")]
		[FieldOffset(Offset = "0x80")]
		public GameObject OccupyVFX_Local;

		// Token: 0x0400D3CB RID: 54219
		[Token(Token = "0x400D3CB")]
		[FieldOffset(Offset = "0x88")]
		public GameObject OccupyVFX_Opp;

		// Token: 0x0400D3CC RID: 54220
		[Token(Token = "0x400D3CC")]
		[FieldOffset(Offset = "0x90")]
		public UIProgressBar LocalTeamScoreBar;

		// Token: 0x0400D3CD RID: 54221
		[Token(Token = "0x400D3CD")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LocalTeamScore;

		// Token: 0x0400D3CE RID: 54222
		[Token(Token = "0x400D3CE")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LocalMinusScore;

		// Token: 0x0400D3CF RID: 54223
		[Token(Token = "0x400D3CF")]
		[FieldOffset(Offset = "0xA8")]
		public UIProgressBar OppTeamScoreBar;

		// Token: 0x0400D3D0 RID: 54224
		[Token(Token = "0x400D3D0")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel OppTeamScore;

		// Token: 0x0400D3D1 RID: 54225
		[Token(Token = "0x400D3D1")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel OppMinusScore;
	}
}
