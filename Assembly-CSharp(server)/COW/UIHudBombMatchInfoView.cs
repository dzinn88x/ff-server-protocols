using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002280 RID: 8832
	[Token(Token = "0x2002280")]
	public class UIHudBombMatchInfoView : UIBaseView
	{
		// Token: 0x0600C011 RID: 49169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C011")]
		[Address(RVA = "0x189C114", Offset = "0x189C114", VA = "0x7BBC09C114", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C012 RID: 49170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C012")]
		[Address(RVA = "0x189C498", Offset = "0x189C498", VA = "0x7BBC09C498")]
		public UIHudBombMatchInfoView()
		{
		}

		// Token: 0x0400D416 RID: 54294
		[Token(Token = "0x400D416")]
		[FieldOffset(Offset = "0x20")]
		public Transform myTeam;

		// Token: 0x0400D417 RID: 54295
		[Token(Token = "0x400D417")]
		[FieldOffset(Offset = "0x28")]
		public Transform oppoTeam;

		// Token: 0x0400D418 RID: 54296
		[Token(Token = "0x400D418")]
		[FieldOffset(Offset = "0x30")]
		public Animator SwitchAnimator;

		// Token: 0x0400D419 RID: 54297
		[Token(Token = "0x400D419")]
		[FieldOffset(Offset = "0x38")]
		public UILabel myWinNum;

		// Token: 0x0400D41A RID: 54298
		[Token(Token = "0x400D41A")]
		[FieldOffset(Offset = "0x40")]
		public UISprite myFaction;

		// Token: 0x0400D41B RID: 54299
		[Token(Token = "0x400D41B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite FixedMyFaction;

		// Token: 0x0400D41C RID: 54300
		[Token(Token = "0x400D41C")]
		[FieldOffset(Offset = "0x50")]
		public UILabel curRound;

		// Token: 0x0400D41D RID: 54301
		[Token(Token = "0x400D41D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite oppoFaction;

		// Token: 0x0400D41E RID: 54302
		[Token(Token = "0x400D41E")]
		[FieldOffset(Offset = "0x60")]
		public UILabel oppoWinNum;

		// Token: 0x0400D41F RID: 54303
		[Token(Token = "0x400D41F")]
		[FieldOffset(Offset = "0x68")]
		public UISprite FixedOppoFaction;

		// Token: 0x0400D420 RID: 54304
		[Token(Token = "0x400D420")]
		[FieldOffset(Offset = "0x70")]
		public ParticleSystem VFX_attack;

		// Token: 0x0400D421 RID: 54305
		[Token(Token = "0x400D421")]
		[FieldOffset(Offset = "0x78")]
		public ParticleSystem VFX_defense;

		// Token: 0x0400D422 RID: 54306
		[Token(Token = "0x400D422")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnLeaderboard;
	}
}
