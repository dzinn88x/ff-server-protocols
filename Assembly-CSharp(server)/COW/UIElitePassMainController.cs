using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001798 RID: 6040
	[Token(Token = "0x2001798")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F25F4", Offset = "0x10F25F4")]
	public class UIElitePassMainController : UINavigationController, IEasyList, IUIModelDataChangeObserver
	{
		// Token: 0x060072F8 RID: 29432 RVA: 0x0001FF38 File Offset: 0x0001E138
		[Token(Token = "0x60072F8")]
		[Address(RVA = "0x1AE8D14", Offset = "0x1AE8D14", VA = "0x7BBC2E8D14")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060072F9 RID: 29433 RVA: 0x0001FF50 File Offset: 0x0001E150
		[Token(Token = "0x60072F9")]
		[Address(RVA = "0x1AE8D64", Offset = "0x1AE8D64", VA = "0x7BBC2E8D64", Slot = "34")]
		public override AdType GetBackgroundCDNImageType()
		{
			return AdType.AdType_NONE;
		}

		// Token: 0x060072FA RID: 29434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FA")]
		[Address(RVA = "0x1AE8D6C", Offset = "0x1AE8D6C", VA = "0x7BBC2E8D6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060072FB RID: 29435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FB")]
		[Address(RVA = "0x1AEA444", Offset = "0x1AEA444", VA = "0x7BBC2EA444", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060072FC RID: 29436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FC")]
		[Address(RVA = "0x1AE9270", Offset = "0x1AE9270", VA = "0x7BBC2E9270")]
		private void RegisterEvent()
		{
		}

		// Token: 0x060072FD RID: 29437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FD")]
		[Address(RVA = "0x1AEA46C", Offset = "0x1AEA46C", VA = "0x7BBC2EA46C")]
		private void UnRegisterEvent()
		{
		}

		// Token: 0x060072FE RID: 29438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FE")]
		[Address(RVA = "0x1AEA954", Offset = "0x1AEA954", VA = "0x7BBC2EA954")]
		private void Update()
		{
		}

		// Token: 0x060072FF RID: 29439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60072FF")]
		[Address(RVA = "0x1AEABA0", Offset = "0x1AEABA0", VA = "0x7BBC2EABA0", Slot = "28")]
		public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
		{
		}

		// Token: 0x06007300 RID: 29440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007300")]
		[Address(RVA = "0x1AEB64C", Offset = "0x1AEB64C", VA = "0x7BBC2EB64C", Slot = "29")]
		public override void OnNavigationClosed()
		{
		}

		// Token: 0x06007301 RID: 29441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007301")]
		[Address(RVA = "0x1AE9FC4", Offset = "0x1AE9FC4", VA = "0x7BBC2E9FC4")]
		public void UpdateFullScreenCG()
		{
		}

		// Token: 0x06007302 RID: 29442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x1AEB6E0", Offset = "0x1AEB6E0", VA = "0x7BBC2EB6E0")]
		private void OnClickClaimAllBtn()
		{
		}

		// Token: 0x06007303 RID: 29443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007303")]
		[Address(RVA = "0x1AEB710", Offset = "0x1AEB710", VA = "0x7BBC2EB710")]
		private void SetClaimAllBtn()
		{
		}

		// Token: 0x06007304 RID: 29444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007304")]
		[Address(RVA = "0x1AEB794", Offset = "0x1AEB794", VA = "0x7BBC2EB794")]
		private void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x06007305 RID: 29445 RVA: 0x0001FF68 File Offset: 0x0001E168
		[Token(Token = "0x6007305")]
		[Address(RVA = "0x1AEB82C", Offset = "0x1AEB82C", VA = "0x7BBC2EB82C", Slot = "32")]
		protected override bool NeedWaitDataReady()
		{
			return default(bool);
		}

		// Token: 0x06007306 RID: 29446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007306")]
		[Address(RVA = "0x1AEB834", Offset = "0x1AEB834", VA = "0x7BBC2EB834")]
		private void CheckEliteAward(uint id)
		{
		}

		// Token: 0x06007307 RID: 29447 RVA: 0x0001FF80 File Offset: 0x0001E180
		[Token(Token = "0x6007307")]
		[Address(RVA = "0x1AEBAC4", Offset = "0x1AEBAC4", VA = "0x7BBC2EBAC4", Slot = "33")]
		public override EFrontendUIType GetBackgroundImageType()
		{
			return EFrontendUIType.Lobby;
		}

		// Token: 0x06007308 RID: 29448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007308")]
		[Address(RVA = "0x1AEBACC", Offset = "0x1AEBACC", VA = "0x7BBC2EBACC")]
		private void OnClickGetBadgeByChallengeButton()
		{
		}

		// Token: 0x06007309 RID: 29449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007309")]
		[Address(RVA = "0x1AEBB48", Offset = "0x1AEBB48", VA = "0x7BBC2EBB48")]
		private void OnClickGetBadgeByPurchaseButton()
		{
		}

		// Token: 0x0600730A RID: 29450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730A")]
		[Address(RVA = "0x1AEBE5C", Offset = "0x1AEBE5C", VA = "0x7BBC2EBE5C")]
		private void OnClickBadgeRankingButton()
		{
		}

		// Token: 0x0600730B RID: 29451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730B")]
		[Address(RVA = "0x1AEBF00", Offset = "0x1AEBF00", VA = "0x7BBC2EBF00")]
		private void OnClickUpgradeEPButton()
		{
		}

		// Token: 0x0600730C RID: 29452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730C")]
		[Address(RVA = "0x1AEC1E0", Offset = "0x1AEC1E0", VA = "0x7BBC2EC1E0")]
		private void OnEPQuestBtn()
		{
		}

		// Token: 0x0600730D RID: 29453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730D")]
		[Address(RVA = "0x1AEC294", Offset = "0x1AEC294", VA = "0x7BBC2EC294")]
		private void OnSubscribedInfoButton()
		{
		}

		// Token: 0x0600730E RID: 29454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730E")]
		[Address(RVA = "0x1AEC334", Offset = "0x1AEC334", VA = "0x7BBC2EC334")]
		private void OnDocumentButton()
		{
		}

		// Token: 0x0600730F RID: 29455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600730F")]
		[Address(RVA = "0x1AEC4A0", Offset = "0x1AEC4A0", VA = "0x7BBC2EC4A0")]
		private void OnGetRewardItem(params object[] param)
		{
		}

		// Token: 0x06007310 RID: 29456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007310")]
		[Address(RVA = "0x1AEC588", Offset = "0x1AEC588", VA = "0x7BBC2EC588")]
		private void OnEPDataReady(params object[] param)
		{
		}

		// Token: 0x06007311 RID: 29457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007311")]
		[Address(RVA = "0x1AECF2C", Offset = "0x1AECF2C", VA = "0x7BBC2ECF2C")]
		private void UpdateBigRewardMark()
		{
		}

		// Token: 0x06007312 RID: 29458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007312")]
		[Address(RVA = "0x1AEE700", Offset = "0x1AEE700", VA = "0x7BBC2EE700")]
		private void CreateMarkBtn(Vector3 pos)
		{
		}

		// Token: 0x06007313 RID: 29459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007313")]
		[Address(RVA = "0x1AEE96C", Offset = "0x1AEE96C", VA = "0x7BBC2EE96C")]
		private void UpdateCurrentProgressMark()
		{
		}

		// Token: 0x06007314 RID: 29460 RVA: 0x0001FF98 File Offset: 0x0001E198
		[Token(Token = "0x6007314")]
		[Address(RVA = "0x1AEE12C", Offset = "0x1AEE12C", VA = "0x7BBC2EE12C")]
		private Vector3 MarkPosInPanelCenterForItemIndex(int index, int maxCount, float yPos)
		{
			return default(Vector3);
		}

		// Token: 0x06007315 RID: 29461 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[Token(Token = "0x6007315")]
		[Address(RVA = "0x1AEE060", Offset = "0x1AEE060", VA = "0x7BBC2EE060")]
		private int maxScrollViewGridCount()
		{
			return 0;
		}

		// Token: 0x06007316 RID: 29462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007316")]
		[Address(RVA = "0x1AED1F8", Offset = "0x1AED1F8", VA = "0x7BBC2ED1F8")]
		private void RefreshBtnState()
		{
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007317")]
		[Address(RVA = "0x1AEA15C", Offset = "0x1AEA15C", VA = "0x7BBC2EA15C")]
		private void InitBtnState()
		{
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007318")]
		[Address(RVA = "0x1AEEBAC", Offset = "0x1AEEBAC", VA = "0x7BBC2EEBAC")]
		private void OnClickBigAwardMark()
		{
		}

		// Token: 0x06007319 RID: 29465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007319")]
		[Address(RVA = "0x1AED4B0", Offset = "0x1AED4B0", VA = "0x7BBC2ED4B0")]
		private void SetBadgeCount()
		{
		}

		// Token: 0x0600731A RID: 29466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731A")]
		[Address(RVA = "0x1AED62C", Offset = "0x1AED62C", VA = "0x7BBC2ED62C")]
		private void SetPreorderBtn()
		{
		}

		// Token: 0x0600731B RID: 29467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731B")]
		[Address(RVA = "0x1AEF02C", Offset = "0x1AEF02C", VA = "0x7BBC2EF02C")]
		private void UpdateSubscriptionBonus()
		{
		}

		// Token: 0x0600731C RID: 29468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731C")]
		[Address(RVA = "0x1AEF1C0", Offset = "0x1AEF1C0", VA = "0x7BBC2EF1C0", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x0600731D RID: 29469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731D")]
		[Address(RVA = "0x1AEF47C", Offset = "0x1AEF47C", VA = "0x7BBC2EF47C")]
		private void ShowRewardItemAnim()
		{
		}

		// Token: 0x0600731E RID: 29470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731E")]
		[Address(RVA = "0x1AEF31C", Offset = "0x1AEF31C", VA = "0x7BBC2EF31C")]
		private void ClearDelayCalls()
		{
		}

		// Token: 0x0600731F RID: 29471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600731F")]
		[Address(RVA = "0x1AEF8DC", Offset = "0x1AEF8DC", VA = "0x7BBC2EF8DC")]
		private void OnEPUpdateReward(params object[] param)
		{
		}

		// Token: 0x06007320 RID: 29472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007320")]
		[Address(RVA = "0x1AEF8E4", Offset = "0x1AEF8E4", VA = "0x7BBC2EF8E4")]
		private void OnEPBadgeChange(params object[] param)
		{
		}

		// Token: 0x06007321 RID: 29473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007321")]
		[Address(RVA = "0x1AECB6C", Offset = "0x1AECB6C", VA = "0x7BBC2ECB6C")]
		private void RefreshEasyList(bool needScroll)
		{
		}

		// Token: 0x06007322 RID: 29474 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[Token(Token = "0x6007322")]
		[Address(RVA = "0x1AEEA6C", Offset = "0x1AEEA6C", VA = "0x7BBC2EEA6C")]
		private int CurProgressIndex()
		{
			return 0;
		}

		// Token: 0x06007323 RID: 29475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007323")]
		[Address(RVA = "0x1AEB158", Offset = "0x1AEB158", VA = "0x7BBC2EB158")]
		public void SetCDNTexture(params object[] data)
		{
		}

		// Token: 0x06007324 RID: 29476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007324")]
		[Address(RVA = "0x1AEDEFC", Offset = "0x1AEDEFC", VA = "0x7BBC2EDEFC")]
		public void ShowFullScreenCG()
		{
		}

		// Token: 0x06007325 RID: 29477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007325")]
		[Address(RVA = "0x1AEF914", Offset = "0x1AEF914", VA = "0x7BBC2EF914")]
		private void OnPreviewItem(params object[] param)
		{
		}

		// Token: 0x06007326 RID: 29478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007326")]
		[Address(RVA = "0x1AF04CC", Offset = "0x1AF04CC", VA = "0x7BBC2F04CC")]
		private void OnReviewMaxReward(params object[] param)
		{
		}

		// Token: 0x06007327 RID: 29479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007327")]
		[Address(RVA = "0x1AEFFA0", Offset = "0x1AEFFA0", VA = "0x7BBC2EFFA0")]
		private void UpdateEPTipsStatus(int badgeCnt, bool isEP)
		{
		}

		// Token: 0x06007328 RID: 29480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x1AF0810", Offset = "0x1AF0810", VA = "0x7BBC2F0810")]
		private void OnClickPrivilegeBtn()
		{
		}

		// Token: 0x06007329 RID: 29481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007329")]
		[Address(RVA = "0x1AF08B0", Offset = "0x1AF08B0", VA = "0x7BBC2F08B0")]
		private void OnClickPreorderBtn()
		{
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732A")]
		[Address(RVA = "0x1AF092C", Offset = "0x1AF092C", VA = "0x7BBC2F092C")]
		private void OnClickAnimPlayBtn()
		{
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732B")]
		[Address(RVA = "0x1AF0930", Offset = "0x1AF0930", VA = "0x7BBC2F0930")]
		private void onClickVideoBtn()
		{
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600732C")]
		[Address(RVA = "0x1AF0AA4", Offset = "0x1AF0AA4", VA = "0x7BBC2F0AA4", Slot = "39")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732D")]
		[Address(RVA = "0x1AF0B38", Offset = "0x1AF0B38", VA = "0x7BBC2F0B38", Slot = "40")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600732E")]
		[Address(RVA = "0x1AF0B68", Offset = "0x1AF0B68", VA = "0x7BBC2F0B68", Slot = "41")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		[Token(Token = "0x600732F")]
		[Address(RVA = "0x1AF0E80", Offset = "0x1AF0E80", VA = "0x7BBC2F0E80", Slot = "42")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007330")]
		[Address(RVA = "0x1AEFF04", Offset = "0x1AEFF04", VA = "0x7BBC2EFF04")]
		private void InitShowBoostAvatarParams()
		{
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007331")]
		[Address(RVA = "0x1AF0EE4", Offset = "0x1AF0EE4", VA = "0x7BBC2F0EE4")]
		private void OnClickSubscribeEPBtn()
		{
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007332")]
		[Address(RVA = "0x1AF1030", Offset = "0x1AF1030", VA = "0x7BBC2F1030")]
		private void OnClickSubscribeHintBtn()
		{
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007333")]
		[Address(RVA = "0x1AF10C8", Offset = "0x1AF10C8", VA = "0x7BBC2F10C8")]
		private void OnClickBadgeIcon()
		{
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007334")]
		[Address(RVA = "0x1AF10CC", Offset = "0x1AF10CC", VA = "0x7BBC2F10CC")]
		private void OnPreorderSuccess(object[] data)
		{
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007335")]
		[Address(RVA = "0x1AF10D0", Offset = "0x1AF10D0", VA = "0x7BBC2F10D0")]
		private void OnMaxRewardClaimed(object[] data)
		{
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007336")]
		[Address(RVA = "0x1AF10D8", Offset = "0x1AF10D8", VA = "0x7BBC2F10D8")]
		private void GoToEPWebSite()
		{
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007337")]
		[Address(RVA = "0x1AF1120", Offset = "0x1AF1120", VA = "0x7BBC2F1120")]
		private void OnMapModeSelected(object[] param)
		{
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007338")]
		[Address(RVA = "0x1AEEE80", Offset = "0x1AEEE80", VA = "0x7BBC2EEE80")]
		private void AutoShowEPPreorderNavi()
		{
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007339")]
		[Address(RVA = "0x1AF11A0", Offset = "0x1AF11A0", VA = "0x7BBC2F11A0")]
		private void OnCgClose(object[] param)
		{
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		[Token(Token = "0x600733A")]
		[Address(RVA = "0x1AF11A4", Offset = "0x1AF11A4", VA = "0x7BBC2F11A4")]
		private bool NeedAutoShowPreorderNavi()
		{
			return default(bool);
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733B")]
		[Address(RVA = "0x1AF1398", Offset = "0x1AF1398", VA = "0x7BBC2F1398")]
		public UIElitePassMainController()
		{
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733C")]
		[Address(RVA = "0x1AF1468", Offset = "0x1AF1468", VA = "0x7BBC2F1468")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11419A0", Offset = "0x11419A0")]
		private void <OnUIInit>b__17_0()
		{
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733D")]
		[Address(RVA = "0x1AF15C4", Offset = "0x1AF15C4", VA = "0x7BBC2F15C4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11419B0", Offset = "0x11419B0")]
		private void <OnVisibilityChanged>b__52_0()
		{
		}

		// Token: 0x04008BBE RID: 35774
		[Token(Token = "0x4008BBE")]
		[FieldOffset(Offset = "0xB0")]
		private UIElitePassMainWindowView m_View;

		// Token: 0x04008BBF RID: 35775
		[Token(Token = "0x4008BBF")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelElitePass m_ModelEP;

		// Token: 0x04008BC0 RID: 35776
		[Token(Token = "0x4008BC0")]
		[FieldOffset(Offset = "0xC0")]
		private UIModelProfile m_ModelProfile;

		// Token: 0x04008BC1 RID: 35777
		[Token(Token = "0x4008BC1")]
		[FieldOffset(Offset = "0xC8")]
		private bool isDataReady;

		// Token: 0x04008BC2 RID: 35778
		[Token(Token = "0x4008BC2")]
		[FieldOffset(Offset = "0xC9")]
		private bool isDataChanged;

		// Token: 0x04008BC3 RID: 35779
		[Token(Token = "0x4008BC3")]
		[FieldOffset(Offset = "0xD0")]
		private string EPWebSiteUrl;

		// Token: 0x04008BC4 RID: 35780
		[Token(Token = "0x4008BC4")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_TmpPurchaseBadgeCnt;

		// Token: 0x04008BC5 RID: 35781
		[Token(Token = "0x4008BC5")]
		[FieldOffset(Offset = "0xDC")]
		private uint m_ElitePassItemId;

		// Token: 0x04008BC6 RID: 35782
		[Token(Token = "0x4008BC6")]
		[FieldOffset(Offset = "0xE0")]
		private FullscreenCgDesc m_CurEPFullScreenCG;

		// Token: 0x04008BC7 RID: 35783
		[Token(Token = "0x4008BC7")]
		[FieldOffset(Offset = "0xE8")]
		private List<UIButton> m_BigAwardMarkCacheList;

		// Token: 0x04008BC8 RID: 35784
		[Token(Token = "0x4008BC8")]
		[FieldOffset(Offset = "0xF0")]
		private List<UIButton> m_CurrentBigAwardButtonList;

		// Token: 0x04008BC9 RID: 35785
		[Token(Token = "0x4008BC9")]
		[FieldOffset(Offset = "0xF8")]
		private ShowBoostAvatarParams m_ShowBoostAvatarParams;

		// Token: 0x04008BCA RID: 35786
		[Token(Token = "0x4008BCA")]
		[FieldOffset(Offset = "0x100")]
		private UIGuideTipsController m_GuideTipsCtrl;

		// Token: 0x04008BCB RID: 35787
		[Token(Token = "0x4008BCB")]
		[FieldOffset(Offset = "0x108")]
		private float m_PreviewX;

		// Token: 0x04008BCC RID: 35788
		[Token(Token = "0x4008BCC")]
		[FieldOffset(Offset = "0x110")]
		private UICountDownController m_CDControler;

		// Token: 0x04008BCD RID: 35789
		[Token(Token = "0x4008BCD")]
		private const string HAS_SEEN_SUBSCRIPTION_PREF_KEY = "HasSeenElitePassSubscription";

		// Token: 0x04008BCE RID: 35790
		[Token(Token = "0x4008BCE")]
		[FieldOffset(Offset = "0x118")]
		private List<uint> m_AnimDelayCalls;

		// Token: 0x02001799 RID: 6041
		[Token(Token = "0x2001799")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F262C", Offset = "0x10F262C")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x0600733E RID: 29502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600733E")]
			[Address(RVA = "0x1E66B98", Offset = "0x1E66B98", VA = "0x7BBC666B98")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x0600733F RID: 29503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600733F")]
			[Address(RVA = "0x1E66BA0", Offset = "0x1E66BA0", VA = "0x7BBC666BA0")]
			internal void <ShowRewardItemAnim>b__1()
			{
			}

			// Token: 0x04008BCF RID: 35791
			[Token(Token = "0x4008BCF")]
			[FieldOffset(Offset = "0x10")]
			public UIElitePassRewardItemController item;
		}

		// Token: 0x0200179A RID: 6042
		[Token(Token = "0x200179A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F263C", Offset = "0x10F263C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007341 RID: 29505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007341")]
			[Address(RVA = "0x1E669D4", Offset = "0x1E669D4", VA = "0x7BBC6669D4")]
			public <>c()
			{
			}

			// Token: 0x06007342 RID: 29506 RVA: 0x00020010 File Offset: 0x0001E210
			[Token(Token = "0x6007342")]
			[Address(RVA = "0x1E669DC", Offset = "0x1E669DC", VA = "0x7BBC6669DC")]
			internal int <ShowRewardItemAnim>b__54_0(UIElitePassRewardItemController x, UIElitePassRewardItemController y)
			{
				return 0;
			}

			// Token: 0x06007343 RID: 29507 RVA: 0x00020028 File Offset: 0x0001E228
			[Token(Token = "0x6007343")]
			[Address(RVA = "0x1E66A4C", Offset = "0x1E66A4C", VA = "0x7BBC666A4C")]
			internal bool <SetCDNTexture>b__60_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x06007344 RID: 29508 RVA: 0x00020040 File Offset: 0x0001E240
			[Token(Token = "0x6007344")]
			[Address(RVA = "0x1E66A80", Offset = "0x1E66A80", VA = "0x7BBC666A80")]
			internal bool <SetCDNTexture>b__60_1(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x06007345 RID: 29509 RVA: 0x00020058 File Offset: 0x0001E258
			[Token(Token = "0x6007345")]
			[Address(RVA = "0x1E66AB4", Offset = "0x1E66AB4", VA = "0x7BBC666AB4")]
			internal bool <SetCDNTexture>b__60_2(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x06007346 RID: 29510 RVA: 0x00020070 File Offset: 0x0001E270
			[Token(Token = "0x6007346")]
			[Address(RVA = "0x1E66AE8", Offset = "0x1E66AE8", VA = "0x7BBC666AE8")]
			internal bool <SetCDNTexture>b__60_3(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x06007347 RID: 29511 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007347")]
			[Address(RVA = "0x1E66B1C", Offset = "0x1E66B1C", VA = "0x7BBC666B1C")]
			internal void <AutoShowEPPreorderNavi>b__81_0()
			{
			}

			// Token: 0x04008BD0 RID: 35792
			[Token(Token = "0x4008BD0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIElitePassMainController.<>c <>9;

			// Token: 0x04008BD1 RID: 35793
			[Token(Token = "0x4008BD1")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<UIElitePassRewardItemController> <>9__54_0;

			// Token: 0x04008BD2 RID: 35794
			[Token(Token = "0x4008BD2")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<AdvertDesc> <>9__60_0;

			// Token: 0x04008BD3 RID: 35795
			[Token(Token = "0x4008BD3")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<AdvertDesc> <>9__60_1;

			// Token: 0x04008BD4 RID: 35796
			[Token(Token = "0x4008BD4")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<AdvertDesc> <>9__60_2;

			// Token: 0x04008BD5 RID: 35797
			[Token(Token = "0x4008BD5")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<AdvertDesc> <>9__60_3;

			// Token: 0x04008BD6 RID: 35798
			[Token(Token = "0x4008BD6")]
			[FieldOffset(Offset = "0x30")]
			public static Action <>9__81_0;
		}
	}
}
