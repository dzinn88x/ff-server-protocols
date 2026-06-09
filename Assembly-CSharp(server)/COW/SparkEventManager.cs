using System;
using System.Collections.Generic;
using COW.GamePlay;
using Il2CppDummyDll;
using proto;
using YouMe;

namespace COW
{
	// Token: 0x0200131E RID: 4894
	[Token(Token = "0x200131E")]
	public class SparkEventManager
	{
		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x06004D7D RID: 19837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000860")]
		public static SparkEventManager instance
		{
			[Token(Token = "0x6004D7D")]
			[Address(RVA = "0x1B3BC28", Offset = "0x1B3BC28", VA = "0x7BBC33BC28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x00017778 File Offset: 0x00015978
		[Token(Token = "0x17000861")]
		public static bool IsEnabled
		{
			[Token(Token = "0x6004D7E")]
			[Address(RVA = "0x1B3BD80", Offset = "0x1B3BD80", VA = "0x7BBC33BD80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06004D7F RID: 19839 RVA: 0x00017790 File Offset: 0x00015990
		// (set) Token: 0x06004D80 RID: 19840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000862")]
		public bool IsConnectedMTV
		{
			[Token(Token = "0x6004D7F")]
			[Address(RVA = "0x1B3BE80", Offset = "0x1B3BE80", VA = "0x7BBC33BE80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE48", Offset = "0x113DE48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D80")]
			[Address(RVA = "0x1B3BE88", Offset = "0x1B3BE88", VA = "0x7BBC33BE88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE58", Offset = "0x113DE58")]
			private set
			{
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06004D81 RID: 19841 RVA: 0x000177A8 File Offset: 0x000159A8
		// (set) Token: 0x06004D82 RID: 19842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000863")]
		public bool IsMicInMTV
		{
			[Token(Token = "0x6004D81")]
			[Address(RVA = "0x1B3BE94", Offset = "0x1B3BE94", VA = "0x7BBC33BE94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE68", Offset = "0x113DE68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D82")]
			[Address(RVA = "0x1B3BE9C", Offset = "0x1B3BE9C", VA = "0x7BBC33BE9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE78", Offset = "0x113DE78")]
			private set
			{
			}
		}

		// Token: 0x06004D83 RID: 19843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D83")]
		[Address(RVA = "0x1B3BEA8", Offset = "0x1B3BEA8", VA = "0x7BBC33BEA8")]
		public void Init()
		{
		}

		// Token: 0x06004D84 RID: 19844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D84")]
		[Address(RVA = "0x1B3C3F8", Offset = "0x1B3C3F8", VA = "0x7BBC33C3F8")]
		public void OnLogin(ulong account_id)
		{
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D85")]
		[Address(RVA = "0x1B3C338", Offset = "0x1B3C338", VA = "0x7BBC33C338")]
		private void StartVoiceDataSender()
		{
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D86")]
		[Address(RVA = "0x1B3C730", Offset = "0x1B3C730", VA = "0x7BBC33C730")]
		private void StopVoiceDataSender()
		{
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D87")]
		[Address(RVA = "0x1B3C7F0", Offset = "0x1B3C7F0", VA = "0x7BBC33C7F0")]
		public void OnSceneLoaded()
		{
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D88")]
		[Address(RVA = "0x1B3C850", Offset = "0x1B3C850", VA = "0x7BBC33C850")]
		private void OnConnectedChanged(bool is_connected)
		{
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D89")]
		[Address(RVA = "0x1B3CB2C", Offset = "0x1B3CB2C", VA = "0x7BBC33CB2C")]
		private void OnMicFocusChanged(bool is_focused)
		{
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x1B3CB38", Offset = "0x1B3CB38", VA = "0x7BBC33CB38")]
		public void RequestReleaseMic()
		{
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x1B3CBB0", Offset = "0x1B3CBB0", VA = "0x7BBC33CBB0")]
		public void RequestResumeMic()
		{
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x1B3CC28", Offset = "0x1B3CC28", VA = "0x7BBC33CC28")]
		public void OnYouMeVoiceCaptureStart()
		{
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x1B3CC88", Offset = "0x1B3CC88", VA = "0x7BBC33CC88")]
		public void OnYouMeVoiceCaptureStop()
		{
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x1B3CCE8", Offset = "0x1B3CCE8", VA = "0x7BBC33CCE8")]
		public void OnYouMeVoiceCaptured(YouMeVoiceAPI.YoumePcmCallbackData data)
		{
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D8F")]
		[Address(RVA = "0x1B3C4BC", Offset = "0x1B3C4BC", VA = "0x7BBC33C4BC")]
		public void ClearEventCountCache()
		{
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D90")]
		[Address(RVA = "0x1B3CD98", Offset = "0x1B3CD98", VA = "0x7BBC33CD98")]
		private void PushEvent(SparkEventData_Base data)
		{
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D91")]
		[Address(RVA = "0x1B3C51C", Offset = "0x1B3C51C", VA = "0x7BBC33C51C")]
		public void RecordEnterLobby()
		{
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D92")]
		[Address(RVA = "0x1B3D000", Offset = "0x1B3D000", VA = "0x7BBC33D000")]
		public void RecordGameStart()
		{
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D93")]
		[Address(RVA = "0x1B3D164", Offset = "0x1B3D164", VA = "0x7BBC33D164")]
		public void RecordGameEnd(MatchStats _match_stats)
		{
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D94")]
		[Address(RVA = "0x1B3D244", Offset = "0x1B3D244", VA = "0x7BBC33D244")]
		public void RecordPlaneJump()
		{
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D95")]
		[Address(RVA = "0x1B3D324", Offset = "0x1B3D324", VA = "0x7BBC33D324")]
		public void RecordLanding()
		{
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x1B3D404", Offset = "0x1B3D404", VA = "0x7BBC33D404")]
		public void RecordDamageEnemy(ulong _account_id, int _damge_dealt, int _weapon_id)
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x1B3D554", Offset = "0x1B3D554", VA = "0x7BBC33D554")]
		public void RecordDamgeTaken({QAb\u0082~u _damager, int _damage_taken, int _remaining_hp, int _weapon_id)
		{
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x1B3D76C", Offset = "0x1B3D76C", VA = "0x7BBC33D76C")]
		public void RecordKill({QAb\u0082~u _player_id, int _weapon_id, int _kill_count)
		{
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x1B3D96C", Offset = "0x1B3D96C", VA = "0x7BBC33D96C")]
		public void RecordLocalPlayerDeath({QAb\u0082~u killer_id, int _weapon_id)
		{
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9A")]
		[Address(RVA = "0x1B3DA74", Offset = "0x1B3DA74", VA = "0x7BBC33DA74")]
		public void RecordKnockDown({QAb\u0082~u killer_id, {QAb\u0082~u knocked_down_id, int _weapon_id)
		{
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0x1B3DE58", Offset = "0x1B3DE58", VA = "0x7BBC33DE58")]
		public void RecordRevive({QAb\u0082~u revive_id, {QAb\u0082~u revived_id)
		{
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x1B3E21C", Offset = "0x1B3E21C", VA = "0x7BBC33E21C")]
		public void RecordPickUpItem(uint _item_id, uint _skin_id)
		{
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x1B3E338", Offset = "0x1B3E338", VA = "0x7BBC33E338")]
		public void RecordLootContainer(byte type, List<^yE\u007FRJO> pick_up_list)
		{
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x1B3E55C", Offset = "0x1B3E55C", VA = "0x7BBC33E55C")]
		private void RecordLootAirDrop(uint[] _item_ids)
		{
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0x1B3E65C", Offset = "0x1B3E65C", VA = "0x7BBC33E65C")]
		private void RecordLootPlayer(uint[] _item_ids)
		{
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x1B3E75C", Offset = "0x1B3E75C", VA = "0x7BBC33E75C")]
		public void RecordUAVExpose(object list_data, {QAb\u0082~u ownerID)
		{
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0x1B3EB98", Offset = "0x1B3EB98", VA = "0x7BBC33EB98")]
		public void RecordUseItem(uint _item_id)
		{
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x1B3EC98", Offset = "0x1B3EC98", VA = "0x7BBC33EC98")]
		public void RecordEnterVehicle(int _vehicle_id, int _vehicle_hp)
		{
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x1B3EDB4", Offset = "0x1B3EDB4", VA = "0x7BBC33EDB4")]
		public void RecordExitVehicle(int _vehicle_id, int _vehicle_hp)
		{
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x1B3EED0", Offset = "0x1B3EED0", VA = "0x7BBC33EED0")]
		public void RecordBattlePassLevel(uint _pass_lvl, bool _is_elite)
		{
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x1B3EFF0", Offset = "0x1B3EFF0", VA = "0x7BBC33EFF0")]
		public void RecordSurviorCount(int _survior_count)
		{
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x1B3BCE8", Offset = "0x1B3BCE8", VA = "0x7BBC33BCE8")]
		public SparkEventManager()
		{
		}

		// Token: 0x04007524 RID: 29988
		[Token(Token = "0x4007524")]
		[FieldOffset(Offset = "0x0")]
		private static SparkEventManager _instance;

		// Token: 0x04007525 RID: 29989
		[Token(Token = "0x4007525")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, SparkEventConfigData> m_EventConfig;

		// Token: 0x04007526 RID: 29990
		[Token(Token = "0x4007526")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> m_EventCountCache;

		// Token: 0x04007527 RID: 29991
		[Token(Token = "0x4007527")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F70C", Offset = "0x112F70C")]
		private bool <IsConnectedMTV>k__BackingField;

		// Token: 0x04007528 RID: 29992
		[Token(Token = "0x4007528")]
		[FieldOffset(Offset = "0x21")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F71C", Offset = "0x112F71C")]
		private bool <IsMicInMTV>k__BackingField;
	}
}
