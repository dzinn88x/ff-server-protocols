using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x0200269E RID: 9886
	[Token(Token = "0x200269E")]
	internal class MultiplePlayerWereWolvesGame : XNfAVOH
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB4")]
		public List<MultiplePlayerWereWolvesGame.WereWolvesChatEasyListInfo> ChatInfos
		{
			[Token(Token = "0x600CCBE")]
			[Address(RVA = "0x1B7DBC0", Offset = "0x1B7DBC0", VA = "0x7BBC37DBC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB5")]
		public WereWolvesBodyManager BodyManager
		{
			[Token(Token = "0x600CCBF")]
			[Address(RVA = "0x1B7DBC8", Offset = "0x1B7DBC8", VA = "0x7BBC37DBC8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCC0")]
		[Address(RVA = "0x1B7DBD0", Offset = "0x1B7DBD0", VA = "0x7BBC37DBD0")]
		public <<EMPTY_NAME>> GetTaskManager()
		{
			return null;
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCC1")]
		[Address(RVA = "0x1B7DBD8", Offset = "0x1B7DBD8", VA = "0x7BBC37DBD8")]
		public cmqSIKS GetVoteManager()
		{
			return null;
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB6")]
		public Dictionary<string, WereWolvesRoleData> RoleDatas
		{
			[Token(Token = "0x600CCC2")]
			[Address(RVA = "0x1B7DBE0", Offset = "0x1B7DBE0", VA = "0x7BBC37DBE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x0600CCC3 RID: 52419 RVA: 0x00036E40 File Offset: 0x00035040
		[Token(Token = "0x17000DB7")]
		public M\u0081 GameOverFlag
		{
			[Token(Token = "0x600CCC3")]
			[Address(RVA = "0x1B7DBE8", Offset = "0x1B7DBE8", VA = "0x7BBC37DBE8")]
			get
			{
				return M\u0081.EWereWolvesGameOverState_NoOver;
			}
		}

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCC4")]
		[Address(RVA = "0x1B7DC4C", Offset = "0x1B7DC4C", VA = "0x7BBC37DC4C", Slot = "18")]
		public override Type GetUISceneType()
		{
			return null;
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x0600CCC5 RID: 52421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB8")]
		public List<WereWolvesQuickChatData> QuickChatList
		{
			[Token(Token = "0x600CCC5")]
			[Address(RVA = "0x1B7DCBC", Offset = "0x1B7DCBC", VA = "0x7BBC37DCBC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x0600CCC6 RID: 52422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DB9")]
		public List<WereWolvesQuickChatData> QuickChatNoTargetList
		{
			[Token(Token = "0x600CCC6")]
			[Address(RVA = "0x1B7DCC4", Offset = "0x1B7DCC4", VA = "0x7BBC37DCC4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x0600CCC7 RID: 52423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBA")]
		public List<WereWolvesQuickChatData> QuickChatTargetList
		{
			[Token(Token = "0x600CCC7")]
			[Address(RVA = "0x1B7DCCC", Offset = "0x1B7DCCC", VA = "0x7BBC37DCCC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x0600CCC8 RID: 52424 RVA: 0x00036E58 File Offset: 0x00035058
		[Token(Token = "0x17000DBB")]
		public bool InChatCD
		{
			[Token(Token = "0x600CCC8")]
			[Address(RVA = "0x1B7DCD4", Offset = "0x1B7DCD4", VA = "0x7BBC37DCD4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (set) Token: 0x0600CCC9 RID: 52425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000DBC")]
		public bool SavedMicState
		{
			[Token(Token = "0x600CCC9")]
			[Address(RVA = "0x1B7DD9C", Offset = "0x1B7DD9C", VA = "0x7BBC37DD9C")]
			set
			{
			}
		}

		// Token: 0x0600CCCA RID: 52426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCA")]
		[Address(RVA = "0x1B7DDA8", Offset = "0x1B7DDA8", VA = "0x7BBC37DDA8", Slot = "8")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600CCCB RID: 52427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCB")]
		[Address(RVA = "0x1B7E430", Offset = "0x1B7E430", VA = "0x7BBC37E430", Slot = "47")]
		public override void OnAddPlayer(Player p)
		{
		}

		// Token: 0x0600CCCC RID: 52428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCC")]
		[Address(RVA = "0x1B7E59C", Offset = "0x1B7E59C", VA = "0x7BBC37E59C")]
		private void ChooseLocalPlayerPrepareCameraPivot(Vector3 playerForward)
		{
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCD")]
		[Address(RVA = "0x1B7E8EC", Offset = "0x1B7E8EC", VA = "0x7BBC37E8EC")]
		private void SpawnLocalPlayerCircleEffect(Transform playerTrans)
		{
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCCE")]
		[Address(RVA = "0x1B7E288", Offset = "0x1B7E288", VA = "0x7BBC37E288")]
		private void InitRoleData()
		{
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x00036E70 File Offset: 0x00035070
		[Token(Token = "0x600CCCF")]
		[Address(RVA = "0x1B7EAF8", Offset = "0x1B7EAF8", VA = "0x7BBC37EAF8")]
		public uint GetCurrentWolfCount()
		{
			return 0U;
		}

		// Token: 0x0600CCD0 RID: 52432 RVA: 0x00036E88 File Offset: 0x00035088
		[Token(Token = "0x600CCD0")]
		[Address(RVA = "0x1B7EB5C", Offset = "0x1B7EB5C", VA = "0x7BBC37EB5C")]
		public uint GetAllWolfCount()
		{
			return 0U;
		}

		// Token: 0x0600CCD1 RID: 52433 RVA: 0x00036EA0 File Offset: 0x000350A0
		[Token(Token = "0x600CCD1")]
		[Address(RVA = "0x1B7EBC0", Offset = "0x1B7EBC0", VA = "0x7BBC37EBC0")]
		public uint GetCurrentPoint()
		{
			return 0U;
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x00036EB8 File Offset: 0x000350B8
		[Token(Token = "0x600CCD2")]
		[Address(RVA = "0x1B7EC24", Offset = "0x1B7EC24", VA = "0x7BBC37EC24")]
		public uint GetCivilWinPoint()
		{
			return 0U;
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x00036ED0 File Offset: 0x000350D0
		[Token(Token = "0x600CCD3")]
		[Address(RVA = "0x1B7EC88", Offset = "0x1B7EC88", VA = "0x7BBC37EC88")]
		public int GetVoteCenterCDEndTimeMs()
		{
			return 0;
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x00036EE8 File Offset: 0x000350E8
		[Token(Token = "0x600CCD4")]
		[Address(RVA = "0x1B7ECEC", Offset = "0x1B7ECEC", VA = "0x7BBC37ECEC")]
		public int GetGameEndTimeMs()
		{
			return 0;
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x00036F00 File Offset: 0x00035100
		[Token(Token = "0x600CCD5")]
		[Address(RVA = "0x1B7ED50", Offset = "0x1B7ED50", VA = "0x7BBC37ED50")]
		public uint GetCurrentPhase()
		{
			return 0U;
		}

		// Token: 0x0600CCD6 RID: 52438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD6")]
		[Address(RVA = "0x1B7EDBC", Offset = "0x1B7EDBC", VA = "0x7BBC37EDBC", Slot = "40")]
		protected override void InitGRIData()
		{
		}

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD7")]
		[Address(RVA = "0x1B7F224", Offset = "0x1B7F224", VA = "0x7BBC37F224")]
		private void OnPhaseChanged(uint oldValue, uint newValue)
		{
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD8")]
		[Address(RVA = "0x1B7FB68", Offset = "0x1B7FB68", VA = "0x7BBC37FB68")]
		private void OnPointChanged(uint oldValue, uint newValue)
		{
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCD9")]
		[Address(RVA = "0x1B7FC04", Offset = "0x1B7FC04", VA = "0x7BBC37FC04", Slot = "46")]
		public override Player CreatePlayer(Transform container, ulong userID, ulong serviceGroupID, {QAb\u0082~u playerID, bool isAI = false, [Optional] object syncInfo)
		{
			return null;
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x00036F18 File Offset: 0x00035118
		[Token(Token = "0x600CCDA")]
		[Address(RVA = "0x1B7FD2C", Offset = "0x1B7FD2C", VA = "0x7BBC37FD2C")]
		public int GetAlivePlayerCount()
		{
			return 0;
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDB")]
		[Address(RVA = "0x1B7FF0C", Offset = "0x1B7FF0C", VA = "0x7BBC37FF0C")]
		public void OnKillCDChange(int oldValue, int newValue)
		{
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDC")]
		[Address(RVA = "0x1B80138", Offset = "0x1B80138", VA = "0x7BBC380138")]
		private void OnAllWolfCountChange(uint oldValue, uint newValue)
		{
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDD")]
		[Address(RVA = "0x1B801D4", Offset = "0x1B801D4", VA = "0x7BBC3801D4")]
		private void OnCurrentWolfCountChange(uint oldValue, uint newValue)
		{
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDE")]
		[Address(RVA = "0x1B80270", Offset = "0x1B80270", VA = "0x7BBC380270")]
		public void OnSkillCDChange(int oldValue, int newValue)
		{
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDF")]
		[Address(RVA = "0x1B8049C", Offset = "0x1B8049C", VA = "0x7BBC38049C", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE0")]
		[Address(RVA = "0x1B805D8", Offset = "0x1B805D8", VA = "0x7BBC3805D8")]
		private void OnDelPlayer(params object[] data)
		{
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE1")]
		[Address(RVA = "0x1B80844", Offset = "0x1B80844", VA = "0x7BBC380844")]
		public void OnAddVoteChat({QAb\u0082~u playerId, int votedTime, MultiplePlayerWereWolvesGame.EChatShowType showType, bool needRefresh)
		{
		}

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE2")]
		[Address(RVA = "0x1B80A60", Offset = "0x1B80A60", VA = "0x7BBC380A60")]
		private void PlayAlertSound()
		{
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE3")]
		[Address(RVA = "0x1B80B10", Offset = "0x1B80B10", VA = "0x7BBC380B10")]
		private void StopPlayAlertSound()
		{
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE4")]
		[Address(RVA = "0x1B80BBC", Offset = "0x1B80BBC", VA = "0x7BBC380BBC")]
		public void OnSyncTaskAlert(<<EMPTY_NAME>> msg)
		{
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE5")]
		[Address(RVA = "0x1B80FE4", Offset = "0x1B80FE4", VA = "0x7BBC380FE4")]
		public void OnSyncQuickChat(luAkRgE msg)
		{
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE6")]
		[Address(RVA = "0x1B8132C", Offset = "0x1B8132C", VA = "0x7BBC38132C")]
		public void OnSyncChat(m^MOqB^ msg)
		{
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x00036F30 File Offset: 0x00035130
		[Token(Token = "0x600CCE7")]
		[Address(RVA = "0x1B815FC", Offset = "0x1B815FC", VA = "0x7BBC3815FC")]
		private int ChatCmp(MultiplePlayerWereWolvesGame.WereWolvesChatEasyListInfo a, MultiplePlayerWereWolvesGame.WereWolvesChatEasyListInfo b)
		{
			return 0;
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE8")]
		[Address(RVA = "0x1B8177C", Offset = "0x1B8177C", VA = "0x7BBC38177C")]
		public void OnSyncVoice(EMjrrWq msg)
		{
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE9")]
		[Address(RVA = "0x1B81A2C", Offset = "0x1B81A2C", VA = "0x7BBC381A2C")]
		public void RegistPreparePhaseCameraPivot(PreparePhaseCameraPivot pivot)
		{
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEA")]
		[Address(RVA = "0x1B81A9C", Offset = "0x1B81A9C", VA = "0x7BBC381A9C")]
		private void OnGameOverFlagCome(uint oldValue, uint newValue)
		{
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DBD")]
		public qxPLSvi CachedMatchEndInfo
		{
			[Token(Token = "0x600CCEB")]
			[Address(RVA = "0x1B81BC0", Offset = "0x1B81BC0", VA = "0x7BBC381BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEC")]
		[Address(RVA = "0x1B81BC8", Offset = "0x1B81BC8", VA = "0x7BBC381BC8")]
		public void CachMatchEndInfo(qxPLSvi msg)
		{
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCED")]
		[Address(RVA = "0x1B81BD0", Offset = "0x1B81BD0", VA = "0x7BBC381BD0")]
		public void RefreshChatCD()
		{
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEE")]
		[Address(RVA = "0x1B7F9FC", Offset = "0x1B7F9FC", VA = "0x7BBC37F9FC")]
		private void BeginTutorial()
		{
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEF")]
		[Address(RVA = "0x1B80744", Offset = "0x1B80744", VA = "0x7BBC380744")]
		private void FilterInvalidChatInfo({QAb\u0082~u playerId)
		{
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF0")]
		[Address(RVA = "0x1B81C5C", Offset = "0x1B81C5C", VA = "0x7BBC381C5C")]
		public MultiplePlayerWereWolvesGame()
		{
		}

		// Token: 0x0401008E RID: 65678
		[Token(Token = "0x401008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Dictionary<int, Color32> PlayerColorMap;

		// Token: 0x0401008F RID: 65679
		[Token(Token = "0x401008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private <<EMPTY_NAME>> m_TaskManager;

		// Token: 0x04010090 RID: 65680
		[Token(Token = "0x4010090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private WereWolvesBodyManager m_BodyManager;

		// Token: 0x04010091 RID: 65681
		[Token(Token = "0x4010091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<MultiplePlayerWereWolvesGame.WereWolvesChatEasyListInfo> m_ChatInfos;

		// Token: 0x04010092 RID: 65682
		[Token(Token = "0x4010092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private cmqSIKS m_VoteManager;

		// Token: 0x04010093 RID: 65683
		[Token(Token = "0x4010093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Dictionary<string, WereWolvesRoleData> m_RoleMap;

		// Token: 0x04010094 RID: 65684
		[Token(Token = "0x4010094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private List<WereWolvesQuickChatData> m_QuickChatList;

		// Token: 0x04010095 RID: 65685
		[Token(Token = "0x4010095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Dictionary<uint, WereWolvesQuickChatData> m_QuickChatDataDic;

		// Token: 0x04010096 RID: 65686
		[Token(Token = "0x4010096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<WereWolvesQuickChatData> m_QuickChatNoTargetList;

		// Token: 0x04010097 RID: 65687
		[Token(Token = "0x4010097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private List<WereWolvesQuickChatData> m_QuickChatTargetList;

		// Token: 0x04010098 RID: 65688
		[Token(Token = "0x4010098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float m_LastChatTime;

		// Token: 0x04010099 RID: 65689
		[Token(Token = "0x4010099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private bool m_SavedMicState;

		// Token: 0x0401009A RID: 65690
		[Token(Token = "0x401009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19D")]
		private bool m_IsInitedCameraPivot;

		// Token: 0x0401009B RID: 65691
		[Token(Token = "0x401009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private GameObject m_LocalPlayerCircleEffect;

		// Token: 0x0401009C RID: 65692
		[Token(Token = "0x401009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private AudioResource m_loopAlertSound;

		// Token: 0x0401009D RID: 65693
		[Token(Token = "0x401009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private List<PreparePhaseCameraPivot> m_PreparePhaseCameraPivotList;

		// Token: 0x0401009E RID: 65694
		[Token(Token = "0x401009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private qxPLSvi m_CachedMatchEndInfo;

		// Token: 0x0200269F RID: 9887
		[Token(Token = "0x200269F")]
		public enum EChatShowType
		{
			// Token: 0x040100A0 RID: 65696
			[Token(Token = "0x40100A0")]
			Normal,
			// Token: 0x040100A1 RID: 65697
			[Token(Token = "0x40100A1")]
			Vote,
			// Token: 0x040100A2 RID: 65698
			[Token(Token = "0x40100A2")]
			DeadInfo
		}

		// Token: 0x020026A0 RID: 9888
		[Token(Token = "0x20026A0")]
		public class WereWolvesChatEasyListInfo
		{
			// Token: 0x0600CCF1 RID: 52465 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CCF1")]
			[Address(RVA = "0x1B80A58", Offset = "0x1B80A58", VA = "0x7BBC380A58")]
			public WereWolvesChatEasyListInfo()
			{
			}

			// Token: 0x040100A3 RID: 65699
			[Token(Token = "0x40100A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u PlayerId;

			// Token: 0x040100A4 RID: 65700
			[Token(Token = "0x40100A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ChatString;

			// Token: 0x040100A5 RID: 65701
			[Token(Token = "0x40100A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int SendTime;

			// Token: 0x040100A6 RID: 65702
			[Token(Token = "0x40100A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public MultiplePlayerWereWolvesGame.EChatShowType ChatShowType;
		}

		// Token: 0x020026A1 RID: 9889
		[Token(Token = "0x20026A1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FE8D8", Offset = "0x10FE8D8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600CCF3 RID: 52467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CCF3")]
			[Address(RVA = "0x1B820E4", Offset = "0x1B820E4", VA = "0x7BBC3820E4")]
			public <>c()
			{
			}

			// Token: 0x0600CCF4 RID: 52468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600CCF4")]
			[Address(RVA = "0x1B820EC", Offset = "0x1B820EC", VA = "0x7BBC3820EC")]
			internal PlayerWereWolves <GetAlivePlayerCount>b__53_0(KeyValuePair<{QAb\u0082~u, Player> playerPair)
			{
				return null;
			}

			// Token: 0x0600CCF5 RID: 52469 RVA: 0x00036F48 File Offset: 0x00035148
			[Token(Token = "0x600CCF5")]
			[Address(RVA = "0x1B82180", Offset = "0x1B82180", VA = "0x7BBC382180")]
			internal bool <GetAlivePlayerCount>b__53_1(PlayerWereWolves wPlayer)
			{
				return default(bool);
			}

			// Token: 0x040100A7 RID: 65703
			[Token(Token = "0x40100A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly MultiplePlayerWereWolvesGame.<>c <>9;

			// Token: 0x040100A8 RID: 65704
			[Token(Token = "0x40100A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<{QAb\u0082~u, Player>, PlayerWereWolves> <>9__53_0;

			// Token: 0x040100A9 RID: 65705
			[Token(Token = "0x40100A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<PlayerWereWolves, bool> <>9__53_1;
		}

		// Token: 0x020026A2 RID: 9890
		[Token(Token = "0x20026A2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FE8E8", Offset = "0x10FE8E8")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x0600CCF6 RID: 52470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CCF6")]
			[Address(RVA = "0x1B81C54", Offset = "0x1B81C54", VA = "0x7BBC381C54")]
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x0600CCF7 RID: 52471 RVA: 0x00036F60 File Offset: 0x00035160
			[Token(Token = "0x600CCF7")]
			[Address(RVA = "0x1B8223C", Offset = "0x1B8223C", VA = "0x7BBC38223C")]
			internal bool <FilterInvalidChatInfo>b__0(MultiplePlayerWereWolvesGame.WereWolvesChatEasyListInfo chatInfo)
			{
				return default(bool);
			}

			// Token: 0x040100AA RID: 65706
			[Token(Token = "0x40100AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public {QAb\u0082~u playerId;
		}
	}
}
