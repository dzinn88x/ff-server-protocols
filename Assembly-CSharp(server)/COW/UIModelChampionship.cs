using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001DA9 RID: 7593
	[Token(Token = "0x2001DA9")]
	public class UIModelChampionship : UIBaseModel
	{
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x0600A604 RID: 42500 RVA: 0x0002C628 File Offset: 0x0002A828
		// (set) Token: 0x0600A605 RID: 42501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AEB")]
		public bool TeamMemberInitialized
		{
			[Token(Token = "0x600A604")]
			[Address(RVA = "0x22E577C", Offset = "0x22E577C", VA = "0x7BBCAE577C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C3C", Offset = "0x1145C3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A605")]
			[Address(RVA = "0x22E5784", Offset = "0x22E5784", VA = "0x7BBCAE5784")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C4C", Offset = "0x1145C4C")]
			set
			{
			}
		}

		// Token: 0x0600A606 RID: 42502 RVA: 0x0002C640 File Offset: 0x0002A840
		[Token(Token = "0x600A606")]
		[Address(RVA = "0x22E5790", Offset = "0x22E5790", VA = "0x7BBCAE5790", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A607 RID: 42503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A607")]
		[Address(RVA = "0x22E5798", Offset = "0x22E5798", VA = "0x7BBCAE5798", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A608 RID: 42504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A608")]
		[Address(RVA = "0x22E57C0", Offset = "0x22E57C0", VA = "0x7BBCAE57C0", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A609 RID: 42505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A609")]
		[Address(RVA = "0x22E5860", Offset = "0x22E5860", VA = "0x7BBCAE5860", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A60A RID: 42506 RVA: 0x0002C658 File Offset: 0x0002A858
		[Token(Token = "0x600A60A")]
		[Address(RVA = "0x22E5AB0", Offset = "0x22E5AB0", VA = "0x7BBCAE5AB0")]
		public bool SelfHasTeam()
		{
			return default(bool);
		}

		// Token: 0x0600A60B RID: 42507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A60B")]
		[Address(RVA = "0x22E5AC8", Offset = "0x22E5AC8", VA = "0x7BBCAE5AC8")]
		public TeamInfo SelfTeamInfo()
		{
			return null;
		}

		// Token: 0x0600A60C RID: 42508 RVA: 0x0002C670 File Offset: 0x0002A870
		[Token(Token = "0x600A60C")]
		[Address(RVA = "0x22E5AC0", Offset = "0x22E5AC0", VA = "0x7BBCAE5AC0")]
		public ulong SelfTeamID()
		{
			return 0UL;
		}

		// Token: 0x0600A60D RID: 42509 RVA: 0x0002C688 File Offset: 0x0002A888
		[Token(Token = "0x600A60D")]
		[Address(RVA = "0x22E5AD0", Offset = "0x22E5AD0", VA = "0x7BBCAE5AD0")]
		public bool SelfIsCaptain()
		{
			return default(bool);
		}

		// Token: 0x0600A60E RID: 42510 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		[Token(Token = "0x600A60E")]
		[Address(RVA = "0x22E5BA8", Offset = "0x22E5BA8", VA = "0x7BBCAE5BA8")]
		public uint PlayerNumberLimit(uint cptype)
		{
			return 0U;
		}

		// Token: 0x0600A60F RID: 42511 RVA: 0x0002C6B8 File Offset: 0x0002A8B8
		[Token(Token = "0x600A60F")]
		[Address(RVA = "0x22E5C64", Offset = "0x22E5C64", VA = "0x7BBCAE5C64")]
		public uint PlayerNumberLimit(uint cptype, uint cpid)
		{
			return 0U;
		}

		// Token: 0x0600A610 RID: 42512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A610")]
		[Address(RVA = "0x22E5DA8", Offset = "0x22E5DA8", VA = "0x7BBCAE5DA8")]
		public ChampionshipTeamDesc TeamSetting(uint cptype)
		{
			return null;
		}

		// Token: 0x0600A611 RID: 42513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A611")]
		[Address(RVA = "0x22E5C80", Offset = "0x22E5C80", VA = "0x7BBCAE5C80")]
		public ChampionshipTeamDesc TeamSetting(uint cptype, uint cpid)
		{
			return null;
		}

		// Token: 0x0600A612 RID: 42514 RVA: 0x0002C6D0 File Offset: 0x0002A8D0
		[Token(Token = "0x600A612")]
		[Address(RVA = "0x22E5F1C", Offset = "0x22E5F1C", VA = "0x7BBCAE5F1C")]
		public uint GetLevelLowerLimit()
		{
			return 0U;
		}

		// Token: 0x0600A613 RID: 42515 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		[Token(Token = "0x600A613")]
		[Address(RVA = "0x22E5F3C", Offset = "0x22E5F3C", VA = "0x7BBCAE5F3C")]
		public uint GetLevelUpperLimit()
		{
			return 0U;
		}

		// Token: 0x0600A614 RID: 42516 RVA: 0x0002C700 File Offset: 0x0002A900
		[Token(Token = "0x600A614")]
		[Address(RVA = "0x22E5F5C", Offset = "0x22E5F5C", VA = "0x7BBCAE5F5C")]
		public uint GetLadderScoreLowerLimit()
		{
			return 0U;
		}

		// Token: 0x0600A615 RID: 42517 RVA: 0x0002C718 File Offset: 0x0002A918
		[Token(Token = "0x600A615")]
		[Address(RVA = "0x22E5F74", Offset = "0x22E5F74", VA = "0x7BBCAE5F74")]
		public uint GetLadderScoreUpperLimit()
		{
			return 0U;
		}

		// Token: 0x0600A616 RID: 42518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A616")]
		[Address(RVA = "0x22E5F94", Offset = "0x22E5F94", VA = "0x7BBCAE5F94")]
		public List<TeamMemberWithAccountInfo> SelfTeamMembers(bool includeSelf = true)
		{
			return null;
		}

		// Token: 0x0600A617 RID: 42519 RVA: 0x0002C730 File Offset: 0x0002A930
		[Token(Token = "0x600A617")]
		[Address(RVA = "0x22E6100", Offset = "0x22E6100", VA = "0x7BBCAE6100")]
		public bool IsFriendInTeam(FriendAccountInfo friendInfo)
		{
			return default(bool);
		}

		// Token: 0x0600A618 RID: 42520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A618")]
		[Address(RVA = "0x22E6284", Offset = "0x22E6284", VA = "0x7BBCAE6284")]
		public List<TeamMemberWithAccountInfo> SelfTeamOnlineMembers(bool includeSelf = true)
		{
			return null;
		}

		// Token: 0x0600A619 RID: 42521 RVA: 0x0002C748 File Offset: 0x0002A948
		[Token(Token = "0x600A619")]
		[Address(RVA = "0x22E6398", Offset = "0x22E6398", VA = "0x7BBCAE6398")]
		public proto.EPresence.AccountPresence TeamMemberPresence(ulong id)
		{
			return proto.EPresence.AccountPresence.AccountPresence_NONE;
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x0002C760 File Offset: 0x0002A960
		[Token(Token = "0x600A61A")]
		[Address(RVA = "0x22E643C", Offset = "0x22E643C", VA = "0x7BBCAE643C")]
		public ulong TeamMemberGroupID(ulong id)
		{
			return 0UL;
		}

		// Token: 0x0600A61B RID: 42523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A61B")]
		[Address(RVA = "0x22E64E0", Offset = "0x22E64E0", VA = "0x7BBCAE64E0")]
		public string TeamMemberPresenceString(ulong id)
		{
			return null;
		}

		// Token: 0x0600A61C RID: 42524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A61C")]
		[Address(RVA = "0x22E67BC", Offset = "0x22E67BC", VA = "0x7BBCAE67BC")]
		public List<AccountInfoBasic> TeamApplicants()
		{
			return null;
		}

		// Token: 0x0600A61D RID: 42525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A61D")]
		[Address(RVA = "0x22E67C4", Offset = "0x22E67C4", VA = "0x7BBCAE67C4")]
		public List<AccountInfoBasic> TeamInvitations()
		{
			return null;
		}

		// Token: 0x0600A61E RID: 42526 RVA: 0x0002C778 File Offset: 0x0002A978
		[Token(Token = "0x600A61E")]
		[Address(RVA = "0x22E67CC", Offset = "0x22E67CC", VA = "0x7BBCAE67CC")]
		public uint GetTeamRank(uint cpType, ulong teamID, out string formatRank)
		{
			return 0U;
		}

		// Token: 0x0600A61F RID: 42527 RVA: 0x0002C790 File Offset: 0x0002A990
		[Token(Token = "0x600A61F")]
		[Address(RVA = "0x22E6A9C", Offset = "0x22E6A9C", VA = "0x7BBCAE6A9C")]
		public bool CheckJoinCreateTimeSatisfy(out string error)
		{
			return default(bool);
		}

		// Token: 0x0600A620 RID: 42528 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		[Token(Token = "0x600A620")]
		[Address(RVA = "0x22E6C00", Offset = "0x22E6C00", VA = "0x7BBCAE6C00")]
		public bool CheckLevelSatisfy()
		{
			return default(bool);
		}

		// Token: 0x0600A621 RID: 42529 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		[Token(Token = "0x600A621")]
		[Address(RVA = "0x22E6D1C", Offset = "0x22E6D1C", VA = "0x7BBCAE6D1C")]
		public bool CheckLadderScoreSatisfy()
		{
			return default(bool);
		}

		// Token: 0x0600A622 RID: 42530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A622")]
		[Address(RVA = "0x22E6E34", Offset = "0x22E6E34", VA = "0x7BBCAE6E34")]
		public proto.ChampionshipInfo GetChampionshipInfoByType(uint type)
		{
			return null;
		}

		// Token: 0x0600A623 RID: 42531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A623")]
		[Address(RVA = "0x22E6EB4", Offset = "0x22E6EB4", VA = "0x7BBCAE6EB4")]
		public ChampionshipOpenInfoDesc GetChampionshipOpenInfo(uint type, uint championshipID)
		{
			return null;
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A624")]
		[Address(RVA = "0x22E6FAC", Offset = "0x22E6FAC", VA = "0x7BBCAE6FAC")]
		public uint[] GetChampionshipMaps(uint type)
		{
			return null;
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		[Token(Token = "0x600A625")]
		[Address(RVA = "0x22E713C", Offset = "0x22E713C", VA = "0x7BBCAE713C")]
		public bool IsInBlackList()
		{
			return default(bool);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		[Token(Token = "0x600A626")]
		[Address(RVA = "0x22E715C", Offset = "0x22E715C", VA = "0x7BBCAE715C")]
		public uint GetCurMembersNum()
		{
			return 0U;
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x0002C808 File Offset: 0x0002AA08
		[Token(Token = "0x600A627")]
		[Address(RVA = "0x22E71C8", Offset = "0x22E71C8", VA = "0x7BBCAE71C8")]
		public uint GetTeamScale(uint cpType)
		{
			return 0U;
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x0002C820 File Offset: 0x0002AA20
		[Token(Token = "0x600A628")]
		[Address(RVA = "0x22E71CC", Offset = "0x22E71CC", VA = "0x7BBCAE71CC")]
		public proto.EChampionship.TeamScaleType GetTeamScaleType(uint cpType)
		{
			return proto.EChampionship.TeamScaleType.TeamScaleType_NONE;
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A629")]
		[Address(RVA = "0x22E5DD8", Offset = "0x22E5DD8", VA = "0x7BBCAE5DD8")]
		public ChampionshipSettingDesc GetChampionshipSetting(uint type, uint championshipID = 0U)
		{
			return null;
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A62A")]
		[Address(RVA = "0x22E71EC", Offset = "0x22E71EC", VA = "0x7BBCAE71EC")]
		public ChampionshipScoreBaseDesc GetChampionshipScoreBaseInfoByType(uint type)
		{
			return null;
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x0002C838 File Offset: 0x0002AA38
		[Token(Token = "0x600A62B")]
		[Address(RVA = "0x22E5BE4", Offset = "0x22E5BE4", VA = "0x7BBCAE5BE4")]
		public uint GetCurrentChampionshipIDByType(uint type)
		{
			return 0U;
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x0002C850 File Offset: 0x0002AA50
		[Token(Token = "0x600A62C")]
		[Address(RVA = "0x22E72C8", Offset = "0x22E72C8", VA = "0x7BBCAE72C8")]
		public float GetChampionshipExtraBonusByType(uint type, uint bonusType)
		{
			return 0f;
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A62D")]
		[Address(RVA = "0x22E7308", Offset = "0x22E7308", VA = "0x7BBCAE7308")]
		public List<AwardDesc> GetChampionshipRewardListByPos(uint championshipType, uint championshipId, int pos)
		{
			return null;
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x0002C868 File Offset: 0x0002AA68
		[Token(Token = "0x600A62E")]
		[Address(RVA = "0x22E7538", Offset = "0x22E7538", VA = "0x7BBCAE7538")]
		public int GetChampionshipRewardIndexByPos(uint championshipType, uint championshipId, int pos)
		{
			return 0;
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A62F")]
		[Address(RVA = "0x22E7654", Offset = "0x22E7654", VA = "0x7BBCAE7654")]
		public ChampionshipScoreRewardDesc GetLowestChampionshipRewardDesc(uint championshipType, uint championshipId)
		{
			return null;
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A630")]
		[Address(RVA = "0x22E7784", Offset = "0x22E7784", VA = "0x7BBCAE7784")]
		public ChampionshipScoreRewardDesc GetFirstChampionshipRewardDesc(uint championshipType, uint championshipId)
		{
			return null;
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A631")]
		[Address(RVA = "0x22E744C", Offset = "0x22E744C", VA = "0x7BBCAE744C")]
		public List<ChampionshipScoreRewardDesc> GetChampionshipAllRewardDesc(uint championshipType, uint championshipId)
		{
			return null;
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x0002C880 File Offset: 0x0002AA80
		[Token(Token = "0x600A632")]
		[Address(RVA = "0x22E78B4", Offset = "0x22E78B4", VA = "0x7BBCAE78B4")]
		private uint GenerateAwardsListKey(uint championshipType, uint championshipID)
		{
			return 0U;
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A633")]
		[Address(RVA = "0x22E78C0", Offset = "0x22E78C0", VA = "0x7BBCAE78C0")]
		public string GetRankPosRange(uint championshipType, uint championshipId, int pos)
		{
			return null;
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x0002C898 File Offset: 0x0002AA98
		[Token(Token = "0x600A634")]
		[Address(RVA = "0x22E7D48", Offset = "0x22E7D48", VA = "0x7BBCAE7D48")]
		public UIModelChampionship.StateViewInfo GetStateViewInfo(UIModelChampionship.ChampionshipOpenState curState)
		{
			return default(UIModelChampionship.StateViewInfo);
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x0002C8B0 File Offset: 0x0002AAB0
		[Token(Token = "0x600A635")]
		[Address(RVA = "0x22E7504", Offset = "0x22E7504", VA = "0x7BBCAE7504")]
		public uint FixRankPos(uint championshipType, uint championshipID, int rank)
		{
			return 0U;
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A636")]
		[Address(RVA = "0x22E7E28", Offset = "0x22E7E28", VA = "0x7BBCAE7E28")]
		public void UpdateTeamInfoEditCD()
		{
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x0002C8C8 File Offset: 0x0002AAC8
		[Token(Token = "0x600A637")]
		[Address(RVA = "0x22E7F18", Offset = "0x22E7F18", VA = "0x7BBCAE7F18")]
		public ulong TeamInfoEditCD()
		{
			return 0UL;
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		[Token(Token = "0x600A638")]
		[Address(RVA = "0x22E7F20", Offset = "0x22E7F20", VA = "0x7BBCAE7F20")]
		public bool ChampionshipIsOpen(uint type, uint championshipID)
		{
			return default(bool);
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x0002C8F8 File Offset: 0x0002AAF8
		[Token(Token = "0x600A639")]
		[Address(RVA = "0x22E8010", Offset = "0x22E8010", VA = "0x7BBCAE8010")]
		public bool ChampionshipIsSeniorTeamOnly(uint type, uint championshipID)
		{
			return default(bool);
		}

		// Token: 0x0600A63A RID: 42554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63A")]
		[Address(RVA = "0x22E8034", Offset = "0x22E8034", VA = "0x7BBCAE8034")]
		public void ProcessChampionshipInfo(CSChampionshipBasicInfoRes championshipInfoRes)
		{
		}

		// Token: 0x0600A63B RID: 42555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63B")]
		[Address(RVA = "0x22E85AC", Offset = "0x22E85AC", VA = "0x7BBCAE85AC")]
		private void PreDownload()
		{
		}

		// Token: 0x0600A63C RID: 42556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63C")]
		[Address(RVA = "0x22E8438", Offset = "0x22E8438", VA = "0x7BBCAE8438")]
		private void InitCurrentChampionshipID(List<ChampionshipOpenInfoDesc> openInfoList)
		{
		}

		// Token: 0x0600A63D RID: 42557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63D")]
		[Address(RVA = "0x22E8110", Offset = "0x22E8110", VA = "0x7BBCAE8110")]
		private void ProcessChampionshipRewardInfo(List<ChampionshipScoreRewardDesc> rewardsDescList)
		{
		}

		// Token: 0x0600A63E RID: 42558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63E")]
		[Address(RVA = "0x22E883C", Offset = "0x22E883C", VA = "0x7BBCAE883C")]
		public void RequestCreateTeam(string name, string contactInfo, string countryOrArea, uint clanAvatar, uint clanBanner, proto.EChampionship.TeamScaleType scaleType)
		{
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A63F")]
		[Address(RVA = "0x22E8A98", Offset = "0x22E8A98", VA = "0x7BBCAE8A98")]
		public void RequestJoinTeam(ulong friendID, ulong teamID)
		{
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A640")]
		[Address(RVA = "0x22E8CC0", Offset = "0x22E8CC0", VA = "0x7BBCAE8CC0")]
		public void RequestModifyTeamInfo(string teamName, string countryOrArea, uint clanAvatar, uint clanBanner)
		{
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A641")]
		[Address(RVA = "0x22E8ED4", Offset = "0x22E8ED4", VA = "0x7BBCAE8ED4")]
		public void RequestEditTeamContactInfo(string contact)
		{
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A642")]
		[Address(RVA = "0x22E9078", Offset = "0x22E9078", VA = "0x7BBCAE9078")]
		public void RequestTeamInfoByTeamID(ulong teamID, bool requestTeamApplication = false)
		{
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A643")]
		[Address(RVA = "0x22E936C", Offset = "0x22E936C", VA = "0x7BBCAE936C")]
		public void RequestSelfTeamMembers()
		{
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A644")]
		[Address(RVA = "0x22E9378", Offset = "0x22E9378", VA = "0x7BBCAE9378")]
		public void RequestTeamMembers(ulong teamID, bool requestTeamMemberPresence = false)
		{
		}

		// Token: 0x0600A645 RID: 42565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A645")]
		[Address(RVA = "0x22E9558", Offset = "0x22E9558", VA = "0x7BBCAE9558")]
		public void RequestTeamMatchStatsHistory(ulong teamID)
		{
		}

		// Token: 0x0600A646 RID: 42566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A646")]
		[Address(RVA = "0x22E9A78", Offset = "0x22E9A78", VA = "0x7BBCAE9A78")]
		public void RequestQuitTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0UL, ulong inviterTeam = 0UL)
		{
		}

		// Token: 0x0600A647 RID: 42567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A647")]
		[Address(RVA = "0x22E9D3C", Offset = "0x22E9D3C", VA = "0x7BBCAE9D3C")]
		public void RequestDismissTeam(bool toNewTeam = false, bool requestApproveJoinTeamInvitation = false, ulong inviter = 0UL, ulong inviterTeam = 0UL)
		{
		}

		// Token: 0x0600A648 RID: 42568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A648")]
		[Address(RVA = "0x22E9FF8", Offset = "0x22E9FF8", VA = "0x7BBCAE9FF8")]
		public void RequestTeamApplicantList()
		{
		}

		// Token: 0x0600A649 RID: 42569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A649")]
		[Address(RVA = "0x22EA194", Offset = "0x22EA194", VA = "0x7BBCAEA194")]
		public void RequestInvitationList()
		{
		}

		// Token: 0x0600A64A RID: 42570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A64A")]
		[Address(RVA = "0x22EA308", Offset = "0x22EA308", VA = "0x7BBCAEA308")]
		public void RequestInvitedIdList()
		{
		}

		// Token: 0x0600A64B RID: 42571 RVA: 0x0002C910 File Offset: 0x0002AB10
		[Token(Token = "0x600A64B")]
		[Address(RVA = "0x22EA498", Offset = "0x22EA498", VA = "0x7BBCAEA498")]
		public bool IsInvitedAccount(FriendAccountInfo accountInfo)
		{
			return default(bool);
		}

		// Token: 0x0600A64C RID: 42572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A64C")]
		[Address(RVA = "0x22EA518", Offset = "0x22EA518", VA = "0x7BBCAEA518")]
		public void RequestApproveApplication(AccountInfoBasic basicInfo)
		{
		}

		// Token: 0x0600A64D RID: 42573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A64D")]
		[Address(RVA = "0x22EA768", Offset = "0x22EA768", VA = "0x7BBCAEA768")]
		public void RequestDeclineApplication(ulong[] applicantIDs)
		{
		}

		// Token: 0x0600A64E RID: 42574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A64E")]
		[Address(RVA = "0x22EA9D0", Offset = "0x22EA9D0", VA = "0x7BBCAEA9D0")]
		public void RequestInvite(ulong inviteeID)
		{
		}

		// Token: 0x0600A64F RID: 42575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A64F")]
		[Address(RVA = "0x22EABCC", Offset = "0x22EABCC", VA = "0x7BBCAEABCC")]
		public void RequestApproveJoinTeamInvitation(ulong inviter, ulong inviterTeam)
		{
		}

		// Token: 0x0600A650 RID: 42576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A650")]
		[Address(RVA = "0x22EAE2C", Offset = "0x22EAE2C", VA = "0x7BBCAEAE2C")]
		public void RequestDeclineJoinTeamInvitation(ulong[] inviterIDs)
		{
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A651")]
		[Address(RVA = "0x22EB08C", Offset = "0x22EB08C", VA = "0x7BBCAEB08C")]
		public void RequestTeamMemberPresence()
		{
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A652")]
		[Address(RVA = "0x22EB2AC", Offset = "0x22EB2AC", VA = "0x7BBCAEB2AC")]
		public void RequestRemoveTeamMember(ulong removeeID)
		{
		}

		// Token: 0x0600A653 RID: 42579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A653")]
		[Address(RVA = "0x22EB4F0", Offset = "0x22EB4F0", VA = "0x7BBCAEB4F0")]
		public void RequestGetTeamChampionshipInfo(uint championshipID, uint championshipType)
		{
		}

		// Token: 0x0600A654 RID: 42580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A654")]
		[Address(RVA = "0x22EB718", Offset = "0x22EB718", VA = "0x7BBCAEB718")]
		public void RequestInitTeamChampionshipInfo(uint championshipType, uint httpOption = 0U)
		{
		}

		// Token: 0x0600A655 RID: 42581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A655")]
		[Address(RVA = "0x22EB900", Offset = "0x22EB900", VA = "0x7BBCAEB900")]
		public void RequestChampionshipConfig(uint championshipID, uint championshipType = 1U, uint httpOption = 0U)
		{
		}

		// Token: 0x0600A656 RID: 42582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A656")]
		[Address(RVA = "0x22EBB90", Offset = "0x22EBB90", VA = "0x7BBCAEBB90")]
		public void RequestChampionshipStatsInfo(ulong teamID, uint championshipType, uint championshipID, bool needTeamMembersInfo = false)
		{
		}

		// Token: 0x0600A657 RID: 42583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A657")]
		[Address(RVA = "0x22EBD68", Offset = "0x22EBD68", VA = "0x7BBCAEBD68")]
		public void RequestAccountLifeSeasonStats(ulong accountID, uint championshipType)
		{
		}

		// Token: 0x0600A658 RID: 42584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A658")]
		[Address(RVA = "0x22EBF0C", Offset = "0x22EBF0C", VA = "0x7BBCAEBF0C")]
		public void OnJoinApplicantNotify()
		{
		}

		// Token: 0x0600A659 RID: 42585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A659")]
		[Address(RVA = "0x22EBF10", Offset = "0x22EBF10", VA = "0x7BBCAEBF10")]
		public void OnConfrimAddNotify(ConfirmAddChampionshipTeamReq ntf)
		{
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65A")]
		[Address(RVA = "0x22EC210", Offset = "0x22EC210", VA = "0x7BBCAEC210")]
		public void OnDismissNotify(ulong teamID)
		{
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65B")]
		[Address(RVA = "0x22EC2D4", Offset = "0x22EC2D4", VA = "0x7BBCAEC2D4")]
		public void OnRemoveNotify(ulong teamID, ulong removeeID)
		{
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65C")]
		[Address(RVA = "0x22EC61C", Offset = "0x22EC61C", VA = "0x7BBCAEC61C")]
		public void OnInviteNotify()
		{
		}

		// Token: 0x0600A65D RID: 42589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65D")]
		[Address(RVA = "0x22EC620", Offset = "0x22EC620", VA = "0x7BBCAEC620")]
		public void OnApproveInviteNotify()
		{
		}

		// Token: 0x0600A65E RID: 42590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65E")]
		[Address(RVA = "0x22EC658", Offset = "0x22EC658", VA = "0x7BBCAEC658")]
		public void OnTeamMemeberPresenceNotify(PresenceListRes presenceData)
		{
		}

		// Token: 0x0600A65F RID: 42591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A65F")]
		[Address(RVA = "0x22EBFD0", Offset = "0x22EBFD0", VA = "0x7BBCAEBFD0")]
		private void UpdateTeamID(ulong teamID)
		{
		}

		// Token: 0x0600A660 RID: 42592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A660")]
		[Address(RVA = "0x22EC830", Offset = "0x22EC830", VA = "0x7BBCAEC830")]
		public void SortTeamMember(List<TeamMemberWithAccountInfo> members, bool sortPresence, TeamInfo teamInfo)
		{
		}

		// Token: 0x0600A661 RID: 42593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A661")]
		[Address(RVA = "0x22EC94C", Offset = "0x22EC94C", VA = "0x7BBCAEC94C")]
		public string GetSeasonStartEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo, bool showYear = true)
		{
			return null;
		}

		// Token: 0x0600A662 RID: 42594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A662")]
		[Address(RVA = "0x22ECB64", Offset = "0x22ECB64", VA = "0x7BBCAECB64")]
		public string GetSeasonEndTimeString(ChampionshipOpenInfoDesc championshipOpenInfo)
		{
			return null;
		}

		// Token: 0x0600A663 RID: 42595 RVA: 0x0002C928 File Offset: 0x0002AB28
		[Token(Token = "0x600A663")]
		[Address(RVA = "0x22ECC14", Offset = "0x22ECC14", VA = "0x7BBCAECC14")]
		public uint GetChampionshipID(ChampionshipOpenInfoDesc championshipOpenInfo)
		{
			return 0U;
		}

		// Token: 0x0600A664 RID: 42596 RVA: 0x0002C940 File Offset: 0x0002AB40
		[Token(Token = "0x600A664")]
		[Address(RVA = "0x22ECC28", Offset = "0x22ECC28", VA = "0x7BBCAECC28")]
		public int GetRankPos(uint championshipType)
		{
			return 0;
		}

		// Token: 0x0600A665 RID: 42597 RVA: 0x0002C958 File Offset: 0x0002AB58
		[Token(Token = "0x600A665")]
		[Address(RVA = "0x22E6A80", Offset = "0x22E6A80", VA = "0x7BBCAE6A80")]
		public int GetPropIDByChampionshipType(uint championshipType)
		{
			return 0;
		}

		// Token: 0x0600A666 RID: 42598 RVA: 0x0002C970 File Offset: 0x0002AB70
		[Token(Token = "0x600A666")]
		[Address(RVA = "0x22ECD0C", Offset = "0x22ECD0C", VA = "0x7BBCAECD0C")]
		public uint GetValidScore(proto.ChampionshipInfo championshipInfo)
		{
			return 0U;
		}

		// Token: 0x0600A667 RID: 42599 RVA: 0x0002C988 File Offset: 0x0002AB88
		[Token(Token = "0x600A667")]
		[Address(RVA = "0x22ECD28", Offset = "0x22ECD28", VA = "0x7BBCAECD28")]
		public uint GetTotalScore(proto.ChampionshipInfo championshipInfo)
		{
			return 0U;
		}

		// Token: 0x0600A668 RID: 42600 RVA: 0x0002C9A0 File Offset: 0x0002ABA0
		[Token(Token = "0x600A668")]
		[Address(RVA = "0x22ECD44", Offset = "0x22ECD44", VA = "0x7BBCAECD44")]
		public uint GetMatchTotalNum(ChampionshipSettingDesc championshipSettingInfo)
		{
			return 0U;
		}

		// Token: 0x0600A669 RID: 42601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A669")]
		[Address(RVA = "0x22ECD58", Offset = "0x22ECD58", VA = "0x7BBCAECD58")]
		public string GetChampionshipTrialMatchName(uint championshipType, uint championshipID = 0U, string originNameKey = "")
		{
			return null;
		}

		// Token: 0x0600A66A RID: 42602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A66A")]
		[Address(RVA = "0x22ED038", Offset = "0x22ED038", VA = "0x7BBCAED038")]
		public string GetChampionshipModeName(uint championshipType, uint championshipID)
		{
			return null;
		}

		// Token: 0x0600A66B RID: 42603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A66B")]
		[Address(RVA = "0x22ED250", Offset = "0x22ED250", VA = "0x7BBCAED250")]
		public string GetChampionshipSeasonNameWithIDOverwrite(uint championshipType, uint championshipID)
		{
			return null;
		}

		// Token: 0x0600A66C RID: 42604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A66C")]
		[Address(RVA = "0x22ED550", Offset = "0x22ED550", VA = "0x7BBCAED550")]
		private void SetTicketsNum(uint type, uint ticketInfoCnt)
		{
		}

		// Token: 0x0600A66D RID: 42605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A66D")]
		[Address(RVA = "0x22ED644", Offset = "0x22ED644", VA = "0x7BBCAED644")]
		private void SetPlayedTimes(uint type, uint playedNum)
		{
		}

		// Token: 0x0600A66E RID: 42606 RVA: 0x0002C9B8 File Offset: 0x0002ABB8
		[Token(Token = "0x600A66E")]
		[Address(RVA = "0x22ED738", Offset = "0x22ED738", VA = "0x7BBCAED738")]
		public uint GetTicketsNum(uint type)
		{
			return 0U;
		}

		// Token: 0x0600A66F RID: 42607 RVA: 0x0002C9D0 File Offset: 0x0002ABD0
		[Token(Token = "0x600A66F")]
		[Address(RVA = "0x22ED7B8", Offset = "0x22ED7B8", VA = "0x7BBCAED7B8")]
		public uint GetPlayedTimes(uint type)
		{
			return 0U;
		}

		// Token: 0x0600A670 RID: 42608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A670")]
		[Address(RVA = "0x22ED838", Offset = "0x22ED838", VA = "0x7BBCAED838")]
		public void AddPlayedTimes(uint type, uint num = 1U)
		{
		}

		// Token: 0x0600A671 RID: 42609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A671")]
		[Address(RVA = "0x22ED8FC", Offset = "0x22ED8FC", VA = "0x7BBCAED8FC")]
		public void DeductTicket(uint type, uint cnt = 1U)
		{
		}

		// Token: 0x0600A672 RID: 42610 RVA: 0x0002C9E8 File Offset: 0x0002ABE8
		[Token(Token = "0x600A672")]
		[Address(RVA = "0x22ED9C0", Offset = "0x22ED9C0", VA = "0x7BBCAED9C0")]
		public bool HasUnTeamMemberPlayerInGroup(List<GroupMemberInfo> members)
		{
			return default(bool);
		}

		// Token: 0x0600A673 RID: 42611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A673")]
		[Address(RVA = "0x22EDBF0", Offset = "0x22EDBF0", VA = "0x7BBCAEDBF0")]
		public List<uint> GetOpenChampionshipTypeList()
		{
			return null;
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x0002CA00 File Offset: 0x0002AC00
		[Token(Token = "0x600A674")]
		[Address(RVA = "0x22EDCB4", Offset = "0x22EDCB4", VA = "0x7BBCAEDCB4")]
		public UIModelChampionship.ChampionshipOpenState GetChampionshipOpenState(ChampionshipOpenInfoDesc championshipOpenInfo)
		{
			return UIModelChampionship.ChampionshipOpenState.UnOpen;
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x0002CA18 File Offset: 0x0002AC18
		[Token(Token = "0x600A675")]
		[Address(RVA = "0x22EE1F4", Offset = "0x22EE1F4", VA = "0x7BBCAEE1F4")]
		public ulong GetMapCloseTime(ChampionshipOpenInfoDesc championshipOpenInfo)
		{
			return 0UL;
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x0002CA30 File Offset: 0x0002AC30
		[Token(Token = "0x600A676")]
		[Address(RVA = "0x22EE2F0", Offset = "0x22EE2F0", VA = "0x7BBCAEE2F0")]
		public ulong GetNextOpenTime(ChampionshipOpenInfoDesc championshipOpenInfo, UIModelChampionship.ChampionshipOpenState championshipState)
		{
			return 0UL;
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A677")]
		[Address(RVA = "0x22EDEF8", Offset = "0x22EDEF8", VA = "0x7BBCAEDEF8")]
		private void SetTipsIfDifferentOpenDay(MapOpeningInfo mapInfo)
		{
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[Token(Token = "0x600A678")]
		[Address(RVA = "0x22EE468", Offset = "0x22EE468", VA = "0x7BBCAEE468")]
		public bool IsTrialStart(UIModelChampionship.ChampionshipOpenState state)
		{
			return default(bool);
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x0002CA60 File Offset: 0x0002AC60
		[Token(Token = "0x600A679")]
		[Address(RVA = "0x22ECCFC", Offset = "0x22ECCFC", VA = "0x7BBCAECCFC")]
		public bool IsFFCCUP(uint cptype)
		{
			return default(bool);
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x0002CA78 File Offset: 0x0002AC78
		[Token(Token = "0x600A67A")]
		[Address(RVA = "0x22E98BC", Offset = "0x22E98BC", VA = "0x7BBCAE98BC")]
		public uint GetCurrentOpenChampionshipType()
		{
			return 0U;
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x0002CA90 File Offset: 0x0002AC90
		[Token(Token = "0x600A67B")]
		[Address(RVA = "0x22EE474", Offset = "0x22EE474", VA = "0x7BBCAEE474")]
		public uint GetLastThirdPartyChampionshipType()
		{
			return 0U;
		}

		// Token: 0x0600A67C RID: 42620 RVA: 0x0002CAA8 File Offset: 0x0002ACA8
		[Token(Token = "0x600A67C")]
		[Address(RVA = "0x22EE614", Offset = "0x22EE614", VA = "0x7BBCAEE614")]
		public uint GetLastFFCCupChampionshipType()
		{
			return 0U;
		}

		// Token: 0x0600A67D RID: 42621 RVA: 0x0002CAC0 File Offset: 0x0002ACC0
		[Token(Token = "0x600A67D")]
		[Address(RVA = "0x22EE7B4", Offset = "0x22EE7B4", VA = "0x7BBCAEE7B4")]
		public bool AllProtocalReady()
		{
			return default(bool);
		}

		// Token: 0x0600A67E RID: 42622 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		[Token(Token = "0x600A67E")]
		[Address(RVA = "0x22EE7DC", Offset = "0x22EE7DC", VA = "0x7BBCAEE7DC")]
		public bool HasPlayedOneGame()
		{
			return default(bool);
		}

		// Token: 0x0600A67F RID: 42623 RVA: 0x0002CAF0 File Offset: 0x0002ACF0
		[Token(Token = "0x600A67F")]
		[Address(RVA = "0x22EE84C", Offset = "0x22EE84C", VA = "0x7BBCAEE84C")]
		public bool IsReplayEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600A680 RID: 42624 RVA: 0x0002CB08 File Offset: 0x0002AD08
		[Token(Token = "0x600A680")]
		[Address(RVA = "0x22EE96C", Offset = "0x22EE96C", VA = "0x7BBCAEE96C")]
		public bool IsDisableWeaponSkin()
		{
			return default(bool);
		}

		// Token: 0x0600A681 RID: 42625 RVA: 0x0002CB20 File Offset: 0x0002AD20
		[Token(Token = "0x600A681")]
		[Address(RVA = "0x22EE9AC", Offset = "0x22EE9AC", VA = "0x7BBCAEE9AC")]
		public bool SetEntranceBtnState()
		{
			return default(bool);
		}

		// Token: 0x0600A682 RID: 42626 RVA: 0x0002CB38 File Offset: 0x0002AD38
		[Token(Token = "0x600A682")]
		[Address(RVA = "0x22EEBBC", Offset = "0x22EEBBC", VA = "0x7BBCAEEBBC")]
		public UIModelChampionship.ChampionshipEntranceState GetEntranceBtnState()
		{
			return UIModelChampionship.ChampionshipEntranceState.Closed;
		}

		// Token: 0x0600A683 RID: 42627 RVA: 0x0002CB50 File Offset: 0x0002AD50
		[Token(Token = "0x600A683")]
		[Address(RVA = "0x22EEBEC", Offset = "0x22EEBEC", VA = "0x7BBCAEEBEC")]
		public uint GetHightestPriorityChampionshipType()
		{
			return 0U;
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A684")]
		[Address(RVA = "0x22EEC1C", Offset = "0x22EEC1C", VA = "0x7BBCAEEC1C")]
		public void SetTeamInfoFlag()
		{
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A685")]
		[Address(RVA = "0x22E8788", Offset = "0x22E8788", VA = "0x7BBCAE8788")]
		public void SetChampionshipInfoFlag()
		{
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A686")]
		[Address(RVA = "0x22EECD0", Offset = "0x22EECD0", VA = "0x7BBCAEECD0")]
		public void SetMapInfoFlag()
		{
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x0002CB68 File Offset: 0x0002AD68
		[Token(Token = "0x600A687")]
		[Address(RVA = "0x22E7C54", Offset = "0x22E7C54", VA = "0x7BBCAE7C54")]
		public uint GetRewardPercent(uint bound)
		{
			return 0U;
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A688")]
		[Address(RVA = "0x22EED84", Offset = "0x22EED84", VA = "0x7BBCAEED84")]
		public UIModelChampionship()
		{
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x0002CB80 File Offset: 0x0002AD80
		[Token(Token = "0x600A68A")]
		[Address(RVA = "0x22EF5B8", Offset = "0x22EF5B8", VA = "0x7BBCAEF5B8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C5C", Offset = "0x1145C5C")]
		private bool <SelfTeamOnlineMembers>b__90_0(TeamMemberWithAccountInfo member)
		{
			return default(bool);
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A68B")]
		[Address(RVA = "0x22EF608", Offset = "0x22EF608", VA = "0x7BBCAEF608")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C6C", Offset = "0x1145C6C")]
		private void <RequestCreateTeam>b__128_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A68C")]
		[Address(RVA = "0x22EF82C", Offset = "0x22EF82C", VA = "0x7BBCAEF82C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C7C", Offset = "0x1145C7C")]
		private void <RequestModifyTeamInfo>b__130_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A68D")]
		[Address(RVA = "0x22EF9C8", Offset = "0x22EF9C8", VA = "0x7BBCAEF9C8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C8C", Offset = "0x1145C8C")]
		private void <RequestEditTeamContactInfo>b__131_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A68E")]
		[Address(RVA = "0x22EFB6C", Offset = "0x22EFB6C", VA = "0x7BBCAEFB6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145C9C", Offset = "0x1145C9C")]
		private void <RequestTeamApplicantList>b__138_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A68F")]
		[Address(RVA = "0x22EFED4", Offset = "0x22EFED4", VA = "0x7BBCAEFED4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CAC", Offset = "0x1145CAC")]
		private void <RequestInvitationList>b__139_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A690")]
		[Address(RVA = "0x22F01C4", Offset = "0x22F01C4", VA = "0x7BBCAF01C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CBC", Offset = "0x1145CBC")]
		private void <RequestInvitedIdList>b__140_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A691")]
		[Address(RVA = "0x22F0524", Offset = "0x22F0524", VA = "0x7BBCAF0524")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CCC", Offset = "0x1145CCC")]
		private void <RequestInitTeamChampionshipInfo>b__150_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A692")]
		[Address(RVA = "0x22F070C", Offset = "0x22F070C", VA = "0x7BBCAF070C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CDC", Offset = "0x1145CDC")]
		private void <RequestChampionshipStatsInfo>b__152_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A693")]
		[Address(RVA = "0x22F08BC", Offset = "0x22F08BC", VA = "0x7BBCAF08BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CEC", Offset = "0x1145CEC")]
		private void <RequestAccountLifeSeasonStats>b__153_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400ABDD RID: 43997
		[Token(Token = "0x400ABDD")]
		[FieldOffset(Offset = "0x18")]
		private TeamInfo m_SelfTeamInfo;

		// Token: 0x0400ABDE RID: 43998
		[Token(Token = "0x400ABDE")]
		[FieldOffset(Offset = "0x20")]
		private TeamMemberListWithAccountInfo m_SelfTeamMemberInfo;

		// Token: 0x0400ABDF RID: 43999
		[Token(Token = "0x400ABDF")]
		[FieldOffset(Offset = "0x28")]
		private ulong m_SelfTeamMatchStatsHistoryRequestTime;

		// Token: 0x0400ABE0 RID: 44000
		[Token(Token = "0x400ABE0")]
		[FieldOffset(Offset = "0x30")]
		private CSTeamMatchStatsHistoryRes m_SelfTeamMatchStatsHistoryRes;

		// Token: 0x0400ABE1 RID: 44001
		[Token(Token = "0x400ABE1")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ulong, PresenceInfo> m_MemberPresenceCache;

		// Token: 0x0400ABE2 RID: 44002
		[Token(Token = "0x400ABE2")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, proto.ChampionshipInfo> m_ChampionshipInfoCache;

		// Token: 0x0400ABE3 RID: 44003
		[Token(Token = "0x400ABE3")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<uint, List<ChampionshipScoreRewardDesc>> m_ChampionshipRewardInfoCache;

		// Token: 0x0400ABE4 RID: 44004
		[Token(Token = "0x400ABE4")]
		[FieldOffset(Offset = "0x50")]
		private List<AccountInfoBasic> m_TeamApplicantList;

		// Token: 0x0400ABE5 RID: 44005
		[Token(Token = "0x400ABE5")]
		[FieldOffset(Offset = "0x58")]
		private List<AccountInfoBasic> m_TeamInvitationList;

		// Token: 0x0400ABE6 RID: 44006
		[Token(Token = "0x400ABE6")]
		[FieldOffset(Offset = "0x60")]
		private List<ulong> m_TeamInvitedIdList;

		// Token: 0x0400ABE7 RID: 44007
		[Token(Token = "0x400ABE7")]
		[FieldOffset(Offset = "0x68")]
		private CSChampionshipBasicInfoRes m_ChampionshipBasicInfoRes;

		// Token: 0x0400ABE8 RID: 44008
		[Token(Token = "0x400ABE8")]
		[FieldOffset(Offset = "0x70")]
		private ulong m_SelfTeamID;

		// Token: 0x0400ABE9 RID: 44009
		[Token(Token = "0x400ABE9")]
		private const string m_PrefTeamInfoEditCD = "CSTeamInfoEditCD";

		// Token: 0x0400ABEA RID: 44010
		[Token(Token = "0x400ABEA")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_TeamInfoEditCoolDownTime;

		// Token: 0x0400ABEB RID: 44011
		[Token(Token = "0x400ABEB")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<uint, uint> m_CurrentChampionshipID;

		// Token: 0x0400ABEC RID: 44012
		[Token(Token = "0x400ABEC")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<uint, uint> m_TicketCntDict;

		// Token: 0x0400ABED RID: 44013
		[Token(Token = "0x400ABED")]
		[FieldOffset(Offset = "0x90")]
		private Dictionary<uint, uint> m_GamesPlayedDict;

		// Token: 0x0400ABEE RID: 44014
		[Token(Token = "0x400ABEE")]
		[FieldOffset(Offset = "0x98")]
		private List<ServiceMessageTypeHTTP> m_requestQueue;

		// Token: 0x0400ABEF RID: 44015
		[Token(Token = "0x400ABEF")]
		[FieldOffset(Offset = "0x0")]
		public static uint PropID_CreateTeam;

		// Token: 0x0400ABF0 RID: 44016
		[Token(Token = "0x400ABF0")]
		[FieldOffset(Offset = "0x4")]
		public static uint PropID_TeamInfoUpdate;

		// Token: 0x0400ABF1 RID: 44017
		[Token(Token = "0x400ABF1")]
		[FieldOffset(Offset = "0x8")]
		public static uint PropID_TeamMembersUpdate;

		// Token: 0x0400ABF2 RID: 44018
		[Token(Token = "0x400ABF2")]
		[FieldOffset(Offset = "0xC")]
		public static uint PropID_QuitTeam;

		// Token: 0x0400ABF3 RID: 44019
		[Token(Token = "0x400ABF3")]
		[FieldOffset(Offset = "0x10")]
		public static uint PropID_TeamApplicantsUpdate;

		// Token: 0x0400ABF4 RID: 44020
		[Token(Token = "0x400ABF4")]
		[FieldOffset(Offset = "0x14")]
		public static uint PropID_DismissTeam;

		// Token: 0x0400ABF5 RID: 44021
		[Token(Token = "0x400ABF5")]
		[FieldOffset(Offset = "0x18")]
		public static uint PropID_DismissTeamNotify;

		// Token: 0x0400ABF6 RID: 44022
		[Token(Token = "0x400ABF6")]
		[FieldOffset(Offset = "0x1C")]
		public static uint PropID_RemoveNotify;

		// Token: 0x0400ABF7 RID: 44023
		[Token(Token = "0x400ABF7")]
		[FieldOffset(Offset = "0x20")]
		public static uint PropID_Invite;

		// Token: 0x0400ABF8 RID: 44024
		[Token(Token = "0x400ABF8")]
		[FieldOffset(Offset = "0x24")]
		public static uint PropID_TeamInvitationUpdate;

		// Token: 0x0400ABF9 RID: 44025
		[Token(Token = "0x400ABF9")]
		[FieldOffset(Offset = "0x28")]
		public static uint PropID_ApproveTeamInvitation;

		// Token: 0x0400ABFA RID: 44026
		[Token(Token = "0x400ABFA")]
		[FieldOffset(Offset = "0x2C")]
		public static uint PropID_JoinTeam;

		// Token: 0x0400ABFB RID: 44027
		[Token(Token = "0x400ABFB")]
		[FieldOffset(Offset = "0x30")]
		public static uint PropID_EditContact;

		// Token: 0x0400ABFC RID: 44028
		[Token(Token = "0x400ABFC")]
		[FieldOffset(Offset = "0x34")]
		public static uint PropID_MemberPresenceUpdate;

		// Token: 0x0400ABFD RID: 44029
		[Token(Token = "0x400ABFD")]
		[FieldOffset(Offset = "0x38")]
		public static uint PropID_ConfirmAddNotify;

		// Token: 0x0400ABFE RID: 44030
		[Token(Token = "0x400ABFE")]
		[FieldOffset(Offset = "0x3C")]
		public static uint PropID_ChampionshipInfoUpdate;

		// Token: 0x0400ABFF RID: 44031
		[Token(Token = "0x400ABFF")]
		[FieldOffset(Offset = "0x40")]
		public static uint PropID_ChampionshipConfigInfoUpdate;

		// Token: 0x0400AC00 RID: 44032
		[Token(Token = "0x400AC00")]
		[FieldOffset(Offset = "0x44")]
		public static uint PropID_ModifyTeamInfo;

		// Token: 0x0400AC01 RID: 44033
		[Token(Token = "0x400AC01")]
		[FieldOffset(Offset = "0x48")]
		public static uint PropID_ChampionshipGameStatsUpdate;

		// Token: 0x0400AC02 RID: 44034
		[Token(Token = "0x400AC02")]
		[FieldOffset(Offset = "0x4C")]
		public static uint PropID_AccountListSeasonStats;

		// Token: 0x0400AC03 RID: 44035
		[Token(Token = "0x400AC03")]
		[FieldOffset(Offset = "0x50")]
		public static uint PropID_TeamMatchStatsHistoryNotify;

		// Token: 0x0400AC04 RID: 44036
		[Token(Token = "0x400AC04")]
		[FieldOffset(Offset = "0x54")]
		public static uint PropID_TeamIDChange;

		// Token: 0x0400AC05 RID: 44037
		[Token(Token = "0x400AC05")]
		[FieldOffset(Offset = "0x58")]
		public static uint PropID_GetInvitedIdListUpdate;

		// Token: 0x0400AC06 RID: 44038
		[Token(Token = "0x400AC06")]
		[FieldOffset(Offset = "0x5C")]
		public static uint PropID_ChampionshipInfoReady;

		// Token: 0x0400AC07 RID: 44039
		[Token(Token = "0x400AC07")]
		[FieldOffset(Offset = "0x60")]
		public static uint PARTICIPATIONFLAG;

		// Token: 0x0400AC08 RID: 44040
		[Token(Token = "0x400AC08")]
		[FieldOffset(Offset = "0x68")]
		public static string NEWSEASONANIM;

		// Token: 0x0400AC09 RID: 44041
		[Token(Token = "0x400AC09")]
		public const string TEAMCLICKLOG = "TeamClickLog,Type{0},Season{1}";

		// Token: 0x0400AC0A RID: 44042
		[Token(Token = "0x400AC0A")]
		public const string ENTRANCECLICKLOG = "EntranceClickLog,Type{0},Season{1}";

		// Token: 0x0400AC0B RID: 44043
		[Token(Token = "0x400AC0B")]
		public const string NEWSEASONANOTICE = "CSNewSeasonNotice,Type{0},Season{1}";

		// Token: 0x0400AC0C RID: 44044
		[Token(Token = "0x400AC0C")]
		[FieldOffset(Offset = "0xA0")]
		public Dictionary<uint, bool> m_ChampionshipMatchEnd;

		// Token: 0x0400AC0D RID: 44045
		[Token(Token = "0x400AC0D")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelChampionship.ChampionshipEntranceState m_HighestPriorityState;

		// Token: 0x0400AC0E RID: 44046
		[Token(Token = "0x400AC0E")]
		[FieldOffset(Offset = "0xAC")]
		private uint m_HighestPriorityType;

		// Token: 0x0400AC0F RID: 44047
		[Token(Token = "0x400AC0F")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_EntranceStateChecked;

		// Token: 0x0400AC10 RID: 44048
		[Token(Token = "0x400AC10")]
		[FieldOffset(Offset = "0xB1")]
		public bool championshipInfoReady;

		// Token: 0x0400AC11 RID: 44049
		[Token(Token = "0x400AC11")]
		[FieldOffset(Offset = "0xB2")]
		public bool teamInfoReady;

		// Token: 0x0400AC12 RID: 44050
		[Token(Token = "0x400AC12")]
		[FieldOffset(Offset = "0xB3")]
		public bool mapInfoReady;

		// Token: 0x0400AC13 RID: 44051
		[Token(Token = "0x400AC13")]
		[FieldOffset(Offset = "0xB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FE9C", Offset = "0x112FE9C")]
		private bool <TeamMemberInitialized>k__BackingField;

		// Token: 0x0400AC14 RID: 44052
		[Token(Token = "0x400AC14")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Dictionary<UIModelChampionship.ChampionshipOpenState, UIModelChampionship.StateViewInfo> m_StateViewInfoDict;

		// Token: 0x0400AC15 RID: 44053
		[Token(Token = "0x400AC15")]
		private const uint NameOverwriteType_TrialMatchName = 1U;

		// Token: 0x0400AC16 RID: 44054
		[Token(Token = "0x400AC16")]
		private const uint NameOverwriteType_ModeName = 2U;

		// Token: 0x0400AC17 RID: 44055
		[Token(Token = "0x400AC17")]
		private const uint NameOverwriteType_SeasonName = 3U;

		// Token: 0x02001DAA RID: 7594
		[Token(Token = "0x2001DAA")]
		public enum MemberType
		{
			// Token: 0x0400AC19 RID: 44057
			[Token(Token = "0x400AC19")]
			Normal = 1,
			// Token: 0x0400AC1A RID: 44058
			[Token(Token = "0x400AC1A")]
			Captain
		}

		// Token: 0x02001DAB RID: 7595
		[Token(Token = "0x2001DAB")]
		public class NotifyArgs
		{
			// Token: 0x0600A694 RID: 42644 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A694")]
			[Address(RVA = "0x20F62B4", Offset = "0x20F62B4", VA = "0x7BBC8F62B4")]
			public NotifyArgs()
			{
			}

			// Token: 0x0400AC1B RID: 44059
			[Token(Token = "0x400AC1B")]
			[FieldOffset(Offset = "0x10")]
			public bool success;
		}

		// Token: 0x02001DAC RID: 7596
		[Token(Token = "0x2001DAC")]
		public class NotifyArgsRemove : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A695 RID: 42645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A695")]
			[Address(RVA = "0x20F69D8", Offset = "0x20F69D8", VA = "0x7BBC8F69D8")]
			public NotifyArgsRemove()
			{
			}

			// Token: 0x0400AC1C RID: 44060
			[Token(Token = "0x400AC1C")]
			[FieldOffset(Offset = "0x11")]
			public bool removeSelf;
		}

		// Token: 0x02001DAD RID: 7597
		[Token(Token = "0x2001DAD")]
		public class NotifyArgsJoin : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A696 RID: 42646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A696")]
			[Address(RVA = "0x20F2ACC", Offset = "0x20F2ACC", VA = "0x7BBC8F2ACC")]
			public NotifyArgsJoin()
			{
			}

			// Token: 0x0400AC1D RID: 44061
			[Token(Token = "0x400AC1D")]
			[FieldOffset(Offset = "0x18")]
			public ulong friendID;

			// Token: 0x0400AC1E RID: 44062
			[Token(Token = "0x400AC1E")]
			[FieldOffset(Offset = "0x20")]
			public bool teamIsFull;
		}

		// Token: 0x02001DAE RID: 7598
		[Token(Token = "0x2001DAE")]
		public class NotifyArgsInvite : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A697 RID: 42647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A697")]
			[Address(RVA = "0x20F51B0", Offset = "0x20F51B0", VA = "0x7BBC8F51B0")]
			public NotifyArgsInvite()
			{
			}

			// Token: 0x0400AC1F RID: 44063
			[Token(Token = "0x400AC1F")]
			[FieldOffset(Offset = "0x18")]
			public ulong invitee;

			// Token: 0x0400AC20 RID: 44064
			[Token(Token = "0x400AC20")]
			[FieldOffset(Offset = "0x20")]
			public bool sameRequest;
		}

		// Token: 0x02001DAF RID: 7599
		[Token(Token = "0x2001DAF")]
		public class NotifyArgsQuit : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A698 RID: 42648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A698")]
			[Address(RVA = "0x20F3CB0", Offset = "0x20F3CB0", VA = "0x7BBC8F3CB0")]
			public NotifyArgsQuit()
			{
			}

			// Token: 0x0400AC21 RID: 44065
			[Token(Token = "0x400AC21")]
			[FieldOffset(Offset = "0x11")]
			public bool toNewTeam;
		}

		// Token: 0x02001DB0 RID: 7600
		[Token(Token = "0x2001DB0")]
		public class NotifyArgsDismiss : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A699 RID: 42649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A699")]
			[Address(RVA = "0x20F4444", Offset = "0x20F4444", VA = "0x7BBC8F4444")]
			public NotifyArgsDismiss()
			{
			}

			// Token: 0x0400AC22 RID: 44066
			[Token(Token = "0x400AC22")]
			[FieldOffset(Offset = "0x11")]
			public bool toNewTeam;
		}

		// Token: 0x02001DB1 RID: 7601
		[Token(Token = "0x2001DB1")]
		public class NotifyArgsStats : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A69A RID: 42650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69A")]
			[Address(RVA = "0x20F69E0", Offset = "0x20F69E0", VA = "0x7BBC8F69E0")]
			public NotifyArgsStats()
			{
			}

			// Token: 0x0400AC23 RID: 44067
			[Token(Token = "0x400AC23")]
			[FieldOffset(Offset = "0x18")]
			public CSTeamChampionshipSeasonStatsRes stats;
		}

		// Token: 0x02001DB2 RID: 7602
		[Token(Token = "0x2001DB2")]
		public class NotifyArgsAccountLifeSeasonStats : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A69B RID: 42651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69B")]
			[Address(RVA = "0x20F69D0", Offset = "0x20F69D0", VA = "0x7BBC8F69D0")]
			public NotifyArgsAccountLifeSeasonStats()
			{
			}

			// Token: 0x0400AC24 RID: 44068
			[Token(Token = "0x400AC24")]
			[FieldOffset(Offset = "0x18")]
			public List<AccountSeasonStats> statsList;
		}

		// Token: 0x02001DB3 RID: 7603
		[Token(Token = "0x2001DB3")]
		public class NotifyArgsTeamMatchStatsHistory : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A69C RID: 42652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69C")]
			[Address(RVA = "0x20F3524", Offset = "0x20F3524", VA = "0x7BBC8F3524")]
			public NotifyArgsTeamMatchStatsHistory()
			{
			}

			// Token: 0x0400AC25 RID: 44069
			[Token(Token = "0x400AC25")]
			[FieldOffset(Offset = "0x18")]
			public CSTeamMatchStatsHistoryRes matchStatsHistory;
		}

		// Token: 0x02001DB4 RID: 7604
		[Token(Token = "0x2001DB4")]
		public class NotifyArgsTeamInfo : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A69D RID: 42653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69D")]
			[Address(RVA = "0x20F2E10", Offset = "0x20F2E10", VA = "0x7BBC8F2E10")]
			public NotifyArgsTeamInfo()
			{
			}

			// Token: 0x0400AC26 RID: 44070
			[Token(Token = "0x400AC26")]
			[FieldOffset(Offset = "0x18")]
			public TeamInfo teamInfo;
		}

		// Token: 0x02001DB5 RID: 7605
		[Token(Token = "0x2001DB5")]
		public class NotifyArgsTeamMemberInfo : UIModelChampionship.NotifyArgs
		{
			// Token: 0x0600A69E RID: 42654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69E")]
			[Address(RVA = "0x20F31AC", Offset = "0x20F31AC", VA = "0x7BBC8F31AC")]
			public NotifyArgsTeamMemberInfo()
			{
			}

			// Token: 0x0400AC27 RID: 44071
			[Token(Token = "0x400AC27")]
			[FieldOffset(Offset = "0x18")]
			public TeamMemberListWithAccountInfo teamMemberInfo;
		}

		// Token: 0x02001DB6 RID: 7606
		[Token(Token = "0x2001DB6")]
		public struct StateViewInfo
		{
			// Token: 0x0400AC28 RID: 44072
			[Token(Token = "0x400AC28")]
			[FieldOffset(Offset = "0x0")]
			public string stateText;

			// Token: 0x0400AC29 RID: 44073
			[Token(Token = "0x400AC29")]
			[FieldOffset(Offset = "0x8")]
			public string stateDescText;
		}

		// Token: 0x02001DB7 RID: 7607
		[Token(Token = "0x2001DB7")]
		public enum ChampionshipEntranceState
		{
			// Token: 0x0400AC2B RID: 44075
			[Token(Token = "0x400AC2B")]
			Closed,
			// Token: 0x0400AC2C RID: 44076
			[Token(Token = "0x400AC2C")]
			WarmUp,
			// Token: 0x0400AC2D RID: 44077
			[Token(Token = "0x400AC2D")]
			Opened,
			// Token: 0x0400AC2E RID: 44078
			[Token(Token = "0x400AC2E")]
			Paused
		}

		// Token: 0x02001DB8 RID: 7608
		[Token(Token = "0x2001DB8")]
		public enum ChampionshipOpenState
		{
			// Token: 0x0400AC30 RID: 44080
			[Token(Token = "0x400AC30")]
			UnOpen,
			// Token: 0x0400AC31 RID: 44081
			[Token(Token = "0x400AC31")]
			EntranceOpen,
			// Token: 0x0400AC32 RID: 44082
			[Token(Token = "0x400AC32")]
			SeasonOpen,
			// Token: 0x0400AC33 RID: 44083
			[Token(Token = "0x400AC33")]
			TodayOpen,
			// Token: 0x0400AC34 RID: 44084
			[Token(Token = "0x400AC34")]
			TodayUnOpen,
			// Token: 0x0400AC35 RID: 44085
			[Token(Token = "0x400AC35")]
			Result,
			// Token: 0x0400AC36 RID: 44086
			[Token(Token = "0x400AC36")]
			TrialClose,
			// Token: 0x0400AC37 RID: 44087
			[Token(Token = "0x400AC37")]
			SeasonClose
		}

		// Token: 0x02001DB9 RID: 7609
		[Token(Token = "0x2001DB9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFA4", Offset = "0x10FBFA4")]
		private sealed class <>c__DisplayClass83_0
		{
			// Token: 0x0600A69F RID: 42655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A69F")]
			[Address(RVA = "0x20F68C4", Offset = "0x20F68C4", VA = "0x7BBC8F68C4")]
			public <>c__DisplayClass83_0()
			{
			}

			// Token: 0x0600A6A0 RID: 42656 RVA: 0x0002CB98 File Offset: 0x0002AD98
			[Token(Token = "0x600A6A0")]
			[Address(RVA = "0x20F68CC", Offset = "0x20F68CC", VA = "0x7BBC8F68CC")]
			internal bool <TeamSetting>b__0(ChampionshipTeamDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400AC38 RID: 44088
			[Token(Token = "0x400AC38")]
			[FieldOffset(Offset = "0x10")]
			public ChampionshipSettingDesc cpSetting;
		}

		// Token: 0x02001DBA RID: 7610
		[Token(Token = "0x2001DBA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFB4", Offset = "0x10FBFB4")]
		private sealed class <>c__DisplayClass88_0
		{
			// Token: 0x0600A6A1 RID: 42657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6A1")]
			[Address(RVA = "0x20F6918", Offset = "0x20F6918", VA = "0x7BBC8F6918")]
			public <>c__DisplayClass88_0()
			{
			}

			// Token: 0x0600A6A2 RID: 42658 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
			[Token(Token = "0x600A6A2")]
			[Address(RVA = "0x20F6920", Offset = "0x20F6920", VA = "0x7BBC8F6920")]
			internal bool <SelfTeamMembers>b__0(TeamMemberWithAccountInfo m)
			{
				return default(bool);
			}

			// Token: 0x0400AC39 RID: 44089
			[Token(Token = "0x400AC39")]
			[FieldOffset(Offset = "0x10")]
			public ulong selfAccountID;
		}

		// Token: 0x02001DBB RID: 7611
		[Token(Token = "0x2001DBB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFC4", Offset = "0x10FBFC4")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600A6A3 RID: 42659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6A3")]
			[Address(RVA = "0x20F696C", Offset = "0x20F696C", VA = "0x7BBC8F696C")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600A6A4 RID: 42660 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
			[Token(Token = "0x600A6A4")]
			[Address(RVA = "0x20F6974", Offset = "0x20F6974", VA = "0x7BBC8F6974")]
			internal bool <GetTeamRank>b__0(LeaderBoardInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AC3A RID: 44090
			[Token(Token = "0x400AC3A")]
			[FieldOffset(Offset = "0x10")]
			public ulong teamID;
		}

		// Token: 0x02001DBC RID: 7612
		[Token(Token = "0x2001DBC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFD4", Offset = "0x10FBFD4")]
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x0600A6A5 RID: 42661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6A5")]
			[Address(RVA = "0x20F24E8", Offset = "0x20F24E8", VA = "0x7BBC8F24E8")]
			public <>c__DisplayClass101_0()
			{
			}

			// Token: 0x0600A6A6 RID: 42662 RVA: 0x0002CBE0 File Offset: 0x0002ADE0
			[Token(Token = "0x600A6A6")]
			[Address(RVA = "0x20F24F0", Offset = "0x20F24F0", VA = "0x7BBC8F24F0")]
			internal bool <GetChampionshipOpenInfo>b__0(ChampionshipOpenInfoDesc basicInfo)
			{
				return default(bool);
			}

			// Token: 0x0400AC3B RID: 44091
			[Token(Token = "0x400AC3B")]
			[FieldOffset(Offset = "0x10")]
			public uint type;

			// Token: 0x0400AC3C RID: 44092
			[Token(Token = "0x400AC3C")]
			[FieldOffset(Offset = "0x14")]
			public uint championshipID;
		}

		// Token: 0x02001DBD RID: 7613
		[Token(Token = "0x2001DBD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFE4", Offset = "0x10FBFE4")]
		private sealed class <>c__DisplayClass107_0
		{
			// Token: 0x0600A6A7 RID: 42663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6A7")]
			[Address(RVA = "0x20F2544", Offset = "0x20F2544", VA = "0x7BBC8F2544")]
			public <>c__DisplayClass107_0()
			{
			}

			// Token: 0x0400AC3D RID: 44093
			[Token(Token = "0x400AC3D")]
			[FieldOffset(Offset = "0x10")]
			public uint type;
		}

		// Token: 0x02001DBE RID: 7614
		[Token(Token = "0x2001DBE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBFF4", Offset = "0x10FBFF4")]
		private sealed class <>c__DisplayClass107_1
		{
			// Token: 0x0600A6A8 RID: 42664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6A8")]
			[Address(RVA = "0x20F254C", Offset = "0x20F254C", VA = "0x7BBC8F254C")]
			public <>c__DisplayClass107_1()
			{
			}

			// Token: 0x0600A6A9 RID: 42665 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
			[Token(Token = "0x600A6A9")]
			[Address(RVA = "0x20F2554", Offset = "0x20F2554", VA = "0x7BBC8F2554")]
			internal bool <GetChampionshipSetting>b__0(ChampionshipSettingDesc basicInfo)
			{
				return default(bool);
			}

			// Token: 0x0400AC3E RID: 44094
			[Token(Token = "0x400AC3E")]
			[FieldOffset(Offset = "0x10")]
			public uint cpID;

			// Token: 0x0400AC3F RID: 44095
			[Token(Token = "0x400AC3F")]
			[FieldOffset(Offset = "0x18")]
			public UIModelChampionship.<>c__DisplayClass107_0 CS$<>8__locals1;
		}

		// Token: 0x02001DBF RID: 7615
		[Token(Token = "0x2001DBF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC004", Offset = "0x10FC004")]
		private sealed class <>c__DisplayClass108_0
		{
			// Token: 0x0600A6AA RID: 42666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6AA")]
			[Address(RVA = "0x20F25C0", Offset = "0x20F25C0", VA = "0x7BBC8F25C0")]
			public <>c__DisplayClass108_0()
			{
			}

			// Token: 0x0600A6AB RID: 42667 RVA: 0x0002CC10 File Offset: 0x0002AE10
			[Token(Token = "0x600A6AB")]
			[Address(RVA = "0x20F25C8", Offset = "0x20F25C8", VA = "0x7BBC8F25C8")]
			internal bool <GetChampionshipScoreBaseInfoByType>b__0(ChampionshipScoreBaseDesc basicInfo)
			{
				return default(bool);
			}

			// Token: 0x0400AC40 RID: 44096
			[Token(Token = "0x400AC40")]
			[FieldOffset(Offset = "0x10")]
			public uint type;
		}

		// Token: 0x02001DC0 RID: 7616
		[Token(Token = "0x2001DC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC014", Offset = "0x10FC014")]
		private sealed class <>c__DisplayClass111_0
		{
			// Token: 0x0600A6AC RID: 42668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6AC")]
			[Address(RVA = "0x20F2604", Offset = "0x20F2604", VA = "0x7BBC8F2604")]
			public <>c__DisplayClass111_0()
			{
			}

			// Token: 0x0600A6AD RID: 42669 RVA: 0x0002CC28 File Offset: 0x0002AE28
			[Token(Token = "0x600A6AD")]
			[Address(RVA = "0x20F260C", Offset = "0x20F260C", VA = "0x7BBC8F260C")]
			internal bool <GetChampionshipRewardListByPos>b__0(ChampionshipScoreRewardDesc r)
			{
				return default(bool);
			}

			// Token: 0x0400AC41 RID: 44097
			[Token(Token = "0x400AC41")]
			[FieldOffset(Offset = "0x10")]
			public uint realPos;
		}

		// Token: 0x02001DC1 RID: 7617
		[Token(Token = "0x2001DC1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC024", Offset = "0x10FC024")]
		private sealed class <>c__DisplayClass112_0
		{
			// Token: 0x0600A6AE RID: 42670 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6AE")]
			[Address(RVA = "0x20F2668", Offset = "0x20F2668", VA = "0x7BBC8F2668")]
			public <>c__DisplayClass112_0()
			{
			}

			// Token: 0x0600A6AF RID: 42671 RVA: 0x0002CC40 File Offset: 0x0002AE40
			[Token(Token = "0x600A6AF")]
			[Address(RVA = "0x20F2670", Offset = "0x20F2670", VA = "0x7BBC8F2670")]
			internal bool <GetChampionshipRewardIndexByPos>b__0(ChampionshipScoreRewardDesc r)
			{
				return default(bool);
			}

			// Token: 0x0400AC42 RID: 44098
			[Token(Token = "0x400AC42")]
			[FieldOffset(Offset = "0x10")]
			public uint realPos;
		}

		// Token: 0x02001DC2 RID: 7618
		[Token(Token = "0x2001DC2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC034", Offset = "0x10FC034")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A6B1 RID: 42673 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6B1")]
			[Address(RVA = "0x20F23EC", Offset = "0x20F23EC", VA = "0x7BBC8F23EC")]
			public <>c()
			{
			}

			// Token: 0x0600A6B2 RID: 42674 RVA: 0x0002CC58 File Offset: 0x0002AE58
			[Token(Token = "0x600A6B2")]
			[Address(RVA = "0x20F23F4", Offset = "0x20F23F4", VA = "0x7BBC8F23F4")]
			internal bool <GetLowestChampionshipRewardDesc>b__113_0(ChampionshipScoreRewardDesc r)
			{
				return default(bool);
			}

			// Token: 0x0600A6B3 RID: 42675 RVA: 0x0002CC70 File Offset: 0x0002AE70
			[Token(Token = "0x600A6B3")]
			[Address(RVA = "0x20F2478", Offset = "0x20F2478", VA = "0x7BBC8F2478")]
			internal bool <GetFirstChampionshipRewardDesc>b__114_0(ChampionshipScoreRewardDesc r)
			{
				return default(bool);
			}

			// Token: 0x0600A6B4 RID: 42676 RVA: 0x0002CC88 File Offset: 0x0002AE88
			[Token(Token = "0x600A6B4")]
			[Address(RVA = "0x20F24AC", Offset = "0x20F24AC", VA = "0x7BBC8F24AC")]
			internal ulong <RequestTeamMemberPresence>b__147_0(TeamMemberWithAccountInfo e)
			{
				return 0UL;
			}

			// Token: 0x0400AC43 RID: 44099
			[Token(Token = "0x400AC43")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelChampionship.<>c <>9;

			// Token: 0x0400AC44 RID: 44100
			[Token(Token = "0x400AC44")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<ChampionshipScoreRewardDesc> <>9__113_0;

			// Token: 0x0400AC45 RID: 44101
			[Token(Token = "0x400AC45")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<ChampionshipScoreRewardDesc> <>9__114_0;

			// Token: 0x0400AC46 RID: 44102
			[Token(Token = "0x400AC46")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<TeamMemberWithAccountInfo, ulong> <>9__147_0;
		}

		// Token: 0x02001DC3 RID: 7619
		[Token(Token = "0x2001DC3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC044", Offset = "0x10FC044")]
		private sealed class <>c__DisplayClass117_0
		{
			// Token: 0x0600A6B5 RID: 42677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6B5")]
			[Address(RVA = "0x20F26CC", Offset = "0x20F26CC", VA = "0x7BBC8F26CC")]
			public <>c__DisplayClass117_0()
			{
			}

			// Token: 0x0600A6B6 RID: 42678 RVA: 0x0002CCA0 File Offset: 0x0002AEA0
			[Token(Token = "0x600A6B6")]
			[Address(RVA = "0x20F26D4", Offset = "0x20F26D4", VA = "0x7BBC8F26D4")]
			internal bool <GetRankPosRange>b__0(ChampionshipScoreRewardDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400AC47 RID: 44103
			[Token(Token = "0x400AC47")]
			[FieldOffset(Offset = "0x10")]
			public uint realPos;
		}

		// Token: 0x02001DC4 RID: 7620
		[Token(Token = "0x2001DC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC054", Offset = "0x10FC054")]
		private sealed class <>c__DisplayClass129_0
		{
			// Token: 0x0600A6B7 RID: 42679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6B7")]
			[Address(RVA = "0x20F2724", Offset = "0x20F2724", VA = "0x7BBC8F2724")]
			public <>c__DisplayClass129_0()
			{
			}

			// Token: 0x0600A6B8 RID: 42680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6B8")]
			[Address(RVA = "0x20F272C", Offset = "0x20F272C", VA = "0x7BBC8F272C")]
			internal void <RequestJoinTeam>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC48 RID: 44104
			[Token(Token = "0x400AC48")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC49 RID: 44105
			[Token(Token = "0x400AC49")]
			[FieldOffset(Offset = "0x18")]
			public ulong friendID;
		}

		// Token: 0x02001DC5 RID: 7621
		[Token(Token = "0x2001DC5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC064", Offset = "0x10FC064")]
		private sealed class <>c__DisplayClass132_0
		{
			// Token: 0x0600A6B9 RID: 42681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6B9")]
			[Address(RVA = "0x20F2AD4", Offset = "0x20F2AD4", VA = "0x7BBC8F2AD4")]
			public <>c__DisplayClass132_0()
			{
			}

			// Token: 0x0600A6BA RID: 42682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BA")]
			[Address(RVA = "0x20F2ADC", Offset = "0x20F2ADC", VA = "0x7BBC8F2ADC")]
			internal void <RequestTeamInfoByTeamID>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC4A RID: 44106
			[Token(Token = "0x400AC4A")]
			[FieldOffset(Offset = "0x10")]
			public ulong teamID;

			// Token: 0x0400AC4B RID: 44107
			[Token(Token = "0x400AC4B")]
			[FieldOffset(Offset = "0x18")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC4C RID: 44108
			[Token(Token = "0x400AC4C")]
			[FieldOffset(Offset = "0x20")]
			public bool requestTeamApplication;
		}

		// Token: 0x02001DC6 RID: 7622
		[Token(Token = "0x2001DC6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC074", Offset = "0x10FC074")]
		private sealed class <>c__DisplayClass134_0
		{
			// Token: 0x0600A6BB RID: 42683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BB")]
			[Address(RVA = "0x20F2E18", Offset = "0x20F2E18", VA = "0x7BBC8F2E18")]
			public <>c__DisplayClass134_0()
			{
			}

			// Token: 0x0600A6BC RID: 42684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BC")]
			[Address(RVA = "0x20F2E20", Offset = "0x20F2E20", VA = "0x7BBC8F2E20")]
			internal void <RequestTeamMembers>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC4D RID: 44109
			[Token(Token = "0x400AC4D")]
			[FieldOffset(Offset = "0x10")]
			public TeamIDReq req;

			// Token: 0x0400AC4E RID: 44110
			[Token(Token = "0x400AC4E")]
			[FieldOffset(Offset = "0x18")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC4F RID: 44111
			[Token(Token = "0x400AC4F")]
			[FieldOffset(Offset = "0x20")]
			public bool requestTeamMemberPresence;
		}

		// Token: 0x02001DC7 RID: 7623
		[Token(Token = "0x2001DC7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC084", Offset = "0x10FC084")]
		private sealed class <>c__DisplayClass135_0
		{
			// Token: 0x0600A6BD RID: 42685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BD")]
			[Address(RVA = "0x20F31B4", Offset = "0x20F31B4", VA = "0x7BBC8F31B4")]
			public <>c__DisplayClass135_0()
			{
			}

			// Token: 0x0600A6BE RID: 42686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BE")]
			[Address(RVA = "0x20F31BC", Offset = "0x20F31BC", VA = "0x7BBC8F31BC")]
			internal void <RequestTeamMatchStatsHistory>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC50 RID: 44112
			[Token(Token = "0x400AC50")]
			[FieldOffset(Offset = "0x10")]
			public ulong teamID;

			// Token: 0x0400AC51 RID: 44113
			[Token(Token = "0x400AC51")]
			[FieldOffset(Offset = "0x18")]
			public UIModelChampionship <>4__this;
		}

		// Token: 0x02001DC8 RID: 7624
		[Token(Token = "0x2001DC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC094", Offset = "0x10FC094")]
		private sealed class <>c__DisplayClass136_0
		{
			// Token: 0x0600A6BF RID: 42687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6BF")]
			[Address(RVA = "0x20F352C", Offset = "0x20F352C", VA = "0x7BBC8F352C")]
			public <>c__DisplayClass136_0()
			{
			}

			// Token: 0x0600A6C0 RID: 42688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C0")]
			[Address(RVA = "0x20F3534", Offset = "0x20F3534", VA = "0x7BBC8F3534")]
			internal void <RequestQuitTeam>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC52 RID: 44114
			[Token(Token = "0x400AC52")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC53 RID: 44115
			[Token(Token = "0x400AC53")]
			[FieldOffset(Offset = "0x18")]
			public bool toNewTeam;

			// Token: 0x0400AC54 RID: 44116
			[Token(Token = "0x400AC54")]
			[FieldOffset(Offset = "0x19")]
			public bool requestApproveJoinTeamInvitation;

			// Token: 0x0400AC55 RID: 44117
			[Token(Token = "0x400AC55")]
			[FieldOffset(Offset = "0x20")]
			public ulong inviter;

			// Token: 0x0400AC56 RID: 44118
			[Token(Token = "0x400AC56")]
			[FieldOffset(Offset = "0x28")]
			public ulong inviterTeam;
		}

		// Token: 0x02001DC9 RID: 7625
		[Token(Token = "0x2001DC9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0A4", Offset = "0x10FC0A4")]
		private sealed class <>c__DisplayClass137_0
		{
			// Token: 0x0600A6C1 RID: 42689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C1")]
			[Address(RVA = "0x20F3CB8", Offset = "0x20F3CB8", VA = "0x7BBC8F3CB8")]
			public <>c__DisplayClass137_0()
			{
			}

			// Token: 0x0600A6C2 RID: 42690 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C2")]
			[Address(RVA = "0x20F3CC0", Offset = "0x20F3CC0", VA = "0x7BBC8F3CC0")]
			internal void <RequestDismissTeam>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC57 RID: 44119
			[Token(Token = "0x400AC57")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC58 RID: 44120
			[Token(Token = "0x400AC58")]
			[FieldOffset(Offset = "0x18")]
			public bool toNewTeam;

			// Token: 0x0400AC59 RID: 44121
			[Token(Token = "0x400AC59")]
			[FieldOffset(Offset = "0x19")]
			public bool requestApproveJoinTeamInvitation;

			// Token: 0x0400AC5A RID: 44122
			[Token(Token = "0x400AC5A")]
			[FieldOffset(Offset = "0x20")]
			public ulong inviter;

			// Token: 0x0400AC5B RID: 44123
			[Token(Token = "0x400AC5B")]
			[FieldOffset(Offset = "0x28")]
			public ulong inviterTeam;
		}

		// Token: 0x02001DCA RID: 7626
		[Token(Token = "0x2001DCA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0B4", Offset = "0x10FC0B4")]
		private sealed class <>c__DisplayClass142_0
		{
			// Token: 0x0600A6C3 RID: 42691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C3")]
			[Address(RVA = "0x20F444C", Offset = "0x20F444C", VA = "0x7BBC8F444C")]
			public <>c__DisplayClass142_0()
			{
			}

			// Token: 0x0600A6C4 RID: 42692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C4")]
			[Address(RVA = "0x20F4454", Offset = "0x20F4454", VA = "0x7BBC8F4454")]
			internal void <RequestApproveApplication>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC5C RID: 44124
			[Token(Token = "0x400AC5C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC5D RID: 44125
			[Token(Token = "0x400AC5D")]
			[FieldOffset(Offset = "0x18")]
			public CSApproveJoinApplicationReq req;

			// Token: 0x0400AC5E RID: 44126
			[Token(Token = "0x400AC5E")]
			[FieldOffset(Offset = "0x20")]
			public AccountInfoBasic basicInfo;
		}

		// Token: 0x02001DCB RID: 7627
		[Token(Token = "0x2001DCB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0C4", Offset = "0x10FC0C4")]
		private sealed class <>c__DisplayClass143_0
		{
			// Token: 0x0600A6C5 RID: 42693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C5")]
			[Address(RVA = "0x20F4BF4", Offset = "0x20F4BF4", VA = "0x7BBC8F4BF4")]
			public <>c__DisplayClass143_0()
			{
			}

			// Token: 0x0600A6C6 RID: 42694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C6")]
			[Address(RVA = "0x20F4BFC", Offset = "0x20F4BFC", VA = "0x7BBC8F4BFC")]
			internal void <RequestDeclineApplication>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A6C7 RID: 42695 RVA: 0x0002CCB8 File Offset: 0x0002AEB8
			[Token(Token = "0x600A6C7")]
			[Address(RVA = "0x20F4E38", Offset = "0x20F4E38", VA = "0x7BBC8F4E38")]
			internal bool <RequestDeclineApplication>b__1(AccountInfoBasic e)
			{
				return default(bool);
			}

			// Token: 0x0400AC5F RID: 44127
			[Token(Token = "0x400AC5F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC60 RID: 44128
			[Token(Token = "0x400AC60")]
			[FieldOffset(Offset = "0x18")]
			public ulong[] applicantIDs;

			// Token: 0x0400AC61 RID: 44129
			[Token(Token = "0x400AC61")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<AccountInfoBasic> <>9__1;
		}

		// Token: 0x02001DCC RID: 7628
		[Token(Token = "0x2001DCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0D4", Offset = "0x10FC0D4")]
		private sealed class <>c__DisplayClass144_0
		{
			// Token: 0x0600A6C8 RID: 42696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C8")]
			[Address(RVA = "0x20F4EA8", Offset = "0x20F4EA8", VA = "0x7BBC8F4EA8")]
			public <>c__DisplayClass144_0()
			{
			}

			// Token: 0x0600A6C9 RID: 42697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6C9")]
			[Address(RVA = "0x20F4EB0", Offset = "0x20F4EB0", VA = "0x7BBC8F4EB0")]
			internal void <RequestInvite>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC62 RID: 44130
			[Token(Token = "0x400AC62")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC63 RID: 44131
			[Token(Token = "0x400AC63")]
			[FieldOffset(Offset = "0x18")]
			public ulong inviteeID;
		}

		// Token: 0x02001DCD RID: 7629
		[Token(Token = "0x2001DCD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0E4", Offset = "0x10FC0E4")]
		private sealed class <>c__DisplayClass145_0
		{
			// Token: 0x0600A6CA RID: 42698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6CA")]
			[Address(RVA = "0x20F51B8", Offset = "0x20F51B8", VA = "0x7BBC8F51B8")]
			public <>c__DisplayClass145_0()
			{
			}

			// Token: 0x0600A6CB RID: 42699 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6CB")]
			[Address(RVA = "0x20F51C0", Offset = "0x20F51C0", VA = "0x7BBC8F51C0")]
			internal void <RequestApproveJoinTeamInvitation>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A6CC RID: 42700 RVA: 0x0002CCD0 File Offset: 0x0002AED0
			[Token(Token = "0x600A6CC")]
			[Address(RVA = "0x20F541C", Offset = "0x20F541C", VA = "0x7BBC8F541C")]
			internal bool <RequestApproveJoinTeamInvitation>b__1(AccountInfoBasic e)
			{
				return default(bool);
			}

			// Token: 0x0400AC64 RID: 44132
			[Token(Token = "0x400AC64")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC65 RID: 44133
			[Token(Token = "0x400AC65")]
			[FieldOffset(Offset = "0x18")]
			public ulong inviterTeam;

			// Token: 0x0400AC66 RID: 44134
			[Token(Token = "0x400AC66")]
			[FieldOffset(Offset = "0x20")]
			public ulong inviter;

			// Token: 0x0400AC67 RID: 44135
			[Token(Token = "0x400AC67")]
			[FieldOffset(Offset = "0x28")]
			public Predicate<AccountInfoBasic> <>9__1;
		}

		// Token: 0x02001DCE RID: 7630
		[Token(Token = "0x2001DCE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC0F4", Offset = "0x10FC0F4")]
		private sealed class <>c__DisplayClass146_0
		{
			// Token: 0x0600A6CD RID: 42701 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6CD")]
			[Address(RVA = "0x20F5458", Offset = "0x20F5458", VA = "0x7BBC8F5458")]
			public <>c__DisplayClass146_0()
			{
			}

			// Token: 0x0600A6CE RID: 42702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6CE")]
			[Address(RVA = "0x20F5460", Offset = "0x20F5460", VA = "0x7BBC8F5460")]
			internal void <RequestDeclineJoinTeamInvitation>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600A6CF RID: 42703 RVA: 0x0002CCE8 File Offset: 0x0002AEE8
			[Token(Token = "0x600A6CF")]
			[Address(RVA = "0x20F569C", Offset = "0x20F569C", VA = "0x7BBC8F569C")]
			internal bool <RequestDeclineJoinTeamInvitation>b__1(AccountInfoBasic e)
			{
				return default(bool);
			}

			// Token: 0x0400AC68 RID: 44136
			[Token(Token = "0x400AC68")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC69 RID: 44137
			[Token(Token = "0x400AC69")]
			[FieldOffset(Offset = "0x18")]
			public ulong[] inviterIDs;

			// Token: 0x0400AC6A RID: 44138
			[Token(Token = "0x400AC6A")]
			[FieldOffset(Offset = "0x20")]
			public Predicate<AccountInfoBasic> <>9__1;
		}

		// Token: 0x02001DCF RID: 7631
		[Token(Token = "0x2001DCF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC104", Offset = "0x10FC104")]
		private sealed class <>c__DisplayClass148_0
		{
			// Token: 0x0600A6D0 RID: 42704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D0")]
			[Address(RVA = "0x20F570C", Offset = "0x20F570C", VA = "0x7BBC8F570C")]
			public <>c__DisplayClass148_0()
			{
			}

			// Token: 0x0600A6D1 RID: 42705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D1")]
			[Address(RVA = "0x20F5714", Offset = "0x20F5714", VA = "0x7BBC8F5714")]
			internal void <RequestRemoveTeamMember>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC6B RID: 44139
			[Token(Token = "0x400AC6B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC6C RID: 44140
			[Token(Token = "0x400AC6C")]
			[FieldOffset(Offset = "0x18")]
			public ulong removeeID;
		}

		// Token: 0x02001DD0 RID: 7632
		[Token(Token = "0x2001DD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC114", Offset = "0x10FC114")]
		private sealed class <>c__DisplayClass149_0
		{
			// Token: 0x0600A6D2 RID: 42706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D2")]
			[Address(RVA = "0x20F5B00", Offset = "0x20F5B00", VA = "0x7BBC8F5B00")]
			public <>c__DisplayClass149_0()
			{
			}

			// Token: 0x0600A6D3 RID: 42707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D3")]
			[Address(RVA = "0x20F5B08", Offset = "0x20F5B08", VA = "0x7BBC8F5B08")]
			internal void <RequestGetTeamChampionshipInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC6D RID: 44141
			[Token(Token = "0x400AC6D")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC6E RID: 44142
			[Token(Token = "0x400AC6E")]
			[FieldOffset(Offset = "0x18")]
			public uint championshipType;
		}

		// Token: 0x02001DD1 RID: 7633
		[Token(Token = "0x2001DD1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC124", Offset = "0x10FC124")]
		private sealed class <>c__DisplayClass151_0
		{
			// Token: 0x0600A6D4 RID: 42708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D4")]
			[Address(RVA = "0x20F5FB0", Offset = "0x20F5FB0", VA = "0x7BBC8F5FB0")]
			public <>c__DisplayClass151_0()
			{
			}

			// Token: 0x0600A6D5 RID: 42709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D5")]
			[Address(RVA = "0x20F5FB8", Offset = "0x20F5FB8", VA = "0x7BBC8F5FB8")]
			internal void <RequestChampionshipConfig>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400AC6F RID: 44143
			[Token(Token = "0x400AC6F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC70 RID: 44144
			[Token(Token = "0x400AC70")]
			[FieldOffset(Offset = "0x18")]
			public uint championshipType;

			// Token: 0x0400AC71 RID: 44145
			[Token(Token = "0x400AC71")]
			[FieldOffset(Offset = "0x1C")]
			public uint championshipID;
		}

		// Token: 0x02001DD2 RID: 7634
		[Token(Token = "0x2001DD2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC134", Offset = "0x10FC134")]
		private sealed class <>c__DisplayClass162_0
		{
			// Token: 0x0600A6D6 RID: 42710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D6")]
			[Address(RVA = "0x20F62BC", Offset = "0x20F62BC", VA = "0x7BBC8F62BC")]
			public <>c__DisplayClass162_0()
			{
			}

			// Token: 0x0600A6D7 RID: 42711 RVA: 0x0002CD00 File Offset: 0x0002AF00
			[Token(Token = "0x600A6D7")]
			[Address(RVA = "0x20F62C4", Offset = "0x20F62C4", VA = "0x7BBC8F62C4")]
			internal int <SortTeamMember>b__0(TeamMemberWithAccountInfo e, TeamMemberWithAccountInfo o)
			{
				return 0;
			}

			// Token: 0x0400AC72 RID: 44146
			[Token(Token = "0x400AC72")]
			[FieldOffset(Offset = "0x10")]
			public bool sortPresence;

			// Token: 0x0400AC73 RID: 44147
			[Token(Token = "0x400AC73")]
			[FieldOffset(Offset = "0x18")]
			public UIModelChampionship <>4__this;

			// Token: 0x0400AC74 RID: 44148
			[Token(Token = "0x400AC74")]
			[FieldOffset(Offset = "0x20")]
			public TeamInfo teamInfo;
		}

		// Token: 0x02001DD3 RID: 7635
		[Token(Token = "0x2001DD3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC144", Offset = "0x10FC144")]
		private sealed class <>c__DisplayClass174_0
		{
			// Token: 0x0600A6D8 RID: 42712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6D8")]
			[Address(RVA = "0x20F6528", Offset = "0x20F6528", VA = "0x7BBC8F6528")]
			public <>c__DisplayClass174_0()
			{
			}

			// Token: 0x0600A6D9 RID: 42713 RVA: 0x0002CD18 File Offset: 0x0002AF18
			[Token(Token = "0x600A6D9")]
			[Address(RVA = "0x20F6530", Offset = "0x20F6530", VA = "0x7BBC8F6530")]
			internal bool <GetChampionshipTrialMatchName>b__0(ChampionshipNameOverwriteDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400AC75 RID: 44149
			[Token(Token = "0x400AC75")]
			[FieldOffset(Offset = "0x10")]
			public uint championshipType;

			// Token: 0x0400AC76 RID: 44150
			[Token(Token = "0x400AC76")]
			[FieldOffset(Offset = "0x14")]
			public uint championshipID;

			// Token: 0x0400AC77 RID: 44151
			[Token(Token = "0x400AC77")]
			[FieldOffset(Offset = "0x18")]
			public string language;
		}

		// Token: 0x02001DD4 RID: 7636
		[Token(Token = "0x2001DD4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC154", Offset = "0x10FC154")]
		private sealed class <>c__DisplayClass175_0
		{
			// Token: 0x0600A6DA RID: 42714 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6DA")]
			[Address(RVA = "0x20F6638", Offset = "0x20F6638", VA = "0x7BBC8F6638")]
			public <>c__DisplayClass175_0()
			{
			}

			// Token: 0x0600A6DB RID: 42715 RVA: 0x0002CD30 File Offset: 0x0002AF30
			[Token(Token = "0x600A6DB")]
			[Address(RVA = "0x20F6640", Offset = "0x20F6640", VA = "0x7BBC8F6640")]
			internal bool <GetChampionshipModeName>b__0(ChampionshipNameOverwriteDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400AC78 RID: 44152
			[Token(Token = "0x400AC78")]
			[FieldOffset(Offset = "0x10")]
			public uint championshipType;

			// Token: 0x0400AC79 RID: 44153
			[Token(Token = "0x400AC79")]
			[FieldOffset(Offset = "0x14")]
			public uint championshipID;

			// Token: 0x0400AC7A RID: 44154
			[Token(Token = "0x400AC7A")]
			[FieldOffset(Offset = "0x18")]
			public string language;
		}

		// Token: 0x02001DD5 RID: 7637
		[Token(Token = "0x2001DD5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC164", Offset = "0x10FC164")]
		private sealed class <>c__DisplayClass176_0
		{
			// Token: 0x0600A6DC RID: 42716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6DC")]
			[Address(RVA = "0x20F6748", Offset = "0x20F6748", VA = "0x7BBC8F6748")]
			public <>c__DisplayClass176_0()
			{
			}

			// Token: 0x0600A6DD RID: 42717 RVA: 0x0002CD48 File Offset: 0x0002AF48
			[Token(Token = "0x600A6DD")]
			[Address(RVA = "0x20F6750", Offset = "0x20F6750", VA = "0x7BBC8F6750")]
			internal bool <GetChampionshipSeasonNameWithIDOverwrite>b__0(ChampionshipNameOverwriteDesc e)
			{
				return default(bool);
			}

			// Token: 0x0400AC7B RID: 44155
			[Token(Token = "0x400AC7B")]
			[FieldOffset(Offset = "0x10")]
			public uint championshipType;

			// Token: 0x0400AC7C RID: 44156
			[Token(Token = "0x400AC7C")]
			[FieldOffset(Offset = "0x14")]
			public uint championshipID;

			// Token: 0x0400AC7D RID: 44157
			[Token(Token = "0x400AC7D")]
			[FieldOffset(Offset = "0x18")]
			public string language;
		}

		// Token: 0x02001DD6 RID: 7638
		[Token(Token = "0x2001DD6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC174", Offset = "0x10FC174")]
		private sealed class <>c__DisplayClass183_0
		{
			// Token: 0x0600A6DE RID: 42718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6DE")]
			[Address(RVA = "0x20F6858", Offset = "0x20F6858", VA = "0x7BBC8F6858")]
			public <>c__DisplayClass183_0()
			{
			}

			// Token: 0x0600A6DF RID: 42719 RVA: 0x0002CD60 File Offset: 0x0002AF60
			[Token(Token = "0x600A6DF")]
			[Address(RVA = "0x20F6860", Offset = "0x20F6860", VA = "0x7BBC8F6860")]
			internal bool <HasUnTeamMemberPlayerInGroup>b__0(TeamMemberWithAccountInfo m)
			{
				return default(bool);
			}

			// Token: 0x0400AC7E RID: 44158
			[Token(Token = "0x400AC7E")]
			[FieldOffset(Offset = "0x10")]
			public GroupMemberInfo member;
		}
	}
}
