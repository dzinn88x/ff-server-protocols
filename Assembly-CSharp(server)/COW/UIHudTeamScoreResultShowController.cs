using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001653 RID: 5715
	[Token(Token = "0x2001653")]
	internal class UIHudTeamScoreResultShowController : UIHudResultShowBaseController
	{
		// Token: 0x0600673F RID: 26431 RVA: 0x0001D700 File Offset: 0x0001B900
		[Token(Token = "0x600673F")]
		[Address(RVA = "0x15DA37C", Offset = "0x15DA37C", VA = "0x7BBBDDA37C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006740")]
		[Address(RVA = "0x15DA3CC", Offset = "0x15DA3CC", VA = "0x7BBBDDA3CC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006741")]
		[Address(RVA = "0x15DA5A4", Offset = "0x15DA5A4", VA = "0x7BBBDDA5A4")]
		private void ShowUIElements(bool show)
		{
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006742")]
		[Address(RVA = "0x15DA640", Offset = "0x15DA640", VA = "0x7BBBDDA640", Slot = "30")]
		protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
		{
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006743")]
		[Address(RVA = "0x15DA6EC", Offset = "0x15DA6EC", VA = "0x7BBBDDA6EC", Slot = "38")]
		protected override List<PlayerData> CreateResultData()
		{
			return null;
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x0001D718 File Offset: 0x0001B918
		[Token(Token = "0x6006744")]
		[Address(RVA = "0x15DA780", Offset = "0x15DA780", VA = "0x7BBBDDA780")]
		private bool IsLocalTeamWinning(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006745")]
		[Address(RVA = "0x15DA79C", Offset = "0x15DA79C", VA = "0x7BBBDDA79C")]
		private List<PlayerData> GetWinnerTeamPlayerData(bool localTeamWin)
		{
			return null;
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006746")]
		[Address(RVA = "0x15DA8B0", Offset = "0x15DA8B0", VA = "0x7BBBDDA8B0")]
		private void SetPlayerDataScores(List<PlayerData> players, List<TeammateStats> stats)
		{
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006747")]
		[Address(RVA = "0x15DAA94", Offset = "0x15DAA94", VA = "0x7BBBDDAA94")]
		private void ReorderPlayerDataForMvp(List<PlayerData> players)
		{
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006748")]
		[Address(RVA = "0x15DACBC", Offset = "0x15DACBC", VA = "0x7BBBDDACBC", Slot = "36")]
		public override void CreateProfileCallSign(PlayerData data, int index)
		{
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006749")]
		[Address(RVA = "0x15DAFDC", Offset = "0x15DAFDC", VA = "0x7BBBDDAFDC", Slot = "39")]
		protected override void InitResultShowWindow()
		{
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674A")]
		[Address(RVA = "0x15DB18C", Offset = "0x15DB18C", VA = "0x7BBBDDB18C")]
		private void InitTeamInfo(MatchStats stats)
		{
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674B")]
		[Address(RVA = "0x15DB35C", Offset = "0x15DB35C", VA = "0x7BBBDDB35C")]
		private void ShowLocalWinning(bool win)
		{
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674C")]
		[Address(RVA = "0x15DB3E4", Offset = "0x15DB3E4", VA = "0x7BBBDDB3E4")]
		private void ShowTeam1Winning(bool win)
		{
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x0001D730 File Offset: 0x0001B930
		[Token(Token = "0x600674D")]
		[Address(RVA = "0x15DB46C", Offset = "0x15DB46C", VA = "0x7BBBDDB46C", Slot = "33")]
		protected override bool HasDefeater(MatchStats stats)
		{
			return default(bool);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674E")]
		[Address(RVA = "0x15DB474", Offset = "0x15DB474", VA = "0x7BBBDDB474", Slot = "34")]
		protected override void ReturnToLobby()
		{
		}

		// Token: 0x0600674F RID: 26447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600674F")]
		[Address(RVA = "0x15DB544", Offset = "0x15DB544", VA = "0x7BBBDDB544")]
		public UIHudTeamScoreResultShowController()
		{
		}

		// Token: 0x040084A1 RID: 33953
		[Token(Token = "0x40084A1")]
		[FieldOffset(Offset = "0xD8")]
		private UIHudTeamScoreResultShowView m_View;

		// Token: 0x040084A2 RID: 33954
		[Token(Token = "0x40084A2")]
		private const int MVP_INDEX = 1;

		// Token: 0x040084A3 RID: 33955
		[Token(Token = "0x40084A3")]
		[FieldOffset(Offset = "0xE0")]
		private int m_MvpIndex;

		// Token: 0x02001654 RID: 5716
		[Token(Token = "0x2001654")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFFBC", Offset = "0x10EFFBC")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06006750 RID: 26448 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006750")]
			[Address(RVA = "0x15DACB4", Offset = "0x15DACB4", VA = "0x7BBBDDACB4")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06006751 RID: 26449 RVA: 0x0001D748 File Offset: 0x0001B948
			[Token(Token = "0x6006751")]
			[Address(RVA = "0x15DB554", Offset = "0x15DB554", VA = "0x7BBBDDB554")]
			internal bool <SetPlayerDataScores>b__0(TeammateStats s)
			{
				return default(bool);
			}

			// Token: 0x040084A4 RID: 33956
			[Token(Token = "0x40084A4")]
			[FieldOffset(Offset = "0x10")]
			public PlayerData p;
		}
	}
}
