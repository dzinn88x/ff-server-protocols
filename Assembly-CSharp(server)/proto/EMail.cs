using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005B2 RID: 1458
	[Token(Token = "0x20005B2")]
	[ProtoContract]
	public class EMail
	{
		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x21B9860", Offset = "0x21B9860", VA = "0x7BBC9B9860")]
		public EMail()
		{
		}

		// Token: 0x020005B3 RID: 1459
		[Token(Token = "0x20005B3")]
		[ProtoContract]
		public enum Source
		{
			// Token: 0x04001CD7 RID: 7383
			[Token(Token = "0x4001CD7")]
			Source_GAME,
			// Token: 0x04001CD8 RID: 7384
			[Token(Token = "0x4001CD8")]
			Source_ADMIN
		}

		// Token: 0x020005B4 RID: 1460
		[Token(Token = "0x20005B4")]
		[ProtoContract]
		public enum ActionType
		{
			// Token: 0x04001CDA RID: 7386
			[Token(Token = "0x4001CDA")]
			ActionType_ATTACHMENT,
			// Token: 0x04001CDB RID: 7387
			[Token(Token = "0x4001CDB")]
			ActionType_NOTICE,
			// Token: 0x04001CDC RID: 7388
			[Token(Token = "0x4001CDC")]
			ActionType_CLAN_INVITE
		}

		// Token: 0x020005B5 RID: 1461
		[Token(Token = "0x20005B5")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x04001CDE RID: 7390
			[Token(Token = "0x4001CDE")]
			Type_NONE,
			// Token: 0x04001CDF RID: 7391
			[Token(Token = "0x4001CDF")]
			Type_CLAN_INVITE,
			// Token: 0x04001CE0 RID: 7392
			[Token(Token = "0x4001CE0")]
			Type_CLAN_DISMISS,
			// Token: 0x04001CE1 RID: 7393
			[Token(Token = "0x4001CE1")]
			Type_CLAN_KICKOUT,
			// Token: 0x04001CE2 RID: 7394
			[Token(Token = "0x4001CE2")]
			Type_CLAN_REASSIGN_CAPTAIN,
			// Token: 0x04001CE3 RID: 7395
			[Token(Token = "0x4001CE3")]
			Type_RANKING_SEASON_REWARDS,
			// Token: 0x04001CE4 RID: 7396
			[Token(Token = "0x4001CE4")]
			Type_RANKING_RANK_LEVEL_REWARDS,
			// Token: 0x04001CE5 RID: 7397
			[Token(Token = "0x4001CE5")]
			Type_EP_UNLOCK_REWARD,
			// Token: 0x04001CE6 RID: 7398
			[Token(Token = "0x4001CE6")]
			Type_EP_CHALLENGE_REWARD,
			// Token: 0x04001CE7 RID: 7399
			[Token(Token = "0x4001CE7")]
			Type_STORE_SEND_GIFT,
			// Token: 0x04001CE8 RID: 7400
			[Token(Token = "0x4001CE8")]
			Type_GLOBAL_DROPS,
			// Token: 0x04001CE9 RID: 7401
			[Token(Token = "0x4001CE9")]
			Type_CLAN_RACE_AWARD,
			// Token: 0x04001CEA RID: 7402
			[Token(Token = "0x4001CEA")]
			Type_SET_STREAMER = 14,
			// Token: 0x04001CEB RID: 7403
			[Token(Token = "0x4001CEB")]
			Type_DEL_STREAMER,
			// Token: 0x04001CEC RID: 7404
			[Token(Token = "0x4001CEC")]
			Type_INSTANT_GAME_REWARD,
			// Token: 0x04001CED RID: 7405
			[Token(Token = "0x4001CED")]
			Type_SUBSCRIPTION_EP,
			// Token: 0x04001CEE RID: 7406
			[Token(Token = "0x4001CEE")]
			Type_CHAMPIONSHIP_TEAM_DISMISS,
			// Token: 0x04001CEF RID: 7407
			[Token(Token = "0x4001CEF")]
			Type_CHAMPIONSHIP_TEAM_KICKOUT,
			// Token: 0x04001CF0 RID: 7408
			[Token(Token = "0x4001CF0")]
			Type_CHAMPIONSHIP_TRIAL_REWARDS,
			// Token: 0x04001CF1 RID: 7409
			[Token(Token = "0x4001CF1")]
			Type_GOP_PURCHASE,
			// Token: 0x04001CF2 RID: 7410
			[Token(Token = "0x4001CF2")]
			Type_NEWBIE_RETURN,
			// Token: 0x04001CF3 RID: 7411
			[Token(Token = "0x4001CF3")]
			Type_CLAN_REGION_CHANGE,
			// Token: 0x04001CF4 RID: 7412
			[Token(Token = "0x4001CF4")]
			Type_VETERAN_RETURN,
			// Token: 0x04001CF5 RID: 7413
			[Token(Token = "0x4001CF5")]
			Type_RANKING_SEASON_TOP_REWARDS,
			// Token: 0x04001CF6 RID: 7414
			[Token(Token = "0x4001CF6")]
			Type_NEW_PALYER_UNCLAIM_REWARDS,
			// Token: 0x04001CF7 RID: 7415
			[Token(Token = "0x4001CF7")]
			Type_FRESH_UNCLAIM_REWARDS,
			// Token: 0x04001CF8 RID: 7416
			[Token(Token = "0x4001CF8")]
			Type_EP_DAILY_QUEST_UNCLAIM_REWARDS,
			// Token: 0x04001CF9 RID: 7417
			[Token(Token = "0x4001CF9")]
			Type_CS_RANKING_RANK_LEVEL_REWARDS,
			// Token: 0x04001CFA RID: 7418
			[Token(Token = "0x4001CFA")]
			Type_CS_RANKING_SEASON_REWARDS,
			// Token: 0x04001CFB RID: 7419
			[Token(Token = "0x4001CFB")]
			Type_CS_RANKING_HANGUP_WARN,
			// Token: 0x04001CFC RID: 7420
			[Token(Token = "0x4001CFC")]
			Type_CS_RANKING_HANGUP_BAN,
			// Token: 0x04001CFD RID: 7421
			[Token(Token = "0x4001CFD")]
			Type_CLAN_DEPUTY_CAPTAIN_NOTIFY,
			// Token: 0x04001CFE RID: 7422
			[Token(Token = "0x4001CFE")]
			Type_LIMITEDEVENT_LEADERBOARD_REWARDS,
			// Token: 0x04001CFF RID: 7423
			[Token(Token = "0x4001CFF")]
			Type_INTIMACY_AWARDS
		}

		// Token: 0x020005B6 RID: 1462
		[Token(Token = "0x20005B6")]
		[ProtoContract]
		public enum Status
		{
			// Token: 0x04001D01 RID: 7425
			[Token(Token = "0x4001D01")]
			Status_INIT,
			// Token: 0x04001D02 RID: 7426
			[Token(Token = "0x4001D02")]
			Status_PROCESSED,
			// Token: 0x04001D03 RID: 7427
			[Token(Token = "0x4001D03")]
			Status_DELETED
		}
	}
}
