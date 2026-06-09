using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002080 RID: 8320
	[Token(Token = "0x2002080")]
	internal class UIInGameScene : UICOWBaseScene
	{
		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600B9DE RID: 47582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CBF")]
		public UIHudWeaponInfoController WeaponInfoController
		{
			[Token(Token = "0x600B9DE")]
			[Address(RVA = "0x139082C", Offset = "0x139082C", VA = "0x7BBBB9082C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC0")]
		public UIHudAuxFireController AuxfireCtrl
		{
			[Token(Token = "0x600B9DF")]
			[Address(RVA = "0x1390834", Offset = "0x1390834", VA = "0x7BBBB90834")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC1")]
		public UIHudSwapWeaponQuickController SweapWeaponQuickController
		{
			[Token(Token = "0x600B9E0")]
			[Address(RVA = "0x139083C", Offset = "0x139083C", VA = "0x7BBBB9083C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC2")]
		public UIHudReloadBtnController ReloadBtnController
		{
			[Token(Token = "0x600B9E1")]
			[Address(RVA = "0x1390844", Offset = "0x1390844", VA = "0x7BBBB90844")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600B9E2 RID: 47586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC3")]
		public UIHudCrosshairsController CrossHairCtrl
		{
			[Token(Token = "0x600B9E2")]
			[Address(RVA = "0x139084C", Offset = "0x139084C", VA = "0x7BBBB9084C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600B9E3 RID: 47587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC4")]
		public UIHudFireController FireController
		{
			[Token(Token = "0x600B9E3")]
			[Address(RVA = "0x1390854", Offset = "0x1390854", VA = "0x7BBBB90854")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x00034EC0 File Offset: 0x000330C0
		// (set) Token: 0x0600B9E5 RID: 47589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CC5")]
		public UIInGameScene.EMapStateType MapState
		{
			[Token(Token = "0x600B9E4")]
			[Address(RVA = "0x139085C", Offset = "0x139085C", VA = "0x7BBBB9085C")]
			get
			{
				return UIInGameScene.EMapStateType.MiniMap;
			}
			[Token(Token = "0x600B9E5")]
			[Address(RVA = "0x1390864", Offset = "0x1390864", VA = "0x7BBBB90864")]
			set
			{
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x0600B9E6 RID: 47590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC6")]
		public Transform UiHudPanelDynamic
		{
			[Token(Token = "0x600B9E6")]
			[Address(RVA = "0x139086C", Offset = "0x139086C", VA = "0x7BBBB9086C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC7")]
		public Transform UiHudPanelStatic
		{
			[Token(Token = "0x600B9E7")]
			[Address(RVA = "0x1390874", Offset = "0x1390874", VA = "0x7BBBB90874")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9E8")]
		[Address(RVA = "0x139087C", Offset = "0x139087C", VA = "0x7BBBB9087C")]
		public UIInGameScene()
		{
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9E9")]
		[Address(RVA = "0x13977C0", Offset = "0x13977C0", VA = "0x7BBBB977C0")]
		private void UIRootOnAwake(UIRoot uiroot)
		{
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EA")]
		[Address(RVA = "0x1397AD0", Offset = "0x1397AD0", VA = "0x7BBBB97AD0", Slot = "10")]
		public virtual void RegisterGameEventHandler()
		{
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EB")]
		[Address(RVA = "0x1399A70", Offset = "0x1399A70", VA = "0x7BBBB99A70", Slot = "4")]
		public override void Destory()
		{
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EC")]
		[Address(RVA = "0x1399B38", Offset = "0x1399B38", VA = "0x7BBBB99B38")]
		public void OpenMask()
		{
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9ED")]
		[Address(RVA = "0x1399BD4", Offset = "0x1399BD4", VA = "0x7BBBB99BD4")]
		public void CloseMask(bool removeFakeLoading)
		{
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EE")]
		[Address(RVA = "0x1399EF8", Offset = "0x1399EF8", VA = "0x7BBBB99EF8", Slot = "11")]
		protected virtual void OnMaskClosed()
		{
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9EF")]
		[Address(RVA = "0x1399F04", Offset = "0x1399F04", VA = "0x7BBBB99F04")]
		private void SetAnhor(EUIAnchor anchor, Transform childTrans, Transform parentTrans)
		{
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F0")]
		[Address(RVA = "0x139A2E0", Offset = "0x139A2E0", VA = "0x7BBBB9A2E0")]
		public void InitHud()
		{
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F1")]
		[Address(RVA = "0x139A824", Offset = "0x139A824", VA = "0x7BBBB9A824")]
		public void OpenHud()
		{
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F2")]
		[Address(RVA = "0x139BCC0", Offset = "0x139BCC0", VA = "0x7BBBB9BCC0")]
		private void InitUIState()
		{
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F3")]
		[Address(RVA = "0x139BED4", Offset = "0x139BED4", VA = "0x7BBBB9BED4", Slot = "12")]
		protected virtual void OpenCommonHud()
		{
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F4")]
		[Address(RVA = "0x139E778", Offset = "0x139E778", VA = "0x7BBBB9E778")]
		public void OpenDriverFireHudInNeed()
		{
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F5")]
		[Address(RVA = "0x139E84C", Offset = "0x139E84C", VA = "0x7BBBB9E84C")]
		public void OpenPassengerSkillHudInNeed()
		{
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x00034ED8 File Offset: 0x000330D8
		[Token(Token = "0x600B9F6")]
		[Address(RVA = "0x139E9AC", Offset = "0x139E9AC", VA = "0x7BBBB9E9AC")]
		public bool CheckTriggerGrenadeShowed()
		{
			return default(bool);
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x00034EF0 File Offset: 0x000330F0
		[Token(Token = "0x600B9F7")]
		[Address(RVA = "0x139EAC0", Offset = "0x139EAC0", VA = "0x7BBBB9EAC0")]
		public bool CheckAuxFireShowed()
		{
			return default(bool);
		}

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9F8")]
		[Address(RVA = "0x139EBD4", Offset = "0x139EBD4", VA = "0x7BBBB9EBD4")]
		private UIBaseController OpenUI(Type uiBaseControllerType, Transform parent)
		{
			return null;
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9F9")]
		[Address(RVA = "0x139BD60", Offset = "0x139BD60", VA = "0x7BBBB9BD60")]
		public void RefreshJetFlyHudVisibility(params object[] data)
		{
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FA")]
		[Address(RVA = "0x139F070", Offset = "0x139F070", VA = "0x7BBBB9F070", Slot = "8")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600B9FB RID: 47611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FB")]
		[Address(RVA = "0x139F908", Offset = "0x139F908", VA = "0x7BBBB9F908", Slot = "9")]
		protected override void OnDestory()
		{
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9FC")]
		[Address(RVA = "0x13A1778", Offset = "0x13A1778", VA = "0x7BBBBA1778", Slot = "7")]
		protected override Transform FindUIRoot()
		{
			return null;
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B9FD")]
		[Address(RVA = "0x139F2A8", Offset = "0x139F2A8", VA = "0x7BBBB9F2A8")]
		protected Transform FindEPRoot()
		{
			return null;
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FE")]
		[Address(RVA = "0x13A17DC", Offset = "0x13A17DC", VA = "0x7BBBBA17DC")]
		public void SetManualTips(string content)
		{
		}

		// Token: 0x0600B9FF RID: 47615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B9FF")]
		[Address(RVA = "0x139F358", Offset = "0x139F358", VA = "0x7BBBB9F358")]
		private void OpenWaitingRoomEPRanking(Transform EPRoot)
		{
		}

		// Token: 0x0600BA00 RID: 47616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA00")]
		[Address(RVA = "0x13A1A04", Offset = "0x13A1A04", VA = "0x7BBBBA1A04")]
		public void ShowDynamicPopupMessage(string message, float duration = 5f)
		{
		}

		// Token: 0x0600BA01 RID: 47617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA01")]
		[Address(RVA = "0x13A1B0C", Offset = "0x13A1B0C", VA = "0x7BBBBA1B0C")]
		public void ShowPopupMessage(string message, float duration = 2f)
		{
		}

		// Token: 0x0600BA02 RID: 47618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA02")]
		[Address(RVA = "0x138FB50", Offset = "0x138FB50", VA = "0x7BBBB8FB50")]
		public void ShowPopupMessageByDepth(string message, int depth, float duration = 2f)
		{
		}

		// Token: 0x0600BA03 RID: 47619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA03")]
		[Address(RVA = "0x13A1C14", Offset = "0x13A1C14", VA = "0x7BBBBA1C14")]
		public void ShowSpecialPopupMessage(GameBannerInfo info, {Z|h[YF z)
		{
		}

		// Token: 0x0600BA04 RID: 47620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA04")]
		[Address(RVA = "0x13A1D14", Offset = "0x13A1D14", VA = "0x7BBBBA1D14")]
		public UIHudPopupController ShowPopupMessageWithoutAutoHide(string message)
		{
			return null;
		}

		// Token: 0x0600BA05 RID: 47621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA05")]
		[Address(RVA = "0x13A1DCC", Offset = "0x13A1DCC", VA = "0x7BBBBA1DCC")]
		public void ShowLowPopupMessage(string message, float duration = 2f)
		{
		}

		// Token: 0x0600BA06 RID: 47622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA06")]
		[Address(RVA = "0x13A1ED4", Offset = "0x13A1ED4", VA = "0x7BBBBA1ED4")]
		public void ClosePopup()
		{
		}

		// Token: 0x0600BA07 RID: 47623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA07")]
		[Address(RVA = "0x13A1FC4", Offset = "0x13A1FC4", VA = "0x7BBBBA1FC4")]
		public void ClosePopupOnly()
		{
		}

		// Token: 0x0600BA08 RID: 47624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA08")]
		[Address(RVA = "0x13A205C", Offset = "0x13A205C", VA = "0x7BBBBA205C")]
		private void OnShowCaseIntroductionVisbility(params object[] data)
		{
		}

		// Token: 0x0600BA09 RID: 47625 RVA: 0x00034F08 File Offset: 0x00033108
		[Token(Token = "0x600BA09")]
		[Address(RVA = "0x13A22C4", Offset = "0x13A22C4", VA = "0x7BBBBA22C4")]
		private bool CheckCanShowNoobPopup()
		{
			return default(bool);
		}

		// Token: 0x0600BA0A RID: 47626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0A")]
		[Address(RVA = "0x13A23E0", Offset = "0x13A23E0", VA = "0x7BBBBA23E0")]
		private void OnAddPlayer(params object[] data)
		{
		}

		// Token: 0x0600BA0B RID: 47627 RVA: 0x00034F20 File Offset: 0x00033120
		[Token(Token = "0x600BA0B")]
		[Address(RVA = "0x13A2CE4", Offset = "0x13A2CE4", VA = "0x7BBBBA2CE4")]
		public bool ShowTutorialFightWithTeammate()
		{
			return default(bool);
		}

		// Token: 0x0600BA0C RID: 47628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0C")]
		[Address(RVA = "0x13A2DDC", Offset = "0x13A2DDC", VA = "0x7BBBBA2DDC")]
		public void ShowChickenShowTimeUI([Optional] Action OnNormalMatchEnd, int rank = 0)
		{
		}

		// Token: 0x0600BA0D RID: 47629 RVA: 0x00034F38 File Offset: 0x00033138
		[Token(Token = "0x600BA0D")]
		[Address(RVA = "0x13A3018", Offset = "0x13A3018", VA = "0x7BBBBA3018")]
		private bool CanShowLoserAudio(int rank)
		{
			return default(bool);
		}

		// Token: 0x0600BA0E RID: 47630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0E")]
		[Address(RVA = "0x13A3104", Offset = "0x13A3104", VA = "0x7BBBBA3104")]
		public void CloseChickenShowTimeUI()
		{
		}

		// Token: 0x0600BA0F RID: 47631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA0F")]
		[Address(RVA = "0x13A319C", Offset = "0x13A319C", VA = "0x7BBBBA319C")]
		private void OnSwitchObserver(params object[] param)
		{
		}

		// Token: 0x0600BA10 RID: 47632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA10")]
		[Address(RVA = "0x13A43A4", Offset = "0x13A43A4", VA = "0x7BBBBA43A4")]
		private void CheckStreamReady()
		{
		}

		// Token: 0x0600BA11 RID: 47633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA11")]
		[Address(RVA = "0x13A4494", Offset = "0x13A4494", VA = "0x7BBBBA4494", Slot = "13")]
		protected virtual void CloseHUDMask()
		{
		}

		// Token: 0x0600BA12 RID: 47634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA12")]
		[Address(RVA = "0x13A45EC", Offset = "0x13A45EC", VA = "0x7BBBBA45EC")]
		private void OnAddSpectator(params object[] data)
		{
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA13")]
		[Address(RVA = "0x13A45F4", Offset = "0x13A45F4", VA = "0x7BBBBA45F4")]
		private void OnAddObserver(params object[] data)
		{
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA14")]
		[Address(RVA = "0x13A46DC", Offset = "0x13A46DC", VA = "0x7BBBBA46DC")]
		private void OnRemovePlayer(params object[] data)
		{
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA15")]
		[Address(RVA = "0x13A49D4", Offset = "0x13A49D4", VA = "0x7BBBBA49D4")]
		private void OnShowMatchResult(params object[] data)
		{
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA16")]
		[Address(RVA = "0x13A55C4", Offset = "0x13A55C4", VA = "0x7BBBBA55C4", Slot = "14")]
		protected virtual Type GetMatchResultType()
		{
			return null;
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA17")]
		[Address(RVA = "0x13A5408", Offset = "0x13A5408", VA = "0x7BBBBA5408")]
		private void OpenMatchResultUI(bool closeAll, bool releaseMemory, Type type, bool keepScene, bool createAvatar)
		{
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA18")]
		[Address(RVA = "0x1399A98", Offset = "0x1399A98", VA = "0x7BBBB99A98")]
		private void StopOpenMatchResultCorInNeed()
		{
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA19")]
		[Address(RVA = "0x13A570C", Offset = "0x13A570C", VA = "0x7BBBBA570C")]
		private void RequestMatchResultInNeed()
		{
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA1A")]
		[Address(RVA = "0x13A5634", Offset = "0x13A5634", VA = "0x7BBBBA5634")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1147B60", Offset = "0x1147B60")]
		private IEnumerator ReleaseMemoryAndOpenMatchResult(Type type, bool keepScene, bool createAvatar)
		{
			return null;
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1B")]
		[Address(RVA = "0x13A58B0", Offset = "0x13A58B0", VA = "0x7BBBBA58B0")]
		private static void PrintMemory(string label)
		{
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1C")]
		[Address(RVA = "0x13A5C3C", Offset = "0x13A5C3C", VA = "0x7BBBBA5C3C", Slot = "15")]
		protected virtual void CloseAllUIs()
		{
		}

		// Token: 0x0600BA1D RID: 47645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1D")]
		[Address(RVA = "0x13A5F34", Offset = "0x13A5F34", VA = "0x7BBBBA5F34")]
		private void OnHudSettingChanged(params object[] param)
		{
		}

		// Token: 0x0600BA1E RID: 47646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1E")]
		[Address(RVA = "0x13A6064", Offset = "0x13A6064", VA = "0x7BBBBA6064")]
		private void AdjustHudApperance(Type t)
		{
		}

		// Token: 0x0600BA1F RID: 47647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA1F")]
		[Address(RVA = "0x13A65FC", Offset = "0x13A65FC", VA = "0x7BBBBA65FC")]
		private void OnHudNormalSettingChanged(params object[] param)
		{
		}

		// Token: 0x0600BA20 RID: 47648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA20")]
		[Address(RVA = "0x13A6A24", Offset = "0x13A6A24", VA = "0x7BBBBA6A24")]
		private void OnReportCheatClick(params object[] param)
		{
		}

		// Token: 0x0600BA21 RID: 47649 RVA: 0x00034F50 File Offset: 0x00033150
		[Token(Token = "0x600BA21")]
		[Address(RVA = "0x13A6D78", Offset = "0x13A6D78", VA = "0x7BBBBA6D78")]
		private bool OnEscapeClick()
		{
			return default(bool);
		}

		// Token: 0x0600BA22 RID: 47650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA22")]
		[Address(RVA = "0x13A6E08", Offset = "0x13A6E08", VA = "0x7BBBBA6E08")]
		private void ShowBackToLobbyDialog()
		{
		}

		// Token: 0x0600BA23 RID: 47651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA23")]
		[Address(RVA = "0x13A7064", Offset = "0x13A7064", VA = "0x7BBBBA7064")]
		private void OnUIQuitGameRequest(params object[] param)
		{
		}

		// Token: 0x0600BA24 RID: 47652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA24")]
		[Address(RVA = "0x13A6F74", Offset = "0x13A6F74", VA = "0x7BBBBA6F74")]
		private void RequestQuitMatch()
		{
		}

		// Token: 0x0600BA25 RID: 47653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA25")]
		[Address(RVA = "0x13A7068", Offset = "0x13A7068", VA = "0x7BBBBA7068")]
		private void RoomSpectatorRequestQuitMatch(MatchGame game)
		{
		}

		// Token: 0x0600BA26 RID: 47654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA26")]
		[Address(RVA = "0x13A71A8", Offset = "0x13A71A8", VA = "0x7BBBBA71A8")]
		private void NormalPlayerRequestQuitMatch(MatchGame game)
		{
		}

		// Token: 0x0600BA27 RID: 47655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA27")]
		[Address(RVA = "0x13A786C", Offset = "0x13A786C", VA = "0x7BBBBA786C")]
		private void OnAddDetector(params object[] data)
		{
		}

		// Token: 0x0600BA28 RID: 47656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA28")]
		[Address(RVA = "0x13A7904", Offset = "0x13A7904", VA = "0x7BBBBA7904")]
		public void OnOpenTweenTips(params object[] data)
		{
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA29")]
		[Address(RVA = "0x13A7A80", Offset = "0x13A7A80", VA = "0x7BBBBA7A80")]
		public void OnLocalTeamFinishGame(params object[] data)
		{
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2A")]
		[Address(RVA = "0x13A7B18", Offset = "0x13A7B18", VA = "0x7BBBBA7B18")]
		private void SetEmotionPanelVisible(params object[] param)
		{
		}

		// Token: 0x0600BA2B RID: 47659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2B")]
		[Address(RVA = "0x13A7C44", Offset = "0x13A7C44", VA = "0x7BBBBA7C44")]
		private void CloseEmotionPanel(params object[] param)
		{
		}

		// Token: 0x0600BA2C RID: 47660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2C")]
		[Address(RVA = "0x13A7DCC", Offset = "0x13A7DCC", VA = "0x7BBBBA7DCC")]
		private void SetMessagePanelVisible(params object[] param)
		{
		}

		// Token: 0x0600BA2D RID: 47661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA2D")]
		[Address(RVA = "0x13A8110", Offset = "0x13A8110", VA = "0x7BBBBA8110")]
		private void CloseMessagePanel(params object[] param)
		{
		}

		// Token: 0x0600BA2E RID: 47662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA2E")]
		[Address(RVA = "0x13A81B4", Offset = "0x13A81B4", VA = "0x7BBBBA81B4")]
		private UIHudVehicleAsMissileTargetControllerBase OpenVehicleTargetUIInNeed(Entity e)
		{
			return null;
		}

		// Token: 0x0600BA2F RID: 47663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA2F")]
		private T OpenVehicleUIInNeed<TKEY, T>(TKEY v, ref Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
		{
			return null;
		}

		// Token: 0x0600BA30 RID: 47664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA30")]
		private TB OpenVehicleUIInNeed<TKEY, T, TB>(TKEY v, ref Dictionary<TKEY, TB> uis) where TKEY : Entity where T : !!2 where TB : UIHudVehiclePosControllerBase
		{
			return null;
		}

		// Token: 0x0600BA31 RID: 47665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA31")]
		private T GetVehicleUI<TKEY, T>(TKEY v, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
		{
			return null;
		}

		// Token: 0x0600BA32 RID: 47666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA32")]
		private void RecycleVehicleUI<TKEY, T>(TKEY v, T ui, Dictionary<TKEY, T> uis) where TKEY : Entity where T : UIHudVehiclePosControllerBase
		{
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA33")]
		[Address(RVA = "0x13A8250", Offset = "0x13A8250", VA = "0x7BBBBA8250")]
		private void OnPlayerGetOnVehicle(params object[] data)
		{
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA34")]
		[Address(RVA = "0x13A8350", Offset = "0x13A8350", VA = "0x7BBBBA8350")]
		private void CheckAndAddVehiclePosUIForPlayer(Player player)
		{
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA35")]
		[Address(RVA = "0x13A85C4", Offset = "0x13A85C4", VA = "0x7BBBBA85C4")]
		public void RecycleVehiclePosUI(Vehicle v, UIHudVehiclePosController ui)
		{
		}

		// Token: 0x0600BA36 RID: 47670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA36")]
		[Address(RVA = "0x13A8630", Offset = "0x13A8630", VA = "0x7BBBBA8630")]
		private void OnMissileTargetChange(params object[] data)
		{
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA37")]
		[Address(RVA = "0x13A8BD8", Offset = "0x13A8BD8", VA = "0x7BBBBA8BD8")]
		private void OnMissileAimingTargetChange(params object[] data)
		{
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA38")]
		[Address(RVA = "0x13A8EA4", Offset = "0x13A8EA4", VA = "0x7BBBBA8EA4")]
		public void RecycleMissileTargetUI(Entity v, UIHudVehicleAsMissileTargetControllerBase ui)
		{
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA39")]
		[Address(RVA = "0x13A8F10", Offset = "0x13A8F10", VA = "0x7BBBBA8F10")]
		public void OnMatchResultScreenshotRequest(params object[] data)
		{
		}

		// Token: 0x0600BA3A RID: 47674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3A")]
		[Address(RVA = "0x13A9198", Offset = "0x13A9198", VA = "0x7BBBBA9198")]
		private void OnLocalPlayerHitOthers(object[] data)
		{
		}

		// Token: 0x0600BA3B RID: 47675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3B")]
		[Address(RVA = "0x13A98C4", Offset = "0x13A98C4", VA = "0x7BBBBA98C4")]
		private void OnLocalPlayerHitObjects(object[] data)
		{
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3C")]
		[Address(RVA = "0x13A9A94", Offset = "0x13A9A94", VA = "0x7BBBBA9A94")]
		private void OnLocalPlayerHitPosition(object[] data)
		{
		}

		// Token: 0x0600BA3D RID: 47677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3D")]
		[Address(RVA = "0x13A9C9C", Offset = "0x13A9C9C", VA = "0x7BBBBA9C9C")]
		public void RecycleEnemyHudName({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA3E RID: 47678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3E")]
		[Address(RVA = "0x13A2A94", Offset = "0x13A2A94", VA = "0x7BBBBA2A94")]
		private void AddTeammateHud({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA3F RID: 47679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA3F")]
		[Address(RVA = "0x13A9EA8", Offset = "0x13A9EA8", VA = "0x7BBBBA9EA8")]
		public void RefreshFriendHudName(List<{QAb\u0082~u> friends)
		{
		}

		// Token: 0x0600BA40 RID: 47680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA40")]
		[Address(RVA = "0x13AA1A4", Offset = "0x13AA1A4", VA = "0x7BBBBAA1A4")]
		private void AddFriendHud({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA41 RID: 47681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA41")]
		[Address(RVA = "0x13A3D1C", Offset = "0x13A3D1C", VA = "0x7BBBBA3D1C")]
		private void RefreshTeammateHud(Dictionary<{QAb\u0082~u, Player> teammates)
		{
		}

		// Token: 0x0600BA42 RID: 47682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA42")]
		[Address(RVA = "0x13AA39C", Offset = "0x13AA39C", VA = "0x7BBBBAA39C")]
		public void RecycleTeammateHudName({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA43 RID: 47683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA43")]
		[Address(RVA = "0x13AA5A8", Offset = "0x13AA5A8", VA = "0x7BBBBAA5A8")]
		public void RecyleFriendHudName({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA44 RID: 47684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA44")]
		[Address(RVA = "0x13AA7B4", Offset = "0x13AA7B4", VA = "0x7BBBBAA7B4")]
		private void RefreshEnermyPoint(params object[] data)
		{
		}

		// Token: 0x0600BA45 RID: 47685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA45")]
		[Address(RVA = "0x13AACD4", Offset = "0x13AACD4", VA = "0x7BBBBAACD4")]
		private void RefreshCuringEnemyPoint(params object[] data)
		{
		}

		// Token: 0x0600BA46 RID: 47686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA46")]
		[Address(RVA = "0x13AB190", Offset = "0x13AB190", VA = "0x7BBBBAB190")]
		public void RefreshBanAvtiveSkillPoint(params object[] data)
		{
		}

		// Token: 0x0600BA47 RID: 47687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA47")]
		[Address(RVA = "0x13AB734", Offset = "0x13AB734", VA = "0x7BBBBAB734")]
		public void RecycleBanAvtiveSkillPoint({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA48 RID: 47688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA48")]
		[Address(RVA = "0x13AB890", Offset = "0x13AB890", VA = "0x7BBBBAB890")]
		public void RefreshDeliverySkillMarkEnemyPoint(params object[] data)
		{
		}

		// Token: 0x0600BA49 RID: 47689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA49")]
		[Address(RVA = "0x13ABABC", Offset = "0x13ABABC", VA = "0x7BBBBABABC")]
		public void ShowDeliveryMarkEnemyPoint(params object[] data)
		{
		}

		// Token: 0x0600BA4A RID: 47690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4A")]
		[Address(RVA = "0x13ABE68", Offset = "0x13ABE68", VA = "0x7BBBBABE68")]
		public void RecycleDeliveryMarkEnemyPoint({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA4B RID: 47691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4B")]
		[Address(RVA = "0x13ABFC4", Offset = "0x13ABFC4", VA = "0x7BBBBABFC4")]
		public void RecycleEnermyPoint({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA4C RID: 47692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4C")]
		[Address(RVA = "0x13AC120", Offset = "0x13AC120", VA = "0x7BBBBAC120")]
		public void RecycleCuringEnemyPoint({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA4D RID: 47693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4D")]
		[Address(RVA = "0x13AC27C", Offset = "0x13AC27C", VA = "0x7BBBBAC27C")]
		public void RefreshRevengeInfoPoint({QAb\u0082~u playerID, bool visible)
		{
		}

		// Token: 0x0600BA4E RID: 47694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4E")]
		[Address(RVA = "0x13AC474", Offset = "0x13AC474", VA = "0x7BBBBAC474")]
		public void RecycleRevengeInfoPoint({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA4F")]
		[Address(RVA = "0x13A4784", Offset = "0x13A4784", VA = "0x7BBBBA4784")]
		internal void RemoveNameHud({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA50")]
		[Address(RVA = "0x13AC5D0", Offset = "0x13AC5D0", VA = "0x7BBBBAC5D0")]
		private void ShowAirEPTopPlayer(params object[] param)
		{
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA51")]
		[Address(RVA = "0x13AC81C", Offset = "0x13AC81C", VA = "0x7BBBBAC81C")]
		private void HideEPRanking(params object[] param)
		{
		}

		// Token: 0x0600BA52 RID: 47698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA52")]
		[Address(RVA = "0x13AC95C", Offset = "0x13AC95C", VA = "0x7BBBBAC95C")]
		private void ShowHudElitePass(params object[] param)
		{
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA53")]
		[Address(RVA = "0x13ACA50", Offset = "0x13ACA50", VA = "0x7BBBBACA50")]
		public void OnRedEnvelopeUsed(params object[] param)
		{
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA54")]
		[Address(RVA = "0x13ACC64", Offset = "0x13ACC64", VA = "0x7BBBBACC64")]
		public void OnRedEnvelopeReceived(params object[] param)
		{
		}

		// Token: 0x0600BA55 RID: 47701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA55")]
		[Address(RVA = "0x13ACFA4", Offset = "0x13ACFA4", VA = "0x7BBBBACFA4")]
		public void OnRedEnvelopeReceiveHudDismiss(params object[] param)
		{
		}

		// Token: 0x0600BA56 RID: 47702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA56")]
		[Address(RVA = "0x13A95B0", Offset = "0x13A95B0", VA = "0x7BBBBA95B0")]
		public void OnHypeRelatedPlayerHit({QAb\u0082~u pID, int level)
		{
		}

		// Token: 0x0600BA57 RID: 47703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA57")]
		[Address(RVA = "0x13AD0A4", Offset = "0x13AD0A4", VA = "0x7BBBBAD0A4")]
		private void OnAddPet(params object[] data)
		{
		}

		// Token: 0x0600BA58 RID: 47704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA58")]
		[Address(RVA = "0x13AD2B4", Offset = "0x13AD2B4", VA = "0x7BBBBAD2B4")]
		private void OnPreloadLoaded(params object[] data)
		{
		}

		// Token: 0x0600BA59 RID: 47705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA59")]
		[Address(RVA = "0x13A2CC4", Offset = "0x13A2CC4", VA = "0x7BBBBA2CC4")]
		private void CheckToCloseHUDMask()
		{
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5A")]
		[Address(RVA = "0x13AD34C", Offset = "0x13AD34C", VA = "0x7BBBBAD34C")]
		private void OnJoinedVoiceRoom(params object[] data)
		{
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5B")]
		[Address(RVA = "0x13AD488", Offset = "0x13AD488", VA = "0x7BBBBAD488")]
		private void OnNotifyBeHinted(params object[] data)
		{
		}

		// Token: 0x0600BA5C RID: 47708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5C")]
		[Address(RVA = "0x13AD620", Offset = "0x13AD620", VA = "0x7BBBBAD620")]
		private void OnPVEBuyReviveSuccess(params object[] param)
		{
		}

		// Token: 0x0600BA5D RID: 47709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5D")]
		[Address(RVA = "0x13AD7B0", Offset = "0x13AD7B0", VA = "0x7BBBBAD7B0")]
		private void OnPlayerLanding(params object[] param)
		{
		}

		// Token: 0x0600BA5E RID: 47710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5E")]
		[Address(RVA = "0x13AD7B4", Offset = "0x13AD7B4", VA = "0x7BBBBAD7B4")]
		private void ShowCommonRewardWnd(object[] data)
		{
		}

		// Token: 0x0600BA5F RID: 47711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5F")]
		[Address(RVA = "0x13AD8D4", Offset = "0x13AD8D4", VA = "0x7BBBBAD8D4")]
		private void HidePVEReviveUI(params object[] param)
		{
		}

		// Token: 0x0600BA60 RID: 47712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA60")]
		[Address(RVA = "0x13AD978", Offset = "0x13AD978", VA = "0x7BBBBAD978", Slot = "16")]
		protected virtual void OnPlayerGodBegin(params object[] param)
		{
		}

		// Token: 0x0600BA61 RID: 47713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA61")]
		[Address(RVA = "0x13ADAC8", Offset = "0x13ADAC8", VA = "0x7BBBBADAC8")]
		public void DisableMask()
		{
		}

		// Token: 0x0600BA62 RID: 47714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA62")]
		[Address(RVA = "0x13ADB68", Offset = "0x13ADB68", VA = "0x7BBBBADB68")]
		private void ShowBlackMaskAnim(params object[] param)
		{
		}

		// Token: 0x0600BA63 RID: 47715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA63")]
		[Address(RVA = "0x13ADDAC", Offset = "0x13ADDAC", VA = "0x7BBBBADDAC")]
		protected void ShowLeaderboard(params object[] data)
		{
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA64")]
		[Address(RVA = "0x13ADE50", Offset = "0x13ADE50", VA = "0x7BBBBADE50")]
		protected void ShowCSShop(params object[] data)
		{
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA65")]
		[Address(RVA = "0x13AE164", Offset = "0x13AE164", VA = "0x7BBBBAE164")]
		private void OnMysteryBoxOpen(params object[] data)
		{
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA66")]
		[Address(RVA = "0x13AE5B0", Offset = "0x13AE5B0", VA = "0x7BBBBAE5B0")]
		private void OnCSShopClosed(params object[] data)
		{
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA67")]
		[Address(RVA = "0x13AE6C4", Offset = "0x13AE6C4", VA = "0x7BBBBAE6C4")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA68")]
		[Address(RVA = "0x13AE9D4", Offset = "0x13AE9D4", VA = "0x7BBBBAE9D4")]
		private void OnInGameShopItemsReady(params object[] data)
		{
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA69")]
		[Address(RVA = "0x13AEAC4", Offset = "0x13AEAC4", VA = "0x7BBBBAEAC4")]
		private void OnRangeShopShowed(params object[] data)
		{
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6A")]
		[Address(RVA = "0x13AECCC", Offset = "0x13AECCC", VA = "0x7BBBBAECCC")]
		private void OnCatagoryRangeShopShowed(params object[] data)
		{
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6B")]
		[Address(RVA = "0x13AF338", Offset = "0x13AF338", VA = "0x7BBBBAF338")]
		private void OnCatagoryRangeShopHided(params object[] data)
		{
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x00034F68 File Offset: 0x00033168
		[Token(Token = "0x600BA6C")]
		[Address(RVA = "0x13AF3DC", Offset = "0x13AF3DC", VA = "0x7BBBBAF3DC")]
		public bool TryOpenCacheShop(uint ShopID)
		{
			return default(bool);
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6D")]
		[Address(RVA = "0x13AF554", Offset = "0x13AF554", VA = "0x7BBBBAF554")]
		protected void OnShowPortalMask(params object[] data)
		{
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6E")]
		[Address(RVA = "0x13AF6F4", Offset = "0x13AF6F4", VA = "0x7BBBBAF6F4")]
		private void OnShowWarningZone(params object[] data)
		{
		}

		// Token: 0x0600BA6F RID: 47727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA6F")]
		[Address(RVA = "0x13AFA34", Offset = "0x13AFA34", VA = "0x7BBBBAFA34")]
		private void OnShowReviveSelect(params object[] data)
		{
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA70")]
		[Address(RVA = "0x13AFD0C", Offset = "0x13AFD0C", VA = "0x7BBBBAFD0C")]
		private void OnShowRevivePoint(params object[] param)
		{
		}

		// Token: 0x0600BA71 RID: 47729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA71")]
		[Address(RVA = "0x13AFFC8", Offset = "0x13AFFC8", VA = "0x7BBBBAFFC8")]
		private void OnRevivePointStateChanged(params object[] param)
		{
		}

		// Token: 0x0600BA72 RID: 47730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA72")]
		[Address(RVA = "0x13B00D0", Offset = "0x13B00D0", VA = "0x7BBBBB00D0")]
		private void OnRevivePointTimeChanged(params object[] param)
		{
		}

		// Token: 0x0600BA73 RID: 47731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA73")]
		[Address(RVA = "0x13B01D8", Offset = "0x13B01D8", VA = "0x7BBBBB01D8")]
		private void OnShowInGameChat(params object[] data)
		{
		}

		// Token: 0x0600BA74 RID: 47732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA74")]
		[Address(RVA = "0x13B06A8", Offset = "0x13B06A8", VA = "0x7BBBBB06A8")]
		private void OnShowAddFriendInfo(params object[] data)
		{
		}

		// Token: 0x0600BA75 RID: 47733 RVA: 0x00034F80 File Offset: 0x00033180
		[Token(Token = "0x600BA75")]
		[Address(RVA = "0x13B084C", Offset = "0x13B084C", VA = "0x7BBBBB084C")]
		public bool FriendInviteIsShowing()
		{
			return default(bool);
		}

		// Token: 0x0600BA76 RID: 47734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA76")]
		[Address(RVA = "0x13B08EC", Offset = "0x13B08EC", VA = "0x7BBBBB08EC")]
		public void ShowInviteFriendInfo(ulong user_id)
		{
		}

		// Token: 0x0600BA77 RID: 47735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA77")]
		[Address(RVA = "0x13B0AA4", Offset = "0x13B0AA4", VA = "0x7BBBBB0AA4")]
		public void OnShowDriftBottleAddFriend(params object[] param)
		{
		}

		// Token: 0x0600BA78 RID: 47736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA78")]
		[Address(RVA = "0x13B0D28", Offset = "0x13B0D28", VA = "0x7BBBBB0D28")]
		private void OnTrainingZoneChanged(params object[] data)
		{
		}

		// Token: 0x0600BA79 RID: 47737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA79")]
		[Address(RVA = "0x13B15A8", Offset = "0x13B15A8", VA = "0x7BBBBB15A8")]
		private void RefreshTeammateNameVisible(Player lp)
		{
		}

		// Token: 0x0600BA7A RID: 47738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7A")]
		[Address(RVA = "0x13B1308", Offset = "0x13B1308", VA = "0x7BBBBB1308")]
		private void RefreshPlayerRemainingVisble({Z|h[YF z)
		{
		}

		// Token: 0x0600BA7B RID: 47739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7B")]
		[Address(RVA = "0x13B0FE4", Offset = "0x13B0FE4", VA = "0x7BBBBB0FE4")]
		private void ShowEnterTrainingZoneTip({Z|h[YF z)
		{
		}

		// Token: 0x0600BA7C RID: 47740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7C")]
		[Address(RVA = "0x13B1AE4", Offset = "0x13B1AE4", VA = "0x7BBBBB1AE4")]
		private void OnTrainingShopBuySucess(params object[] data)
		{
		}

		// Token: 0x0600BA7D RID: 47741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7D")]
		[Address(RVA = "0x13B1CFC", Offset = "0x13B1CFC", VA = "0x7BBBBB1CFC")]
		private void OnTrainingShowCountDown(params object[] data)
		{
		}

		// Token: 0x0600BA7E RID: 47742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7E")]
		[Address(RVA = "0x13B1F40", Offset = "0x13B1F40", VA = "0x7BBBBB1F40")]
		private void OnGameOpeningStart(params object[] data)
		{
		}

		// Token: 0x0600BA7F RID: 47743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA7F")]
		[Address(RVA = "0x13B21CC", Offset = "0x13B21CC", VA = "0x7BBBBB21CC")]
		private void OnGameOpeningEnd(params object[] data)
		{
		}

		// Token: 0x0600BA80 RID: 47744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA80")]
		[Address(RVA = "0x13B2458", Offset = "0x13B2458", VA = "0x7BBBBB2458")]
		private void OnGameOpeningPlaySound(params object[] data)
		{
		}

		// Token: 0x0600BA81 RID: 47745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA81")]
		[Address(RVA = "0x13B27E8", Offset = "0x13B27E8", VA = "0x7BBBBB27E8")]
		public void ShowEventTriggerUIWithPlayer({QAb\u0082~u id, InGameTriggerMaskData data)
		{
		}

		// Token: 0x0600BA82 RID: 47746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA82")]
		[Address(RVA = "0x13B291C", Offset = "0x13B291C", VA = "0x7BBBBB291C")]
		public void ClearEventTriggerUIWithPlayer({QAb\u0082~u id, InGameTriggerMaskData data)
		{
		}

		// Token: 0x0600BA83 RID: 47747 RVA: 0x00034F98 File Offset: 0x00033198
		[Token(Token = "0x600BA83")]
		[Address(RVA = "0x13B2AEC", Offset = "0x13B2AEC", VA = "0x7BBBBB2AEC")]
		public bool CheckPrepareIsIng()
		{
			return default(bool);
		}

		// Token: 0x0600BA84 RID: 47748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA84")]
		[Address(RVA = "0x13B2BA4", Offset = "0x13B2BA4", VA = "0x7BBBBB2BA4")]
		public void ShowMarkItemUIWithWorldPosition({QAb\u0082~u id, uint markID, uint containerID, Vector3 itemPosition, int fixCount)
		{
		}

		// Token: 0x0600BA85 RID: 47749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA85")]
		[Address(RVA = "0x13B2E60", Offset = "0x13B2E60", VA = "0x7BBBBB2E60")]
		public void RemoveMarkItemShow({QAb\u0082~u id, uint itemID, uint containerID)
		{
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA86")]
		[Address(RVA = "0x13B2F9C", Offset = "0x13B2F9C", VA = "0x7BBBBB2F9C")]
		public void ForceRemoveMarkItemShow({QAb\u0082~u id)
		{
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA87")]
		[Address(RVA = "0x13B317C", Offset = "0x13B317C", VA = "0x7BBBBB317C")]
		public void ShowMarkItemChooseListWindow(LevelContainerBase container, bool isTriggerOpen, bool showAllInfo)
		{
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA88")]
		[Address(RVA = "0x13B32A0", Offset = "0x13B32A0", VA = "0x7BBBBB32A0")]
		public void ShowAssistantText(string playerName, string line)
		{
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA89")]
		[Address(RVA = "0x13B33B4", Offset = "0x13B33B4", VA = "0x7BBBBB33B4")]
		public void ShowEventTriggerUIWithWorldPosition(Vector3 followObjectPosition, InGameTriggerMaskData data)
		{
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA8A")]
		[Address(RVA = "0x13B34B4", Offset = "0x13B34B4", VA = "0x7BBBBB34B4")]
		public GameObject GetSpeedUpCollider()
		{
			return null;
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA8B")]
		[Address(RVA = "0x13ADFFC", Offset = "0x13ADFFC", VA = "0x7BBBBADFFC")]
		protected void HideCSShop()
		{
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x00034FB0 File Offset: 0x000331B0
		[Token(Token = "0x600BA8C")]
		[Address(RVA = "0x139BC28", Offset = "0x139BC28", VA = "0x7BBBB9BC28")]
		private bool NeedUseNewRoundTransition()
		{
			return default(bool);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA8D")]
		[Address(RVA = "0x13B3554", Offset = "0x13B3554", VA = "0x7BBBBB3554")]
		protected void ShowCSRoundResult(params object[] data)
		{
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA8E")]
		[Address(RVA = "0x13B3834", Offset = "0x13B3834", VA = "0x7BBBBB3834")]
		protected void ShowCSRoundSpectatorResult(params object[] data)
		{
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA8F")]
		[Address(RVA = "0x13B3838", Offset = "0x13B3838", VA = "0x7BBBBB3838")]
		private void OnSpectatorPlayerFlashed(params object[] data)
		{
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA90")]
		[Address(RVA = "0x13B39E4", Offset = "0x13B39E4", VA = "0x7BBBBB39E4")]
		private void OnShowWhiteScreen(params object[] ps)
		{
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA91")]
		public T GetUIControllerFromPool<T>(EUIAnchor anchor = EUIAnchor.None) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA92")]
		public void RecycleUIController<T>(T uicontroller) where T : UIBaseController
		{
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA93")]
		[Address(RVA = "0x13B3B3C", Offset = "0x13B3B3C", VA = "0x7BBBBB3B3C")]
		protected void ShowEquipSetSelection(params object[] param)
		{
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA94")]
		[Address(RVA = "0x13B3E54", Offset = "0x13B3E54", VA = "0x7BBBBB3E54")]
		protected void ShowEquipSetSelectionBtn(params object[] param)
		{
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA95")]
		[Address(RVA = "0x13B3F48", Offset = "0x13B3F48", VA = "0x7BBBBB3F48")]
		protected void OnSelectEquipSet(params object[] param)
		{
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA96")]
		[Address(RVA = "0x13B4028", Offset = "0x13B4028", VA = "0x7BBBBB4028")]
		private void OnPlayCutScene(object[] data)
		{
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA97")]
		[Address(RVA = "0x13B40F4", Offset = "0x13B40F4", VA = "0x7BBBBB40F4")]
		private void ShowOrHideAllUI(params object[] param)
		{
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA98")]
		[Address(RVA = "0x13B4328", Offset = "0x13B4328", VA = "0x7BBBBB4328")]
		private void OnSecondConfirmShowed(params object[] param)
		{
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA99")]
		[Address(RVA = "0x13B445C", Offset = "0x13B445C", VA = "0x7BBBBB445C")]
		private void OnHandleUpdateMapMark(params object[] data)
		{
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9A")]
		[Address(RVA = "0x13B4974", Offset = "0x13B4974", VA = "0x7BBBBB4974")]
		private void OnHandleRemoveMapMark(params object[] data)
		{
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9B")]
		[Address(RVA = "0x13B4AD4", Offset = "0x13B4AD4", VA = "0x7BBBBB4AD4")]
		private void OnHandleForceStopSkysurfing(params object[] data)
		{
		}

		// Token: 0x0600BA9C RID: 47772 RVA: 0x00034FC8 File Offset: 0x000331C8
		[Token(Token = "0x600BA9C")]
		[Address(RVA = "0x13B4C94", Offset = "0x13B4C94", VA = "0x7BBBBB4C94")]
		public ResourceID GetDamageNumResId()
		{
			return default(ResourceID);
		}

		// Token: 0x0600BA9D RID: 47773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BA9D")]
		[Address(RVA = "0x13B4D54", Offset = "0x13B4D54", VA = "0x7BBBBB4D54")]
		public GameObject GetDamageNumObject([Optional] Transform root)
		{
			return null;
		}

		// Token: 0x0600BA9E RID: 47774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9E")]
		[Address(RVA = "0x13B4E74", Offset = "0x13B4E74", VA = "0x7BBBBB4E74")]
		public void RecycleDamageNumObject(GameObject numObject)
		{
		}

		// Token: 0x0600BA9F RID: 47775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA9F")]
		[Address(RVA = "0x139F890", Offset = "0x139F890", VA = "0x7BBBB9F890")]
		private void PreLoadDamageNumObject()
		{
		}

		// Token: 0x0600BAA0 RID: 47776 RVA: 0x00034FE0 File Offset: 0x000331E0
		[Token(Token = "0x600BAA0")]
		[Address(RVA = "0x13B503C", Offset = "0x13B503C", VA = "0x7BBBBB503C")]
		public bool GetPickUpInScroll()
		{
			return default(bool);
		}

		// Token: 0x0600BAA1 RID: 47777 RVA: 0x00034FF8 File Offset: 0x000331F8
		[Token(Token = "0x600BAA1")]
		[Address(RVA = "0x13B50DC", Offset = "0x13B50DC", VA = "0x7BBBBB50DC")]
		public int GetPickUpListGridDepth()
		{
			return 0;
		}

		// Token: 0x0600BAA2 RID: 47778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAA2")]
		[Address(RVA = "0x13B510C", Offset = "0x13B510C", VA = "0x7BBBBB510C", Slot = "17")]
		protected virtual UIHudWeaponInfoController OpenCommonWeaponPanel()
		{
			return null;
		}

		// Token: 0x0600BAA3 RID: 47779 RVA: 0x00035010 File Offset: 0x00033210
		[Token(Token = "0x600BAA3")]
		[Address(RVA = "0x13B5160", Offset = "0x13B5160", VA = "0x7BBBBB5160", Slot = "18")]
		protected virtual bool IsNeedDirectionRuler()
		{
			return default(bool);
		}

		// Token: 0x0600BAA4 RID: 47780 RVA: 0x00035028 File Offset: 0x00033228
		[Token(Token = "0x600BAA4")]
		[Address(RVA = "0x13B5360", Offset = "0x13B5360", VA = "0x7BBBBB5360", Slot = "19")]
		protected virtual bool IsNeedQuickSwitchHUD()
		{
			return default(bool);
		}

		// Token: 0x0600BAA5 RID: 47781 RVA: 0x00035040 File Offset: 0x00033240
		[Token(Token = "0x600BAA5")]
		[Address(RVA = "0x13B53CC", Offset = "0x13B53CC", VA = "0x7BBBBB53CC", Slot = "20")]
		protected virtual bool IsNeedMedkitController()
		{
			return default(bool);
		}

		// Token: 0x0600BAA6 RID: 47782 RVA: 0x00035058 File Offset: 0x00033258
		[Token(Token = "0x600BAA6")]
		[Address(RVA = "0x13B5464", Offset = "0x13B5464", VA = "0x7BBBBB5464", Slot = "21")]
		protected virtual bool IsNeedSafeZoneInfoController()
		{
			return default(bool);
		}

		// Token: 0x0600BAA7 RID: 47783 RVA: 0x00035070 File Offset: 0x00033270
		[Token(Token = "0x600BAA7")]
		[Address(RVA = "0x139E69C", Offset = "0x139E69C", VA = "0x7BBBB9E69C")]
		private bool IsNeedShowGamePhaseCountdownUI()
		{
			return default(bool);
		}

		// Token: 0x0600BAA8 RID: 47784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA8")]
		[Address(RVA = "0x13B561C", Offset = "0x13B561C", VA = "0x7BBBBB561C", Slot = "22")]
		public virtual void ShowCommonEquipSelectionController(bool show, int defaultSelectIndex, float showTime)
		{
		}

		// Token: 0x0600BAA9 RID: 47785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAA9")]
		[Address(RVA = "0x13B5754", Offset = "0x13B5754", VA = "0x7BBBBB5754", Slot = "23")]
		public virtual void ShowEquipUnlockLevelController(bool show, float showTime)
		{
		}

		// Token: 0x0600BAAA RID: 47786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAA")]
		[Address(RVA = "0x13B5884", Offset = "0x13B5884", VA = "0x7BBBBB5884")]
		public void ShowTeamKill(float showTime)
		{
		}

		// Token: 0x0600BAAB RID: 47787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAB")]
		[Address(RVA = "0x13B598C", Offset = "0x13B598C", VA = "0x7BBBBB598C")]
		public void ShowPlayerAttributeUP(string msg)
		{
		}

		// Token: 0x0600BAAC RID: 47788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAC")]
		[Address(RVA = "0x13B5A9C", Offset = "0x13B5A9C", VA = "0x7BBBBB5A9C")]
		public void GamePhaseChange(uint curPhase, float leftTime, bool isExitPregame)
		{
		}

		// Token: 0x0600BAAD RID: 47789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAD")]
		[Address(RVA = "0x13B5C7C", Offset = "0x13B5C7C", VA = "0x7BBBBB5C7C", Slot = "24")]
		protected virtual void OnGamePhaseChange(uint curPhase, float leftTime)
		{
		}

		// Token: 0x0600BAAE RID: 47790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAE")]
		[Address(RVA = "0x13B5B2C", Offset = "0x13B5B2C", VA = "0x7BBBBB5B2C")]
		private void OpenHudInPregame()
		{
		}

		// Token: 0x0600BAAF RID: 47791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAAF")]
		[Address(RVA = "0x13B5BD8", Offset = "0x13B5BD8", VA = "0x7BBBBB5BD8")]
		private void CloseHudInPregame()
		{
		}

		// Token: 0x0600BAB0 RID: 47792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB0")]
		[Address(RVA = "0x13B5C80", Offset = "0x13B5C80", VA = "0x7BBBBB5C80", Slot = "25")]
		protected virtual void OnOpenHudInPregame()
		{
		}

		// Token: 0x0600BAB1 RID: 47793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB1")]
		[Address(RVA = "0x13B5C84", Offset = "0x13B5C84", VA = "0x7BBBBB5C84", Slot = "26")]
		protected virtual void OnClosePregameHud()
		{
		}

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB2")]
		[Address(RVA = "0x13B5C88", Offset = "0x13B5C88", VA = "0x7BBBBB5C88", Slot = "27")]
		protected virtual void OnOpenHudBeginFight()
		{
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BAB3")]
		[Address(RVA = "0x13B5C8C", Offset = "0x13B5C8C", VA = "0x7BBBBB5C8C", Slot = "28")]
		protected virtual Type GetMatchEndShowHUD()
		{
			return null;
		}

		// Token: 0x0600BAB4 RID: 47796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB4")]
		[Address(RVA = "0x13B5CFC", Offset = "0x13B5CFC", VA = "0x7BBBBB5CFC")]
		public void ShowOrHideEnterPhotographModeController(bool isShow)
		{
		}

		// Token: 0x0600BAB5 RID: 47797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB5")]
		[Address(RVA = "0x13B5E1C", Offset = "0x13B5E1C", VA = "0x7BBBBB5E1C")]
		public void ShowOrHidePhotographModeController(bool isShow)
		{
		}

		// Token: 0x0600BAB6 RID: 47798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB6")]
		[Address(RVA = "0x13B5F60", Offset = "0x13B5F60", VA = "0x7BBBBB5F60")]
		public void ShowOrHidePhotographEmotePanel(bool isShow)
		{
		}

		// Token: 0x0600BAB7 RID: 47799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB7")]
		[Address(RVA = "0x13B60B8", Offset = "0x13B60B8", VA = "0x7BBBBB60B8")]
		public void ShowOrHideBountyWaitingBossHP(bool isShow)
		{
		}

		// Token: 0x0600BAB8 RID: 47800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB8")]
		[Address(RVA = "0x13B6210", Offset = "0x13B6210", VA = "0x7BBBBB6210")]
		public void OpenBountyBossInfoController()
		{
		}

		// Token: 0x0600BAB9 RID: 47801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAB9")]
		[Address(RVA = "0x13B629C", Offset = "0x13B629C", VA = "0x7BBBBB629C")]
		private void OnTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x0600BABA RID: 47802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABA")]
		[Address(RVA = "0x13B6FA0", Offset = "0x13B6FA0", VA = "0x7BBBBB6FA0")]
		private void OnGamePaused(params object[] param)
		{
		}

		// Token: 0x0600BABB RID: 47803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BABB")]
		[Address(RVA = "0x13B7198", Offset = "0x13B7198", VA = "0x7BBBBB7198")]
		private void OnRequestGameResumeConfirm(params object[] param)
		{
		}

		// Token: 0x0600BABC RID: 47804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BABC")]
		[Address(RVA = "0x13B6DFC", Offset = "0x13B6DFC", VA = "0x7BBBBB6DFC")]
		private string GetLocalTeamParachuteLeaderName()
		{
			return null;
		}

		// Token: 0x0600BABD RID: 47805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BABD")]
		public T OpenUIInternal<T>(Transform parent, Vector3 localPosition, EUIAnchor anchor) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x0600BABE RID: 47806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600BABE")]
		protected T OpenUIFromConfig<T>(Transform parent) where T : UIBaseController
		{
			return null;
		}

		// Token: 0x0600BABF RID: 47807 RVA: 0x00035088 File Offset: 0x00033288
		[Token(Token = "0x600BABF")]
		protected Vector3 GetPositionFromConfig<T>() where T : UIBaseController
		{
			return default(Vector3);
		}

		// Token: 0x0600BAC0 RID: 47808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC0")]
		protected void OverrideGroupSettings<T>(uint[] bs)
		{
		}

		// Token: 0x0600BAC2 RID: 47810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC2")]
		[Address(RVA = "0x13B82BC", Offset = "0x13B82BC", VA = "0x7BBBBB82BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147BC4", Offset = "0x1147BC4")]
		private void <OpenCommonHud>b__120_0()
		{
		}

		// Token: 0x0600BAC3 RID: 47811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC3")]
		[Address(RVA = "0x13B834C", Offset = "0x13B834C", VA = "0x7BBBBB834C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147BD4", Offset = "0x1147BD4")]
		private void <OpenCommonHud>b__120_1()
		{
		}

		// Token: 0x0600BAC4 RID: 47812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC4")]
		[Address(RVA = "0x13B83DC", Offset = "0x13B83DC", VA = "0x7BBBBB83DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147BE4", Offset = "0x1147BE4")]
		private void <OpenCommonHud>b__120_2()
		{
		}

		// Token: 0x0600BAC5 RID: 47813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC5")]
		[Address(RVA = "0x13B846C", Offset = "0x13B846C", VA = "0x7BBBBB846C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147BF4", Offset = "0x1147BF4")]
		private void <OpenCommonHud>b__120_3()
		{
		}

		// Token: 0x0600BAC6 RID: 47814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC6")]
		[Address(RVA = "0x13B85B0", Offset = "0x13B85B0", VA = "0x7BBBBB85B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147C04", Offset = "0x1147C04")]
		private void <OpenCommonHud>b__120_4()
		{
		}

		// Token: 0x0600BAC7 RID: 47815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC7")]
		[Address(RVA = "0x13B86AC", Offset = "0x13B86AC", VA = "0x7BBBBB86AC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147C14", Offset = "0x1147C14")]
		private void <OnAddPlayer>b__145_0()
		{
		}

		// Token: 0x0600BAC8 RID: 47816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC8")]
		[Address(RVA = "0x13B86E0", Offset = "0x13B86E0", VA = "0x7BBBBB86E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147C24", Offset = "0x1147C24")]
		private void <CheckStreamReady>b__151_0()
		{
		}

		// Token: 0x0600BAC9 RID: 47817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BAC9")]
		[Address(RVA = "0x13B88C4", Offset = "0x13B88C4", VA = "0x7BBBBB88C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147C34", Offset = "0x1147C34")]
		private void <OnShowMatchResult>b__156_0()
		{
		}

		// Token: 0x0600BACA RID: 47818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BACA")]
		[Address(RVA = "0x13B89E4", Offset = "0x13B89E4", VA = "0x7BBBBB89E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1147C44", Offset = "0x1147C44")]
		private void <OnGameOpeningEnd>b__266_0()
		{
		}

		// Token: 0x0400BB85 RID: 48005
		[Token(Token = "0x400BB85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private UIHudPopupController m_LastPopupController;

		// Token: 0x0400BB86 RID: 48006
		[Token(Token = "0x400BB86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private UIHudPopupController m_LastLowPopupController;

		// Token: 0x0400BB87 RID: 48007
		[Token(Token = "0x400BB87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UIHudTweenTipsController m_TweenTipsController;

		// Token: 0x0400BB88 RID: 48008
		[Token(Token = "0x400BB88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UIHudSpecialPopupController m_LastSpecialPopupController;

		// Token: 0x0400BB89 RID: 48009
		[Token(Token = "0x400BB89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UIHudDynamicInfoPopupController m_LastDynamicPopupController;

		// Token: 0x0400BB8A RID: 48010
		[Token(Token = "0x400BB8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIHudTeammatesInfoController m_TeamInfoUI;

		// Token: 0x0400BB8B RID: 48011
		[Token(Token = "0x400BB8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIHudSpeedRoyaleTeammatesInfoController m_SpeedRoyalTeamInfoUI;

		// Token: 0x0400BB8C RID: 48012
		[Token(Token = "0x400BB8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIHudEmotionController m_EmotionCtrl;

		// Token: 0x0400BB8D RID: 48013
		[Token(Token = "0x400BB8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIHudMessageController m_MessageCtrl;

		// Token: 0x0400BB8E RID: 48014
		[Token(Token = "0x400BB8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private GameObject m_BlackScreen;

		// Token: 0x0400BB8F RID: 48015
		[Token(Token = "0x400BB8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Dictionary<{QAb\u0082~u, UIBaseController> m_PlayerNames;

		// Token: 0x0400BB90 RID: 48016
		[Token(Token = "0x400BB90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Dictionary<{QAb\u0082~u, UIBaseController> m_EnemyNames;

		// Token: 0x0400BB91 RID: 48017
		[Token(Token = "0x400BB91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<{QAb\u0082~u, UIBaseController> m_FriendNames;

		// Token: 0x0400BB92 RID: 48018
		[Token(Token = "0x400BB92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Dictionary<{QAb\u0082~u, UIHudChatBoxController> m_PlayerChats;

		// Token: 0x0400BB93 RID: 48019
		[Token(Token = "0x400BB93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<uint, UIBaseController> m_ObjectNames;

		// Token: 0x0400BB94 RID: 48020
		[Token(Token = "0x400BB94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Dictionary<{QAb\u0082~u, UIHudNameRedEnvelopeOwnerController> m_RedEnvelopeOwners;

		// Token: 0x0400BB95 RID: 48021
		[Token(Token = "0x400BB95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Dictionary<{QAb\u0082~u, UIHudEnermyPointController> m_EnermyPoints;

		// Token: 0x0400BB96 RID: 48022
		[Token(Token = "0x400BB96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Dictionary<{QAb\u0082~u, UIHudEnermyPointController> m_BanActiveSkillPoints;

		// Token: 0x0400BB97 RID: 48023
		[Token(Token = "0x400BB97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Dictionary<{QAb\u0082~u, UIHudEnermyPointController> m_DeliveryMarkEnemyPoints;

		// Token: 0x0400BB98 RID: 48024
		[Token(Token = "0x400BB98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Dictionary<{QAb\u0082~u, UIHudEnermyPointController> m_CuringEnemyPoints;

		// Token: 0x0400BB99 RID: 48025
		[Token(Token = "0x400BB99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Dictionary<{QAb\u0082~u, UIHudRevengeInfoPointController> m_RevengeInfoPoints;

		// Token: 0x0400BB9A RID: 48026
		[Token(Token = "0x400BB9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Dictionary<{QAb\u0082~u, UIHudItemMarkShowController> m_AssistantItemMarks;

		// Token: 0x0400BB9B RID: 48027
		[Token(Token = "0x400BB9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Dictionary<{QAb\u0082~u, UIHudMapMarkController> m_TeammateMapMarks;

		// Token: 0x0400BB9C RID: 48028
		[Token(Token = "0x400BB9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Dictionary<uint, UIHudRevivePointPosMarkController> m_RevivePointMarks;

		// Token: 0x0400BB9D RID: 48029
		[Token(Token = "0x400BB9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected UIHudPVEAutoReviveController m_HudPVEReviveInfoCtrl;

		// Token: 0x0400BB9E RID: 48030
		[Token(Token = "0x400BB9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected UIHUDPlayerGodBarController m_HUDPlayerGodInfoCtrl;

		// Token: 0x0400BB9F RID: 48031
		[Token(Token = "0x400BB9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private UIHudWhiteScreenController m_WhiteScreenCtrl;

		// Token: 0x0400BBA0 RID: 48032
		[Token(Token = "0x400BBA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private UIHudEnemyHypeLevelController m_HudEnemyHypeLevel;

		// Token: 0x0400BBA1 RID: 48033
		[Token(Token = "0x400BBA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected UIHudMinimapController m_MiniMapController;

		// Token: 0x0400BBA2 RID: 48034
		[Token(Token = "0x400BBA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private UIHudMatchEndShowTimeControllerBase m_MatchEndShowTimeController;

		// Token: 0x0400BBA3 RID: 48035
		[Token(Token = "0x400BBA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIHudManualTipsController m_ManualTipsController;

		// Token: 0x0400BBA4 RID: 48036
		[Token(Token = "0x400BBA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected UIBaseController m_LeaderboardController;

		// Token: 0x0400BBA5 RID: 48037
		[Token(Token = "0x400BBA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private UIHudGamePauseController m_GamePauseCtrl;

		// Token: 0x0400BBA6 RID: 48038
		[Token(Token = "0x400BBA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private UIHudCSShopController m_CSShopController;

		// Token: 0x0400BBA7 RID: 48039
		[Token(Token = "0x400BBA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private UIHudCSShopMysteryBoxOpenController m_MysteryBoxOpenController;

		// Token: 0x0400BBA8 RID: 48040
		[Token(Token = "0x400BBA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected UIHudBaseCSRoundResultController m_CSRoundResultController;

		// Token: 0x0400BBA9 RID: 48041
		[Token(Token = "0x400BBA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected UIHudRoundTransitionController m_RoundTransitionController;

		// Token: 0x0400BBAA RID: 48042
		[Token(Token = "0x400BBAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		protected UIHudCSFactionController m_CSFactionController;

		// Token: 0x0400BBAB RID: 48043
		[Token(Token = "0x400BBAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected UIHudCSShopEntryController m_CSShopEntryCtrl;

		// Token: 0x0400BBAC RID: 48044
		[Token(Token = "0x400BBAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected bool mLoadingMaskClosed;

		// Token: 0x0400BBAD RID: 48045
		[Token(Token = "0x400BBAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private UIHudWeaponInfoController m_HudWeaponInfoController;

		// Token: 0x0400BBAE RID: 48046
		[Token(Token = "0x400BBAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private UIHudAssistantTextController m_HudAssistantTextController;

		// Token: 0x0400BBAF RID: 48047
		[Token(Token = "0x400BBAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private UIHudPickupListController m_HudPickUpListController;

		// Token: 0x0400BBB0 RID: 48048
		[Token(Token = "0x400BBB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		protected UIEquipSetSelectionController m_UIEquipSetSelectionController;

		// Token: 0x0400BBB1 RID: 48049
		[Token(Token = "0x400BBB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private UIHudItemMarkGridWndController m_HudItemMarkGridWndController;

		// Token: 0x0400BBB2 RID: 48050
		[Token(Token = "0x400BBB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private UIHudRangeShopController m_HudRangeShopController;

		// Token: 0x0400BBB3 RID: 48051
		[Token(Token = "0x400BBB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private UIHudCatagoryRangeShopController m_HudCatagoryRangeShopController;

		// Token: 0x0400BBB4 RID: 48052
		[Token(Token = "0x400BBB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private UIHudPortalMaskController m_HudPortalMaskController;

		// Token: 0x0400BBB5 RID: 48053
		[Token(Token = "0x400BBB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private UIHudFriendAddController m_HudFriendAddController;

		// Token: 0x0400BBB6 RID: 48054
		[Token(Token = "0x400BBB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private UIHudFriendInviteController m_HudFriendInviteController;

		// Token: 0x0400BBB7 RID: 48055
		[Token(Token = "0x400BBB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private UIHudDriftBottleAddFriendController m_HudDriftBottleAddFriend;

		// Token: 0x0400BBB8 RID: 48056
		[Token(Token = "0x400BBB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private UIHudTrainingConfirmController m_TrainingConfirmCtrl;

		// Token: 0x0400BBB9 RID: 48057
		[Token(Token = "0x400BBB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private UIHudAuxFireController m_AuxfireCtrl;

		// Token: 0x0400BBBA RID: 48058
		[Token(Token = "0x400BBBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private UIHudSwapWeaponQuickController m_SweapWeaponQuickController;

		// Token: 0x0400BBBB RID: 48059
		[Token(Token = "0x400BBBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private UIHudReloadBtnController m_ReloadBtnController;

		// Token: 0x0400BBBC RID: 48060
		[Token(Token = "0x400BBBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private UIHudTriggerGrenadeController m_TriggerGrenadeCtrl;

		// Token: 0x0400BBBD RID: 48061
		[Token(Token = "0x400BBBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private UIHudPreparationTimerController m_PrepareCtrl;

		// Token: 0x0400BBBE RID: 48062
		[Token(Token = "0x400BBBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		protected UIHudCrosshairsController m_CrossHairCtrl;

		// Token: 0x0400BBBF RID: 48063
		[Token(Token = "0x400BBBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		protected UIHudFireController m_FireController;

		// Token: 0x0400BBC0 RID: 48064
		[Token(Token = "0x400BBC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private UIHudPlayerRemainingInfoController m_PlayerRemainingInfoCtrl;

		// Token: 0x0400BBC1 RID: 48065
		[Token(Token = "0x400BBC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		protected UIHud2TeamsTimeScoreController m_UIHud2TeamsTimeScoreController;

		// Token: 0x0400BBC2 RID: 48066
		[Token(Token = "0x400BBC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private UIHudCSMatchInfoController m_CSMatchInfoInfoCtrl;

		// Token: 0x0400BBC3 RID: 48067
		[Token(Token = "0x400BBC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		protected UIHudInGameShopController m_InGameShopCtrl;

		// Token: 0x0400BBC4 RID: 48068
		[Token(Token = "0x400BBC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		protected UIHudReviveSelectController m_ReviveSelectController;

		// Token: 0x0400BBC5 RID: 48069
		[Token(Token = "0x400BBC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		protected UIHudChatBtnController m_ChatBtnController;

		// Token: 0x0400BBC6 RID: 48070
		[Token(Token = "0x400BBC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool m_IsMatchEendShow;

		// Token: 0x0400BBC7 RID: 48071
		[Token(Token = "0x400BBC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private UIInGameScene.EMapStateType m_MapState;

		// Token: 0x0400BBC8 RID: 48072
		[Token(Token = "0x400BBC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		public readonly Vector3 fixedAuxFireButtonPox;

		// Token: 0x0400BBC9 RID: 48073
		[Token(Token = "0x400BBC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		protected Transform m_UiHudPanelDynamic;

		// Token: 0x0400BBCA RID: 48074
		[Token(Token = "0x400BBCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		protected Transform m_UiHudPanelStatic;

		// Token: 0x0400BBCB RID: 48075
		[Token(Token = "0x400BBCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private UIElitePassTopPlayerLeftWingController m_LeftWingCtrl;

		// Token: 0x0400BBCC RID: 48076
		[Token(Token = "0x400BBCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private UIElitePassTopPlayerRightWingController m_RightWingCtrl;

		// Token: 0x0400BBCD RID: 48077
		[Token(Token = "0x400BBCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private UIElitePassIngameHudRankingController m_EPHudRankingCtrl;

		// Token: 0x0400BBCE RID: 48078
		[Token(Token = "0x400BBCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private UIHudJetFlyController m_JetFlyCtrl;

		// Token: 0x0400BBCF RID: 48079
		[Token(Token = "0x400BBCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private UIHudJetFlyUpController m_JetFlyUpCtrl;

		// Token: 0x0400BBD0 RID: 48080
		[Token(Token = "0x400BBD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private UIHudJetFlyDownController m_JetFlyDownCtrl;

		// Token: 0x0400BBD1 RID: 48081
		[Token(Token = "0x400BBD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		protected UIHudSpeedupAreaController m_SpeedUpCtrl;

		// Token: 0x0400BBD2 RID: 48082
		[Token(Token = "0x400BBD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private UIHudGameVoiceController m_GameVoiceCtrl;

		// Token: 0x0400BBD3 RID: 48083
		[Token(Token = "0x400BBD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private Coroutine m_OpenMatchResultCor;

		// Token: 0x0400BBD4 RID: 48084
		[Token(Token = "0x400BBD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private UIHudBeHintedController m_HintedCtrl;

		// Token: 0x0400BBD5 RID: 48085
		[Token(Token = "0x400BBD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private UIHudPlayerStatsController m_PlayerStatsCtrl;

		// Token: 0x0400BBD6 RID: 48086
		[Token(Token = "0x400BBD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private UIHudShowCaseIntroductionController m_ShowCaseIntroductionCtrl;

		// Token: 0x0400BBD7 RID: 48087
		[Token(Token = "0x400BBD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private UIHUDPVEGameCountdownController m_TrainingEndCountDownCtrl;

		// Token: 0x0400BBD8 RID: 48088
		[Token(Token = "0x400BBD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private UniqueIDGenerator m_UniqueIDGen;

		// Token: 0x0400BBD9 RID: 48089
		[Token(Token = "0x400BBD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private UIHudCommonPregameTimeTipController m_UIHudCommonPregameTimeTipController;

		// Token: 0x0400BBDA RID: 48090
		[Token(Token = "0x400BBDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private GameObject m_HudNoobPopup;

		// Token: 0x0400BBDB RID: 48091
		[Token(Token = "0x400BBDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private bool m_HadBasicPopShow;

		// Token: 0x0400BBDC RID: 48092
		[Token(Token = "0x400BBDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x339")]
		private bool m_LocalPlayerAdded;

		// Token: 0x0400BBDD RID: 48093
		[Token(Token = "0x400BBDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33A")]
		private bool m_PreloadLoaded;

		// Token: 0x0400BBDE RID: 48094
		[Token(Token = "0x400BBDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33B")]
		private bool m_DirverFireHudOpened;

		// Token: 0x0400BBDF RID: 48095
		[Token(Token = "0x400BBDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		private bool m_PassengerSkillHudOpened;

		// Token: 0x0400BBE0 RID: 48096
		[Token(Token = "0x400BBE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Dictionary<Vehicle, UIHudVehiclePosController> m_VehiclePositions;

		// Token: 0x0400BBE1 RID: 48097
		[Token(Token = "0x400BBE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private Dictionary<Entity, UIHudVehicleAsMissileTargetControllerBase> m_VehicleTargets;

		// Token: 0x0400BBE2 RID: 48098
		[Token(Token = "0x400BBE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private UIHudLockedWarningController m_LockedWarningController;

		// Token: 0x0400BBE3 RID: 48099
		[Token(Token = "0x400BBE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private uint m_HideCSShopDelayCallID;

		// Token: 0x0400BBE4 RID: 48100
		[Token(Token = "0x400BBE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private Dictionary<Type, Queue<UIBaseController>> m_InGameUIPoolDic;

		// Token: 0x0400BBE5 RID: 48101
		[Token(Token = "0x400BBE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private UIHUDCommonEquipSetSelectionController m_CommonEquipSetSelectionCtrl;

		// Token: 0x0400BBE6 RID: 48102
		[Token(Token = "0x400BBE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private UIHUDEquipUnlockLevelController m_EquipUnlockLevelController;

		// Token: 0x0400BBE7 RID: 48103
		[Token(Token = "0x400BBE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private UIHUDTeamKillController m_TeamKillController;

		// Token: 0x0400BBE8 RID: 48104
		[Token(Token = "0x400BBE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		public UIHUDPlayerAttributeUpController m_AttributeUpController;

		// Token: 0x0400BBE9 RID: 48105
		[Token(Token = "0x400BBE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private bool m_HasOpenHudBeginFight;

		// Token: 0x0400BBEA RID: 48106
		[Token(Token = "0x400BBEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private EnterPhotographModeController m_EnterPhotographModeController;

		// Token: 0x0400BBEB RID: 48107
		[Token(Token = "0x400BBEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private PhotographModeController m_PhotographModeController;

		// Token: 0x0400BBEC RID: 48108
		[Token(Token = "0x400BBEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private UIHUDPhotographEmoteController m_PhotographEmoteController;

		// Token: 0x0400BBED RID: 48109
		[Token(Token = "0x400BBED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private ulong preEnterPhotographModeUIGroup;

		// Token: 0x0400BBEE RID: 48110
		[Token(Token = "0x400BBEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private BountyBossHPController m_BountyBossHPController;

		// Token: 0x0400BBEF RID: 48111
		[Token(Token = "0x400BBEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private UIHUDTeamParachuteActionController m_TeamParachuteController;

		// Token: 0x0400BBF0 RID: 48112
		[Token(Token = "0x400BBF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private UIHUDCenterUpTitleController m_CenterUpTitleController;

		// Token: 0x0400BBF1 RID: 48113
		[Token(Token = "0x400BBF1")]
		public const int UIGroup_Num = 32;

		// Token: 0x0400BBF2 RID: 48114
		[Token(Token = "0x400BBF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		protected Dictionary<Type, uint[]> GROUP_SETTING;

		// Token: 0x0400BBF3 RID: 48115
		[Token(Token = "0x400BBF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static Dictionary<Type, string> IngameHudConfigMapping;

		// Token: 0x02002081 RID: 8321
		[Token(Token = "0x2002081")]
		public enum EMapStateType
		{
			// Token: 0x0400BBF5 RID: 48117
			[Token(Token = "0x400BBF5")]
			MiniMap,
			// Token: 0x0400BBF6 RID: 48118
			[Token(Token = "0x400BBF6")]
			BigMap,
			// Token: 0x0400BBF7 RID: 48119
			[Token(Token = "0x400BBF7")]
			SideMap
		}

		// Token: 0x02002082 RID: 8322
		[Token(Token = "0x2002082")]
		public enum EUIGroup : ulong
		{
			// Token: 0x0400BBF9 RID: 48121
			[Token(Token = "0x400BBF9")]
			UIGroup_InGameNormal = 1UL,
			// Token: 0x0400BBFA RID: 48122
			[Token(Token = "0x400BBFA")]
			UIGroup_Inventory,
			// Token: 0x0400BBFB RID: 48123
			[Token(Token = "0x400BBFB")]
			UIGroup_Driver = 4UL,
			// Token: 0x0400BBFC RID: 48124
			[Token(Token = "0x400BBFC")]
			UIGroup_Passenger = 8UL,
			// Token: 0x0400BBFD RID: 48125
			[Token(Token = "0x400BBFD")]
			UIGroup_Skydiving = 16UL,
			// Token: 0x0400BBFE RID: 48126
			[Token(Token = "0x400BBFE")]
			UIGroup_Sighting = 32UL,
			// Token: 0x0400BBFF RID: 48127
			[Token(Token = "0x400BBFF")]
			UIGroup_MatchEnd = 64UL,
			// Token: 0x0400BC00 RID: 48128
			[Token(Token = "0x400BC00")]
			UIGroup_HideAll = 128UL,
			// Token: 0x0400BC01 RID: 48129
			[Token(Token = "0x400BC01")]
			UIGroup_BIGMAP = 256UL,
			// Token: 0x0400BC02 RID: 48130
			[Token(Token = "0x400BC02")]
			UIGroup_Observer = 512UL,
			// Token: 0x0400BC03 RID: 48131
			[Token(Token = "0x400BC03")]
			UIGroup_KnockDown = 1024UL,
			// Token: 0x0400BC04 RID: 48132
			[Token(Token = "0x400BC04")]
			UIGroup_SpectatorFixed = 2048UL,
			// Token: 0x0400BC05 RID: 48133
			[Token(Token = "0x400BC05")]
			UIGroup_SpectatorFree = 4096UL,
			// Token: 0x0400BC06 RID: 48134
			[Token(Token = "0x400BC06")]
			UIGroup_OnStrop = 8192UL,
			// Token: 0x0400BC07 RID: 48135
			[Token(Token = "0x400BC07")]
			UIGroup_RoomObserver = 16384UL,
			// Token: 0x0400BC08 RID: 48136
			[Token(Token = "0x400BC08")]
			UIGroup_InJetFly = 32768UL,
			// Token: 0x0400BC09 RID: 48137
			[Token(Token = "0x400BC09")]
			UIGroup_ActiveSkill = 65536UL,
			// Token: 0x0400BC0A RID: 48138
			[Token(Token = "0x400BC0A")]
			UIGroup_PendingRevive = 131072UL,
			// Token: 0x0400BC0B RID: 48139
			[Token(Token = "0x400BC0B")]
			UIGroup_OnSeat = 262144UL,
			// Token: 0x0400BC0C RID: 48140
			[Token(Token = "0x400BC0C")]
			UIGroup_OnCatapult = 524288UL,
			// Token: 0x0400BC0D RID: 48141
			[Token(Token = "0x400BC0D")]
			UIGroup_CatapultFalling = 1048576UL,
			// Token: 0x0400BC0E RID: 48142
			[Token(Token = "0x400BC0E")]
			UIGroup_PendingReviveReborn = 2097152UL,
			// Token: 0x0400BC0F RID: 48143
			[Token(Token = "0x400BC0F")]
			UIGroup_InFoldWing = 4194304UL,
			// Token: 0x0400BC10 RID: 48144
			[Token(Token = "0x400BC10")]
			UIGroup_Skateboarding = 8388608UL,
			// Token: 0x0400BC11 RID: 48145
			[Token(Token = "0x400BC11")]
			UIGroup_SnowMan = 16777216UL,
			// Token: 0x0400BC12 RID: 48146
			[Token(Token = "0x400BC12")]
			UIGroup_Cutscene = 33554432UL,
			// Token: 0x0400BC13 RID: 48147
			[Token(Token = "0x400BC13")]
			UIGroup_ReaperMode = 67108864UL,
			// Token: 0x0400BC14 RID: 48148
			[Token(Token = "0x400BC14")]
			UIGroup_ObserverMatchEndShow = 134217728UL,
			// Token: 0x0400BC15 RID: 48149
			[Token(Token = "0x400BC15")]
			UIGroup_Photograph = 268435456UL,
			// Token: 0x0400BC16 RID: 48150
			[Token(Token = "0x400BC16")]
			UIGroup_NewDeath = 536870912UL,
			// Token: 0x0400BC17 RID: 48151
			[Token(Token = "0x400BC17")]
			UIGroup_OnFerrisWheel = 1073741824UL,
			// Token: 0x0400BC18 RID: 48152
			[Token(Token = "0x400BC18")]
			UIGroup_WereWolves = 2147483648UL
		}

		// Token: 0x02002083 RID: 8323
		[Token(Token = "0x2002083")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA44", Offset = "0x10FDA44")]
		private sealed class <ReleaseMemoryAndOpenMatchResult>d__161 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600BACB RID: 47819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BACB")]
			[Address(RVA = "0x190C168", Offset = "0x190C168", VA = "0x7BBC10C168")]
			[DebuggerHidden]
			public <ReleaseMemoryAndOpenMatchResult>d__161(int <>1__state)
			{
			}

			// Token: 0x0600BACC RID: 47820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BACC")]
			[Address(RVA = "0x190C194", Offset = "0x190C194", VA = "0x7BBC10C194", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600BACD RID: 47821 RVA: 0x000350A0 File Offset: 0x000332A0
			[Token(Token = "0x600BACD")]
			[Address(RVA = "0x190C198", Offset = "0x190C198", VA = "0x7BBC10C198", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x0600BACE RID: 47822 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CC8")]
			private object Current
			{
				[Token(Token = "0x600BACE")]
				[Address(RVA = "0x190C69C", Offset = "0x190C69C", VA = "0x7BBC10C69C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600BACF RID: 47823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BACF")]
			[Address(RVA = "0x190C6A4", Offset = "0x190C6A4", VA = "0x7BBC10C6A4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x0600BAD0 RID: 47824 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CC9")]
			private object Current
			{
				[Token(Token = "0x600BAD0")]
				[Address(RVA = "0x190C70C", Offset = "0x190C70C", VA = "0x7BBC10C70C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400BC19 RID: 48153
			[Token(Token = "0x400BC19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400BC1A RID: 48154
			[Token(Token = "0x400BC1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400BC1B RID: 48155
			[Token(Token = "0x400BC1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool keepScene;

			// Token: 0x0400BC1C RID: 48156
			[Token(Token = "0x400BC1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool createAvatar;

			// Token: 0x0400BC1D RID: 48157
			[Token(Token = "0x400BC1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIInGameScene <>4__this;

			// Token: 0x0400BC1E RID: 48158
			[Token(Token = "0x400BC1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Type type;

			// Token: 0x0400BC1F RID: 48159
			[Token(Token = "0x400BC1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <waitEndTime>5__2;
		}

		// Token: 0x02002084 RID: 8324
		[Token(Token = "0x2002084")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA54", Offset = "0x10FDA54")]
		private sealed class <>c__DisplayClass165_0
		{
			// Token: 0x0600BAD1 RID: 47825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD1")]
			[Address(RVA = "0x190BEB8", Offset = "0x190BEB8", VA = "0x7BBC10BEB8")]
			public <>c__DisplayClass165_0()
			{
			}

			// Token: 0x0600BAD2 RID: 47826 RVA: 0x000350B8 File Offset: 0x000332B8
			[Token(Token = "0x600BAD2")]
			[Address(RVA = "0x190BEC0", Offset = "0x190BEC0", VA = "0x7BBC10BEC0")]
			internal bool <AdjustHudApperance>b__0(UIBaseController c)
			{
				return default(bool);
			}

			// Token: 0x0400BC20 RID: 48160
			[Token(Token = "0x400BC20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Type t;
		}

		// Token: 0x02002085 RID: 8325
		[Token(Token = "0x2002085")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA64", Offset = "0x10FDA64")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600BAD4 RID: 47828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD4")]
			[Address(RVA = "0x190BC70", Offset = "0x190BC70", VA = "0x7BBC10BC70")]
			public <>c()
			{
			}

			// Token: 0x0600BAD5 RID: 47829 RVA: 0x000350D0 File Offset: 0x000332D0
			[Token(Token = "0x600BAD5")]
			[Address(RVA = "0x190BC78", Offset = "0x190BC78", VA = "0x7BBC10BC78")]
			internal bool <OnHudNormalSettingChanged>b__166_0(UIBaseController c)
			{
				return default(bool);
			}

			// Token: 0x0600BAD6 RID: 47830 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD6")]
			[Address(RVA = "0x190BD1C", Offset = "0x190BD1C", VA = "0x7BBC10BD1C")]
			internal void <ShowBackToLobbyDialog>b__169_0()
			{
			}

			// Token: 0x0600BAD7 RID: 47831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD7")]
			[Address(RVA = "0x190BDE0", Offset = "0x190BDE0", VA = "0x7BBC10BDE0")]
			internal void <OnRequestGameResumeConfirm>b__339_0()
			{
			}

			// Token: 0x0400BC21 RID: 48161
			[Token(Token = "0x400BC21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIInGameScene.<>c <>9;

			// Token: 0x0400BC22 RID: 48162
			[Token(Token = "0x400BC22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UIBaseController> <>9__166_0;

			// Token: 0x0400BC23 RID: 48163
			[Token(Token = "0x400BC23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__169_0;

			// Token: 0x0400BC24 RID: 48164
			[Token(Token = "0x400BC24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action <>9__339_0;
		}

		// Token: 0x02002086 RID: 8326
		[Token(Token = "0x2002086")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA74", Offset = "0x10FDA74")]
		private sealed class <>c__DisplayClass172_0
		{
			// Token: 0x0600BAD8 RID: 47832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD8")]
			[Address(RVA = "0x190BF5C", Offset = "0x190BF5C", VA = "0x7BBC10BF5C")]
			public <>c__DisplayClass172_0()
			{
			}

			// Token: 0x0600BAD9 RID: 47833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BAD9")]
			[Address(RVA = "0x190BF64", Offset = "0x190BF64", VA = "0x7BBC10BF64")]
			internal void <RoomSpectatorRequestQuitMatch>b__0()
			{
			}

			// Token: 0x0400BC25 RID: 48165
			[Token(Token = "0x400BC25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MatchGame game;
		}

		// Token: 0x02002087 RID: 8327
		[Token(Token = "0x2002087")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA84", Offset = "0x10FDA84")]
		private sealed class <>c__DisplayClass173_0
		{
			// Token: 0x0600BADA RID: 47834 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BADA")]
			[Address(RVA = "0x190C02C", Offset = "0x190C02C", VA = "0x7BBC10C02C")]
			public <>c__DisplayClass173_0()
			{
			}

			// Token: 0x0600BADB RID: 47835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BADB")]
			[Address(RVA = "0x190C034", Offset = "0x190C034", VA = "0x7BBC10C034")]
			internal void <NormalPlayerRequestQuitMatch>b__0()
			{
			}

			// Token: 0x0400BC26 RID: 48166
			[Token(Token = "0x400BC26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MatchGame game;
		}

		// Token: 0x02002088 RID: 8328
		[Token(Token = "0x2002088")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDA94", Offset = "0x10FDA94")]
		private sealed class <>c__DisplayClass217_0
		{
			// Token: 0x0600BADC RID: 47836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BADC")]
			[Address(RVA = "0x190C100", Offset = "0x190C100", VA = "0x7BBC10C100")]
			public <>c__DisplayClass217_0()
			{
			}

			// Token: 0x0600BADD RID: 47837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600BADD")]
			[Address(RVA = "0x190C108", Offset = "0x190C108", VA = "0x7BBC10C108")]
			internal void <RemoveNameHud>b__0()
			{
			}

			// Token: 0x0400BC27 RID: 48167
			[Token(Token = "0x400BC27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIInGameScene <>4__this;

			// Token: 0x0400BC28 RID: 48168
			[Token(Token = "0x400BC28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public {QAb\u0082~u id;
		}
	}
}
