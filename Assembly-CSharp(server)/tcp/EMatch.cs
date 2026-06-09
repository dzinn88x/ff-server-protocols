using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000531 RID: 1329
	[Token(Token = "0x2000531")]
	[ProtoContract]
	public class EMatch
	{
		// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x24A2D70", Offset = "0x24A2D70", VA = "0x7BBCCA2D70")]
		public EMatch()
		{
		}

		// Token: 0x02000532 RID: 1330
		[Token(Token = "0x2000532")]
		[ProtoContract]
		public enum MatchMode
		{
			// Token: 0x040018F7 RID: 6391
			[Token(Token = "0x40018F7")]
			MatchMode_NONE,
			// Token: 0x040018F8 RID: 6392
			[Token(Token = "0x40018F8")]
			MatchMode_CASUAL,
			// Token: 0x040018F9 RID: 6393
			[Token(Token = "0x40018F9")]
			MatchMode_RANKING,
			// Token: 0x040018FA RID: 6394
			[Token(Token = "0x40018FA")]
			MatchMode_ROOM,
			// Token: 0x040018FB RID: 6395
			[Token(Token = "0x40018FB")]
			MatchMode_CHAMPIONSHIP,
			// Token: 0x040018FC RID: 6396
			[Token(Token = "0x40018FC")]
			MatchMode_TRAINING,
			// Token: 0x040018FD RID: 6397
			[Token(Token = "0x40018FD")]
			MatchMode_CSRANKING,
			// Token: 0x040018FE RID: 6398
			[Token(Token = "0x40018FE")]
			MatchMode_CUP
		}

		// Token: 0x02000533 RID: 1331
		[Token(Token = "0x2000533")]
		[ProtoContract]
		public enum GameMode
		{
			// Token: 0x04001900 RID: 6400
			[Token(Token = "0x4001900")]
			GameMode_NONE,
			// Token: 0x04001901 RID: 6401
			[Token(Token = "0x4001901")]
			GameMode_BattleRoyale,
			// Token: 0x04001902 RID: 6402
			[Token(Token = "0x4001902")]
			GameMode_SpeedRoyale,
			// Token: 0x04001903 RID: 6403
			[Token(Token = "0x4001903")]
			GameMode_FateRoyale,
			// Token: 0x04001904 RID: 6404
			[Token(Token = "0x4001904")]
			GameMode_ZombieSpeedRoyale,
			// Token: 0x04001905 RID: 6405
			[Token(Token = "0x4001905")]
			GameMode_ZombieGround = 7,
			// Token: 0x04001906 RID: 6406
			[Token(Token = "0x4001906")]
			GameMode_Jankenpon = 9,
			// Token: 0x04001907 RID: 6407
			[Token(Token = "0x4001907")]
			GameMode_WinnerTakesAll = 11,
			// Token: 0x04001908 RID: 6408
			[Token(Token = "0x4001908")]
			GameMode_Purge,
			// Token: 0x04001909 RID: 6409
			[Token(Token = "0x4001909")]
			GameMode_Reborn,
			// Token: 0x0400190A RID: 6410
			[Token(Token = "0x400190A")]
			GameMode_HookBrick,
			// Token: 0x0400190B RID: 6411
			[Token(Token = "0x400190B")]
			GameMode_CS,
			// Token: 0x0400190C RID: 6412
			[Token(Token = "0x400190C")]
			GameMode_BigHead,
			// Token: 0x0400190D RID: 6413
			[Token(Token = "0x400190D")]
			GameMode_PumpkinSnatch = 21,
			// Token: 0x0400190E RID: 6414
			[Token(Token = "0x400190E")]
			GameMode_ThrowingKnife,
			// Token: 0x0400190F RID: 6415
			[Token(Token = "0x400190F")]
			GameMode_Training,
			// Token: 0x04001910 RID: 6416
			[Token(Token = "0x4001910")]
			GameMode_TDM,
			// Token: 0x04001911 RID: 6417
			[Token(Token = "0x4001911")]
			GameMode_Snowman,
			// Token: 0x04001912 RID: 6418
			[Token(Token = "0x4001912")]
			GameMode_ArmsRace,
			// Token: 0x04001913 RID: 6419
			[Token(Token = "0x4001913")]
			GameMode_BombMatch,
			// Token: 0x04001914 RID: 6420
			[Token(Token = "0x4001914")]
			GameMode_Token,
			// Token: 0x04001915 RID: 6421
			[Token(Token = "0x4001915")]
			GameMode_Escort,
			// Token: 0x04001916 RID: 6422
			[Token(Token = "0x4001916")]
			GameMode_Reaper,
			// Token: 0x04001917 RID: 6423
			[Token(Token = "0x4001917")]
			GameMode_AttackOnHead,
			// Token: 0x04001918 RID: 6424
			[Token(Token = "0x4001918")]
			GameMode_Control,
			// Token: 0x04001919 RID: 6425
			[Token(Token = "0x4001919")]
			GameMode_BankNote,
			// Token: 0x0400191A RID: 6426
			[Token(Token = "0x400191A")]
			GameMode_TeamArmsRace,
			// Token: 0x0400191B RID: 6427
			[Token(Token = "0x400191B")]
			GameMode_ADSpace,
			// Token: 0x0400191C RID: 6428
			[Token(Token = "0x400191C")]
			GameMode_StrikeOut,
			// Token: 0x0400191D RID: 6429
			[Token(Token = "0x400191D")]
			GameMode_Werewolves,
			// Token: 0x0400191E RID: 6430
			[Token(Token = "0x400191E")]
			GameMode_PVP_MaxMode,
			// Token: 0x0400191F RID: 6431
			[Token(Token = "0x400191F")]
			GameMode_PVP = 99,
			// Token: 0x04001920 RID: 6432
			[Token(Token = "0x4001920")]
			GameMode_PVE_MinMode,
			// Token: 0x04001921 RID: 6433
			[Token(Token = "0x4001921")]
			GameMode_PVE_HYAKKI,
			// Token: 0x04001922 RID: 6434
			[Token(Token = "0x4001922")]
			GameMode_PVE_SVZombie,
			// Token: 0x04001923 RID: 6435
			[Token(Token = "0x4001923")]
			GameMode_PVE_MaxMode
		}

		// Token: 0x02000534 RID: 1332
		[Token(Token = "0x2000534")]
		[ProtoContract]
		public enum GroupMode
		{
			// Token: 0x04001925 RID: 6437
			[Token(Token = "0x4001925")]
			GroupMode_SOLO,
			// Token: 0x04001926 RID: 6438
			[Token(Token = "0x4001926")]
			GroupMode_DUAL,
			// Token: 0x04001927 RID: 6439
			[Token(Token = "0x4001927")]
			GroupMode_TRIPLE,
			// Token: 0x04001928 RID: 6440
			[Token(Token = "0x4001928")]
			GroupMode_QUAD
		}
	}
}
