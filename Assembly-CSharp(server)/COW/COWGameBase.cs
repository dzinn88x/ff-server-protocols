using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200124C RID: 4684
	[Token(Token = "0x200124C")]
	public abstract class COWGameBase : BaseGame
	{
		// Token: 0x060047E0 RID: 18400 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x60047E0")]
		[Address(RVA = "0x14E8FA8", Offset = "0x14E8FA8", VA = "0x7BBBCE8FA8")]
		public static bool IsMatchGame()
		{
			return default(bool);
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E1")]
		[Address(RVA = "0x14E90B8", Offset = "0x14E90B8", VA = "0x7BBBCE90B8", Slot = "8")]
		protected override void OnAwake()
		{
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E2")]
		[Address(RVA = "0x14E9160", Offset = "0x14E9160", VA = "0x7BBBCE9160", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E3")]
		[Address(RVA = "0x14E91E8", Offset = "0x14E91E8", VA = "0x7BBBCE91E8", Slot = "9")]
		protected override void OnSceneLoaded()
		{
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047E4")]
		[Address(RVA = "0x14E92B0", Offset = "0x14E92B0", VA = "0x7BBBCE92B0")]
		protected COWGameBase()
		{
		}

		// Token: 0x0200124D RID: 4685
		[Token(Token = "0x200124D")]
		public enum GameType
		{
			// Token: 0x04007147 RID: 28999
			[Token(Token = "0x4007147")]
			FrontEndGame,
			// Token: 0x04007148 RID: 29000
			[Token(Token = "0x4007148")]
			MultiPlayerGame,
			// Token: 0x04007149 RID: 29001
			[Token(Token = "0x4007149")]
			SinglePlayerGame,
			// Token: 0x0400714A RID: 29002
			[Token(Token = "0x400714A")]
			TutorialGame,
			// Token: 0x0400714B RID: 29003
			[Token(Token = "0x400714B")]
			HotUpdaterGame
		}

		// Token: 0x0200124E RID: 4686
		[Token(Token = "0x200124E")]
		public enum GameSubType
		{
			// Token: 0x0400714D RID: 29005
			[Token(Token = "0x400714D")]
			None,
			// Token: 0x0400714E RID: 29006
			[Token(Token = "0x400714E")]
			WaitingGame,
			// Token: 0x0400714F RID: 29007
			[Token(Token = "0x400714F")]
			BattleGame
		}

		// Token: 0x0200124F RID: 4687
		[Token(Token = "0x200124F")]
		public enum GameModeType
		{
			// Token: 0x04007151 RID: 29009
			[Token(Token = "0x4007151")]
			All,
			// Token: 0x04007152 RID: 29010
			[Token(Token = "0x4007152")]
			PVP,
			// Token: 0x04007153 RID: 29011
			[Token(Token = "0x4007153")]
			PVE
		}

		// Token: 0x02001250 RID: 4688
		[Token(Token = "0x2001250")]
		public enum GameMode : uint
		{
			// Token: 0x04007155 RID: 29013
			[Token(Token = "0x4007155")]
			GameModeNone,
			// Token: 0x04007156 RID: 29014
			[Token(Token = "0x4007156")]
			GameModeBattleRoyale,
			// Token: 0x04007157 RID: 29015
			[Token(Token = "0x4007157")]
			GameModeSpeedRoyale,
			// Token: 0x04007158 RID: 29016
			[Token(Token = "0x4007158")]
			GameModeFateRoyale,
			// Token: 0x04007159 RID: 29017
			[Token(Token = "0x4007159")]
			GameModeSpeedRoyaleZombie,
			// Token: 0x0400715A RID: 29018
			[Token(Token = "0x400715A")]
			GameModeSVZombie = 102U,
			// Token: 0x0400715B RID: 29019
			[Token(Token = "0x400715B")]
			GameModeBattleRoyaleZombie = 7U,
			// Token: 0x0400715C RID: 29020
			[Token(Token = "0x400715C")]
			GameModePurge = 12U,
			// Token: 0x0400715D RID: 29021
			[Token(Token = "0x400715D")]
			GameModeSnowMan = 25U,
			// Token: 0x0400715E RID: 29022
			[Token(Token = "0x400715E")]
			GameModeReborn = 13U,
			// Token: 0x0400715F RID: 29023
			[Token(Token = "0x400715F")]
			GameModeCS = 15U,
			// Token: 0x04007160 RID: 29024
			[Token(Token = "0x4007160")]
			GameModeTK = 22U,
			// Token: 0x04007161 RID: 29025
			[Token(Token = "0x4007161")]
			GameModePVEHyakki = 101U,
			// Token: 0x04007162 RID: 29026
			[Token(Token = "0x4007162")]
			GameModeTDM = 24U,
			// Token: 0x04007163 RID: 29027
			[Token(Token = "0x4007163")]
			GameModeReaper = 30U,
			// Token: 0x04007164 RID: 29028
			[Token(Token = "0x4007164")]
			GameModeGiant = 29U
		}
	}
}
