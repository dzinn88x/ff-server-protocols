using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	[ProtoContract]
	public class EClan
	{
		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x21B97F0", Offset = "0x21B97F0", VA = "0x7BBC9B97F0")]
		public EClan()
		{
		}

		// Token: 0x0200061B RID: 1563
		[Token(Token = "0x200061B")]
		[ProtoContract]
		public enum MemberType
		{
			// Token: 0x04001F1A RID: 7962
			[Token(Token = "0x4001F1A")]
			MemberType_NONE,
			// Token: 0x04001F1B RID: 7963
			[Token(Token = "0x4001F1B")]
			MemberType_NORMAL_MEMBER,
			// Token: 0x04001F1C RID: 7964
			[Token(Token = "0x4001F1C")]
			MemberType_VICE_CAPTAIN,
			// Token: 0x04001F1D RID: 7965
			[Token(Token = "0x4001F1D")]
			MemberType_CAPTAIN,
			// Token: 0x04001F1E RID: 7966
			[Token(Token = "0x4001F1E")]
			MemberType_DEPUTY_CAPTAIN
		}

		// Token: 0x0200061C RID: 1564
		[Token(Token = "0x200061C")]
		[ProtoContract]
		public enum EntryType
		{
			// Token: 0x04001F20 RID: 7968
			[Token(Token = "0x4001F20")]
			EntryType_NONE,
			// Token: 0x04001F21 RID: 7969
			[Token(Token = "0x4001F21")]
			EntryType_MANUALLY,
			// Token: 0x04001F22 RID: 7970
			[Token(Token = "0x4001F22")]
			EntryType_AUTO
		}

		// Token: 0x0200061D RID: 1565
		[Token(Token = "0x200061D")]
		[ProtoContract]
		public enum ClanUserChangeType
		{
			// Token: 0x04001F24 RID: 7972
			[Token(Token = "0x4001F24")]
			ClanUserChangeType_NONE,
			// Token: 0x04001F25 RID: 7973
			[Token(Token = "0x4001F25")]
			ClanUserChangeType_REQUEST,
			// Token: 0x04001F26 RID: 7974
			[Token(Token = "0x4001F26")]
			ClanUserChangeType_APPROVE_APPLICATION,
			// Token: 0x04001F27 RID: 7975
			[Token(Token = "0x4001F27")]
			ClanUserChangeType_INVITE,
			// Token: 0x04001F28 RID: 7976
			[Token(Token = "0x4001F28")]
			ClanUserChangeType_APPROVE_INVITATION,
			// Token: 0x04001F29 RID: 7977
			[Token(Token = "0x4001F29")]
			ClanUserChangeType_CHANGE_MEMBER_TYPE,
			// Token: 0x04001F2A RID: 7978
			[Token(Token = "0x4001F2A")]
			ClanUserChangeType_REASSIGN_CAPTAIN,
			// Token: 0x04001F2B RID: 7979
			[Token(Token = "0x4001F2B")]
			ClanUserChangeType_REMOVE,
			// Token: 0x04001F2C RID: 7980
			[Token(Token = "0x4001F2C")]
			ClanUserChangeType_QUIT,
			// Token: 0x04001F2D RID: 7981
			[Token(Token = "0x4001F2D")]
			ClanUserChangeType_REQUEST_AUTO,
			// Token: 0x04001F2E RID: 7982
			[Token(Token = "0x4001F2E")]
			ClanUserChangeType_ADMIN_CHANGE_MEMBER_TYPE,
			// Token: 0x04001F2F RID: 7983
			[Token(Token = "0x4001F2F")]
			ClanUserChangeType_ASSIGN_AGENT,
			// Token: 0x04001F30 RID: 7984
			[Token(Token = "0x4001F30")]
			ClanUserChangeType_DISMISS_AGENT,
			// Token: 0x04001F31 RID: 7985
			[Token(Token = "0x4001F31")]
			ClanUserChangeType_APPLY_AGENT,
			// Token: 0x04001F32 RID: 7986
			[Token(Token = "0x4001F32")]
			ClanUserChangeType_APPLY_AGENT_SUCCESS,
			// Token: 0x04001F33 RID: 7987
			[Token(Token = "0x4001F33")]
			ClanUserChangeType_CANCEL_OVERTIME_AGENT
		}

		// Token: 0x0200061E RID: 1566
		[Token(Token = "0x200061E")]
		[ProtoContract]
		public enum ClanMainType
		{
			// Token: 0x04001F35 RID: 7989
			[Token(Token = "0x4001F35")]
			ClanMainType_NONE,
			// Token: 0x04001F36 RID: 7990
			[Token(Token = "0x4001F36")]
			ClanMainType_REGION,
			// Token: 0x04001F37 RID: 7991
			[Token(Token = "0x4001F37")]
			ClanMainType_AREA,
			// Token: 0x04001F38 RID: 7992
			[Token(Token = "0x4001F38")]
			ClanMainType_PLAY_STYLE
		}

		// Token: 0x0200061F RID: 1567
		[Token(Token = "0x200061F")]
		[ProtoContract]
		public enum ClanHonorType
		{
			// Token: 0x04001F3A RID: 7994
			[Token(Token = "0x4001F3A")]
			ClanHonorType_NONE,
			// Token: 0x04001F3B RID: 7995
			[Token(Token = "0x4001F3B")]
			ClanHonorType_MATCH,
			// Token: 0x04001F3C RID: 7996
			[Token(Token = "0x4001F3C")]
			ClanHonorType_SAME_TEAM,
			// Token: 0x04001F3D RID: 7997
			[Token(Token = "0x4001F3D")]
			ClanHonorType_TOP_UP
		}

		// Token: 0x02000620 RID: 1568
		[Token(Token = "0x2000620")]
		[ProtoContract]
		public enum ClanSignInRewardStatus
		{
			// Token: 0x04001F3F RID: 7999
			[Token(Token = "0x4001F3F")]
			ClanSignInRewardStatus_NOT_SIGNED,
			// Token: 0x04001F40 RID: 8000
			[Token(Token = "0x4001F40")]
			ClanSignInRewardStatus_SIGNED,
			// Token: 0x04001F41 RID: 8001
			[Token(Token = "0x4001F41")]
			ClanSignInRewardStatus_CLAIMED
		}

		// Token: 0x02000621 RID: 1569
		[Token(Token = "0x2000621")]
		[ProtoContract]
		public enum RacePointsGainType
		{
			// Token: 0x04001F43 RID: 8003
			[Token(Token = "0x4001F43")]
			RacePointsGainType_NONE,
			// Token: 0x04001F44 RID: 8004
			[Token(Token = "0x4001F44")]
			RacePointsGainType_MATCH,
			// Token: 0x04001F45 RID: 8005
			[Token(Token = "0x4001F45")]
			RacePointsGainType_SAME_TEAM
		}

		// Token: 0x02000622 RID: 1570
		[Token(Token = "0x2000622")]
		[ProtoContract]
		public enum PlayerRacePointChangeType
		{
			// Token: 0x04001F47 RID: 8007
			[Token(Token = "0x4001F47")]
			PlayerRacePointChangeType_NONE,
			// Token: 0x04001F48 RID: 8008
			[Token(Token = "0x4001F48")]
			PlayerRacePointChangeType_MATCH,
			// Token: 0x04001F49 RID: 8009
			[Token(Token = "0x4001F49")]
			PlayerRacePointChangeType_PLAYER_LEAVES,
			// Token: 0x04001F4A RID: 8010
			[Token(Token = "0x4001F4A")]
			PlayerRacePointChangeType_EXCHANGE
		}

		// Token: 0x02000623 RID: 1571
		[Token(Token = "0x2000623")]
		[ProtoContract]
		public enum NewsType
		{
			// Token: 0x04001F4C RID: 8012
			[Token(Token = "0x4001F4C")]
			NewsType_NONE,
			// Token: 0x04001F4D RID: 8013
			[Token(Token = "0x4001F4D")]
			NewsType_JOIN,
			// Token: 0x04001F4E RID: 8014
			[Token(Token = "0x4001F4E")]
			NewsType_CHANGE_TYPE,
			// Token: 0x04001F4F RID: 8015
			[Token(Token = "0x4001F4F")]
			NewsType_EP_BUNDLE,
			// Token: 0x04001F50 RID: 8016
			[Token(Token = "0x4001F50")]
			NewsType_IAP,
			// Token: 0x04001F51 RID: 8017
			[Token(Token = "0x4001F51")]
			NewsType_LEVEL_UP,
			// Token: 0x04001F52 RID: 8018
			[Token(Token = "0x4001F52")]
			NewsType_OTHERS
		}

		// Token: 0x02000624 RID: 1572
		[Token(Token = "0x2000624")]
		[ProtoContract]
		public enum CreateLuckyBagEventType
		{
			// Token: 0x04001F54 RID: 8020
			[Token(Token = "0x4001F54")]
			CreateLuckyBagEventType_NONE,
			// Token: 0x04001F55 RID: 8021
			[Token(Token = "0x4001F55")]
			CreateLuckyBagEventType_EPBUNDLE,
			// Token: 0x04001F56 RID: 8022
			[Token(Token = "0x4001F56")]
			CreateLuckyBagEventType_IAP
		}
	}
}
