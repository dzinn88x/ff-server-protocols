using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02002093 RID: 8339
	[Token(Token = "0x2002093")]
	internal class UIWereWolvesGameScene : UIInGameScene
	{
		// Token: 0x0600BB3E RID: 47934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3E")]
		[Address(RVA = "0x178D6FC", Offset = "0x178D6FC", VA = "0x7BBBF8D6FC", Slot = "12")]
		protected override void OpenCommonHud()
		{
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB3F")]
		[Address(RVA = "0x178E730", Offset = "0x178E730", VA = "0x7BBBF8E730", Slot = "10")]
		public override void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600BB40 RID: 47936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB40")]
		[Address(RVA = "0x178EAF0", Offset = "0x178EAF0", VA = "0x7BBBF8EAF0", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600BB41 RID: 47937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB41")]
		[Address(RVA = "0x178EEB0", Offset = "0x178EEB0", VA = "0x7BBBF8EEB0")]
		private void OnPlayerRoleChange(params object[] data)
		{
		}

		// Token: 0x0600BB42 RID: 47938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB42")]
		[Address(RVA = "0x178EF74", Offset = "0x178EF74", VA = "0x7BBBF8EF74")]
		private void ProcessLocalPlayerRoleChange(DML\u007FYGw role)
		{
		}

		// Token: 0x0600BB43 RID: 47939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB43")]
		[Address(RVA = "0x178F46C", Offset = "0x178F46C", VA = "0x7BBBF8F46C")]
		private void OnShowTaskPanel(params object[] data)
		{
		}

		// Token: 0x0600BB44 RID: 47940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB44")]
		[Address(RVA = "0x178F994", Offset = "0x178F994", VA = "0x7BBBF8F994")]
		private void OnShowVotePanel(params object[] data)
		{
		}

		// Token: 0x0600BB45 RID: 47941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB45")]
		[Address(RVA = "0x178FA90", Offset = "0x178FA90", VA = "0x7BBBF8FA90")]
		private void OnPlayerReadyVote(params object[] data)
		{
		}

		// Token: 0x0600BB46 RID: 47942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB46")]
		[Address(RVA = "0x178FB6C", Offset = "0x178FB6C", VA = "0x7BBBF8FB6C")]
		private void OnPlayerExitReadyVote(params object[] data)
		{
		}

		// Token: 0x0600BB47 RID: 47943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB47")]
		[Address(RVA = "0x178FC9C", Offset = "0x178FC9C", VA = "0x7BBBF8FC9C")]
		private void OnBuffNoMap(params object[] data)
		{
		}

		// Token: 0x0600BB48 RID: 47944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB48")]
		[Address(RVA = "0x178D8E0", Offset = "0x178D8E0", VA = "0x7BBBF8D8E0")]
		public void OpenMiniMap()
		{
		}

		// Token: 0x0600BB49 RID: 47945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB49")]
		[Address(RVA = "0x178DA34", Offset = "0x178DA34", VA = "0x7BBBF8DA34")]
		public void OpenBigMap()
		{
		}

		// Token: 0x0600BB4A RID: 47946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4A")]
		[Address(RVA = "0x178DBC8", Offset = "0x178DBC8", VA = "0x7BBBF8DBC8")]
		public void OpenMoveBtn()
		{
		}

		// Token: 0x0600BB4B RID: 47947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4B")]
		[Address(RVA = "0x178DF8C", Offset = "0x178DF8C", VA = "0x7BBBF8DF8C")]
		public void OpenInteract()
		{
		}

		// Token: 0x0600BB4C RID: 47948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4C")]
		[Address(RVA = "0x178E06C", Offset = "0x178E06C", VA = "0x7BBBF8E06C")]
		public void OpenReadyVote()
		{
		}

		// Token: 0x0600BB4D RID: 47949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4D")]
		[Address(RVA = "0x178E414", Offset = "0x178E414", VA = "0x7BBBF8E414")]
		public void OpenVoteResult()
		{
		}

		// Token: 0x0600BB4E RID: 47950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4E")]
		[Address(RVA = "0x178DCB8", Offset = "0x178DCB8", VA = "0x7BBBF8DCB8")]
		public void OpenTaskHUD()
		{
		}

		// Token: 0x0600BB4F RID: 47951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB4F")]
		[Address(RVA = "0x178DD98", Offset = "0x178DD98", VA = "0x7BBBF8DD98")]
		public void OpenVoteHUD()
		{
		}

		// Token: 0x0600BB50 RID: 47952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB50")]
		[Address(RVA = "0x178DEB4", Offset = "0x178DEB4", VA = "0x7BBBF8DEB4")]
		private void OpenGameInfoHUD()
		{
		}

		// Token: 0x0600BB51 RID: 47953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB51")]
		[Address(RVA = "0x178F0C4", Offset = "0x178F0C4", VA = "0x7BBBF8F0C4")]
		private void OpenTaskList()
		{
		}

		// Token: 0x0600BB52 RID: 47954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB52")]
		[Address(RVA = "0x178F394", Offset = "0x178F394", VA = "0x7BBBF8F394")]
		private void OpenTaskWolfList()
		{
		}

		// Token: 0x0600BB53 RID: 47955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB53")]
		[Address(RVA = "0x178F2B4", Offset = "0x178F2B4", VA = "0x7BBBF8F2B4")]
		private void OpenWolfTask()
		{
		}

		// Token: 0x0600BB54 RID: 47956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB54")]
		[Address(RVA = "0x178E1F8", Offset = "0x178E1F8", VA = "0x7BBBF8E1F8")]
		private void OpenWolfCount()
		{
		}

		// Token: 0x0600BB55 RID: 47957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB55")]
		[Address(RVA = "0x178E164", Offset = "0x178E164", VA = "0x7BBBF8E164")]
		private void OpenVoiceEngine()
		{
		}

		// Token: 0x0600BB56 RID: 47958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB56")]
		[Address(RVA = "0x178FDEC", Offset = "0x178FDEC", VA = "0x7BBBF8FDEC")]
		private void CloseVoiceEngine()
		{
		}

		// Token: 0x0600BB57 RID: 47959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB57")]
		[Address(RVA = "0x178E334", Offset = "0x178E334", VA = "0x7BBBF8E334")]
		private void OpenPrepareHUD()
		{
		}

		// Token: 0x0600BB58 RID: 47960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB58")]
		[Address(RVA = "0x178E550", Offset = "0x178E550", VA = "0x7BBBF8E550")]
		private void OpenSpeedUpHUD()
		{
		}

		// Token: 0x0600BB59 RID: 47961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB59")]
		[Address(RVA = "0x178F19C", Offset = "0x178F19C", VA = "0x7BBBF8F19C")]
		private void OpenWolfKillHUD()
		{
		}

		// Token: 0x0600BB5A RID: 47962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5A")]
		[Address(RVA = "0x178FE84", Offset = "0x178FE84", VA = "0x7BBBF8FE84")]
		private void OpenIntroInfoHUD()
		{
		}

		// Token: 0x0600BB5B RID: 47963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5B")]
		[Address(RVA = "0x178FF44", Offset = "0x178FF44", VA = "0x7BBBF8FF44")]
		public void OpenCampInfo(bool isWolf, int wolfCount, List<byte> wolfsColorIndex)
		{
		}

		// Token: 0x0600BB5C RID: 47964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5C")]
		[Address(RVA = "0x17900F0", Offset = "0x17900F0", VA = "0x7BBBF900F0")]
		public void OpenHumanKilledHUD({QAb\u0082~u humanPlayerID, {QAb\u0082~u wolfPlayerID)
		{
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5D")]
		[Address(RVA = "0x1790340", Offset = "0x1790340", VA = "0x7BBBF90340")]
		public void OnNewPhaseCome(params object[] param)
		{
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5E")]
		[Address(RVA = "0x1790988", Offset = "0x1790988", VA = "0x7BBBF90988")]
		public void OpenEndShowTime()
		{
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB5F")]
		[Address(RVA = "0x1790A1C", Offset = "0x1790A1C", VA = "0x7BBBF90A1C")]
		public void OpenMatchResult()
		{
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB60")]
		[Address(RVA = "0x178E640", Offset = "0x178E640", VA = "0x7BBBF8E640")]
		public void OpenJumpBtn()
		{
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB61")]
		[Address(RVA = "0x1790AD0", Offset = "0x1790AD0", VA = "0x7BBBF90AD0")]
		private void OnLocalPlayerBunkerStateCome(params object[] param)
		{
		}

		// Token: 0x0600BB62 RID: 47970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB62")]
		public T OpenUIByGamePhase<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor, [Optional] List<DHQ~KHd> gamePhases) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x0600BB63 RID: 47971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB63")]
		[Address(RVA = "0x1790E90", Offset = "0x1790E90", VA = "0x7BBBF90E90")]
		public void OnAddTaskNameController(UIHudTaskNameIconController controller)
		{
		}

		// Token: 0x0600BB64 RID: 47972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB64")]
		[Address(RVA = "0x1790F48", Offset = "0x1790F48", VA = "0x7BBBF90F48")]
		public void OnRemoveTaskNameController(UIHudTaskNameIconController controller)
		{
		}

		// Token: 0x0600BB65 RID: 47973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BB65")]
		[Address(RVA = "0x1790FFC", Offset = "0x1790FFC", VA = "0x7BBBF90FFC")]
		private UIHudTaskNameIconController FindNearestTaskNameIcon()
		{
			return null;
		}

		// Token: 0x0600BB66 RID: 47974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB66")]
		[Address(RVA = "0x179134C", Offset = "0x179134C", VA = "0x7BBBF9134C")]
		public void BeginTutorial(bool isWolf)
		{
		}

		// Token: 0x0600BB67 RID: 47975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB67")]
		[Address(RVA = "0x179135C", Offset = "0x179135C", VA = "0x7BBBF9135C")]
		private void ShowTaskIconTurorial(bool isWolf)
		{
		}

		// Token: 0x0600BB68 RID: 47976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB68")]
		[Address(RVA = "0x1791414", Offset = "0x1791414", VA = "0x7BBBF91414")]
		private void ShowKillTutorial()
		{
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB69")]
		[Address(RVA = "0x1791504", Offset = "0x1791504", VA = "0x7BBBF91504")]
		private void OnShowWolfDestroyTutorial(params object[] param)
		{
		}

		// Token: 0x0600BB6A RID: 47978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6A")]
		[Address(RVA = "0x17915F4", Offset = "0x17915F4", VA = "0x7BBBF915F4")]
		private void OnShowWolfFakeTaskTutorial(params object[] param)
		{
		}

		// Token: 0x0600BB6B RID: 47979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6B")]
		[Address(RVA = "0x17915FC", Offset = "0x17915FC", VA = "0x7BBBF915FC")]
		public UIWereWolvesGameScene()
		{
		}

		// Token: 0x0600BB6C RID: 47980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB6C")]
		[Address(RVA = "0x17916B4", Offset = "0x17916B4", VA = "0x7BBBF916B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147CE4", Offset = "0x1147CE4")]
		private void <OpenIntroInfoHUD>b__43_0()
		{
		}

		// Token: 0x0400BC4E RID: 48206
		[Token(Token = "0x400BC4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private UIHudWereWolvesTaskController m_HudTask;

		// Token: 0x0400BC4F RID: 48207
		[Token(Token = "0x400BC4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private UIHudWereWolvesVoteController m_HudVote;

		// Token: 0x0400BC50 RID: 48208
		[Token(Token = "0x400BC50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private UIHUDWolfKillActionController m_WolfKill;

		// Token: 0x0400BC51 RID: 48209
		[Token(Token = "0x400BC51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private UIHUDSelfInfoController m_SelfInfo;

		// Token: 0x0400BC52 RID: 48210
		[Token(Token = "0x400BC52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private UIHudWereWolvesInteractController m_Interact;

		// Token: 0x0400BC53 RID: 48211
		[Token(Token = "0x400BC53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private UIHUDReadyVote m_ReadyVote;

		// Token: 0x0400BC54 RID: 48212
		[Token(Token = "0x400BC54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private Dictionary<DHQ~KHd, List<UIBaseController>> m_PhaseShowControllerMap;

		// Token: 0x0400BC55 RID: 48213
		[Token(Token = "0x400BC55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private DHQ~KHd m_CurPhase;

		// Token: 0x0400BC56 RID: 48214
		[Token(Token = "0x400BC56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private Dictionary<UIHudTaskNameIconController, bool> m_ActiveTaskNameIconMap;

		// Token: 0x0400BC57 RID: 48215
		[Token(Token = "0x400BC57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private UIHudWereWolvesVoiceEngineController m_VoiceController;

		// Token: 0x0400BC58 RID: 48216
		[Token(Token = "0x400BC58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private UIHudMovingJoystickController m_MoveBtn;

		// Token: 0x0400BC59 RID: 48217
		[Token(Token = "0x400BC59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private UIBigMapController m_BigMap;

		// Token: 0x0400BC5A RID: 48218
		[Token(Token = "0x400BC5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private UIHudWolfTaskController m_WolfTask;

		// Token: 0x0400BC5B RID: 48219
		[Token(Token = "0x400BC5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private UIHUDWereWolvesPrepareInfoController m_PrepareInfoController;

		// Token: 0x0400BC5C RID: 48220
		[Token(Token = "0x400BC5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private UIHudModeIntroInfoController m_IntroController;

		// Token: 0x0400BC5D RID: 48221
		[Token(Token = "0x400BC5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private UIHUDWereWolvesCampInfoController m_CampInfoController;

		// Token: 0x0400BC5E RID: 48222
		[Token(Token = "0x400BC5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private UIHUDWereWolvesEndShowTime m_EndShowTime;

		// Token: 0x0400BC5F RID: 48223
		[Token(Token = "0x400BC5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private UIHudJumpController m_JumpCtrl;
	}
}
