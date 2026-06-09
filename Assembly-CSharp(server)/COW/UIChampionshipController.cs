using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x0200146C RID: 5228
	[Token(Token = "0x200146C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ECD58", Offset = "0x10ECD58")]
	public class UIChampionshipController : UINavigationController, IUIModelDataChangeObserver
	{
		// Token: 0x060057EC RID: 22508 RVA: 0x00019FE0 File Offset: 0x000181E0
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0x1C27E00", Offset = "0x1C27E00", VA = "0x7BBC427E00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0x1C27E50", Offset = "0x1C27E50", VA = "0x7BBC427E50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x1C28F98", Offset = "0x1C28F98", VA = "0x7BBC428F98", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x1C29154", Offset = "0x1C29154", VA = "0x7BBC429154", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x1C2ABC0", Offset = "0x1C2ABC0", VA = "0x7BBC42ABC0", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x060057F1 RID: 22513 RVA: 0x00019FF8 File Offset: 0x000181F8
		[Token(Token = "0x60057F1")]
		[Address(RVA = "0x1C2B13C", Offset = "0x1C2B13C", VA = "0x7BBC42B13C", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x060057F2 RID: 22514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x1C28604", Offset = "0x1C28604", VA = "0x7BBC428604")]
		private void InitRewardContainer()
		{
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x1C28990", Offset = "0x1C28990", VA = "0x7BBC428990")]
		private void InitLookUpDict()
		{
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x1C2A54C", Offset = "0x1C2A54C", VA = "0x7BBC42A54C")]
		private void CreateTabs()
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x1C2A358", Offset = "0x1C2A358", VA = "0x7BBC42A358")]
		private void CreateTeamPage()
		{
		}

		// Token: 0x060057F6 RID: 22518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057F6")]
		[Address(RVA = "0x1C2B144", Offset = "0x1C2B144", VA = "0x7BBC42B144")]
		public UIChampionshipTeamProfileSelfController GetTeamCtrl()
		{
			return null;
		}

		// Token: 0x060057F7 RID: 22519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F7")]
		[Address(RVA = "0x1C29908", Offset = "0x1C29908", VA = "0x7BBC429908")]
		private void RefreshView()
		{
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F8")]
		[Address(RVA = "0x1C2BC04", Offset = "0x1C2BC04", VA = "0x7BBC42BC04")]
		private void RefreshMatchStateInfo()
		{
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F9")]
		[Address(RVA = "0x1C2B14C", Offset = "0x1C2B14C", VA = "0x7BBC42B14C")]
		private void RefreshMainPageInfo()
		{
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FA")]
		[Address(RVA = "0x1C2ABE8", Offset = "0x1C2ABE8", VA = "0x7BBC42ABE8")]
		private void UpdateTabRedPoint()
		{
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x1C29568", Offset = "0x1C29568", VA = "0x7BBC429568")]
		protected void SetCDNBG()
		{
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x1C2C0C0", Offset = "0x1C2C0C0", VA = "0x7BBC42C0C0")]
		private void RequestLeaderBoardFriend(bool force)
		{
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x1C29778", Offset = "0x1C29778", VA = "0x7BBC429778")]
		private void RequestLeaderBoardRegion(bool force)
		{
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x1C2C0C4", Offset = "0x1C2C0C4", VA = "0x7BBC42C0C4")]
		private void RefreshLeardBoard()
		{
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0x1C2C238", Offset = "0x1C2C238", VA = "0x7BBC42C238")]
		private void RefreshSelfLeardBoard()
		{
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x1C2C300", Offset = "0x1C2C300", VA = "0x7BBC42C300")]
		private void RefreshGameResult()
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005801")]
		[Address(RVA = "0x1C2B9FC", Offset = "0x1C2B9FC", VA = "0x7BBC42B9FC")]
		private void RefreshSeasonInfo()
		{
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005802")]
		[Address(RVA = "0x1C2CB64", Offset = "0x1C2CB64", VA = "0x7BBC42CB64", Slot = "41")]
		protected virtual void RefreshCupIcon()
		{
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005803")]
		[Address(RVA = "0x1C2CE40", Offset = "0x1C2CE40", VA = "0x7BBC42CE40")]
		private void RefreshRankReward()
		{
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005804")]
		[Address(RVA = "0x1C2C0B8", Offset = "0x1C2C0B8", VA = "0x7BBC42C0B8")]
		private void SetRankReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, [Optional] List<Transform> parentContainerList)
		{
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x0001A010 File Offset: 0x00018210
		[Token(Token = "0x6005805")]
		[Address(RVA = "0x1C2CFA8", Offset = "0x1C2CFA8", VA = "0x7BBC42CFA8")]
		private bool CheckRankRangUp(int rankBefore, int rankNow)
		{
			return default(bool);
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005806")]
		[Address(RVA = "0x1C2D05C", Offset = "0x1C2D05C", VA = "0x7BBC42D05C")]
		private void RefreshPosReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, [Optional] List<Transform> parentContainerList)
		{
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005807")]
		[Address(RVA = "0x1C29B04", Offset = "0x1C29B04", VA = "0x7BBC429B04")]
		private void SetStartMatchBtnState()
		{
		}

		// Token: 0x06005808 RID: 22536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005808")]
		[Address(RVA = "0x1C29C34", Offset = "0x1C29C34", VA = "0x7BBC429C34")]
		private void SetMainPageTeamBtnState()
		{
		}

		// Token: 0x06005809 RID: 22537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005809")]
		[Address(RVA = "0x1C2D548", Offset = "0x1C2D548", VA = "0x7BBC42D548")]
		private string CheckCanStartMatch()
		{
			return null;
		}

		// Token: 0x0600580A RID: 22538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580A")]
		[Address(RVA = "0x1C2D990", Offset = "0x1C2D990", VA = "0x7BBC42D990")]
		protected object GetView()
		{
			return null;
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580B")]
		[Address(RVA = "0x1C2BB8C", Offset = "0x1C2BB8C", VA = "0x7BBC42BB8C")]
		private void RefreshNoticeBtn()
		{
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x0001A028 File Offset: 0x00018228
		[Token(Token = "0x600580C")]
		[Address(RVA = "0x1C2D998", Offset = "0x1C2D998", VA = "0x7BBC42D998")]
		private bool ShowNotice()
		{
			return default(bool);
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580D")]
		[Address(RVA = "0x1C2D9B8", Offset = "0x1C2D9B8", VA = "0x7BBC42D9B8", Slot = "42")]
		protected virtual void AutoShowNotice()
		{
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580E")]
		[Address(RVA = "0x1C2DA78", Offset = "0x1C2DA78", VA = "0x7BBC42DA78")]
		private void ShowNoticeWnd()
		{
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580F")]
		[Address(RVA = "0x1C2BC80", Offset = "0x1C2BC80", VA = "0x7BBC42BC80")]
		private void RefreshChampionReward()
		{
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005810")]
		[Address(RVA = "0x1C2DBE8", Offset = "0x1C2DBE8", VA = "0x7BBC42DBE8")]
		private void OnStartMatchBtnClick()
		{
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005811")]
		[Address(RVA = "0x1C2E048", Offset = "0x1C2E048", VA = "0x7BBC42E048")]
		private void OnShowAllRewardBtnClick()
		{
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005812")]
		[Address(RVA = "0x1C2E17C", Offset = "0x1C2E17C", VA = "0x7BBC42E17C")]
		private void OnGameStatsBtnClick()
		{
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005813")]
		[Address(RVA = "0x1C2E3DC", Offset = "0x1C2E3DC", VA = "0x7BBC42E3DC")]
		private void OnSeasonTipsBtnClick()
		{
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005814")]
		[Address(RVA = "0x1C2EB58", Offset = "0x1C2EB58", VA = "0x7BBC42EB58")]
		private void OnNoticyBtnClick()
		{
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005815")]
		[Address(RVA = "0x1C2EB5C", Offset = "0x1C2EB5C", VA = "0x7BBC42EB5C")]
		private void OnMapModeSelecteSuccess(object[] param)
		{
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005816")]
		[Address(RVA = "0x1C2EBDC", Offset = "0x1C2EBDC", VA = "0x7BBC42EBDC")]
		private void AnimationEventHandler(params object[] data)
		{
		}

		// Token: 0x06005817 RID: 22551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005817")]
		[Address(RVA = "0x1C2ED7C", Offset = "0x1C2ED7C", VA = "0x7BBC42ED7C")]
		public void OnBtnMainPageClick()
		{
		}

		// Token: 0x06005818 RID: 22552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005818")]
		[Address(RVA = "0x1C2EEE8", Offset = "0x1C2EEE8", VA = "0x7BBC42EEE8")]
		public void OnBtnTeamPageClick()
		{
		}

		// Token: 0x06005819 RID: 22553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005819")]
		[Address(RVA = "0x1C2F1FC", Offset = "0x1C2F1FC", VA = "0x7BBC42F1FC")]
		public void OnBtnLadderPageClick()
		{
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x1C2F360", Offset = "0x1C2F360", VA = "0x7BBC42F360")]
		public void OnBtnMainPageSignUpClick()
		{
		}

		// Token: 0x0600581B RID: 22555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581B")]
		[Address(RVA = "0x1C2F3F8", Offset = "0x1C2F3F8", VA = "0x7BBC42F3F8")]
		private void ShowChampionshipRecruitWnd(object[] param)
		{
		}

		// Token: 0x0600581C RID: 22556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581C")]
		[Address(RVA = "0x1C2F4CC", Offset = "0x1C2F4CC", VA = "0x7BBC42F4CC")]
		private void GotoTeamPage()
		{
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581D")]
		[Address(RVA = "0x1C2F518", Offset = "0x1C2F518", VA = "0x7BBC42F518")]
		private void GotoLadderPage()
		{
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581E")]
		[Address(RVA = "0x1C2EE0C", Offset = "0x1C2EE0C", VA = "0x7BBC42EE0C")]
		private void ShowMainPage()
		{
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581F")]
		[Address(RVA = "0x1C2F104", Offset = "0x1C2F104", VA = "0x7BBC42F104")]
		private void ShowTeamPage()
		{
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005820")]
		[Address(RVA = "0x1C2F244", Offset = "0x1C2F244", VA = "0x7BBC42F244")]
		private void ShowLadderPage()
		{
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005821")]
		[Address(RVA = "0x1C2F550", Offset = "0x1C2F550", VA = "0x7BBC42F550")]
		private void OnBtnRecuitClick()
		{
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005822")]
		[Address(RVA = "0x1C2F5FC", Offset = "0x1C2F5FC", VA = "0x7BBC42F5FC", Slot = "39")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x0001A040 File Offset: 0x00018240
		[Token(Token = "0x6005823")]
		[Address(RVA = "0x1C2F89C", Offset = "0x1C2F89C", VA = "0x7BBC42F89C", Slot = "40")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005824")]
		[Address(RVA = "0x1C2F964", Offset = "0x1C2F964", VA = "0x7BBC42F964")]
		public UIChampionshipController()
		{
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005825")]
		[Address(RVA = "0x1C2FA40", Offset = "0x1C2FA40", VA = "0x7BBC42FA40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F2B0", Offset = "0x113F2B0")]
		private void <OnUIInit>b__38_0(UIToggleButton e)
		{
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005826")]
		[Address(RVA = "0x1C2FA64", Offset = "0x1C2FA64", VA = "0x7BBC42FA64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F2C0", Offset = "0x113F2C0")]
		private void <CreateTeamPage>b__46_0()
		{
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005827")]
		[Address(RVA = "0x1C2FA9C", Offset = "0x1C2FA9C", VA = "0x7BBC42FA9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F2D0", Offset = "0x113F2D0")]
		private string <RefreshMainPageInfo>b__50_0(uint item)
		{
			return null;
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0001A058 File Offset: 0x00018258
		[Token(Token = "0x6005828")]
		[Address(RVA = "0x1C2FAF4", Offset = "0x1C2FAF4", VA = "0x7BBC42FAF4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F2E0", Offset = "0x113F2E0")]
		private bool <SetCDNBG>b__52_0(AdvertDesc ad)
		{
			return default(bool);
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005829")]
		[Address(RVA = "0x1C2FB30", Offset = "0x1C2FB30", VA = "0x7BBC42FB30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F2F0", Offset = "0x113F2F0")]
		private void <OnStartMatchBtnClick>b__73_0()
		{
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582A")]
		[Address(RVA = "0x1C2FB74", Offset = "0x1C2FB74", VA = "0x7BBC42FB74")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F300", Offset = "0x113F300")]
		private void <OnStartMatchBtnClick>b__73_1()
		{
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582B")]
		[Address(RVA = "0x1C2FBB8", Offset = "0x1C2FBB8", VA = "0x7BBC42FBB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F310", Offset = "0x113F310")]
		private void <OnStartMatchBtnClick>b__73_2()
		{
		}

		// Token: 0x04007BF9 RID: 31737
		[Token(Token = "0x4007BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UIChampionshipView m_View;

		// Token: 0x04007BFA RID: 31738
		[Token(Token = "0x4007BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected UIModelChampionship m_ModelChampionship;

		// Token: 0x04007BFB RID: 31739
		[Token(Token = "0x4007BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected ChampionshipInfo m_ChampionshipInfo;

		// Token: 0x04007BFC RID: 31740
		[Token(Token = "0x4007BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

		// Token: 0x04007BFD RID: 31741
		[Token(Token = "0x4007BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

		// Token: 0x04007BFE RID: 31742
		[Token(Token = "0x4007BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

		// Token: 0x04007BFF RID: 31743
		[Token(Token = "0x4007BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private UIModelLeaderBoard m_ModelLeaderBoard;

		// Token: 0x04007C00 RID: 31744
		[Token(Token = "0x4007C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected uint m_ChampionshipType;

		// Token: 0x04007C01 RID: 31745
		[Token(Token = "0x4007C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private MapOpeningInfo m_MapInfo;

		// Token: 0x04007C02 RID: 31746
		[Token(Token = "0x4007C02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private uint m_BtnBGGrey;

		// Token: 0x04007C03 RID: 31747
		[Token(Token = "0x4007C03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		protected uint m_ChampionshipID;

		// Token: 0x04007C04 RID: 31748
		[Token(Token = "0x4007C04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool m_NeedUpdateCSInfo;

		// Token: 0x04007C05 RID: 31749
		[Token(Token = "0x4007C05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Color m_StartBtnColor;

		// Token: 0x04007C06 RID: 31750
		[Token(Token = "0x4007C06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private UINavigationData m_LastNavigationData;

		// Token: 0x04007C07 RID: 31751
		[Token(Token = "0x4007C07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

		// Token: 0x04007C08 RID: 31752
		[Token(Token = "0x4007C08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private List<Transform> m_RewardContainerList;

		// Token: 0x04007C09 RID: 31753
		[Token(Token = "0x4007C09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private List<Transform> m_NewRewardContainerList;

		// Token: 0x04007C0A RID: 31754
		[Token(Token = "0x4007C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<Transform> m_RewardParentContainerList;

		// Token: 0x04007C0B RID: 31755
		[Token(Token = "0x4007C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<Transform> m_ChampionshipRewardContainerList;

		// Token: 0x04007C0C RID: 31756
		[Token(Token = "0x4007C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int m_LastRankPos;

		// Token: 0x04007C0D RID: 31757
		[Token(Token = "0x4007C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private bool m_NeedPlayRewardAnim;

		// Token: 0x04007C0E RID: 31758
		[Token(Token = "0x4007C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		private bool m_TransitionAnimFinish;

		// Token: 0x04007C0F RID: 31759
		[Token(Token = "0x4007C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private UIChampionshipController.LeaderBoardEasyList m_LeaderBoardEasyList;

		// Token: 0x04007C10 RID: 31760
		[Token(Token = "0x4007C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private UIChampionshipLeaderBoardItem m_LeaderBoardSelfItem;

		// Token: 0x04007C11 RID: 31761
		[Token(Token = "0x4007C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private UIStandardDrawerTabController m_DrawerTabCtrl;

		// Token: 0x04007C12 RID: 31762
		[Token(Token = "0x4007C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool m_FromJoinBtn;

		// Token: 0x04007C13 RID: 31763
		[Token(Token = "0x4007C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool m_TeamTabClickLogged;

		// Token: 0x04007C14 RID: 31764
		[Token(Token = "0x4007C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private string m_MatchStateClockTips;

		// Token: 0x04007C15 RID: 31765
		[Token(Token = "0x4007C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private UIChampionshipController.EPage m_CurSelectPage;

		// Token: 0x04007C16 RID: 31766
		[Token(Token = "0x4007C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private UIChampionshipTeamProfileSelfController m_TeamProfileSelfCtrl;

		// Token: 0x04007C17 RID: 31767
		[Token(Token = "0x4007C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private UICountDownController m_MatchOpenCountDownCtrl;

		// Token: 0x04007C18 RID: 31768
		[Token(Token = "0x4007C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Dictionary<UIModelChampionship.ChampionshipOpenState, UIToggleButton> m_StateBtnDict;

		// Token: 0x04007C19 RID: 31769
		[Token(Token = "0x4007C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private string[] m_DayInWeekStrDict;

		// Token: 0x04007C1A RID: 31770
		[Token(Token = "0x4007C1A")]
		private const float VFX_BLINK_DURATION = 2.15f;

		// Token: 0x0200146D RID: 5229
		[Token(Token = "0x200146D")]
		public enum EPage
		{
			// Token: 0x04007C1C RID: 31772
			[Token(Token = "0x4007C1C")]
			Main,
			// Token: 0x04007C1D RID: 31773
			[Token(Token = "0x4007C1D")]
			Team,
			// Token: 0x04007C1E RID: 31774
			[Token(Token = "0x4007C1E")]
			Ladder
		}

		// Token: 0x0200146E RID: 5230
		[Token(Token = "0x200146E")]
		public enum ETeamSubPage
		{
			// Token: 0x04007C20 RID: 31776
			[Token(Token = "0x4007C20")]
			Info,
			// Token: 0x04007C21 RID: 31777
			[Token(Token = "0x4007C21")]
			Reward
		}

		// Token: 0x0200146F RID: 5231
		[Token(Token = "0x200146F")]
		public class LeaderBoardEasyList : IEasyList
		{
			// Token: 0x0600582C RID: 22572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600582C")]
			[Address(RVA = "0x1C285D8", Offset = "0x1C285D8", VA = "0x7BBC4285D8")]
			public LeaderBoardEasyList(UIChampionshipController championshipController)
			{
			}

			// Token: 0x0600582D RID: 22573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600582D")]
			[Address(RVA = "0x1C2FC90", Offset = "0x1C2FC90", VA = "0x7BBC42FC90", Slot = "5")]
			public void CloseItemController(UIEasyListItemController itemController)
			{
			}

			// Token: 0x0600582E RID: 22574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600582E")]
			[Address(RVA = "0x1C2FCC0", Offset = "0x1C2FCC0", VA = "0x7BBC42FCC0", Slot = "4")]
			public UIEasyListItemController OpenItemController(Transform parent)
			{
				return null;
			}

			// Token: 0x04007C22 RID: 31778
			[Token(Token = "0x4007C22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UIChampionshipController championshipController;

			// Token: 0x04007C23 RID: 31779
			[Token(Token = "0x4007C23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint championshipType;
		}

		// Token: 0x02001470 RID: 5232
		[Token(Token = "0x2001470")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECD90", Offset = "0x10ECD90")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005830 RID: 22576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005830")]
			[Address(RVA = "0x1C2FC60", Offset = "0x1C2FC60", VA = "0x7BBC42FC60")]
			public <>c()
			{
			}

			// Token: 0x06005831 RID: 22577 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005831")]
			[Address(RVA = "0x1C2FC68", Offset = "0x1C2FC68", VA = "0x7BBC42FC68")]
			internal string <OnSeasonTipsBtnClick>b__76_0(uint day)
			{
				return null;
			}

			// Token: 0x04007C24 RID: 31780
			[Token(Token = "0x4007C24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIChampionshipController.<>c <>9;

			// Token: 0x04007C25 RID: 31781
			[Token(Token = "0x4007C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<uint, string> <>9__76_0;
		}
	}
}
