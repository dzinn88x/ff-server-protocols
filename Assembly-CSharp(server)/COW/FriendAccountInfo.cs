using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001E64 RID: 7780
	[Token(Token = "0x2001E64")]
	public class FriendAccountInfo : IComparable<FriendAccountInfo>
	{
		// Token: 0x0600AAC4 RID: 43716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC4")]
		[Address(RVA = "0x1B9A65C", Offset = "0x1B9A65C", VA = "0x7BBC39A65C")]
		public FriendAccountInfo()
		{
		}

		// Token: 0x0600AAC5 RID: 43717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC5")]
		[Address(RVA = "0x1B9A6C0", Offset = "0x1B9A6C0", VA = "0x7BBC39A6C0")]
		public FriendAccountInfo(ulong id, bool friend_flag)
		{
		}

		// Token: 0x0600AAC6 RID: 43718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC6")]
		[Address(RVA = "0x1B9A744", Offset = "0x1B9A744", VA = "0x7BBC39A744")]
		public void CopyFromAccountInfoWithPresence(AccountInfoWithPresence info)
		{
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AAC7")]
		[Address(RVA = "0x1B9AA10", Offset = "0x1B9AA10", VA = "0x7BBC39AA10")]
		private AccountInfoWithStats CreateEmptyAccountInfoStats()
		{
			return null;
		}

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC8")]
		[Address(RVA = "0x1B9AAA8", Offset = "0x1B9AAA8", VA = "0x7BBC39AAA8")]
		public void CopyFromBaseProfileInfo(BaseProfileInfo info)
		{
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AAC9")]
		[Address(RVA = "0x1B9ACBC", Offset = "0x1B9ACBC", VA = "0x7BBC39ACBC")]
		public void CopyFromAccountInfoBasic(AccountInfoBasic info)
		{
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACA")]
		[Address(RVA = "0x1B9AF94", Offset = "0x1B9AF94", VA = "0x7BBC39AF94")]
		public void CopyFromAccountInfoBase(AccountInfoBasic info)
		{
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AACB")]
		[Address(RVA = "0x1B9B0E4", Offset = "0x1B9B0E4", VA = "0x7BBC39B0E4")]
		public void SetSocialInfo(SocialBasicInfo info)
		{
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x0002EC68 File Offset: 0x0002CE68
		[Token(Token = "0x600AACC")]
		[Address(RVA = "0x1B9B170", Offset = "0x1B9B170", VA = "0x7BBC39B170", Slot = "4")]
		public int CompareTo(FriendAccountInfo other)
		{
			return 0;
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x0002EC80 File Offset: 0x0002CE80
		[Token(Token = "0x600AACD")]
		[Address(RVA = "0x1B9B730", Offset = "0x1B9B730", VA = "0x7BBC39B730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600AACE RID: 43726 RVA: 0x0002EC98 File Offset: 0x0002CE98
		[Token(Token = "0x600AACE")]
		[Address(RVA = "0x1B9B7DC", Offset = "0x1B9B7DC", VA = "0x7BBC39B7DC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0400AFA4 RID: 44964
		[Token(Token = "0x400AFA4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<EPresence.AccountPresence, int> AccountPresenceSortOrder;

		// Token: 0x0400AFA5 RID: 44965
		[Token(Token = "0x400AFA5")]
		[FieldOffset(Offset = "0x10")]
		public ulong account_id;

		// Token: 0x0400AFA6 RID: 44966
		[Token(Token = "0x400AFA6")]
		[FieldOffset(Offset = "0x18")]
		public uint account_type;

		// Token: 0x0400AFA7 RID: 44967
		[Token(Token = "0x400AFA7")]
		[FieldOffset(Offset = "0x20")]
		public string nickname;

		// Token: 0x0400AFA8 RID: 44968
		[Token(Token = "0x400AFA8")]
		[FieldOffset(Offset = "0x28")]
		public uint level;

		// Token: 0x0400AFA9 RID: 44969
		[Token(Token = "0x400AFA9")]
		[FieldOffset(Offset = "0x2C")]
		public uint exp;

		// Token: 0x0400AFAA RID: 44970
		[Token(Token = "0x400AFAA")]
		[FieldOffset(Offset = "0x30")]
		public EPresence.AccountPresence presence;

		// Token: 0x0400AFAB RID: 44971
		[Token(Token = "0x400AFAB")]
		[FieldOffset(Offset = "0x34")]
		public l}BQs\u0080\u0082 presenceGameMode;

		// Token: 0x0400AFAC RID: 44972
		[Token(Token = "0x400AFAC")]
		[FieldOffset(Offset = "0x38")]
		public f presenceMatchMode;

		// Token: 0x0400AFAD RID: 44973
		[Token(Token = "0x400AFAD")]
		[FieldOffset(Offset = "0x3C")]
		public uint presenceMapID;

		// Token: 0x0400AFAE RID: 44974
		[Token(Token = "0x400AFAE")]
		[FieldOffset(Offset = "0x40")]
		public string external_id;

		// Token: 0x0400AFAF RID: 44975
		[Token(Token = "0x400AFAF")]
		[FieldOffset(Offset = "0x48")]
		public ulong external_platform_id;

		// Token: 0x0400AFB0 RID: 44976
		[Token(Token = "0x400AFB0")]
		[FieldOffset(Offset = "0x50")]
		public uint external_type;

		// Token: 0x0400AFB1 RID: 44977
		[Token(Token = "0x400AFB1")]
		[FieldOffset(Offset = "0x58")]
		public long update_time;

		// Token: 0x0400AFB2 RID: 44978
		[Token(Token = "0x400AFB2")]
		[FieldOffset(Offset = "0x60")]
		public EAccountAdscription account_adscription;

		// Token: 0x0400AFB3 RID: 44979
		[Token(Token = "0x400AFB3")]
		[FieldOffset(Offset = "0x68")]
		public string external_name;

		// Token: 0x0400AFB4 RID: 44980
		[Token(Token = "0x400AFB4")]
		[FieldOffset(Offset = "0x70")]
		public string portrait;

		// Token: 0x0400AFB5 RID: 44981
		[Token(Token = "0x400AFB5")]
		[FieldOffset(Offset = "0x78")]
		public string region;

		// Token: 0x0400AFB6 RID: 44982
		[Token(Token = "0x400AFB6")]
		[FieldOffset(Offset = "0x80")]
		public ulong groupId;

		// Token: 0x0400AFB7 RID: 44983
		[Token(Token = "0x400AFB7")]
		[FieldOffset(Offset = "0x88")]
		public double solo_score;

		// Token: 0x0400AFB8 RID: 44984
		[Token(Token = "0x400AFB8")]
		[FieldOffset(Offset = "0x90")]
		public double duo_score;

		// Token: 0x0400AFB9 RID: 44985
		[Token(Token = "0x400AFB9")]
		[FieldOffset(Offset = "0x98")]
		public double quad_score;

		// Token: 0x0400AFBA RID: 44986
		[Token(Token = "0x400AFBA")]
		[FieldOffset(Offset = "0xA0")]
		public AccountInfoWithStats solo_stats;

		// Token: 0x0400AFBB RID: 44987
		[Token(Token = "0x400AFBB")]
		[FieldOffset(Offset = "0xA8")]
		public AccountInfoWithStats duo_stats;

		// Token: 0x0400AFBC RID: 44988
		[Token(Token = "0x400AFBC")]
		[FieldOffset(Offset = "0xB0")]
		public AccountInfoWithStats quad_stats;

		// Token: 0x0400AFBD RID: 44989
		[Token(Token = "0x400AFBD")]
		[FieldOffset(Offset = "0xB8")]
		public AccountInfoWithStats solo_stats_ranking;

		// Token: 0x0400AFBE RID: 44990
		[Token(Token = "0x400AFBE")]
		[FieldOffset(Offset = "0xC0")]
		public AccountInfoWithStats duo_stats_ranking;

		// Token: 0x0400AFBF RID: 44991
		[Token(Token = "0x400AFBF")]
		[FieldOffset(Offset = "0xC8")]
		public AccountInfoWithStats quad_stats_ranking;

		// Token: 0x0400AFC0 RID: 44992
		[Token(Token = "0x400AFC0")]
		[FieldOffset(Offset = "0xD0")]
		public AccountInfoWithStats solo_stats_casual;

		// Token: 0x0400AFC1 RID: 44993
		[Token(Token = "0x400AFC1")]
		[FieldOffset(Offset = "0xD8")]
		public AccountInfoWithStats duo_stats_casual;

		// Token: 0x0400AFC2 RID: 44994
		[Token(Token = "0x400AFC2")]
		[FieldOffset(Offset = "0xE0")]
		public AccountInfoWithStats quad_stats_casual;

		// Token: 0x0400AFC3 RID: 44995
		[Token(Token = "0x400AFC3")]
		[FieldOffset(Offset = "0xE8")]
		public AccountInfoWithStats cs_stats;

		// Token: 0x0400AFC4 RID: 44996
		[Token(Token = "0x400AFC4")]
		[FieldOffset(Offset = "0xF0")]
		public bool is_friend;

		// Token: 0x0400AFC5 RID: 44997
		[Token(Token = "0x400AFC5")]
		[FieldOffset(Offset = "0xF4")]
		public uint friend_intimacy;

		// Token: 0x0400AFC6 RID: 44998
		[Token(Token = "0x400AFC6")]
		[FieldOffset(Offset = "0xF8")]
		public uint rank;

		// Token: 0x0400AFC7 RID: 44999
		[Token(Token = "0x400AFC7")]
		[FieldOffset(Offset = "0xFC")]
		public uint ranking_points;

		// Token: 0x0400AFC8 RID: 45000
		[Token(Token = "0x400AFC8")]
		[FieldOffset(Offset = "0x100")]
		public uint csrank;

		// Token: 0x0400AFC9 RID: 45001
		[Token(Token = "0x400AFC9")]
		[FieldOffset(Offset = "0x104")]
		public uint csranking_points;

		// Token: 0x0400AFCA RID: 45002
		[Token(Token = "0x400AFCA")]
		[FieldOffset(Offset = "0x108")]
		public string clan_name;

		// Token: 0x0400AFCB RID: 45003
		[Token(Token = "0x400AFCB")]
		[FieldOffset(Offset = "0x110")]
		public ulong championship_team_id;

		// Token: 0x0400AFCC RID: 45004
		[Token(Token = "0x400AFCC")]
		[FieldOffset(Offset = "0x118")]
		public string championship_team_name;

		// Token: 0x0400AFCD RID: 45005
		[Token(Token = "0x400AFCD")]
		[FieldOffset(Offset = "0x120")]
		public uint championship_team_member_num;

		// Token: 0x0400AFCE RID: 45006
		[Token(Token = "0x400AFCE")]
		[FieldOffset(Offset = "0x124")]
		public uint banner_id;

		// Token: 0x0400AFCF RID: 45007
		[Token(Token = "0x400AFCF")]
		[FieldOffset(Offset = "0x128")]
		public uint headpic_id;

		// Token: 0x0400AFD0 RID: 45008
		[Token(Token = "0x400AFD0")]
		[FieldOffset(Offset = "0x12C")]
		public uint pin_id;

		// Token: 0x0400AFD1 RID: 45009
		[Token(Token = "0x400AFD1")]
		[FieldOffset(Offset = "0x130")]
		public uint ep_badgeId;

		// Token: 0x0400AFD2 RID: 45010
		[Token(Token = "0x400AFD2")]
		[FieldOffset(Offset = "0x134")]
		public bool is_ep;

		// Token: 0x0400AFD3 RID: 45011
		[Token(Token = "0x400AFD3")]
		[FieldOffset(Offset = "0x138")]
		public uint ep_badge_count;

		// Token: 0x0400AFD4 RID: 45012
		[Token(Token = "0x400AFD4")]
		[FieldOffset(Offset = "0x13C")]
		public bool ShowRank;

		// Token: 0x0400AFD5 RID: 45013
		[Token(Token = "0x400AFD5")]
		[FieldOffset(Offset = "0x140")]
		public long LastLoginAt;

		// Token: 0x0400AFD6 RID: 45014
		[Token(Token = "0x400AFD6")]
		[FieldOffset(Offset = "0x148")]
		public uint Role;

		// Token: 0x0400AFD7 RID: 45015
		[Token(Token = "0x400AFD7")]
		[FieldOffset(Offset = "0x14C")]
		public bool isCommonFriend;

		// Token: 0x0400AFD8 RID: 45016
		[Token(Token = "0x400AFD8")]
		[FieldOffset(Offset = "0x14D")]
		public bool isClanmate;

		// Token: 0x0400AFD9 RID: 45017
		[Token(Token = "0x400AFD9")]
		[FieldOffset(Offset = "0x14E")]
		public bool isRecentMate;

		// Token: 0x0400AFDA RID: 45018
		[Token(Token = "0x400AFDA")]
		[FieldOffset(Offset = "0x14F")]
		public bool is_cs_ranking_ban;

		// Token: 0x0400AFDB RID: 45019
		[Token(Token = "0x400AFDB")]
		[FieldOffset(Offset = "0x150")]
		public uint friendNumInSameChampionshipTeam;

		// Token: 0x0400AFDC RID: 45020
		[Token(Token = "0x400AFDC")]
		[FieldOffset(Offset = "0x158")]
		public long updateTime;

		// Token: 0x0400AFDD RID: 45021
		[Token(Token = "0x400AFDD")]
		[FieldOffset(Offset = "0x160")]
		public ESocial.Gender gender;

		// Token: 0x0400AFDE RID: 45022
		[Token(Token = "0x400AFDE")]
		[FieldOffset(Offset = "0x164")]
		public ESocial.Language language;

		// Token: 0x0400AFDF RID: 45023
		[Token(Token = "0x400AFDF")]
		[FieldOffset(Offset = "0x168")]
		public ESocial.ModePrefer modePrefer;

		// Token: 0x0400AFE0 RID: 45024
		[Token(Token = "0x400AFE0")]
		[FieldOffset(Offset = "0x16C")]
		public ESocial.TimeActive timeActive;

		// Token: 0x02001E65 RID: 7781
		[Token(Token = "0x2001E65")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC6B4", Offset = "0x10FC6B4")]
		private sealed class <>c__DisplayClass69_0
		{
			// Token: 0x0600AAD0 RID: 43728 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AAD0")]
			[Address(RVA = "0x1B9B728", Offset = "0x1B9B728", VA = "0x7BBC39B728")]
			public <>c__DisplayClass69_0()
			{
			}

			// Token: 0x0600AAD1 RID: 43729 RVA: 0x0002ECB0 File Offset: 0x0002CEB0
			[Token(Token = "0x600AAD1")]
			[Address(RVA = "0x1B9B984", Offset = "0x1B9B984", VA = "0x7BBC39B984")]
			internal bool <CompareTo>b__0(TeamMemberWithAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x0600AAD2 RID: 43730 RVA: 0x0002ECC8 File Offset: 0x0002CEC8
			[Token(Token = "0x600AAD2")]
			[Address(RVA = "0x1B9B9E8", Offset = "0x1B9B9E8", VA = "0x7BBC39B9E8")]
			internal bool <CompareTo>b__1(TeamMemberWithAccountInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AFE1 RID: 45025
			[Token(Token = "0x400AFE1")]
			[FieldOffset(Offset = "0x10")]
			public FriendAccountInfo <>4__this;

			// Token: 0x0400AFE2 RID: 45026
			[Token(Token = "0x400AFE2")]
			[FieldOffset(Offset = "0x18")]
			public FriendAccountInfo other;
		}
	}
}
