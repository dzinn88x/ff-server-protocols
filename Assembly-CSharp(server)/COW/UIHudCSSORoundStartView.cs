using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B5 RID: 8885
	[Token(Token = "0x20022B5")]
	public class UIHudCSSORoundStartView : UIBaseView
	{
		// Token: 0x0600C07A RID: 49274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C07A")]
		[Address(RVA = "0x19CC3D0", Offset = "0x19CC3D0", VA = "0x7BBC1CC3D0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C07B RID: 49275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C07B")]
		[Address(RVA = "0x19CC7D4", Offset = "0x19CC7D4", VA = "0x7BBC1CC7D4")]
		public UIHudCSSORoundStartView()
		{
		}

		// Token: 0x0400D58D RID: 54669
		[Token(Token = "0x400D58D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject RoundStartContainer;

		// Token: 0x0400D58E RID: 54670
		[Token(Token = "0x400D58E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RoundNum;

		// Token: 0x0400D58F RID: 54671
		[Token(Token = "0x400D58F")]
		[FieldOffset(Offset = "0x30")]
		public UILabel GamezoneName;

		// Token: 0x0400D590 RID: 54672
		[Token(Token = "0x400D590")]
		[FieldOffset(Offset = "0x38")]
		public UILabel MyTeamRank;

		// Token: 0x0400D591 RID: 54673
		[Token(Token = "0x400D591")]
		[FieldOffset(Offset = "0x40")]
		public UILabel OppoTeamRank;

		// Token: 0x0400D592 RID: 54674
		[Token(Token = "0x400D592")]
		[FieldOffset(Offset = "0x48")]
		public GameObject NormalNum;

		// Token: 0x0400D593 RID: 54675
		[Token(Token = "0x400D593")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SpecialNum;

		// Token: 0x0400D594 RID: 54676
		[Token(Token = "0x400D594")]
		[FieldOffset(Offset = "0x58")]
		public UISprite PlayerNum;

		// Token: 0x0400D595 RID: 54677
		[Token(Token = "0x400D595")]
		[FieldOffset(Offset = "0x60")]
		public UISprite PlayerNum2;

		// Token: 0x0400D596 RID: 54678
		[Token(Token = "0x400D596")]
		[FieldOffset(Offset = "0x68")]
		public UIHudCSSOTeamInfoView MyFaction;

		// Token: 0x0400D597 RID: 54679
		[Token(Token = "0x400D597")]
		[FieldOffset(Offset = "0x70")]
		public GameObject MyFactionHP;

		// Token: 0x0400D598 RID: 54680
		[Token(Token = "0x400D598")]
		[FieldOffset(Offset = "0x78")]
		public UILabel MyTeamLabel;

		// Token: 0x0400D599 RID: 54681
		[Token(Token = "0x400D599")]
		[FieldOffset(Offset = "0x80")]
		public UIHudCSSOTeamInfoView OppoFaction;

		// Token: 0x0400D59A RID: 54682
		[Token(Token = "0x400D59A")]
		[FieldOffset(Offset = "0x88")]
		public GameObject OppoFactionHP;

		// Token: 0x0400D59B RID: 54683
		[Token(Token = "0x400D59B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject NoEnemy;

		// Token: 0x0400D59C RID: 54684
		[Token(Token = "0x400D59C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel OppoTeamLabel;
	}
}
