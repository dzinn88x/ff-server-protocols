using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002511 RID: 9489
	[Token(Token = "0x2002511")]
	public class UISPHudGameAchievementView : UIBaseView
	{
		// Token: 0x0600C532 RID: 50482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C532")]
		[Address(RVA = "0x1EE7628", Offset = "0x1EE7628", VA = "0x7BBC6E7628", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C533 RID: 50483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C533")]
		[Address(RVA = "0x1EE7B88", Offset = "0x1EE7B88", VA = "0x7BBC6E7B88")]
		public UISPHudGameAchievementView()
		{
		}

		// Token: 0x0400F229 RID: 61993
		[Token(Token = "0x400F229")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget UISPHudGameAchievement;

		// Token: 0x0400F22A RID: 61994
		[Token(Token = "0x400F22A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite TeamSplashNEW;

		// Token: 0x0400F22B RID: 61995
		[Token(Token = "0x400F22B")]
		[FieldOffset(Offset = "0x30")]
		public UISprite TeamIcon;

		// Token: 0x0400F22C RID: 61996
		[Token(Token = "0x400F22C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F22D RID: 61997
		[Token(Token = "0x400F22D")]
		[FieldOffset(Offset = "0x40")]
		public UILabel KillCount;

		// Token: 0x0400F22E RID: 61998
		[Token(Token = "0x400F22E")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TeamNameNEW;

		// Token: 0x0400F22F RID: 61999
		[Token(Token = "0x400F22F")]
		[FieldOffset(Offset = "0x50")]
		public UISprite TeamSplashSHUT;

		// Token: 0x0400F230 RID: 62000
		[Token(Token = "0x400F230")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TeamNameSHUT;

		// Token: 0x0400F231 RID: 62001
		[Token(Token = "0x400F231")]
		[FieldOffset(Offset = "0x60")]
		public UISprite FirstBloodSplash;

		// Token: 0x0400F232 RID: 62002
		[Token(Token = "0x400F232")]
		[FieldOffset(Offset = "0x68")]
		public UIEffectSprite FBKillerTeamIcon;

		// Token: 0x0400F233 RID: 62003
		[Token(Token = "0x400F233")]
		[FieldOffset(Offset = "0x70")]
		public UISprite FBKillerTeamFakeIcon;

		// Token: 0x0400F234 RID: 62004
		[Token(Token = "0x400F234")]
		[FieldOffset(Offset = "0x78")]
		public UIEffectSprite FBBekillTeamIcon;

		// Token: 0x0400F235 RID: 62005
		[Token(Token = "0x400F235")]
		[FieldOffset(Offset = "0x80")]
		public UISprite FBBekillTeamFakeIcon;

		// Token: 0x0400F236 RID: 62006
		[Token(Token = "0x400F236")]
		[FieldOffset(Offset = "0x88")]
		public UILabel FirstBloodName;

		// Token: 0x0400F237 RID: 62007
		[Token(Token = "0x400F237")]
		[FieldOffset(Offset = "0x90")]
		public UISprite TeamSplashAce;

		// Token: 0x0400F238 RID: 62008
		[Token(Token = "0x400F238")]
		[FieldOffset(Offset = "0x98")]
		public UILabel TeamNameACE;

		// Token: 0x0400F239 RID: 62009
		[Token(Token = "0x400F239")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite MultiKillSplash;

		// Token: 0x0400F23A RID: 62010
		[Token(Token = "0x400F23A")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel MultiKillLabel;

		// Token: 0x0400F23B RID: 62011
		[Token(Token = "0x400F23B")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel MultiKillPlayerName;

		// Token: 0x0400F23C RID: 62012
		[Token(Token = "0x400F23C")]
		[FieldOffset(Offset = "0xB8")]
		public Transform MultiKillPlayerPicOB;

		// Token: 0x0400F23D RID: 62013
		[Token(Token = "0x400F23D")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite MultiKillPlayerIcon;

		// Token: 0x0400F23E RID: 62014
		[Token(Token = "0x400F23E")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject MultiKillPlayerFakeIcon;
	}
}
