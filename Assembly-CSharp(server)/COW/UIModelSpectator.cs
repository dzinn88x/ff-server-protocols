using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001FF9 RID: 8185
	[Token(Token = "0x2001FF9")]
	internal class UIModelSpectator : UIBaseModel
	{
		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600B603 RID: 46595 RVA: 0x00033D38 File Offset: 0x00031F38
		// (set) Token: 0x0600B604 RID: 46596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7F")]
		public UIModelSpectator.InfoTab CurrentInfoTab
		{
			[Token(Token = "0x600B603")]
			[Address(RVA = "0x22F86BC", Offset = "0x22F86BC", VA = "0x7BBCAF86BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114755C", Offset = "0x114755C")]
			get
			{
				return UIModelSpectator.InfoTab.Player;
			}
			[Token(Token = "0x600B604")]
			[Address(RVA = "0x22F86C4", Offset = "0x22F86C4", VA = "0x7BBCAF86C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114756C", Offset = "0x114756C")]
			set
			{
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x0600B605 RID: 46597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C80")]
		public List<byte> TeamList
		{
			[Token(Token = "0x600B605")]
			[Address(RVA = "0x22F86CC", Offset = "0x22F86CC", VA = "0x7BBCAF86CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600B606 RID: 46598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C81")]
		public List<TeamData> TeamDataList
		{
			[Token(Token = "0x600B606")]
			[Address(RVA = "0x22F86D4", Offset = "0x22F86D4", VA = "0x7BBCAF86D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600B607 RID: 46599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C82")]
		public List<RankingTeamData> RankingTeamDataListByLiving
		{
			[Token(Token = "0x600B607")]
			[Address(RVA = "0x22F86DC", Offset = "0x22F86DC", VA = "0x7BBCAF86DC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600B608 RID: 46600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C83")]
		public List<RankingTeamData> RankingTeamDataByCombatLevel
		{
			[Token(Token = "0x600B608")]
			[Address(RVA = "0x22F8804", Offset = "0x22F8804", VA = "0x7BBCAF8804")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x0600B609 RID: 46601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C84")]
		public List<AccTeamData> AccTeamDataList
		{
			[Token(Token = "0x600B609")]
			[Address(RVA = "0x22F892C", Offset = "0x22F892C", VA = "0x7BBCAF892C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600B60A RID: 46602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C85")]
		public Dictionary<int, UIModelSpectator.TeamWinInfo> RoundResult
		{
			[Token(Token = "0x600B60A")]
			[Address(RVA = "0x22F8934", Offset = "0x22F8934", VA = "0x7BBCAF8934")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B60B RID: 46603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B60B")]
		[Address(RVA = "0x22F893C", Offset = "0x22F893C", VA = "0x7BBCAF893C")]
		public void AddRoundResult(int round, byte winTeamId, byte winReason)
		{
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B60C")]
		[Address(RVA = "0x22F8AAC", Offset = "0x22F8AAC", VA = "0x7BBCAF8AAC")]
		public List<PlayerKillInfo> GetPlayerKillInfo({QAb\u0082~u id)
		{
			return null;
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600B60D RID: 46605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C86")]
		public Dictionary<uint, AirdropInfo> Airdrops
		{
			[Token(Token = "0x600B60D")]
			[Address(RVA = "0x22F8B9C", Offset = "0x22F8B9C", VA = "0x7BBCAF8B9C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600B60E RID: 46606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C87")]
		public List<AirdropInfo> AirdropsList
		{
			[Token(Token = "0x600B60E")]
			[Address(RVA = "0x22F8BA4", Offset = "0x22F8BA4", VA = "0x7BBCAF8BA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x0600B60F RID: 46607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C88")]
		public List<ResultTeamData> MatchResult
		{
			[Token(Token = "0x600B60F")]
			[Address(RVA = "0x22F8BAC", Offset = "0x22F8BAC", VA = "0x7BBCAF8BAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600B610 RID: 46608 RVA: 0x00033D50 File Offset: 0x00031F50
		[Token(Token = "0x17000C89")]
		public int RemainPlayer
		{
			[Token(Token = "0x600B610")]
			[Address(RVA = "0x22F8BB4", Offset = "0x22F8BB4", VA = "0x7BBCAF8BB4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600B611 RID: 46609 RVA: 0x00033D68 File Offset: 0x00031F68
		// (set) Token: 0x0600B612 RID: 46610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8A")]
		public bool GroupIconEnabled
		{
			[Token(Token = "0x600B611")]
			[Address(RVA = "0x22F8BBC", Offset = "0x22F8BBC", VA = "0x7BBCAF8BBC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114757C", Offset = "0x114757C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B612")]
			[Address(RVA = "0x22F8BC4", Offset = "0x22F8BC4", VA = "0x7BBCAF8BC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114758C", Offset = "0x114758C")]
			set
			{
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600B613 RID: 46611 RVA: 0x00033D80 File Offset: 0x00031F80
		// (set) Token: 0x0600B614 RID: 46612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8B")]
		public {QAb\u0082~u CurrentKillLeaderPlayerID
		{
			[Token(Token = "0x600B613")]
			[Address(RVA = "0x22F8BD0", Offset = "0x22F8BD0", VA = "0x7BBCAF8BD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114759C", Offset = "0x114759C")]
			get
			{
				return default({QAb\u0082~u);
			}
			[Token(Token = "0x600B614")]
			[Address(RVA = "0x22F8BE4", Offset = "0x22F8BE4", VA = "0x7BBCAF8BE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475AC", Offset = "0x11475AC")]
			set
			{
			}
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x00033D98 File Offset: 0x00031F98
		[Token(Token = "0x600B615")]
		[Address(RVA = "0x22F8BF8", Offset = "0x22F8BF8", VA = "0x7BBCAF8BF8", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B616 RID: 46614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B616")]
		[Address(RVA = "0x22F8C00", Offset = "0x22F8C00", VA = "0x7BBCAF8C00")]
		public void StartMatch()
		{
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B617")]
		[Address(RVA = "0x22F8E14", Offset = "0x22F8E14", VA = "0x7BBCAF8E14")]
		public void OnAddPlayer(Player player)
		{
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B618")]
		[Address(RVA = "0x22F9B8C", Offset = "0x22F9B8C", VA = "0x7BBCAF9B8C")]
		public void OnDelPlayer({QAb\u0082~u id, {QAb\u0082~u killerId, Vector3 last_position, Vector3 last_forward)
		{
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B619")]
		[Address(RVA = "0x22F9D38", Offset = "0x22F9D38", VA = "0x7BBCAF9D38")]
		public void OnHandlePlayerKillInfo({QAb\u0082~u bekillid, {QAb\u0082~u damager, int weaponID)
		{
		}

		// Token: 0x0600B61A RID: 46618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61A")]
		[Address(RVA = "0x22F9A1C", Offset = "0x22F9A1C", VA = "0x7BBCAF9A1C")]
		public void SortTeams()
		{
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x00033DB0 File Offset: 0x00031FB0
		[Token(Token = "0x600B61B")]
		[Address(RVA = "0x22F9FD4", Offset = "0x22F9FD4", VA = "0x7BBCAF9FD4")]
		private bool IsTeamDead(TeamData team)
		{
			return default(bool);
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61C")]
		[Address(RVA = "0x22FA114", Offset = "0x22FA114", VA = "0x7BBCAFA114")]
		public void OnAlivePlayerCountChanged(int remainingPlayers)
		{
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61D")]
		[Address(RVA = "0x22FA188", Offset = "0x22FA188", VA = "0x7BBCAFA188")]
		public void OnUpdatePlayerKillCount({QAb\u0082~u id, byte oldValue, byte newValue)
		{
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61E")]
		[Address(RVA = "0x22FA310", Offset = "0x22FA310", VA = "0x7BBCAFA310")]
		public void OnUpdatePlayerDeadCount({QAb\u0082~u id, byte oldValue, byte newValue)
		{
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B61F")]
		[Address(RVA = "0x22FA4E4", Offset = "0x22FA4E4", VA = "0x7BBCAFA4E4")]
		public void OnUpdatePlayerAssistCount({QAb\u0082~u id, byte oldValue, byte newValue)
		{
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B620")]
		[Address(RVA = "0x22FA6B8", Offset = "0x22FA6B8", VA = "0x7BBCAFA6B8")]
		public void OnUpdatePlayerTotalDamage({QAb\u0082~u id, uint oldValue, uint newValue)
		{
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B621")]
		[Address(RVA = "0x22FA7B4", Offset = "0x22FA7B4", VA = "0x7BBCAFA7B4")]
		public void OnUpdatePlayerFactionID({QAb\u0082~u id, int factionID)
		{
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B622")]
		[Address(RVA = "0x22FA8B0", Offset = "0x22FA8B0", VA = "0x7BBCAFA8B0")]
		public void OnUpdateTeamWinNum({QAb\u0082~u id, ushort newValue)
		{
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B623")]
		[Address(RVA = "0x22FAA74", Offset = "0x22FAA74", VA = "0x7BBCAFAA74")]
		public Player GetNextLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B624 RID: 46628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B624")]
		[Address(RVA = "0x22FAE48", Offset = "0x22FAE48", VA = "0x7BBCAFAE48")]
		public Player GetPrevLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B625")]
		[Address(RVA = "0x22FB20C", Offset = "0x22FB20C", VA = "0x7BBCAFB20C")]
		public Player GetTeamNextLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B626")]
		[Address(RVA = "0x22FB454", Offset = "0x22FB454", VA = "0x7BBCAFB454")]
		public Player GetTeamPrevLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B627")]
		[Address(RVA = "0x22FB6B8", Offset = "0x22FB6B8", VA = "0x7BBCAFB6B8")]
		public Player GetNextTeamLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B628")]
		[Address(RVA = "0x22FB8FC", Offset = "0x22FB8FC", VA = "0x7BBCAFB8FC")]
		public Player GetPrevTeamLivePlayer({QAb\u0082~u playerId)
		{
			return null;
		}

		// Token: 0x0600B629 RID: 46633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B629")]
		[Address(RVA = "0x22FBB3C", Offset = "0x22FBB3C", VA = "0x7BBCAFBB3C")]
		public Player GetRandomPlayer()
		{
			return null;
		}

		// Token: 0x0600B62A RID: 46634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B62A")]
		[Address(RVA = "0x22FBCD0", Offset = "0x22FBCD0", VA = "0x7BBCAFBCD0")]
		public Player GetFirtstLivePlayerByTeamId(int teamId)
		{
			return null;
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B62B")]
		[Address(RVA = "0x22FBDC4", Offset = "0x22FBDC4", VA = "0x7BBCAFBDC4")]
		public List<PlayerData> GetPlayerListFromTeamId(byte team)
		{
			return null;
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B62C")]
		[Address(RVA = "0x22F95F8", Offset = "0x22F95F8", VA = "0x7BBCAF95F8")]
		public PlayerData GetPlayerData({QAb\u0082~u id)
		{
			return null;
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x00033DC8 File Offset: 0x00031FC8
		[Token(Token = "0x600B62D")]
		[Address(RVA = "0x22FBE4C", Offset = "0x22FBE4C", VA = "0x7BBCAFBE4C")]
		public bool IsCSTeamOnLeft({QAb\u0082~u id)
		{
			return default(bool);
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x00033DE0 File Offset: 0x00031FE0
		[Token(Token = "0x600B62E")]
		[Address(RVA = "0x22FBE98", Offset = "0x22FBE98", VA = "0x7BBCAFBE98")]
		public int GetPlayerCount()
		{
			return 0;
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x00033DF8 File Offset: 0x00031FF8
		[Token(Token = "0x600B62F")]
		[Address(RVA = "0x22FBEF8", Offset = "0x22FBEF8", VA = "0x7BBCAFBEF8")]
		public uint GetTeamKillCount({QAb\u0082~u player)
		{
			return 0U;
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B630")]
		[Address(RVA = "0x22FC004", Offset = "0x22FC004", VA = "0x7BBCAFC004")]
		public void OnGameAchievementNotify({QAb\u0082~u killerId, {QAb\u0082~u beKilledId, int weaponDataId, List<QD|\u0082jKq> type)
		{
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B631")]
		[Address(RVA = "0x22FC448", Offset = "0x22FC448", VA = "0x7BBCAFC448")]
		public void OnAddRejoinDeadPlayer(List<AD|E|wt> deadPlayerInfos)
		{
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B632")]
		[Address(RVA = "0x22FCEC0", Offset = "0x22FCEC0", VA = "0x7BBCAFCEC0")]
		public void AddPickup(uint objID, ^yE\u007FRJO pickup, Vector3 position)
		{
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B633")]
		[Address(RVA = "0x22FD228", Offset = "0x22FD228", VA = "0x7BBCAFD228")]
		public void DelPickup(uint objID, ^yE\u007FRJO pickup)
		{
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x00033E10 File Offset: 0x00032010
		[Token(Token = "0x600B634")]
		[Address(RVA = "0x22FD324", Offset = "0x22FD324", VA = "0x7BBCAFD324")]
		public Vector3 GetPickupPositionByIndex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x0600B635 RID: 46645 RVA: 0x00033E28 File Offset: 0x00032028
		[Token(Token = "0x600B635")]
		[Address(RVA = "0x22FD3AC", Offset = "0x22FD3AC", VA = "0x7BBCAFD3AC")]
		public int GetPickupCount()
		{
			return 0;
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x00033E40 File Offset: 0x00032040
		[Token(Token = "0x600B636")]
		[Address(RVA = "0x22FD40C", Offset = "0x22FD40C", VA = "0x7BBCAFD40C")]
		public int GetRandomPickupIndex()
		{
			return 0;
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B637")]
		[Address(RVA = "0x22FD478", Offset = "0x22FD478", VA = "0x7BBCAFD478")]
		public void AddAirdrop(uint objID, Vector3 position)
		{
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x00033E58 File Offset: 0x00032058
		[Token(Token = "0x600B638")]
		[Address(RVA = "0x22FD554", Offset = "0x22FD554", VA = "0x7BBCAFD554")]
		public uint CalculateTriggerContainerID(Vector3 position)
		{
			return 0U;
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B639")]
		[Address(RVA = "0x22F96A8", Offset = "0x22F96A8", VA = "0x7BBCAF96A8")]
		private Dictionary<HesZZW, int> ConstructItemDic()
		{
			return null;
		}

		// Token: 0x0600B63A RID: 46650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63A")]
		[Address(RVA = "0x22FD76C", Offset = "0x22FD76C", VA = "0x7BBCAFD76C")]
		public void ChangePlayerItem({QAb\u0082~u id, HesZZW type, int count)
		{
		}

		// Token: 0x0600B63B RID: 46651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63B")]
		[Address(RVA = "0x22FDBB4", Offset = "0x22FDBB4", VA = "0x7BBCAFDBB4")]
		public void SpectatorJoinChangePlayerItem(lwdvWIr msg)
		{
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B63C")]
		[Address(RVA = "0x22FDF38", Offset = "0x22FDF38", VA = "0x7BBCAFDF38")]
		public void GenerateSpectatorMatchResult(Wb\u0080zYNb msg)
		{
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B63D")]
		[Address(RVA = "0x22FE870", Offset = "0x22FE870", VA = "0x7BBCAFE870")]
		public List<PlayerData> GetMatchWinnerPlayerData()
		{
			return null;
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B63E")]
		[Address(RVA = "0x22FEABC", Offset = "0x22FEABC", VA = "0x7BBCAFEABC")]
		public List<ResultTeamData> GenerateResult()
		{
			return null;
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B63F")]
		[Address(RVA = "0x22FF144", Offset = "0x22FF144", VA = "0x7BBCAFF144")]
		public ResultMVPInfo GetMatchMvpInfo()
		{
			return null;
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B640")]
		[Address(RVA = "0x22FE6E4", Offset = "0x22FE6E4", VA = "0x7BBCAFE6E4")]
		private void GenerateTeamWinNum()
		{
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B641")]
		[Address(RVA = "0x22FF154", Offset = "0x22FF154", VA = "0x7BBCAFF154")]
		public void RegisterUIShowPosition(Transform transform)
		{
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B642")]
		[Address(RVA = "0x22FF1C4", Offset = "0x22FF1C4", VA = "0x7BBCAFF1C4")]
		public void UnRegisterUIShowPosition(Transform transform)
		{
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B643")]
		[Address(RVA = "0x22FF234", Offset = "0x22FF234", VA = "0x7BBCAFF234")]
		public void OnTeamScoreInited(List<WoiuRUj> teams)
		{
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B644")]
		[Address(RVA = "0x22FF5F8", Offset = "0x22FF5F8", VA = "0x7BBCAFF5F8")]
		public void OnTeamScoreChanged(List<lu\u0082yiKu> teams)
		{
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B645")]
		[Address(RVA = "0x22FFB00", Offset = "0x22FFB00", VA = "0x7BBCAFFB00")]
		public void OnPlayerRankGet(ULmRXKF msg)
		{
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B646")]
		[Address(RVA = "0x22FFE00", Offset = "0x22FFE00", VA = "0x7BBCAFFE00")]
		public void UpdateCombatLevelInfo(KruGck\u0080 msg)
		{
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B647")]
		[Address(RVA = "0x23001F0", Offset = "0x23001F0", VA = "0x7BBCB001F0")]
		public void OnBattleDetected({QAb\u0082~u damager, {QAb\u0082~u beDamaged, hxgtqc~.|yu\u0082|Iy type)
		{
		}

		// Token: 0x0600B648 RID: 46664 RVA: 0x00033E70 File Offset: 0x00032070
		[Token(Token = "0x600B648")]
		[Address(RVA = "0x2300A50", Offset = "0x2300A50", VA = "0x7BBCB00A50")]
		private bool IsValidDamage({QAb\u0082~u damager, {QAb\u0082~u beDamaged, hxgtqc~.|yu\u0082|Iy type)
		{
			return default(bool);
		}

		// Token: 0x0600B649 RID: 46665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B649")]
		[Address(RVA = "0x2300B80", Offset = "0x2300B80", VA = "0x7BBCB00B80")]
		public void RecordMatchInfo()
		{
		}

		// Token: 0x0600B64A RID: 46666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64A")]
		[Address(RVA = "0x2300BF4", Offset = "0x2300BF4", VA = "0x7BBCB00BF4")]
		private void LogToFile()
		{
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x00033E88 File Offset: 0x00032088
		[Token(Token = "0x600B64B")]
		[Address(RVA = "0x2301468", Offset = "0x2301468", VA = "0x7BBCB01468")]
		public bool CheckIsValidGameAchievement(SPGameAchievement info)
		{
			return default(bool);
		}

		// Token: 0x0600B64C RID: 46668 RVA: 0x00033EA0 File Offset: 0x000320A0
		[Token(Token = "0x600B64C")]
		[Address(RVA = "0x2301618", Offset = "0x2301618", VA = "0x7BBCB01618")]
		private bool IsTeamEliminated({QAb\u0082~u player)
		{
			return default(bool);
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B64D")]
		[Address(RVA = "0x2301724", Offset = "0x2301724", VA = "0x7BBCB01724")]
		public void LogReplayEvent(\u0081fXogCG evt, {QAb\u0082~u id, float time = 0f, float fparam = 0f, string sparam = "")
		{
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B64E")]
		[Address(RVA = "0x2301A88", Offset = "0x2301A88", VA = "0x7BBCB01A88")]
		public List<ReplayEvent> GetReplayEvents()
		{
			return null;
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x00033EB8 File Offset: 0x000320B8
		[Token(Token = "0x600B64F")]
		[Address(RVA = "0x2301A90", Offset = "0x2301A90", VA = "0x7BBCB01A90")]
		private Color GetCurrentTeamColor(byte id)
		{
			return default(Color);
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B650")]
		[Address(RVA = "0x22F8700", Offset = "0x22F8700", VA = "0x7BBCAF8700")]
		private void SortRankingTeamListByLiving()
		{
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B651")]
		[Address(RVA = "0x22F8828", Offset = "0x22F8828", VA = "0x7BBCAF8828")]
		private void SortRankingTeamListByCombatLevel()
		{
		}

		// Token: 0x0600B652 RID: 46674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B652")]
		[Address(RVA = "0x2301B00", Offset = "0x2301B00", VA = "0x7BBCB01B00")]
		private void CalculateTeamScore()
		{
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B653")]
		[Address(RVA = "0x2301D3C", Offset = "0x2301D3C", VA = "0x7BBCB01D3C")]
		public string GerenateMatchInfo()
		{
			return null;
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x00033ED0 File Offset: 0x000320D0
		[Token(Token = "0x600B654")]
		[Address(RVA = "0x2302238", Offset = "0x2302238", VA = "0x7BBCB02238")]
		public bool LoadDirectoryBGImage(UITexture bgTexture)
		{
			return default(bool);
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x00033EE8 File Offset: 0x000320E8
		[Token(Token = "0x600B655")]
		[Address(RVA = "0x2302294", Offset = "0x2302294", VA = "0x7BBCB02294")]
		public bool LoadPCTextures(UITexture texture, string dirName, string picName)
		{
			return default(bool);
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B656")]
		[Address(RVA = "0x23024A8", Offset = "0x23024A8", VA = "0x7BBCB024A8")]
		public void SetInputBlockValue(uint flag, bool val)
		{
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x00033F00 File Offset: 0x00032100
		[Token(Token = "0x600B657")]
		[Address(RVA = "0x23024F0", Offset = "0x23024F0", VA = "0x7BBCB024F0")]
		public bool IsInputBlock()
		{
			return default(bool);
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B658")]
		[Address(RVA = "0x2302520", Offset = "0x2302520", VA = "0x7BBCB02520")]
		public UIModelSpectator()
		{
		}

		// Token: 0x0600B659 RID: 46681 RVA: 0x00033F18 File Offset: 0x00032118
		[Token(Token = "0x600B659")]
		[Address(RVA = "0x2302808", Offset = "0x2302808", VA = "0x7BBCB02808")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11475BC", Offset = "0x11475BC")]
		private int <SortTeams>b__75_0(TeamData a, TeamData b)
		{
			return 0;
		}

		// Token: 0x0400B84D RID: 47181
		[Token(Token = "0x400B84D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113070C", Offset = "0x113070C")]
		private UIModelSpectator.InfoTab <CurrentInfoTab>k__BackingField;

		// Token: 0x0400B84E RID: 47182
		[Token(Token = "0x400B84E")]
		[FieldOffset(Offset = "0x20")]
		private List<byte> m_TeamList;

		// Token: 0x0400B84F RID: 47183
		[Token(Token = "0x400B84F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

		// Token: 0x0400B850 RID: 47184
		[Token(Token = "0x400B850")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<{QAb\u0082~u, PlayerData> m_PlayerDic;

		// Token: 0x0400B851 RID: 47185
		[Token(Token = "0x400B851")]
		[FieldOffset(Offset = "0x38")]
		private List<TeamData> m_TeamDataList;

		// Token: 0x0400B852 RID: 47186
		[Token(Token = "0x400B852")]
		[FieldOffset(Offset = "0x40")]
		private List<RankingTeamData> m_RankingTeamDataList;

		// Token: 0x0400B853 RID: 47187
		[Token(Token = "0x400B853")]
		[FieldOffset(Offset = "0x48")]
		private List<AccTeamData> m_AccTeamDataList;

		// Token: 0x0400B854 RID: 47188
		[Token(Token = "0x400B854")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, UIModelSpectator.TeamWinInfo> m_RoundResult;

		// Token: 0x0400B855 RID: 47189
		[Token(Token = "0x400B855")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<{QAb\u0082~u, List<PlayerKillInfo>> m_PlayerKillInfoList;

		// Token: 0x0400B856 RID: 47190
		[Token(Token = "0x400B856")]
		public const uint PropID_PlayerAdded = 2U;

		// Token: 0x0400B857 RID: 47191
		[Token(Token = "0x400B857")]
		public const uint PropID_AirDropChanged = 4U;

		// Token: 0x0400B858 RID: 47192
		[Token(Token = "0x400B858")]
		public const uint PropID_PlayerDeleted = 8U;

		// Token: 0x0400B859 RID: 47193
		[Token(Token = "0x400B859")]
		public const uint PropID_PlayerKillCountChanged = 16U;

		// Token: 0x0400B85A RID: 47194
		[Token(Token = "0x400B85A")]
		public const uint PropID_PlayerRemainingCountChanged = 32U;

		// Token: 0x0400B85B RID: 47195
		[Token(Token = "0x400B85B")]
		public const uint PropID_SpectatorRejoin = 128U;

		// Token: 0x0400B85C RID: 47196
		[Token(Token = "0x400B85C")]
		public const uint PropID_SafeZoneChanged = 256U;

		// Token: 0x0400B85D RID: 47197
		[Token(Token = "0x400B85D")]
		public const uint PropID_TeamAce = 512U;

		// Token: 0x0400B85E RID: 47198
		[Token(Token = "0x400B85E")]
		public const uint PropID_GameAchievement = 1024U;

		// Token: 0x0400B85F RID: 47199
		[Token(Token = "0x400B85F")]
		public const uint PropID_ScoreChanged = 2048U;

		// Token: 0x0400B860 RID: 47200
		[Token(Token = "0x400B860")]
		public const uint PropID_PlayerRankGet = 4096U;

		// Token: 0x0400B861 RID: 47201
		[Token(Token = "0x400B861")]
		public const uint PropID_CombatLevelUpdated = 8192U;

		// Token: 0x0400B862 RID: 47202
		[Token(Token = "0x400B862")]
		public const uint PropID_PlayerDeadCountChanged = 16384U;

		// Token: 0x0400B863 RID: 47203
		[Token(Token = "0x400B863")]
		public const uint PropID_PlayerAssistCountChanged = 32768U;

		// Token: 0x0400B864 RID: 47204
		[Token(Token = "0x400B864")]
		public const uint PropID_LiveCountChanged = 65536U;

		// Token: 0x0400B865 RID: 47205
		[Token(Token = "0x400B865")]
		[FieldOffset(Offset = "0x60")]
		public bool HasPlayerDead;

		// Token: 0x0400B866 RID: 47206
		[Token(Token = "0x400B866")]
		[FieldOffset(Offset = "0x68")]
		public List<Transform> ResultShowPositionList;

		// Token: 0x0400B867 RID: 47207
		[Token(Token = "0x400B867")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<uint, AirdropInfo> m_Airdrops;

		// Token: 0x0400B868 RID: 47208
		[Token(Token = "0x400B868")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<uint, Vector3> m_AirdopsPos;

		// Token: 0x0400B869 RID: 47209
		[Token(Token = "0x400B869")]
		[FieldOffset(Offset = "0x80")]
		public List<AirdropInfo> m_AirDropsList;

		// Token: 0x0400B86A RID: 47210
		[Token(Token = "0x400B86A")]
		[FieldOffset(Offset = "0x88")]
		private List<PlayerData> m_DeadOrderList;

		// Token: 0x0400B86B RID: 47211
		[Token(Token = "0x400B86B")]
		[FieldOffset(Offset = "0x90")]
		private List<ResultTeamData> m_MatchResult;

		// Token: 0x0400B86C RID: 47212
		[Token(Token = "0x400B86C")]
		[FieldOffset(Offset = "0x98")]
		private ResultMVPInfo m_MVPInfo;

		// Token: 0x0400B86D RID: 47213
		[Token(Token = "0x400B86D")]
		[FieldOffset(Offset = "0xA0")]
		private int m_RemainingPlayerCount;

		// Token: 0x0400B86E RID: 47214
		[Token(Token = "0x400B86E")]
		[FieldOffset(Offset = "0xA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113071C", Offset = "0x113071C")]
		private bool <GroupIconEnabled>k__BackingField;

		// Token: 0x0400B86F RID: 47215
		[Token(Token = "0x400B86F")]
		[FieldOffset(Offset = "0xA8")]
		private {QAb\u0082~u m_currentKillLeaderPlayerID;

		// Token: 0x0400B870 RID: 47216
		[Token(Token = "0x400B870")]
		[FieldOffset(Offset = "0xC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113072C", Offset = "0x113072C")]
		private {QAb\u0082~u <CurrentKillLeaderPlayerID>k__BackingField;

		// Token: 0x0400B871 RID: 47217
		[Token(Token = "0x400B871")]
		[FieldOffset(Offset = "0xD8")]
		public float UI_PLAYER_ITEM_HEIGHT;

		// Token: 0x0400B872 RID: 47218
		[Token(Token = "0x400B872")]
		[FieldOffset(Offset = "0xDC")]
		private float m_BattleCheckedTime;

		// Token: 0x0400B873 RID: 47219
		[Token(Token = "0x400B873")]
		[FieldOffset(Offset = "0xE0")]
		private HashSet<byte> m_InBattleTeams;

		// Token: 0x0400B874 RID: 47220
		[Token(Token = "0x400B874")]
		[FieldOffset(Offset = "0xE8")]
		private List<ReplayEvent> m_ReplayEventList;

		// Token: 0x0400B875 RID: 47221
		[Token(Token = "0x400B875")]
		[FieldOffset(Offset = "0xF0")]
		private BitArrayBoolean m_InputBlock;

		// Token: 0x0400B876 RID: 47222
		[Token(Token = "0x400B876")]
		public const uint INPUT_BLCOK_VIDEO_UI_FOUCUSED = 1U;

		// Token: 0x02001FFA RID: 8186
		[Token(Token = "0x2001FFA")]
		public enum InfoTab
		{
			// Token: 0x0400B878 RID: 47224
			[Token(Token = "0x400B878")]
			Player,
			// Token: 0x0400B879 RID: 47225
			[Token(Token = "0x400B879")]
			AirDrop
		}

		// Token: 0x02001FFB RID: 8187
		[Token(Token = "0x2001FFB")]
		public class TeamWinInfo
		{
			// Token: 0x0600B65A RID: 46682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B65A")]
			[Address(RVA = "0x22F8A70", Offset = "0x22F8A70", VA = "0x7BBCAF8A70")]
			public TeamWinInfo(byte teamID, byte winReason)
			{
			}

			// Token: 0x0400B87A RID: 47226
			[Token(Token = "0x400B87A")]
			[FieldOffset(Offset = "0x10")]
			public byte teamID;

			// Token: 0x0400B87B RID: 47227
			[Token(Token = "0x400B87B")]
			[FieldOffset(Offset = "0x11")]
			public byte winReason;
		}

		// Token: 0x02001FFC RID: 8188
		[Token(Token = "0x2001FFC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD6D4", Offset = "0x10FD6D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B65C RID: 46684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B65C")]
			[Address(RVA = "0x23028F8", Offset = "0x23028F8", VA = "0x7BBCB028F8")]
			public <>c()
			{
			}

			// Token: 0x0600B65D RID: 46685 RVA: 0x00033F30 File Offset: 0x00032130
			[Token(Token = "0x600B65D")]
			[Address(RVA = "0x2302900", Offset = "0x2302900", VA = "0x7BBCB02900")]
			internal int <OnAddPlayer>b__72_0(PlayerData a, PlayerData b)
			{
				return 0;
			}

			// Token: 0x0600B65E RID: 46686 RVA: 0x00033F48 File Offset: 0x00032148
			[Token(Token = "0x600B65E")]
			[Address(RVA = "0x2302948", Offset = "0x2302948", VA = "0x7BBCB02948")]
			internal byte <SortTeams>b__75_1(TeamData a)
			{
				return 0;
			}

			// Token: 0x0600B65F RID: 46687 RVA: 0x00033F60 File Offset: 0x00032160
			[Token(Token = "0x600B65F")]
			[Address(RVA = "0x2302974", Offset = "0x2302974", VA = "0x7BBCB02974")]
			internal int <OnAddRejoinDeadPlayer>b__98_0(PlayerData a, PlayerData b)
			{
				return 0;
			}

			// Token: 0x0600B660 RID: 46688 RVA: 0x00033F78 File Offset: 0x00032178
			[Token(Token = "0x600B660")]
			[Address(RVA = "0x23029BC", Offset = "0x23029BC", VA = "0x7BBCB029BC")]
			internal int <GenerateSpectatorMatchResult>b__109_0(ResultTeamData a, ResultTeamData b)
			{
				return 0;
			}

			// Token: 0x0600B661 RID: 46689 RVA: 0x00033F90 File Offset: 0x00032190
			[Token(Token = "0x600B661")]
			[Address(RVA = "0x2302A04", Offset = "0x2302A04", VA = "0x7BBCB02A04")]
			internal int <OnTeamScoreChanged>b__117_0(AccTeamData a, AccTeamData b)
			{
				return 0;
			}

			// Token: 0x0600B662 RID: 46690 RVA: 0x00033FA8 File Offset: 0x000321A8
			[Token(Token = "0x600B662")]
			[Address(RVA = "0x2302A4C", Offset = "0x2302A4C", VA = "0x7BBCB02A4C")]
			internal int <SortRankingTeamListByLiving>b__132_0(RankingTeamData a, RankingTeamData b)
			{
				return 0;
			}

			// Token: 0x0600B663 RID: 46691 RVA: 0x00033FC0 File Offset: 0x000321C0
			[Token(Token = "0x600B663")]
			[Address(RVA = "0x2302AE0", Offset = "0x2302AE0", VA = "0x7BBCB02AE0")]
			internal int <SortRankingTeamListByCombatLevel>b__133_0(RankingTeamData a, RankingTeamData b)
			{
				return 0;
			}

			// Token: 0x0400B87C RID: 47228
			[Token(Token = "0x400B87C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelSpectator.<>c <>9;

			// Token: 0x0400B87D RID: 47229
			[Token(Token = "0x400B87D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<PlayerData> <>9__72_0;

			// Token: 0x0400B87E RID: 47230
			[Token(Token = "0x400B87E")]
			[FieldOffset(Offset = "0x10")]
			public static Func<TeamData, byte> <>9__75_1;

			// Token: 0x0400B87F RID: 47231
			[Token(Token = "0x400B87F")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<PlayerData> <>9__98_0;

			// Token: 0x0400B880 RID: 47232
			[Token(Token = "0x400B880")]
			[FieldOffset(Offset = "0x20")]
			public static Comparison<ResultTeamData> <>9__109_0;

			// Token: 0x0400B881 RID: 47233
			[Token(Token = "0x400B881")]
			[FieldOffset(Offset = "0x28")]
			public static Comparison<AccTeamData> <>9__117_0;

			// Token: 0x0400B882 RID: 47234
			[Token(Token = "0x400B882")]
			[FieldOffset(Offset = "0x30")]
			public static Comparison<RankingTeamData> <>9__132_0;

			// Token: 0x0400B883 RID: 47235
			[Token(Token = "0x400B883")]
			[FieldOffset(Offset = "0x38")]
			public static Comparison<RankingTeamData> <>9__133_0;
		}

		// Token: 0x02001FFD RID: 8189
		[Token(Token = "0x2001FFD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD6E4", Offset = "0x10FD6E4")]
		private sealed class <>c__DisplayClass96_0
		{
			// Token: 0x0600B664 RID: 46692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B664")]
			[Address(RVA = "0x22FBFFC", Offset = "0x22FBFFC", VA = "0x7BBCAFBFFC")]
			public <>c__DisplayClass96_0()
			{
			}

			// Token: 0x0600B665 RID: 46693 RVA: 0x00033FD8 File Offset: 0x000321D8
			[Token(Token = "0x600B665")]
			[Address(RVA = "0x2302DF8", Offset = "0x2302DF8", VA = "0x7BBCB02DF8")]
			internal bool <GetTeamKillCount>b__0(RankingTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B884 RID: 47236
			[Token(Token = "0x400B884")]
			[FieldOffset(Offset = "0x10")]
			public PlayerData data;
		}

		// Token: 0x02001FFE RID: 8190
		[Token(Token = "0x2001FFE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD6F4", Offset = "0x10FD6F4")]
		private sealed class <>c__DisplayClass111_0
		{
			// Token: 0x0600B666 RID: 46694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B666")]
			[Address(RVA = "0x22FF13C", Offset = "0x22FF13C", VA = "0x7BBCAFF13C")]
			public <>c__DisplayClass111_0()
			{
			}

			// Token: 0x0600B667 RID: 46695 RVA: 0x00033FF0 File Offset: 0x000321F0
			[Token(Token = "0x600B667")]
			[Address(RVA = "0x2302B88", Offset = "0x2302B88", VA = "0x7BBCB02B88")]
			internal bool <GenerateResult>b__0(ResultTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B885 RID: 47237
			[Token(Token = "0x400B885")]
			[FieldOffset(Offset = "0x10")]
			public PlayerData data;
		}

		// Token: 0x02001FFF RID: 8191
		[Token(Token = "0x2001FFF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD704", Offset = "0x10FD704")]
		private sealed class <>c__DisplayClass113_0
		{
			// Token: 0x0600B668 RID: 46696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B668")]
			[Address(RVA = "0x22FF14C", Offset = "0x22FF14C", VA = "0x7BBCAFF14C")]
			public <>c__DisplayClass113_0()
			{
			}

			// Token: 0x0600B669 RID: 46697 RVA: 0x00034008 File Offset: 0x00032208
			[Token(Token = "0x600B669")]
			[Address(RVA = "0x2302BD4", Offset = "0x2302BD4", VA = "0x7BBCB02BD4")]
			internal bool <GenerateTeamWinNum>b__0(ResultTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B886 RID: 47238
			[Token(Token = "0x400B886")]
			[FieldOffset(Offset = "0x10")]
			public int i;

			// Token: 0x0400B887 RID: 47239
			[Token(Token = "0x400B887")]
			[FieldOffset(Offset = "0x18")]
			public UIModelSpectator <>4__this;
		}

		// Token: 0x02002000 RID: 8192
		[Token(Token = "0x2002000")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD714", Offset = "0x10FD714")]
		private sealed class <>c__DisplayClass116_0
		{
			// Token: 0x0600B66A RID: 46698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66A")]
			[Address(RVA = "0x22FF5F0", Offset = "0x22FF5F0", VA = "0x7BBCAFF5F0")]
			public <>c__DisplayClass116_0()
			{
			}

			// Token: 0x0600B66B RID: 46699 RVA: 0x00034020 File Offset: 0x00032220
			[Token(Token = "0x600B66B")]
			[Address(RVA = "0x2302C84", Offset = "0x2302C84", VA = "0x7BBCB02C84")]
			internal bool <OnTeamScoreInited>b__0(RankingTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B888 RID: 47240
			[Token(Token = "0x400B888")]
			[FieldOffset(Offset = "0x10")]
			public AccTeamData data;
		}

		// Token: 0x02002001 RID: 8193
		[Token(Token = "0x2002001")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD724", Offset = "0x10FD724")]
		private sealed class <>c__DisplayClass117_0
		{
			// Token: 0x0600B66C RID: 46700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66C")]
			[Address(RVA = "0x22FFAF8", Offset = "0x22FFAF8", VA = "0x7BBCAFFAF8")]
			public <>c__DisplayClass117_0()
			{
			}

			// Token: 0x0600B66D RID: 46701 RVA: 0x00034038 File Offset: 0x00032238
			[Token(Token = "0x600B66D")]
			[Address(RVA = "0x2302CD0", Offset = "0x2302CD0", VA = "0x7BBCB02CD0")]
			internal bool <OnTeamScoreChanged>b__1(AccTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B889 RID: 47241
			[Token(Token = "0x400B889")]
			[FieldOffset(Offset = "0x10")]
			public lu\u0082yiKu team;
		}

		// Token: 0x02002002 RID: 8194
		[Token(Token = "0x2002002")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD734", Offset = "0x10FD734")]
		private sealed class <>c__DisplayClass119_0
		{
			// Token: 0x0600B66E RID: 46702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B66E")]
			[Address(RVA = "0x23001E0", Offset = "0x23001E0", VA = "0x7BBCB001E0")]
			public <>c__DisplayClass119_0()
			{
			}

			// Token: 0x0600B66F RID: 46703 RVA: 0x00034050 File Offset: 0x00032250
			[Token(Token = "0x600B66F")]
			[Address(RVA = "0x2302D1C", Offset = "0x2302D1C", VA = "0x7BBCB02D1C")]
			internal bool <UpdateCombatLevelInfo>b__0(TeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B88A RID: 47242
			[Token(Token = "0x400B88A")]
			[FieldOffset(Offset = "0x10")]
			public ~QWuCsB teams;
		}

		// Token: 0x02002003 RID: 8195
		[Token(Token = "0x2002003")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD744", Offset = "0x10FD744")]
		private sealed class <>c__DisplayClass119_1
		{
			// Token: 0x0600B670 RID: 46704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B670")]
			[Address(RVA = "0x23001E8", Offset = "0x23001E8", VA = "0x7BBCB001E8")]
			public <>c__DisplayClass119_1()
			{
			}

			// Token: 0x0600B671 RID: 46705 RVA: 0x00034068 File Offset: 0x00032268
			[Token(Token = "0x600B671")]
			[Address(RVA = "0x2302D68", Offset = "0x2302D68", VA = "0x7BBCB02D68")]
			internal bool <UpdateCombatLevelInfo>b__1(RankingTeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B88B RID: 47243
			[Token(Token = "0x400B88B")]
			[FieldOffset(Offset = "0x10")]
			public TeamData team;
		}

		// Token: 0x02002004 RID: 8196
		[Token(Token = "0x2002004")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD754", Offset = "0x10FD754")]
		private sealed class <>c__DisplayClass127_0
		{
			// Token: 0x0600B672 RID: 46706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B672")]
			[Address(RVA = "0x230171C", Offset = "0x230171C", VA = "0x7BBCB0171C")]
			public <>c__DisplayClass127_0()
			{
			}

			// Token: 0x0600B673 RID: 46707 RVA: 0x00034080 File Offset: 0x00032280
			[Token(Token = "0x600B673")]
			[Address(RVA = "0x2302DB4", Offset = "0x2302DB4", VA = "0x7BBCB02DB4")]
			internal bool <IsTeamEliminated>b__0(TeamData a)
			{
				return default(bool);
			}

			// Token: 0x0400B88C RID: 47244
			[Token(Token = "0x400B88C")]
			[FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u player;
		}
	}
}
