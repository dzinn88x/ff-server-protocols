using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022B4 RID: 8884
	[Token(Token = "0x20022B4")]
	public class UIHudCSSORoundResultView : UIBaseView
	{
		// Token: 0x0600C078 RID: 49272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C078")]
		[Address(RVA = "0x19CB10C", Offset = "0x19CB10C", VA = "0x7BBC1CB10C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C079 RID: 49273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C079")]
		[Address(RVA = "0x19CB5AC", Offset = "0x19CB5AC", VA = "0x7BBC1CB5AC")]
		public UIHudCSSORoundResultView()
		{
		}

		// Token: 0x0400D57A RID: 54650
		[Token(Token = "0x400D57A")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Coins;

		// Token: 0x0400D57B RID: 54651
		[Token(Token = "0x400D57B")]
		[FieldOffset(Offset = "0x28")]
		public GameObject WinSprite;

		// Token: 0x0400D57C RID: 54652
		[Token(Token = "0x400D57C")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LoseSprite;

		// Token: 0x0400D57D RID: 54653
		[Token(Token = "0x400D57D")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid BonusGrid;

		// Token: 0x0400D57E RID: 54654
		[Token(Token = "0x400D57E")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BonusItem;

		// Token: 0x0400D57F RID: 54655
		[Token(Token = "0x400D57F")]
		[FieldOffset(Offset = "0x48")]
		public UILabel MvpPlayer;

		// Token: 0x0400D580 RID: 54656
		[Token(Token = "0x400D580")]
		[FieldOffset(Offset = "0x50")]
		public GameObject MVPIcon;

		// Token: 0x0400D581 RID: 54657
		[Token(Token = "0x400D581")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HoldBG;

		// Token: 0x0400D582 RID: 54658
		[Token(Token = "0x400D582")]
		[FieldOffset(Offset = "0x60")]
		public UIHudCSSOTeamInfoView OppoFaction;

		// Token: 0x0400D583 RID: 54659
		[Token(Token = "0x400D583")]
		[FieldOffset(Offset = "0x68")]
		public GameObject OppoFactionHP;

		// Token: 0x0400D584 RID: 54660
		[Token(Token = "0x400D584")]
		[FieldOffset(Offset = "0x70")]
		public GameObject NoEnemy;

		// Token: 0x0400D585 RID: 54661
		[Token(Token = "0x400D585")]
		[FieldOffset(Offset = "0x78")]
		public GameObject OppoFactionEliminate;

		// Token: 0x0400D586 RID: 54662
		[Token(Token = "0x400D586")]
		[FieldOffset(Offset = "0x80")]
		public GameObject OppoTeam;

		// Token: 0x0400D587 RID: 54663
		[Token(Token = "0x400D587")]
		[FieldOffset(Offset = "0x88")]
		public UILabel OppoTeamLabel;

		// Token: 0x0400D588 RID: 54664
		[Token(Token = "0x400D588")]
		[FieldOffset(Offset = "0x90")]
		public GameObject OppoWin;

		// Token: 0x0400D589 RID: 54665
		[Token(Token = "0x400D589")]
		[FieldOffset(Offset = "0x98")]
		public UIHudCSSOTeamInfoView MyFaction;

		// Token: 0x0400D58A RID: 54666
		[Token(Token = "0x400D58A")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject MyFactionEliminate;

		// Token: 0x0400D58B RID: 54667
		[Token(Token = "0x400D58B")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel MyTeamLabel;

		// Token: 0x0400D58C RID: 54668
		[Token(Token = "0x400D58C")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject MyWin;
	}
}
