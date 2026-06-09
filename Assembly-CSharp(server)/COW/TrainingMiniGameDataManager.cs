using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02002095 RID: 8341
	[Token(Token = "0x2002095")]
	public class TrainingMiniGameDataManager : SingletonModule<TrainingMiniGameDataManager>
	{
		// Token: 0x0600BB72 RID: 47986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB72")]
		[Address(RVA = "0x1A3089C", Offset = "0x1A3089C", VA = "0x7BBC23089C", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB73")]
		[Address(RVA = "0x1A308A0", Offset = "0x1A308A0", VA = "0x7BBC2308A0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB74")]
		[Address(RVA = "0x1A31158", Offset = "0x1A31158", VA = "0x7BBC231158")]
		public TrainingShootingGameData GetShootingGameData()
		{
			return null;
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB75")]
		[Address(RVA = "0x1A31160", Offset = "0x1A31160", VA = "0x7BBC231160")]
		public TrainingIceWallPracticeData GetIceWallPracticeData()
		{
			return null;
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB76")]
		[Address(RVA = "0x1A31168", Offset = "0x1A31168", VA = "0x7BBC231168")]
		public TrainingEsportHallOfFameData GetEsportsDataById(uint id)
		{
			return null;
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB77")]
		[Address(RVA = "0x1A311E8", Offset = "0x1A311E8", VA = "0x7BBC2311E8")]
		public ServerMiniGameData GetMiniGameDataByGameType(MLY^mpx gameType)
		{
			return null;
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x00035100 File Offset: 0x00033300
		[Token(Token = "0x600BB78")]
		[Address(RVA = "0x1A31268", Offset = "0x1A31268", VA = "0x7BBC231268")]
		public ResourceID GetMiniGameEffectRes(MLY^mpx gameType, int effectId)
		{
			return default(ResourceID);
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB79")]
		[Address(RVA = "0x1A31324", Offset = "0x1A31324", VA = "0x7BBC231324")]
		public TrainingMiniGameDataManager()
		{
		}

		// Token: 0x0400BC68 RID: 48232
		[Token(Token = "0x400BC68")]
		[FieldOffset(Offset = "0x18")]
		private TrainingShootingGameData m_ShootingGameData;

		// Token: 0x0400BC69 RID: 48233
		[Token(Token = "0x400BC69")]
		[FieldOffset(Offset = "0x20")]
		private TrainingIceWallPracticeData m_IceWallPracticeData;

		// Token: 0x0400BC6A RID: 48234
		[Token(Token = "0x400BC6A")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, TrainingEsportHallOfFameData> m_TrainingEsportsData;

		// Token: 0x0400BC6B RID: 48235
		[Token(Token = "0x400BC6B")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, ServerMiniGameData> m_ServerMiniGameDataDict;
	}
}
