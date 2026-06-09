using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	[ProtoContract]
	public class EMessageQueue
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x21B9878", Offset = "0x21B9878", VA = "0x7BBC9B9878")]
		public EMessageQueue()
		{
		}

		// Token: 0x020005BD RID: 1469
		[Token(Token = "0x20005BD")]
		[ProtoContract]
		public enum Topic
		{
			// Token: 0x04001D3C RID: 7484
			[Token(Token = "0x4001D3C")]
			Topic_EndMatch,
			// Token: 0x04001D3D RID: 7485
			[Token(Token = "0x4001D3D")]
			Topic_LogoutMatch,
			// Token: 0x04001D3E RID: 7486
			[Token(Token = "0x4001D3E")]
			Topic_ActivityTrigger,
			// Token: 0x04001D3F RID: 7487
			[Token(Token = "0x4001D3F")]
			Topic_SendMail,
			// Token: 0x04001D40 RID: 7488
			[Token(Token = "0x4001D40")]
			Topic_BatchSendMail,
			// Token: 0x04001D41 RID: 7489
			[Token(Token = "0x4001D41")]
			Topic_ManualUpdate,
			// Token: 0x04001D42 RID: 7490
			[Token(Token = "0x4001D42")]
			Topic_AccountNews,
			// Token: 0x04001D43 RID: 7491
			[Token(Token = "0x4001D43")]
			Topic_EPChallengeTrigger,
			// Token: 0x04001D44 RID: 7492
			[Token(Token = "0x4001D44")]
			Topic_ChampionshipEndMatch,
			// Token: 0x04001D45 RID: 7493
			[Token(Token = "0x4001D45")]
			Topic_FreshActivityTrigger,
			// Token: 0x04001D46 RID: 7494
			[Token(Token = "0x4001D46")]
			Topic_LinkageActivityTrigger,
			// Token: 0x04001D47 RID: 7495
			[Token(Token = "0x4001D47")]
			Topic_VN_EndMatch,
			// Token: 0x04001D48 RID: 7496
			[Token(Token = "0x4001D48")]
			Topic_TH_EndMatch,
			// Token: 0x04001D49 RID: 7497
			[Token(Token = "0x4001D49")]
			Topic_ID_EndMatch,
			// Token: 0x04001D4A RID: 7498
			[Token(Token = "0x4001D4A")]
			Topic_TW_EndMatch,
			// Token: 0x04001D4B RID: 7499
			[Token(Token = "0x4001D4B")]
			Topic_BR_EndMatch,
			// Token: 0x04001D4C RID: 7500
			[Token(Token = "0x4001D4C")]
			Topic_SG_EndMatch,
			// Token: 0x04001D4D RID: 7501
			[Token(Token = "0x4001D4D")]
			Topic_US_EndMatch,
			// Token: 0x04001D4E RID: 7502
			[Token(Token = "0x4001D4E")]
			Topic_ZA_EndMatch,
			// Token: 0x04001D4F RID: 7503
			[Token(Token = "0x4001D4F")]
			Topic_RU_EndMatch,
			// Token: 0x04001D50 RID: 7504
			[Token(Token = "0x4001D50")]
			Topic_EUROPE_EndMatch,
			// Token: 0x04001D51 RID: 7505
			[Token(Token = "0x4001D51")]
			Topic_SAC_EndMatch,
			// Token: 0x04001D52 RID: 7506
			[Token(Token = "0x4001D52")]
			Topic_IND_EndMatch,
			// Token: 0x04001D53 RID: 7507
			[Token(Token = "0x4001D53")]
			Topic_ME_ENdMatch,
			// Token: 0x04001D54 RID: 7508
			[Token(Token = "0x4001D54")]
			Topic_AttendanceTrigger,
			// Token: 0x04001D55 RID: 7509
			[Token(Token = "0x4001D55")]
			Topic_NA_EndMatch,
			// Token: 0x04001D56 RID: 7510
			[Token(Token = "0x4001D56")]
			Topic_AwakenTaskTrigger,
			// Token: 0x04001D57 RID: 7511
			[Token(Token = "0x4001D57")]
			Topic_ReduceCSRankingHangUps,
			// Token: 0x04001D58 RID: 7512
			[Token(Token = "0x4001D58")]
			Topic_SyncEPArchivesInfoTrigger,
			// Token: 0x04001D59 RID: 7513
			[Token(Token = "0x4001D59")]
			Topic_PayLevelTrigger,
			// Token: 0x04001D5A RID: 7514
			[Token(Token = "0x4001D5A")]
			Topic_UpdateAccountHackerTagTrigger,
			// Token: 0x04001D5B RID: 7515
			[Token(Token = "0x4001D5B")]
			Topic_PK_EndMatch,
			// Token: 0x04001D5C RID: 7516
			[Token(Token = "0x4001D5C")]
			Topic_AmendPlayerMmr,
			// Token: 0x04001D5D RID: 7517
			[Token(Token = "0x4001D5D")]
			Topic_AddIntimacy,
			// Token: 0x04001D5E RID: 7518
			[Token(Token = "0x4001D5E")]
			Topic_UpdateBattleTag,
			// Token: 0x04001D5F RID: 7519
			[Token(Token = "0x4001D5F")]
			Topic_StoreIAPTrigger
		}

		// Token: 0x020005BE RID: 1470
		[Token(Token = "0x20005BE")]
		[ProtoContract]
		public enum EndMatchChannel
		{
			// Token: 0x04001D61 RID: 7521
			[Token(Token = "0x4001D61")]
			EndMatchChannel_SubmitMatchStats
		}

		// Token: 0x020005BF RID: 1471
		[Token(Token = "0x20005BF")]
		[ProtoContract]
		public enum LogoutMatchChannel
		{
			// Token: 0x04001D63 RID: 7523
			[Token(Token = "0x4001D63")]
			LogoutMatchChannel_SubmitMatchStats
		}

		// Token: 0x020005C0 RID: 1472
		[Token(Token = "0x20005C0")]
		[ProtoContract]
		public enum ActivityChannel
		{
			// Token: 0x04001D65 RID: 7525
			[Token(Token = "0x4001D65")]
			ActivityTriggerChannel_Trigger
		}

		// Token: 0x020005C1 RID: 1473
		[Token(Token = "0x20005C1")]
		[ProtoContract]
		public enum SendMailChannel
		{
			// Token: 0x04001D67 RID: 7527
			[Token(Token = "0x4001D67")]
			SendMailChannel_CheckMail
		}

		// Token: 0x020005C2 RID: 1474
		[Token(Token = "0x20005C2")]
		[ProtoContract]
		public enum BatchSendMailChannel
		{
			// Token: 0x04001D69 RID: 7529
			[Token(Token = "0x4001D69")]
			BatchSendMailChannel_CheckMail
		}

		// Token: 0x020005C3 RID: 1475
		[Token(Token = "0x20005C3")]
		[ProtoContract]
		public enum AmendPlayerMmrChannel
		{
			// Token: 0x04001D6B RID: 7531
			[Token(Token = "0x4001D6B")]
			AmendPlayerMmrChannel_Update
		}

		// Token: 0x020005C4 RID: 1476
		[Token(Token = "0x20005C4")]
		[ProtoContract]
		public enum ManualChannel
		{
			// Token: 0x04001D6D RID: 7533
			[Token(Token = "0x4001D6D")]
			ManualUpdateChannel_Update
		}

		// Token: 0x020005C5 RID: 1477
		[Token(Token = "0x20005C5")]
		[ProtoContract]
		public enum AccountNewsChannel
		{
			// Token: 0x04001D6F RID: 7535
			[Token(Token = "0x4001D6F")]
			AccountNewsChannel_Update
		}

		// Token: 0x020005C6 RID: 1478
		[Token(Token = "0x20005C6")]
		[ProtoContract]
		public enum EPChannel
		{
			// Token: 0x04001D71 RID: 7537
			[Token(Token = "0x4001D71")]
			EPChallengeTriggerChannel_Trigger
		}

		// Token: 0x020005C7 RID: 1479
		[Token(Token = "0x20005C7")]
		[ProtoContract]
		public enum ChampionshipChannel
		{
			// Token: 0x04001D73 RID: 7539
			[Token(Token = "0x4001D73")]
			ChampionshipChannel_SubmitChampionshipTeamMatchStats
		}

		// Token: 0x020005C8 RID: 1480
		[Token(Token = "0x20005C8")]
		[ProtoContract]
		public enum FreshChannel
		{
			// Token: 0x04001D75 RID: 7541
			[Token(Token = "0x4001D75")]
			FreshActivityTriggerChannel_Trigger
		}

		// Token: 0x020005C9 RID: 1481
		[Token(Token = "0x20005C9")]
		[ProtoContract]
		public enum LinkageChannel
		{
			// Token: 0x04001D77 RID: 7543
			[Token(Token = "0x4001D77")]
			LinkageActivityTriggerChannel_Trigger
		}

		// Token: 0x020005CA RID: 1482
		[Token(Token = "0x20005CA")]
		[ProtoContract]
		public enum AttendanceChannel
		{
			// Token: 0x04001D79 RID: 7545
			[Token(Token = "0x4001D79")]
			AttendanceVeteranTaskTriggerChannel_Trigger
		}

		// Token: 0x020005CB RID: 1483
		[Token(Token = "0x20005CB")]
		[ProtoContract]
		public enum ProfileChannel
		{
			// Token: 0x04001D7B RID: 7547
			[Token(Token = "0x4001D7B")]
			ProfileChannel_AwakenTaskTrigger
		}

		// Token: 0x020005CC RID: 1484
		[Token(Token = "0x20005CC")]
		[ProtoContract]
		public enum CSRankingMatchChannel
		{
			// Token: 0x04001D7D RID: 7549
			[Token(Token = "0x4001D7D")]
			CSRankingMatchChannel_ReduceHangUps
		}

		// Token: 0x020005CD RID: 1485
		[Token(Token = "0x20005CD")]
		[ProtoContract]
		public enum EPArchivesChannel
		{
			// Token: 0x04001D7F RID: 7551
			[Token(Token = "0x4001D7F")]
			EPArchivesChannel_Sync
		}

		// Token: 0x020005CE RID: 1486
		[Token(Token = "0x20005CE")]
		[ProtoContract]
		public enum StoreChannel
		{
			// Token: 0x04001D81 RID: 7553
			[Token(Token = "0x4001D81")]
			StoreChannel_PayLevelTrigger,
			// Token: 0x04001D82 RID: 7554
			[Token(Token = "0x4001D82")]
			StoreChannel_IAPStoreTrigger
		}

		// Token: 0x020005CF RID: 1487
		[Token(Token = "0x20005CF")]
		[ProtoContract]
		public enum AccountHackerTagChannel
		{
			// Token: 0x04001D84 RID: 7556
			[Token(Token = "0x4001D84")]
			AccountHackerTagChannel_Update
		}

		// Token: 0x020005D0 RID: 1488
		[Token(Token = "0x20005D0")]
		[ProtoContract]
		public enum AddIntimacyChannel
		{
			// Token: 0x04001D86 RID: 7558
			[Token(Token = "0x4001D86")]
			AddIntimacyChannel_Trigger
		}

		// Token: 0x020005D1 RID: 1489
		[Token(Token = "0x20005D1")]
		[ProtoContract]
		public enum BattleTagChannel
		{
			// Token: 0x04001D88 RID: 7560
			[Token(Token = "0x4001D88")]
			BattleTagChannel_Update
		}
	}
}
