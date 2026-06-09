using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A0A RID: 6666
	[Token(Token = "0x2001A0A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F776C", Offset = "0x10F776C")]
	public class UILobbyNewController : UINavigationController, IUIModelDataChangeObserver, ITipsDelegate
	{
		// Token: 0x06008AB6 RID: 35510 RVA: 0x00025368 File Offset: 0x00023568
		[Token(Token = "0x6008AB6")]
		[Address(RVA = "0x1442EF8", Offset = "0x1442EF8", VA = "0x7BBBC42EF8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB7")]
		[Address(RVA = "0x1442F48", Offset = "0x1442F48", VA = "0x7BBBC42F48", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB8")]
		[Address(RVA = "0x144A1A4", Offset = "0x144A1A4", VA = "0x7BBBC4A1A4")]
		private void ShowProfileGuide(object[] data)
		{
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AB9")]
		[Address(RVA = "0x1447EA0", Offset = "0x1447EA0", VA = "0x7BBBC47EA0")]
		private void OpenActivityCountDownCtrl(Transform parent, ref UICountDownController countDownCtrl)
		{
		}

		// Token: 0x06008ABA RID: 35514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ABA")]
		[Address(RVA = "0x1449D2C", Offset = "0x1449D2C", VA = "0x7BBBC49D2C")]
		private void ShowAgeLogo()
		{
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ABB")]
		[Address(RVA = "0x144A4CC", Offset = "0x144A4CC", VA = "0x7BBBC4A4CC")]
		private void FirstMatchProcess(params object[] args)
		{
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ABC")]
		[Address(RVA = "0x144B248", Offset = "0x144B248", VA = "0x7BBBC4B248")]
		private void OnEndMatchMaking(params object[] data)
		{
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008ABD")]
		[Address(RVA = "0x144B250", Offset = "0x144B250", VA = "0x7BBBC4B250")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143B30", Offset = "0x1143B30")]
		private IEnumerator HideOverMask(float delay)
		{
			return null;
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ABE")]
		[Address(RVA = "0x144A700", Offset = "0x144A700", VA = "0x7BBBC4A700")]
		private void SetOverMaskShow(bool show)
		{
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ABF")]
		[Address(RVA = "0x144B2E8", Offset = "0x144B2E8", VA = "0x7BBBC4B2E8")]
		private void OnVaultBGChange()
		{
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC0")]
		[Address(RVA = "0x14489B0", Offset = "0x14489B0", VA = "0x7BBBC489B0")]
		private void InitClanRaceInfo()
		{
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC1")]
		[Address(RVA = "0x144B588", Offset = "0x144B588", VA = "0x7BBBC4B588")]
		private void ClearClanRaceInfo()
		{
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC2")]
		[Address(RVA = "0x144B6B4", Offset = "0x144B6B4", VA = "0x7BBBC4B6B4")]
		private void ClanOwnStatusChanged(params object[] args)
		{
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC3")]
		[Address(RVA = "0x144B408", Offset = "0x144B408", VA = "0x7BBBC4B408")]
		private void RefreshRaceInfo(bool showAnim)
		{
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC4")]
		[Address(RVA = "0x144B85C", Offset = "0x144B85C", VA = "0x7BBBC4B85C")]
		private void OnGetSeasonChangeInfo(params object[] param)
		{
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC5")]
		[Address(RVA = "0x144BA14", Offset = "0x144BA14", VA = "0x7BBBC4BA14")]
		private void RequestSilenceInfo()
		{
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC6")]
		[Address(RVA = "0x144BB44", Offset = "0x144BB44", VA = "0x7BBBC4BB44", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC7")]
		[Address(RVA = "0x144BC00", Offset = "0x144BC00", VA = "0x7BBBC4BC00")]
		private void OnBtnAvatarClick()
		{
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC8")]
		[Address(RVA = "0x144C034", Offset = "0x144C034", VA = "0x7BBBC4C034")]
		private void OnBtnCollectionClick()
		{
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AC9")]
		[Address(RVA = "0x144C19C", Offset = "0x144C19C", VA = "0x7BBBC4C19C")]
		private void OnBtnGachaClick()
		{
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACA")]
		[Address(RVA = "0x144C2B4", Offset = "0x144C2B4", VA = "0x7BBBC4C2B4")]
		private void OnLiveTvClick()
		{
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACB")]
		[Address(RVA = "0x144C37C", Offset = "0x144C37C", VA = "0x7BBBC4C37C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACC")]
		[Address(RVA = "0x144DC20", Offset = "0x144DC20", VA = "0x7BBBC4DC20", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACD")]
		[Address(RVA = "0x144E24C", Offset = "0x144E24C", VA = "0x7BBBC4E24C", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACE")]
		[Address(RVA = "0x1450A88", Offset = "0x1450A88", VA = "0x7BBBC50A88")]
		private void RefreshDailyTask()
		{
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ACF")]
		[Address(RVA = "0x144F818", Offset = "0x144F818", VA = "0x7BBBC4F818")]
		private void RefreshAllBigEventEnrance()
		{
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD0")]
		[Address(RVA = "0x1451C58", Offset = "0x1451C58", VA = "0x7BBBC51C58")]
		private void OnEsportsTweenFinished()
		{
		}

		// Token: 0x06008AD1 RID: 35537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD1")]
		[Address(RVA = "0x1451C9C", Offset = "0x1451C9C", VA = "0x7BBBC51C9C")]
		private void CloseEsportsBubble()
		{
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD2")]
		[Address(RVA = "0x14504BC", Offset = "0x14504BC", VA = "0x7BBBC504BC")]
		private void RefreshEsportsBubble()
		{
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AD3")]
		[Address(RVA = "0x1451CE0", Offset = "0x1451CE0", VA = "0x7BBBC51CE0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143B94", Offset = "0x1143B94")]
		private IEnumerator StartShowGuide()
		{
			return null;
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD4")]
		[Address(RVA = "0x1451D54", Offset = "0x1451D54", VA = "0x7BBBC51D54", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD5")]
		[Address(RVA = "0x144F160", Offset = "0x144F160", VA = "0x7BBBC4F160")]
		private void CheckPetLobbyAction()
		{
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD6")]
		[Address(RVA = "0x144F008", Offset = "0x144F008", VA = "0x7BBBC4F008")]
		private void CheckLobbyExtraAdsTips()
		{
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD7")]
		[Address(RVA = "0x144F0C0", Offset = "0x144F0C0", VA = "0x7BBBC4F0C0")]
		private void CheckPetNewTips()
		{
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AD8")]
		[Address(RVA = "0x1452208", Offset = "0x1452208", VA = "0x7BBBC52208", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AD9")]
		[Address(RVA = "0x1452270", Offset = "0x1452270", VA = "0x7BBBC52270")]
		private void SetDefaultMode()
		{
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ADA")]
		[Address(RVA = "0x145443C", Offset = "0x145443C", VA = "0x7BBBC5443C")]
		private void ShowMapModetip(params object[] data)
		{
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ADB")]
		[Address(RVA = "0x1454508", Offset = "0x1454508", VA = "0x7BBBC54508")]
		private void OnMapModeBtnClick()
		{
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ADC")]
		[Address(RVA = "0x1454E8C", Offset = "0x1454E8C", VA = "0x7BBBC54E8C")]
		private void OnTipsBtnClick()
		{
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ADD")]
		[Address(RVA = "0x1454EE8", Offset = "0x1454EE8", VA = "0x7BBBC54EE8")]
		private void OnTeamModeBtnClick()
		{
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008ADE")]
		[Address(RVA = "0x1455524", Offset = "0x1455524", VA = "0x7BBBC55524")]
		private void RefreshTeamModesPanel()
		{
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x00025380 File Offset: 0x00023580
		[Token(Token = "0x6008ADF")]
		[Address(RVA = "0x1454CB4", Offset = "0x1454CB4", VA = "0x7BBBC54CB4")]
		private bool CheckMapAvailability()
		{
			return default(bool);
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE0")]
		[Address(RVA = "0x14558D8", Offset = "0x14558D8", VA = "0x7BBBC558D8")]
		private void ChangeGroupMode(params object[] args)
		{
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE1")]
		[Address(RVA = "0x14559A4", Offset = "0x14559A4", VA = "0x7BBBC559A4")]
		private void OnSquardBtnClick()
		{
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE2")]
		[Address(RVA = "0x14559B0", Offset = "0x14559B0", VA = "0x7BBBC559B0")]
		private void OnDuoBtnClick()
		{
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE3")]
		[Address(RVA = "0x145282C", Offset = "0x145282C", VA = "0x7BBBC5282C")]
		private void OnSoloBtnClick()
		{
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE4")]
		[Address(RVA = "0x14559BC", Offset = "0x14559BC", VA = "0x7BBBC559BC")]
		private void RevertsGroupMode(params object[] data)
		{
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE5")]
		[Address(RVA = "0x144A7C8", Offset = "0x144A7C8", VA = "0x7BBBC4A7C8")]
		private void ChangeGroupMode(zTfbhtW mode, tcp.EGroup.CreateFromType fromType = tcp.EGroup.CreateFromType.CreateFromType_OWNSELF)
		{
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE6")]
		[Address(RVA = "0x1455DD4", Offset = "0x1455DD4", VA = "0x7BBBC55DD4")]
		private void RevertGroupMode(zTfbhtW mode)
		{
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE7")]
		[Address(RVA = "0x1449720", Offset = "0x1449720", VA = "0x7BBBC49720")]
		private void RefreshGroupModeUI()
		{
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AE8")]
		[Address(RVA = "0x144127C", Offset = "0x144127C", VA = "0x7BBBC4127C")]
		public MapModeData GetSelectedMapData()
		{
			return null;
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AE9")]
		[Address(RVA = "0x145609C", Offset = "0x145609C", VA = "0x7BBBC5609C")]
		private void RefreshLoadoutContainer()
		{
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x00025398 File Offset: 0x00023598
		[Token(Token = "0x6008AEA")]
		[Address(RVA = "0x14559C0", Offset = "0x14559C0", VA = "0x7BBBC559C0")]
		private bool QuitToSolo()
		{
			return default(bool);
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x000253B0 File Offset: 0x000235B0
		[Token(Token = "0x6008AEB")]
		[Address(RVA = "0x1455AE4", Offset = "0x1455AE4", VA = "0x7BBBC55AE4")]
		private bool CheckGroupMode()
		{
			return default(bool);
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x000253C8 File Offset: 0x000235C8
		[Token(Token = "0x6008AEC")]
		[Address(RVA = "0x14556A8", Offset = "0x14556A8", VA = "0x7BBBC556A8")]
		private bool CheckPlayerLimits(zTfbhtW groupMode, bool showTips = true)
		{
			return default(bool);
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x000253E0 File Offset: 0x000235E0
		[Token(Token = "0x6008AED")]
		[Address(RVA = "0x1456460", Offset = "0x1456460", VA = "0x7BBBC56460")]
		private bool CheckPlayerLimitsAndAutoSelectGroupMode(zTfbhtW groupMode)
		{
			return default(bool);
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x000253F8 File Offset: 0x000235F8
		[Token(Token = "0x6008AEE")]
		[Address(RVA = "0x14523FC", Offset = "0x14523FC", VA = "0x7BBBC523FC")]
		private bool IsSoloSupported(MapModeData mapData, bool showTips = true)
		{
			return default(bool);
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AEF")]
		[Address(RVA = "0x1455E7C", Offset = "0x1455E7C", VA = "0x7BBBC55E7C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143BF8", Offset = "0x1143BF8")]
		private IEnumerator CloseGroupModePanel(float seconds)
		{
			return null;
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF0")]
		[Address(RVA = "0x1456A50", Offset = "0x1456A50", VA = "0x7BBBC56A50")]
		private void CloseGroupModePanel()
		{
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF1")]
		[Address(RVA = "0x1452934", Offset = "0x1452934", VA = "0x7BBBC52934")]
		private void UpdateSelectedGroupModeUI()
		{
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF2")]
		[Address(RVA = "0x1452CA8", Offset = "0x1452CA8", VA = "0x7BBBC52CA8")]
		private void UpdateSelectedMapModeUI()
		{
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF3")]
		[Address(RVA = "0x1456AE8", Offset = "0x1456AE8", VA = "0x7BBBC56AE8")]
		private void RefreshPVEUI()
		{
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF4")]
		[Address(RVA = "0x1457070", Offset = "0x1457070", VA = "0x7BBBC57070")]
		private void OnOnPveDifficultyChanged(object[] param)
		{
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF5")]
		[Address(RVA = "0x14571CC", Offset = "0x14571CC", VA = "0x7BBBC571CC")]
		private void OnMapModeSelected(object[] param)
		{
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF6")]
		[Address(RVA = "0x1456DC0", Offset = "0x1456DC0", VA = "0x7BBBC56DC0")]
		private void ShowGameModeWebTutorial(MapModeData mapData)
		{
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x00025410 File Offset: 0x00023610
		[Token(Token = "0x6008AF7")]
		[Address(RVA = "0x14576C0", Offset = "0x14576C0", VA = "0x7BBBC576C0")]
		private bool ChangeMapMode(MapModeData mapData)
		{
			return default(bool);
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF8")]
		[Address(RVA = "0x1457F40", Offset = "0x1457F40", VA = "0x7BBBC57F40")]
		private void AutoSelectGroup()
		{
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AF9")]
		[Address(RVA = "0x1452724", Offset = "0x1452724", VA = "0x7BBBC52724")]
		private void RevertMapMode(MapModeData mapData)
		{
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008AFA")]
		[Address(RVA = "0x1458130", Offset = "0x1458130", VA = "0x7BBBC58130")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143C5C", Offset = "0x1143C5C")]
		private IEnumerator CloseMapModePanel(float seconds)
		{
			return null;
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AFB")]
		[Address(RVA = "0x14581C8", Offset = "0x14581C8", VA = "0x7BBBC581C8")]
		private void CloseMapModePanel()
		{
		}

		// Token: 0x06008AFC RID: 35580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AFC")]
		[Address(RVA = "0x14582FC", Offset = "0x14582FC", VA = "0x7BBBC582FC")]
		private void OnHelperBtnClick()
		{
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AFD")]
		[Address(RVA = "0x145844C", Offset = "0x145844C", VA = "0x7BBBC5844C")]
		private void CloseModeSelectionPanels(params object[] data)
		{
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008AFE")]
		[Address(RVA = "0x1458650", Offset = "0x1458650", VA = "0x7BBBC58650")]
		private void OpenGroupUI()
		{
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x00025428 File Offset: 0x00023628
		[Token(Token = "0x6008AFF")]
		[Address(RVA = "0x1458AB0", Offset = "0x1458AB0", VA = "0x7BBBC58AB0")]
		public Vector3 GetInviteBoxScale()
		{
			return default(Vector3);
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x00025440 File Offset: 0x00023640
		[Token(Token = "0x6008B00")]
		[Address(RVA = "0x1458BB4", Offset = "0x1458BB4", VA = "0x7BBBC58BB4")]
		public Vector3 GetInviteBoxCenterPos()
		{
			return default(Vector3);
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B01")]
		[Address(RVA = "0x1452838", Offset = "0x1452838", VA = "0x7BBBC52838")]
		private void EnableModeSelectionButtons(bool v)
		{
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B02")]
		[Address(RVA = "0x1458C0C", Offset = "0x1458C0C", VA = "0x7BBBC58C0C")]
		private void OnMatchmakingHide(object[] data)
		{
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B03")]
		[Address(RVA = "0x1458D34", Offset = "0x1458D34", VA = "0x7BBBC58D34")]
		private void OnMatchmakingShow(object[] data)
		{
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B04")]
		[Address(RVA = "0x1458E9C", Offset = "0x1458E9C", VA = "0x7BBBC58E9C")]
		private void OnGroupQuit(object[] param)
		{
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B05")]
		[Address(RVA = "0x145904C", Offset = "0x145904C", VA = "0x7BBBC5904C")]
		public void OnInviteClick()
		{
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B06")]
		[Address(RVA = "0x1459298", Offset = "0x1459298", VA = "0x7BBBC59298")]
		private void OnReplayClick()
		{
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B07")]
		[Address(RVA = "0x1459334", Offset = "0x1459334", VA = "0x7BBBC59334")]
		private void OnBtnLoginClick()
		{
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B08")]
		[Address(RVA = "0x144AF64", Offset = "0x144AF64", VA = "0x7BBBC4AF64")]
		private void StartFirstGuideMatchmakingSolo(params object[] data)
		{
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B09")]
		[Address(RVA = "0x1459A44", Offset = "0x1459A44", VA = "0x7BBBC59A44")]
		private void StartSoloMatchmaking(params object[] data)
		{
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0A")]
		[Address(RVA = "0x1459EF4", Offset = "0x1459EF4", VA = "0x7BBBC59EF4")]
		private void OnBtnLoginSpecialModeClick()
		{
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0B")]
		[Address(RVA = "0x1459FE4", Offset = "0x1459FE4", VA = "0x7BBBC59FE4")]
		private void OnBtnGoliathClick()
		{
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0C")]
		[Address(RVA = "0x145A0EC", Offset = "0x145A0EC", VA = "0x7BBBC5A0EC")]
		private void OnBtnSuperFighterClick()
		{
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0D")]
		[Address(RVA = "0x145A1D8", Offset = "0x145A1D8", VA = "0x7BBBC5A1D8")]
		private void OnBtnCustomizeClick()
		{
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0E")]
		[Address(RVA = "0x145A334", Offset = "0x145A334", VA = "0x7BBBC5A334")]
		private void OnWeaponSkinClick()
		{
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B0F")]
		[Address(RVA = "0x145A474", Offset = "0x145A474", VA = "0x7BBBC5A474")]
		private void OnBtnTutorialClick()
		{
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B10")]
		[Address(RVA = "0x145AC30", Offset = "0x145AC30", VA = "0x7BBBC5AC30")]
		private void OnCloseTutorial(params object[] data)
		{
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B11")]
		[Address(RVA = "0x145AE28", Offset = "0x145AE28", VA = "0x7BBBC5AE28")]
		private void OnBtnPetClick()
		{
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B12")]
		[Address(RVA = "0x145AF90", Offset = "0x145AF90", VA = "0x7BBBC5AF90")]
		private void OnBtnStoreClick()
		{
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B13")]
		[Address(RVA = "0x145B094", Offset = "0x145B094", VA = "0x7BBBC5B094")]
		private void OnMallQuit(params object[] data)
		{
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B14")]
		[Address(RVA = "0x145B098", Offset = "0x145B098", VA = "0x7BBBC5B098")]
		private void OnAdsSelected(params object[] data)
		{
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B15")]
		[Address(RVA = "0x145A9D0", Offset = "0x145A9D0", VA = "0x7BBBC5A9D0")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06008B16 RID: 35606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B16")]
		[Address(RVA = "0x145B174", Offset = "0x145B174", VA = "0x7BBBC5B174")]
		private void OpenWebTutorial()
		{
		}

		// Token: 0x06008B17 RID: 35607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B17")]
		[Address(RVA = "0x145B188", Offset = "0x145B188", VA = "0x7BBBC5B188")]
		private void OpenVideoTutorial()
		{
		}

		// Token: 0x06008B18 RID: 35608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B18")]
		[Address(RVA = "0x145B3F0", Offset = "0x145B3F0", VA = "0x7BBBC5B3F0")]
		private void OnGroupCreateSuccess(params object[] param)
		{
		}

		// Token: 0x06008B19 RID: 35609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B19")]
		[Address(RVA = "0x145B4C8", Offset = "0x145B4C8", VA = "0x7BBBC5B4C8")]
		private void OnJoinNtf(params object[] data)
		{
		}

		// Token: 0x06008B1A RID: 35610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1A")]
		[Address(RVA = "0x145B7B4", Offset = "0x145B7B4", VA = "0x7BBBC5B7B4")]
		private void OnGroupInfoSync(params object[] data)
		{
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1B")]
		[Address(RVA = "0x145B9F4", Offset = "0x145B9F4", VA = "0x7BBBC5B9F4")]
		private void OnGroupChangeNtf(params object[] data)
		{
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1C")]
		[Address(RVA = "0x145BA08", Offset = "0x145BA08", VA = "0x7BBBC5BA08")]
		private void OnGroupChangeGroupModeNtf(params object[] data)
		{
		}

		// Token: 0x06008B1D RID: 35613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1D")]
		[Address(RVA = "0x145BBA4", Offset = "0x145BBA4", VA = "0x7BBBC5BBA4")]
		private void OnCreateGroupFail(params object[] data)
		{
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1E")]
		[Address(RVA = "0x145BBE8", Offset = "0x145BBE8", VA = "0x7BBBC5BBE8")]
		private void OnOpenSetting(object[] data)
		{
		}

		// Token: 0x06008B1F RID: 35615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B1F")]
		[Address(RVA = "0x145BCA4", Offset = "0x145BCA4", VA = "0x7BBBC5BCA4")]
		private void OnLeaderBoardClick()
		{
		}

		// Token: 0x06008B20 RID: 35616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B20")]
		[Address(RVA = "0x145BD6C", Offset = "0x145BD6C", VA = "0x7BBBC5BD6C")]
		private void OnNewPlayerSigninClick()
		{
		}

		// Token: 0x06008B21 RID: 35617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B21")]
		[Address(RVA = "0x145BE38", Offset = "0x145BE38", VA = "0x7BBBC5BE38")]
		private void OnVeteranSigninClick()
		{
		}

		// Token: 0x06008B22 RID: 35618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B22")]
		[Address(RVA = "0x145BEBC", Offset = "0x145BEBC", VA = "0x7BBBC5BEBC")]
		private void OnClanBtnClick()
		{
		}

		// Token: 0x06008B23 RID: 35619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B23")]
		[Address(RVA = "0x145C024", Offset = "0x145C024", VA = "0x7BBBC5C024")]
		private void OnEventClick()
		{
		}

		// Token: 0x06008B24 RID: 35620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B24")]
		[Address(RVA = "0x145C0C8", Offset = "0x145C0C8", VA = "0x7BBBC5C0C8")]
		private void OnBtnTaskClick()
		{
		}

		// Token: 0x06008B25 RID: 35621 RVA: 0x00025458 File Offset: 0x00023658
		[Token(Token = "0x6008B25")]
		[Address(RVA = "0x145C240", Offset = "0x145C240", VA = "0x7BBBC5C240")]
		public Vector3 GetLivTvPosForSplash()
		{
			return default(Vector3);
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B26")]
		[Address(RVA = "0x144EC00", Offset = "0x144EC00", VA = "0x7BBBC4EC00")]
		private void RefreshVeteranBtnState()
		{
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B27")]
		[Address(RVA = "0x1447F78", Offset = "0x1447F78", VA = "0x7BBBC47F78")]
		private void RefreshNewPlayerSigninState()
		{
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B28")]
		[Address(RVA = "0x145C298", Offset = "0x145C298", VA = "0x7BBBC5C298")]
		private void OnBtnBundleWebClick()
		{
		}

		// Token: 0x06008B29 RID: 35625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B29")]
		[Address(RVA = "0x145C394", Offset = "0x145C394", VA = "0x7BBBC5C394")]
		private void OnBtnBundleChoose1From3Click()
		{
		}

		// Token: 0x06008B2A RID: 35626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B2A")]
		[Address(RVA = "0x1448568", Offset = "0x1448568", VA = "0x7BBBC48568")]
		private void RefreshIAPBundleActivityState()
		{
		}

		// Token: 0x06008B2B RID: 35627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B2B")]
		[Address(RVA = "0x145C6C0", Offset = "0x145C6C0", VA = "0x7BBBC5C6C0")]
		private void RefreshSuperCarTips()
		{
		}

		// Token: 0x06008B2C RID: 35628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B2C")]
		[Address(RVA = "0x1448F10", Offset = "0x1448F10", VA = "0x7BBBC48F10")]
		private void RefreshActivityButtonState()
		{
		}

		// Token: 0x06008B2D RID: 35629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B2D")]
		[Address(RVA = "0x1449F30", Offset = "0x1449F30", VA = "0x7BBBC49F30")]
		private void ConfigBigEventEntrance()
		{
		}

		// Token: 0x06008B2E RID: 35630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B2E")]
		[Address(RVA = "0x144A0D4", Offset = "0x144A0D4", VA = "0x7BBBC4A0D4")]
		private void ConfigBigEventIntro()
		{
		}

		// Token: 0x06008B2F RID: 35631 RVA: 0x00025470 File Offset: 0x00023670
		[Token(Token = "0x6008B2F")]
		[Address(RVA = "0x145C7D0", Offset = "0x145C7D0", VA = "0x7BBBC5C7D0")]
		private bool SetBigEventEntranceActive(proto.ELimitedEvent.EventID eventId, bool isActive)
		{
			return default(bool);
		}

		// Token: 0x06008B30 RID: 35632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B30")]
		[Address(RVA = "0x145C97C", Offset = "0x145C97C", VA = "0x7BBBC5C97C")]
		private void SetBigEventCountDown(proto.ELimitedEvent.EventID eventId, proto.ELimitedEvent.EventState eventState)
		{
		}

		// Token: 0x06008B31 RID: 35633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B31")]
		[Address(RVA = "0x145CE0C", Offset = "0x145CE0C", VA = "0x7BBBC5CE0C")]
		private void BigEventWarmUpActionDefault(proto.ELimitedEvent.EventID eventId, bool hasWarmUpPhase)
		{
		}

		// Token: 0x06008B32 RID: 35634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B32")]
		[Address(RVA = "0x145CFD0", Offset = "0x145CFD0", VA = "0x7BBBC5CFD0")]
		private void BigEventProcessActionDefault(proto.ELimitedEvent.EventID eventId)
		{
		}

		// Token: 0x06008B33 RID: 35635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B33")]
		[Address(RVA = "0x145D014", Offset = "0x145D014", VA = "0x7BBBC5D014")]
		private void BigEventSettleActionDefault(proto.ELimitedEvent.EventID eventId)
		{
		}

		// Token: 0x06008B34 RID: 35636 RVA: 0x00025488 File Offset: 0x00023688
		[Token(Token = "0x6008B34")]
		[Address(RVA = "0x145D01C", Offset = "0x145D01C", VA = "0x7BBBC5D01C")]
		private uint GetBigEventStateActionKey(proto.ELimitedEvent.EventID eventId, proto.ELimitedEvent.EventState eventState)
		{
			return 0U;
		}

		// Token: 0x06008B35 RID: 35637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B35")]
		[Address(RVA = "0x1451AF4", Offset = "0x1451AF4", VA = "0x7BBBC51AF4")]
		private void RefreshBigEventEntranceState(proto.ELimitedEvent.EventID eventId, bool hasWarmUpPhase = false)
		{
		}

		// Token: 0x06008B36 RID: 35638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B36")]
		[Address(RVA = "0x145CF38", Offset = "0x145CF38", VA = "0x7BBBC5CF38")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143CC0", Offset = "0x1143CC0")]
		private IEnumerator WaitForBigEventProcessOpen(proto.ELimitedEvent.EventID eventId)
		{
			return null;
		}

		// Token: 0x06008B37 RID: 35639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B37")]
		[Address(RVA = "0x145D028", Offset = "0x145D028", VA = "0x7BBBC5D028")]
		private void ShowBigEventIntroIfNeed(proto.ELimitedEvent.EventID eventId, EBigEventIntroTiming timing)
		{
		}

		// Token: 0x06008B38 RID: 35640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B38")]
		[Address(RVA = "0x144F86C", Offset = "0x144F86C", VA = "0x7BBBC4F86C")]
		private void ShowBigEventPeakDayOpenIntroIfNeed()
		{
		}

		// Token: 0x06008B39 RID: 35641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B39")]
		[Address(RVA = "0x1450FE0", Offset = "0x1450FE0", VA = "0x7BBBC50FE0")]
		private void RefreshSuperFighterTips()
		{
		}

		// Token: 0x06008B3A RID: 35642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B3A")]
		[Address(RVA = "0x14517A8", Offset = "0x14517A8", VA = "0x7BBBC517A8")]
		private void RefreshFFWSBtnState()
		{
		}

		// Token: 0x06008B3B RID: 35643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B3B")]
		[Address(RVA = "0x145137C", Offset = "0x145137C", VA = "0x7BBBC5137C")]
		private void RefreshGoliathBtnState()
		{
		}

		// Token: 0x06008B3C RID: 35644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B3C")]
		[Address(RVA = "0x1450C98", Offset = "0x1450C98", VA = "0x7BBBC50C98")]
		private void RefreshGoliathNextGroupFinishTime()
		{
		}

		// Token: 0x06008B3D RID: 35645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B3D")]
		[Address(RVA = "0x1450D88", Offset = "0x1450D88", VA = "0x7BBBC50D88")]
		private void RefreshGoliathGroupNumberState()
		{
		}

		// Token: 0x06008B3E RID: 35646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B3E")]
		[Address(RVA = "0x145D5AC", Offset = "0x145D5AC", VA = "0x7BBBC5D5AC")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143D24", Offset = "0x1143D24")]
		private IEnumerator WaitForNextAFKGroupFinish()
		{
			return null;
		}

		// Token: 0x06008B3F RID: 35647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B3F")]
		[Address(RVA = "0x1450EA0", Offset = "0x1450EA0", VA = "0x7BBBC50EA0")]
		private void RefreshGoliathPeakDayState()
		{
		}

		// Token: 0x06008B40 RID: 35648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B40")]
		[Address(RVA = "0x144FA20", Offset = "0x144FA20", VA = "0x7BBBC4FA20")]
		private void RefreshChampionshipBtnState()
		{
		}

		// Token: 0x06008B41 RID: 35649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B41")]
		[Address(RVA = "0x144F450", Offset = "0x144F450", VA = "0x7BBBC4F450")]
		public void RefreshBtnStoreState()
		{
		}

		// Token: 0x06008B42 RID: 35650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B42")]
		[Address(RVA = "0x145D60C", Offset = "0x145D60C", VA = "0x7BBBC5D60C")]
		private void RefreshWeaponSysRedPoint()
		{
		}

		// Token: 0x06008B43 RID: 35651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B43")]
		[Address(RVA = "0x145D820", Offset = "0x145D820", VA = "0x7BBBC5D820")]
		private void RefreshEPNewTag()
		{
		}

		// Token: 0x06008B44 RID: 35652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B44")]
		[Address(RVA = "0x1449688", Offset = "0x1449688", VA = "0x7BBBC49688")]
		private void ShowMapHintContainer(bool v)
		{
		}

		// Token: 0x06008B45 RID: 35653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B45")]
		[Address(RVA = "0x145DAD8", Offset = "0x145DAD8", VA = "0x7BBBC5DAD8")]
		private void RefreshHint()
		{
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B46")]
		[Address(RVA = "0x145DB58", Offset = "0x145DB58", VA = "0x7BBBC5DB58", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B47")]
		[Address(RVA = "0x1455F20", Offset = "0x1455F20", VA = "0x7BBBC55F20")]
		private void UpdateAllLevelEntranceStatus()
		{
		}

		// Token: 0x06008B48 RID: 35656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B48")]
		[Address(RVA = "0x144BDF0", Offset = "0x144BDF0", VA = "0x7BBBC4BDF0")]
		public void ShowEntranceLockTip(uint entranceId)
		{
		}

		// Token: 0x06008B49 RID: 35657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B49")]
		[Address(RVA = "0x145638C", Offset = "0x145638C", VA = "0x7BBBC5638C")]
		private void UpdateLevelEntrance(int entranceIndex, uint LockStatus)
		{
		}

		// Token: 0x06008B4A RID: 35658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4A")]
		[Address(RVA = "0x145F344", Offset = "0x145F344", VA = "0x7BBBC5F344")]
		private void UpdateAvatarCloth()
		{
		}

		// Token: 0x06008B4B RID: 35659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4B")]
		[Address(RVA = "0x14561C4", Offset = "0x14561C4", VA = "0x7BBBC561C4")]
		private void RefreshGachaBtnView()
		{
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4C")]
		[Address(RVA = "0x144EDD0", Offset = "0x144EDD0", VA = "0x7BBBC4EDD0")]
		private void CheckGachaNewTips()
		{
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4D")]
		[Address(RVA = "0x144EEAC", Offset = "0x144EEAC", VA = "0x7BBBC4EEAC")]
		private void CheckGachaFreeTips([Optional] object[] data)
		{
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4E")]
		[Address(RVA = "0x145A684", Offset = "0x145A684", VA = "0x7BBBC5A684")]
		private void CheckGameGuideTips()
		{
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B4F")]
		[Address(RVA = "0x145F46C", Offset = "0x145F46C", VA = "0x7BBBC5F46C")]
		private void CheckManualShakeTips()
		{
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B50")]
		[Address(RVA = "0x145F670", Offset = "0x145F670", VA = "0x7BBBC5F670")]
		private void ProcessTopupNotifications()
		{
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x000254A0 File Offset: 0x000236A0
		[Token(Token = "0x6008B51")]
		[Address(RVA = "0x145F870", Offset = "0x145F870", VA = "0x7BBBC5F870", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B52")]
		[Address(RVA = "0x145FBC0", Offset = "0x145FBC0", VA = "0x7BBBC5FBC0")]
		private void OnChimpionshipClick()
		{
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B53")]
		[Address(RVA = "0x145FE08", Offset = "0x145FE08", VA = "0x7BBBC5FE08")]
		private void OnEPDataChange(params object[] param)
		{
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B54")]
		[Address(RVA = "0x1460138", Offset = "0x1460138", VA = "0x7BBBC60138")]
		private void OnEPEntranceChange(params object[] param)
		{
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B55")]
		[Address(RVA = "0x1460350", Offset = "0x1460350", VA = "0x7BBBC60350")]
		private void OnRoomOpen(params object[] param)
		{
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B56")]
		[Address(RVA = "0x145C434", Offset = "0x145C434", VA = "0x7BBBC5C434")]
		private void UpdateLobbyIAPBundle()
		{
		}

		// Token: 0x06008B57 RID: 35671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B57")]
		[Address(RVA = "0x1448BBC", Offset = "0x1448BBC", VA = "0x7BBBC48BBC")]
		private void UpdateLobbyRewardedVideo()
		{
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B58")]
		[Address(RVA = "0x1448D8C", Offset = "0x1448D8C", VA = "0x7BBBC48D8C")]
		private void UpdateLobbyGoogleEngagementRewards()
		{
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B59")]
		[Address(RVA = "0x1460374", Offset = "0x1460374", VA = "0x7BBBC60374")]
		private void OnRewardedVideoBtnClick()
		{
		}

		// Token: 0x06008B5A RID: 35674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5A")]
		[Address(RVA = "0x14603EC", Offset = "0x14603EC", VA = "0x7BBBC603EC")]
		private void OnManualBtnClick()
		{
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5B")]
		[Address(RVA = "0x1460690", Offset = "0x1460690", VA = "0x7BBBC60690")]
		private void OnEPTaskButtonClick()
		{
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5C")]
		[Address(RVA = "0x1441284", Offset = "0x1441284", VA = "0x7BBBC41284")]
		public void SetEntranceClick(string newbietype, NewbieGuideId guideId)
		{
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5D")]
		[Address(RVA = "0x1460768", Offset = "0x1460768", VA = "0x7BBBC60768")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5E")]
		[Address(RVA = "0x1460A38", Offset = "0x1460A38", VA = "0x7BBBC60A38")]
		private void OnGoogleEngagementRewardsBtnClick()
		{
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B5F")]
		[Address(RVA = "0x1460AFC", Offset = "0x1460AFC", VA = "0x7BBBC60AFC")]
		private void OnShowAvatarEmotePanel(object[] data)
		{
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B60")]
		[Address(RVA = "0x1460DC8", Offset = "0x1460DC8", VA = "0x7BBBC60DC8")]
		private void OnCloseEmotePanel(object[] data)
		{
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B61")]
		[Address(RVA = "0x1460E64", Offset = "0x1460E64", VA = "0x7BBBC60E64")]
		private void OnPetShowActionClick(params object[] param)
		{
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B62")]
		[Address(RVA = "0x1461448", Offset = "0x1461448", VA = "0x7BBBC61448")]
		private void OnPetHideActionPanel(params object[] data)
		{
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B63")]
		[Address(RVA = "0x14614E0", Offset = "0x14614E0", VA = "0x7BBBC614E0")]
		private void CheckShowAvatarEmoteGuide()
		{
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B64")]
		[Address(RVA = "0x1455F14", Offset = "0x1455F14", VA = "0x7BBBC55F14")]
		private void SetPaymentButtonShow(bool isShow)
		{
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B65")]
		[Address(RVA = "0x145EB18", Offset = "0x145EB18", VA = "0x7BBBC5EB18")]
		private void UpdatePaymentButton()
		{
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x000254B8 File Offset: 0x000236B8
		[Token(Token = "0x6008B66")]
		[Address(RVA = "0x14614E4", Offset = "0x14614E4", VA = "0x7BBBC614E4")]
		private bool IsPayAcitivityOpen(UIModelPayment.PaymentButtonStyle paymentType)
		{
			return default(bool);
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B67")]
		[Address(RVA = "0x14617B0", Offset = "0x14617B0", VA = "0x7BBBC617B0")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143D88", Offset = "0x1143D88")]
		private IEnumerator LadderMatchDailyCoroutine()
		{
			return null;
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B68")]
		[Address(RVA = "0x1461824", Offset = "0x1461824", VA = "0x7BBBC61824")]
		private void OnBtnLadderMatchClick()
		{
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B69")]
		[Address(RVA = "0x14619E4", Offset = "0x14619E4", VA = "0x7BBBC619E4")]
		private void OnPaymentButtonClick()
		{
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6A")]
		[Address(RVA = "0x1461E10", Offset = "0x1461E10", VA = "0x7BBBC61E10")]
		private void OnShowLobbyStartGameGuide(params object[] data)
		{
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6B")]
		[Address(RVA = "0x1462100", Offset = "0x1462100", VA = "0x7BBBC62100")]
		private void RefreshIAPBundle(params object[] data)
		{
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6C")]
		[Address(RVA = "0x1462104", Offset = "0x1462104", VA = "0x7BBBC62104")]
		private void OnShowLobbyManualGuide(params object[] data)
		{
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6D")]
		[Address(RVA = "0x14623DC", Offset = "0x14623DC", VA = "0x7BBBC623DC")]
		private void OnSHowLobbyClanGuide(params object[] data)
		{
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6E")]
		[Address(RVA = "0x14626B4", Offset = "0x14626B4", VA = "0x7BBBC626B4")]
		private void OnCloseCommonGuide(params object[] data)
		{
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B6F")]
		[Address(RVA = "0x144F2B8", Offset = "0x144F2B8", VA = "0x7BBBC4F2B8")]
		public void CheckManualTips()
		{
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B70")]
		[Address(RVA = "0x14627AC", Offset = "0x14627AC", VA = "0x7BBBC627AC")]
		public void OnTouchLocalAvatar(params object[] param)
		{
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B71")]
		[Address(RVA = "0x14629B8", Offset = "0x14629B8", VA = "0x7BBBC629B8")]
		private void OnSuperCarBtnClick()
		{
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B72")]
		[Address(RVA = "0x1462CF0", Offset = "0x1462CF0", VA = "0x7BBBC62CF0")]
		private void OnFFWSMainBtnClick()
		{
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B73")]
		[Address(RVA = "0x146320C", Offset = "0x146320C", VA = "0x7BBBC6320C")]
		private void PlayGroupTween(params object[] data)
		{
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B74")]
		[Address(RVA = "0x14632D4", Offset = "0x14632D4", VA = "0x7BBBC632D4")]
		private void OnLobbyGroupEnter(params object[] data)
		{
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B75")]
		[Address(RVA = "0x1463328", Offset = "0x1463328", VA = "0x7BBBC63328")]
		private void OnLobbyGroupQuit(params object[] data)
		{
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B76")]
		[Address(RVA = "0x146337C", Offset = "0x146337C", VA = "0x7BBBC6337C")]
		private void ScrollBgCameraSize(params object[] data)
		{
		}

		// Token: 0x06008B77 RID: 35703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B77")]
		[Address(RVA = "0x14635B8", Offset = "0x14635B8", VA = "0x7BBBC635B8")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143DEC", Offset = "0x1143DEC")]
		private IEnumerator CoroutineScrollingBgCamera(float needSize)
		{
			return null;
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B78")]
		[Address(RVA = "0x1463650", Offset = "0x1463650", VA = "0x7BBBC63650")]
		private void StartCertainMode(params object[] args)
		{
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B79")]
		[Address(RVA = "0x14638EC", Offset = "0x14638EC", VA = "0x7BBBC638EC")]
		private void StartNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7A")]
		[Address(RVA = "0x1452204", Offset = "0x1452204", VA = "0x7BBBC52204")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7B")]
		[Address(RVA = "0x1466074", Offset = "0x1466074", VA = "0x7BBBC66074")]
		private void NewbiePathGuideProgressUpdate(params object[] args)
		{
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7C")]
		[Address(RVA = "0x1465F00", Offset = "0x1465F00", VA = "0x7BBBC65F00")]
		private void OnStopLobbyGuide()
		{
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7D")]
		[Address(RVA = "0x14661A4", Offset = "0x14661A4", VA = "0x7BBBC661A4")]
		private void PrepareStartGuide()
		{
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7E")]
		[Address(RVA = "0x1466244", Offset = "0x1466244", VA = "0x7BBBC66244")]
		private void PrepareStopGuide()
		{
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B7F")]
		[Address(RVA = "0x1463B58", Offset = "0x1463B58", VA = "0x7BBBC63B58")]
		private void NewbieGeneralGameGuide()
		{
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B80")]
		[Address(RVA = "0x1463DA4", Offset = "0x1463DA4", VA = "0x7BBBC63DA4")]
		private void NewbieMatchGameGuide()
		{
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B81")]
		[Address(RVA = "0x1464038", Offset = "0x1464038", VA = "0x7BBBC64038")]
		private void NewbieRankGameGuide()
		{
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B82")]
		[Address(RVA = "0x1464880", Offset = "0x1464880", VA = "0x7BBBC64880")]
		private void NewbieRoleGuide()
		{
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B83")]
		[Address(RVA = "0x14643A8", Offset = "0x14643A8", VA = "0x7BBBC643A8")]
		private void NewbieNonPVEGuide()
		{
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B84")]
		[Address(RVA = "0x1464AF0", Offset = "0x1464AF0", VA = "0x7BBBC64AF0")]
		private void NewbieVaultGuide()
		{
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B85")]
		[Address(RVA = "0x1464D60", Offset = "0x1464D60", VA = "0x7BBBC64D60")]
		private void NewbieCollectGuide()
		{
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B86")]
		[Address(RVA = "0x1464FD0", Offset = "0x1464FD0", VA = "0x7BBBC64FD0")]
		private void NewbieGachaGuide()
		{
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B87")]
		[Address(RVA = "0x1465240", Offset = "0x1465240", VA = "0x7BBBC65240")]
		private void NewbieLoadoutGuide()
		{
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B88")]
		[Address(RVA = "0x14655E0", Offset = "0x14655E0", VA = "0x7BBBC655E0")]
		private void NewbieNonMatchAndNonRankGuide()
		{
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B89")]
		[Address(RVA = "0x1465950", Offset = "0x1465950", VA = "0x7BBBC65950")]
		private void NewbieEPEntryGuide()
		{
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B8A")]
		[Address(RVA = "0x1465C64", Offset = "0x1465C64", VA = "0x7BBBC65C64")]
		private void NewbieEPTaskGuide()
		{
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B8B")]
		[Address(RVA = "0x14663CC", Offset = "0x14663CC", VA = "0x7BBBC663CC", Slot = "41")]
		public void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B8C")]
		[Address(RVA = "0x145D538", Offset = "0x145D538", VA = "0x7BBBC5D538")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x1143E50", Offset = "0x1143E50")]
		private IEnumerator WaitForGoliathOpen()
		{
			return null;
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B8D")]
		[Address(RVA = "0x14510A4", Offset = "0x14510A4", VA = "0x7BBBC510A4")]
		private void OpenAvatarLimitExpireWindow()
		{
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B8E")]
		[Address(RVA = "0x1451244", Offset = "0x1451244", VA = "0x7BBBC51244")]
		private void BackFromPaymentShowSecondRecharge()
		{
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B8F")]
		[Address(RVA = "0x1466820", Offset = "0x1466820", VA = "0x7BBBC66820")]
		public void StartLoginAutoTask()
		{
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B90")]
		[Address(RVA = "0x1466E14", Offset = "0x1466E14", VA = "0x7BBBC66E14")]
		public void StartReturnFromInGameAutoTask()
		{
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B91")]
		[Address(RVA = "0x1467178", Offset = "0x1467178", VA = "0x7BBBC67178")]
		public UILobbyNewController()
		{
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B93")]
		[Address(RVA = "0x1467644", Offset = "0x1467644", VA = "0x7BBBC67644")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143EB4", Offset = "0x1143EB4")]
		private void <FirstMatchProcess>b__81_0()
		{
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B94")]
		[Address(RVA = "0x1467798", Offset = "0x1467798", VA = "0x7BBBC67798")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143EC4", Offset = "0x1143EC4")]
		private void <FirstMatchProcess>b__81_1()
		{
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B95")]
		[Address(RVA = "0x1467954", Offset = "0x1467954", VA = "0x7BBBC67954")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143ED4", Offset = "0x1143ED4")]
		private void <OpenGroupUI>b__148_0()
		{
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B96")]
		[Address(RVA = "0x1467ADC", Offset = "0x1467ADC", VA = "0x7BBBC67ADC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143EE4", Offset = "0x1143EE4")]
		private void <OnBtnLoginClick>b__157_0()
		{
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B97")]
		[Address(RVA = "0x1467B24", Offset = "0x1467B24", VA = "0x7BBBC67B24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143EF4", Offset = "0x1143EF4")]
		private void <RefreshNewPlayerSigninState>b__189_0()
		{
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B98")]
		[Address(RVA = "0x1467BB4", Offset = "0x1467BB4", VA = "0x7BBBC67BB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F04", Offset = "0x1143F04")]
		private void <RefreshIAPBundleActivityState>b__192_0()
		{
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008B99")]
		[Address(RVA = "0x1467C1C", Offset = "0x1467C1C", VA = "0x7BBBC67C1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F14", Offset = "0x1143F14")]
		private UIBigEventIntroBaseController <ConfigBigEventIntro>b__196_0(Transform btn)
		{
			return null;
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9A")]
		[Address(RVA = "0x1467CB0", Offset = "0x1467CB0", VA = "0x7BBBC67CB0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F24", Offset = "0x1143F24")]
		private void <RefreshGoliathBtnState>b__209_0()
		{
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9B")]
		[Address(RVA = "0x1467D40", Offset = "0x1467D40", VA = "0x7BBBC67D40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F34", Offset = "0x1143F34")]
		private void <RefreshChampionshipBtnState>b__214_0()
		{
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9C")]
		[Address(RVA = "0x1467D9C", Offset = "0x1467D9C", VA = "0x7BBBC67D9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F44", Offset = "0x1143F44")]
		private void <NewbieMatchGameGuide>b__286_0()
		{
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9D")]
		[Address(RVA = "0x1467E40", Offset = "0x1467E40", VA = "0x7BBBC67E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F54", Offset = "0x1143F54")]
		private void <NewbieRankGameGuide>b__287_0()
		{
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9E")]
		[Address(RVA = "0x146800C", Offset = "0x146800C", VA = "0x7BBBC6800C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F64", Offset = "0x1143F64")]
		private void <NewbieRankGameGuide>b__287_1()
		{
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008B9F")]
		[Address(RVA = "0x1468138", Offset = "0x1468138", VA = "0x7BBBC68138")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F74", Offset = "0x1143F74")]
		private void <NewbieNonMatchAndNonRankGuide>b__294_0()
		{
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008BA0")]
		[Address(RVA = "0x1468304", Offset = "0x1468304", VA = "0x7BBBC68304")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143F84", Offset = "0x1143F84")]
		private void <NewbieNonMatchAndNonRankGuide>b__294_1()
		{
		}

		// Token: 0x04009822 RID: 38946
		[Token(Token = "0x4009822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UILobbyViewExt2 m_View;

		// Token: 0x04009823 RID: 38947
		[Token(Token = "0x4009823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x04009824 RID: 38948
		[Token(Token = "0x4009824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UIModelCustomRoom m_ModelCustomRoom;

		// Token: 0x04009825 RID: 38949
		[Token(Token = "0x4009825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04009826 RID: 38950
		[Token(Token = "0x4009826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x04009827 RID: 38951
		[Token(Token = "0x4009827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIModelLogin m_ModelLogin;

		// Token: 0x04009828 RID: 38952
		[Token(Token = "0x4009828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool season_change_panel_showed;

		// Token: 0x04009829 RID: 38953
		[Token(Token = "0x4009829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 m_BtnTutorialLocalPosCache;

		// Token: 0x0400982A RID: 38954
		[Token(Token = "0x400982A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private MapModeData m_SelectedMapData;

		// Token: 0x0400982B RID: 38955
		[Token(Token = "0x400982B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x0400982C RID: 38956
		[Token(Token = "0x400982C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private zTfbhtW m_GroupMode;

		// Token: 0x0400982D RID: 38957
		[Token(Token = "0x400982D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private zTfbhtW m_CachedGroupMode;

		// Token: 0x0400982E RID: 38958
		[Token(Token = "0x400982E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private UILobbyGroupNewController m_GroupCtrl;

		// Token: 0x0400982F RID: 38959
		[Token(Token = "0x400982F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private UIRankGuideController m_GuideCtrl;

		// Token: 0x04009830 RID: 38960
		[Token(Token = "0x4009830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private UIHudPetAnimLobbyController m_petAnimCtrl;

		// Token: 0x04009831 RID: 38961
		[Token(Token = "0x4009831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private UILobbyAdsController m_LobbyAdCtrl;

		// Token: 0x04009832 RID: 38962
		[Token(Token = "0x4009832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private UILobbyBonusEventInfoController m_SoloBonusEventInfoCtrl;

		// Token: 0x04009833 RID: 38963
		[Token(Token = "0x4009833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private UICountDownController m_NewPlayerCountDownCtrl;

		// Token: 0x04009834 RID: 38964
		[Token(Token = "0x4009834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private UICountDownController m_GoliathCountDownCtrl;

		// Token: 0x04009835 RID: 38965
		[Token(Token = "0x4009835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private UICountDownController m_ChampionshipCtrl;

		// Token: 0x04009836 RID: 38966
		[Token(Token = "0x4009836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private UICountDownController m_PaymentCountCtrl;

		// Token: 0x04009837 RID: 38967
		[Token(Token = "0x4009837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action m_OnAfterCreateGroupSuccess;

		// Token: 0x04009838 RID: 38968
		[Token(Token = "0x4009838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private UIModelUser m_ModelUser;

		// Token: 0x04009839 RID: 38969
		[Token(Token = "0x4009839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Dictionary<GameObject, bool[]> m_ButtonGroupSetting;

		// Token: 0x0400983A RID: 38970
		[Token(Token = "0x400983A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> UI3DOBJECT_NAMES;

		// Token: 0x0400983B RID: 38971
		[Token(Token = "0x400983B")]
		private const string MAP_MODE_TIPS = "map_mode_tips";

		// Token: 0x0400983C RID: 38972
		[Token(Token = "0x400983C")]
		private const string MAP_MODE_WTA_TIPS = "map_mode_wta_tips";

		// Token: 0x0400983D RID: 38973
		[Token(Token = "0x400983D")]
		private const string TEAM_MODE_TIPS = "team_mode_tips";

		// Token: 0x0400983E RID: 38974
		[Token(Token = "0x400983E")]
		private const string GAME_GUIDE_TIPS = "GAME_GUIDE_TIPS";

		// Token: 0x0400983F RID: 38975
		[Token(Token = "0x400983F")]
		private const string MANUAL_TIPS = "MANUAL_TIPS";

		// Token: 0x04009840 RID: 38976
		[Token(Token = "0x4009840")]
		public const string PET_ACTION_GUIDE = "PET_ACTION_GUIDE";

		// Token: 0x04009841 RID: 38977
		[Token(Token = "0x4009841")]
		public const string AVATAR_EMOTESHOW_GUIDE = "AVATAR_EMOTESHOW_GUIDE";

		// Token: 0x04009842 RID: 38978
		[Token(Token = "0x4009842")]
		public const string RANK_UNLOCK_TIPS = "rank_unlock_tips";

		// Token: 0x04009843 RID: 38979
		[Token(Token = "0x4009843")]
		public const string GAME_MODE_WEB_TUTORIAL = "game_mode_web_tutorial";

		// Token: 0x04009844 RID: 38980
		[Token(Token = "0x4009844")]
		public const string EP_PREORDER_TIPS = "EP_PREORDER_TIPS";

		// Token: 0x04009845 RID: 38981
		[Token(Token = "0x4009845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public uint UserRegisteOnMax;

		// Token: 0x04009846 RID: 38982
		[Token(Token = "0x4009846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private bool EsportsBubbleInAni;

		// Token: 0x04009847 RID: 38983
		[Token(Token = "0x4009847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 TEAM_TIPS_POS;

		// Token: 0x04009848 RID: 38984
		[Token(Token = "0x4009848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private UIElitePassLobbyIconController m_EPIconController;

		// Token: 0x04009849 RID: 38985
		[Token(Token = "0x4009849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private UIEPTaskEntryController m_EPTaskEntry;

		// Token: 0x0400984A RID: 38986
		[Token(Token = "0x400984A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x0400984B RID: 38987
		[Token(Token = "0x400984B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private UIPVEMapSelectionController m_PveMapCtrl;

		// Token: 0x0400984C RID: 38988
		[Token(Token = "0x400984C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private EMapDifficulty m_PveMapDifficulty;

		// Token: 0x0400984D RID: 38989
		[Token(Token = "0x400984D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private string m_EventIconDefaultName;

		// Token: 0x0400984E RID: 38990
		[Token(Token = "0x400984E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool m_RetryMapData;

		// Token: 0x0400984F RID: 38991
		[Token(Token = "0x400984F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private UIEmoteShowPanelController m_EmotePanelController;

		// Token: 0x04009850 RID: 38992
		[Token(Token = "0x4009850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private UIEquipSetSelectionLobbyController m_EquipSetSelectionController;

		// Token: 0x04009851 RID: 38993
		[Token(Token = "0x4009851")]
		public const string SECOND_RECHARGE = "SecondRecharge";

		// Token: 0x04009852 RID: 38994
		[Token(Token = "0x4009852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private UICommonGuideController m_CommonGuideCtrl;

		// Token: 0x04009853 RID: 38995
		[Token(Token = "0x4009853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private UIInviteGroupBoxController m_InviteBox;

		// Token: 0x04009854 RID: 38996
		[Token(Token = "0x4009854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private uint m_BountyShowBtnDelayCallId;

		// Token: 0x04009855 RID: 38997
		[Token(Token = "0x4009855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private uint m_DelayCallGuideId;

		// Token: 0x04009856 RID: 38998
		[Token(Token = "0x4009856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private GameObject[] m_LevelEntranceArray;

		// Token: 0x04009857 RID: 38999
		[Token(Token = "0x4009857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private GameObject m_BtnEventVFX;

		// Token: 0x04009858 RID: 39000
		[Token(Token = "0x4009858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private GameObject m_FFWSEnterAnim;

		// Token: 0x04009859 RID: 39001
		[Token(Token = "0x4009859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private string m_BtnEventAnim;

		// Token: 0x0400985A RID: 39002
		[Token(Token = "0x400985A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private float m_NextDailyTipTime;

		// Token: 0x0400985B RID: 39003
		[Token(Token = "0x400985B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private uint m_DelayCallCancelFirstGuideGameSquad;

		// Token: 0x0400985C RID: 39004
		[Token(Token = "0x400985C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private uint m_DelayCallFirstGuideGameSquadToSoloDelay;

		// Token: 0x0400985D RID: 39005
		[Token(Token = "0x400985D")]
		private const float FirstGameMatchCancelWaitSeconds = 0.1f;

		// Token: 0x0400985E RID: 39006
		[Token(Token = "0x400985E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private bool m_WaitForFirstGuideGameSquard;

		// Token: 0x0400985F RID: 39007
		[Token(Token = "0x400985F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Coroutine m_CoroutineScrollingBgCamera;

		// Token: 0x04009860 RID: 39008
		[Token(Token = "0x4009860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private float m_OriginalBgCamOrthographicSize;

		// Token: 0x04009861 RID: 39009
		[Token(Token = "0x4009861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private uint m_DelayCallOpenInviteBox;

		// Token: 0x04009862 RID: 39010
		[Token(Token = "0x4009862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private uint m_StartGameCoolDownResumeDelayID;

		// Token: 0x04009863 RID: 39011
		[Token(Token = "0x4009863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private UIModelPayment.PaymentButtonStyle m_PaymentButtonStyle;

		// Token: 0x04009864 RID: 39012
		[Token(Token = "0x4009864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool m_LateShowAvatarLimitExpireWnd;

		// Token: 0x04009865 RID: 39013
		[Token(Token = "0x4009865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Dictionary<uint, UIButton> m_BigEventEntrance;

		// Token: 0x04009866 RID: 39014
		[Token(Token = "0x4009866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Dictionary<uint, Transform> m_BigEventCountDownContainer;

		// Token: 0x04009867 RID: 39015
		[Token(Token = "0x4009867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Dictionary<uint, Action> m_BigEventEntranceAction;

		// Token: 0x04009868 RID: 39016
		[Token(Token = "0x4009868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Dictionary<uint, uint> m_BigEventActivitySubType2EventId;

		// Token: 0x04009869 RID: 39017
		[Token(Token = "0x4009869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Dictionary<uint, Func<Transform, UIBigEventIntroBaseController>> m_BigEventIntroCallback;

		// Token: 0x0400986A RID: 39018
		[Token(Token = "0x400986A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private Dictionary<uint, UICountDownController> m_BigEventCountDownCtrl;

		// Token: 0x0400986B RID: 39019
		[Token(Token = "0x400986B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Dictionary<uint, Coroutine> m_BigEventWaitForOpenCoroutine;

		// Token: 0x0400986C RID: 39020
		[Token(Token = "0x400986C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Dictionary<uint, UIBigEventIntroBaseController> m_BigEventIntroCtrl;

		// Token: 0x0400986D RID: 39021
		[Token(Token = "0x400986D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Dictionary<uint, uint> m_BigEventIntroInShowing;

		// Token: 0x0400986E RID: 39022
		[Token(Token = "0x400986E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private UILobbyIAPBundleController m_LobbyIAPBundleController;

		// Token: 0x0400986F RID: 39023
		[Token(Token = "0x400986F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool m_ShouldShowPaymentButton;

		// Token: 0x04009870 RID: 39024
		[Token(Token = "0x4009870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private readonly int BEFORE_STARTGAME_GUIDE_TIME;

		// Token: 0x04009871 RID: 39025
		[Token(Token = "0x4009871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private uint m_StartGameGuideCall;

		// Token: 0x04009872 RID: 39026
		[Token(Token = "0x4009872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private uint m_DelayShowMask;

		// Token: 0x04009873 RID: 39027
		[Token(Token = "0x4009873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private UIWidget m_GeneralGuideWidget;

		// Token: 0x04009874 RID: 39028
		[Token(Token = "0x4009874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Queue<Action> m_GuideQueue;

		// Token: 0x04009875 RID: 39029
		[Token(Token = "0x4009875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool m_NewbieGuideTriggered;

		// Token: 0x02001A0B RID: 6667
		[Token(Token = "0x2001A0B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77A4", Offset = "0x10F77A4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008BA2 RID: 35746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BA2")]
			[Address(RVA = "0x19D37AC", Offset = "0x19D37AC", VA = "0x7BBC1D37AC")]
			public <>c()
			{
			}

			// Token: 0x06008BA3 RID: 35747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BA3")]
			[Address(RVA = "0x19D37B4", Offset = "0x19D37B4", VA = "0x7BBC1D37B4")]
			internal void <OnUIInit>b__77_0()
			{
			}

			// Token: 0x06008BA4 RID: 35748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BA4")]
			[Address(RVA = "0x19D3854", Offset = "0x19D3854", VA = "0x7BBC1D3854")]
			internal void <CheckPlayerLimitsAndAutoSelectGroupMode>b__131_1()
			{
			}

			// Token: 0x06008BA5 RID: 35749 RVA: 0x000254D0 File Offset: 0x000236D0
			[Token(Token = "0x6008BA5")]
			[Address(RVA = "0x19D3858", Offset = "0x19D3858", VA = "0x7BBC1D3858")]
			internal bool <NewbieNonPVEGuide>b__289_0(MapModeData temp)
			{
				return default(bool);
			}

			// Token: 0x04009876 RID: 39030
			[Token(Token = "0x4009876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UILobbyNewController.<>c <>9;

			// Token: 0x04009877 RID: 39031
			[Token(Token = "0x4009877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static EventDelegate.Callback <>9__77_0;

			// Token: 0x04009878 RID: 39032
			[Token(Token = "0x4009878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__131_1;

			// Token: 0x04009879 RID: 39033
			[Token(Token = "0x4009879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<MapModeData> <>9__289_0;
		}

		// Token: 0x02001A0C RID: 6668
		[Token(Token = "0x2001A0C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77B4", Offset = "0x10F77B4")]
		private sealed class <HideOverMask>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BA6 RID: 35750 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BA6")]
			[Address(RVA = "0x19D445C", Offset = "0x19D445C", VA = "0x7BBC1D445C")]
			[DebuggerHidden]
			public <HideOverMask>d__83(int <>1__state)
			{
			}

			// Token: 0x06008BA7 RID: 35751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BA7")]
			[Address(RVA = "0x19D4488", Offset = "0x19D4488", VA = "0x7BBC1D4488", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BA8 RID: 35752 RVA: 0x000254E8 File Offset: 0x000236E8
			[Token(Token = "0x6008BA8")]
			[Address(RVA = "0x19D448C", Offset = "0x19D448C", VA = "0x7BBC1D448C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06008BA9 RID: 35753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C9")]
			private object Current
			{
				[Token(Token = "0x6008BA9")]
				[Address(RVA = "0x19D454C", Offset = "0x19D454C", VA = "0x7BBC1D454C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BAA RID: 35754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BAA")]
			[Address(RVA = "0x19D4554", Offset = "0x19D4554", VA = "0x7BBC1D4554", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CA")]
			private object Current
			{
				[Token(Token = "0x6008BAB")]
				[Address(RVA = "0x19D45BC", Offset = "0x19D45BC", VA = "0x7BBC1D45BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400987A RID: 39034
			[Token(Token = "0x400987A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400987B RID: 39035
			[Token(Token = "0x400987B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400987C RID: 39036
			[Token(Token = "0x400987C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			// Token: 0x0400987D RID: 39037
			[Token(Token = "0x400987D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UILobbyNewController <>4__this;
		}

		// Token: 0x02001A0D RID: 6669
		[Token(Token = "0x2001A0D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77C4", Offset = "0x10F77C4")]
		private sealed class <StartShowGuide>d__105 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BAC RID: 35756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BAC")]
			[Address(RVA = "0x19D4788", Offset = "0x19D4788", VA = "0x7BBC1D4788")]
			[DebuggerHidden]
			public <StartShowGuide>d__105(int <>1__state)
			{
			}

			// Token: 0x06008BAD RID: 35757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BAD")]
			[Address(RVA = "0x19D47B4", Offset = "0x19D47B4", VA = "0x7BBC1D47B4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BAE RID: 35758 RVA: 0x00025500 File Offset: 0x00023700
			[Token(Token = "0x6008BAE")]
			[Address(RVA = "0x19D47B8", Offset = "0x19D47B8", VA = "0x7BBC1D47B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x06008BAF RID: 35759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CB")]
			private object Current
			{
				[Token(Token = "0x6008BAF")]
				[Address(RVA = "0x19D4E8C", Offset = "0x19D4E8C", VA = "0x7BBC1D4E8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BB0 RID: 35760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB0")]
			[Address(RVA = "0x19D4E94", Offset = "0x19D4E94", VA = "0x7BBC1D4E94", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x06008BB1 RID: 35761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CC")]
			private object Current
			{
				[Token(Token = "0x6008BB1")]
				[Address(RVA = "0x19D4EFC", Offset = "0x19D4EFC", VA = "0x7BBC1D4EFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400987E RID: 39038
			[Token(Token = "0x400987E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400987F RID: 39039
			[Token(Token = "0x400987F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009880 RID: 39040
			[Token(Token = "0x4009880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyNewController <>4__this;
		}

		// Token: 0x02001A0E RID: 6670
		[Token(Token = "0x2001A0E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77D4", Offset = "0x10F77D4")]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x06008BB2 RID: 35762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB2")]
			[Address(RVA = "0x19D388C", Offset = "0x19D388C", VA = "0x7BBC1D388C")]
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x04009881 RID: 39041
			[Token(Token = "0x4009881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UILobbyNewController <>4__this;

			// Token: 0x04009882 RID: 39042
			[Token(Token = "0x4009882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MapModeData cachedMap;
		}

		// Token: 0x02001A0F RID: 6671
		[Token(Token = "0x2001A0F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77E4", Offset = "0x10F77E4")]
		private sealed class <>c__DisplayClass131_1
		{
			// Token: 0x06008BB3 RID: 35763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB3")]
			[Address(RVA = "0x19D3894", Offset = "0x19D3894", VA = "0x7BBC1D3894")]
			public <>c__DisplayClass131_1()
			{
			}

			// Token: 0x06008BB4 RID: 35764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB4")]
			[Address(RVA = "0x19D389C", Offset = "0x19D389C", VA = "0x7BBC1D389C")]
			internal void <CheckPlayerLimitsAndAutoSelectGroupMode>b__0()
			{
			}

			// Token: 0x04009883 RID: 39043
			[Token(Token = "0x4009883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<uint> playerLimitList;

			// Token: 0x04009884 RID: 39044
			[Token(Token = "0x4009884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UILobbyNewController.<>c__DisplayClass131_0 CS$<>8__locals1;
		}

		// Token: 0x02001A10 RID: 6672
		[Token(Token = "0x2001A10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F77F4", Offset = "0x10F77F4")]
		private sealed class <CloseGroupModePanel>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BB5 RID: 35765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB5")]
			[Address(RVA = "0x19D3DF0", Offset = "0x19D3DF0", VA = "0x7BBC1D3DF0")]
			[DebuggerHidden]
			public <CloseGroupModePanel>d__133(int <>1__state)
			{
			}

			// Token: 0x06008BB6 RID: 35766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB6")]
			[Address(RVA = "0x19D3E1C", Offset = "0x19D3E1C", VA = "0x7BBC1D3E1C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BB7 RID: 35767 RVA: 0x00025518 File Offset: 0x00023718
			[Token(Token = "0x6008BB7")]
			[Address(RVA = "0x19D3E20", Offset = "0x19D3E20", VA = "0x7BBC1D3E20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x06008BB8 RID: 35768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CD")]
			private object Current
			{
				[Token(Token = "0x6008BB8")]
				[Address(RVA = "0x19D3EE4", Offset = "0x19D3EE4", VA = "0x7BBC1D3EE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BB9 RID: 35769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BB9")]
			[Address(RVA = "0x19D3EEC", Offset = "0x19D3EEC", VA = "0x7BBC1D3EEC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x06008BBA RID: 35770 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CE")]
			private object Current
			{
				[Token(Token = "0x6008BBA")]
				[Address(RVA = "0x19D3F54", Offset = "0x19D3F54", VA = "0x7BBC1D3F54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009885 RID: 39045
			[Token(Token = "0x4009885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009886 RID: 39046
			[Token(Token = "0x4009886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009887 RID: 39047
			[Token(Token = "0x4009887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			// Token: 0x04009888 RID: 39048
			[Token(Token = "0x4009888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UILobbyNewController <>4__this;
		}

		// Token: 0x02001A11 RID: 6673
		[Token(Token = "0x2001A11")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7804", Offset = "0x10F7804")]
		private sealed class <CloseMapModePanel>d__144 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BBB RID: 35771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BBB")]
			[Address(RVA = "0x19D3F5C", Offset = "0x19D3F5C", VA = "0x7BBC1D3F5C")]
			[DebuggerHidden]
			public <CloseMapModePanel>d__144(int <>1__state)
			{
			}

			// Token: 0x06008BBC RID: 35772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BBC")]
			[Address(RVA = "0x19D3F88", Offset = "0x19D3F88", VA = "0x7BBC1D3F88", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BBD RID: 35773 RVA: 0x00025530 File Offset: 0x00023730
			[Token(Token = "0x6008BBD")]
			[Address(RVA = "0x19D3F8C", Offset = "0x19D3F8C", VA = "0x7BBC1D3F8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009CF RID: 2511
			// (get) Token: 0x06008BBE RID: 35774 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009CF")]
			private object Current
			{
				[Token(Token = "0x6008BBE")]
				[Address(RVA = "0x19D4050", Offset = "0x19D4050", VA = "0x7BBC1D4050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BBF RID: 35775 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BBF")]
			[Address(RVA = "0x19D4058", Offset = "0x19D4058", VA = "0x7BBC1D4058", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009D0 RID: 2512
			// (get) Token: 0x06008BC0 RID: 35776 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D0")]
			private object Current
			{
				[Token(Token = "0x6008BC0")]
				[Address(RVA = "0x19D40C0", Offset = "0x19D40C0", VA = "0x7BBC1D40C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009889 RID: 39049
			[Token(Token = "0x4009889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400988A RID: 39050
			[Token(Token = "0x400988A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400988B RID: 39051
			[Token(Token = "0x400988B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			// Token: 0x0400988C RID: 39052
			[Token(Token = "0x400988C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UILobbyNewController <>4__this;
		}

		// Token: 0x02001A12 RID: 6674
		[Token(Token = "0x2001A12")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7814", Offset = "0x10F7814")]
		private sealed class <>c__DisplayClass198_0
		{
			// Token: 0x06008BC1 RID: 35777 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC1")]
			[Address(RVA = "0x19D3BC0", Offset = "0x19D3BC0", VA = "0x7BBC1D3BC0")]
			public <>c__DisplayClass198_0()
			{
			}

			// Token: 0x06008BC2 RID: 35778 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC2")]
			[Address(RVA = "0x19D3BC8", Offset = "0x19D3BC8", VA = "0x7BBC1D3BC8")]
			internal void <SetBigEventCountDown>b__0()
			{
			}

			// Token: 0x0400988D RID: 39053
			[Token(Token = "0x400988D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public proto.ELimitedEvent.EventState eventState;

			// Token: 0x0400988E RID: 39054
			[Token(Token = "0x400988E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UILobbyNewController <>4__this;

			// Token: 0x0400988F RID: 39055
			[Token(Token = "0x400988F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public proto.ELimitedEvent.EventID eventId;
		}

		// Token: 0x02001A13 RID: 6675
		[Token(Token = "0x2001A13")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7824", Offset = "0x10F7824")]
		private sealed class <WaitForBigEventProcessOpen>d__204 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BC3 RID: 35779 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC3")]
			[Address(RVA = "0x19D4F04", Offset = "0x19D4F04", VA = "0x7BBC1D4F04")]
			[DebuggerHidden]
			public <WaitForBigEventProcessOpen>d__204(int <>1__state)
			{
			}

			// Token: 0x06008BC4 RID: 35780 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC4")]
			[Address(RVA = "0x19D4F30", Offset = "0x19D4F30", VA = "0x7BBC1D4F30", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BC5 RID: 35781 RVA: 0x00025548 File Offset: 0x00023748
			[Token(Token = "0x6008BC5")]
			[Address(RVA = "0x19D4F34", Offset = "0x19D4F34", VA = "0x7BBC1D4F34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x06008BC6 RID: 35782 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D1")]
			private object Current
			{
				[Token(Token = "0x6008BC6")]
				[Address(RVA = "0x19D50E0", Offset = "0x19D50E0", VA = "0x7BBC1D50E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BC7 RID: 35783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC7")]
			[Address(RVA = "0x19D50E8", Offset = "0x19D50E8", VA = "0x7BBC1D50E8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x06008BC8 RID: 35784 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D2")]
			private object Current
			{
				[Token(Token = "0x6008BC8")]
				[Address(RVA = "0x19D5150", Offset = "0x19D5150", VA = "0x7BBC1D5150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009890 RID: 39056
			[Token(Token = "0x4009890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009891 RID: 39057
			[Token(Token = "0x4009891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04009892 RID: 39058
			[Token(Token = "0x4009892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyNewController <>4__this;

			// Token: 0x04009893 RID: 39059
			[Token(Token = "0x4009893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public proto.ELimitedEvent.EventID eventId;
		}

		// Token: 0x02001A14 RID: 6676
		[Token(Token = "0x2001A14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7834", Offset = "0x10F7834")]
		private sealed class <>c__DisplayClass205_0
		{
			// Token: 0x06008BC9 RID: 35785 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BC9")]
			[Address(RVA = "0x19D3C44", Offset = "0x19D3C44", VA = "0x7BBC1D3C44")]
			public <>c__DisplayClass205_0()
			{
			}

			// Token: 0x06008BCA RID: 35786 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BCA")]
			[Address(RVA = "0x19D3C4C", Offset = "0x19D3C4C", VA = "0x7BBC1D3C4C")]
			internal void <ShowBigEventIntroIfNeed>b__0()
			{
			}

			// Token: 0x04009894 RID: 39060
			[Token(Token = "0x4009894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UILobbyNewController <>4__this;

			// Token: 0x04009895 RID: 39061
			[Token(Token = "0x4009895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public proto.ELimitedEvent.EventID eventId;

			// Token: 0x04009896 RID: 39062
			[Token(Token = "0x4009896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public EBigEventIntroTiming timing;
		}

		// Token: 0x02001A15 RID: 6677
		[Token(Token = "0x2001A15")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7844", Offset = "0x10F7844")]
		private sealed class <WaitForNextAFKGroupFinish>d__212 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BCB RID: 35787 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BCB")]
			[Address(RVA = "0x19D5360", Offset = "0x19D5360", VA = "0x7BBC1D5360")]
			[DebuggerHidden]
			public <WaitForNextAFKGroupFinish>d__212(int <>1__state)
			{
			}

			// Token: 0x06008BCC RID: 35788 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BCC")]
			[Address(RVA = "0x19D538C", Offset = "0x19D538C", VA = "0x7BBC1D538C", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BCD RID: 35789 RVA: 0x00025560 File Offset: 0x00023760
			[Token(Token = "0x6008BCD")]
			[Address(RVA = "0x19D5390", Offset = "0x19D5390", VA = "0x7BBC1D5390", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x06008BCE RID: 35790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D3")]
			private object Current
			{
				[Token(Token = "0x6008BCE")]
				[Address(RVA = "0x19D55A0", Offset = "0x19D55A0", VA = "0x7BBC1D55A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BCF RID: 35791 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BCF")]
			[Address(RVA = "0x19D55A8", Offset = "0x19D55A8", VA = "0x7BBC1D55A8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D4")]
			private object Current
			{
				[Token(Token = "0x6008BD0")]
				[Address(RVA = "0x19D5610", Offset = "0x19D5610", VA = "0x7BBC1D5610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04009897 RID: 39063
			[Token(Token = "0x4009897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04009898 RID: 39064
			[Token(Token = "0x4009898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;
		}

		// Token: 0x02001A16 RID: 6678
		[Token(Token = "0x2001A16")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7854", Offset = "0x10F7854")]
		private sealed class <>c__DisplayClass248_0
		{
			// Token: 0x06008BD1 RID: 35793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BD1")]
			[Address(RVA = "0x19D3D58", Offset = "0x19D3D58", VA = "0x7BBC1D3D58")]
			public <>c__DisplayClass248_0()
			{
			}

			// Token: 0x06008BD2 RID: 35794 RVA: 0x00025578 File Offset: 0x00023778
			[Token(Token = "0x6008BD2")]
			[Address(RVA = "0x19D3D60", Offset = "0x19D3D60", VA = "0x7BBC1D3D60")]
			internal bool <OnPetShowActionClick>b__0(PetActionInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009899 RID: 39065
			[Token(Token = "0x4009899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PetActionData data;
		}

		// Token: 0x02001A17 RID: 6679
		[Token(Token = "0x2001A17")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7864", Offset = "0x10F7864")]
		private sealed class <LadderMatchDailyCoroutine>d__255 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BD3 RID: 35795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BD3")]
			[Address(RVA = "0x19D45C4", Offset = "0x19D45C4", VA = "0x7BBC1D45C4")]
			[DebuggerHidden]
			public <LadderMatchDailyCoroutine>d__255(int <>1__state)
			{
			}

			// Token: 0x06008BD4 RID: 35796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BD4")]
			[Address(RVA = "0x19D45F0", Offset = "0x19D45F0", VA = "0x7BBC1D45F0", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BD5 RID: 35797 RVA: 0x00025590 File Offset: 0x00023790
			[Token(Token = "0x6008BD5")]
			[Address(RVA = "0x19D45F4", Offset = "0x19D45F4", VA = "0x7BBC1D45F4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D5")]
			private object Current
			{
				[Token(Token = "0x6008BD6")]
				[Address(RVA = "0x19D4710", Offset = "0x19D4710", VA = "0x7BBC1D4710", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BD7 RID: 35799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BD7")]
			[Address(RVA = "0x19D4718", Offset = "0x19D4718", VA = "0x7BBC1D4718", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D6")]
			private object Current
			{
				[Token(Token = "0x6008BD8")]
				[Address(RVA = "0x19D4780", Offset = "0x19D4780", VA = "0x7BBC1D4780", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400989A RID: 39066
			[Token(Token = "0x400989A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400989B RID: 39067
			[Token(Token = "0x400989B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400989C RID: 39068
			[Token(Token = "0x400989C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyNewController <>4__this;
		}

		// Token: 0x02001A18 RID: 6680
		[Token(Token = "0x2001A18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7874", Offset = "0x10F7874")]
		private sealed class <CoroutineScrollingBgCamera>d__271 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BD9 RID: 35801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BD9")]
			[Address(RVA = "0x19D40C8", Offset = "0x19D40C8", VA = "0x7BBC1D40C8")]
			[DebuggerHidden]
			public <CoroutineScrollingBgCamera>d__271(int <>1__state)
			{
			}

			// Token: 0x06008BDA RID: 35802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BDA")]
			[Address(RVA = "0x19D40F4", Offset = "0x19D40F4", VA = "0x7BBC1D40F4", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BDB RID: 35803 RVA: 0x000255A8 File Offset: 0x000237A8
			[Token(Token = "0x6008BDB")]
			[Address(RVA = "0x19D40F8", Offset = "0x19D40F8", VA = "0x7BBC1D40F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x06008BDC RID: 35804 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D7")]
			private object Current
			{
				[Token(Token = "0x6008BDC")]
				[Address(RVA = "0x19D43E4", Offset = "0x19D43E4", VA = "0x7BBC1D43E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BDD RID: 35805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BDD")]
			[Address(RVA = "0x19D43EC", Offset = "0x19D43EC", VA = "0x7BBC1D43EC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x06008BDE RID: 35806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D8")]
			private object Current
			{
				[Token(Token = "0x6008BDE")]
				[Address(RVA = "0x19D4454", Offset = "0x19D4454", VA = "0x7BBC1D4454", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0400989D RID: 39069
			[Token(Token = "0x400989D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400989E RID: 39070
			[Token(Token = "0x400989E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400989F RID: 39071
			[Token(Token = "0x400989F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyNewController <>4__this;

			// Token: 0x040098A0 RID: 39072
			[Token(Token = "0x40098A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float needSize;

			// Token: 0x040098A1 RID: 39073
			[Token(Token = "0x40098A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Camera <cam>5__2;

			// Token: 0x040098A2 RID: 39074
			[Token(Token = "0x40098A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <currentSize>5__3;
		}

		// Token: 0x02001A19 RID: 6681
		[Token(Token = "0x2001A19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7884", Offset = "0x10F7884")]
		private sealed class <>c__DisplayClass272_0
		{
			// Token: 0x06008BDF RID: 35807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BDF")]
			[Address(RVA = "0x19D3DAC", Offset = "0x19D3DAC", VA = "0x7BBC1D3DAC")]
			public <>c__DisplayClass272_0()
			{
			}

			// Token: 0x06008BE0 RID: 35808 RVA: 0x000255C0 File Offset: 0x000237C0
			[Token(Token = "0x6008BE0")]
			[Address(RVA = "0x19D3DB4", Offset = "0x19D3DB4", VA = "0x7BBC1D3DB4")]
			internal bool <StartCertainMode>b__0(MapModeData temp)
			{
				return default(bool);
			}

			// Token: 0x040098A3 RID: 39075
			[Token(Token = "0x40098A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint mode;
		}

		// Token: 0x02001A1A RID: 6682
		[Token(Token = "0x2001A1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F7894", Offset = "0x10F7894")]
		private sealed class <WaitForGoliathOpen>d__298 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06008BE1 RID: 35809 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BE1")]
			[Address(RVA = "0x19D5158", Offset = "0x19D5158", VA = "0x7BBC1D5158")]
			[DebuggerHidden]
			public <WaitForGoliathOpen>d__298(int <>1__state)
			{
			}

			// Token: 0x06008BE2 RID: 35810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BE2")]
			[Address(RVA = "0x19D5184", Offset = "0x19D5184", VA = "0x7BBC1D5184", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06008BE3 RID: 35811 RVA: 0x000255D8 File Offset: 0x000237D8
			[Token(Token = "0x6008BE3")]
			[Address(RVA = "0x19D5188", Offset = "0x19D5188", VA = "0x7BBC1D5188", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009D9")]
			private object Current
			{
				[Token(Token = "0x6008BE4")]
				[Address(RVA = "0x19D52E8", Offset = "0x19D52E8", VA = "0x7BBC1D52E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06008BE5 RID: 35813 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008BE5")]
			[Address(RVA = "0x19D52F0", Offset = "0x19D52F0", VA = "0x7BBC1D52F0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009DA")]
			private object Current
			{
				[Token(Token = "0x6008BE6")]
				[Address(RVA = "0x19D5358", Offset = "0x19D5358", VA = "0x7BBC1D5358", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040098A4 RID: 39076
			[Token(Token = "0x40098A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040098A5 RID: 39077
			[Token(Token = "0x40098A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040098A6 RID: 39078
			[Token(Token = "0x40098A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILobbyNewController <>4__this;
		}
	}
}
