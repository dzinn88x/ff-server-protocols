using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x0200125A RID: 4698
	[Token(Token = "0x200125A")]
	internal abstract class MatchGame : COWGameBase
	{
		// Token: 0x06004892 RID: 18578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004892")]
		[Address(RVA = "0x1A59F2C", Offset = "0x1A59F2C", VA = "0x7BBC259F2C")]
		public <<EMPTY_NAME>> GetMatch()
		{
			return null;
		}

		// Token: 0x06004893 RID: 18579 RVA: 0x00016098 File Offset: 0x00014298
		[Token(Token = "0x6004893")]
		[Address(RVA = "0x1A59F34", Offset = "0x1A59F34", VA = "0x7BBC259F34", Slot = "39")]
		public virtual bool IsOnlineGame()
		{
			return default(bool);
		}

		// Token: 0x06004894 RID: 18580 RVA: 0x000160B0 File Offset: 0x000142B0
		[Token(Token = "0x6004894")]
		[Address(RVA = "0x1A59F3C", Offset = "0x1A59F3C", VA = "0x7BBC259F3C", Slot = "26")]
		public override bool NotUsingAB()
		{
			return default(bool);
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004895")]
		[Address(RVA = "0x1A59F4C", Offset = "0x1A59F4C", VA = "0x7BBC259F4C", Slot = "27")]
		public override void SetSceneABInfo(AssetBundle ab, bool useAB, string abPath, string streamABPath)
		{
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004896")]
		[Address(RVA = "0x1A59F60", Offset = "0x1A59F60", VA = "0x7BBC259F60", Slot = "30")]
		public override string GetSceneStreamABPath()
		{
			return null;
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004897")]
		[Address(RVA = "0x1A59F68", Offset = "0x1A59F68", VA = "0x7BBC259F68", Slot = "28")]
		public override AssetBundle GetStreamSceneAB()
		{
			return null;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004898")]
		[Address(RVA = "0x1A59F70", Offset = "0x1A59F70", VA = "0x7BBC259F70", Slot = "29")]
		public override byte[] GetStreamSceneABTexRefInfo()
		{
			return null;
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004899")]
		[Address(RVA = "0x1A5A260", Offset = "0x1A5A260", VA = "0x7BBC25A260", Slot = "18")]
		public override Type GetUISceneType()
		{
			return null;
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489A")]
		[Address(RVA = "0x1A5A2D0", Offset = "0x1A5A2D0", VA = "0x7BBC25A2D0", Slot = "8")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489B")]
		[Address(RVA = "0x1A5A46C", Offset = "0x1A5A46C", VA = "0x7BBC25A46C", Slot = "40")]
		protected virtual void InitGRIData()
		{
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489C")]
		[Address(RVA = "0x1A5A618", Offset = "0x1A5A618", VA = "0x7BBC25A618", Slot = "9")]
		protected override void OnSceneLoaded()
		{
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600489D")]
		[Address(RVA = "0x1A5A7C4", Offset = "0x1A5A7C4", VA = "0x7BBC25A7C4", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x000160C8 File Offset: 0x000142C8
		[Token(Token = "0x600489E")]
		[Address(RVA = "0x1A5A908", Offset = "0x1A5A908", VA = "0x7BBC25A908")]
		public bool ShowGameOpeingAnimation()
		{
			return default(bool);
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x600489F")]
		[Address(RVA = "0x1A5A9B4", Offset = "0x1A5A9B4", VA = "0x7BBC25A9B4")]
		public bool GameOpeningMovieAnimationEnable()
		{
			return default(bool);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A0")]
		[Address(RVA = "0x1A5AA90", Offset = "0x1A5AA90", VA = "0x7BBC25AA90")]
		private void OnReturnToLobby(params object[] data)
		{
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A1")]
		[Address(RVA = "0x1A5B00C", Offset = "0x1A5B00C", VA = "0x7BBC25B00C", Slot = "41")]
		protected virtual void OnLeaveMatchGame()
		{
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A2")]
		[Address(RVA = "0x1A5B010", Offset = "0x1A5B010", VA = "0x7BBC25B010")]
		public Y GetLevelObjectManager()
		{
			return null;
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A3")]
		[Address(RVA = "0x1A5B018", Offset = "0x1A5B018", VA = "0x7BBC25B018", Slot = "42")]
		public virtual GameModeSetting GetGameModeSetting()
		{
			return null;
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A4")]
		[Address(RVA = "0x1A5B118", Offset = "0x1A5B118", VA = "0x7BBC25B118", Slot = "43")]
		public virtual ContainerDatas GetContainerDatas()
		{
			return null;
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A5")]
		[Address(RVA = "0x1A5B218", Offset = "0x1A5B218", VA = "0x7BBC25B218")]
		public CameraControllerManager GetCameraControllerManager()
		{
			return null;
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A6")]
		[Address(RVA = "0x1A5B220", Offset = "0x1A5B220", VA = "0x7BBC25B220")]
		public void RegisterRepEntity(ReplicationEntity entity)
		{
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A7")]
		[Address(RVA = "0x1A5B2B0", Offset = "0x1A5B2B0", VA = "0x7BBC25B2B0")]
		public void UnRegisterRepEntity(ReplicationEntity entity)
		{
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048A8")]
		[Address(RVA = "0x1A5B33C", Offset = "0x1A5B33C", VA = "0x7BBC25B33C")]
		public ReplicationEntity GetRepEntity(uint id)
		{
			return null;
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048A9")]
		[Address(RVA = "0x1A5B3C4", Offset = "0x1A5B3C4", VA = "0x7BBC25B3C4")]
		public void OnSyncReplicationData(BinaryReader reader)
		{
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AA")]
		[Address(RVA = "0x1A5B3FC", Offset = "0x1A5B3FC", VA = "0x7BBC25B3FC", Slot = "44")]
		protected virtual void OnAlivePlayerCountChanged(byte oldValue, byte newValue)
		{
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AB")]
		[Address(RVA = "0x1A5B4A4", Offset = "0x1A5B4A4", VA = "0x7BBC25B4A4")]
		protected void AddUmaDC()
		{
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AC")]
		[Address(RVA = "0x1A5B6C8", Offset = "0x1A5B6C8", VA = "0x7BBC25B6C8")]
		public void ReleaseUmaDc()
		{
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x1A5B774", Offset = "0x1A5B774", VA = "0x7BBC25B774")]
		public void EnsureUmaDc()
		{
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048AE")]
		[Address(RVA = "0x1A5B7FC", Offset = "0x1A5B7FC", VA = "0x7BBC25B7FC")]
		public void OnRequestQuitMatchRes(qunw|Dp msg)
		{
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x000160F8 File Offset: 0x000142F8
		[Token(Token = "0x60048AF")]
		[Address(RVA = "0x1A5BB68", Offset = "0x1A5BB68", VA = "0x7BBC25BB68")]
		public bool IsLocalPlayerAlive()
		{
			return default(bool);
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x00016110 File Offset: 0x00014310
		[Token(Token = "0x60048B0")]
		[Address(RVA = "0x1A5BC30", Offset = "0x1A5BC30", VA = "0x7BBC25BC30")]
		public bool IsLocalPlayerPendingRevive()
		{
			return default(bool);
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x00016128 File Offset: 0x00014328
		[Token(Token = "0x60048B1")]
		[Address(RVA = "0x1A5BD34", Offset = "0x1A5BD34", VA = "0x7BBC25BD34")]
		public bool IsLocalObserverFinishedMatch()
		{
			return default(bool);
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00016140 File Offset: 0x00014340
		[Token(Token = "0x60048B2")]
		[Address(RVA = "0x1A5BF3C", Offset = "0x1A5BF3C", VA = "0x7BBC25BF3C")]
		public bool IsLocalPlayerFinishedMatch()
		{
			return default(bool);
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B3")]
		[Address(RVA = "0x1A5C060", Offset = "0x1A5C060", VA = "0x7BBC25C060")]
		public void EndObserver()
		{
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B4")]
		[Address(RVA = "0x1A5C114", Offset = "0x1A5C114", VA = "0x7BBC25C114")]
		public void SendQuitRequest(EQuitGameReason reason = EQuitGameReason.Normal)
		{
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B5")]
		[Address(RVA = "0x1A5C1D4", Offset = "0x1A5C1D4", VA = "0x7BBC25C1D4", Slot = "45")]
		public virtual void SendQuitFakeBotRequest()
		{
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B6")]
		[Address(RVA = "0x1A5C1D8", Offset = "0x1A5C1D8", VA = "0x7BBC25C1D8")]
		public void RequestShowMatchResult()
		{
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B7")]
		[Address(RVA = "0x1A5C284", Offset = "0x1A5C284", VA = "0x7BBC25C284")]
		public void RoomSpectatorRequestQuitMatch()
		{
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B8")]
		[Address(RVA = "0x1A5C434", Offset = "0x1A5C434", VA = "0x7BBC25C434")]
		public void RequestQuitMatch(EQuitGameReason reason = EQuitGameReason.Normal)
		{
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048B9")]
		[Address(RVA = "0x1A5B800", Offset = "0x1A5B800", VA = "0x7BBC25B800")]
		public void OnQuitMatchToLobby()
		{
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00016158 File Offset: 0x00014358
		[Token(Token = "0x60048BA")]
		[Address(RVA = "0x1A5C5E8", Offset = "0x1A5C5E8", VA = "0x7BBC25C5E8", Slot = "32")]
		public override bool ShouldClearPreloadAssets(Type nextGameType)
		{
			return default(bool);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BB")]
		[Address(RVA = "0x1A5C6C4", Offset = "0x1A5C6C4", VA = "0x7BBC25C6C4")]
		public InGameCutsceneManager GetInGameCutsceneManager()
		{
			return null;
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x1A5C6CC", Offset = "0x1A5C6CC", VA = "0x7BBC25C6CC")]
		public void RegisterInGameCutsceneManager(InGameCutsceneManager manager)
		{
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x1A5C6D4", Offset = "0x1A5C6D4", VA = "0x7BBC25C6D4", Slot = "13")]
		protected override void OnInputUpdate()
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x1A5C6D8", Offset = "0x1A5C6D8", VA = "0x7BBC25C6D8", Slot = "46")]
		public virtual Player CreatePlayer(Transform container, ulong userID, ulong serviceGroupID, {QAb\u0082~u playerID, bool isAI = false, [Optional] object syncInfo)
		{
			return null;
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048BF")]
		[Address(RVA = "0x1A5C7B4", Offset = "0x1A5C7B4", VA = "0x7BBC25C7B4", Slot = "47")]
		public virtual void OnAddPlayer(Player p)
		{
		}

		// Token: 0x060048C0 RID: 18624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C0")]
		[Address(RVA = "0x1A5C7B8", Offset = "0x1A5C7B8", VA = "0x7BBC25C7B8")]
		protected MatchGame()
		{
		}

		// Token: 0x060048C1 RID: 18625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C1")]
		[Address(RVA = "0x1A5C858", Offset = "0x1A5C858", VA = "0x7BBC25C858")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC20", Offset = "0x113DC20")]
		private void <OnReturnToLobby>b__30_0()
		{
		}

		// Token: 0x060048C2 RID: 18626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C2")]
		[Address(RVA = "0x1A5C970", Offset = "0x1A5C970", VA = "0x7BBC25C970")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC30", Offset = "0x113DC30")]
		private void <RoomSpectatorRequestQuitMatch>b__53_0()
		{
		}

		// Token: 0x060048C3 RID: 18627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048C3")]
		[Address(RVA = "0x1A5C974", Offset = "0x1A5C974", VA = "0x7BBC25C974")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DC40", Offset = "0x113DC40")]
		private void <RequestQuitMatch>b__54_0()
		{
		}

		// Token: 0x040071A8 RID: 29096
		[Token(Token = "0x40071A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected <<EMPTY_NAME>> m_Match;

		// Token: 0x040071A9 RID: 29097
		[Token(Token = "0x40071A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected GameModeSetting m_GameModeSetting;

		// Token: 0x040071AA RID: 29098
		[Token(Token = "0x40071AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected uint m_ReturnToLobbyRequest;

		// Token: 0x040071AB RID: 29099
		[Token(Token = "0x40071AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected Y m_LevelObjectManager;

		// Token: 0x040071AC RID: 29100
		[Token(Token = "0x40071AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected Dictionary<uint, ReplicationEntity> m_ReplicationEntitis;

		// Token: 0x040071AD RID: 29101
		[Token(Token = "0x40071AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected GRIDataPool m_GRIDataPool;

		// Token: 0x040071AE RID: 29102
		[Token(Token = "0x40071AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected CameraControllerManager m_CameraControllerManager;

		// Token: 0x040071AF RID: 29103
		[Token(Token = "0x40071AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected uint m_QuitMatchRequest;

		// Token: 0x040071B0 RID: 29104
		[Token(Token = "0x40071B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected ContainerDatas m_ContainerDatas;

		// Token: 0x040071B1 RID: 29105
		[Token(Token = "0x40071B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected bool mUseAB;

		// Token: 0x040071B2 RID: 29106
		[Token(Token = "0x40071B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		protected bool m_isSendMsg;

		// Token: 0x040071B3 RID: 29107
		[Token(Token = "0x40071B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected string mSceneABPath;

		// Token: 0x040071B4 RID: 29108
		[Token(Token = "0x40071B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected string mStreamSceneAbPath;

		// Token: 0x040071B5 RID: 29109
		[Token(Token = "0x40071B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected InGameCutsceneManager m_InGameCutsceneManager;

		// Token: 0x040071B6 RID: 29110
		[Token(Token = "0x40071B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected AssetBundle m_streamSceneAB;

		// Token: 0x040071B7 RID: 29111
		[Token(Token = "0x40071B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected GameObject m_UmaDcs;
	}
}
