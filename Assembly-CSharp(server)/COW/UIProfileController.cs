using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B1D RID: 6941
	[Token(Token = "0x2001B1D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F948C", Offset = "0x10F948C")]
	public class UIProfileController : UINavigationController, IUIModelDataChangeObserver, IEasyList
	{
		// Token: 0x0600940E RID: 37902 RVA: 0x00027408 File Offset: 0x00025608
		[Token(Token = "0x600940E")]
		[Address(RVA = "0x1B4EA98", Offset = "0x1B4EA98", VA = "0x7BBC34EA98")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600940F")]
		[Address(RVA = "0x1B4EAE8", Offset = "0x1B4EAE8", VA = "0x7BBC34EAE8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009410")]
		[Address(RVA = "0x1B521DC", Offset = "0x1B521DC", VA = "0x7BBC3521DC")]
		private void OnRankIconCSBtnClick()
		{
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009411")]
		[Address(RVA = "0x1B52318", Offset = "0x1B52318", VA = "0x7BBC352318")]
		private void OnRankIconHistoryCSClick()
		{
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009412")]
		[Address(RVA = "0x1B52454", Offset = "0x1B52454", VA = "0x7BBC352454")]
		private void OnRankIconBtnClick()
		{
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009413")]
		[Address(RVA = "0x1B52590", Offset = "0x1B52590", VA = "0x7BBC352590")]
		private void OnRankIconHistoryClick()
		{
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009414")]
		[Address(RVA = "0x1B526CC", Offset = "0x1B526CC", VA = "0x7BBC3526CC")]
		private void OnHistoryDetailClick()
		{
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009415")]
		[Address(RVA = "0x1B52880", Offset = "0x1B52880", VA = "0x7BBC352880")]
		private void GenerateModeBrMenu()
		{
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009416")]
		[Address(RVA = "0x1B52B48", Offset = "0x1B52B48", VA = "0x7BBC352B48")]
		private void OnModeBrMenuSelect(object obj)
		{
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009417")]
		[Address(RVA = "0x1B531C8", Offset = "0x1B531C8", VA = "0x7BBC3531C8")]
		private void GenerateModeCSMenu()
		{
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009418")]
		[Address(RVA = "0x1B53490", Offset = "0x1B53490", VA = "0x7BBC353490")]
		private void OnModeCSMenuSelect(object obj)
		{
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009419")]
		[Address(RVA = "0x1B53960", Offset = "0x1B53960", VA = "0x7BBC353960", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600941A RID: 37914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941A")]
		[Address(RVA = "0x1B53F24", Offset = "0x1B53F24", VA = "0x7BBC353F24", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x0600941B RID: 37915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941B")]
		[Address(RVA = "0x1B550E0", Offset = "0x1B550E0", VA = "0x7BBC3550E0")]
		private void TrySendLangr(AccountPersonalShowInfo info)
		{
		}

		// Token: 0x0600941C RID: 37916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941C")]
		[Address(RVA = "0x1B54C60", Offset = "0x1B54C60", VA = "0x7BBC354C60")]
		private void TryShowSettingGuide()
		{
		}

		// Token: 0x0600941D RID: 37917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941D")]
		[Address(RVA = "0x1B55390", Offset = "0x1B55390", VA = "0x7BBC355390")]
		private void TryShowNodeFullRuleWnd()
		{
		}

		// Token: 0x0600941E RID: 37918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941E")]
		[Address(RVA = "0x1B554B8", Offset = "0x1B554B8", VA = "0x7BBC3554B8")]
		private void OnEpFullClick()
		{
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600941F")]
		[Address(RVA = "0x1B55530", Offset = "0x1B55530", VA = "0x7BBC355530")]
		private void OnEpBriefClick()
		{
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009420")]
		[Address(RVA = "0x1B55808", Offset = "0x1B55808", VA = "0x7BBC355808")]
		private void OnBtnPinClick()
		{
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009421")]
		[Address(RVA = "0x1B5590C", Offset = "0x1B5590C", VA = "0x7BBC35590C")]
		private void OnBtnEPDocumentClick()
		{
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009422")]
		[Address(RVA = "0x1B513C0", Offset = "0x1B513C0", VA = "0x7BBC3513C0")]
		private void AddTottleBtns()
		{
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009423")]
		[Address(RVA = "0x1B513C4", Offset = "0x1B513C4", VA = "0x7BBC3513C4")]
		private void AddLabels()
		{
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009424")]
		[Address(RVA = "0x1B54C24", Offset = "0x1B54C24", VA = "0x7BBC354C24")]
		private void RefreshProfileUI()
		{
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009425")]
		[Address(RVA = "0x1B55A28", Offset = "0x1B55A28", VA = "0x7BBC355A28", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009426")]
		[Address(RVA = "0x1B55F38", Offset = "0x1B55F38", VA = "0x7BBC355F38", Slot = "31")]
		protected override void OnSendShowTimeEvent(ref string eventLogKey, ref EventLogger.EventPageDetentionTime eventLog)
		{
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x00027420 File Offset: 0x00025620
		[Token(Token = "0x6009427")]
		[Address(RVA = "0x1B56010", Offset = "0x1B56010", VA = "0x7BBC356010", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06009428 RID: 37928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009428")]
		[Address(RVA = "0x1B51B94", Offset = "0x1B51B94", VA = "0x7BBC351B94")]
		private void InitEPAwardUIList()
		{
		}

		// Token: 0x06009429 RID: 37929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009429")]
		[Address(RVA = "0x1B56018", Offset = "0x1B56018", VA = "0x7BBC356018")]
		private void RefreshEpFullList(List<BasicEPInfo> historyinfo)
		{
		}

		// Token: 0x0600942A RID: 37930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942A")]
		[Address(RVA = "0x1B56548", Offset = "0x1B56548", VA = "0x7BBC356548")]
		private void RefreshProfileNodeUI(params object[] data)
		{
		}

		// Token: 0x0600942B RID: 37931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942B")]
		[Address(RVA = "0x1B566B8", Offset = "0x1B566B8", VA = "0x7BBC3566B8")]
		private void RefreshSelectedCloth(params object[] data)
		{
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942C")]
		[Address(RVA = "0x1B5503C", Offset = "0x1B5503C", VA = "0x7BBC35503C")]
		private void ChooseFirstTab()
		{
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942D")]
		[Address(RVA = "0x1B567E0", Offset = "0x1B567E0", VA = "0x7BBC3567E0")]
		private void OnNodeRuleBtnClick()
		{
		}

		// Token: 0x0600942E RID: 37934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942E")]
		[Address(RVA = "0x1B56AB8", Offset = "0x1B56AB8", VA = "0x7BBC356AB8")]
		private void OnProfileNodeAllShare()
		{
		}

		// Token: 0x0600942F RID: 37935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600942F")]
		[Address(RVA = "0x1B56DCC", Offset = "0x1B56DCC", VA = "0x7BBC356DCC")]
		private void OnProfileNodeHistoryShare()
		{
		}

		// Token: 0x06009430 RID: 37936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009430")]
		[Address(RVA = "0x1B57030", Offset = "0x1B57030", VA = "0x7BBC357030")]
		private void OnPortraitCloseupBtnClick()
		{
		}

		// Token: 0x06009431 RID: 37937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009431")]
		[Address(RVA = "0x1B5716C", Offset = "0x1B5716C", VA = "0x7BBC35716C")]
		private void OnHeroicMarkBRIconBtnClick()
		{
		}

		// Token: 0x06009432 RID: 37938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009432")]
		[Address(RVA = "0x1B5723C", Offset = "0x1B5723C", VA = "0x7BBC35723C")]
		private void OnHeroicMarkCSIconBtnClick()
		{
		}

		// Token: 0x06009433 RID: 37939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009433")]
		[Address(RVA = "0x1B5730C", Offset = "0x1B5730C", VA = "0x7BBC35730C", Slot = "36")]
		public override List<string> GetNeedShowUI3dObjectNames()
		{
			return null;
		}

		// Token: 0x06009434 RID: 37940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009434")]
		[Address(RVA = "0x1B51E68", Offset = "0x1B51E68", VA = "0x7BBC351E68")]
		private void CreateTab()
		{
		}

		// Token: 0x06009435 RID: 37941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009435")]
		[Address(RVA = "0x1B57374", Offset = "0x1B57374", VA = "0x7BBC357374")]
		private void ShowCsNodeALLbtn()
		{
		}

		// Token: 0x06009436 RID: 37942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009436")]
		[Address(RVA = "0x1B574D4", Offset = "0x1B574D4", VA = "0x7BBC3574D4")]
		private void RefreshCsInfo(params object[] data)
		{
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009437")]
		[Address(RVA = "0x1B57F28", Offset = "0x1B57F28", VA = "0x7BBC357F28")]
		private void RefreshProfileFightListVfxState(bool show, int index)
		{
		}

		// Token: 0x06009438 RID: 37944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009438")]
		[Address(RVA = "0x1B580CC", Offset = "0x1B580CC", VA = "0x7BBC3580CC")]
		private void ShowDetailDataPanelAnimation(params object[] data)
		{
		}

		// Token: 0x06009439 RID: 37945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009439")]
		[Address(RVA = "0x1B583F0", Offset = "0x1B583F0", VA = "0x7BBC3583F0")]
		private void CloseModeSelectionPanels(params object[] data)
		{
		}

		// Token: 0x0600943A RID: 37946 RVA: 0x00027438 File Offset: 0x00025638
		[Token(Token = "0x600943A")]
		[Address(RVA = "0x1B5845C", Offset = "0x1B5845C", VA = "0x7BBC35845C", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600943B")]
		[Address(RVA = "0x1B58464", Offset = "0x1B58464", VA = "0x7BBC358464", Slot = "39")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600943C")]
		[Address(RVA = "0x1B5C5FC", Offset = "0x1B5C5FC", VA = "0x7BBC35C5FC")]
		private void ShowChampionshipIcon(bool isChampionship)
		{
		}

		// Token: 0x0600943D RID: 37949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600943D")]
		[Address(RVA = "0x1B588B8", Offset = "0x1B588B8", VA = "0x7BBC3588B8")]
		private void ShowPersonalProfile(uint type)
		{
		}

		// Token: 0x0600943E RID: 37950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600943E")]
		[Address(RVA = "0x1B5C65C", Offset = "0x1B5C65C", VA = "0x7BBC35C65C")]
		private void RefreshItemDescText(params object[] data)
		{
		}

		// Token: 0x0600943F RID: 37951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600943F")]
		[Address(RVA = "0x1B5C8A8", Offset = "0x1B5C8A8", VA = "0x7BBC35C8A8")]
		private void OnBtnOpenClanDetail()
		{
		}

		// Token: 0x06009440 RID: 37952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009440")]
		[Address(RVA = "0x1B5C9B4", Offset = "0x1B5C9B4", VA = "0x7BBC35C9B4")]
		private void ShowBrLadder(int rank, uint rankpoint, UILabel go, UISprite spr)
		{
		}

		// Token: 0x06009441 RID: 37953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009441")]
		[Address(RVA = "0x1B5CD2C", Offset = "0x1B5CD2C", VA = "0x7BBC35CD2C")]
		private void ShowBrRankInfo()
		{
		}

		// Token: 0x06009442 RID: 37954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009442")]
		[Address(RVA = "0x1B5D4C4", Offset = "0x1B5D4C4", VA = "0x7BBC35D4C4")]
		private void ShowCsHistoryRankInfo(uint rank)
		{
		}

		// Token: 0x06009443 RID: 37955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009443")]
		[Address(RVA = "0x1B574D8", Offset = "0x1B574D8", VA = "0x7BBC3574D8")]
		private void ShowCsCurrentRankInfo()
		{
		}

		// Token: 0x06009444 RID: 37956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009444")]
		[Address(RVA = "0x1B5D8EC", Offset = "0x1B5D8EC", VA = "0x7BBC35D8EC")]
		private void onSeasonBrBtnClick()
		{
		}

		// Token: 0x06009445 RID: 37957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009445")]
		[Address(RVA = "0x1B5D964", Offset = "0x1B5D964", VA = "0x7BBC35D964")]
		private void onSeasonCSBtnClick()
		{
		}

		// Token: 0x06009446 RID: 37958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009446")]
		[Address(RVA = "0x1B5D9DC", Offset = "0x1B5D9DC", VA = "0x7BBC35D9DC")]
		private void OnMarryClick()
		{
		}

		// Token: 0x06009447 RID: 37959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009447")]
		[Address(RVA = "0x1B5D9E0", Offset = "0x1B5D9E0", VA = "0x7BBC35D9E0")]
		private void OnAddFriend()
		{
		}

		// Token: 0x06009448 RID: 37960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009448")]
		[Address(RVA = "0x1B56ED4", Offset = "0x1B56ED4", VA = "0x7BBC356ED4")]
		private void SendShareBtnClickLog()
		{
		}

		// Token: 0x06009449 RID: 37961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009449")]
		[Address(RVA = "0x1B5DD64", Offset = "0x1B5DD64", VA = "0x7BBC35DD64")]
		private void ShowPersonalSetting()
		{
		}

		// Token: 0x0600944A RID: 37962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944A")]
		[Address(RVA = "0x1B5DEF0", Offset = "0x1B5DEF0", VA = "0x7BBC35DEF0")]
		private void SetDefaultLangr()
		{
		}

		// Token: 0x0600944B RID: 37963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944B")]
		[Address(RVA = "0x1B5AE10", Offset = "0x1B5AE10", VA = "0x7BBC35AE10")]
		private void ShowMarryInfo()
		{
		}

		// Token: 0x0600944C RID: 37964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944C")]
		[Address(RVA = "0x1B58F90", Offset = "0x1B58F90", VA = "0x7BBC358F90")]
		private void ShowPersonalBoard()
		{
		}

		// Token: 0x0600944D RID: 37965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944D")]
		[Address(RVA = "0x1B5EB30", Offset = "0x1B5EB30", VA = "0x7BBC35EB30")]
		private void RefreshSocialProfile()
		{
		}

		// Token: 0x0600944E RID: 37966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944E")]
		[Address(RVA = "0x1B5B39C", Offset = "0x1B5B39C", VA = "0x7BBC35B39C")]
		private void RefreshBattleTagProfile()
		{
		}

		// Token: 0x0600944F RID: 37967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600944F")]
		[Address(RVA = "0x1B5D420", Offset = "0x1B5D420", VA = "0x7BBC35D420")]
		private void RefreshHeroicLevel(int rankPoint)
		{
		}

		// Token: 0x06009450 RID: 37968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009450")]
		[Address(RVA = "0x1B5D468", Offset = "0x1B5D468", VA = "0x7BBC35D468")]
		private void RefreshHeroicMaxLevel(int rankPoint)
		{
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009451")]
		[Address(RVA = "0x1B5BC58", Offset = "0x1B5BC58", VA = "0x7BBC35BC58")]
		private void ShowPersonalAvatar()
		{
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009452")]
		[Address(RVA = "0x1B549A8", Offset = "0x1B549A8", VA = "0x7BBC3549A8")]
		private void RefreshPet(PetInfo info)
		{
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009453")]
		[Address(RVA = "0x1B544DC", Offset = "0x1B544DC", VA = "0x7BBC3544DC")]
		private void RefreshAvatar(AccountPersonalShowInfo info)
		{
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x00027450 File Offset: 0x00025650
		[Token(Token = "0x6009454")]
		[Address(RVA = "0x1B5F664", Offset = "0x1B5F664", VA = "0x7BBC35F664")]
		private bool CheckNeedDelayShowAvatar(List<uint> clothes, bool isfemale)
		{
			return default(bool);
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009455")]
		[Address(RVA = "0x1B55E24", Offset = "0x1B55E24", VA = "0x7BBC355E24")]
		private void SetAvatarPos(bool inputEnable, bool resetRotation)
		{
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009456")]
		[Address(RVA = "0x1B5DF9C", Offset = "0x1B5DF9C", VA = "0x7BBC35DF9C")]
		private void InItClothTabUI()
		{
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009457")]
		[Address(RVA = "0x1B5F214", Offset = "0x1B5F214", VA = "0x7BBC35F214")]
		private void UpdateClothTabUI(uint[] itemids)
		{
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009458")]
		[Address(RVA = "0x1B5E5B8", Offset = "0x1B5E5B8", VA = "0x7BBC35E5B8")]
		private void UpdateEpAwardUIList(List<BasicEPInfo> historyinfo)
		{
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009459")]
		[Address(RVA = "0x1B5E0A4", Offset = "0x1B5E0A4", VA = "0x7BBC35E0A4")]
		public void UpdateHeadPic(uint iid)
		{
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945A")]
		[Address(RVA = "0x1B5FAB8", Offset = "0x1B5FAB8", VA = "0x7BBC35FAB8")]
		public void UpdateHeadPic(HeadPicData data)
		{
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945B")]
		[Address(RVA = "0x1B5E438", Offset = "0x1B5E438", VA = "0x7BBC35E438")]
		public void UpdatePin(uint pinId)
		{
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945C")]
		[Address(RVA = "0x1B5E1D0", Offset = "0x1B5E1D0", VA = "0x7BBC35E1D0")]
		public void UpdateBanner(uint bannerId)
		{
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945D")]
		[Address(RVA = "0x1B5FBBC", Offset = "0x1B5FBBC", VA = "0x7BBC35FBBC")]
		public void UpdateBanner(BannerData bannerData, bool isBrief = false)
		{
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945E")]
		[Address(RVA = "0x1B51924", Offset = "0x1B51924", VA = "0x7BBC351924")]
		private void RefreshUserInfo()
		{
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600945F")]
		[Address(RVA = "0x1B60020", Offset = "0x1B60020", VA = "0x7BBC360020")]
		private void UpdateHeadshot()
		{
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x00027468 File Offset: 0x00025668
		[Token(Token = "0x6009460")]
		[Address(RVA = "0x1B60220", Offset = "0x1B60220", VA = "0x7BBC360220", Slot = "40")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009461")]
		[Address(RVA = "0x1B60350", Offset = "0x1B60350", VA = "0x7BBC360350")]
		private void OnHistoryRecordClick(object[] data)
		{
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009462")]
		[Address(RVA = "0x1B5C350", Offset = "0x1B5C350", VA = "0x7BBC35C350")]
		private void RefreshTeammateFriendBtnShow()
		{
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009463")]
		[Address(RVA = "0x1B58B70", Offset = "0x1B58B70", VA = "0x7BBC358B70")]
		public void ShowHistoryRecord()
		{
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009464")]
		[Address(RVA = "0x1B61AB4", Offset = "0x1B61AB4", VA = "0x7BBC361AB4")]
		public void ShowRankHistory(UINavigationUtil.UINavagationProfileType _profileType = UINavigationUtil.UINavagationProfileType.ProfileDefault)
		{
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009465")]
		[Address(RVA = "0x1B5187C", Offset = "0x1B5187C", VA = "0x7BBC35187C")]
		private void CloseAllNode()
		{
		}

		// Token: 0x06009466 RID: 37990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009466")]
		[Address(RVA = "0x1B61AF0", Offset = "0x1B61AF0", VA = "0x7BBC361AF0")]
		private void _ShowRankHistory()
		{
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009467")]
		[Address(RVA = "0x1B61B68", Offset = "0x1B61B68", VA = "0x7BBC361B68")]
		private void RefreshCurrentProfileTeamMode(int index)
		{
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009468")]
		[Address(RVA = "0x1B61B6C", Offset = "0x1B61B6C", VA = "0x7BBC361B6C")]
		private void RefreshLabelSelectColor()
		{
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009469")]
		[Address(RVA = "0x1B61DD8", Offset = "0x1B61DD8", VA = "0x7BBC361DD8", Slot = "41")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600946A RID: 37994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946A")]
		[Address(RVA = "0x1B61E6C", Offset = "0x1B61E6C", VA = "0x7BBC361E6C", Slot = "42")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946B")]
		[Address(RVA = "0x1B61E9C", Offset = "0x1B61E9C", VA = "0x7BBC361E9C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946C")]
		[Address(RVA = "0x1B62DB8", Offset = "0x1B62DB8", VA = "0x7BBC362DB8")]
		private void RestoreBtnState()
		{
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946D")]
		[Address(RVA = "0x1B62F04", Offset = "0x1B62F04", VA = "0x7BBC362F04")]
		private void RestoreBtnState2()
		{
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946E")]
		[Address(RVA = "0x1B6309C", Offset = "0x1B6309C", VA = "0x7BBC36309C")]
		private void ResetBtnState2()
		{
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600946F")]
		[Address(RVA = "0x1B6324C", Offset = "0x1B6324C", VA = "0x7BBC36324C")]
		private void ResetBtnState()
		{
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009470")]
		[Address(RVA = "0x1B5F540", Offset = "0x1B5F540", VA = "0x7BBC35F540")]
		private void ShowOrHideAvatar(bool flag)
		{
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009471")]
		[Address(RVA = "0x1B633AC", Offset = "0x1B633AC", VA = "0x7BBC3633AC", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009472")]
		[Address(RVA = "0x1B63A20", Offset = "0x1B63A20", VA = "0x7BBC363A20")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009473")]
		[Address(RVA = "0x1B63B28", Offset = "0x1B63B28", VA = "0x7BBC363B28")]
		private void OnTeamModeBtnClick()
		{
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009474")]
		[Address(RVA = "0x1B52D44", Offset = "0x1B52D44", VA = "0x7BBC352D44")]
		private void OnTotalBtnClick()
		{
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009475")]
		[Address(RVA = "0x1B52E50", Offset = "0x1B52E50", VA = "0x7BBC352E50")]
		private void OnCasualBtnClick()
		{
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009476")]
		[Address(RVA = "0x1B63C4C", Offset = "0x1B63C4C", VA = "0x7BBC363C4C")]
		private void SetDefaultClick()
		{
		}

		// Token: 0x06009477 RID: 38007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009477")]
		[Address(RVA = "0x1B53684", Offset = "0x1B53684", VA = "0x7BBC353684")]
		private void OnCsLifeClick()
		{
		}

		// Token: 0x06009478 RID: 38008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009478")]
		[Address(RVA = "0x1B53778", Offset = "0x1B53778", VA = "0x7BBC353778")]
		private void OnCsBtnClick()
		{
		}

		// Token: 0x06009479 RID: 38009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009479")]
		[Address(RVA = "0x1B5386C", Offset = "0x1B5386C", VA = "0x7BBC35386C")]
		private void OnRankCsBtnClick()
		{
		}

		// Token: 0x0600947A RID: 38010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947A")]
		[Address(RVA = "0x1B5C420", Offset = "0x1B5C420", VA = "0x7BBC35C420")]
		private void ShowCSRankModeData(uint matchmode)
		{
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947B")]
		[Address(RVA = "0x1B52F60", Offset = "0x1B52F60", VA = "0x7BBC352F60")]
		private void OnRankBtnClick()
		{
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947C")]
		[Address(RVA = "0x1B63C7C", Offset = "0x1B63C7C", VA = "0x7BBC363C7C")]
		private void OnMaskBtnClick()
		{
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947D")]
		[Address(RVA = "0x1B63C80", Offset = "0x1B63C80", VA = "0x7BBC363C80")]
		private void OnCopyBtnClick()
		{
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947E")]
		[Address(RVA = "0x1B63B2C", Offset = "0x1B63B2C", VA = "0x7BBC363B2C")]
		private void RefreshProfileTeamModestate(int type)
		{
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600947F")]
		[Address(RVA = "0x1B5F88C", Offset = "0x1B5F88C", VA = "0x7BBC35F88C")]
		private void OnShowClothesTab(uint itemid)
		{
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009480")]
		[Address(RVA = "0x1B63E24", Offset = "0x1B63E24", VA = "0x7BBC363E24")]
		private void OnEpBtnClick()
		{
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009481")]
		[Address(RVA = "0x1B63E68", Offset = "0x1B63E68", VA = "0x7BBC363E68")]
		private void OnLikeBtnClick()
		{
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009482")]
		[Address(RVA = "0x1B63EAC", Offset = "0x1B63EAC", VA = "0x7BBC363EAC")]
		private void OnEPHelperMaskBtnClick()
		{
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009483")]
		[Address(RVA = "0x1B63EF0", Offset = "0x1B63EF0", VA = "0x7BBC363EF0")]
		private void OnLikeHelperMaskBtnClick()
		{
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009484")]
		[Address(RVA = "0x1B63C88", Offset = "0x1B63C88", VA = "0x7BBC363C88")]
		private void CopyToClipBoard(ulong uid)
		{
		}

		// Token: 0x06009485 RID: 38021 RVA: 0x00027480 File Offset: 0x00025680
		[Token(Token = "0x6009485")]
		[Address(RVA = "0x1B61A44", Offset = "0x1B61A44", VA = "0x7BBC361A44")]
		private bool ShowKDRatio(uint gameMode)
		{
			return default(bool);
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009486")]
		[Address(RVA = "0x1B58208", Offset = "0x1B58208", VA = "0x7BBC358208")]
		private void PlayAnimByAnimClip(int index)
		{
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009487")]
		[Address(RVA = "0x1B513C8", Offset = "0x1B513C8", VA = "0x7BBC3513C8")]
		private void InitAnimState()
		{
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009488")]
		[Address(RVA = "0x1B51794", Offset = "0x1B51794", VA = "0x7BBC351794")]
		private void InitProfileGridTransform()
		{
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009489")]
		[Address(RVA = "0x1B53070", Offset = "0x1B53070", VA = "0x7BBC353070")]
		private void ResetProfileState()
		{
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948A")]
		[Address(RVA = "0x1B54C28", Offset = "0x1B54C28", VA = "0x7BBC354C28")]
		private void GetPlayerHeroicMarkInfo()
		{
		}

		// Token: 0x0600948B RID: 38027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948B")]
		[Address(RVA = "0x1B5BCCC", Offset = "0x1B5BCCC", VA = "0x7BBC35BCCC")]
		private void RefreshHeroicMarkInfo()
		{
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948C")]
		[Address(RVA = "0x1B63F34", Offset = "0x1B63F34", VA = "0x7BBC363F34")]
		public UIProfileController()
		{
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948E")]
		[Address(RVA = "0x1B64A34", Offset = "0x1B64A34", VA = "0x7BBC364A34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B50", Offset = "0x1144B50")]
		private void <OnUIInit>b__76_0(bool flag)
		{
		}

		// Token: 0x0600948F RID: 38031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600948F")]
		[Address(RVA = "0x1B64BB8", Offset = "0x1B64BB8", VA = "0x7BBC364BB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B60", Offset = "0x1144B60")]
		private void <OnUIInit>b__76_1(bool flag)
		{
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009490")]
		[Address(RVA = "0x1B64D3C", Offset = "0x1B64D3C", VA = "0x7BBC364D3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B70", Offset = "0x1144B70")]
		private void <OnUIInit>b__76_2(bool flag)
		{
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009491")]
		[Address(RVA = "0x1B64EC0", Offset = "0x1B64EC0", VA = "0x7BBC364EC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B80", Offset = "0x1144B80")]
		private void <OnUIInit>b__76_3(bool flag)
		{
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009492")]
		[Address(RVA = "0x1B65044", Offset = "0x1B65044", VA = "0x7BBC365044")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144B90", Offset = "0x1144B90")]
		private void <OnUIInit>b__76_4(bool flag)
		{
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009493")]
		[Address(RVA = "0x1B6519C", Offset = "0x1B6519C", VA = "0x7BBC36519C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BA0", Offset = "0x1144BA0")]
		private void <OnUIInit>b__76_5(bool flag)
		{
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009494")]
		[Address(RVA = "0x1B652F4", Offset = "0x1B652F4", VA = "0x7BBC3652F4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BB0", Offset = "0x1144BB0")]
		private void <OnUIInit>b__76_6(bool flag)
		{
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009495")]
		[Address(RVA = "0x1B6544C", Offset = "0x1B6544C", VA = "0x7BBC36544C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BC0", Offset = "0x1144BC0")]
		private void <OnUIInit>b__76_7(bool flag)
		{
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009496")]
		[Address(RVA = "0x1B65824", Offset = "0x1B65824", VA = "0x7BBC365824")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BD0", Offset = "0x1144BD0")]
		private void <CreateTab>b__114_0()
		{
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009497")]
		[Address(RVA = "0x1B65B9C", Offset = "0x1B65B9C", VA = "0x7BBC365B9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BE0", Offset = "0x1144BE0")]
		private void <CreateTab>b__114_1()
		{
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009498")]
		[Address(RVA = "0x1B66028", Offset = "0x1B66028", VA = "0x7BBC366028")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144BF0", Offset = "0x1144BF0")]
		private void <CreateTab>b__114_2()
		{
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009499")]
		[Address(RVA = "0x1B6639C", Offset = "0x1B6639C", VA = "0x7BBC36639C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144C00", Offset = "0x1144C00")]
		private void <CreateTab>b__114_3()
		{
		}

		// Token: 0x04009DDD RID: 40413
		[Token(Token = "0x4009DDD")]
		[FieldOffset(Offset = "0xB0")]
		private UIProfileViewExt m_View;

		// Token: 0x04009DDE RID: 40414
		[Token(Token = "0x4009DDE")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelProfile m_Model;

		// Token: 0x04009DDF RID: 40415
		[Token(Token = "0x4009DDF")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelCSLadderMatch m_CsLaddermodel;

		// Token: 0x04009DE0 RID: 40416
		[Token(Token = "0x4009DE0")]
		[FieldOffset(Offset = "0xC8")]
		private List<GameObject> m_GroupHCList;

		// Token: 0x04009DE1 RID: 40417
		[Token(Token = "0x4009DE1")]
		[FieldOffset(Offset = "0xD0")]
		private List<UIHistoryTeammateController> m_HistoryTeammate;

		// Token: 0x04009DE2 RID: 40418
		[Token(Token = "0x4009DE2")]
		[FieldOffset(Offset = "0xD8")]
		private List<BasicEPInfo> m_AllEpList;

		// Token: 0x04009DE3 RID: 40419
		[Token(Token = "0x4009DE3")]
		[FieldOffset(Offset = "0xE0")]
		private List<uint> m_GameModeListShowKDRatio;

		// Token: 0x04009DE4 RID: 40420
		[Token(Token = "0x4009DE4")]
		[FieldOffset(Offset = "0xE8")]
		private ProfileFullTab m_ChooseTab;

		// Token: 0x04009DE5 RID: 40421
		[Token(Token = "0x4009DE5")]
		private const int m_FightTypeAll = 3;

		// Token: 0x04009DE6 RID: 40422
		[Token(Token = "0x4009DE6")]
		private const int m_TrendALL = 3;

		// Token: 0x04009DE7 RID: 40423
		[Token(Token = "0x4009DE7")]
		private const int m_HistoryBriefEPALL = 4;

		// Token: 0x04009DE8 RID: 40424
		[Token(Token = "0x4009DE8")]
		private const int m_HistoryFullEpAll = 9;

		// Token: 0x04009DE9 RID: 40425
		[Token(Token = "0x4009DE9")]
		private const int m_ClothPreviewAll = 7;

		// Token: 0x04009DEA RID: 40426
		[Token(Token = "0x4009DEA")]
		public const string LADDER_MATCH = "TXT_OB5_HISTORY_RANK";

		// Token: 0x04009DEB RID: 40427
		[Token(Token = "0x4009DEB")]
		public const string CASUAL_MATCH = "TXT_OB5_HISTORY_CASUAL";

		// Token: 0x04009DEC RID: 40428
		[Token(Token = "0x4009DEC")]
		public const string ROOM_MATCH = "TXT_OB7_ZJS_CUSTOM_TITLE";

		// Token: 0x04009DED RID: 40429
		[Token(Token = "0x4009DED")]
		public const uint POSITIVE_DELTA_COLOR = 4284678115U;

		// Token: 0x04009DEE RID: 40430
		[Token(Token = "0x4009DEE")]
		public const uint NEGATIVE_DELTA_COLOR = 4294912512U;

		// Token: 0x04009DEF RID: 40431
		[Token(Token = "0x4009DEF")]
		public const int RankLeadBoardSize = 100;

		// Token: 0x04009DF0 RID: 40432
		[Token(Token = "0x4009DF0")]
		[FieldOffset(Offset = "0xF0")]
		private ulong m_AccoutId;

		// Token: 0x04009DF1 RID: 40433
		[Token(Token = "0x4009DF1")]
		[FieldOffset(Offset = "0xF8")]
		private string[] m_MatchModesKey;

		// Token: 0x04009DF2 RID: 40434
		[Token(Token = "0x4009DF2")]
		[FieldOffset(Offset = "0x100")]
		private UIModelAvatarBase.EWardrobeType[] m_EwardrobeTypeList;

		// Token: 0x04009DF3 RID: 40435
		[Token(Token = "0x4009DF3")]
		[FieldOffset(Offset = "0x108")]
		private List<UIProfileTrendItemController> m_ProfileTrendListController;

		// Token: 0x04009DF4 RID: 40436
		[Token(Token = "0x4009DF4")]
		[FieldOffset(Offset = "0x110")]
		private List<UIProfileFightDataItemController> m_ProfileFightDataListController;

		// Token: 0x04009DF5 RID: 40437
		[Token(Token = "0x4009DF5")]
		[FieldOffset(Offset = "0x118")]
		private List<UIClothPreviewItemController> m_UIClothPreviewListControler;

		// Token: 0x04009DF6 RID: 40438
		[Token(Token = "0x4009DF6")]
		[FieldOffset(Offset = "0x120")]
		private List<UIProfileEPAwardItemController> m_ProfileEPAwardListController;

		// Token: 0x04009DF7 RID: 40439
		[Token(Token = "0x4009DF7")]
		[FieldOffset(Offset = "0x128")]
		private UIProfileFightDataItemController m_CurrentShowFightDataController;

		// Token: 0x04009DF8 RID: 40440
		[Token(Token = "0x4009DF8")]
		[FieldOffset(Offset = "0x130")]
		private List<UIToggleButton> m_ToggleBtns;

		// Token: 0x04009DF9 RID: 40441
		[Token(Token = "0x4009DF9")]
		[FieldOffset(Offset = "0x138")]
		private List<UILabel> m_Labels;

		// Token: 0x04009DFA RID: 40442
		[Token(Token = "0x4009DFA")]
		[FieldOffset(Offset = "0x140")]
		private List<UISprite> EPAwardIconList;

		// Token: 0x04009DFB RID: 40443
		[Token(Token = "0x4009DFB")]
		[FieldOffset(Offset = "0x148")]
		private List<UILabel> EPAwardLabelList;

		// Token: 0x04009DFC RID: 40444
		[Token(Token = "0x4009DFC")]
		[FieldOffset(Offset = "0x150")]
		private uint[] m_DefaultClothes;

		// Token: 0x04009DFD RID: 40445
		[Token(Token = "0x4009DFD")]
		[FieldOffset(Offset = "0x158")]
		private uint m_CurrentFightMode;

		// Token: 0x04009DFE RID: 40446
		[Token(Token = "0x4009DFE")]
		[FieldOffset(Offset = "0x15C")]
		private float m_ScreenshotbgoriginWidth;

		// Token: 0x04009DFF RID: 40447
		[Token(Token = "0x4009DFF")]
		[FieldOffset(Offset = "0x160")]
		private float m_ScreenshotlineoriginWidth;

		// Token: 0x04009E00 RID: 40448
		[Token(Token = "0x4009E00")]
		[FieldOffset(Offset = "0x164")]
		private UINavigationUtil.UINavagationProfileType m_profileType;

		// Token: 0x04009E01 RID: 40449
		[Token(Token = "0x4009E01")]
		[FieldOffset(Offset = "0x168")]
		private UIButton m_LastButton;

		// Token: 0x04009E02 RID: 40450
		[Token(Token = "0x4009E02")]
		[FieldOffset(Offset = "0x170")]
		private ELive.FollowerType m_CurrentType;

		// Token: 0x04009E03 RID: 40451
		[Token(Token = "0x4009E03")]
		[FieldOffset(Offset = "0x178")]
		private BaseItemInfo m_PinItemInfo;

		// Token: 0x04009E04 RID: 40452
		[Token(Token = "0x4009E04")]
		[FieldOffset(Offset = "0x180")]
		private List<GameObject> m_StarList;

		// Token: 0x04009E05 RID: 40453
		[Token(Token = "0x4009E05")]
		[FieldOffset(Offset = "0x188")]
		private List<GameObject> m_BlackStarList;

		// Token: 0x04009E06 RID: 40454
		[Token(Token = "0x4009E06")]
		[FieldOffset(Offset = "0x190")]
		private List<GameObject> m_HistoryStarList;

		// Token: 0x04009E07 RID: 40455
		[Token(Token = "0x4009E07")]
		[FieldOffset(Offset = "0x198")]
		private List<GameObject> m_HistoryBlackStarList;

		// Token: 0x04009E08 RID: 40456
		[Token(Token = "0x4009E08")]
		[FieldOffset(Offset = "0x1A0")]
		private UIStandardDrawerTabController m_TabCtrl;

		// Token: 0x04009E09 RID: 40457
		[Token(Token = "0x4009E09")]
		[FieldOffset(Offset = "0x1A8")]
		private bool m_BtnSettingState;

		// Token: 0x04009E0A RID: 40458
		[Token(Token = "0x4009E0A")]
		[FieldOffset(Offset = "0x1A9")]
		private bool m_BtnMarryState;

		// Token: 0x04009E0B RID: 40459
		[Token(Token = "0x4009E0B")]
		[FieldOffset(Offset = "0x1AA")]
		private bool m_BtnStreamingState;

		// Token: 0x04009E0C RID: 40460
		[Token(Token = "0x4009E0C")]
		[FieldOffset(Offset = "0x1AB")]
		private bool m_BtnAddfriendState;

		// Token: 0x04009E0D RID: 40461
		[Token(Token = "0x4009E0D")]
		[FieldOffset(Offset = "0x1AC")]
		private bool m_BtnShareBtnState;

		// Token: 0x04009E0E RID: 40462
		[Token(Token = "0x4009E0E")]
		[FieldOffset(Offset = "0x1AD")]
		private bool m_FightBrMenuState;

		// Token: 0x04009E0F RID: 40463
		[Token(Token = "0x4009E0F")]
		[FieldOffset(Offset = "0x1AE")]
		private bool m_FightCsMenuState;

		// Token: 0x04009E10 RID: 40464
		[Token(Token = "0x4009E10")]
		[FieldOffset(Offset = "0x1AF")]
		private bool m_Deslabel1State;

		// Token: 0x04009E11 RID: 40465
		[Token(Token = "0x4009E11")]
		[FieldOffset(Offset = "0x1B0")]
		private bool m_ProfileNodeALlShareState;

		// Token: 0x04009E12 RID: 40466
		[Token(Token = "0x4009E12")]
		[FieldOffset(Offset = "0x1B1")]
		private bool m_ProfileNodeRulteState;

		// Token: 0x04009E13 RID: 40467
		[Token(Token = "0x4009E13")]
		[FieldOffset(Offset = "0x1B2")]
		private bool isShowMarry;

		// Token: 0x04009E14 RID: 40468
		[Token(Token = "0x4009E14")]
		[FieldOffset(Offset = "0x1B3")]
		private bool isFromBoard;

		// Token: 0x04009E15 RID: 40469
		[Token(Token = "0x4009E15")]
		[FieldOffset(Offset = "0x1B8")]
		private UIPopMenuSmallControler m_ModeCsMenu;

		// Token: 0x04009E16 RID: 40470
		[Token(Token = "0x4009E16")]
		[FieldOffset(Offset = "0x1C0")]
		private UIPopMenuSmallControler m_ModeBrMenu;

		// Token: 0x04009E17 RID: 40471
		[Token(Token = "0x4009E17")]
		[FieldOffset(Offset = "0x1C8")]
		private string m_SelectBr;

		// Token: 0x04009E18 RID: 40472
		[Token(Token = "0x4009E18")]
		[FieldOffset(Offset = "0x1D0")]
		private string m_SelectCS;

		// Token: 0x04009E19 RID: 40473
		[Token(Token = "0x4009E19")]
		[FieldOffset(Offset = "0x1D8")]
		private List<PopMenuData> m_ModeBRMenuList;

		// Token: 0x04009E1A RID: 40474
		[Token(Token = "0x4009E1A")]
		[FieldOffset(Offset = "0x1E0")]
		private List<PopMenuData> m_ModeCSMenuList;

		// Token: 0x04009E1B RID: 40475
		[Token(Token = "0x4009E1B")]
		[FieldOffset(Offset = "0x1E8")]
		private List<string> m_ModeStrBRMenuList;

		// Token: 0x04009E1C RID: 40476
		[Token(Token = "0x4009E1C")]
		[FieldOffset(Offset = "0x1F0")]
		private List<string> m_ModeStrCSMenuList;

		// Token: 0x04009E1D RID: 40477
		[Token(Token = "0x4009E1D")]
		[FieldOffset(Offset = "0x1F8")]
		private List<UIProfileTagSmallController> m_SocialBiaoqianList;

		// Token: 0x04009E1E RID: 40478
		[Token(Token = "0x4009E1E")]
		[FieldOffset(Offset = "0x200")]
		private List<UIProfileTagSmallController> m_BattleBiaoqianList;

		// Token: 0x04009E1F RID: 40479
		[Token(Token = "0x4009E1F")]
		[FieldOffset(Offset = "0x208")]
		private List<PlayerBattleTagData> m_PlayerBattleTagDataList;

		// Token: 0x04009E20 RID: 40480
		[Token(Token = "0x4009E20")]
		[FieldOffset(Offset = "0x210")]
		private string m_Selectedhuoyue;

		// Token: 0x04009E21 RID: 40481
		[Token(Token = "0x4009E21")]
		[FieldOffset(Offset = "0x218")]
		private string m_SelectOnline;

		// Token: 0x04009E22 RID: 40482
		[Token(Token = "0x4009E22")]
		[FieldOffset(Offset = "0x220")]
		private string m_SelectModeLikes;

		// Token: 0x04009E23 RID: 40483
		[Token(Token = "0x4009E23")]
		[FieldOffset(Offset = "0x228")]
		private uint chooseDefaultMode;

		// Token: 0x04009E24 RID: 40484
		[Token(Token = "0x4009E24")]
		[FieldOffset(Offset = "0x230")]
		private MatchRecordPersonal m_MatchData;

		// Token: 0x04009E25 RID: 40485
		[Token(Token = "0x4009E25")]
		[FieldOffset(Offset = "0x238")]
		private string[] HistoryProfileItemAnimationArr;

		// Token: 0x04009E26 RID: 40486
		[Token(Token = "0x4009E26")]
		[FieldOffset(Offset = "0x240")]
		private List<Transform> HistoryProfileItemTranform;

		// Token: 0x04009E27 RID: 40487
		[Token(Token = "0x4009E27")]
		[FieldOffset(Offset = "0x248")]
		private Vector3 clonePos;

		// Token: 0x04009E28 RID: 40488
		[Token(Token = "0x4009E28")]
		[FieldOffset(Offset = "0x0")]
		private static List<string> UI3DOBJECT_NAMES;

		// Token: 0x04009E29 RID: 40489
		[Token(Token = "0x4009E29")]
		[FieldOffset(Offset = "0x254")]
		private UIUtils.ScreenshotType m_CurrentScreenshotType;

		// Token: 0x04009E2A RID: 40490
		[Token(Token = "0x4009E2A")]
		[FieldOffset(Offset = "0x258")]
		private GameObject m_CacheHeroicBREffect;

		// Token: 0x04009E2B RID: 40491
		[Token(Token = "0x4009E2B")]
		[FieldOffset(Offset = "0x260")]
		private GameObject m_CacheHeroicCSEffect;

		// Token: 0x02001B1E RID: 6942
		[Token(Token = "0x2001B1E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F94C4", Offset = "0x10F94C4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600949B RID: 38043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600949B")]
			[Address(RVA = "0x1B6659C", Offset = "0x1B6659C", VA = "0x7BBC36659C")]
			public <>c()
			{
			}

			// Token: 0x0600949C RID: 38044 RVA: 0x00027498 File Offset: 0x00025698
			[Token(Token = "0x600949C")]
			[Address(RVA = "0x1B665A4", Offset = "0x1B665A4", VA = "0x7BBC3665A4")]
			internal bool <ShowHistoryRecord>b__161_0(MatchRecordPersonal item)
			{
				return default(bool);
			}

			// Token: 0x0600949D RID: 38045 RVA: 0x000274B0 File Offset: 0x000256B0
			[Token(Token = "0x600949D")]
			[Address(RVA = "0x1B665D8", Offset = "0x1B665D8", VA = "0x7BBC3665D8")]
			internal bool <ShowHistoryRecord>b__161_1(MatchRecordPersonal item)
			{
				return default(bool);
			}

			// Token: 0x04009E2C RID: 40492
			[Token(Token = "0x4009E2C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIProfileController.<>c <>9;

			// Token: 0x04009E2D RID: 40493
			[Token(Token = "0x4009E2D")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<MatchRecordPersonal> <>9__161_0;

			// Token: 0x04009E2E RID: 40494
			[Token(Token = "0x4009E2E")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<MatchRecordPersonal> <>9__161_1;
		}
	}
}
