using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using tcp;

namespace COW
{
	// Token: 0x02001EC2 RID: 7874
	[Token(Token = "0x2001EC2")]
	internal class UIModelGroup : UIBaseModel
	{
		// Token: 0x0600ACAC RID: 44204 RVA: 0x0002FAF0 File Offset: 0x0002DCF0
		[Token(Token = "0x600ACAC")]
		[Address(RVA = "0x2325AF4", Offset = "0x2325AF4", VA = "0x7BBCB25AF4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600ACAD RID: 44205 RVA: 0x0002FB08 File Offset: 0x0002DD08
		// (set) Token: 0x0600ACAE RID: 44206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B67")]
		public bool IsGroupLeader
		{
			[Token(Token = "0x600ACAD")]
			[Address(RVA = "0x2325AFC", Offset = "0x2325AFC", VA = "0x7BBCB25AFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114641C", Offset = "0x114641C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ACAE")]
			[Address(RVA = "0x2325B04", Offset = "0x2325B04", VA = "0x7BBCB25B04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114642C", Offset = "0x114642C")]
			private set
			{
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600ACAF RID: 44207 RVA: 0x0002FB20 File Offset: 0x0002DD20
		// (set) Token: 0x0600ACB0 RID: 44208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B68")]
		public bool IsGroupPublic
		{
			[Token(Token = "0x600ACAF")]
			[Address(RVA = "0x2325B10", Offset = "0x2325B10", VA = "0x7BBCB25B10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ACB0")]
			[Address(RVA = "0x2325B18", Offset = "0x2325B18", VA = "0x7BBCB25B18")]
			set
			{
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600ACB1 RID: 44209 RVA: 0x0002FB38 File Offset: 0x0002DD38
		[Token(Token = "0x17000B69")]
		public bool IsRankingMatch
		{
			[Token(Token = "0x600ACB1")]
			[Address(RVA = "0x2325B24", Offset = "0x2325B24", VA = "0x7BBCB25B24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600ACB2 RID: 44210 RVA: 0x0002FB50 File Offset: 0x0002DD50
		[Token(Token = "0x17000B6A")]
		public uint GameMode
		{
			[Token(Token = "0x600ACB2")]
			[Address(RVA = "0x2325BB8", Offset = "0x2325BB8", VA = "0x7BBCB25BB8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB3")]
		[Address(RVA = "0x2325C48", Offset = "0x2325C48", VA = "0x7BBCB25C48")]
		public void AddIgnorePlayer(ulong accountId)
		{
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB4")]
		[Address(RVA = "0x2325D70", Offset = "0x2325D70", VA = "0x7BBCB25D70")]
		public void RemoveIgnorePlayer(ulong accountId)
		{
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x0002FB68 File Offset: 0x0002DD68
		[Token(Token = "0x600ACB5")]
		[Address(RVA = "0x2325E1C", Offset = "0x2325E1C", VA = "0x7BBCB25E1C")]
		public bool HasRelationshipPlayerInGroup(ulong friendID)
		{
			return default(bool);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x0002FB80 File Offset: 0x0002DD80
		[Token(Token = "0x600ACB6")]
		[Address(RVA = "0x2325F8C", Offset = "0x2325F8C", VA = "0x7BBCB25F8C")]
		public bool CheckIsInIgnoreList(ulong accountId)
		{
			return default(bool);
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x0002FB98 File Offset: 0x0002DD98
		[Token(Token = "0x600ACB7")]
		[Address(RVA = "0x2326074", Offset = "0x2326074", VA = "0x7BBCB26074")]
		public bool ReachMaxGroupCount()
		{
			return default(bool);
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB8")]
		[Address(RVA = "0x23261D4", Offset = "0x23261D4", VA = "0x7BBCB261D4")]
		public void RequestCreateGroup(uint map_id = 1U, bool isRanking = false, uint game_mode = 1U, zTfbhtW group_mode = zTfbhtW.EGROUPMODE_DUAL, uint difficulty = 0U, uint match_mode = 1U, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0U, string groupTag = "")
		{
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACB9")]
		[Address(RVA = "0x23264D8", Offset = "0x23264D8", VA = "0x7BBCB264D8")]
		private void RequestCreateGroupInternal(uint map_id = 1U, bool isRanking = false, uint game_mode = 1U, zTfbhtW group_mode = zTfbhtW.EGROUPMODE_DUAL, uint difficulty = 0U, uint match_mode = 1U, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF, bool isRandomMap = false, uint requireRank = 0U, string groupTag = "")
		{
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBA")]
		[Address(RVA = "0x2327124", Offset = "0x2327124", VA = "0x7BBCB27124")]
		public void RequestJoinGroup(ulong account_id, ulong groupId, EGroup.InviteeType inviteType)
		{
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBB")]
		[Address(RVA = "0x2327304", Offset = "0x2327304", VA = "0x7BBCB27304")]
		private void RequestJoinGroupInternal(ulong account_id, ulong groupId, EGroup.InviteeType inviteType)
		{
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBC")]
		[Address(RVA = "0x2327F54", Offset = "0x2327F54", VA = "0x7BBCB27F54")]
		public void RequestInvite(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
		{
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBD")]
		[Address(RVA = "0x23283DC", Offset = "0x23283DC", VA = "0x7BBCB283DC")]
		public void RequestAccept(ulong group_id, string region, ulong inviterid = 0UL, string group_code = "", EGroup.InviteChannelType channel = EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "")
		{
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBE")]
		[Address(RVA = "0x2328644", Offset = "0x2328644", VA = "0x7BBCB28644")]
		private void RequestAcceptInternal(ulong group_id, string region, ulong inviterid = 0UL, string group_code = "", EGroup.InviteChannelType channel = EGroup.InviteChannelType.InviteChannelType_PLAYER, string secretCode = "")
		{
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACBF")]
		[Address(RVA = "0x2329298", Offset = "0x2329298", VA = "0x7BBCB29298")]
		public void RequestRefuse(ulong group_id, string region, GroupInviteNtf inviteNtfData)
		{
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC0")]
		[Address(RVA = "0x2329460", Offset = "0x2329460", VA = "0x7BBCB29460")]
		public void RequestAcceptGroupJoinRequest(ulong group_id, GroupJoinRequestNtf ntf)
		{
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC1")]
		[Address(RVA = "0x23297AC", Offset = "0x23297AC", VA = "0x7BBCB297AC")]
		public void RequestRefuseGroupJoinRequest(ulong group_id, GroupJoinRequestNtf inviteNtfData)
		{
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC2")]
		[Address(RVA = "0x23299E8", Offset = "0x23299E8", VA = "0x7BBCB299E8")]
		public void RequestLeave()
		{
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC3")]
		[Address(RVA = "0x2329CC4", Offset = "0x2329CC4", VA = "0x7BBCB29CC4")]
		public void RequestKickout(ulong kickout_id)
		{
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC4")]
		[Address(RVA = "0x2329E50", Offset = "0x2329E50", VA = "0x7BBCB29E50")]
		public void RequestChangePubPvt(bool isPublic)
		{
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC5")]
		[Address(RVA = "0x2329F40", Offset = "0x2329F40", VA = "0x7BBCB29F40")]
		public void RequestShowEmote(uint _eid)
		{
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACC6")]
		[Address(RVA = "0x232A0AC", Offset = "0x232A0AC", VA = "0x7BBCB2A0AC")]
		public List<ulong> GetFriendsInGroup()
		{
			return null;
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC7")]
		[Address(RVA = "0x232A318", Offset = "0x232A318", VA = "0x7BBCB2A318")]
		public void RequestStart()
		{
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC8")]
		[Address(RVA = "0x232A480", Offset = "0x232A480", VA = "0x7BBCB2A480")]
		public void RequestStop()
		{
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC9")]
		[Address(RVA = "0x232A580", Offset = "0x232A580", VA = "0x7BBCB2A580")]
		public void RequestGroupInfo()
		{
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCA")]
		[Address(RVA = "0x232A680", Offset = "0x232A680", VA = "0x7BBCB2A680")]
		public void RequestUpdateMaps(List<uint> maps)
		{
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCB")]
		[Address(RVA = "0x232A804", Offset = "0x232A804", VA = "0x7BBCB2A804")]
		public void UpdatePlayerAvailableMaps(GroupChangeAvailableMapsNtf info)
		{
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x0002FBB0 File Offset: 0x0002DDB0
		[Token(Token = "0x600ACCC")]
		[Address(RVA = "0x232A9BC", Offset = "0x232A9BC", VA = "0x7BBCB2A9BC")]
		public static bool IsForceAutoMatchGameMode(uint gamemode)
		{
			return default(bool);
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x0002FBC8 File Offset: 0x0002DDC8
		[Token(Token = "0x600ACCD")]
		[Address(RVA = "0x232A9FC", Offset = "0x232A9FC", VA = "0x7BBCB2A9FC")]
		public bool IsCantSoloMatchMakingGame(uint gamemode)
		{
			return default(bool);
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCE")]
		[Address(RVA = "0x232AA08", Offset = "0x232AA08", VA = "0x7BBCB2AA08")]
		public void UpdateGroupInfo(GroupInfo resData, bool isNew = false)
		{
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCF")]
		[Address(RVA = "0x232B2F8", Offset = "0x232B2F8", VA = "0x7BBCB2B2F8")]
		public void SetAfterCreateIntent(UIModelGroup.IntentToDo todo)
		{
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD0")]
		[Address(RVA = "0x232B430", Offset = "0x232B430", VA = "0x7BBCB2B430")]
		public void DoAfterCreateGroup()
		{
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD1")]
		[Address(RVA = "0x232B6C4", Offset = "0x232B6C4", VA = "0x7BBCB2B6C4")]
		public void SetIntentInviteInfo(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
		{
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD2")]
		[Address(RVA = "0x232B4FC", Offset = "0x232B4FC", VA = "0x7BBCB2B4FC")]
		public void DoIntentInvite()
		{
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD3")]
		[Address(RVA = "0x232B3D0", Offset = "0x232B3D0", VA = "0x7BBCB2B3D0")]
		public void ClearIntentInviteInfo()
		{
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD4")]
		[Address(RVA = "0x232B774", Offset = "0x232B774", VA = "0x7BBCB2B774")]
		public void UpdateInviterGroupInfo(GroupInviteNtf resData)
		{
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACD5")]
		[Address(RVA = "0x232B77C", Offset = "0x232B77C", VA = "0x7BBCB2B77C")]
		public List<ulong> GetMemberIds()
		{
			return null;
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD6")]
		[Address(RVA = "0x2329B64", Offset = "0x2329B64", VA = "0x7BBCB29B64")]
		public void ClearData()
		{
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		[Token(Token = "0x600ACD7")]
		[Address(RVA = "0x232B978", Offset = "0x232B978", VA = "0x7BBCB2B978")]
		public int GetGroupMembersCount()
		{
			return 0;
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD8")]
		[Address(RVA = "0x232B9F0", Offset = "0x232B9F0", VA = "0x7BBCB2B9F0", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD9")]
		[Address(RVA = "0x232B9F4", Offset = "0x232B9F4", VA = "0x7BBCB2B9F4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDA")]
		[Address(RVA = "0x232BAF0", Offset = "0x232BAF0", VA = "0x7BBCB2BAF0")]
		public void SetGroupMode(zTfbhtW mode, bool request = true)
		{
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDB")]
		[Address(RVA = "0x232C1AC", Offset = "0x232C1AC", VA = "0x7BBCB2C1AC")]
		public void SetAutoMatch(bool v)
		{
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDC")]
		[Address(RVA = "0x232BC2C", Offset = "0x232BC2C", VA = "0x7BBCB2BC2C")]
		public void RequestGroupChange(MapModeData mapData, uint difficutly = 0U, uint rankLimit = 0U, string groupTags = "")
		{
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDD")]
		[Address(RVA = "0x232C2E8", Offset = "0x232C2E8", VA = "0x7BBCB2C2E8")]
		public void RequestReady()
		{
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDE")]
		[Address(RVA = "0x232C43C", Offset = "0x232C43C", VA = "0x7BBCB2C43C")]
		public void RequestGroupCode()
		{
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDF")]
		[Address(RVA = "0x232C530", Offset = "0x232C530", VA = "0x7BBCB2C530")]
		public void SetEndReason(int reason)
		{
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE0")]
		[Address(RVA = "0x232C538", Offset = "0x232C538", VA = "0x7BBCB2C538")]
		public void SetGroupReady()
		{
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x0002FBF8 File Offset: 0x0002DDF8
		[Token(Token = "0x600ACE1")]
		[Address(RVA = "0x232C57C", Offset = "0x232C57C", VA = "0x7BBCB2C57C")]
		public uint GetPlayersLimitsByMode(zTfbhtW mode)
		{
			return 0U;
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x0002FC10 File Offset: 0x0002DE10
		[Token(Token = "0x600ACE2")]
		[Address(RVA = "0x232C59C", Offset = "0x232C59C", VA = "0x7BBCB2C59C")]
		public zTfbhtW GetGroupModeByMaxPlayerCount(uint playerCount)
		{
			return zTfbhtW.EGROUPMODE_SOLO;
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE3")]
		[Address(RVA = "0x232C5D0", Offset = "0x232C5D0", VA = "0x7BBCB2C5D0")]
		public void CheckAvailableMaps(uint[] maps)
		{
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x0002FC28 File Offset: 0x0002DE28
		[Token(Token = "0x600ACE4")]
		[Address(RVA = "0x232C978", Offset = "0x232C978", VA = "0x7BBCB2C978")]
		public bool CheckMemberLackOfMaps(uint mapId, bool showTips = true)
		{
			return default(bool);
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE5")]
		[Address(RVA = "0x232CDA4", Offset = "0x232CDA4", VA = "0x7BBCB2CDA4")]
		public void UpdateGroupCode(string groupCode)
		{
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x0002FC40 File Offset: 0x0002DE40
		[Token(Token = "0x600ACE6")]
		[Address(RVA = "0x232CDB8", Offset = "0x232CDB8", VA = "0x7BBCB2CDB8")]
		public bool IsLeftMode()
		{
			return default(bool);
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE7")]
		[Address(RVA = "0x232CE58", Offset = "0x232CE58", VA = "0x7BBCB2CE58")]
		public UIModelGroup()
		{
		}

		// Token: 0x0400B12E RID: 45358
		[Token(Token = "0x400B12E")]
		[FieldOffset(Offset = "0x18")]
		public GroupInfo GroupInfo;

		// Token: 0x0400B12F RID: 45359
		[Token(Token = "0x400B12F")]
		[FieldOffset(Offset = "0x20")]
		public GroupMemberInfo MyInfo;

		// Token: 0x0400B130 RID: 45360
		[Token(Token = "0x400B130")]
		[FieldOffset(Offset = "0x28")]
		public GroupInviteNtf InviterGroupInfo;

		// Token: 0x0400B131 RID: 45361
		[Token(Token = "0x400B131")]
		[FieldOffset(Offset = "0x30")]
		private List<ulong> m_GroupMemberIds;

		// Token: 0x0400B132 RID: 45362
		[Token(Token = "0x400B132")]
		[FieldOffset(Offset = "0x38")]
		public zTfbhtW GroupMode;

		// Token: 0x0400B133 RID: 45363
		[Token(Token = "0x400B133")]
		[FieldOffset(Offset = "0x3C")]
		public bool IsAutoMatch;

		// Token: 0x0400B134 RID: 45364
		[Token(Token = "0x400B134")]
		[FieldOffset(Offset = "0x3D")]
		public bool AllReady;

		// Token: 0x0400B135 RID: 45365
		[Token(Token = "0x400B135")]
		[FieldOffset(Offset = "0x40")]
		private int m_SpecialReason;

		// Token: 0x0400B136 RID: 45366
		[Token(Token = "0x400B136")]
		[FieldOffset(Offset = "0x0")]
		public static int GROUP_DUO_MEMBER_COUNT;

		// Token: 0x0400B137 RID: 45367
		[Token(Token = "0x400B137")]
		[FieldOffset(Offset = "0x4")]
		public static int GROUP_QUARD_MEMBER_COUNT;

		// Token: 0x0400B138 RID: 45368
		[Token(Token = "0x400B138")]
		public const uint PropID_GroupInfo_Update = 2U;

		// Token: 0x0400B139 RID: 45369
		[Token(Token = "0x400B139")]
		public const uint PropID_GroupInfo_Clear = 4U;

		// Token: 0x0400B13A RID: 45370
		[Token(Token = "0x400B13A")]
		[FieldOffset(Offset = "0x44")]
		private UIModelGroup.IntentToDo m_IntentAfterCreate;

		// Token: 0x0400B13B RID: 45371
		[Token(Token = "0x400B13B")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113007C", Offset = "0x113007C")]
		private bool <IsGroupLeader>k__BackingField;

		// Token: 0x0400B13C RID: 45372
		[Token(Token = "0x400B13C")]
		[FieldOffset(Offset = "0x49")]
		private bool m_IsGroupPublic;

		// Token: 0x0400B13D RID: 45373
		[Token(Token = "0x400B13D")]
		[FieldOffset(Offset = "0x4A")]
		public bool IsGroupMatchMaking;

		// Token: 0x0400B13E RID: 45374
		[Token(Token = "0x400B13E")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<ulong, ulong> m_IgnorePlayerDict;

		// Token: 0x0400B13F RID: 45375
		[Token(Token = "0x400B13F")]
		[FieldOffset(Offset = "0x58")]
		private List<UIModelGroup.IntentInviteInfo> m_IntentInviteInfoList;

		// Token: 0x02001EC3 RID: 7875
		[Token(Token = "0x2001EC3")]
		public enum IntentToDo
		{
			// Token: 0x0400B141 RID: 45377
			[Token(Token = "0x400B141")]
			None,
			// Token: 0x0400B142 RID: 45378
			[Token(Token = "0x400B142")]
			Invite,
			// Token: 0x0400B143 RID: 45379
			[Token(Token = "0x400B143")]
			Recruit
		}

		// Token: 0x02001EC4 RID: 7876
		[Token(Token = "0x2001EC4")]
		public class IntentInviteInfo
		{
			// Token: 0x0600ACE9 RID: 44265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACE9")]
			[Address(RVA = "0x236AF10", Offset = "0x236AF10", VA = "0x7BBCB6AF10")]
			public IntentInviteInfo(ulong account_id, string region, EGroup.InviteChannelType channel, EGroup.InviteeType inviteeType = EGroup.InviteeType.InviteeType_NONE)
			{
			}

			// Token: 0x0400B144 RID: 45380
			[Token(Token = "0x400B144")]
			[FieldOffset(Offset = "0x10")]
			public ulong m_AccountID;

			// Token: 0x0400B145 RID: 45381
			[Token(Token = "0x400B145")]
			[FieldOffset(Offset = "0x18")]
			public string m_Region;

			// Token: 0x0400B146 RID: 45382
			[Token(Token = "0x400B146")]
			[FieldOffset(Offset = "0x20")]
			public EGroup.InviteChannelType m_Channel;

			// Token: 0x0400B147 RID: 45383
			[Token(Token = "0x400B147")]
			[FieldOffset(Offset = "0x24")]
			public EGroup.InviteeType m_InviteeType;
		}

		// Token: 0x02001EC5 RID: 7877
		[Token(Token = "0x2001EC5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB14", Offset = "0x10FCB14")]
		private sealed class <>c__DisplayClass34_0
		{
			// Token: 0x0600ACEA RID: 44266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACEA")]
			[Address(RVA = "0x236AB44", Offset = "0x236AB44", VA = "0x7BBCB6AB44")]
			public <>c__DisplayClass34_0()
			{
			}

			// Token: 0x0600ACEB RID: 44267 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACEB")]
			[Address(RVA = "0x236AB4C", Offset = "0x236AB4C", VA = "0x7BBCB6AB4C")]
			internal void <RequestCreateGroup>b__0(ResErrorCode error, ResDownloadType download_type)
			{
			}

			// Token: 0x0400B148 RID: 45384
			[Token(Token = "0x400B148")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGroup <>4__this;

			// Token: 0x0400B149 RID: 45385
			[Token(Token = "0x400B149")]
			[FieldOffset(Offset = "0x18")]
			public uint map_id;

			// Token: 0x0400B14A RID: 45386
			[Token(Token = "0x400B14A")]
			[FieldOffset(Offset = "0x1C")]
			public bool isRanking;

			// Token: 0x0400B14B RID: 45387
			[Token(Token = "0x400B14B")]
			[FieldOffset(Offset = "0x20")]
			public uint game_mode;

			// Token: 0x0400B14C RID: 45388
			[Token(Token = "0x400B14C")]
			[FieldOffset(Offset = "0x24")]
			public zTfbhtW group_mode;

			// Token: 0x0400B14D RID: 45389
			[Token(Token = "0x400B14D")]
			[FieldOffset(Offset = "0x28")]
			public uint difficulty;

			// Token: 0x0400B14E RID: 45390
			[Token(Token = "0x400B14E")]
			[FieldOffset(Offset = "0x2C")]
			public uint match_mode;

			// Token: 0x0400B14F RID: 45391
			[Token(Token = "0x400B14F")]
			[FieldOffset(Offset = "0x30")]
			public EGroup.CreateFromType fromType;

			// Token: 0x0400B150 RID: 45392
			[Token(Token = "0x400B150")]
			[FieldOffset(Offset = "0x34")]
			public bool isRandomMap;

			// Token: 0x0400B151 RID: 45393
			[Token(Token = "0x400B151")]
			[FieldOffset(Offset = "0x38")]
			public uint requireRank;

			// Token: 0x0400B152 RID: 45394
			[Token(Token = "0x400B152")]
			[FieldOffset(Offset = "0x40")]
			public string groupTag;
		}

		// Token: 0x02001EC6 RID: 7878
		[Token(Token = "0x2001EC6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB24", Offset = "0x10FCB24")]
		private sealed class <>c__DisplayClass36_0
		{
			// Token: 0x0600ACEC RID: 44268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACEC")]
			[Address(RVA = "0x236AC94", Offset = "0x236AC94", VA = "0x7BBCB6AC94")]
			public <>c__DisplayClass36_0()
			{
			}

			// Token: 0x0600ACED RID: 44269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACED")]
			[Address(RVA = "0x236AC9C", Offset = "0x236AC9C", VA = "0x7BBCB6AC9C")]
			internal void <RequestJoinGroup>b__0(ResErrorCode error, ResDownloadType download_type)
			{
			}

			// Token: 0x0400B153 RID: 45395
			[Token(Token = "0x400B153")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGroup <>4__this;

			// Token: 0x0400B154 RID: 45396
			[Token(Token = "0x400B154")]
			[FieldOffset(Offset = "0x18")]
			public ulong account_id;

			// Token: 0x0400B155 RID: 45397
			[Token(Token = "0x400B155")]
			[FieldOffset(Offset = "0x20")]
			public ulong groupId;

			// Token: 0x0400B156 RID: 45398
			[Token(Token = "0x400B156")]
			[FieldOffset(Offset = "0x28")]
			public EGroup.InviteeType inviteType;
		}

		// Token: 0x02001EC7 RID: 7879
		[Token(Token = "0x2001EC7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB34", Offset = "0x10FCB34")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600ACEE RID: 44270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACEE")]
			[Address(RVA = "0x236AD8C", Offset = "0x236AD8C", VA = "0x7BBCB6AD8C")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0600ACEF RID: 44271 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACEF")]
			[Address(RVA = "0x236AD94", Offset = "0x236AD94", VA = "0x7BBCB6AD94")]
			internal void <RequestAccept>b__0(ResErrorCode error, ResDownloadType type)
			{
			}

			// Token: 0x0400B157 RID: 45399
			[Token(Token = "0x400B157")]
			[FieldOffset(Offset = "0x10")]
			public UIModelGroup <>4__this;

			// Token: 0x0400B158 RID: 45400
			[Token(Token = "0x400B158")]
			[FieldOffset(Offset = "0x18")]
			public ulong group_id;

			// Token: 0x0400B159 RID: 45401
			[Token(Token = "0x400B159")]
			[FieldOffset(Offset = "0x20")]
			public string region;

			// Token: 0x0400B15A RID: 45402
			[Token(Token = "0x400B15A")]
			[FieldOffset(Offset = "0x28")]
			public ulong inviterid;

			// Token: 0x0400B15B RID: 45403
			[Token(Token = "0x400B15B")]
			[FieldOffset(Offset = "0x30")]
			public string group_code;

			// Token: 0x0400B15C RID: 45404
			[Token(Token = "0x400B15C")]
			[FieldOffset(Offset = "0x38")]
			public EGroup.InviteChannelType channel;

			// Token: 0x0400B15D RID: 45405
			[Token(Token = "0x400B15D")]
			[FieldOffset(Offset = "0x40")]
			public string secretCode;
		}

		// Token: 0x02001EC8 RID: 7880
		[Token(Token = "0x2001EC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB44", Offset = "0x10FCB44")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600ACF1 RID: 44273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACF1")]
			[Address(RVA = "0x236AA60", Offset = "0x236AA60", VA = "0x7BBCB6AA60")]
			public <>c()
			{
			}

			// Token: 0x0600ACF2 RID: 44274 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ACF2")]
			[Address(RVA = "0x236AA68", Offset = "0x236AA68", VA = "0x7BBCB6AA68")]
			internal string <RequestAcceptInternal>b__40_0(uint i)
			{
				return null;
			}

			// Token: 0x0600ACF3 RID: 44275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600ACF3")]
			[Address(RVA = "0x236AAE0", Offset = "0x236AAE0", VA = "0x7BBCB6AAE0")]
			internal string <RequestAcceptInternal>b__40_1(string s1, string s2)
			{
				return null;
			}

			// Token: 0x0400B15E RID: 45406
			[Token(Token = "0x400B15E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelGroup.<>c <>9;

			// Token: 0x0400B15F RID: 45407
			[Token(Token = "0x400B15F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<uint, string> <>9__40_0;

			// Token: 0x0400B160 RID: 45408
			[Token(Token = "0x400B160")]
			[FieldOffset(Offset = "0x10")]
			public static Func<string, string, string> <>9__40_1;
		}

		// Token: 0x02001EC9 RID: 7881
		[Token(Token = "0x2001EC9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB54", Offset = "0x10FCB54")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x0600ACF4 RID: 44276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACF4")]
			[Address(RVA = "0x236AE04", Offset = "0x236AE04", VA = "0x7BBCB6AE04")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x0600ACF5 RID: 44277 RVA: 0x0002FC58 File Offset: 0x0002DE58
			[Token(Token = "0x600ACF5")]
			[Address(RVA = "0x236AE0C", Offset = "0x236AE0C", VA = "0x7BBCB6AE0C")]
			internal bool <RequestKickout>b__0(GroupMemberInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400B161 RID: 45409
			[Token(Token = "0x400B161")]
			[FieldOffset(Offset = "0x10")]
			public ulong kickout_id;
		}

		// Token: 0x02001ECA RID: 7882
		[Token(Token = "0x2001ECA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB64", Offset = "0x10FCB64")]
		private sealed class <>c__DisplayClass56_0
		{
			// Token: 0x0600ACF6 RID: 44278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACF6")]
			[Address(RVA = "0x236AE68", Offset = "0x236AE68", VA = "0x7BBCB6AE68")]
			public <>c__DisplayClass56_0()
			{
			}

			// Token: 0x0600ACF7 RID: 44279 RVA: 0x0002FC70 File Offset: 0x0002DE70
			[Token(Token = "0x600ACF7")]
			[Address(RVA = "0x236AE70", Offset = "0x236AE70", VA = "0x7BBCB6AE70")]
			internal bool <UpdateGroupInfo>b__0(GroupMemberInfo m)
			{
				return default(bool);
			}

			// Token: 0x0600ACF8 RID: 44280 RVA: 0x0002FC88 File Offset: 0x0002DE88
			[Token(Token = "0x600ACF8")]
			[Address(RVA = "0x236AEB4", Offset = "0x236AEB4", VA = "0x7BBCB6AEB4")]
			internal bool <UpdateGroupInfo>b__1(GroupMemberInfo mem)
			{
				return default(bool);
			}

			// Token: 0x0400B162 RID: 45410
			[Token(Token = "0x400B162")]
			[FieldOffset(Offset = "0x10")]
			public ulong myId;
		}

		// Token: 0x02001ECB RID: 7883
		[Token(Token = "0x2001ECB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FCB74", Offset = "0x10FCB74")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600ACF9 RID: 44281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600ACF9")]
			[Address(RVA = "0x236AEF8", Offset = "0x236AEF8", VA = "0x7BBCB6AEF8")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600ACFA RID: 44282 RVA: 0x0002FCA0 File Offset: 0x0002DEA0
			[Token(Token = "0x600ACFA")]
			[Address(RVA = "0x236AF00", Offset = "0x236AF00", VA = "0x7BBCB6AF00")]
			internal bool <CheckMemberLackOfMaps>b__0(uint a)
			{
				return default(bool);
			}

			// Token: 0x0400B163 RID: 45411
			[Token(Token = "0x400B163")]
			[FieldOffset(Offset = "0x10")]
			public uint mapId;

			// Token: 0x0400B164 RID: 45412
			[Token(Token = "0x400B164")]
			[FieldOffset(Offset = "0x18")]
			public Predicate<uint> <>9__0;
		}
	}
}
